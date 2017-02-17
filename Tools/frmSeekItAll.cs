using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using dLibAdJobs;
using System.Collections;
using System.Text.RegularExpressions;

namespace Seeker
{
    public partial class frmSeekItAll : Form
    {
        public frmSeekItAll()
        {
            InitializeComponent();
        }
                  

        public string unkToSeek { get; set; }

        class NodeSorterByName : IComparer
        {
            public int Compare(object x, object y)
            {
                TreeNode tx = (TreeNode)x;
                TreeNode ty = (TreeNode)y;

                if (tx.Text.CompareTo(ty.Text) > 0)
                {
                    return 1;
                }

                if (tx.Text.CompareTo(ty.Text) < 0)
                {
                    return -1;
                }

                return 0;
            }
        }

        public class NodeSorterByType : IComparer
        {
            public int Compare(object x, object y)
            {
                TreeNode tx = (TreeNode)x;
                TreeNode ty = (TreeNode)y;
                if ((tx.Tag as DirectoryEntry) != null && (ty.Tag as DirectoryEntry) != null)
                {
                    if (!((tx.Tag as DirectoryEntry).Properties["objectCategory"][0].ToString().ToLower().Split(',')[0] == (ty.Tag as DirectoryEntry).Properties["objectCategory"][0].ToString().ToLower().Split(',')[0]))
                    {
                        return String.Compare((tx.Tag as DirectoryEntry).Properties["objectCategory"][0].ToString().ToLower().Split(',')[0], (ty.Tag as DirectoryEntry).Properties["objectCategory"][0].ToString().ToLower().Split(',')[0]);
                    }

                }
                //return String.Compare((tx.Tag as DirectoryEntry).Properties["objectCategory"][0].ToString().ToLower().Split(',')[0], (ty.Tag as DirectoryEntry).Properties["objectCategory"][0].ToString().ToLower().Split(',')[0]);
                return 0;
            }
        }      

        #region UI
        private void frmSeekItAll_Load(object sender, EventArgs e)
        {
            tvResults.ImageList = frmMain.objTypeOmgList;
            string firstName = frmMain.domainAccountObject.FirstName;
            string lastName = frmMain.domainAccountObject.LastName;
            string domain = frmMain.domainAccountObject.StructClass.Split('|')[0];
            if (firstName != null && lastName != null)
            {
                tsLoggedUser.Text = domain.ToUpper() + @"\" + firstName.Substring(0, 1) + firstName.Substring(1, firstName.Length - 1).ToLower() + " " + lastName.Substring(0, 1) + lastName.Substring(1, lastName.Length - 1).ToLower() + " - (" + frmMain.domainAccountObject.Account + ")";
            }
        }
        private void tsLoggedUser_Click(object sender, EventArgs e)
        {
            frmSeek seekUser = new frmSeek();
            seekUser.userToQuery = frmMain.domainAccountObject.Account;
            seekUser.Show();
        }
        private void frmSeekItAll_Shown(object sender, EventArgs e)
        {
            if (unkToSeek != null)
            {
                txtBoxObject.Text = unkToSeek;
            }
        }
        #endregion

