namespace Seeker
{
    partial class frmCreateUserDialog
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
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpStart = new System.Windows.Forms.TabPage();
            this.createIn = new System.Windows.Forms.Label();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxDomain = new System.Windows.Forms.TextBox();
            this.tBoxPre2000LogonName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxLogonName = new System.Windows.Forms.TextBox();
            this.cbBoxDomains = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.tBoxFirstName = new System.Windows.Forms.TextBox();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gBoxTimeOut = new System.Windows.Forms.GroupBox();
            this.dtpExpires = new System.Windows.Forms.DateTimePicker();
            this.rbEndOf = new System.Windows.Forms.RadioButton();
            this.rbNever = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbpMiddle = new System.Windows.Forms.TabPage();
            this.createIn2nd = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tBoxPass2nd = new System.Windows.Forms.TextBox();
            this.tBoxPass1st = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext2nd = new System.Windows.Forms.Button();
            this.btnBack2nd = new System.Windows.Forms.Button();
            this.btnCancel2nd = new System.Windows.Forms.Button();
            this.ckChangePass = new System.Windows.Forms.CheckBox();
            this.ckCannotChange = new System.Windows.Forms.CheckBox();
            this.ckPNeverExpires = new System.Windows.Forms.CheckBox();
            this.ckAccountDisable = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbpEnd = new System.Windows.Forms.TabPage();
            this.createIn3rd = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnBack3rd = new System.Windows.Forms.Button();
            this.btnCancel3rd = new System.Windows.Forms.Button();
            this.rtBoxDetails = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbcMain.SuspendLayout();
            this.tbpStart.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.gBoxTimeOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbpMiddle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tbpEnd.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpStart);
            this.tbcMain.Controls.Add(this.tbpMiddle);
            this.tbcMain.Controls.Add(this.tbpEnd);
            this.tbcMain.Location = new System.Drawing.Point(-1, -21);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(516, 355);
            this.tbcMain.TabIndex = 0;
            this.tbcMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbcMain_KeyDown);
            // 
            // tbpStart
            // 
            this.tbpStart.Controls.Add(this.createIn);
            this.tbpStart.Controls.Add(this.tblMain);
            this.tbpStart.Controls.Add(this.label1);
            this.tbpStart.Controls.Add(this.pictureBox1);
            this.tbpStart.Location = new System.Drawing.Point(4, 22);
            this.tbpStart.Name = "tbpStart";
            this.tbpStart.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStart.Size = new System.Drawing.Size(508, 329);
            this.tbpStart.TabIndex = 0;
            this.tbpStart.Text = "tabPage1";
            this.tbpStart.UseVisualStyleBackColor = true;
            // 
            // createIn
            // 
            this.createIn.Location = new System.Drawing.Point(109, 32);
            this.createIn.Name = "createIn";
            this.createIn.Size = new System.Drawing.Size(343, 30);
            this.createIn.TabIndex = 6;
            this.createIn.Text = "lblOuDn";
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.label8, 0, 0);
            this.tblMain.Controls.Add(this.label9, 0, 8);
            this.tblMain.Controls.Add(this.tBoxDomain, 0, 7);
            this.tblMain.Controls.Add(this.tBoxPre2000LogonName, 2, 7);
            this.tblMain.Controls.Add(this.label6, 0, 6);
            this.tblMain.Controls.Add(this.tBoxLogonName, 0, 5);
            this.tblMain.Controls.Add(this.cbBoxDomains, 2, 5);
            this.tblMain.Controls.Add(this.label5, 0, 4);
            this.tblMain.Controls.Add(this.tBoxFullName, 1, 3);
            this.tblMain.Controls.Add(this.label4, 0, 3);
            this.tblMain.Controls.Add(this.label3, 0, 2);
            this.tblMain.Controls.Add(this.label2, 0, 1);
            this.tblMain.Controls.Add(this.tBoxLastName, 1, 2);
            this.tblMain.Controls.Add(this.tBoxFirstName, 1, 1);
            this.tblMain.Controls.Add(this.tblButtons, 0, 9);
            this.tblMain.Controls.Add(this.gBoxTimeOut, 2, 1);
            this.tblMain.Location = new System.Drawing.Point(6, 65);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 10;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tblMain.Size = new System.Drawing.Size(499, 260);
            this.tblMain.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblMain.SetColumnSpan(this.label8, 3);
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(492, 1);
            this.label8.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblMain.SetColumnSpan(this.label9, 3);
            this.label9.Location = new System.Drawing.Point(3, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(492, 1);
            this.label9.TabIndex = 6;
            // 
            // tBoxDomain
            // 
            this.tBoxDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblMain.SetColumnSpan(this.tBoxDomain, 2);
            this.tBoxDomain.Location = new System.Drawing.Point(3, 178);
            this.tBoxDomain.Name = "tBoxDomain";
            this.tBoxDomain.ReadOnly = true;
            this.tBoxDomain.Size = new System.Drawing.Size(267, 20);
            this.tBoxDomain.TabIndex = 5;
            // 
            // tBoxPre2000LogonName
            // 
            this.tBoxPre2000LogonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxPre2000LogonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBoxPre2000LogonName.Location = new System.Drawing.Point(276, 178);
            this.tBoxPre2000LogonName.Name = "tBoxPre2000LogonName";
            this.tBoxPre2000LogonName.Size = new System.Drawing.Size(220, 20);
            this.tBoxPre2000LogonName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.tblMain.SetColumnSpan(this.label6, 2);
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "User logon name(pre-windows 2000):";
            // 
            // tBoxLogonName
            // 
            this.tBoxLogonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblMain.SetColumnSpan(this.tBoxLogonName, 2);
            this.tBoxLogonName.Location = new System.Drawing.Point(3, 128);
            this.tBoxLogonName.Name = "tBoxLogonName";
            this.tBoxLogonName.Size = new System.Drawing.Size(267, 20);
            this.tBoxLogonName.TabIndex = 3;
            this.tBoxLogonName.TextChanged += new System.EventHandler(this.tBoxLogonName_TextChanged);
            this.tBoxLogonName.Leave += new System.EventHandler(this.tBoxLogonName_Leave);
            // 
            // cbBoxDomains
            // 
            this.cbBoxDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoxDomains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxDomains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoxDomains.FormattingEnabled = true;
            this.cbBoxDomains.Location = new System.Drawing.Point(276, 128);
            this.cbBoxDomains.Name = "cbBoxDomains";
            this.cbBoxDomains.Size = new System.Drawing.Size(220, 21);
            this.cbBoxDomains.TabIndex = 4;
            this.cbBoxDomains.SelectedIndexChanged += new System.EventHandler(this.cbBoxDomains_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "User logon name:";
            // 
            // tBoxFullName
            // 
            this.tBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblMain.SetColumnSpan(this.tBoxFullName, 2);
            this.tBoxFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBoxFullName.Location = new System.Drawing.Point(102, 78);
            this.tBoxFullName.Name = "tBoxFullName";
            this.tBoxFullName.Size = new System.Drawing.Size(394, 20);
            this.tBoxFullName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxLastName.Location = new System.Drawing.Point(102, 53);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(168, 20);
            this.tBoxLastName.TabIndex = 1;
            this.tBoxLastName.TextChanged += new System.EventHandler(this.tBoxLastName_TextChanged);
            // 
            // tBoxFirstName
            // 
            this.tBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxFirstName.Location = new System.Drawing.Point(102, 28);
            this.tBoxFirstName.Name = "tBoxFirstName";
            this.tBoxFirstName.Size = new System.Drawing.Size(168, 20);
            this.tBoxFirstName.TabIndex = 0;
            this.tBoxFirstName.TextChanged += new System.EventHandler(this.tBoxFirstName_TextChanged);
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblButtons, 3);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tblButtons.Controls.Add(this.btnNext, 0, 0);
            this.tblButtons.Controls.Add(this.btnBack, 0, 0);
            this.tblButtons.Controls.Add(this.btnCancel, 2, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(3, 224);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.Size = new System.Drawing.Size(493, 33);
            this.tblButtons.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(334, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 27);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Enabled = false;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(253, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 27);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(414, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gBoxTimeOut
            // 
            this.gBoxTimeOut.Controls.Add(this.dtpExpires);
            this.gBoxTimeOut.Controls.Add(this.rbEndOf);
            this.gBoxTimeOut.Controls.Add(this.rbNever);
            this.gBoxTimeOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxTimeOut.Location = new System.Drawing.Point(276, 28);
            this.gBoxTimeOut.Name = "gBoxTimeOut";
            this.tblMain.SetRowSpan(this.gBoxTimeOut, 2);
            this.gBoxTimeOut.Size = new System.Drawing.Size(220, 44);
            this.gBoxTimeOut.TabIndex = 8;
            this.gBoxTimeOut.TabStop = false;
            this.gBoxTimeOut.Text = "Account Expires:";
            // 
            // dtpExpires
            // 
            this.dtpExpires.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpires.Location = new System.Drawing.Point(123, 19);
            this.dtpExpires.Name = "dtpExpires";
            this.dtpExpires.Size = new System.Drawing.Size(91, 20);
            this.dtpExpires.TabIndex = 2;
            this.dtpExpires.ValueChanged += new System.EventHandler(this.dtpExpires_ValueChanged);
            // 
            // rbEndOf
            // 
            this.rbEndOf.AutoSize = true;
            this.rbEndOf.Location = new System.Drawing.Point(67, 20);
            this.rbEndOf.Name = "rbEndOf";
            this.rbEndOf.Size = new System.Drawing.Size(59, 17);
            this.rbEndOf.TabIndex = 1;
            this.rbEndOf.Text = "End of:";
            this.rbEndOf.UseVisualStyleBackColor = true;
            this.rbEndOf.CheckedChanged += new System.EventHandler(this.rbEndOf_CheckedChanged);
            this.rbEndOf.Click += new System.EventHandler(this.rbEndOf_Click);
            // 
            // rbNever
            // 
            this.rbNever.AutoSize = true;
            this.rbNever.Checked = true;
            this.rbNever.Location = new System.Drawing.Point(7, 20);
            this.rbNever.Name = "rbNever";
            this.rbNever.Size = new System.Drawing.Size(54, 17);
            this.rbNever.TabIndex = 0;
            this.rbNever.TabStop = true;
            this.rbNever.Text = "Never";
            this.rbNever.UseVisualStyleBackColor = true;
            this.rbNever.Click += new System.EventHandler(this.rbNever_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create in:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Seeker.Properties.Resources.usrPhoto;
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tbpMiddle
            // 
            this.tbpMiddle.Controls.Add(this.createIn2nd);
            this.tbpMiddle.Controls.Add(this.tableLayoutPanel1);
            this.tbpMiddle.Controls.Add(this.label18);
            this.tbpMiddle.Controls.Add(this.pictureBox2);
            this.tbpMiddle.Location = new System.Drawing.Point(4, 22);
            this.tbpMiddle.Name = "tbpMiddle";
            this.tbpMiddle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMiddle.Size = new System.Drawing.Size(508, 329);
            this.tbpMiddle.TabIndex = 1;
            this.tbpMiddle.Text = "tabPage2";
            this.tbpMiddle.UseVisualStyleBackColor = true;
            // 
            // createIn2nd
            // 
            this.createIn2nd.Location = new System.Drawing.Point(109, 32);
            this.createIn2nd.Name = "createIn2nd";
            this.createIn2nd.Size = new System.Drawing.Size(343, 30);
            this.createIn2nd.TabIndex = 10;
            this.createIn2nd.Text = "lblOuDn";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBoxPass2nd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tBoxPass1st, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.ckChangePass, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ckCannotChange, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ckPNeverExpires, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ckAccountDisable, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 260);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.label11, 3);
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(493, 1);
            this.label11.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.label12, 3);
            this.label12.Location = new System.Drawing.Point(3, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(493, 1);
            this.label12.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Confirm Password:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Password:";
            // 
            // tBoxPass2nd
            // 
            this.tBoxPass2nd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxPass2nd.Location = new System.Drawing.Point(107, 53);
            this.tBoxPass2nd.Name = "tBoxPass2nd";
            this.tBoxPass2nd.Size = new System.Drawing.Size(163, 20);
            this.tBoxPass2nd.TabIndex = 1;
            this.tBoxPass2nd.UseSystemPasswordChar = true;
            // 
            // tBoxPass1st
            // 
            this.tBoxPass1st.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxPass1st.Location = new System.Drawing.Point(107, 28);
            this.tBoxPass1st.Name = "tBoxPass1st";
            this.tBoxPass1st.Size = new System.Drawing.Size(163, 20);
            this.tBoxPass1st.TabIndex = 0;
            this.tBoxPass1st.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.Controls.Add(this.btnNext2nd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBack2nd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel2nd, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 224);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(493, 33);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btnNext2nd
            // 
            this.btnNext2nd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext2nd.Location = new System.Drawing.Point(334, 3);
            this.btnNext2nd.Name = "btnNext2nd";
            this.btnNext2nd.Size = new System.Drawing.Size(74, 27);
            this.btnNext2nd.TabIndex = 1;
            this.btnNext2nd.Text = "Next >";
            this.btnNext2nd.UseVisualStyleBackColor = true;
            this.btnNext2nd.Click += new System.EventHandler(this.btnNext2nd_Click);
            // 
            // btnBack2nd
            // 
            this.btnBack2nd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack2nd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2nd.Location = new System.Drawing.Point(253, 3);
            this.btnBack2nd.Name = "btnBack2nd";
            this.btnBack2nd.Size = new System.Drawing.Size(75, 27);
            this.btnBack2nd.TabIndex = 0;
            this.btnBack2nd.Text = "< Back";
            this.btnBack2nd.UseVisualStyleBackColor = true;
            this.btnBack2nd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancel2nd
            // 
            this.btnCancel2nd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2nd.Location = new System.Drawing.Point(414, 3);
            this.btnCancel2nd.Name = "btnCancel2nd";
            this.btnCancel2nd.Size = new System.Drawing.Size(75, 27);
            this.btnCancel2nd.TabIndex = 2;
            this.btnCancel2nd.Text = "Cancel";
            this.btnCancel2nd.UseVisualStyleBackColor = true;
            this.btnCancel2nd.Click += new System.EventHandler(this.btnCancel2nd_Click);
            // 
            // ckChangePass
            // 
            this.ckChangePass.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ckChangePass, 2);
            this.ckChangePass.Location = new System.Drawing.Point(3, 103);
            this.ckChangePass.Name = "ckChangePass";
            this.ckChangePass.Size = new System.Drawing.Size(224, 17);
            this.ckChangePass.TabIndex = 2;
            this.ckChangePass.Text = "User must change password at next logon";
            this.ckChangePass.UseVisualStyleBackColor = true;
            this.ckChangePass.Click += new System.EventHandler(this.ckChangePass_Click);
            // 
            // ckCannotChange
            // 
            this.ckCannotChange.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ckCannotChange, 2);
            this.ckCannotChange.Location = new System.Drawing.Point(3, 128);
            this.ckCannotChange.Name = "ckCannotChange";
            this.ckCannotChange.Size = new System.Drawing.Size(171, 17);
            this.ckCannotChange.TabIndex = 3;
            this.ckCannotChange.Text = "User cannot change password";
            this.ckCannotChange.UseVisualStyleBackColor = true;
            this.ckCannotChange.Click += new System.EventHandler(this.ckCannotChange_Click);
            // 
            // ckPNeverExpires
            // 
            this.ckPNeverExpires.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ckPNeverExpires, 2);
            this.ckPNeverExpires.Location = new System.Drawing.Point(3, 153);
            this.ckPNeverExpires.Name = "ckPNeverExpires";
            this.ckPNeverExpires.Size = new System.Drawing.Size(138, 17);
            this.ckPNeverExpires.TabIndex = 4;
            this.ckPNeverExpires.Text = "Password never expires";
            this.ckPNeverExpires.UseVisualStyleBackColor = true;
            this.ckPNeverExpires.Click += new System.EventHandler(this.ckPNeverExpires_Click);
            // 
            // ckAccountDisable
            // 
            this.ckAccountDisable.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ckAccountDisable, 2);
            this.ckAccountDisable.Location = new System.Drawing.Point(3, 178);
            this.ckAccountDisable.Name = "ckAccountDisable";
            this.ckAccountDisable.Size = new System.Drawing.Size(118, 17);
            this.ckAccountDisable.TabIndex = 5;
            this.ckAccountDisable.Text = "Account is disabled";
            this.ckAccountDisable.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(61, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Create in:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Seeker.Properties.Resources.usrPhoto;
            this.pictureBox2.Location = new System.Drawing.Point(6, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // tbpEnd
            // 
            this.tbpEnd.Controls.Add(this.createIn3rd);
            this.tbpEnd.Controls.Add(this.tableLayoutPanel3);
            this.tbpEnd.Controls.Add(this.label21);
            this.tbpEnd.Controls.Add(this.pictureBox3);
            this.tbpEnd.Location = new System.Drawing.Point(4, 22);
            this.tbpEnd.Name = "tbpEnd";
            this.tbpEnd.Size = new System.Drawing.Size(508, 329);
            this.tbpEnd.TabIndex = 2;
            this.tbpEnd.Text = "tabPage1";
            this.tbpEnd.UseVisualStyleBackColor = true;
            // 
            // createIn3rd
            // 
            this.createIn3rd.Location = new System.Drawing.Point(109, 32);
            this.createIn3rd.Name = "createIn3rd";
            this.createIn3rd.Size = new System.Drawing.Size(343, 30);
            this.createIn3rd.TabIndex = 14;
            this.createIn3rd.Text = "lblOuDn";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.rtBoxDetails, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 65);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(499, 260);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel3.SetColumnSpan(this.label14, 3);
            this.label14.Location = new System.Drawing.Point(3, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(493, 1);
            this.label14.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel3.SetColumnSpan(this.label15, 3);
            this.label15.Location = new System.Drawing.Point(3, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(493, 1);
            this.label15.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label19, 3);
            this.label19.Location = new System.Drawing.Point(3, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(282, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "When you click Finish, the following object will be created:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 3);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.Controls.Add(this.btnFinish, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnBack3rd, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCancel3rd, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 224);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(493, 33);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // btnFinish
            // 
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Location = new System.Drawing.Point(334, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(74, 27);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnBack3rd
            // 
            this.btnBack3rd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack3rd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack3rd.Location = new System.Drawing.Point(253, 3);
            this.btnBack3rd.Name = "btnBack3rd";
            this.btnBack3rd.Size = new System.Drawing.Size(75, 27);
            this.btnBack3rd.TabIndex = 0;
            this.btnBack3rd.Text = "< Back";
            this.btnBack3rd.UseVisualStyleBackColor = true;
            this.btnBack3rd.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCancel3rd
            // 
            this.btnCancel3rd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel3rd.Location = new System.Drawing.Point(414, 3);
            this.btnCancel3rd.Name = "btnCancel3rd";
            this.btnCancel3rd.Size = new System.Drawing.Size(75, 27);
            this.btnCancel3rd.TabIndex = 2;
            this.btnCancel3rd.Text = "Cancel";
            this.btnCancel3rd.UseVisualStyleBackColor = true;
            this.btnCancel3rd.Click += new System.EventHandler(this.btnCancel3rd_Click);
            // 
            // rtBoxDetails
            // 
            this.rtBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel3.SetColumnSpan(this.rtBoxDetails, 3);
            this.rtBoxDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBoxDetails.Location = new System.Drawing.Point(3, 53);
            this.rtBoxDetails.Name = "rtBoxDetails";
            this.rtBoxDetails.ReadOnly = true;
            this.tableLayoutPanel3.SetRowSpan(this.rtBoxDetails, 6);
            this.rtBoxDetails.Size = new System.Drawing.Size(493, 144);
            this.rtBoxDetails.TabIndex = 0;
            this.rtBoxDetails.Text = "";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(61, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Create in:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Seeker.Properties.Resources.usrPhoto;
            this.pictureBox3.Location = new System.Drawing.Point(6, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // frmCreateUserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 333);
            this.Controls.Add(this.tbcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateUserDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Object - User";
            this.Load += new System.EventHandler(this.frmCreateUserDialog_Load);
            this.tbcMain.ResumeLayout(false);
            this.tbpStart.ResumeLayout(false);
            this.tbpStart.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.gBoxTimeOut.ResumeLayout(false);
            this.gBoxTimeOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbpMiddle.ResumeLayout(false);
            this.tbpMiddle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tbpEnd.ResumeLayout(false);
            this.tbpEnd.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpStart;
        private System.Windows.Forms.Label createIn;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBoxDomain;
        private System.Windows.Forms.TextBox tBoxPre2000LogonName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxLogonName;
        private System.Windows.Forms.ComboBox cbBoxDomains;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.TextBox tBoxFirstName;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tbpMiddle;
        private System.Windows.Forms.Label createIn2nd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tBoxPass2nd;
        private System.Windows.Forms.TextBox tBoxPass1st;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnNext2nd;
        private System.Windows.Forms.Button btnBack2nd;
        private System.Windows.Forms.Button btnCancel2nd;
        private System.Windows.Forms.CheckBox ckChangePass;
        private System.Windows.Forms.CheckBox ckCannotChange;
        private System.Windows.Forms.CheckBox ckPNeverExpires;
        private System.Windows.Forms.CheckBox ckAccountDisable;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tbpEnd;
        private System.Windows.Forms.Label createIn3rd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnBack3rd;
        private System.Windows.Forms.Button btnCancel3rd;
        private System.Windows.Forms.RichTextBox rtBoxDetails;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox gBoxTimeOut;
        private System.Windows.Forms.DateTimePicker dtpExpires;
        private System.Windows.Forms.RadioButton rbEndOf;
        private System.Windows.Forms.RadioButton rbNever;
    }
}