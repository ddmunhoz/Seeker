using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using dLibAdJobs;
using dLibSeekerSessions;


namespace Seeker
{
    public partial class frmMain : Form
    {
        public static string[] domainAccountData { set; get; }
        public static dLibAd.adUsers domainAccountObject { set; get; }
        public static ContextMenuStrip sharedcMenuSeekUser { set; get; }
        public static ContextMenuStrip sharedcMenuSeekComputer { set; get; }
        public static ContextMenuStrip sharedcMenuSeekFNETUser { set; get; }
        public static ContextMenuStrip sharedcMenuSeekGroup { set; get; }
        public static ContextMenuStrip sharedcMenuSeekOu { set; get; }
        public static ContextMenuStrip sharedcMenuSeekUnk { set; get; }

        public static ImageList objTypeOmgList { get; set; }

        static string loggedUser = Environment.UserName;
        dLibAd.adUsers loggedUserAdObj = domainAccountObject;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HideMainForm();
            objTypeOmgList = imgListObjType;
            notifyMain.BalloonTipIcon = ToolTipIcon.Info;
            notifyMain.BalloonTipTitle = "Seeker";
            notifyMain.BalloonTipText = "What are you Seeking today ?";
            notifyMain.ShowBalloonTip(2500);

            //Share Context Menus
            sharedcMenuSeekUser = cMenuSeekUser;
            sharedcMenuSeekComputer = cMenuSeekComputer;            
            sharedcMenuSeekGroup = cMenuSeekGroup;
            sharedcMenuSeekOu = cMenuSeekOu;
            sharedcMenuSeekUnk = cMenuSeekUnk;
        }

        #region Trayicon Menu
        public void HideMainForm()
        {
            Visible = false;
            ShowInTaskbar = false;
        }

