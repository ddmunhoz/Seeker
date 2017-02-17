namespace Seeker
{
    partial class frmSeekGroup
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
            System.Windows.Forms.ColumnHeader columnHeader6;
            System.Windows.Forms.ColumnHeader columnHeader7;
            System.Windows.Forms.ColumnHeader columnHeader8;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ColumnHeader columnHeader4;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbControlGroupInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.lblDn = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblScope = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tblActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopyUserData = new System.Windows.Forms.Button();
            this.btnCollectObject = new System.Windows.Forms.Button();
            this.tbpMembers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tblGroupActionsGroupMembers = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveGroupMembers = new System.Windows.Forms.Button();
            this.btnAddGroupMembers = new System.Windows.Forms.Button();
            this.cMenuSearchType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ckBoxNestedGroupMembers = new System.Windows.Forms.CheckBox();
            this.pBoxProgressGroupMembers = new System.Windows.Forms.PictureBox();
            this.lblMembersCount = new System.Windows.Forms.Label();
            this.lvMembers = new Seeker.Library.BufferedListView();
            this.tbpMemberOf = new System.Windows.Forms.TabPage();
            this.tblMemberOf = new System.Windows.Forms.TableLayoutPanel();
            this.tblGroupActionsGroupGroups = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveGroupGroups = new System.Windows.Forms.Button();
            this.btnAddGroupGroups = new System.Windows.Forms.Button();
            this.ckBoxNestedGroupGroups = new System.Windows.Forms.CheckBox();
            this.pBoxProgressGroupsGroups = new System.Windows.Forms.PictureBox();
            this.lvlGroupGroups = new Seeker.Library.BufferedListView();
            columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tbControlGroupInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tblActions.SuspendLayout();
            this.tbpMembers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblGroupActionsGroupMembers.SuspendLayout();
            this.cMenuSearchType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressGroupMembers)).BeginInit();
            this.tbpMemberOf.SuspendLayout();
            this.tblMemberOf.SuspendLayout();
            this.tblGroupActionsGroupGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressGroupsGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Name";
            columnHeader6.Width = 95;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Account";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Active Directory Domain Services Folder";
            columnHeader8.Width = 211;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Name";
            columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Active Directory Domain Services Folder";
            columnHeader4.Width = 168;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbControlGroupInfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 423);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // tbControlGroupInfo
            // 
            this.tbControlGroupInfo.Controls.Add(this.tabPage1);
            this.tbControlGroupInfo.Controls.Add(this.tbpMembers);
            this.tbControlGroupInfo.Controls.Add(this.tbpMemberOf);
            this.tbControlGroupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlGroupInfo.Location = new System.Drawing.Point(3, 3);
            this.tbControlGroupInfo.Name = "tbControlGroupInfo";
            this.tbControlGroupInfo.SelectedIndex = 0;
            this.tbControlGroupInfo.Size = new System.Drawing.Size(424, 417);
            this.tbControlGroupInfo.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(416, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Group";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            this.tblMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tblMain.Controls.Add(this.label5, 0, 9);
            this.tblMain.Controls.Add(this.lblNotes, 1, 9);
            this.tblMain.Controls.Add(this.label7, 0, 7);
            this.tblMain.Controls.Add(this.label6, 0, 6);
            this.tblMain.Controls.Add(this.label8, 0, 5);
            this.tblMain.Controls.Add(this.label4, 0, 4);
            this.tblMain.Controls.Add(this.label3, 0, 3);
            this.tblMain.Controls.Add(this.label2, 0, 2);
            this.tblMain.Controls.Add(this.label1, 0, 1);
            this.tblMain.Controls.Add(this.lblModifiedDate, 1, 7);
            this.tblMain.Controls.Add(this.lblDn, 1, 5);
            this.tblMain.Controls.Add(this.lblCreatedDate, 1, 6);
            this.tblMain.Controls.Add(this.lblType, 1, 4);
            this.tblMain.Controls.Add(this.lblScope, 1, 3);
            this.tblMain.Controls.Add(this.lblDescription, 1, 2);
            this.tblMain.Controls.Add(this.lblName, 1, 1);
            this.tblMain.Controls.Add(this.tblActions, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(3, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 11;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(410, 385);
            this.tblMain.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Notes";
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(94, 213);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(234, 13);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Modified Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Created Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "DN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Scope:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Location = new System.Drawing.Point(94, 171);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(234, 13);
            this.lblModifiedDate.TabIndex = 0;
            this.lblModifiedDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblDn
            // 
            this.lblDn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDn.AutoSize = true;
            this.lblDn.Location = new System.Drawing.Point(94, 129);
            this.lblDn.Name = "lblDn";
            this.lblDn.Size = new System.Drawing.Size(234, 13);
            this.lblDn.TabIndex = 0;
            this.lblDn.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(94, 150);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(234, 13);
            this.lblCreatedDate.TabIndex = 0;
            this.lblCreatedDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(94, 108);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(234, 13);
            this.lblType.TabIndex = 0;
            this.lblType.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblScope
            // 
            this.lblScope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScope.AutoSize = true;
            this.lblScope.Location = new System.Drawing.Point(94, 87);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(234, 13);
            this.lblScope.TabIndex = 0;
            this.lblScope.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(94, 66);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(234, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(94, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(234, 13);
            this.lblName.TabIndex = 0;
            this.lblName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // tblActions
            // 
            this.tblActions.ColumnCount = 2;
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblActions.Controls.Add(this.btnCopyUserData, 0, 0);
            this.tblActions.Controls.Add(this.btnCollectObject, 1, 0);
            this.tblActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblActions.Location = new System.Drawing.Point(1, 1);
            this.tblActions.Margin = new System.Windows.Forms.Padding(0);
            this.tblActions.Name = "tblActions";
            this.tblActions.RowCount = 1;
            this.tblActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblActions.Size = new System.Drawing.Size(89, 40);
            this.tblActions.TabIndex = 30;
            // 
            // btnCopyUserData
            // 
            this.btnCopyUserData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopyUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyUserData.Image = global::Seeker.Properties.Resources.copy24;
            this.btnCopyUserData.Location = new System.Drawing.Point(7, 5);
            this.btnCopyUserData.Name = "btnCopyUserData";
            this.btnCopyUserData.Size = new System.Drawing.Size(29, 29);
            this.btnCopyUserData.TabIndex = 10;
            this.btnCopyUserData.UseVisualStyleBackColor = true;
            this.btnCopyUserData.Click += new System.EventHandler(this.btnCopyUserData_Click_1);
            // 
            // btnCollectObject
            // 
            this.btnCollectObject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCollectObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollectObject.Image = global::Seeker.Properties.Resources.collectObject24;
            this.btnCollectObject.Location = new System.Drawing.Point(52, 5);
            this.btnCollectObject.Name = "btnCollectObject";
            this.btnCollectObject.Size = new System.Drawing.Size(29, 29);
            this.btnCollectObject.TabIndex = 10;
            this.btnCollectObject.UseVisualStyleBackColor = true;
            this.btnCollectObject.Click += new System.EventHandler(this.btnCollectObject_Click);
            // 
            // tbpMembers
            // 
            this.tbpMembers.Controls.Add(this.tableLayoutPanel2);
            this.tbpMembers.Location = new System.Drawing.Point(4, 22);
            this.tbpMembers.Name = "tbpMembers";
            this.tbpMembers.Size = new System.Drawing.Size(416, 391);
            this.tbpMembers.TabIndex = 2;
            this.tbpMembers.Text = "Members";
            this.tbpMembers.UseVisualStyleBackColor = true;
            this.tbpMembers.Enter += new System.EventHandler(this.tbpMembers_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel2.Controls.Add(this.tblGroupActionsGroupMembers, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lvMembers, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(416, 391);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tblGroupActionsGroupMembers
            // 
            this.tblGroupActionsGroupMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblGroupActionsGroupMembers.ColumnCount = 5;
            this.tblGroupActionsGroupMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tblGroupActionsGroupMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tblGroupActionsGroupMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tblGroupActionsGroupMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tblGroupActionsGroupMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tblGroupActionsGroupMembers.Controls.Add(this.btnRemoveGroupMembers, 4, 0);
            this.tblGroupActionsGroupMembers.Controls.Add(this.btnAddGroupMembers, 3, 0);
            this.tblGroupActionsGroupMembers.Controls.Add(this.ckBoxNestedGroupMembers, 2, 0);
            this.tblGroupActionsGroupMembers.Controls.Add(this.pBoxProgressGroupMembers, 1, 0);
            this.tblGroupActionsGroupMembers.Controls.Add(this.lblMembersCount, 0, 0);
            this.tblGroupActionsGroupMembers.Location = new System.Drawing.Point(3, 359);
            this.tblGroupActionsGroupMembers.Name = "tblGroupActionsGroupMembers";
            this.tblGroupActionsGroupMembers.RowCount = 1;
            this.tblGroupActionsGroupMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGroupActionsGroupMembers.Size = new System.Drawing.Size(410, 29);
            this.tblGroupActionsGroupMembers.TabIndex = 34;
            // 
            // btnRemoveGroupMembers
            // 
            this.btnRemoveGroupMembers.Enabled = false;
            this.btnRemoveGroupMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveGroupMembers.Location = new System.Drawing.Point(341, 3);
            this.btnRemoveGroupMembers.Name = "btnRemoveGroupMembers";
            this.btnRemoveGroupMembers.Size = new System.Drawing.Size(67, 23);
            this.btnRemoveGroupMembers.TabIndex = 34;
            this.btnRemoveGroupMembers.Text = "Remove";
            this.btnRemoveGroupMembers.UseVisualStyleBackColor = true;
            this.btnRemoveGroupMembers.Click += new System.EventHandler(this.btnRemoveGroupMembers_Click);
            // 
            // btnAddGroupMembers
            // 
            this.btnAddGroupMembers.ContextMenuStrip = this.cMenuSearchType;
            this.btnAddGroupMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroupMembers.Location = new System.Drawing.Point(270, 3);
            this.btnAddGroupMembers.Name = "btnAddGroupMembers";
            this.btnAddGroupMembers.Size = new System.Drawing.Size(65, 23);
            this.btnAddGroupMembers.TabIndex = 33;
            this.btnAddGroupMembers.Text = "Add...";
            this.btnAddGroupMembers.UseVisualStyleBackColor = true;
            this.btnAddGroupMembers.Click += new System.EventHandler(this.btnAddGroupMembers_Click);
            // 
            // cMenuSearchType
            // 
            this.cMenuSearchType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem,
            this.userToolStripMenuItem});
            this.cMenuSearchType.Name = "cMenuSearchType";
            this.cMenuSearchType.Size = new System.Drawing.Size(104, 48);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Image = global::Seeker.Properties.Resources.seekUser24;
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.groupToolStripMenuItem.Text = "User";
            this.groupToolStripMenuItem.Visible = false;
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Image = global::Seeker.Properties.Resources.seekFnet24;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.userToolStripMenuItem.Text = "Group";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // ckBoxNestedGroupMembers
            // 
            this.ckBoxNestedGroupMembers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckBoxNestedGroupMembers.AutoSize = true;
            this.ckBoxNestedGroupMembers.Location = new System.Drawing.Point(167, 6);
            this.ckBoxNestedGroupMembers.Name = "ckBoxNestedGroupMembers";
            this.ckBoxNestedGroupMembers.Size = new System.Drawing.Size(97, 17);
            this.ckBoxNestedGroupMembers.TabIndex = 36;
            this.ckBoxNestedGroupMembers.Text = "Show nested ?";
            this.ckBoxNestedGroupMembers.UseVisualStyleBackColor = true;
            this.ckBoxNestedGroupMembers.CheckedChanged += new System.EventHandler(this.ckBoxNestedGroupMembers_CheckedChanged);
            // 
            // pBoxProgressGroupMembers
            // 
            this.pBoxProgressGroupMembers.Image = global::Seeker.Properties.Resources.pBarGreen;
            this.pBoxProgressGroupMembers.Location = new System.Drawing.Point(86, 3);
            this.pBoxProgressGroupMembers.Name = "pBoxProgressGroupMembers";
            this.pBoxProgressGroupMembers.Size = new System.Drawing.Size(75, 23);
            this.pBoxProgressGroupMembers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxProgressGroupMembers.TabIndex = 37;
            this.pBoxProgressGroupMembers.TabStop = false;
            this.pBoxProgressGroupMembers.Visible = false;
            // 
            // lblMembersCount
            // 
            this.lblMembersCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMembersCount.AutoSize = true;
            this.lblMembersCount.Location = new System.Drawing.Point(80, 8);
            this.lblMembersCount.Name = "lblMembersCount";
            this.lblMembersCount.Size = new System.Drawing.Size(0, 13);
            this.lblMembersCount.TabIndex = 38;
            this.lblMembersCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvMembers
            // 
            this.lvMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader6,
            columnHeader7,
            columnHeader8});
            this.lvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMembers.FullRowSelect = true;
            this.lvMembers.Location = new System.Drawing.Point(3, 3);
            this.lvMembers.Name = "lvMembers";
            this.lvMembers.Size = new System.Drawing.Size(410, 350);
            this.lvMembers.TabIndex = 35;
            this.lvMembers.UseCompatibleStateImageBehavior = false;
            this.lvMembers.View = System.Windows.Forms.View.Details;
            this.lvMembers.SelectedIndexChanged += new System.EventHandler(this.lvMembers_SelectedIndexChanged);
            this.lvMembers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMembers_MouseClick);
            // 
            // tbpMemberOf
            // 
            this.tbpMemberOf.Controls.Add(this.tblMemberOf);
            this.tbpMemberOf.Location = new System.Drawing.Point(4, 22);
            this.tbpMemberOf.Name = "tbpMemberOf";
            this.tbpMemberOf.Size = new System.Drawing.Size(416, 391);
            this.tbpMemberOf.TabIndex = 1;
            this.tbpMemberOf.Text = "Member Of";
            this.tbpMemberOf.UseVisualStyleBackColor = true;
            this.tbpMemberOf.Enter += new System.EventHandler(this.tbpMemberOf_Enter);
            // 
            // tblMemberOf
            // 
            this.tblMemberOf.ColumnCount = 1;
            this.tblMemberOf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tblMemberOf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMemberOf.Controls.Add(this.tblGroupActionsGroupGroups, 0, 1);
            this.tblMemberOf.Controls.Add(this.lvlGroupGroups, 1, 0);
            this.tblMemberOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMemberOf.Location = new System.Drawing.Point(0, 0);
            this.tblMemberOf.Name = "tblMemberOf";
            this.tblMemberOf.RowCount = 2;
            this.tblMemberOf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMemberOf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblMemberOf.Size = new System.Drawing.Size(416, 391);
            this.tblMemberOf.TabIndex = 1;
            // 
            // tblGroupActionsGroupGroups
            // 
            this.tblGroupActionsGroupGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblGroupActionsGroupGroups.ColumnCount = 5;
            this.tblGroupActionsGroupGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tblGroupActionsGroupGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tblGroupActionsGroupGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tblGroupActionsGroupGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tblGroupActionsGroupGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tblGroupActionsGroupGroups.Controls.Add(this.btnRemoveGroupGroups, 4, 0);
            this.tblGroupActionsGroupGroups.Controls.Add(this.btnAddGroupGroups, 3, 0);
            this.tblGroupActionsGroupGroups.Controls.Add(this.ckBoxNestedGroupGroups, 2, 0);
            this.tblGroupActionsGroupGroups.Controls.Add(this.pBoxProgressGroupsGroups, 1, 0);
            this.tblGroupActionsGroupGroups.Location = new System.Drawing.Point(11, 359);
            this.tblGroupActionsGroupGroups.Name = "tblGroupActionsGroupGroups";
            this.tblGroupActionsGroupGroups.RowCount = 1;
            this.tblGroupActionsGroupGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGroupActionsGroupGroups.Size = new System.Drawing.Size(402, 29);
            this.tblGroupActionsGroupGroups.TabIndex = 35;
            // 
            // btnRemoveGroupGroups
            // 
            this.btnRemoveGroupGroups.Enabled = false;
            this.btnRemoveGroupGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveGroupGroups.Location = new System.Drawing.Point(333, 3);
            this.btnRemoveGroupGroups.Name = "btnRemoveGroupGroups";
            this.btnRemoveGroupGroups.Size = new System.Drawing.Size(67, 23);
            this.btnRemoveGroupGroups.TabIndex = 34;
            this.btnRemoveGroupGroups.Text = "Remove";
            this.btnRemoveGroupGroups.UseVisualStyleBackColor = true;
            this.btnRemoveGroupGroups.Click += new System.EventHandler(this.btnRemoveGroupGroups_Click);
            // 
            // btnAddGroupGroups
            // 
            this.btnAddGroupGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroupGroups.Location = new System.Drawing.Point(260, 3);
            this.btnAddGroupGroups.Name = "btnAddGroupGroups";
            this.btnAddGroupGroups.Size = new System.Drawing.Size(66, 23);
            this.btnAddGroupGroups.TabIndex = 33;
            this.btnAddGroupGroups.Text = "Add...";
            this.btnAddGroupGroups.UseVisualStyleBackColor = true;
            this.btnAddGroupGroups.Click += new System.EventHandler(this.btnAddGroupGroups_Click);
            // 
            // ckBoxNestedGroupGroups
            // 
            this.ckBoxNestedGroupGroups.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckBoxNestedGroupGroups.AutoSize = true;
            this.ckBoxNestedGroupGroups.Location = new System.Drawing.Point(157, 6);
            this.ckBoxNestedGroupGroups.Name = "ckBoxNestedGroupGroups";
            this.ckBoxNestedGroupGroups.Size = new System.Drawing.Size(97, 17);
            this.ckBoxNestedGroupGroups.TabIndex = 36;
            this.ckBoxNestedGroupGroups.Text = "Show nested ?";
            this.ckBoxNestedGroupGroups.UseVisualStyleBackColor = true;
            this.ckBoxNestedGroupGroups.Visible = false;
            this.ckBoxNestedGroupGroups.CheckedChanged += new System.EventHandler(this.ckBoxNestedGroups_CheckedChanged);
            // 
            // pBoxProgressGroupsGroups
            // 
            this.pBoxProgressGroupsGroups.Image = global::Seeker.Properties.Resources.pBarGreen;
            this.pBoxProgressGroupsGroups.Location = new System.Drawing.Point(76, 3);
            this.pBoxProgressGroupsGroups.Name = "pBoxProgressGroupsGroups";
            this.pBoxProgressGroupsGroups.Size = new System.Drawing.Size(75, 23);
            this.pBoxProgressGroupsGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxProgressGroupsGroups.TabIndex = 37;
            this.pBoxProgressGroupsGroups.TabStop = false;
            this.pBoxProgressGroupsGroups.Visible = false;
            // 
            // lvlGroupGroups
            // 
            this.lvlGroupGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlGroupGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader3,
            columnHeader4});
            this.lvlGroupGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvlGroupGroups.FullRowSelect = true;
            this.lvlGroupGroups.Location = new System.Drawing.Point(3, 3);
            this.lvlGroupGroups.Name = "lvlGroupGroups";
            this.lvlGroupGroups.Size = new System.Drawing.Size(410, 350);
            this.lvlGroupGroups.TabIndex = 36;
            this.lvlGroupGroups.UseCompatibleStateImageBehavior = false;
            this.lvlGroupGroups.View = System.Windows.Forms.View.Details;
            this.lvlGroupGroups.SelectedIndexChanged += new System.EventHandler(this.lvlGroupGroups_SelectedIndexChanged);
            this.lvlGroupGroups.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvlGroupGroups_MouseClick);
            // 
            // frmSeekGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 423);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSeekGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seek:";
            
            this.Load += new System.EventHandler(this.frmSeekGroup_Load);
            this.Move += new System.EventHandler(this.frmSeekGroup_Move);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbControlGroupInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblActions.ResumeLayout(false);
            this.tbpMembers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tblGroupActionsGroupMembers.ResumeLayout(false);
            this.tblGroupActionsGroupMembers.PerformLayout();
            this.cMenuSearchType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressGroupMembers)).EndInit();
            this.tbpMemberOf.ResumeLayout(false);
            this.tblMemberOf.ResumeLayout(false);
            this.tblGroupActionsGroupGroups.ResumeLayout(false);
            this.tblGroupActionsGroupGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressGroupsGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tbControlGroupInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tbpMembers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tblGroupActionsGroupMembers;
        private System.Windows.Forms.Button btnRemoveGroupMembers;
        private System.Windows.Forms.Button btnAddGroupMembers;
        private System.Windows.Forms.CheckBox ckBoxNestedGroupMembers;
        private System.Windows.Forms.PictureBox pBoxProgressGroupMembers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ContextMenuStrip cMenuSearchType;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDn;
        private System.Windows.Forms.TabPage tbpMemberOf;
        private System.Windows.Forms.TableLayoutPanel tblMemberOf;
        private System.Windows.Forms.TableLayoutPanel tblGroupActionsGroupGroups;
        private System.Windows.Forms.Button btnRemoveGroupGroups;
        private System.Windows.Forms.Button btnAddGroupGroups;
        private System.Windows.Forms.CheckBox ckBoxNestedGroupGroups;
        private System.Windows.Forms.PictureBox pBoxProgressGroupsGroups;
        private System.Windows.Forms.Label lblMembersCount;
        private Library.BufferedListView lvMembers;
        private Library.BufferedListView lvlGroupGroups;
        private System.Windows.Forms.TableLayoutPanel tblActions;
        private System.Windows.Forms.Button btnCopyUserData;
        private System.Windows.Forms.Button btnCollectObject;
    }
}