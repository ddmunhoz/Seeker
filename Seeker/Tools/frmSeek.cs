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
using dLibClipboardJObs;
using System.Diagnostics.Eventing.Reader;
using System.Security;
using System.Globalization;
using Simple_AD_Browser_Helpers;
using dLibSeekerSessions;


namespace Seeker
{
    public partial class frmSeek : Form
    {
        public string userToQuery { get; set; }

        dLibAd adquery = new dLibAd();
        dLibAd.adUsers usrToUpdate;
        seekerObjects adUserObject = new seekerObjects();        

        //Cached Queries
        Boolean cachedGroups = false;


        //Get Control Items Xthread------------------------------------------------------
        private delegate ListView.ListViewItemCollection GetItems(ListView lstview);
        private ListView.ListViewItemCollection getListViewItems(ListView lstview)
        {
            ListView.ListViewItemCollection temp = new ListView.ListViewItemCollection(new ListView());
            if (!lstview.InvokeRequired)
            {
                foreach (ListViewItem item in lstview.SelectedItems)
                    temp.Add((ListViewItem)item.Clone());
                return temp;
            }
            else
                return (ListView.ListViewItemCollection)this.Invoke(new GetItems(getListViewItems), new object[] { lstview });
        }
        //-------------------------------------------------------------------------------

        public frmSeek()
        {
            InitializeComponent();
        }

        private void frmSeek_Load(object sender, EventArgs e)
        {
            //Tags form with Seeker object that is being searched---
            adUserObject.Type = seekerObjectType.AD_User;
            adUserObject.QueryData = userToQuery;
            this.Tag = adUserObject;
            //------------------------------------------------------

            //Load central imagelist from Main form
            lvUserGroups.SmallImageList = frmMain.objTypeOmgList;
            //------------------------------------------------------

            //Start query
            queryUser(this.userToQuery);
            //------------------------------------------------------
        }


        #region UI
        public void ClearFileds()
        {
            placeHolderFullName.Text = "";
            lblPs.Text = "";
            lblAccount.Text = "";
            lvUserGroups.Items.Clear();
            lblLocation.Text = "";
            lblDivision.Text = "";
            lblPhone.Text = "";
            pEmployee.Image = null;
            lblFirstName.Text = "";
            lblLastName.Text = "";
            lblFullName.Text = "";
            lblMail.Text = "";
            pEmployee.Image = Seeker.Properties.Resources.usrPhoto;
        }

        private void updateProgress(bool state)
        {
            switch (state)
            {
                case true:
                    pBoxProgress.Visible = true;
                    ckBoxNested.Enabled = false;
                    btnAdd.Enabled = false;
                    break;
                case false:
                    pBoxProgress.Visible = false;
                    ckBoxNested.Enabled = true;
                    btnAdd.Enabled = true;
                    break;
            }
        }

        private void btnCopyUserData_Click(object sender, EventArgs e)
        {
            StringBuilder txtData = new StringBuilder();
            txtData.Append("Account: " + usrToUpdate.Account + Environment.NewLine);
            txtData.Append("Status: " + usrToUpdate.Status + Environment.NewLine);
            txtData.Append("First Name: " + usrToUpdate.FirstName + Environment.NewLine);
            txtData.Append("Last Name: " + usrToUpdate.LastName + Environment.NewLine);
            txtData.Append("Full Name: " + usrToUpdate.DisplayName + Environment.NewLine);
            txtData.Append("E-Mail: " + usrToUpdate.Email + Environment.NewLine);
            txtData.Append("Department: " + usrToUpdate.Division + Environment.NewLine);
            txtData.Append("Location: " + usrToUpdate.Location + Environment.NewLine);
            txtData.Append("Phone: " + usrToUpdate.Phone + Environment.NewLine);
            txtData.Append("Creation: " + "" + usrToUpdate.CreationDate + Environment.NewLine);
            txtData.Append("Changed " + "" + usrToUpdate.ChangedDate + Environment.NewLine);
            txtData.Append("Last Bad Password: " + usrToUpdate.LastBadPasswordAttempt + Environment.NewLine);
            txtData.Append("Last Password Set: " + usrToUpdate.LastPasswordChange + Environment.NewLine);
            dLibClipboardJObs.dLibCopyToClipboard.ClipboardHelper.CopyToClipboard(txtData.ToString(), txtData.ToString());
        }