        private void txtBoxObject_TextChanged(object sender, EventArgs e)
        {
            tvResults.Nodes.Clear();
            int qrySize = txtBoxObject.Text.Count();
            this.Text = "Seeking for: " + txtBoxObject.Text;
            if ((txtBoxObject.Text != string.Empty) & (txtBoxObject.Text.Trim().Count() >= 3))
            {
                tvResults.Nodes.Clear();                

                //Seek Users---------------------------------------------------------
                Thread thloadAdUsers = new Thread(() =>
                {
                    try
                    {
                        if (txtBoxObject.Text.Count() == qrySize)
                        {
                            this.Invoke((MethodInvoker)delegate { tSUsers.Image = Seeker.Properties.Resources.smallPBarGreen; });
                            Thread.CurrentThread.Name = "thloadAdUsers";

                            TreeNode tGrpNodeUsers = new TreeNode();

                            if ((!tvResults.Nodes.ContainsKey("users")) & (txtBoxObject.Text.Count() == qrySize)) // & (!txtBoxObject.Text.Contains("(Insira pelo menos 3 Caracteres)")))
                            {
                                tGrpNodeUsers.Name = "users";
                                tGrpNodeUsers.Text = "Users";
                                tGrpNodeUsers.ImageIndex = 0;
                                tGrpNodeUsers.SelectedImageIndex = 0;
                                this.Invoke((MethodInvoker)delegate { tvResults.Nodes.Add(tGrpNodeUsers); });
                            }

                            int contUsers = 1;
                            var usersItems = new List<TreeNode>();

                            dLibAd searchUsers = new dLibAd();
                            using (PrincipalSearchResult<Principal> results = searchUsers.GetADUser(new PrincipalContext(ContextType.Domain,frmMain.domainAccountData[0],frmMain.domainAccountData[1],frmMain.domainAccountData[2]),txtBoxObject.Text.Trim()))
                            {
                                foreach (var foundUser in results)
                                {
                                    if (txtBoxObject.Text.Count() == qrySize)
                                    {
                                        if (foundUser != null)
                                        {
                                            this.Invoke((MethodInvoker)delegate
                                            {
                                                TreeNode tGrpNode = new TreeNode();
                                                tGrpNode.Text = foundUser.DisplayName + "," + foundUser.SamAccountName;
                                                tGrpNode.ImageIndex = 1;
                                                tGrpNode.SelectedImageIndex = 2;
                                                //tGrpNodeUsers.Nodes.Add(tGrpNode);
                                                usersItems.Add(tGrpNode);
                                                tGrpNodeUsers.Text = "Users(" + contUsers++ + ")";
                                            });
                                        }
                                    }
                                    else
                                    {
                                        this.Invoke((MethodInvoker)delegate { tSUsers.Image = new Bitmap(1, 1); });
                                        Thread.CurrentThread.Abort();
                                    }
                                    foundUser.Dispose();
                                }
                                this.Invoke((MethodInvoker)delegate
                                {
                                    TreeNode[] arr = usersItems.ToArray();
                                    tvResults.BeginUpdate();
                                    tGrpNodeUsers.Nodes.AddRange(arr);
                                    tvResults.EndUpdate();
                                    this.Invoke((MethodInvoker)delegate { tSUsers.Image = new Bitmap(1, 1); });
                                });
                            }
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate { tSUsers.Image = new Bitmap(1, 1); });
                            Thread.CurrentThread.Abort();
                        }
                    }
                    catch
                    {
                        Thread.CurrentThread.Abort();
                    }
                });

                //-------------------------------------------------------------

                // Seek Computers ---------------------------------------------
                Thread thloadAdComputers = new Thread(() =>
                {
                    try
                    {
                        if (txtBoxObject.Text.Count() == qrySize)
                        {
                            this.Invoke((MethodInvoker)delegate { tSComputers.Image = Seeker.Properties.Resources.smallPBarBlue; });
                            Thread.CurrentThread.Name = "thloadAdComputers";


                            TreeNode tGrpNodeComputers = new TreeNode();

                            if ((!tvResults.Nodes.ContainsKey("computers")) & (txtBoxObject.Text.Count() == qrySize)) //& (!txtBoxObject.Text.Contains("(Insira pelo menos 3 Caracteres)")))
                            {
                                tGrpNodeComputers.Name = "computers";
                                tGrpNodeComputers.Text = "Computers";
                                tGrpNodeComputers.ImageIndex = 3;
                                tGrpNodeComputers.SelectedImageIndex = 3;
                                this.Invoke((MethodInvoker)delegate { tvResults.Nodes.Add(tGrpNodeComputers); });
                            }

                            int contComputers = 1;
                            var computersItems = new List<TreeNode>();
                            dLibAd searchComputers = new dLibAd();
                            using (PrincipalSearchResult<Principal> resultsComputers = searchComputers.GetADComputer(new PrincipalContext(ContextType.Domain,frmMain.domainAccountData[0],frmMain.domainAccountData[1],frmMain.domainAccountData[2]),txtBoxObject.Text.Trim()))
                            {
                                foreach (var foundComputer in resultsComputers)
                                {
                                    if (txtBoxObject.Text.Count() == qrySize)
                                    {
                                        if (foundComputer != null)
                                        {
                                            try
                                            {
                                                this.Invoke((MethodInvoker)delegate
                                                {
                                                    TreeNode tGrpNode = new TreeNode();
                                                    tGrpNode.Text = foundComputer.SamAccountName.Substring(0, foundComputer.SamAccountName.Length - 1) + "," + foundComputer.DisplayName;
                                                    tGrpNode.ImageIndex = 4;
                                                    tGrpNode.SelectedImageIndex = 5;
                                                    //tGrpNodeComputers.Nodes.Add(tGrpNode);
                                                    computersItems.Add(tGrpNode);
                                                    tGrpNodeComputers.Text = "Computers(" + contComputers++ + ")";
                                                });
                                            }
                                            catch { }
                                        }
                                    }
                                    else
                                    {
                                        this.Invoke((MethodInvoker)delegate { tSComputers.Image = new Bitmap(1, 1); });
                                        Thread.CurrentThread.Abort();
                                    }
                                    foundComputer.Dispose();
                                }
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                //Stopwatch testTime = new Stopwatch();
                                TreeNode[] arr = computersItems.ToArray();

                                //testTime.Start();
                                tvResults.BeginUpdate();
                                //foreach (ListViewItem item in items)
                                tGrpNodeComputers.Nodes.AddRange(arr);
                                tvResults.EndUpdate();
                                arr = null;
                                computersItems = null;
                                //testTime.Stop();
                                this.Invoke((MethodInvoker)delegate { tSComputers.Image = new Bitmap(1, 1); });
                            });
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate { tSComputers.Image = new Bitmap(1, 1); });
                            Thread.CurrentThread.Abort();
                        }
                    }
                    catch
                    {
                        Thread.CurrentThread.Abort();
                    }
                });

