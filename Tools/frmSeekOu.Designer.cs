namespace Seeker
{
    partial class frmSeekOu
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
            this.tbControlGroupInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblDn = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbpMembers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tblOuActionsMembers = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveGroupMembers = new System.Windows.Forms.Button();
            this.btnAddGroupMembers = new System.Windows.Forms.Button();
            this.ckBoxNestedGroupMembers = new System.Windows.Forms.CheckBox();
            this.pBoxProgressGroupMembers = new System.Windows.Forms.PictureBox();
            this.tvOuMembers = new Seeker.Library.BufferedTreeView();
            this.tblActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopyUserData = new System.Windows.Forms.Button();
            this.btnCollectObject = new System.Windows.Forms.Button();
            this.tbControlGroupInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tbpMembers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblOuActionsMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressGroupMembers)).BeginInit();
            this.tblActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlGroupInfo
            // 
            this.tbControlGroupInfo.Controls.Add(this.tabPage1);
            this.tbControlGroupInfo.Controls.Add(this.tbpMembers);
            this.tbControlGroupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlGroupInfo.Location = new System.Drawing.Point(0, 0);
            this.tbControlGroupInfo.Name = "tbControlGroupInfo";
            this.tbControlGroupInfo.SelectedIndex = 0;
            this.tbControlGroupInfo.Size = new System.Drawing.Size(430, 423);
            this.tbControlGroupInfo.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(422, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OU";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            this.tblMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tblMain.Controls.Add(this.label7, 0, 5);
            this.tblMain.Controls.Add(this.label6, 0, 4);
            this.tblMain.Controls.Add(this.label8, 0, 3);
            this.tblMain.Controls.Add(this.label2, 0, 2);
            this.tblMain.Controls.Add(this.label1, 0, 1);
            this.tblMain.Controls.Add(this.lblModifiedDate, 1, 5);
            this.tblMain.Controls.Add(this.lblCreatedDate, 1, 4);
            this.tblMain.Controls.Add(this.lblDn, 1, 3);
            this.tblMain.Controls.Add(this.lblDescription, 1, 2);
            this.tblMain.Controls.Add(this.lblName, 1, 1);
            this.tblMain.Controls.Add(this.tblActions, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(3, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 10;
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
            this.tblMain.Size = new System.Drawing.Size(416, 391);
            this.tblMain.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Modified Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Created Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "DN:";
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
            this.lblModifiedDate.Location = new System.Drawing.Point(94, 129);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(254, 13);
            this.lblModifiedDate.TabIndex = 0;
            this.lblModifiedDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(94, 108);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(254, 13);
            this.lblCreatedDate.TabIndex = 0;
            this.lblCreatedDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblDn
            // 
            this.lblDn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDn.AutoSize = true;
            this.lblDn.Location = new System.Drawing.Point(94, 87);
            this.lblDn.Name = "lblDn";
            this.lblDn.Size = new System.Drawing.Size(254, 13);
            this.lblDn.TabIndex = 0;
            this.lblDn.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(94, 66);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(254, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(94, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(254, 13);
            this.lblName.TabIndex = 0;
            this.lblName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // tbpMembers
            // 
            this.tbpMembers.Controls.Add(this.tableLayoutPanel2);
            this.tbpMembers.Location = new System.Drawing.Point(4, 22);
            this.tbpMembers.Name = "tbpMembers";
            this.tbpMembers.Size = new System.Drawing.Size(422, 397);
            this.tbpMembers.TabIndex = 2;
            this.tbpMembers.Text = "Members";
            this.tbpMembers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 422F));
            this.tableLayoutPanel2.Controls.Add(this.tblOuActionsMembers, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tvOuMembers, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(422, 397);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tblOuActionsMembers
            // 
            this.tblOuActionsMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblOuActionsMembers.ColumnCount = 5;
            this.tblOuActionsMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tblOuActionsMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tblOuActionsMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tblOuActionsMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tblOuActionsMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tblOuActionsMembers.Controls.Add(this.btnRemoveGroupMembers, 4, 0);
            this.tblOuActionsMembers.Controls.Add(this.btnAddGroupMembers, 3, 0);
            this.tblOuActionsMembers.Controls.Add(this.ckBoxNestedGroupMembers, 2, 0);
            this.tblOuActionsMembers.Controls.Add(this.pBoxProgressGroupMembers, 1, 0);
            this.tblOuActionsMembers.Location = new System.Drawing.Point(17, 365);
            this.tblOuActionsMembers.Name = "tblOuActionsMembers";
            this.tblOuActionsMembers.RowCount = 1;
            this.tblOuActionsMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOuActionsMembers.Size = new System.Drawing.Size(402, 29);
            this.tblOuActionsMembers.TabIndex = 34;
            // 
            // btnRemoveGroupMembers
            // 
            this.btnRemoveGroupMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveGroupMembers.Location = new System.Drawing.Point(333, 3);
            this.btnRemoveGroupMembers.Name = "btnRemoveGroupMembers";
            this.btnRemoveGroupMembers.Size = new System.Drawing.Size(67, 23);
            this.btnRemoveGroupMembers.TabIndex = 34;
            this.btnRemoveGroupMembers.Text = "Remove";
            this.btnRemoveGroupMembers.UseVisualStyleBackColor = true;
            // 
            // btnAddGroupMembers
            // 
            this.btnAddGroupMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroupMembers.Location = new System.Drawing.Point(260, 3);
            this.btnAddGroupMembers.Name = "btnAddGroupMembers";
            this.btnAddGroupMembers.Size = new System.Drawing.Size(66, 23);
            this.btnAddGroupMembers.TabIndex = 33;
            this.btnAddGroupMembers.Text = "Add...";
            this.btnAddGroupMembers.UseVisualStyleBackColor = true;
            this.btnAddGroupMembers.Click += new System.EventHandler(this.btnAddGroupMembers_Click);
            // 
            // ckBoxNestedGroupMembers
            // 
            this.ckBoxNestedGroupMembers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckBoxNestedGroupMembers.AutoSize = true;
            this.ckBoxNestedGroupMembers.Location = new System.Drawing.Point(157, 6);
            this.ckBoxNestedGroupMembers.Name = "ckBoxNestedGroupMembers";
            this.ckBoxNestedGroupMembers.Size = new System.Drawing.Size(97, 17);
            this.ckBoxNestedGroupMembers.TabIndex = 36;
            this.ckBoxNestedGroupMembers.Text = "Show nested ?";
            this.ckBoxNestedGroupMembers.UseVisualStyleBackColor = true;
            this.ckBoxNestedGroupMembers.Visible = false;
            // 
            // pBoxProgressGroupMembers
            // 
            this.pBoxProgressGroupMembers.Image = global::Seeker.Properties.Resources.pBarGreen;
            this.pBoxProgressGroupMembers.Location = new System.Drawing.Point(76, 3);
            this.pBoxProgressGroupMembers.Name = "pBoxProgressGroupMembers";
            this.pBoxProgressGroupMembers.Size = new System.Drawing.Size(75, 23);
            this.pBoxProgressGroupMembers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxProgressGroupMembers.TabIndex = 37;
            this.pBoxProgressGroupMembers.TabStop = false;
            this.pBoxProgressGroupMembers.Visible = false;
            // 
            // tvOuMembers
            // 
            this.tvOuMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvOuMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOuMembers.Location = new System.Drawing.Point(3, 3);
            this.tvOuMembers.Name = "tvOuMembers";
            this.tvOuMembers.Size = new System.Drawing.Size(416, 356);
            this.tvOuMembers.TabIndex = 35;
            this.tvOuMembers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOuMembers_AfterSelect);
            this.tvOuMembers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvOuMembers_MouseClick);
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
            // frmSeekOu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 423);
            this.Controls.Add(this.tbControlGroupInfo);
            this.Name = "frmSeekOu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seek:";
            this.Load += new System.EventHandler(this.frmSeekOu_Load);
            this.Move += new System.EventHandler(this.frmSeekOu_Move);
            this.tbControlGroupInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tbpMembers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tblOuActionsMembers.ResumeLayout(false);
            this.tblOuActionsMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressGroupMembers)).EndInit();
            this.tblActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlGroupInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDn;
        private System.Windows.Forms.TabPage tbpMembers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tblOuActionsMembers;
        private System.Windows.Forms.Button btnRemoveGroupMembers;
        private System.Windows.Forms.Button btnAddGroupMembers;
        private System.Windows.Forms.CheckBox ckBoxNestedGroupMembers;
        private System.Windows.Forms.PictureBox pBoxProgressGroupMembers;
        private Library.BufferedTreeView tvOuMembers;
        private System.Windows.Forms.TableLayoutPanel tblActions;
        private System.Windows.Forms.Button btnCopyUserData;
        private System.Windows.Forms.Button btnCollectObject;
    }
}