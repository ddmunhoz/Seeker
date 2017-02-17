using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using dLibAdJobs;

namespace Seeker
{
    public partial class frmSearchDialog : Form
    {
        public frmSearchDialog()
        {
            InitializeComponent();
        }

        public List<object> returnObjectsTags { get; set; }

        public int searchType { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
             DialogResult = MessageBox.Show("Are you sure ?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
             if (DialogResult == DialogResult.OK)
             {
                 var selectedTags = this.lvResults.CheckedItems
                                      .Cast<ListViewItem>()
                                      .Select(x => x.Tag);
                 returnObjectsTags = selectedTags.ToList();

                 this.DialogResult = DialogResult.OK;
                 this.Close();
             }
        }



        private void fillListViewResults(PrincipalSearchResult<Principal> results)
        {
            foreach (var userResult in results)
            {
                ListViewItem user = new ListViewItem();
                string formatedFolder = "";
                if ((userResult.DistinguishedName != null) && (userResult.DistinguishedName != string.Empty))
                {
                    string userDN = userResult.DistinguishedName.Substring(userResult.DistinguishedName.IndexOf(',') + 1, userResult.DistinguishedName.Length - (userResult.DistinguishedName.IndexOf(',') + 1));
                    formatedFolder = userDN.Replace("CN=", string.Empty).Replace("DC=", string.Empty).Replace("OU=", string.Empty).Replace(",", "/");
                }

                if (lvResults.Items.Count % 2 != 0)
                    user.BackColor = Color.White;
                else
                    user.BackColor = Color.WhiteSmoke;
                user.Tag = userResult.SamAccountName + "," + formatedFolder;
                user.Text = userResult.Name;
                user.SubItems.Add(userResult.SamAccountName);
                user.SubItems.Add(formatedFolder);
                lvResults.Items.Add(user);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvResults.Items.Clear();
            dLibAd searchAdObjects = new dLibAd();            
            PrincipalSearchResult<Principal> resultsUsers = null;           
            PrincipalSearchResult<Principal> resultsGroups = null;
            string[] searchQuery = rtBoxSearchQuery.Text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            switch(searchType)
            {
                case 0:
                    foreach (var line in searchQuery)
                    {
                        resultsGroups = searchAdObjects.GetADGroup(new PrincipalContext(ContextType.Domain,frmMain.domainAccountData[0],frmMain.domainAccountData[1],frmMain.domainAccountData[2]),line, false);
                        fillListViewResults(resultsGroups);
                    }
                    break;
                case 1:
                    foreach (var line in searchQuery)
                    {
                        resultsUsers = searchAdObjects.GetADUser(new PrincipalContext(ContextType.Domain,frmMain.domainAccountData[0],frmMain.domainAccountData[1],frmMain.domainAccountData[2]),line);
                        fillListViewResults(resultsUsers);
                    }
                    break;
                case 2:
                    foreach (var line in searchQuery)
                    {
                        resultsUsers = searchAdObjects.GetADUser(new PrincipalContext(ContextType.Domain,frmMain.domainAccountData[0],frmMain.domainAccountData[1],frmMain.domainAccountData[2]),line);
                        fillListViewResults(resultsUsers);
                    }
                     foreach (var line in searchQuery)
                    {
                        resultsGroups = searchAdObjects.GetADGroup(new PrincipalContext(ContextType.Domain,frmMain.domainAccountData[0],frmMain.domainAccountData[1],frmMain.domainAccountData[2]),line, false);
                        fillListViewResults(resultsGroups);
                    }
                    break;                    
            }      


            if (lvResults.Items.Count > 0)
            {
                tbMain.SelectTab(tbpResults);
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
