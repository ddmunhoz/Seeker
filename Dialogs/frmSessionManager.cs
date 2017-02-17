using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

using dLibSeekerSessions;
using dLibAdJobs;

namespace Seeker
{
    public partial class frmSessionManager : Form
    {
        public frmSessionManager()
        {
            InitializeComponent();
        }

        public Boolean insertObjectIntSessionMode { get; set; }
        public seekerObjects seekerObjectToInsertIntoSession { get; set; }

        private void frmSessionManager_Load(object sender, EventArgs e)
        {
            lvUserSessions.SmallImageList = frmMain.objTypeOmgList;
            lvSessionObjects.SmallImageList = frmMain.objTypeOmgList;
            sessionLoader();

            if(insertObjectIntSessionMode)
            {
                tblActions.Enabled = false;
                lvUserSessions.MultiSelect = false;
            }
        }


        private void sessionLoader()
        {           
            
            Thread thLoadUserSessions = new Thread(() =>
            {
                seekerSessions sessionToLoad = new seekerSessions();

                string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Seeker\Sessions\" + frmMain.domainAccountData[1] + @"\";
                if (Directory.Exists(filepath))
                {
                    Invoke((MethodInvoker)delegate{pBoxProgressUserSessions.Visible = true;});

                    var seekerSessions = new List<ListViewItem>();
                    DirectoryInfo d = new DirectoryInfo(filepath);
                    foreach (var file in d.GetFiles("*.xml"))
                    {
                        sessionToLoad = dLibObjSerializer.dLibObjSerializer.XmlDeSerializeObjectFromDisk<seekerSessions>(file.FullName);
                        if (sessionToLoad.Objects.Count() > 0)
                        {
                            ListViewItem objectSession = new ListViewItem();

                            objectSession.Tag = sessionToLoad;
                            objectSession.Text = sessionToLoad.Description;
                            objectSession.SubItems.Add(sessionToLoad.Objects.Count().ToString());
                            objectSession.SubItems.Add(sessionToLoad.SessionDate.ToString());
                            int objCounter = seekerSessions.Count + 1;
                            Invoke((MethodInvoker)delegate { lblSessionCounter.Text = objCounter.ToString(); });

                            objectSession.ImageIndex = 16;
                            if (objCounter % 2 != 0)
                                objectSession.BackColor = Color.White;
                            else
                                objectSession.BackColor = Color.WhiteSmoke;

                            seekerSessions.Add(objectSession);
                        }
                    }
                    try
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            lvUserSessions.Items.Clear();
                            lvUserSessions.BeginUpdate();
                            ListViewItem[] arr = seekerSessions.ToArray();
                            lvUserSessions.Items.AddRange(arr);
                            lvUserSessions.EndUpdate();

                            pBoxProgressUserSessions.Visible = false;
                        });
                    }
                    catch { Thread.CurrentThread.Abort(); }

                }
            });
            thLoadUserSessions.Start();
        }

    
        private void lvUserSessions_MouseClick(object sender, MouseEventArgs e)
        {        

            lvSessionObjects.Items.Clear();
            List<seekerSessions> listViewSessions = new List<seekerSessions>();
            foreach (ListViewItem session in lvUserSessions.SelectedItems)
            {
                listViewSessions.Add(session.Tag as seekerSessions);
            }


            pBoxProgressSessionObjects.Visible = true;
            Thread thLoadSessionObjects = new Thread(() =>
           {
               List<ListViewItem> sessionObjToLoad = new List<ListViewItem>();
               foreach (seekerSessions session in listViewSessions)
               {
                   foreach (seekerObjects sessionObj in session.Objects)
                   {
                       ListViewItem lvSessionObj = new ListViewItem();
                       lvSessionObj.Tag = sessionObj;
                       switch (sessionObj.Type)
                       {
                           case seekerObjectType.AD_Computer:
                               lvSessionObj.Text = "Computer";
                               lvSessionObj.ImageIndex = 3;
                               break;

                           case seekerObjectType.AD_User:
                               lvSessionObj.Text = "User";
                               lvSessionObj.ImageIndex = 0;
                               break;

                           case seekerObjectType.AD_Group:
                               lvSessionObj.Text = "Group";
                               lvSessionObj.ImageIndex = 9;
                               break;

                           case seekerObjectType.AD_OrganizationalUnit:
                               lvSessionObj.Text = "Organizational Unit";
                               lvSessionObj.ImageIndex = 13;
                               break;

                           case seekerObjectType.FurnasNet:
                               lvSessionObj.Text = "FurnasNET";
                               lvSessionObj.ImageIndex = 6;
                               break;
                       }
                       lvSessionObj.SubItems.Add(sessionObj.QueryData);
                       sessionObjToLoad.Add(lvSessionObj);                       
                   }
                   try
                   {
                       Invoke((MethodInvoker)delegate
                        {
                            lvSessionObjects.BeginUpdate();                            
                            ListViewItem[] arr = sessionObjToLoad.OrderBy(o => o.Text).ToArray();
                            lvSessionObjects.Items.Clear();
                            lvSessionObjects.Items.AddRange(arr);
                            lvSessionObjects.EndUpdate();
                            lblSessionObjectsCounter.Text = sessionObjToLoad.Count().ToString();
                            pBoxProgressSessionObjects.Visible = false;
                        });
                   }
                   catch { Thread.CurrentThread.Abort(); }
               }
           });
            thLoadSessionObjects.Start();
        }
           
      
        private void lvSessionObjects_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvSessionObjects.SelectedItems.Count == 1)
                {
                    seekerObjects objectToLaunch = (lvSessionObjects.SelectedItems[0].Tag as seekerObjects);
                    switch (objectToLaunch.Type)
                    {
                        case seekerObjectType.AD_User:
                            frmMain.sharedcMenuSeekUser.Tag = objectToLaunch.QueryData;
                            frmMain.sharedcMenuSeekUser.Show(MousePosition);
                            break;

                        case seekerObjectType.AD_Group:
                            frmMain.sharedcMenuSeekGroup.Tag = objectToLaunch.QueryData;
                            frmMain.sharedcMenuSeekGroup.Show(MousePosition);
                            break;

                        case seekerObjectType.AD_OrganizationalUnit:
                            frmMain.sharedcMenuSeekOu.Tag = objectToLaunch.QueryData;
                            frmMain.sharedcMenuSeekOu.Show(MousePosition);
                            break;

                        case seekerObjectType.AD_Computer:
                            frmMain.sharedcMenuSeekComputer.Tag = objectToLaunch.QueryData;
                            frmMain.sharedcMenuSeekComputer.Show(MousePosition);
                            break;
                        default:

                            break;
                    }
                }
            }
        }
   
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveSession_Click(object sender, EventArgs e)
        {
            if(lvUserSessions.SelectedItems.Count != 0)
            {
                DialogResult dlgResult = MessageBox.Show("Are you sure that you want to delete this session ? This operation cannot be undone.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    foreach (ListViewItem sessionToDelete in lvUserSessions.SelectedItems)
                    {
                        lvUserSessions.Items.Remove(sessionToDelete);
                        System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Seeker\Sessions\" + frmMain.domainAccountData[1] + @"\" + (sessionToDelete.Tag as seekerSessions).SessionID + ".xml");
                        lblSessionCounter.Text = (Convert.ToInt32(lblSessionCounter.Text) - 1).ToString();
                    }
                    lvSessionObjects.Items.Clear();
                    lblSessionObjectsCounter.Text = "0";
                }
            }
        }

        private void lvUserSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!insertObjectIntSessionMode)
            {
                if (lvUserSessions.SelectedItems.Count != 0)
                {
                    btnRemoveSession.Enabled = true;
                    btnExportSession.Enabled = true;
                }
                else
                {
                    btnRemoveSession.Enabled = false;
                    btnExportSession.Enabled = false;
                }
            }
            else
            {
                DialogResult dlgResult = MessageBox.Show("Are you sure you want to insert object " + seekerObjectToInsertIntoSession.QueryData + " into selected session ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dlgResult == DialogResult.Yes)
                {                    
                    dLibSeekerSessions.seekerSessions.sessionsUpdate(lvUserSessions.SelectedItems[0].Tag as seekerSessions, seekerObjectToInsertIntoSession);
                    MessageBox.Show("Session updated!", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }

        private void lvUserSessions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach(ListViewItem sessionToLaunch in lvUserSessions.SelectedItems)
            {
                seekerSessions.sessionsLauncher(sessionToLaunch.Tag as seekerSessions);
            }
        }

        private void btnExportSession_Click(object sender, EventArgs e)
        {
            if(lvUserSessions.SelectedItems.Count != 0)
            {
                folderBrowserDlg.ShowDialog();
                if (folderBrowserDlg.SelectedPath != string.Empty)
                {
                    foreach(ListViewItem sessionToExport in lvUserSessions.SelectedItems)
                    {
                        seekerSessions sessionBeingExported = new seekerSessions();
                        sessionBeingExported = sessionToExport.Tag as seekerSessions;
                        dLibObjSerializer.dLibObjSerializer.XmlSerializeObjectToDisk<seekerSessions>(sessionBeingExported,folderBrowserDlg.SelectedPath + @"\" + sessionBeingExported.SessionID + ".xml");
                    }
                    MessageBox.Show("Session export was sucessful! you can check your exported data in folder " + folderBrowserDlg.SelectedPath, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }            
            }
        }

        private void btnImportSession_Click(object sender, EventArgs e)
        {            
            openFileDlg.Title = "Select session(ons) to import...";
            openFileDlg.Multiselect = true;
            openFileDlg.CheckFileExists = true;
            openFileDlg.Filter = "Seeker session files (*.xml)|*.xml";
            openFileDlg.ShowHelp = true;
            openFileDlg.FileName = "";
            openFileDlg.ShowDialog();

            if (openFileDlg.FileNames != null)
            {
                foreach(var fileToLoad in openFileDlg.FileNames)
                {
                    if (fileToLoad != string.Empty)
                    {
                        seekerSessions sessionToImport = dLibObjSerializer.dLibObjSerializer.XmlDeSerializeObjectFromDisk<seekerSessions>(fileToLoad);
                        int contX = 0;
                        int contY = 0;
                        foreach (seekerObjects objToBeUpdated in sessionToImport.Objects)
                        {
                            contX = contX + 20;
                            contY = contY + 20;
                            objToBeUpdated.ScreenPos = new System.Drawing.Point(contX, contY);
                        }
                        dLibObjSerializer.dLibObjSerializer.XmlSerializeObjectToDisk<seekerSessions>(sessionToImport, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Seeker\Sessions\" + frmMain.domainAccountData[1] + @"\" + sessionToImport.SessionID + ".xml");
                    }
                }
                sessionLoader();
            }
        }
    }
}