        private void frmSeek_Move(object sender, EventArgs e)
        {
            adUserObject.ScreenPos = new System.Drawing.Point(this.Location.X, this.Location.Y);
            this.Tag = adUserObject;
        }

        #endregion


        #region Seeking Logic
        private void queryUser(string user)
        {
            ClearFileds();
            usrToUpdate = dLibAd.locateUsr(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), user);
            if (usrToUpdate != null)
            {
                this.Text = "";
                lblAccount.Text = usrToUpdate.Account;
                lblFirstName.Text = usrToUpdate.FirstName;
                lblLastName.Text = usrToUpdate.LastName;
                lblFullName.Text = usrToUpdate.DisplayName;
                lblMail.Text = usrToUpdate.Email;
                pEmployee.Image = usrToUpdate.Photo;
                lblLocation.Text = usrToUpdate.Location;
                lblDivision.Text = usrToUpdate.Division;
                lblPhone.Text = usrToUpdate.Phone;
                lblCreationDate.Text = usrToUpdate.CreationDate;
                lblChangedDate.Text = usrToUpdate.ChangedDate;
                if (usrToUpdate.Status.Contains("Locked"))
                {
                    lblAccountStatus.ForeColor = Color.Red;
                }
                else { lblAccountStatus.ForeColor = Color.Blue; }
                lblAccountStatus.Text = usrToUpdate.Status;
                lblLastBadPassword.Text = usrToUpdate.LastBadPasswordAttempt.ToString();
                lblLastPasswordChange.Text = usrToUpdate.LastPasswordChange.ToString();
                this.Text = usrToUpdate.Account;

            }
        }

        private void queryUserGroups(bool nested)
        {
            if (!cachedGroups)
            {
                updateProgress(true);
                lvUserGroups.Items.Clear();
                Thread thloadUserGroups = new Thread(() =>
                {
                    Thread.CurrentThread.Name = "thloadUserGroups";
                    List<dLibAd.adGroups> landList = new List<dLibAd.adGroups>();
                    landList = null;
                    usrToUpdate.Groups = null;
                    usrToUpdate.Groups = dLibAd.adObjectGroups(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), usrToUpdate.Account, adObjectType.User, false).OrderBy(o => o.Name).ToList();

                    if (nested)
                    {
                        landList = dLibAd.adObjectGroups(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), usrToUpdate.Account, adObjectType.User, nested).OrderBy(o => o.Name).ToList();
                    }
                    else
                    {
                        landList = dLibAd.adObjectGroups(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), usrToUpdate.Account, adObjectType.User, nested).OrderBy(o => o.Name).ToList();
                    }

                    int counter = 0;

                    this.Invoke((MethodInvoker)delegate { lvUserGroups.BeginUpdate(); });
                    landList.ForEach(delegate(dLibAd.adGroups s)
                    {
                        ListViewItem userGroup = new ListViewItem();
                        if ((nested) && (usrToUpdate.Groups != null) && (usrToUpdate.Groups.Count > 0))
                        {
                            if (!usrToUpdate.Groups.Select(g => g.SammAccountName).Contains(s.SammAccountName))
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    userGroup.BackColor = Color.SandyBrown;
                                });
                            }
                        }
                        else
                        {
                            if (lvUserGroups.Items.Count % 2 != 0)
                                userGroup.BackColor = Color.White;
                            else
                                userGroup.BackColor = Color.WhiteSmoke;
                        }

