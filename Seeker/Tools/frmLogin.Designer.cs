namespace Seeker
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblMainBottom = new System.Windows.Forms.TableLayoutPanel();
            this.cbBoxDomains = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbcLogin = new System.Windows.Forms.TabControl();
            this.tbpNewLogin = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckBoxSaveCredentials = new System.Windows.Forms.CheckBox();
            this.pboxLoginProgress = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbpLogins = new System.Windows.Forms.TabPage();
            this.pboxLoginProgress2 = new System.Windows.Forms.PictureBox();
            this.lvLogins = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMenuDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblMain.SuspendLayout();
            this.tblMainBottom.SuspendLayout();
            this.tbcLogin.SuspendLayout();
            this.tbpNewLogin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLoginProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbpLogins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLoginProgress2)).BeginInit();
            this.cMenuDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblMainBottom, 0, 1);
            this.tblMain.Controls.Add(this.tbcLogin, 0, 0);
            this.tblMain.Location = new System.Drawing.Point(3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(256, 236);
            this.tblMain.TabIndex = 0;
            // 
            // tblMainBottom
            // 
            this.tblMainBottom.ColumnCount = 2;
            this.tblMainBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.59677F));
            this.tblMainBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.40322F));
            this.tblMainBottom.Controls.Add(this.cbBoxDomains, 0, 0);
            this.tblMainBottom.Controls.Add(this.btnLogin, 1, 0);
            this.tblMainBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainBottom.Location = new System.Drawing.Point(4, 198);
            this.tblMainBottom.Name = "tblMainBottom";
            this.tblMainBottom.RowCount = 1;
            this.tblMainBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMainBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMainBottom.Size = new System.Drawing.Size(248, 34);
            this.tblMainBottom.TabIndex = 1;
            // 
            // cbBoxDomains
            // 
            this.cbBoxDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoxDomains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoxDomains.FormattingEnabled = true;
            this.cbBoxDomains.Location = new System.Drawing.Point(3, 3);
            this.cbBoxDomains.Name = "cbBoxDomains";
            this.cbBoxDomains.Size = new System.Drawing.Size(179, 21);
            this.cbBoxDomains.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Image = global::Seeker.Properties.Resources._0431;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(188, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(57, 24);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbcLogin
            // 
            this.tbcLogin.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcLogin.Controls.Add(this.tbpNewLogin);
            this.tbcLogin.Controls.Add(this.tbpLogins);
            this.tbcLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcLogin.Location = new System.Drawing.Point(4, 4);
            this.tbcLogin.Name = "tbcLogin";
            this.tbcLogin.SelectedIndex = 0;
            this.tbcLogin.Size = new System.Drawing.Size(248, 187);
            this.tbcLogin.TabIndex = 1;
            // 
            // tbpNewLogin
            // 
            this.tbpNewLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpNewLogin.Controls.Add(this.tableLayoutPanel1);
            this.tbpNewLogin.Location = new System.Drawing.Point(4, 25);
            this.tbpNewLogin.Name = "tbpNewLogin";
            this.tbpNewLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNewLogin.Size = new System.Drawing.Size(240, 158);
            this.tbpNewLogin.TabIndex = 1;
            this.tbpNewLogin.Text = "New Login";
            this.tbpNewLogin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.30252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.69748F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.txtBoxPass, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxUser, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ckBoxSaveCredentials, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.pboxLoginProgress, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(232, 154);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxPass, 2);
            this.txtBoxPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPass.Location = new System.Drawing.Point(69, 71);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(160, 20);
            this.txtBoxPass.TabIndex = 1;
            this.txtBoxPass.UseSystemPasswordChar = true;
            this.txtBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPass_KeyDown);
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxUser, 2);
            this.txtBoxUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxUser.Location = new System.Drawing.Point(69, 47);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(160, 20);
            this.txtBoxUser.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // ckBoxSaveCredentials
            // 
            this.ckBoxSaveCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBoxSaveCredentials.AutoSize = true;
            this.ckBoxSaveCredentials.Location = new System.Drawing.Point(178, 96);
            this.ckBoxSaveCredentials.Name = "ckBoxSaveCredentials";
            this.ckBoxSaveCredentials.Size = new System.Drawing.Size(51, 17);
            this.ckBoxSaveCredentials.TabIndex = 2;
            this.ckBoxSaveCredentials.Text = "Save";
            this.ckBoxSaveCredentials.UseVisualStyleBackColor = true;
            // 
            // pboxLoginProgress
            // 
            this.pboxLoginProgress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pboxLoginProgress.Image = ((System.Drawing.Image)(resources.GetObject("pboxLoginProgress.Image")));
            this.pboxLoginProgress.Location = new System.Drawing.Point(81, 106);
            this.pboxLoginProgress.Name = "pboxLoginProgress";
            this.pboxLoginProgress.Size = new System.Drawing.Size(34, 34);
            this.pboxLoginProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxLoginProgress.TabIndex = 5;
            this.pboxLoginProgress.TabStop = false;
            this.pboxLoginProgress.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::Seeker.Properties.Resources.Seeker;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tbpLogins
            // 
            this.tbpLogins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpLogins.Controls.Add(this.pboxLoginProgress2);
            this.tbpLogins.Controls.Add(this.lvLogins);
            this.tbpLogins.Location = new System.Drawing.Point(4, 25);
            this.tbpLogins.Name = "tbpLogins";
            this.tbpLogins.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLogins.Size = new System.Drawing.Size(240, 158);
            this.tbpLogins.TabIndex = 0;
            this.tbpLogins.Text = "Logins";
            this.tbpLogins.UseVisualStyleBackColor = true;
            // 
            // pboxLoginProgress2
            // 
            this.pboxLoginProgress2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxLoginProgress2.Image = ((System.Drawing.Image)(resources.GetObject("pboxLoginProgress2.Image")));
            this.pboxLoginProgress2.Location = new System.Drawing.Point(82, 106);
            this.pboxLoginProgress2.Name = "pboxLoginProgress2";
            this.pboxLoginProgress2.Size = new System.Drawing.Size(34, 34);
            this.pboxLoginProgress2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxLoginProgress2.TabIndex = 5;
            this.pboxLoginProgress2.TabStop = false;
            this.pboxLoginProgress2.Visible = false;
            // 
            // lvLogins
            // 
            this.lvLogins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLogins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvLogins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLogins.Location = new System.Drawing.Point(3, 3);
            this.lvLogins.Name = "lvLogins";
            this.lvLogins.Size = new System.Drawing.Size(232, 150);
            this.lvLogins.TabIndex = 0;
            this.lvLogins.UseCompatibleStateImageBehavior = false;
            this.lvLogins.View = System.Windows.Forms.View.Details;
            this.lvLogins.DoubleClick += new System.EventHandler(this.lvLogins_DoubleClick);
            this.lvLogins.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvLogins_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Logins";
            this.columnHeader1.Width = 232;
            // 
            // cMenuDelete
            // 
            this.cMenuDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteLoginToolStripMenuItem});
            this.cMenuDelete.Name = "cMenuDelete";
            this.cMenuDelete.Size = new System.Drawing.Size(141, 26);
            // 
            // deleteLoginToolStripMenuItem
            // 
            this.deleteLoginToolStripMenuItem.Image = global::Seeker.Properties.Resources.deleteItem24;
            this.deleteLoginToolStripMenuItem.Name = "deleteLoginToolStripMenuItem";
            this.deleteLoginToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.deleteLoginToolStripMenuItem.Text = "Delete Login";
            this.deleteLoginToolStripMenuItem.Click += new System.EventHandler(this.deleteLoginToolStripMenuItem_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 230);
            this.Controls.Add(this.tblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(268, 269);
            this.MinimumSize = new System.Drawing.Size(268, 269);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seeker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.tblMain.ResumeLayout(false);
            this.tblMainBottom.ResumeLayout(false);
            this.tbcLogin.ResumeLayout(false);
            this.tbpNewLogin.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLoginProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbpLogins.ResumeLayout(false);
            this.tbpLogins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLoginProgress2)).EndInit();
            this.cMenuDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblMainBottom;
        private System.Windows.Forms.ComboBox cbBoxDomains;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl tbcLogin;
        private System.Windows.Forms.TabPage tbpLogins;
        private System.Windows.Forms.TabPage tbpNewLogin;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox ckBoxSaveCredentials;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvLogins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pboxLoginProgress2;
        private System.Windows.Forms.ContextMenuStrip cMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteLoginToolStripMenuItem;
        private System.Windows.Forms.PictureBox pboxLoginProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}