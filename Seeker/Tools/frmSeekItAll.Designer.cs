namespace Seeker
{
    partial class frmSeekItAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeekItAll));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.sSMain = new System.Windows.Forms.StatusStrip();
            this.tsLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSUsers = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSComputers = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSFnet = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSGroups = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSOUs = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtBoxObject = new Seeker.WaterMarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tvResults = new Seeker.Library.BufferedTreeView();
            this.selectedUserPic = new System.Windows.Forms.PictureBox();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuOu = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.sSMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedUserPic)).BeginInit();
            this.cMenuOu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.tblMain);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.selectedUserPic);
            this.splitMain.Panel2Collapsed = true;
            this.splitMain.Size = new System.Drawing.Size(611, 360);
            this.splitMain.SplitterDistance = 383;
            this.splitMain.TabIndex = 31;
            // 
            // tblMain
            // 
            this.tblMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.sSMain, 0, 2);
            this.tblMain.Controls.Add(this.txtBoxObject, 1, 0);
            this.tblMain.Controls.Add(this.label1, 0, 0);
            this.tblMain.Controls.Add(this.tvResults, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(611, 360);
            this.tblMain.TabIndex = 31;
            // 
            // sSMain
            // 
            this.tblMain.SetColumnSpan(this.sSMain, 2);
            this.sSMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLoggedUser,
            this.tSUsers,
            this.tSComputers,
            this.tSFnet,
            this.tSGroups,
            this.tSOUs});
            this.sSMain.Location = new System.Drawing.Point(1, 339);
            this.sSMain.Name = "sSMain";
            this.sSMain.Size = new System.Drawing.Size(609, 20);
            this.sSMain.SizingGrip = false;
            this.sSMain.TabIndex = 34;
            this.sSMain.Text = "statusStrip1";
            // 
            // tsLoggedUser
            // 
            this.tsLoggedUser.IsLink = true;
            this.tsLoggedUser.Name = "tsLoggedUser";
            this.tsLoggedUser.Size = new System.Drawing.Size(0, 15);
            this.tsLoggedUser.Click += new System.EventHandler(this.tsLoggedUser_Click);
            // 
            // tSUsers
            // 
            this.tSUsers.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tSUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSUsers.Name = "tSUsers";
            this.tSUsers.Size = new System.Drawing.Size(0, 15);
            // 
            // tSComputers
            // 
            this.tSComputers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSComputers.Name = "tSComputers";
            this.tSComputers.Size = new System.Drawing.Size(0, 15);
            // 
            // tSFnet
            // 
            this.tSFnet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSFnet.Name = "tSFnet";
            this.tSFnet.Size = new System.Drawing.Size(0, 15);
            // 
            // tSGroups
            // 
            this.tSGroups.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSGroups.Name = "tSGroups";
            this.tSGroups.Size = new System.Drawing.Size(0, 15);
            // 
            // tSOUs
            // 
            this.tSOUs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSOUs.Name = "tSOUs";
            this.tSOUs.Size = new System.Drawing.Size(0, 15);
            // 
            // txtBoxObject
            // 
            this.txtBoxObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBoxObject.Location = new System.Drawing.Point(110, 4);
            this.txtBoxObject.Name = "txtBoxObject";
            this.txtBoxObject.Size = new System.Drawing.Size(497, 20);
            this.txtBoxObject.TabIndex = 35;
            this.txtBoxObject.WaterMarkColor = System.Drawing.Color.DimGray;
            this.txtBoxObject.WaterMarkText = "Insira pelo menos 3 Caracteres";
            this.txtBoxObject.TextChanged += new System.EventHandler(this.txtBoxObject_TextChanged);
            this.txtBoxObject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxObject_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "I\'m Seeking for:";
            // 
            // tvResults
            // 
            this.tvResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblMain.SetColumnSpan(this.tvResults, 2);
            this.tvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvResults.Location = new System.Drawing.Point(4, 29);
            this.tvResults.Name = "tvResults";
            this.tvResults.Size = new System.Drawing.Size(603, 306);
            this.tvResults.TabIndex = 38;
            this.tvResults.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvResults_AfterSelect);
            this.tvResults.DoubleClick += new System.EventHandler(this.tvResults_DoubleClick);
            this.tvResults.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvResults_MouseClick);
            // 
            // selectedUserPic
            // 
            this.selectedUserPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedUserPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedUserPic.Location = new System.Drawing.Point(0, 0);
            this.selectedUserPic.Name = "selectedUserPic";
            this.selectedUserPic.Size = new System.Drawing.Size(96, 100);
            this.selectedUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedUserPic.TabIndex = 31;
            this.selectedUserPic.TabStop = false;
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Image = global::Seeker.Properties.Resources.groupMembertIcon16;
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // cMenuOu
            // 
            this.cMenuOu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem});
            this.cMenuOu.Name = "cMenuOu";
            this.cMenuOu.Size = new System.Drawing.Size(135, 26);
            // 
            // frmSeekItAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 360);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeekItAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "What are you Seeking Today ?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSeekItAll_FormClosing);
            this.Load += new System.EventHandler(this.frmSeekItAll_Load);
            this.Shown += new System.EventHandler(this.frmSeekItAll_Shown);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.sSMain.ResumeLayout(false);
            this.sSMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedUserPic)).EndInit();
            this.cMenuOu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private WaterMarkTextBox txtBoxObject;
        private System.Windows.Forms.PictureBox selectedUserPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cMenuOu;
        private System.Windows.Forms.StatusStrip sSMain;
        private System.Windows.Forms.ToolStripStatusLabel tsLoggedUser;
        private System.Windows.Forms.ToolStripStatusLabel tSUsers;
        private System.Windows.Forms.ToolStripStatusLabel tSComputers;
        private System.Windows.Forms.ToolStripStatusLabel tSFnet;
        private System.Windows.Forms.ToolStripStatusLabel tSGroups;
        private Library.BufferedTreeView tvResults;
        private System.Windows.Forms.ToolStripStatusLabel tSOUs;
    }
}