                        userGroup.ImageIndex = 10;
                        userGroup.Text = s.Name;
                        userGroup.Tag = s;
                        string formatedGroup = "";
                        if ((s.DN != null) && (s.DN != string.Empty))
                        {
                            string userDN = s.DN.Substring(s.DN.IndexOf(',') + 1, s.DN.Length - (s.DN.IndexOf(',') + 1));
                            formatedGroup = userDN.Replace("CN=", string.Empty).Replace("DC=", string.Empty).Replace("OU=", string.Empty).Replace(",", "/");
                        }
                        userGroup.SubItems.Add(s.SammAccountName);
                        userGroup.SubItems.Add(formatedGroup);
                        try
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lvUserGroups.Items.Add(userGroup);
                            });
                        }
                        catch { Thread.CurrentThread.Abort(); }
                        counter++;
                    });
                    cachedGroups = true;
                    this.Invoke((MethodInvoker)delegate
                    {
                        updateProgress(false);
                        lvUserGroups.EndUpdate();
                    });
                });
                thloadUserGroups.Start();
            }
        }
        #endregion


        private void lblAccount_MouseDoubleClick(object sender, MouseEventArgs e)
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
                    UserPrincipal usr = UserPrincipal.FindByIdentity(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), this.userToQuery);
                    System.DirectoryServices.DirectoryEntry underField = usr.GetUnderlyingObject() as System.DirectoryServices.DirectoryEntry;
                    DataTable advancedData = LdapHelper.FillDataTableFromADContainer(underField);
                    this.Invoke((MethodInvoker)delegate
                    {
                        dGridAdvanced.DataSource = advancedData;
                        dGridAdvanced.Columns[1].Width = 350;
                        pBoxProgressAdvanced.Visible = false;
                    });

                }
                catch { Thread.CurrentThread.Abort(); }
            });
            thloadAdvanced.Start();
        }           

        private void tbpMemberOf_Enter(object sender, EventArgs e)
        {
            queryUserGroups(false);
        }

        private void ckBoxNested_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxNested.Checked == true)
            {
                cachedGroups = false;
                ckBoxNested.Checked = true;
                queryUserGroups(true);
                btnRemove.Enabled = false;
            }
            else
            {
                cachedGroups = false;
                ckBoxNested.Checked = false;
                queryUserGroups(false);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure ?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                if (lvUserGroups.SelectedItems.Count > 0)
                {
                    updateProgress(true);
                    foreach (ListViewItem item in lvUserGroups.SelectedItems)
                    {
                        Thread thRemoveObjectsFromUser = new Thread(() =>
                        {
                            Thread.CurrentThread.Name = "thRemoveObjectsFromUser";
                            dLibAd.adGroups selectedGroup = (item.Tag as dLibAd.adGroups);
                            dLibAd.RemoveMemberFromGroup(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), selectedGroup.SammAccountName, usrToUpdate.Account);
                            try
                            {
                                this.Invoke((MethodInvoker)delegate { lvUserGroups.Items.Remove(item); });
                            }
                            catch { Thread.CurrentThread.Abort(); }
                        });
                        thRemoveObjectsFromUser.Start();
                    }
                    updateProgress(false);
                    cachedGroups = false;
                    queryUserGroups(false);
                }
            }
        }

        private void lvUserGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lvUserGroups.SelectedItems.Count > 0) && (ckBoxNested.Checked == false))
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new frmSearchDialog())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    updateProgress(true);
                    Thread thAddObjectsToUser = new Thread(() =>
                    {
                        Thread.CurrentThread.Name = "thAddObjectsToUser";
                        var tagsToLoad = form.returnObjectsTags;
                        foreach (var tag in tagsToLoad)
                        {
                            string[] tagArray = tag.ToString().Split(',');
                            PrincipalContext context = new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]);
                            dLibAd.AddMemberToGroup(tagArray[0], context, usrToUpdate.Account, context, adObjectType.User);

                        }
                        try
                        {
                            this.Invoke((MethodInvoker)delegate { updateProgress(false); cachedGroups = false; queryUserGroups(false); });
                        }
                        catch { Thread.CurrentThread.Abort(); }
                    });
                    thAddObjectsToUser.Start();
                }
            }

        }

        private void lvUserGroups_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvUserGroups.SelectedItems.Count == 1)
                {
                    foreach (ListViewItem item in lvUserGroups.SelectedItems)
                    {
                        frmMain.sharedcMenuSeekGroup.Tag = (item.Tag as dLibAd.adGroups).SammAccountName;
                        frmMain.sharedcMenuSeekGroup.Show(MousePosition);
                    }
                }
            }
        }

        private void pEmployee_Click(object sender, EventArgs e)
        {
            Form form = new Form();

            form.Width = 250;
            form.Height = 300;
            form.MdiParent = this.ParentForm;

            PictureBox pic = new PictureBox();
            pic.Dock = DockStyle.Fill;
            pic.Image = pEmployee.Image;
            pic.SizeMode = PictureBoxSizeMode.Zoom;

            pic.Click += new EventHandler((object s, EventArgs ex) =>
            {
                // frmSeek newSeek = new frmSeek();
                //newSeek.txtBoxUser.Text = Regex.Match(usrToSeek, @"\d+").Value;
                //newSeek.Show();
                //newSeek.btnBuscar.PerformClick();
            }); ;
            form.Text = this.Text;
            form.Controls.Add(pic);
            form.Show();
        }


        //Deprecated-------------------------------------------------------------------------------------
        private DataTable querySecHistoricSQLScom(string iUser, int nOFDays)
        {
            //DataTable queryResult = new DataTable();
            //StringBuilder query = new StringBuilder();
            //query.Append("SELECT ");
            //query.Append(" cast([EventId] as char) as 'Action'");
            //query.Append(",[CreationTime] as 'Time'");
            //query.Append(",[PrimaryUser] as 'Who'");
            ////query.Append(",[TargetUser]");
            //query.Append(",[TargetDomain] as 'Where'");
            //query.Append("FROM [OperationsManagerAC].[AdtServer].[dvAll] where (EventId = 4740 or  EventId = 4767 ) and TargetUser like '%" + iUser + "%' order by CreationTime desc");

            //using (SqlConnection con = new SqlConnection(dLibLke.DecText("OTl4WVHybkwO86mJtq1uFiV4Zz01D3sthdVVbBrQgJKskQyaWGS2gu/gGee5B9o7Y/lJbKkQMGby4ygQ9hdkC/nZaIrY2wXjKLP+D11Kg3vRRlOaeVElHUZG0Fvtc1DjyygeXhsfaSzHHAliPysUUg==")))
            //{
            //    try
            //    {
            //        con.Open();
            //        using (SqlCommand command = new SqlCommand(query.ToString(), con))
            //        {
            //            SqlDataAdapter da = new SqlDataAdapter(command);
            //            da.Fill(queryResult);
            //            con.Close();
            //            da.Dispose();
            //        }
            //    }
            //    catch (SqlException)
            //    {
            //        //
            //    }
            //}
            //return queryResult;
            return null;
        }
        
        private void querySecHistoricLocalServerEvents()
        {
            Thread thloadSecH = new Thread(() =>
            {
                Thread.CurrentThread.Name = "thloadSecH";

                TimeSpan span = DateTime.UtcNow.Subtract(DateTime.UtcNow.AddDays(-1));
                string queryString = "<QueryList>" +
                                     @"<Query Id = ""0"" Path = ""ForwardedEvents"">" +
                                         @"<Select Path = ""ForwardedEvents""> *[System[(EventID=4740) and TimeCreated[timediff(@SystemTime) &lt;= " + span.TotalMilliseconds + "]]]</Select>" +
                                     @"</Query>" +
                                     @"</QueryList>";

                SecureString pw = new SecureString();
                foreach (char c in frmMain.domainAccountData[2])
                {
                    pw.AppendChar(c);
                }
                EventLogSession session = new EventLogSession("corp1042", frmMain.domainAccountData[0], frmMain.domainAccountData[1], pw, SessionAuthentication.Default);
                pw.Dispose();

                // Query the Application log on the remote computer.
                EventLogQuery query = new EventLogQuery("ForwardedEvents", PathType.LogName, queryString);
                query.Session = session;

                try
                {
                    EventLogReader logReader = new EventLogReader(query);
                    DisplayEventAndLogInformation(logReader);
                }
                catch (EventLogException ex)
                {
                    Console.WriteLine("Could not query the remote computer! " + ex.Message);
                    return;
                }
                session.Dispose();
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        pBoxProgressSecH.Visible = false;
                    });
                }
                catch { Thread.CurrentThread.Abort(); }
            });

            string nOFDays;
            int nOFDaysInt;
            nOFDays = txtBoxDays.Text;
            if (int.TryParse(nOFDays, out nOFDaysInt))
            {
                pBoxProgressSecH.Visible = true;
                thloadSecH.Start();
            }
            else
            {
                MessageBox.Show("Please enter only Numbers on field: Days", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisplayEventAndLogInformation(EventLogReader logReader)
        {
            DataTable eventsHorizon = new DataTable();
            eventsHorizon.Columns.Add("EventID", Type.GetType("System.Int32")).SetOrdinal(0);
            eventsHorizon.Columns.Add("Publisher", Type.GetType("System.String")).SetOrdinal(1);
            eventsHorizon.Columns.Add("Time", Type.GetType("System.DateTime")).SetOrdinal(2);

            eventsHorizon.Columns.Add("TargetAccount", Type.GetType("System.String")).SetOrdinal(3);
            eventsHorizon.Columns.Add("TargetSecID", Type.GetType("System.String")).SetOrdinal(4);

            eventsHorizon.Columns.Add("LockedSource", Type.GetType("System.String")).SetOrdinal(5);
            eventsHorizon.Columns["LockedSource"].Caption = "Locked On";

            eventsHorizon.Columns.Add("LockedSecID", Type.GetType("System.String")).SetOrdinal(6);
            eventsHorizon.Columns.Add("Domain", Type.GetType("System.String")).SetOrdinal(7);

            eventsHorizon.Columns.Add("CallerSource", Type.GetType("System.String")).SetOrdinal(8);
            eventsHorizon.Columns["CallerSource"].Caption = "Locked From";

            for (EventRecord eventInstance = logReader.ReadEvent(); null != eventInstance; eventInstance = logReader.ReadEvent())
            {
                if (eventInstance.Properties[0].Value.ToString().ToLower().Contains(this.userToQuery.ToLower()))
                {
                    //Console.WriteLine("-----------------------------------------------------");
                    //Console.WriteLine("Event ID: {0}", eventInstance.Id);
                    //Console.WriteLine("Publisher: {0}", eventInstance.ProviderName);
                    //Console.WriteLine("Time :  " + eventInstance.TimeCreated + "\n");

                    DataRow logLine = eventsHorizon.NewRow();
                    logLine["EventID"] = eventInstance.Id;
                    logLine["Publisher"] = eventInstance.ProviderName;
                    logLine["Time"] = eventInstance.TimeCreated;
                    try
                    {
                        StringBuilder tempLogLine = new StringBuilder();
                        switch (eventInstance.Properties.Count())
                        {
                            case 7:
                                for (int i = 0; i < 7; i++)
                                {
                                    //Console.WriteLine("Properties number {0}: {1}", i, eventInstance.Properties[i].Value);
                                    switch (i)
                                    {
                                        case 0:
                                            logLine["TargetAccount"] = eventInstance.Properties[i].Value;
                                            break;
                                        case 1:
                                            logLine["CallerSource"] = eventInstance.Properties[i].Value;
                                            break;
                                        case 2:
                                            logLine["TargetSecID"] = eventInstance.Properties[i].Value;
                                            break;
                                        case 3:
                                            logLine["LockedSecID"] = eventInstance.Properties[i].Value;
                                            break;
                                        case 4:
                                            logLine["LockedSource"] = eventInstance.Properties[i].Value;
                                            break;
                                        case 5:
                                            logLine["Domain"] = eventInstance.Properties[i].Value;
                                            break;
                                    }
                                }
                                break;
                            case 6:
                                for (int i = 0; i < 6; i++)
                                {
                                    //Console.WriteLine("Properties number {0}: {1}", i, eventInstance.Properties[i].Value);
                                    switch (i)
                                    {
                                        case 0:
                                            logLine["TargetAccount"] = eventInstance.Properties[i].Value;
                                            break;
                                        case 1:
                                            logLine["TargetSecID"] = eventInstance.Properties[i].Value;
                                            break;
                                        case 2:
                                            logLine["LockedSecID"] = eventInstance.Properties[i].Value;
                                            break;
                                        case 3:
                                            logLine["LockedSource"] = eventInstance.Properties[i].Value;
                                            break;
                                        case 4:
                                            logLine["Domain"] = eventInstance.Properties[i].Value;
                                            break;
                                    }
                                    logLine["CallerSource"] = "Probably WIFI";
                                }
                                break;
                        }
                        eventsHorizon.Rows.Add(logLine);
                    }
                    catch (EventLogException)
                    {
                        // The event description contains parameters, and no parameters were 
                        // passed to the FormatDescription method, so an exception is thrown.
                    }
                }
            }
            eventsHorizon.Columns.Remove("EventID");
            eventsHorizon.Columns.Remove("Publisher");
            eventsHorizon.Columns.Remove("TargetSecID");
            eventsHorizon.Columns.Remove("LockedSecID");
            eventsHorizon.Columns.Remove("TargetAccount");

            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    dGridSecH.DataSource = eventsHorizon;
                });
            }
            catch { Thread.CurrentThread.Abort(); }

        }
        
        private void lblAccountStatus_Click(object sender, EventArgs e)
        {
            //tbControlUserInfo.SelectedTab = tbControlUserInfo.TabPages[4];            
        }    

        private void btnSeekLogs_Click(object sender, EventArgs e)
        {
            //querySecHistoricLocalServerEvents();
            Thread thloadSecH = new Thread(() =>
            {
                Thread.CurrentThread.Name = "thloadSecH";
                DataTable dtHistoricResult = querySecHistoricSQLScom(userToQuery, 30);
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        // dtHistoricResult.Columns["EventId"].ColumnName = "Operation";
                        // dtHistoricResult.Columns["CreationTime"].ColumnName = "Time";
                        // dtHistoricResult.Columns["PrimaryUser"].ColumnName = "Who";                        
                        // dtHistoricResult.Columns["TargetDomain"].ColumnName = "Where";

                        foreach (DataRow drow in dtHistoricResult.Rows)
                        {
                            drow[0] = Regex.Replace(drow[0].ToString(), "4740", "Lock").Trim();
                            drow[0] = Regex.Replace(drow[0].ToString(), "4767", "Unlock").Trim();
                        }

                        dGridSecH.DataSource = dtHistoricResult;
                        pBoxProgressSecH.Visible = false;
                    });
                }
                catch { Thread.CurrentThread.Abort(); }
            });

            string nOFDays;
            int nOFDaysInt;
            nOFDays = txtBoxDays.Text;
            if (int.TryParse(nOFDays, out nOFDaysInt))
            {
                pBoxProgressSecH.Visible = true;
                thloadSecH.Start();
            }
            else
            {
                MessageBox.Show("Please enter only Numbers on field: Days", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dGridSecH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dGridSecH.Columns[e.ColumnIndex].Name.Equals("Action"))
            {
                if (e.Value.ToString().Contains("Lock"))
                {
                    dGridSecH.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
                }
                else
                {
                    dGridSecH.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.YellowGreen;
                }
            }
        }

        private void dGridSecH_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dGridSecH.SelectedCells.Count == 1)
                {
                    if ((dGridSecH.SelectedCells[0].ColumnIndex == 2) | (dGridSecH.SelectedCells[0].ColumnIndex == 3))
                    {
                        frmMain.sharedcMenuSeekUnk.Tag = dGridSecH.CurrentCell.Value.ToString();
                        frmMain.sharedcMenuSeekUnk.Show(MousePosition);
                    }
                }
            }
        }

        private void btnCollectObject_Click(object sender, EventArgs e)
        {
            using (var form = new frmSessionManager())
            {
                form.insertObjectIntSessionMode = true;
                form.seekerObjectToInsertIntoSession = adUserObject;
                form.ShowDialog();
            }
        }

        //------------------------------------------------------------------------------------------------    
      
    }
}
