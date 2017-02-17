//...The uninitiated perceive time with no appreciation of the beginning
//and no understanding of the end. To them, time is an infinite commodity. 
//We know better. And we will not waste a second of it. 
//This Is Who We Are...

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
using System.DirectoryServices.ActiveDirectory;
using dLibAdJobs;
using Microsoft.Win32;
using dLibCypherJobs;
using System.Diagnostics;



namespace Seeker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        dLibAd.adUsers userAccount = new dLibAd.adUsers();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Environment.UserDomainName != string.Empty)
            {
                try
                {
                    //Get Domains list into ComboBox            
                    using (var forest = Forest.GetCurrentForest())
                    {
                        foreach (Domain domain in forest.Domains)
                        {
                            cbBoxDomains.Items.Add(domain.Name);
                            domain.Dispose();
                        }
                    }

                    if (cbBoxDomains.Items.Count > 0)
                    {
                        cbBoxDomains.SelectedIndex = 0;
                    }
                }
                catch
                {
                    MessageBox.Show("Sorry, but Seeker is a Tool meant to be used on Domain Environment", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Sorry, but Seeker is a Tool meant to be used on Domain Environment", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            //----------------------------------------------
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            //loadLoginsKeys();
            //if (lvLogins.Items.Count > 0)
            //{
            //    tbcLogin.SelectedTab = tbpLogins;
            //}
            //txtBoxUser.Focus();
        }

        #region UI
        private void updateProgress(int status)
        {
            switch (status)
            {
                case 0:
                    txtBoxUser.Enabled = true;
                    txtBoxPass.Enabled = true;
                    ckBoxSaveCredentials.Enabled = true;
                    pboxLoginProgress.Visible = false;
                    pboxLoginProgress2.Visible = false;
                    btnLogin.Enabled = true;
                    lvLogins.Enabled = true;
                    //txtBoxUser.Text = "";
                    txtBoxPass.Text = "";
                    break;
                case 1:
                    txtBoxUser.Enabled = false;
                    txtBoxPass.Enabled = false;
                    ckBoxSaveCredentials.Enabled = false;
                    pboxLoginProgress.Visible = true;
                    pboxLoginProgress2.Visible = true;
                    btnLogin.Enabled = false;
                    lvLogins.Enabled = false;
                    break;
            }
        }
        #endregion
        
        #region Login Logic
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            string domain = string.Empty, user = string.Empty, pass = string.Empty;

            Thread thLogin;
            thLogin = new Thread(() =>
            {
                try
                {
                    using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain))
                    {
                        isValid = pc.ValidateCredentials(user, pass);
                    }
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("Seeker",
                   "Can't authenticate User: " + domain + @"\" + user +
                   "\n\nMessage: " + ex.Message +
                   "\n\nSource: " + ex.Source +
                   "\n\nStack: " + ex.StackTrace +
                   "\n\nTarget: " + ex.TargetSite, EventLogEntryType.Error, 3310, 00);
                }

                if (isValid)
                {
                    userAccount = dLibAd.locateUsr(new PrincipalContext(ContextType.Domain, domain, user, pass), user);
                    userAccount.StructClass = domain + "|" + user + "|" + pass;

                    frmMain.domainAccountData = new string[] { domain, user, pass };
                    frmMain.domainAccountObject = userAccount;
                    if (ckBoxSaveCredentials.Checked)
                    {
                        saveLogin(domain, user, pass);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("Invalid Credentials", "Something went Wrong...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        updateProgress(0);
                    });
                }
            });


            //Start Login Process
            if (cbBoxDomains.SelectedItem != null)
            {
                domain = cbBoxDomains.SelectedItem.ToString();
            }
            else
            {
                domain = cbBoxDomains.Text.Trim();
            }

            if (lvLogins.SelectedItems.Count > 0)
            {
                dLibAd.adUsers currentSelectedUser = (dLibAd.adUsers)lvLogins.SelectedItems[0].Tag;
                user = dLibCypher.DecText(currentSelectedUser.StructClass.Split('|')[0], "OC7Wwx9vui*y6ltCTv,e*u$z+4Hv:o%uSYZB5P7dpaYa5N.zsx.SP]lvAL7k50dA");
                pass = dLibCypher.DecText(currentSelectedUser.StructClass.Split('|')[1], "OC7Wwx9vui*y6ltCTv,e*u$z+4Hv:o%uSYZB5P7dpaYa5N.zsx.SP]lvAL7k50dA");
                updateProgress(1);
                thLogin.Start();
            }
            else
            {
                if (txtBoxUser.Text != string.Empty && txtBoxUser.Text != string.Empty)
                {
                    user = txtBoxUser.Text;
                    pass = txtBoxPass.Text;
                    updateProgress(1);
                    thLogin.Start();
                }
                else
                {
                    MessageBox.Show("You have to enter your Credentials first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadLoginsKeys()
        {
            lvLogins.Items.Clear();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Seeker", true);
            if (key != null)
            {
                foreach (string keyItem in key.GetSubKeyNames())
                {
                    dLibAd.adUsers loginUser = loadLogin(keyItem, cbBoxDomains.SelectedItem.ToString());
                    if (loginUser != null)
                    {
                        ListViewItem loginItem = new ListViewItem();
                        loginItem.Name = loginUser.Account;
                        loginItem.Text = loginUser.Account;
                        loginItem.Tag = loginUser;
                        lvLogins.Items.Add(loginItem);
                    }                   
                }
            }
            if (!(lvLogins.Items.Count > 0))
            {
                tbcLogin.SelectTab(tbpNewLogin);
            }
        }
        private dLibAd.adUsers loadLogin(string user, string domain)
        {
            string decUser = "";
            dLibAd.adUsers userObject = new dLibAd.adUsers();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Seeker\" + user, false);
            if (key != null)
            {
                decUser = dLibCypher.DecText(key.GetValue("0").ToString(), "OC7Wwx9vui*y6ltCTv,e*u$z+4Hv:o%uSYZB5P7dpaYa5N.zsx.SP]lvAL7k50dA");
                userObject = dLibAd.locateUsr(new PrincipalContext(ContextType.Domain,cbBoxDomains.SelectedItem.ToString()), decUser);
                if (userObject != null)
                {
                    userObject.StructClass = key.GetValue("0").ToString() + "|" + key.GetValue("1").ToString();
                }
            }
            return userObject;
        }

        private void saveLogin(string domain, string user, string pass)
        {
            string cUser = dLibCypher.EncText(user.ToUpper(), "OC7Wwx9vui*y6ltCTv,e*u$z+4Hv:o%uSYZB5P7dpaYa5N.zsx.SP]lvAL7k50dA");
            string cPass = dLibCypher.EncText(pass, "OC7Wwx9vui*y6ltCTv,e*u$z+4Hv:o%uSYZB5P7dpaYa5N.zsx.SP]lvAL7k50dA");
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            if (key.OpenSubKey("Seeker", false) == null)
            {
                key.CreateSubKey("Seeker");
            }

            RegistryKey keySeeker = Registry.CurrentUser.OpenSubKey(@"Software\Seeker", true);
            keySeeker.CreateSubKey(cUser);

            RegistryKey keySeekerUser = Registry.CurrentUser.OpenSubKey(@"Software\Seeker\" + cUser, true);
            keySeekerUser.SetValue("0", cUser);
            keySeekerUser.SetValue("1", cPass);
        }

        private void deleteLogin(string user, Boolean clear)
        {
            if (!clear)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Seeker", true);
                if (key != null)
                {
                    foreach (string keyItem in key.GetSubKeyNames())
                    {
                        string decUser = dLibCypher.DecText(keyItem, "OC7Wwx9vui*y6ltCTv,e*u$z+4Hv:o%uSYZB5P7dpaYa5N.zsx.SP]lvAL7k50dA");
                        if (decUser.Contains(user.ToUpper()))
                        {
                            RegistryKey keyUser = Registry.CurrentUser.OpenSubKey(@"Software\Seeker\", true);
                            keyUser.DeleteSubKey(keyItem);
                        }
                    }
                }
                loadLoginsKeys();
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Seeker", true);
                if (key != null)
                {
                    foreach (string keyItem in key.GetSubKeyNames())
                    {
                        key.DeleteSubKey(keyItem);
                    }
                }
            }
        }
        #endregion

        private void lvLogins_DoubleClick(object sender, EventArgs e)
        {
            if (lvLogins.SelectedItems.Count > 0)
            {
                btnLogin.PerformClick();
            }
        }     

        private void lvLogins_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvLogins.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    cMenuDelete.Show(Cursor.Position);
                }
            }
        }

        private void deleteLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvLogins.SelectedItems.Count > 0)
            {
                deleteLogin(lvLogins.SelectedItems[0].Text, false);
                MessageBox.Show("Login deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ckBoxSaveCredentials.Checked = true;
                btnLogin.PerformClick();
            }
        }

        private void tbcLogin_Enter(object sender, EventArgs e)
        {
            loadLoginsKeys();
            if (lvLogins.Items.Count > 0)
            {
                tbcLogin.SelectedTab = tbpLogins;
            }
            txtBoxUser.Focus();
        }
    }
}
