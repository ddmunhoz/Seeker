namespace Seeker
{
    partial class frmSeek
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            this.tbpSecH = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dGridSecH = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSeekLogs = new System.Windows.Forms.Button();
            this.pBoxProgressSecH = new System.Windows.Forms.PictureBox();
            this.txtBoxDays = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbpMemberOf = new System.Windows.Forms.TabPage();
            this.tblMemberOf = new System.Windows.Forms.TableLayoutPanel();
            this.lvUserGroups = new Seeker.Library.BufferedListView();
            this.tblGroupActions = new System.Windows.Forms.TableLayoutPanel();
            this.pBoxProgress = new System.Windows.Forms.PictureBox();
            this.ckBoxNested = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbpAdvanced = new System.Windows.Forms.TabPage();
            this.tbpLayoutAdvanced = new System.Windows.Forms.TableLayoutPanel();
            this.dGridAdvanced = new System.Windows.Forms.DataGridView();
            this.pBoxProgressAdvanced = new System.Windows.Forms.PictureBox();
            this.tbpUser = new System.Windows.Forms.TabPage();
            this.tblUserDetails = new System.Windows.Forms.TableLayoutPanel();
            this.pEmployee = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.placeHolderFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChangedDate = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAccountStatus = new System.Windows.Forms.Label();
            this.lblPs = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblLastBadPassword = new System.Windows.Forms.Label();
            this.lblLastPasswordChange = new System.Windows.Forms.Label();
            this.tblActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopyUserData = new System.Windows.Forms.Button();
            this.btnCollectObject = new System.Windows.Forms.Button();
            this.tbControlUserInfo = new System.Windows.Forms.TabControl();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpSecH.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridSecH)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressSecH)).BeginInit();
            this.tbpMemberOf.SuspendLayout();
            this.tblMemberOf.SuspendLayout();
            this.tblGroupActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgress)).BeginInit();
            this.tbpAdvanced.SuspendLayout();
            this.tbpLayoutAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAdvanced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressAdvanced)).BeginInit();
            this.tbpUser.SuspendLayout();
            this.tblUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEmployee)).BeginInit();
            this.tblActions.SuspendLayout();
            this.tbControlUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Account";
            columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Active Directory Domain Services Folder";
            columnHeader3.Width = 124;
            // 
            // tbpSecH
            // 
            this.tbpSecH.Controls.Add(this.tableLayoutPanel2);
            this.tbpSecH.Location = new System.Drawing.Point(4, 22);
            this.tbpSecH.Name = "tbpSecH";
            this.tbpSecH.Size = new System.Drawing.Size(476, 410);
            this.tbpSecH.TabIndex = 3;
            this.tbpSecH.Text = "Security Historic";
            this.tbpSecH.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dGridSecH, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(476, 410);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // dGridSecH
            // 
            this.dGridSecH.AllowUserToAddRows = false;
            this.dGridSecH.AllowUserToDeleteRows = false;
            this.dGridSecH.AllowUserToOrderColumns = true;
            this.dGridSecH.AllowUserToResizeRows = false;
            this.dGridSecH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGridSecH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridSecH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridSecH.Location = new System.Drawing.Point(3, 36);
            this.dGridSecH.Name = "dGridSecH";
            this.dGridSecH.ReadOnly = true;
            this.dGridSecH.RowHeadersVisible = false;
            this.dGridSecH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGridSecH.Size = new System.Drawing.Size(470, 371);
            this.dGridSecH.TabIndex = 13;
            this.dGridSecH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGridSecH_CellFormatting);
            this.dGridSecH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dGridSecH_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btnSeekLogs);
            this.panel1.Controls.Add(this.pBoxProgressSecH);
            this.panel1.Controls.Add(this.txtBoxDays);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 27);
            this.panel1.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Listing events in last";
            // 
            // btnSeekLogs
            // 
            this.btnSeekLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeekLogs.Location = new System.Drawing.Point(250, 2);
            this.btnSeekLogs.Name = "btnSeekLogs";
            this.btnSeekLogs.Size = new System.Drawing.Size(75, 23);
            this.btnSeekLogs.TabIndex = 41;
            this.btnSeekLogs.Text = "Seek";
            this.btnSeekLogs.UseVisualStyleBackColor = true;
            this.btnSeekLogs.Click += new System.EventHandler(this.btnSeekLogs_Click);
            // 
            // pBoxProgressSecH
            // 
            this.pBoxProgressSecH.Image = global::Seeker.Properties.Resources.pBarGreen;
            this.pBoxProgressSecH.Location = new System.Drawing.Point(330, 2);
            this.pBoxProgressSecH.Name = "pBoxProgressSecH";
            this.pBoxProgressSecH.Size = new System.Drawing.Size(75, 23);
            this.pBoxProgressSecH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxProgressSecH.TabIndex = 38;
            this.pBoxProgressSecH.TabStop = false;
            this.pBoxProgressSecH.Visible = false;
            // 
            // txtBoxDays
            // 
            this.txtBoxDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDays.Location = new System.Drawing.Point(107, 4);
            this.txtBoxDays.Name = "txtBoxDays";
            this.txtBoxDays.Size = new System.Drawing.Size(86, 20);
            this.txtBoxDays.TabIndex = 40;
            this.txtBoxDays.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(199, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "days.";
            // 
            // tbpMemberOf
            // 
            this.tbpMemberOf.Controls.Add(this.tblMemberOf);
            this.tbpMemberOf.Location = new System.Drawing.Point(4, 22);
            this.tbpMemberOf.Name = "tbpMemberOf";
            this.tbpMemberOf.Size = new System.Drawing.Size(476, 410);
            this.tbpMemberOf.TabIndex = 1;
            this.tbpMemberOf.Text = "Member Of";
            this.tbpMemberOf.UseVisualStyleBackColor = true;
            this.tbpMemberOf.Enter += new System.EventHandler(this.tbpMemberOf_Enter);
            // 
            // tblMemberOf
            // 
            this.tblMemberOf.ColumnCount = 1;
            this.tblMemberOf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 476F));
            this.tblMemberOf.Controls.Add(this.lvUserGroups, 0, 0);
            this.tblMemberOf.Controls.Add(this.tblGroupActions, 0, 1);
            this.tblMemberOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMemberOf.Location = new System.Drawing.Point(0, 0);
            this.tblMemberOf.Name = "tblMemberOf";
            this.tblMemberOf.RowCount = 2;
            this.tblMemberOf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMemberOf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblMemberOf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMemberOf.Size = new System.Drawing.Size(476, 410);
            this.tblMemberOf.TabIndex = 1;
            // 
            // lvUserGroups
            // 
            this.lvUserGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUserGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3});
            this.lvUserGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUserGroups.FullRowSelect = true;
            this.lvUserGroups.Location = new System.Drawing.Point(3, 3);
            this.lvUserGroups.Name = "lvUserGroups";
            this.lvUserGroups.Size = new System.Drawing.Size(470, 369);
            this.lvUserGroups.TabIndex = 34;
            this.lvUserGroups.UseCompatibleStateImageBehavior = false;
            this.lvUserGroups.View = System.Windows.Forms.View.Details;
            this.lvUserGroups.SelectedIndexChanged += new System.EventHandler(this.lvUserGroups_SelectedIndexChanged);
            this.lvUserGroups.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvUserGroups_MouseClick);
            // 
            // tblGroupActions
            // 
            this.tblGroupActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblGroupActions.ColumnCount = 4;
            this.tblGroupActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tblGroupActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tblGroupActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblGroupActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblGroupActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tblGroupActions.Controls.Add(this.pBoxProgress, 0, 0);
            this.tblGroupActions.Controls.Add(this.ckBoxNested, 1, 0);
            this.tblGroupActions.Controls.Add(this.btnAdd, 2, 0);
            this.tblGroupActions.Controls.Add(this.btnRemove, 3, 0);
            this.tblGroupActions.Location = new System.Drawing.Point(159, 378);
            this.tblGroupActions.Name = "tblGroupActions";
            this.tblGroupActions.RowCount = 1;
            this.tblGroupActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGroupActions.Size = new System.Drawing.Size(314, 29);
            this.tblGroupActions.TabIndex = 34;
            // 
            // pBoxProgress
            // 
            this.pBoxProgress.Image = global::Seeker.Properties.Resources.pBarGreen;
            this.pBoxProgress.Location = new System.Drawing.Point(3, 3);
            this.pBoxProgress.Name = "pBoxProgress";
            this.pBoxProgress.Size = new System.Drawing.Size(67, 23);
            this.pBoxProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxProgress.TabIndex = 37;
            this.pBoxProgress.TabStop = false;
            this.pBoxProgress.Visible = false;
            // 
            // ckBoxNested
            // 
            this.ckBoxNested.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckBoxNested.AutoSize = true;
            this.ckBoxNested.Location = new System.Drawing.Point(76, 6);
            this.ckBoxNested.Name = "ckBoxNested";
            this.ckBoxNested.Size = new System.Drawing.Size(88, 17);
            this.ckBoxNested.TabIndex = 36;
            this.ckBoxNested.Text = "Show nested ?";
            this.ckBoxNested.UseVisualStyleBackColor = true;
            this.ckBoxNested.CheckedChanged += new System.EventHandler(this.ckBoxNested_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(170, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(242, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(67, 23);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbpAdvanced
            // 
            this.tbpAdvanced.Controls.Add(this.tbpLayoutAdvanced);
            this.tbpAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tbpAdvanced.Name = "tbpAdvanced";
            this.tbpAdvanced.Size = new System.Drawing.Size(476, 410);
            this.tbpAdvanced.TabIndex = 4;
            this.tbpAdvanced.Text = "Advanced";
            this.tbpAdvanced.UseVisualStyleBackColor = true;
            this.tbpAdvanced.Enter += new System.EventHandler(this.tbpAdvanced_Enter);
            // 
            // tbpLayoutAdvanced
            // 
            this.tbpLayoutAdvanced.ColumnCount = 1;
            this.tbpLayoutAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpLayoutAdvanced.Controls.Add(this.dGridAdvanced, 0, 0);
            this.tbpLayoutAdvanced.Controls.Add(this.pBoxProgressAdvanced, 0, 1);
            this.tbpLayoutAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpLayoutAdvanced.Location = new System.Drawing.Point(0, 0);
            this.tbpLayoutAdvanced.Name = "tbpLayoutAdvanced";
            this.tbpLayoutAdvanced.RowCount = 2;
            this.tbpLayoutAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpLayoutAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbpLayoutAdvanced.Size = new System.Drawing.Size(476, 410);
            this.tbpLayoutAdvanced.TabIndex = 40;
            // 
            // dGridAdvanced
            // 
            this.dGridAdvanced.AllowUserToAddRows = false;
            this.dGridAdvanced.AllowUserToDeleteRows = false;
            this.dGridAdvanced.AllowUserToOrderColumns = true;
            this.dGridAdvanced.AllowUserToResizeRows = false;
            this.dGridAdvanced.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridAdvanced.Location = new System.Drawing.Point(3, 3);
            this.dGridAdvanced.Name = "dGridAdvanced";
            this.dGridAdvanced.ReadOnly = true;
            this.dGridAdvanced.RowHeadersVisible = false;
            this.dGridAdvanced.Size = new System.Drawing.Size(470, 375);
            this.dGridAdvanced.TabIndex = 10;
            // 
            // pBoxProgressAdvanced
            // 
            this.pBoxProgressAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxProgressAdvanced.Image = global::Seeker.Properties.Resources.pBarGreen;
            this.pBoxProgressAdvanced.Location = new System.Drawing.Point(398, 384);
            this.pBoxProgressAdvanced.Name = "pBoxProgressAdvanced";
            this.pBoxProgressAdvanced.Size = new System.Drawing.Size(75, 23);
            this.pBoxProgressAdvanced.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxProgressAdvanced.TabIndex = 39;
            this.pBoxProgressAdvanced.TabStop = false;
            this.pBoxProgressAdvanced.Visible = false;
            // 
            // tbpUser
            // 
            this.tbpUser.Controls.Add(this.tblUserDetails);
            this.tbpUser.Location = new System.Drawing.Point(4, 22);
            this.tbpUser.Name = "tbpUser";
            this.tbpUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUser.Size = new System.Drawing.Size(476, 410);
            this.tbpUser.TabIndex = 0;
            this.tbpUser.Text = "User";
            this.tbpUser.UseVisualStyleBackColor = true;
            // 
            // tblUserDetails
            // 
            this.tblUserDetails.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblUserDetails.ColumnCount = 3;
            this.tblUserDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tblUserDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUserDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tblUserDetails.Controls.Add(this.pEmployee, 2, 0);
            this.tblUserDetails.Controls.Add(this.label10, 0, 1);
            this.tblUserDetails.Controls.Add(this.lblAccount, 1, 1);
            this.tblUserDetails.Controls.Add(this.label3, 0, 11);
            this.tblUserDetails.Controls.Add(this.label8, 0, 10);
            this.tblUserDetails.Controls.Add(this.label13, 0, 9);
            this.tblUserDetails.Controls.Add(this.label11, 0, 8);
            this.tblUserDetails.Controls.Add(this.label9, 0, 7);
            this.tblUserDetails.Controls.Add(this.label4, 0, 6);
            this.tblUserDetails.Controls.Add(this.placeHolderFullName, 0, 5);
            this.tblUserDetails.Controls.Add(this.label2, 0, 4);
            this.tblUserDetails.Controls.Add(this.label1, 0, 3);
            this.tblUserDetails.Controls.Add(this.lblChangedDate, 1, 11);
            this.tblUserDetails.Controls.Add(this.lblCreationDate, 1, 10);
            this.tblUserDetails.Controls.Add(this.lblPhone, 1, 9);
            this.tblUserDetails.Controls.Add(this.lblLocation, 1, 8);
            this.tblUserDetails.Controls.Add(this.lblDivision, 1, 7);
            this.tblUserDetails.Controls.Add(this.lblMail, 1, 6);
            this.tblUserDetails.Controls.Add(this.lblFullName, 1, 5);
            this.tblUserDetails.Controls.Add(this.lblLastName, 1, 4);
            this.tblUserDetails.Controls.Add(this.lblFirstName, 1, 3);
            this.tblUserDetails.Controls.Add(this.label5, 0, 2);
            this.tblUserDetails.Controls.Add(this.lblAccountStatus, 1, 2);
            this.tblUserDetails.Controls.Add(this.lblPs, 1, 14);
            this.tblUserDetails.Controls.Add(this.label12, 0, 12);
            this.tblUserDetails.Controls.Add(this.label14, 0, 13);
            this.tblUserDetails.Controls.Add(this.lblLastBadPassword, 1, 12);
            this.tblUserDetails.Controls.Add(this.lblLastPasswordChange, 1, 13);
            this.tblUserDetails.Controls.Add(this.tblActions, 0, 0);
            this.tblUserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUserDetails.Location = new System.Drawing.Point(3, 3);
            this.tblUserDetails.Name = "tblUserDetails";
            this.tblUserDetails.RowCount = 16;
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblUserDetails.Size = new System.Drawing.Size(470, 404);
            this.tblUserDetails.TabIndex = 34;
            this.tblUserDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // pEmployee
            // 
            this.pEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pEmployee.Image = global::Seeker.Properties.Resources.usrPhoto;
            this.pEmployee.Location = new System.Drawing.Point(358, 4);
            this.pEmployee.Name = "pEmployee";
            this.tblUserDetails.SetRowSpan(this.pEmployee, 6);
            this.pEmployee.Size = new System.Drawing.Size(78, 113);
            this.pEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pEmployee.TabIndex = 24;
            this.pEmployee.TabStop = false;
            this.pEmployee.Click += new System.EventHandler(this.pEmployee_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Account:";
            // 
            // lblAccount
            // 
            this.lblAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccount.AutoSize = true;
            this.lblAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAccount.ForeColor = System.Drawing.Color.Blue;
            this.lblAccount.Location = new System.Drawing.Point(91, 41);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(230, 13);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Changed Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Creation Date:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Phone:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Location:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Department:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // placeHolderFullName
            // 
            this.placeHolderFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.placeHolderFullName.AutoSize = true;
            this.placeHolderFullName.Location = new System.Drawing.Point(4, 133);
            this.placeHolderFullName.Name = "placeHolderFullName";
            this.placeHolderFullName.Size = new System.Drawing.Size(80, 13);
            this.placeHolderFullName.TabIndex = 0;
            this.placeHolderFullName.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // lblChangedDate
            // 
            this.lblChangedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChangedDate.AutoSize = true;
            this.lblChangedDate.Location = new System.Drawing.Point(91, 271);
            this.lblChangedDate.Name = "lblChangedDate";
            this.lblChangedDate.Size = new System.Drawing.Size(230, 13);
            this.lblChangedDate.TabIndex = 0;
            this.lblChangedDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(91, 248);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(230, 13);
            this.lblCreationDate.TabIndex = 0;
            this.lblCreationDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(91, 225);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(230, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(91, 202);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(230, 13);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // lblDivision
            // 
            this.lblDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(91, 179);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(230, 13);
            this.lblDivision.TabIndex = 0;
            this.lblDivision.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(91, 156);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(230, 13);
            this.lblMail.TabIndex = 0;
            this.lblMail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(91, 133);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(230, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(91, 110);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(230, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(91, 87);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(230, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // lblAccountStatus
            // 
            this.lblAccountStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountStatus.AutoSize = true;
            this.lblAccountStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAccountStatus.Location = new System.Drawing.Point(91, 64);
            this.lblAccountStatus.Name = "lblAccountStatus";
            this.lblAccountStatus.Size = new System.Drawing.Size(230, 13);
            this.lblAccountStatus.TabIndex = 0;
            this.lblAccountStatus.Click += new System.EventHandler(this.lblAccountStatus_Click);
            // 
            // lblPs
            // 
            this.lblPs.AutoSize = true;
            this.lblPs.Location = new System.Drawing.Point(91, 354);
            this.lblPs.Name = "lblPs";
            this.lblPs.Size = new System.Drawing.Size(0, 13);
            this.lblPs.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 26);
            this.label12.TabIndex = 26;
            this.label12.Text = "Last Bad Password:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 26);
            this.label14.TabIndex = 26;
            this.label14.Text = "Last Password Set:";
            // 
            // lblLastBadPassword
            // 
            this.lblLastBadPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastBadPassword.AutoSize = true;
            this.lblLastBadPassword.Location = new System.Drawing.Point(91, 299);
            this.lblLastBadPassword.Name = "lblLastBadPassword";
            this.lblLastBadPassword.Size = new System.Drawing.Size(230, 13);
            this.lblLastBadPassword.TabIndex = 0;
            this.lblLastBadPassword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // lblLastPasswordChange
            // 
            this.lblLastPasswordChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastPasswordChange.AutoSize = true;
            this.lblLastPasswordChange.Location = new System.Drawing.Point(91, 331);
            this.lblLastPasswordChange.Name = "lblLastPasswordChange";
            this.lblLastPasswordChange.Size = new System.Drawing.Size(230, 13);
            this.lblLastPasswordChange.TabIndex = 0;
            this.lblLastPasswordChange.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblAccount_MouseDoubleClick);
            // 
            // tblActions
            // 
            this.tblActions.ColumnCount = 2;
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblActions.Controls.Add(this.btnCopyUserData, 0, 0);
            this.tblActions.Controls.Add(this.btnCollectObject, 1, 0);
            this.tblActions.Location = new System.Drawing.Point(1, 1);
            this.tblActions.Margin = new System.Windows.Forms.Padding(0);
            this.tblActions.Name = "tblActions";
            this.tblActions.RowCount = 1;
            this.tblActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblActions.Size = new System.Drawing.Size(86, 35);
            this.tblActions.TabIndex = 29;
            // 
            // btnCopyUserData
            // 
            this.btnCopyUserData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopyUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyUserData.Image = global::Seeker.Properties.Resources.copy24;
            this.btnCopyUserData.Location = new System.Drawing.Point(7, 3);
            this.btnCopyUserData.Name = "btnCopyUserData";
            this.btnCopyUserData.Size = new System.Drawing.Size(29, 29);
            this.btnCopyUserData.TabIndex = 10;
            this.btnCopyUserData.UseVisualStyleBackColor = true;
            this.btnCopyUserData.Click += new System.EventHandler(this.btnCopyUserData_Click);
            // 
            // btnCollectObject
            // 
            this.btnCollectObject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCollectObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollectObject.Image = global::Seeker.Properties.Resources.collectObject24;
            this.btnCollectObject.Location = new System.Drawing.Point(50, 3);
            this.btnCollectObject.Name = "btnCollectObject";
            this.btnCollectObject.Size = new System.Drawing.Size(29, 29);
            this.btnCollectObject.TabIndex = 10;
            this.btnCollectObject.UseVisualStyleBackColor = true;
            this.btnCollectObject.Click += new System.EventHandler(this.btnCollectObject_Click);
            // 
            // tbControlUserInfo
            // 
            this.tbControlUserInfo.Controls.Add(this.tbpUser);
            this.tbControlUserInfo.Controls.Add(this.tbpAdvanced);
            this.tbControlUserInfo.Controls.Add(this.tbpMemberOf);
            this.tbControlUserInfo.Controls.Add(this.tbpSecH);
            this.tbControlUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tbControlUserInfo.Name = "tbControlUserInfo";
            this.tbControlUserInfo.SelectedIndex = 0;
            this.tbControlUserInfo.Size = new System.Drawing.Size(484, 436);
            this.tbControlUserInfo.TabIndex = 28;
            // 
            // frmSeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 436);
            this.Controls.Add(this.tbControlUserInfo);
            this.Name = "frmSeek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seek:";
            this.Load += new System.EventHandler(this.frmSeek_Load);
            this.Move += new System.EventHandler(this.frmSeek_Move);
            this.tbpSecH.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridSecH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressSecH)).EndInit();
            this.tbpMemberOf.ResumeLayout(false);
            this.tblMemberOf.ResumeLayout(false);
            this.tblGroupActions.ResumeLayout(false);
            this.tblGroupActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgress)).EndInit();
            this.tbpAdvanced.ResumeLayout(false);
            this.tbpLayoutAdvanced.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridAdvanced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressAdvanced)).EndInit();
            this.tbpUser.ResumeLayout(false);
            this.tblUserDetails.ResumeLayout(false);
            this.tblUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEmployee)).EndInit();
            this.tblActions.ResumeLayout(false);
            this.tbControlUserInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpSecH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dGridSecH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSeekLogs;
        private System.Windows.Forms.PictureBox pBoxProgressSecH;
        private System.Windows.Forms.TextBox txtBoxDays;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tbpMemberOf;
        private System.Windows.Forms.TableLayoutPanel tblMemberOf;
        private Library.BufferedListView lvUserGroups;
        private System.Windows.Forms.TableLayoutPanel tblGroupActions;
        private System.Windows.Forms.PictureBox pBoxProgress;
        private System.Windows.Forms.CheckBox ckBoxNested;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TabPage tbpAdvanced;
        private System.Windows.Forms.TabPage tbpUser;
        private System.Windows.Forms.TableLayoutPanel tblUserDetails;
        private System.Windows.Forms.Button btnCopyUserData;
        private System.Windows.Forms.PictureBox pEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label placeHolderFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChangedDate;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAccountStatus;
        private System.Windows.Forms.Label lblPs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblLastBadPassword;
        private System.Windows.Forms.Label lblLastPasswordChange;
        private System.Windows.Forms.TabControl tbControlUserInfo;
        private System.Windows.Forms.DataGridView dGridAdvanced;
        private System.Windows.Forms.PictureBox pBoxProgressAdvanced;
        private System.Windows.Forms.TableLayoutPanel tbpLayoutAdvanced;
        private System.Windows.Forms.TableLayoutPanel tblActions;
        private System.Windows.Forms.Button btnCollectObject;




    }
}