using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using dLibAdJobs;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Diagnostics;
using dLibSeekerSessions;

namespace Seeker
{
    public partial class frmSeekGroup : Form
    {
        public string groupToQuery { get; set; }
        dLibAd.adGroups groupResult;
        seekerObjects adGroupObject = new seekerObjects();

        //Cached Queries
        Boolean cachedGroupMembers = false;
        Boolean cachedGroupGroups = false;

        public frmSeekGroup()
        {
            InitializeComponent();
        }

        //Get Control Items Xthread----------------------------------------------------
        private delegate ListView.ListViewItemCollection GetItems(ListView lstview);
        private ListView.ListViewItemCollection getListViewItems(ListView lstview)
        {
            ListView.ListViewItemCollection temp = new ListView.ListViewItemCollection(new ListView());
            if (!lstview.InvokeRequired)
            {
                foreach (ListViewItem item in lstview.Items)
                    temp.Add((ListViewItem)item.Clone());
                return temp;
            }
            else
                return (ListView.ListViewItemCollection)this.Invoke(new GetItems(getListViewItems), new object[] { lstview });
        }
        //-----------------------------------------------------------------------------

        private void frmSeekGroup_Load(object sender, EventArgs e)
        {
            //Tags form with Seeker object that is being searched---           
            adGroupObject.Type = seekerObjectType.AD_Group;
            adGroupObject.QueryData = groupToQuery;
            this.Tag = adGroupObject;
            //------------------------------------------------------

            //Load central imagelist from Main form
            lvMembers.SmallImageList = frmMain.objTypeOmgList;
            lvlGroupGroups.SmallImageList = frmMain.objTypeOmgList;
            //------------------------------------------------------

            //Start query
            queryGroup(this.groupToQuery);
            //------------------------------------------------------
        }


        #region UI
        private void btnCopyUserData_Click(object sender, EventArgs e)
        {
            StringBuilder txtData = new StringBuilder();
            txtData.Append("Group Name: " + groupResult.Name + Environment.NewLine);
            txtData.Append("Description: " + groupResult.Description + Environment.NewLine);
            txtData.Append("Scope: " + groupResult.Scope + Environment.NewLine);
            txtData.Append("Type: " + groupResult.Type + Environment.NewLine);
            if ((groupResult.DN != null) && (groupResult.DN != string.Empty))
            {
                txtData.Append("DN: " + groupResult.DN + Environment.NewLine);
            }
            txtData.Append("Creation Date: " + groupResult.CreationDate + Environment.NewLine);
            txtData.Append("Modification Date: " + groupResult.ChangedDate + Environment.NewLine);
            txtData.Append("Notes: " + groupResult.Notes + Environment.NewLine);
            dLibClipboardJObs.dLibCopyToClipboard.ClipboardHelper.CopyToClipboard(txtData.ToString(), txtData.ToString());
        }

        private void frmSeekGroup_Move(object sender, EventArgs e)
        {
            adGroupObject.ScreenPos = new System.Drawing.Point(this.Location.X, this.Location.Y);
            this.Tag = adGroupObject;
        }

        private void btnAddGroupMembers_Click(object sender, EventArgs e)
        {
            cMenuSearchType.Items[0].Visible = true;
            cMenuSearchType.Show(MousePosition);
        }

        private void btnAddGroupGroups_Click(object sender, EventArgs e)
        {
            cMenuSearchType.Items[0].Visible = false;
            cMenuSearchType.Show(MousePosition);
        }

        private void updateProgressGroupMembers(bool state)
        {
            switch (state)
            {
                case true:
                    pBoxProgressGroupMembers.Visible = true;
                    ckBoxNestedGroupMembers.Enabled = false;
                    btnAddGroupMembers.Enabled = false;
                    break;
                case false:
                    pBoxProgressGroupMembers.Visible = false;
                    ckBoxNestedGroupMembers.Enabled = true;
                    btnAddGroupMembers.Enabled = true;
                    break;
            }
        }

        private void updateProgressGroupGroups(bool state)
        {
            switch (state)
            {
                case true:
                    pBoxProgressGroupsGroups.Visible = true;
                    btnAddGroupGroups.Enabled = false;
                    ckBoxNestedGroupGroups.Enabled = false;
                    break;
                case false:
                    pBoxProgressGroupsGroups.Visible = false;
                    btnAddGroupGroups.Enabled = true;
                    ckBoxNestedGroupGroups.Enabled = true;
                    break;
            }
        }