        private void newSeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeekItAll myForm = new frmSeekItAll();
            myForm.WindowState = FormWindowState.Normal;
            myForm.Show();
        }

        private void notifyMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                frmSeekItAll frmSeekITALL = new frmSeekItAll();
                frmSeekITALL.StartPosition = FormStartPosition.CenterScreen;
                frmSeekITALL.Show();
                frmSeekITALL.Activate();
            }
        }

        private void notifyMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMenuTray.Show(MousePosition);
            }
        }          

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to close all opened Cards ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
            {
                Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                foreach (Form thisForm in forms)
                {
                    thisForm.Close();                    
                }
            }
            GC.Collect();
        }

        //Session Launch handler       
        public void sessionLauncherStripClick(object sender, EventArgs e)
        {
            seekerSessions.sessionsLauncher(((sender as ToolStripMenuItem).Tag as seekerSessions));
        }

        private void sessionsTrayMenu()
        {
            //savedSessionsToolStripMenuItem.DropDownItems.Clear();

            seekerSessions sessionToLoad = new seekerSessions();
            List<ToolStripMenuItem> sessionMenuItems = new List<ToolStripMenuItem>();

            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Seeker\Sessions\" + frmMain.domainAccountData[1] + @"\";

            Thread thLoadTraySessions = new Thread(() =>
            {
                if (Directory.Exists(filepath))
                {
                    ToolStripMenuItem sessionLoadProgress = new ToolStripMenuItem();
                    sessionLoadProgress.Text = "Loading...";
                    sessionLoadProgress.Image = Seeker.Properties.Resources.spinningWeel16;
                    Invoke((MethodInvoker)delegate { savedSessionsToolStripMenuItem.DropDownItems.Clear(); savedSessionsToolStripMenuItem.DropDownItems.Add(sessionLoadProgress); });

                    DirectoryInfo d = new DirectoryInfo(filepath);
                    foreach (var file in d.GetFiles("*.xml"))
                    {
                        sessionToLoad = dLibObjSerializer.dLibObjSerializer.XmlDeSerializeObjectFromDisk<seekerSessions>(file.FullName);

                        ToolStripMenuItem itemToInsert = new ToolStripMenuItem();
                        itemToInsert.Text = sessionToLoad.Description + " - " + sessionToLoad.SessionDate;
                        itemToInsert.Click += new EventHandler(sessionLauncherStripClick);
                        itemToInsert.Tag = sessionToLoad;
                        itemToInsert.Image = Seeker.Properties.Resources.seekerSession16;

                        //Insert session Objects
                        foreach (seekerObjects sessionObj in sessionToLoad.Objects)
                        {
                            seekerSessions sessionToOverhideAndLoad = new seekerSessions();
                            sessionToOverhideAndLoad.Objects.Add(sessionObj);

                            ToolStripMenuItem itemToInsertInSessionObjects = new ToolStripMenuItem();

                            itemToInsertInSessionObjects.Text = sessionObj.QueryData;
                            itemToInsertInSessionObjects.Tag = sessionToOverhideAndLoad;
                            itemToInsertInSessionObjects.Click += new EventHandler(sessionLauncherStripClick);

                            switch (sessionObj.Type)
                            {
                                case seekerObjectType.AD_Computer:
                                    itemToInsertInSessionObjects.Image = imgListObjType.Images["Computer"];
                                    break;

                                case seekerObjectType.AD_User:
                                    itemToInsertInSessionObjects.Image = imgListObjType.Images["User"];
                                    break;

                                case seekerObjectType.AD_Group:
                                    itemToInsertInSessionObjects.Image = imgListObjType.Images["Group"];
                                    break;

                                case seekerObjectType.AD_OrganizationalUnit:
                                    itemToInsertInSessionObjects.Image = imgListObjType.Images["ouIcon"];
                                    break;                                
                            }
                            itemToInsert.DropDownItems.Add(itemToInsertInSessionObjects);
                        }
                        sessionMenuItems.Add(itemToInsert);
                        //savedSessionsToolStripMenuItem.DropDownItems.Add(itemToInsert);
                    }
                    try
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            savedSessionsToolStripMenuItem.DropDownItems.Clear();
                            ToolStripMenuItem[] arr = sessionMenuItems.OrderBy(o => o.Text).ToArray();
                            savedSessionsToolStripMenuItem.DropDownItems.AddRange(arr);
                        });

                    }
                    catch { }
                }
            });
            thLoadTraySessions.Start();
        }

        private void saveSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean validSessions = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Tag != null)
                {
                    validSessions = true;
                    break;
                }
            }

            if (validSessions)
            {
                using (var formInputData = new frmInputDialog())
                {
                    formInputData.inputDataAsk = "Type something to help you remember this session";
                    var result = formInputData.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        DialogResult dlgResultCloseForms = MessageBox.Show("Do you want to close Session cards after saving ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        seekerSessions sessionDump = new seekerSessions();
                        sessionDump.Description = formInputData.returnInputData;

                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.Tag != null)
                            {
                                sessionDump.Objects.Add(form.Tag as seekerObjects);
                            }
                        }

                        if (dlgResultCloseForms == DialogResult.Yes)
                        {
                            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                            foreach (Form thisForm in forms)
                            {
                                thisForm.Close();
                            }
                        }
                        dLibObjSerializer.dLibObjSerializer.XmlSerializeObjectToDisk<seekerSessions>(sessionDump, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Seeker\Sessions\" + frmMain.domainAccountData[1] + @"\" + sessionDump.SessionID + ".xml");
                    }
                }
                validSessions = false;
            }
            else
            {
                MessageBox.Show("Sorry, but you don't have any Session data to save!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 

        private void manageSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSessionManager sessionManager = new frmSessionManager();
            sessionManager.Show();
        }

        private void sessionsToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            sessionsTrayMenu();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutDlg = new frmAbout();
            aboutDlg.Show();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        #endregion

        #region Context Menu Openings  
        private void cMenuSeekUser_Opening(object sender, CancelEventArgs e)
        {
            cMenuSeekUser.Items[0].Text = "Seek User: " + cMenuSeekUser.Tag.ToString();
        }

        private void cMenuSeekComputer_Opening(object sender, CancelEventArgs e)
        {
            cMenuSeekComputer.Items[0].Text = "Seek Computer: " + cMenuSeekComputer.Tag.ToString();
        }

        private void cMenuSeekGroup_Opening(object sender, CancelEventArgs e)
        {
            cMenuSeekGroup.Items[0].Text = "Seek Group: " + cMenuSeekGroup.Tag.ToString();
        }

        private void cMenuSeekOu_Opening(object sender, CancelEventArgs e)
        {
            cMenuSeekOu.Items[0].Text = "Seek OU: " + cMenuSeekOu.Tag.ToString();
        }

        private void cMenuSeekUnk_Opening(object sender, CancelEventArgs e)
        {
            cMenuSeekUnk.Items[0].Text = "Seek Unknow: " + cMenuSeekUnk.Tag.ToString();
        }

        #endregion

        #region Context Menu Click                      

        private void seekUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeek userToSeek = new frmSeek();
            userToSeek.userToQuery = cMenuSeekUser.Tag.ToString().Trim();
            userToSeek.WindowState = FormWindowState.Normal;
            userToSeek.Show();

        }            

        private void seekComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeekComputer computerToSeek = new frmSeekComputer();
            computerToSeek.machineToQuery = cMenuSeekComputer.Tag.ToString().Trim();
            computerToSeek.WindowState = FormWindowState.Normal;
            computerToSeek.Show();
        }     
            
        private void seekGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeekGroup groupToSeek = new frmSeekGroup();
            groupToSeek.groupToQuery = cMenuSeekGroup.Tag.ToString();
            groupToSeek.WindowState = FormWindowState.Normal;
            groupToSeek.Show();
        }       

        private void seekOuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeekOu frmSeekOu = new frmSeekOu();
            frmSeekOu.ouToQuery = cMenuSeekOu.Tag.ToString();
            frmSeekOu.WindowState = FormWindowState.Normal;
            frmSeekOu.Show();
        }

        private void seekUnknowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeekItAll frmSeekItAll = new frmSeekItAll();
            frmSeekItAll.unkToSeek = cMenuSeekUnk.Tag.ToString();
            frmSeekItAll.WindowState = FormWindowState.Normal;
            frmSeekItAll.Show();
        }
             
        #endregion
    }
}
