using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Net;
using System.Windows;
using dLibAdJobs;
using dLibCypherJobs;
using dLibProcessMng;

using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;
using sysOps;
using System.Runtime.InteropServices;
using genEx;
using System.Timers;
using Simple_AD_Browser_Helpers;
using dLibSeekerSessions;

namespace Seeker
{
    public partial class frmSeekComputer : Form
    {
        public frmSeekComputer()
        {
            InitializeComponent();
        }

        //Main Vars
        public string machineToQuery { get; set; }

        dLibAd.adComputers computerToUpdate;
        seekerObjects adComputerObject = new seekerObjects();     

        //Cached Queries
        Boolean cachedGroups = false;

        private void frmSeekComputer_Load(object sender, EventArgs e)
        {
            //Tags form with Seeker object that is being searched---
            adComputerObject.Type = seekerObjectType.AD_Computer;
            adComputerObject.QueryData = machineToQuery;
            this.Tag = adComputerObject;
            //-------------------------------------------------------

            //Start query
            queryComputer(machineToQuery);
            //-----------------------------------------------------
        }


        #region Seeking Logic
        private void queryComputer(string computer)
        {
            this.Text = machineToQuery;            
            computerToUpdate = dLibAd.adComputerDetailsFinder(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), machineToQuery);

            lblMachineName.Text = computerToUpdate.Name;
            lblMachineOS.Text = computerToUpdate.OS;
            lblMachineDN.Text = computerToUpdate.DN;
            lblMachineChangedDate.Text = computerToUpdate.ChangedDate;
            lblMachineCreationDate.Text = computerToUpdate.CreationDate;
            lblLapsExpDate.Text = computerToUpdate.LapPASExpirationDate;

            //Machine Process-----------------------------------------------------------------          
            try
            {
                findMachineProcess(machineToQuery, dGridMachineProcess);
            }
            catch (Exception noAccess)
            {
                if (noAccess.ToString().ToLower().Contains("denied"))
                {
                    MessageBox.Show("Sorry, but you don't have admin rights on this machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //--------------------------------------------------------------------------------
        }

        private DataTable findMachineProcess(string machine, DataGridView dGridProcess)
        {
            Thread thGetMachineProcess;
            DataTable dt = new DataTable();
            thGetMachineProcess = new Thread(() =>
            {
                dt = getMachineProcess(machine);
                if ((dt != null) && (dt.Rows.Count > 0))
                {
                    try
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            dGridProcess.DataSource = dt;
                            dGridProcess.Sort(dGridProcess.Columns[1], ListSortDirection.Ascending);
                        });
                    }
                    catch { }
                }
            });
            thGetMachineProcess.Start();
            return dt;
        }        