        private void lvMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lvMembers.SelectedItems.Count > 0) && (ckBoxNestedGroupMembers.Checked == false))
            {
                btnRemoveGroupMembers.Enabled = true;
            }
            else
            {
                btnRemoveGroupMembers.Enabled = false;
            }
        }

        private void lvlGroupGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lvlGroupGroups.SelectedItems.Count > 0))
            {
                btnRemoveGroupGroups.Enabled = true;
            }
            else
            {
                btnRemoveGroupGroups.Enabled = false;
            }
        }

        #endregion

        #region SeekingLogic

        private void queryGroup(string group)
        {
            groupResult = dLibAd.adGrpDetailsFinder(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), group);
            lblName.Text = groupResult.Name;
            lblDescription.Text = groupResult.Description;
            lblCreatedDate.Text = groupResult.CreationDate.ToString();
            lblModifiedDate.Text = groupResult.ChangedDate.ToString();
            lblScope.Text = groupResult.Scope;
            lblType.Text = groupResult.Type;
            lblNotes.Text = groupResult.Notes;
            this.Text = groupResult.Name;

            if ((groupResult.DN != null) && (groupResult.DN != string.Empty))
            {
                //string userDN = groupResult.DN.Substring(groupResult.DN.IndexOf(',') + 1, groupResult.DN.Length - (groupResult.DN.IndexOf(',') + 1));
                //string userDN = groupResult.DN;
                //lblDn.Text = userDN.Replace("CN=", string.Empty).Replace("DC=", string.Empty).Replace("OU=", string.Empty).Replace(",", "/");
                lblDn.Text = groupResult.DN;
            }
        }

        private void queryGroupMembers(bool nested)
        {
            if (!cachedGroupMembers)
            {
                updateProgressGroupMembers(true);
                lvMembers.Items.Clear();

                Thread thloadUserGroups = new Thread(() =>
                {
                    //this.Invoke((MethodInvoker)delegate { lvMembers.BeginUpdate(); });
                    GroupPrincipal group = GroupPrincipal.FindByIdentity(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), this.groupToQuery);
                    if (group != null)
                    {
                        List<Principal> groups = null;
                        List<Principal> groupsNoNest = null;
                        if (nested)
                        {
                            groups = group.GetMembers(true).OrderBy(o => o.Name).ToList();
                            groupsNoNest = groups;
                        }
                        else
                        {
                            groups = group.GetMembers().OrderBy(o => o.Name).ToList();
                        }

                        

                        int i = groups.Count();
                        Invoke((MethodInvoker)delegate { lblMembersCount.Text = i.ToString() + ", members."; });                        
                        List<ListViewItem> items = new List<ListViewItem>();
                        foreach (Principal userResult in groups)
                        {
                            ListViewItem objectItem = new ListViewItem();
                            string formatedFolder = "";

                            if ((userResult.DistinguishedName != null) && (userResult.DistinguishedName != string.Empty))
                            {
                                string userDN = userResult.DistinguishedName.Substring(userResult.DistinguishedName.IndexOf(',') + 1, userResult.DistinguishedName.Length - (userResult.DistinguishedName.IndexOf(',') + 1));
                                formatedFolder = userDN.Replace("CN=", string.Empty).Replace("DC=", string.Empty).Replace("OU=", string.Empty).Replace(",", "/");
                            }

                            if ((nested) && (groupsNoNest != null) && (groupsNoNest.Count() > 0))
                            {
                                if (!groupsNoNest.Select(g => g.SamAccountName).Contains(userResult.SamAccountName))
                                {
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        objectItem.BackColor = Color.SandyBrown;
                                    });
                                }
                            }
                            else
                            {
                                if (lvMembers.Items.Count % 2 != 0)
                                    objectItem.BackColor = Color.White;
                                else
                                    objectItem.BackColor = Color.WhiteSmoke;
                            }
                            if (userResult.StructuralObjectClass != null)
                            {
                                switch (userResult.StructuralObjectClass.ToString())
                                {
                                    case "user":
                                        objectItem.ImageIndex = 1;
                                        break;
                                    case "group":
                                        objectItem.ImageIndex = 10;
                                        break;
                                    case "computer":
                                        objectItem.ImageIndex = 4;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                objectItem.ImageIndex = 12;
                            }

                            objectItem.Tag = userResult.SamAccountName + "," + formatedFolder;
                            objectItem.Tag = userResult;
                            objectItem.Text = userResult.Name;
                            objectItem.SubItems.Add(userResult.SamAccountName);
                            objectItem.SubItems.Add(formatedFolder);
                            items.Add(objectItem);
                        }
                        try
                        {
                            this.Invoke((MethodInvoker)delegate
                            {                                
                                ListViewItem[] arr = items.ToArray();                                
                                lvMembers.BeginUpdate();
                                //foreach (ListViewItem item in items)
                                lvMembers.Items.AddRange(arr);
                                lvMembers.EndUpdate();                                
                            });

                            //Dispose          
                            group.Dispose();
                            groups = null;
                            groupsNoNest = null;
                            items = null;                            
                        }
                        catch { Thread.CurrentThread.Abort(); }
                    }

                    cachedGroupMembers = true;
                    try
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            updateProgressGroupMembers(false);
                            // lvMembers.EndUpdate();                            
                        });
                    }
                    catch { Thread.CurrentThread.Abort(); }
                    // this.Invoke((MethodInvoker)delegate { lvMembers.EndUpdate(); });                    
                });
                thloadUserGroups.IsBackground = true;
                thloadUserGroups.Start();                
            }
        }

        private void queryGroupGroups(bool nested)
        {
            if (!cachedGroupGroups)
            {
                updateProgressGroupGroups(true);
                lvlGroupGroups.Items.Clear();

                Thread thloadGroupGroups = new Thread(() =>
                {
                    List<dLibAd.adGroups> groupGroups = dLibAd.adObjectGroups(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0]), groupToQuery, adObjectType.Group, nested);
                    groupGroups = groupGroups.OrderBy(o => o.Name).ToList();
                    if (groupGroups.Count > 0)
                    {
                        int i = groupGroups.Count();
                        Invoke((MethodInvoker)delegate { lvlGroupGroups.BeginUpdate(); });
                        foreach (var userResult in groupGroups)
                        {
                            ListViewItem objectGroup = new ListViewItem();
                            string formatedFolder = "";
                            if ((userResult.DN != null) && (userResult.DN != string.Empty))
                            {
                                string userDN = userResult.DN.Substring(userResult.DN.IndexOf(',') + 1, userResult.DN.Length - (userResult.DN.IndexOf(',') + 1));
                                formatedFolder = userDN.Replace("CN=", string.Empty).Replace("DC=", string.Empty).Replace("OU=", string.Empty).Replace(",", "/");
                            }

                            if (lvlGroupGroups.Items.Count % 2 != 0)
                                objectGroup.BackColor = Color.White;
                            else
                                objectGroup.BackColor = Color.WhiteSmoke;

                            objectGroup.ImageIndex = 10;
                            objectGroup.Tag = userResult;
                            objectGroup.Text = userResult.Name;
                            objectGroup.SubItems.Add(userResult.SammAccountName);
                            objectGroup.SubItems.Add(formatedFolder);
                            try
                            {
                                this.Invoke((MethodInvoker)delegate { lvlGroupGroups.Items.Add(objectGroup); });
                            }
                            catch { Thread.CurrentThread.Abort(); }
                        }
                    }
                    cachedGroupGroups = true;
                    try
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            updateProgressGroupGroups(false);
                            lvlGroupGroups.EndUpdate();
                        });
                    }
                    catch { Thread.CurrentThread.Abort(); }
                });
                thloadGroupGroups.IsBackground = true;
                thloadGroupGroups.Start();
            }
        }

        #endregion


        private void tbpMembers_Enter(object sender, EventArgs e)
        {
            queryGroupMembers(false);
        }

        private void tbpMemberOf_Enter(object sender, EventArgs e)
        {
            queryGroupGroups(false);
        }

        private void ckBoxNestedGroupMembers_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxNestedGroupMembers.Checked == true)
            {
                cachedGroupMembers = false;
                ckBoxNestedGroupMembers.Checked = true;
                queryGroupMembers(true);
                btnAddGroupMembers.Enabled = false;
            }
            else
            {
                cachedGroupMembers = false;
                ckBoxNestedGroupMembers.Checked = false;
                queryGroupMembers(false);
            }
        }

        private void ckBoxNestedGroups_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxNestedGroupGroups.Checked == true)
            {
                cachedGroupGroups = false;
                ckBoxNestedGroupGroups.Checked = true;
                queryGroupGroups(true);
                btnAddGroupGroups.Enabled = false;
            }
            else
            {
                cachedGroupGroups = false;
                ckBoxNestedGroupGroups.Checked = false;
                queryGroupGroups(false);
            }
        }


        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new frmSearchDialog())
            {
                bool memberPageActive = false;
                form.searchType = 0;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (tbControlGroupInfo.SelectedTab == tbControlGroupInfo.TabPages["tbpMembers"])
                    {
                        updateProgressGroupMembers(true);
                        memberPageActive = true;
                    }
                    else
                    {
                        updateProgressGroupGroups(true);
                    }
                    Thread thAddObjectsToGroup = new Thread(() =>
                    {
                        Thread.CurrentThread.Name = "thAddObjectsToGroup";
                        var tagsToLoad = form.returnObjectsTags;
                        foreach (var tag in tagsToLoad)
                        {
                            string[] tagArray = tag.ToString().Split(',');
                            PrincipalContext context = new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]);

                            if (memberPageActive)
                            {
                                dLibAd.AddMemberToGroup(groupToQuery, context, tagArray[0], context, adObjectType.Group);
                            }
                            else
                            {
                                dLibAd.AddMemberToGroup(tagArray[0], context, groupToQuery, context, adObjectType.Group);
                            }
                        }
                        try
                        {
                            if (memberPageActive)
                            {
                                this.Invoke((MethodInvoker)delegate { updateProgressGroupMembers(false); cachedGroupMembers = false; queryGroupMembers(false); });
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate { updateProgressGroupGroups(false); cachedGroupGroups = false; queryGroupGroups(false); });
                            }
                        }
                        catch { Thread.CurrentThread.Abort(); }
                    });
                    thAddObjectsToGroup.Start();
                }
            }
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new frmSearchDialog())
            {
                form.searchType = 1;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    updateProgressGroupMembers(true);
                    Thread thAddObjectsToGroup = new Thread(() =>
                    {
                        Thread.CurrentThread.Name = "thAddObjectsToGroup";
                        var tagsToLoad = form.returnObjectsTags;
                        foreach (var tag in tagsToLoad)
                        {
                            string[] tagArray = tag.ToString().Split(',');
                            PrincipalContext context = new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]);
                            dLibAd.AddMemberToGroup(this.groupToQuery, context, tagArray[0], context, adObjectType.User);
                        }
                        try
                        {
                            this.Invoke((MethodInvoker)delegate { updateProgressGroupMembers(false); cachedGroupMembers = false; queryGroupMembers(false); });
                        }
                        catch { Thread.CurrentThread.Abort(); }
                    });
                    thAddObjectsToGroup.Start();
                }
            }
        }

        private void btnRemoveGroupMembers_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure ?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                if (lvMembers.SelectedItems.Count > 0)
                {
                    updateProgressGroupMembers(true);
                    StringBuilder objectsToRemove = new StringBuilder();
                    foreach (ListViewItem item in lvMembers.SelectedItems)
                    {
                        objectsToRemove.Append(item.Text);

                        Thread thRemoveObjectsFromGroup = new Thread(() =>
                        {
                            Thread.CurrentThread.Name = "thRemoveObjectsFromGroup";
                            Principal selectObject = (item.Tag as Principal);
                            dLibAd.RemoveMemberFromGroup(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), this.groupToQuery, selectObject.SamAccountName);
                            try
                            {
                                //  this.Invoke((MethodInvoker)delegate { lvMembers.Items.Remove(item); });
                            }
                            catch { Thread.CurrentThread.Abort(); }
                        });
                        thRemoveObjectsFromGroup.Start();
                    }

                    foreach (ListViewItem item in lvMembers.SelectedItems)
                    {
                        if (item.Text.Contains(objectsToRemove.ToString()))
                        {
                            lvMembers.Items.Remove(item);
                        }
                    }
                    updateProgressGroupMembers(false);
                    cachedGroupMembers = false;
                    queryGroupMembers(false);
                }
            }
        }

        private void btnRemoveGroupGroups_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure ?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                if (lvlGroupGroups.SelectedItems.Count > 0)
                {
                    updateProgressGroupGroups(true);
                    StringBuilder objectsToRemove = new StringBuilder();
                    foreach (ListViewItem item in lvlGroupGroups.SelectedItems)
                    {
                        objectsToRemove.Append(item.Text);

                        Thread thRemoveObjectsFromGroup = new Thread(() =>
                        {
                            Thread.CurrentThread.Name = "thRemoveObjectsFromGroup";
                            dLibAd.adGroups selectObject = (item.Tag as dLibAd.adGroups);
                            dLibAd.RemoveMemberFromGroup(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), selectObject.SammAccountName, groupToQuery);
                            try
                            {
                                //  this.Invoke((MethodInvoker)delegate { lvMembers.Items.Remove(item); });
                            }
                            catch { Thread.CurrentThread.Abort(); }
                        });
                        thRemoveObjectsFromGroup.Start();
                    }

                    foreach (ListViewItem item in lvlGroupGroups.SelectedItems)
                    {
                        if (item.Text.Contains(objectsToRemove.ToString()))
                        {
                            lvlGroupGroups.Items.Remove(item);
                        }
                    }
                    updateProgressGroupGroups(false);
                    cachedGroupGroups = false;
                    queryGroupGroups(false);
                }
            }
        }

  

        private void lvMembers_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvMembers.SelectedItems.Count == 1)
                {
                    foreach (ListViewItem item in lvMembers.SelectedItems)
                    {
                        switch ((item.Tag as Principal).StructuralObjectClass)
                        {
                            case "user":
                                frmMain.sharedcMenuSeekUser.Tag = (item.Tag as Principal).SamAccountName;
                                frmMain.sharedcMenuSeekUser.Show(MousePosition);
                                break;
                            case "group":
                                frmMain.sharedcMenuSeekGroup.Tag = (item.Tag as Principal).SamAccountName;
                                frmMain.sharedcMenuSeekGroup.Show(MousePosition);
                                break;
                            case "computer":
                                frmMain.sharedcMenuSeekComputer.Tag = (item.Tag as Principal).SamAccountName;
                                frmMain.sharedcMenuSeekComputer.Show(MousePosition);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void lvlGroupGroups_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvlGroupGroups.SelectedItems.Count == 1)
                {
                    foreach (ListViewItem item in lvlGroupGroups.SelectedItems)
                    {
                        frmMain.sharedcMenuSeekGroup.Tag = (item.Tag as dLibAd.adGroups).SammAccountName;
                        frmMain.sharedcMenuSeekGroup.Show(MousePosition);
                    }
                }
            }
        }

        private void lblName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((sender as Label) != null)
            {
                try
                {
                    (sender as Label).ForeColor = Color.Green;
                    dLibClipboardJObs.dLibCopyToClipboard.ClipboardHelper.CopyToClipboard((sender as Label).Text, (sender as Label).Text);
                }
                catch { }
            }
        }

        private void btnCopyUserData_Click_1(object sender, EventArgs e)
        {
            StringBuilder txtData = new StringBuilder();
            txtData.Append("Group Name: " + groupResult.Name + Environment.NewLine);
            txtData.Append("Description: " + groupResult.Description + Environment.NewLine);
            txtData.Append("Scope: " + groupResult.Scope + Environment.NewLine);
            txtData.Append("Type: " + groupResult.Type + Environment.NewLine);
            if ((groupResult.DN != null) && (groupResult.DN != string.Empty))
            {
                txtData.Append("DN: " + groupResult.DN + Environment.NewLine);
            }
            txtData.Append("Creation Date: " + groupResult.CreationDate + Environment.NewLine);
            txtData.Append("Modification Date: " + groupResult.ChangedDate + Environment.NewLine);
            txtData.Append("Notes: " + groupResult.Notes + Environment.NewLine);
            dLibClipboardJObs.dLibCopyToClipboard.ClipboardHelper.CopyToClipboard(txtData.ToString(), txtData.ToString());
        }

        private void btnCollectObject_Click(object sender, EventArgs e)
        {
            using (var form = new frmSessionManager())
            {
                form.insertObjectIntSessionMode = true;
                form.seekerObjectToInsertIntoSession = adGroupObject;
                form.ShowDialog();
            }
        }

        }
}