                //-------------------------------------------------------------

               

                //Seek Groups---------------------------------------------------------
                Thread thloadAdGroups = new Thread(() =>
                {
                    try
                    {
                        if (txtBoxObject.Text.Count() == qrySize)
                        {
                            this.Invoke((MethodInvoker)delegate { tSGroups.Image = Seeker.Properties.Resources.smallPbarYellow; });
                            Thread.CurrentThread.Name = "thloadAdGroups";

                            TreeNode tGrpNodeGroups = new TreeNode();

                            if ((!tvResults.Nodes.ContainsKey("groups")) & (txtBoxObject.Text.Count() == qrySize))
                            {
                                tGrpNodeGroups.Name = "groups";
                                tGrpNodeGroups.Text = "Groups";
                                tGrpNodeGroups.ImageIndex = 9;
                                tGrpNodeGroups.SelectedImageIndex = 9;
                                this.Invoke((MethodInvoker)delegate { tvResults.Nodes.Add(tGrpNodeGroups); });
                            }

                            int contGroups = 1;
                            var groupsItems = new List<TreeNode>();
                            dLibAd searchGroups = new dLibAd();
                            using (PrincipalSearchResult<Principal> results = searchGroups.GetADGroup(new PrincipalContext(ContextType.Domain,frmMain.domainAccountData[0],frmMain.domainAccountData[1],frmMain.domainAccountData[2]),txtBoxObject.Text.Trim(), false))
                            {
                                foreach (var foundGroup in results)
                                {
                                    if (txtBoxObject.Text.Count() == qrySize)
                                    {
                                        if (foundGroup != null)
                                        {
                                            this.Invoke((MethodInvoker)delegate
                                            {
                                                TreeNode tGrpNode = new TreeNode();
                                                tGrpNode.Text = foundGroup.SamAccountName;
                                                tGrpNode.ImageIndex = 10;
                                                tGrpNode.SelectedImageIndex = 11;
                                                //tGrpNodeGroups.Nodes.Add(tGrpNode);
                                                groupsItems.Add(tGrpNode);
                                                tGrpNodeGroups.Text = "Groups(" + contGroups++ + ")";
                                            });
                                        }
                                    }
                                    else
                                    {
                                        this.Invoke((MethodInvoker)delegate { tSGroups.Image = new Bitmap(1, 1); });
                                        Thread.CurrentThread.Abort();
                                    }
                                    foundGroup.Dispose();
                                }
                                this.Invoke((MethodInvoker)delegate
                                {
                                    TreeNode[] arr = groupsItems.ToArray();
                                    tvResults.BeginUpdate();
                                    tGrpNodeGroups.Nodes.AddRange(arr);
                                    tvResults.EndUpdate();
                                    this.Invoke((MethodInvoker)delegate { tSGroups.Image = new Bitmap(1, 1); });
                                });
                            }
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate { tSGroups.Image = new Bitmap(1, 1); });
                            Thread.CurrentThread.Abort();
                        }
                    }
                    catch
                    {
                        Thread.CurrentThread.Abort();
                    }
                });

                //-------------------------------------------------------------

                //Seek OUS---------------------------------------------------------
                Thread thloadAdOUS = new Thread(() =>
                {
                    try
                    {
                        if (txtBoxObject.Text.Count() == qrySize)
                        {
                            this.Invoke((MethodInvoker)delegate { tSOUs.Image = Seeker.Properties.Resources.smallPbarYellow; });
                            Thread.CurrentThread.Name = "thloadAdOUS";                            
                            DirectoryEntry deBase = new DirectoryEntry("LDAP://" + frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]);

                            string sanitizedOU = txtBoxObject.Text;
                            sanitizedOU = Regex.Replace(sanitizedOU, @"[^\w\.@-]", "Seeker",

                                    RegexOptions.None);


                            TreeNode tGrpNodeOus = new TreeNode();

                            if ((!tvResults.Nodes.ContainsKey("ous")) & (txtBoxObject.Text.Count() == qrySize))
                            {
                                tGrpNodeOus.Name = "ous";
                                tGrpNodeOus.Text = "OU's";
                                tGrpNodeOus.ImageIndex = 13;
                                tGrpNodeOus.SelectedImageIndex = 13;
                                this.Invoke((MethodInvoker)delegate { tvResults.Nodes.Add(tGrpNodeOus); });
                            }

                            int contGroups = 1;
                            var ousItems = new List<TreeNode>();
                            dLibAd searchOus = new dLibAd();
                            using (SearchResultCollection l = searchOus.GetADOu(deBase, sanitizedOU))
                            {
                                foreach (SearchResult foundOu in l)
                                {
                                    if (txtBoxObject.Text.Count() == qrySize)
                                    {
                                        if (foundOu != null)
                                        {
                                            this.Invoke((MethodInvoker)delegate
                                            {
                                                TreeNode tGrpNode = new TreeNode();
                                                tGrpNode.Text = tGrpNode.Text = foundOu.Properties["name"][0].ToString() + "-" + foundOu.Properties["distinguishedName"][0].ToString();
                                                tGrpNode.Tag = foundOu.Properties["distinguishedName"][0].ToString();
                                                tGrpNode.ImageIndex = 14;
                                                tGrpNode.SelectedImageIndex = 15;
                                                //tGrpNodeOus.Nodes.Add(tGrpNode);
                                                ousItems.Add(tGrpNode);
                                                tGrpNodeOus.Text = "OU's(" + contGroups++ + ")";
                                            });
                                        }
                                    }
                                    else
                                    {
                                        this.Invoke((MethodInvoker)delegate { tSOUs.Image = new Bitmap(1, 1); });
                                        Thread.CurrentThread.Abort();
                                    }
                                }
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                TreeNode[] arr = ousItems.ToArray();
                                tvResults.BeginUpdate();
                                tGrpNodeOus.Nodes.AddRange(arr);
                                tvResults.EndUpdate();
                                this.Invoke((MethodInvoker)delegate { tSOUs.Image = new Bitmap(1, 1); });
                            });
                            deBase.Dispose();
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate { tSOUs.Image = new Bitmap(1, 1); });
                            Thread.CurrentThread.Abort();
                        }
                    }
                    catch
                    {
                        Thread.CurrentThread.Abort();
                    }
                });

                //-------------------------------------------------------------

                //Threads Start------------------------------------------------              
                thloadAdUsers.Start();
                thloadAdComputers.Start();
                thloadAdGroups.Start();
                thloadAdOUS.Start();
                //-------------------------------------------------------------
            }
            else
            {
                if (txtBoxObject.Text.Count() == 0)
                {
                    this.Text = "What are you Seeking Today ?";
                    txtBoxObject.SelectionStart = 0;
                    txtBoxObject.SelectionLength = txtBoxObject.Text.Length;
                }
            }
            tvResults.TreeViewNodeSorter = new NodeSorterByName();
            tvResults.Sort();
        }

        private void tvResults_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((tvResults.SelectedNode.Parent != null) && (tvResults.SelectedNode.Text != string.Empty))
            {
                switch (tvResults.SelectedNode.Parent.Name)
                {
                    case "users":
                        try
                        {
                            dLibAd.adUsers selectedUser = dLibAd.locateUsr(new PrincipalContext(ContextType.Domain, frmMain.domainAccountData[0], frmMain.domainAccountData[1], frmMain.domainAccountData[2]), tvResults.SelectedNode.Text.Split(',')[1]);
                            if ((selectedUser != null) && (selectedUser.Photo != null))
                            {
                                selectedUserPic.Image = selectedUser.Photo;
                                splitMain.Panel2Collapsed = false;
                            }
                        }
                        catch
                        {
                            splitMain.Panel2Collapsed = true;
                        }
                        break;                   
                    default:
                        splitMain.Panel2Collapsed = true;
                        break;
                }
            }
        }

        private void tvResults_DoubleClick(object sender, EventArgs e)
        {
            if (tvResults.SelectedNode != null)
            {
                //User Seek
                if ((tvResults.SelectedNode.Parent != null) && (tvResults.SelectedNode.Text != string.Empty) && (tvResults.SelectedNode.Parent.Name.Contains("users")))
                {
                    frmSeek userToSeek = new frmSeek();                    
                    userToSeek.userToQuery = tvResults.SelectedNode.Text.Split(',')[1];
                    userToSeek.WindowState = FormWindowState.Normal;
                    userToSeek.Show();
                }

                //Computer Seek
                if ((tvResults.SelectedNode.Parent != null) && (tvResults.SelectedNode.Text != string.Empty) && (tvResults.SelectedNode.Parent.Name.Contains("computer")))
                {
                    frmSeekComputer computerToSeek = new frmSeekComputer();                    
                    computerToSeek.machineToQuery = tvResults.SelectedNode.Text.Split(',')[0];
                    computerToSeek.WindowState = FormWindowState.Normal;
                    computerToSeek.Show();
                }             

                //Group Seek
                if ((tvResults.SelectedNode.Parent != null) && (tvResults.SelectedNode.Text != string.Empty) && (tvResults.SelectedNode.Parent.Name.Contains("group")))
                {
                    frmSeekGroup frmSeekGroup = new frmSeekGroup();                    
                    frmSeekGroup.groupToQuery = tvResults.SelectedNode.Text;
                    frmSeekGroup.WindowState = FormWindowState.Normal;
                    frmSeekGroup.Show();
                }

                //OU Seek
                if ((tvResults.SelectedNode.Parent != null) && (tvResults.SelectedNode.Text != string.Empty) && (tvResults.SelectedNode.Parent.Name.Contains("ous")))
                {
                    frmSeekOu frmSeekOu = new frmSeekOu();                    
                    frmSeekOu.ouToQuery = tvResults.SelectedNode.Tag.ToString();
                    frmSeekOu.WindowState = FormWindowState.Normal;
                    frmSeekOu.Show();
                }              
            }
        }

        private void txtBoxObject_KeyPress(object sender, KeyPressEventArgs e)
        {
            splitMain.Panel2Collapsed = true;
        }



        private void tvResults_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {                
                if ((tvResults.SelectedNode != null) && (tvResults.SelectedNode.Parent != null) && (tvResults.SelectedNode.Text != string.Empty) && (tvResults.SelectedNode.Parent.Name.Contains("ous")))
                {
                    cMenuOu.Show(MousePosition);
                }
            }
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateUserDialog createUser = new frmCreateUserDialog();
            createUser.destOu = tvResults.SelectedNode.Tag.ToString();
            createUser.WindowState = FormWindowState.Normal;
            createUser.Show();
        }

        private void frmSeekItAll_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }
    }
}