        private DataTable getMachineProcess(string machine)
        {
            DataTable dt = new DataTable();
            dLibProcess machData = new dLibProcess();
            dt = machData.findProcess(machine, frmMain.domainAccountData[0] + @"\" + frmMain.domainAccountData[1], frmMain.domainAccountData[2]);
            return dt;
        }
        #endregion             

        private void tbpMemberOf_Enter(object sender, EventArgs e)
        {
            if (!cachedGroups)
            {
                computerToUpdate.Groups = dLibAd.adComputerGroups(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]),machineToQuery);
                int counter = 0;
                computerToUpdate.Groups.ForEach(delegate(dLibAd.adGroups s)
                {
                    ListViewItem computerGroup = new ListViewItem();
                    if (lViewResults.Items.Count % 2 != 0)
                        computerGroup.BackColor = Color.White;
                    else
                        computerGroup.BackColor = Color.WhiteSmoke;

                    computerGroup.Text = s.Name;
                    string formatedGroup = "";
                    if ((s.DN != null) && (s.DN != string.Empty))
                    {
                        formatedGroup = s.DN.Replace("CN=", string.Empty).Replace("DC=", string.Empty).Replace("OU=", string.Empty).Replace(",", "/");
                        computerGroup.SubItems.Add(formatedGroup);
                        lViewResults.Items.Add(computerGroup);
                        counter++;
                    }

                });
                cachedGroups = true;
            }
        }
        
        private void lblMachineName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((sender as Label) != null)
            {
                (sender as Label).ForeColor = Color.Green;
                dLibClipboardJObs.dLibCopyToClipboard.ClipboardHelper.CopyToClipboard((sender as Label).Text, (sender as Label).Text);
            }
        }

        private void tbpAdvanced_Enter(object sender, EventArgs e)
        {
            Thread thloadAdvanced = new Thread(() =>
            {
                try
                {
                    Thread.CurrentThread.Name = "thloadAdvanced";
                    this.Invoke((MethodInvoker)delegate { pBoxProgressAdvanced.Visible = true; });

                    ADLib LdapHelper = new ADLib();
                    ComputerPrincipal computer = ComputerPrincipal.FindByIdentity(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), this.machineToQuery);
                    System.DirectoryServices.DirectoryEntry underField = computer.GetUnderlyingObject() as System.DirectoryServices.DirectoryEntry;
                    DataTable advancedData = LdapHelper.FillDataTableFromADContainer(underField);
                    this.Invoke((MethodInvoker)delegate
                    {
                        dGridAdvanced.DataSource = advancedData;
                        dGridAdvanced.Columns[1].Width = 300;
                        pBoxProgressAdvanced.Visible = false;
                    });

                }
                catch { Thread.CurrentThread.Abort(); }
            });
            thloadAdvanced.Start();
        }

        private void btnGetLapsPass_Click(object sender, EventArgs e)
        {
            string ticketNumber = "";

            DialogResult dlgGetPass = MessageBox.Show("Clicking on Yes you'll receive Admin account password for machine " + this.machineToQuery + ". This access will be logged. Do you want to procced ?", "Do you want to procced ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgGetPass == DialogResult.Yes)
            {
                computerToUpdate.LapPASExpirationDate = DateTime.Now.ToString();

                using (var form = new frmInputDialog())
                {
                    form.inputDataAsk = "Please fill with your authorization number(for audit purposes)";
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        ticketNumber = form.returnInputData;
                    }
                }
                computerToUpdate.SerialNumber = Environment.UserName + "," + ticketNumber + "," + DateTime.Now;


                try
                {
                    computerToUpdate.updateComputer();
                    btnGetLapsPass.Enabled = false;
                    lblLapsPasswordData.Text = computerToUpdate.LapPAS;
                    lblLapsPassNotice.Text = "Expires in 90minutes...";

                    lblLapsExpDate.Text = computerToUpdate.LapPASExpirationDate;
                    lblLapsExpDateNotice.Text = "Flagged for change!";
                }
                catch (Exception permissionError)
                {
                    if (permissionError.ToString().ToLower().Contains("denied"))
                    {
                        MessageBox.Show("Sorry, but you are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void tbMachineDetails_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void frmSeekComputer_Resize(object sender, EventArgs e)
        {
            splitMain.Panel2Collapsed = false;
            splitMain.SplitterDistance = 300;
        }

        private void frmSeekComputer_Move(object sender, EventArgs e)
        {
            adComputerObject.ScreenPos = new System.Drawing.Point(this.Location.X, this.Location.Y);
            this.Tag = adComputerObject;
        }

        private void btnCollectObject_Click(object sender, EventArgs e)
        {
            using (var form = new frmSessionManager())
            {
                form.insertObjectIntSessionMode = true;
                form.seekerObjectToInsertIntoSession = adComputerObject;
                form.ShowDialog();
            }
        }

        private void btnCopyUserData_Click(object sender, EventArgs e)
        {
            StringBuilder txtData = new StringBuilder();
            txtData.Append("Name: " + computerToUpdate.Name + Environment.NewLine);
            txtData.Append("O.S: " + computerToUpdate.OS + Environment.NewLine);
            txtData.Append("DN: " + computerToUpdate.DN + Environment.NewLine);
            txtData.Append("Creation Date: " + computerToUpdate.CreationDate + Environment.NewLine);
            txtData.Append("Changed Date:" + computerToUpdate.ChangedDate + Environment.NewLine);            
            dLibClipboardJObs.dLibCopyToClipboard.ClipboardHelper.CopyToClipboard(txtData.ToString(), txtData.ToString());
        }
    }
}
