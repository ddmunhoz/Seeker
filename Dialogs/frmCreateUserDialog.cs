using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using genEx;



namespace Seeker
{
    public partial class frmCreateUserDialog : Form
    {        
        public string destOu { get; set; }
        UserPrincipal upUserToCreate;
        StringBuilder resultRtbox = new StringBuilder();

        public frmCreateUserDialog()
        {
            InitializeComponent();
        }

        private void frmCreateUserDialog_Load(object sender, EventArgs e)
        {
            
            dtpExpires.Value = DateTime.Today;           

            //Get Domains list into ComboBox            
            using (var forest = Forest.GetCurrentForest())
            {
                foreach (Domain domain in forest.Domains)
                {
                    cbBoxDomains.Items.Add("@" + domain.Name);
                    domain.Dispose();
                }
            }
            if (cbBoxDomains.Items.Count > 0)
            {
                cbBoxDomains.SelectedIndex = 0;
            }

            //Format OU            
            string ouDN = destOu.Replace("CN=", string.Empty).Replace("DC=", string.Empty).Replace("OU=", string.Empty).Replace(",", "/");
            createIn.Text = ouDN;
            createIn2nd.Text = ouDN;
            createIn3rd.Text = ouDN;


            //BlockTabNavigation
            tbcMain.KeyDown += new KeyEventHandler(tbcMain_KeyDown);
            generalExtensions.EnableTab(tbpMiddle, false);
            generalExtensions.EnableTab(tbpEnd, false);
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            //UserObject
            PrincipalContext pcUserToCreate = new PrincipalContext(ContextType.Domain,frmMain.domainAccountData[0],destOu, frmMain.domainAccountData[1], frmMain.domainAccountData[2]);
            upUserToCreate = new UserPrincipal(pcUserToCreate);

            if ((tBoxFirstName.Text != string.Empty) && (tBoxLastName.Text != string.Empty))
            {
                upUserToCreate.Name = tBoxFirstName.Text;
                upUserToCreate.Surname = tBoxLastName.Text;
                upUserToCreate.DisplayName = tBoxFullName.Text;
                upUserToCreate.SamAccountName = tBoxPre2000LogonName.Text;                

                upUserToCreate.UserPrincipalName = tBoxPre2000LogonName.Text + cbBoxDomains.SelectedItem.ToString();

                if (rbEndOf.Checked)
                {
                    upUserToCreate.AccountExpirationDate = dtpExpires.Value;
                }

                generalExtensions.EnableTab(tbpStart, false);
                generalExtensions.EnableTab(tbpMiddle, true);
                generalExtensions.EnableTab(tbpEnd, false);
                tbcMain.SelectedTab = tbcMain.TabPages[1];
            }
            else
            {
                MessageBox.Show("Please fill at least: First, Last and User logon name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnNext2nd_Click(object sender, EventArgs e)
        {
            tBoxPass1st.Focus();
            if (tBoxPass1st.Text == tBoxPass2nd.Text)
            {
                if (generalExtensions.checkDiacritics(tBoxPass1st.Text))
                {
                    resultRtbox.Append(Environment.NewLine + "Full name: " + upUserToCreate.Name + Environment.NewLine);
                    resultRtbox.Append(Environment.NewLine + "User logon name: " + upUserToCreate.UserPrincipalName + Environment.NewLine);
                    if (ckChangePass.Checked)
                    {
                        //upUserToCreate.ExpirePasswordNow();
                        resultRtbox.Append(Environment.NewLine + "The user must change the password at next logon." + Environment.NewLine);
                    }

                    if (ckCannotChange.Checked)
                    {
                        //upUserToCreate.UserCannotChangePassword = true;
                        resultRtbox.Append(Environment.NewLine + "The user cannot change the password." + Environment.NewLine);
                    }

                    if (ckPNeverExpires.Checked)
                    {
                        //upUserToCreate.PasswordNeverExpires = true;
                        resultRtbox.Append(Environment.NewLine + "The password never expires." + Environment.NewLine);
                    }

                    if (ckAccountDisable.Checked)
                    {
                        //upUserToCreate.Enabled = false;
                        resultRtbox.Append(Environment.NewLine + "The account is disabled." + Environment.NewLine);
                    }
                    upUserToCreate.SetPassword(tBoxPass1st.Text);
                    rtBoxDetails.Text = resultRtbox.ToString();
                    generalExtensions.EnableTab(tbpStart, false);
                    generalExtensions.EnableTab(tbpMiddle, false);
                    generalExtensions.EnableTab(tbpEnd, true);
                    tbcMain.SelectedTab = tbcMain.TabPages[2];
                    tBoxPass1st.Focus();
                }
                else
                {
                    MessageBox.Show("Your password does not meet the complexity criteria: \nAt least one upper character, on lower, one numeral, one special. Minimum of 8 digits", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tBoxPass1st.Focus();
                }
            }
            else
            {
                MessageBox.Show("The passwords do not match.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxPass1st.Focus();
            }

        }

        private void ckCannotChange_Click(object sender, EventArgs e)
        {
            if (ckChangePass.Checked)
            {
                MessageBox.Show("You cannot check both User must change password at next logon \n and user cannot change password for the same user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ckCannotChange.Checked = false;
            }
        }

        private void ckChangePass_Click(object sender, EventArgs e)
        {
            if ((ckPNeverExpires.Checked == false) && (ckCannotChange.Checked == true))
            {
                MessageBox.Show("You cannot check both User must change password at next logon \nand user cannot change password for the same user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ckChangePass.Checked = false;
            }
            else
            {
                if (ckPNeverExpires.Checked)
                {
                    MessageBox.Show("You specified that the password should never expire.\nThe user win not be required to change the password at next\nLogon", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ckChangePass.Checked = false;
                }
            }
        }

        private void ckPNeverExpires_Click(object sender, EventArgs e)
        {
            if (ckChangePass.Checked)
            {
                MessageBox.Show("You specified that the password should never expire.\nThe user win not be required to change the password at next\nLogon", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ckChangePass.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            generalExtensions.EnableTab(tbpStart, true);
            generalExtensions.EnableTab(tbpMiddle, false);
            generalExtensions.EnableTab(tbpEnd, false);
            tbcMain.SelectedTab = tbcMain.TabPages[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            generalExtensions.EnableTab(tbpStart, false);
            generalExtensions.EnableTab(tbpMiddle, true);
            generalExtensions.EnableTab(tbpEnd, false);
            rtBoxDetails.Text = "";
            resultRtbox.Clear();
            tbcMain.SelectedTab = tbcMain.TabPages[1];
        }

        private void cbBoxDomains_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxDomain.Text = cbBoxDomains.SelectedItem.ToString().Substring(1, cbBoxDomains.SelectedItem.ToString().IndexOf('.') - 1).ToUpper() + @"\";
        }

        private void tBoxLogonName_TextChanged(object sender, EventArgs e)
        {
            tBoxPre2000LogonName.Text = tBoxLogonName.Text;
        }

        private void tBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            tBoxFullName.Text = tBoxFirstName.Text + " " + tBoxLastName.Text;
        }

        private void tBoxLastName_TextChanged(object sender, EventArgs e)
        {
            tBoxFullName.Text = tBoxFirstName.Text + " " + tBoxLastName.Text;
        }

        private void btnCancel2nd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel3rd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
               
                    if (ckChangePass.Checked)
                    {
                        upUserToCreate.ExpirePasswordNow();
                    }

                    if (ckCannotChange.Checked)
                    {
                        upUserToCreate.UserCannotChangePassword = true;
                    }

                    if (ckPNeverExpires.Checked)
                    {
                        upUserToCreate.PasswordNeverExpires = true;
                    }

                    if (ckAccountDisable.Checked)
                    {
                        upUserToCreate.Enabled = false;
                    }
                    else 
                    { 
                        upUserToCreate.Enabled = true; 
                    }
                    upUserToCreate.Save();
                    MessageBox.Show("User created Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();               
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("denied"))
                {
                    MessageBox.Show("Access Denied!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Message.Contains("exists"))
                {
                    MessageBox.Show("This users already exists on: \n" + destOu, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void tbcMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }
        }

        private void rbEndOf_Click(object sender, EventArgs e)
        {
            rbNever.Checked = false;
        }

        private void rbEndOf_CheckedChanged(object sender, EventArgs e)
        {

            dtpExpires_ValueChanged(null,null);
            if (rbEndOf.Checked)
            {
                dtpExpires.Enabled = true;
            }
            else
            {
                dtpExpires.Enabled = false;
            }
        }

        private void rbNever_Click(object sender, EventArgs e)
        {
            rbEndOf.Checked = false;
        }

        private void tBoxLogonName_Leave(object sender, EventArgs e)
        {
            
        }

        private void dtpExpires_ValueChanged(object sender, EventArgs e)
        {
            if (rbEndOf.Checked)
            {
                if ((dtpExpires.Value - DateTime.Today).TotalDays > 0)
                {
                    gBoxTimeOut.Text = "Account Expires in: " + (dtpExpires.Value - DateTime.Today).TotalDays.ToString();
                    gBoxTimeOut.ForeColor = Color.Blue;
                }
                else
                {
                    gBoxTimeOut.Text = "The account will be created Expired!";
                    gBoxTimeOut.ForeColor = Color.Red;
                }
            }
        }
    }
}

