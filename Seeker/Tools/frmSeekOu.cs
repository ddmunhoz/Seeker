using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using dLibAdJobs;
using Simple_AD_Browser_Helpers;
using dLibSeekerSessions;

namespace Seeker
{
    public partial class frmSeekOu : Form
    {
        public string ouToQuery { get; set; }
        dLibAd.adOu ouInfo = new dLibAd.adOu();
        seekerObjects adOUObject = new seekerObjects();
        private static ADLib LdapHelper = new ADLib();
        public Credits LoginCredits = new Credits();

        public frmSeekOu()
        {
            InitializeComponent();
        }

        private void frmSeekOu_Load(object sender, EventArgs e)
        {
            //Tags form with Seeker object that is being searched---
            adOUObject.Type = seekerObjectType.AD_OrganizationalUnit;
            adOUObject.QueryData = ouToQuery;
            this.Tag = adOUObject;
            //------------------------------------------------------

            //Load central imagelist from Main form
            tvOuMembers.ImageList = frmMain.objTypeOmgList;
            //------------------------------------------------------

            //Start query
            queryOu(ouToQuery);
            //------------------------------------------------------
        }


        #region UI
        private void btnCopyUserData_Click(object sender, EventArgs e)
        {
            StringBuilder txtData = new StringBuilder();
            txtData.Append("Organizational Unit name: " + ouInfo.Name + Environment.NewLine);
            txtData.Append("Description: " + ouInfo.Description + Environment.NewLine);
            if ((ouInfo.DN != null) && (ouInfo.DN != string.Empty))
            {
                txtData.Append("DN: " + ouInfo.DN + Environment.NewLine);
            }
            txtData.Append("Creation Date: " + ouInfo.CreationDate + Environment.NewLine);
            txtData.Append("Modification Date: " + ouInfo.ChangedDate + Environment.NewLine);
            dLibClipboardJObs.dLibCopyToClipboard.ClipboardHelper.CopyToClipboard(txtData.ToString(), txtData.ToString());
        }

        private void lblName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((sender as Label) != null)
            {
                (sender as Label).ForeColor = Color.Green;
                dLibClipboardJObs.dLibCopyToClipboard.ClipboardHelper.CopyToClipboard((sender as Label).Text, (sender as Label).Text);
            }
        }

        private void frmSeekOu_Move(object sender, EventArgs e)
        {
            adOUObject.ScreenPos = new System.Drawing.Point(this.Location.X, this.Location.Y);
            this.Tag = adOUObject;
        }
        #endregion

        #region SeekingLogic

        private void queryOu(string ou)
        {
            DirectoryEntry deBase = new DirectoryEntry("LDAP://" + ouToQuery, frmMain.domainAccountData[1], frmMain.domainAccountData[2]);
            ouInfo = dLibAd.GetADOuInfo(deBase, ouToQuery);
            this.Text = this.ouToQuery.Substring(3, ouToQuery.Length - 3);
            // SearchResultCollection l = dLibAd.GetADOuMembers(deBase, ouToQuery);
            // frmSeekItAll.NodeSorterByType sortTypes = new frmSeekItAll.NodeSorterByType();
            lblName.Text = ouInfo.Name;
            lblDescription.Text = ouInfo.Description;
            lblCreatedDate.Text = ouInfo.CreationDate;
            lblModifiedDate.Text = ouInfo.ChangedDate;
            lblDn.Text = ouInfo.DN;
            LoginCredits.Domain = ouToQuery;
            LoginCredits.Username = frmMain.domainAccountData[1];
            LoginCredits.Pwd = frmMain.domainAccountData[2];
            LdapHelper.ConnectAndDisplayRoot(ref tvOuMembers, LoginCredits);
            //tvOuMembers.TreeViewNodeSorter = sortTypes;
            // tvOuMembers.Sort();
        }
        #endregion
        private void tvOuMembers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LdapHelper.FillCheckTreeNodeForChildObjects(e.Node);
        }

        private void tvOuMembers_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (tvOuMembers.SelectedNode != null)
                {
                    DirectoryEntry adObject = (tvOuMembers.SelectedNode.Tag as DirectoryEntry);
                    switch (adObject.Properties["objectCategory"][0].ToString().ToLower().Split(',')[0].Substring(3, adObject.Properties["objectCategory"][0].ToString().ToLower().Split(',')[0].Length - 3))
                    {
                        case "person":
                            frmMain.sharedcMenuSeekUser.Tag = adObject.Properties["sAMAccountName"].Value.ToString();
                            frmMain.sharedcMenuSeekUser.Show(MousePosition);
                            break;
                        case "group":
                            frmMain.sharedcMenuSeekGroup.Tag = adObject.Properties["sAMAccountName"].Value.ToString();
                            frmMain.sharedcMenuSeekGroup.Show(MousePosition);
                            break;

                        case "organizational-unit":
                            frmMain.sharedcMenuSeekOu.Tag = adObject.Properties["distinguishedName"].Value.ToString();
                            frmMain.sharedcMenuSeekOu.Show(MousePosition);

                            break;

                        case "computer":
                            frmMain.sharedcMenuSeekComputer.Tag = adObject.Properties["sAMAccountName"].Value.ToString();
                            frmMain.sharedcMenuSeekComputer.Show(MousePosition);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void btnAddGroupMembers_Click(object sender, EventArgs e)
        {
            frmCreateUserDialog createUser = new frmCreateUserDialog();
            createUser.destOu = ouToQuery;
            createUser.WindowState = FormWindowState.Normal;
            createUser.Show();
        }

        private void btnCopyUserData_Click_1(object sender, EventArgs e)
        {
            StringBuilder txtData = new StringBuilder();
            txtData.Append("Organizational Unit name: " + ouInfo.Name + Environment.NewLine);
            txtData.Append("Description: " + ouInfo.Description + Environment.NewLine);
            if ((ouInfo.DN != null) && (ouInfo.DN != string.Empty))
            {
                txtData.Append("DN: " + ouInfo.DN + Environment.NewLine);
            }
            txtData.Append("Creation Date: " + ouInfo.CreationDate + Environment.NewLine);
            txtData.Append("Modification Date: " + ouInfo.ChangedDate + Environment.NewLine);
            dLibClipboardJObs.dLibCopyToClipboard.ClipboardHelper.CopyToClipboard(txtData.ToString(), txtData.ToString());
        }

        private void btnCollectObject_Click(object sender, EventArgs e)
        {
            using (var form = new frmSessionManager())
            {
                form.insertObjectIntSessionMode = true;
                form.seekerObjectToInsertIntoSession = adOUObject;
                form.ShowDialog();
            }
        }
    }
}
