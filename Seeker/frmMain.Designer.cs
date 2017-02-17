namespace Seeker
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notifyMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newSeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuSeekUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seekUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuSeekComputer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seekComputerToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuSeekGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seekGroupToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuSeekOu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seekOuToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.imgListObjType = new System.Windows.Forms.ImageList(this.components);
            this.cMenuSeekUnk = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seekUnknowToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuTray.SuspendLayout();
            this.cMenuSeekUser.SuspendLayout();
            this.cMenuSeekComputer.SuspendLayout();
            this.cMenuSeekGroup.SuspendLayout();
            this.cMenuSeekOu.SuspendLayout();
            this.cMenuSeekUnk.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyMain
            // 
            this.notifyMain.ContextMenuStrip = this.cMenuTray;
            this.notifyMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyMain.Icon")));
            this.notifyMain.Text = "Seeker";
            this.notifyMain.Visible = true;
            this.notifyMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyMain_MouseClick);
            this.notifyMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyMain_MouseDoubleClick);
            // 
            // cMenuTray
            // 
            this.cMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSeekToolStripMenuItem,
            this.toolStripMenuItem3,
            this.sessionsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.clearAllToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logoutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.cMenuTray.Name = "cMenuTray";
            this.cMenuTray.Size = new System.Drawing.Size(122, 176);
            // 
            // newSeekToolStripMenuItem
            // 
            this.newSeekToolStripMenuItem.Image = global::Seeker.Properties.Resources.newSeek24;
            this.newSeekToolStripMenuItem.Name = "newSeekToolStripMenuItem";
            this.newSeekToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newSeekToolStripMenuItem.Text = "New &Seek";
            this.newSeekToolStripMenuItem.Click += new System.EventHandler(this.newSeekToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(118, 6);
            // 
            // sessionsToolStripMenuItem
            // 
            this.sessionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageSessionsToolStripMenuItem,
            this.toolStripMenuItem9,
            this.saveSessionToolStripMenuItem,
            this.savedSessionsToolStripMenuItem});
            this.sessionsToolStripMenuItem.Image = global::Seeker.Properties.Resources.seekerSessions16;
            this.sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            this.sessionsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sessionsToolStripMenuItem.Text = "Sessions";
            this.sessionsToolStripMenuItem.Paint += new System.Windows.Forms.PaintEventHandler(this.sessionsToolStripMenuItem_Paint);
            // 
            // manageSessionsToolStripMenuItem
            // 
            this.manageSessionsToolStripMenuItem.Image = global::Seeker.Properties.Resources.sessionManager16;
            this.manageSessionsToolStripMenuItem.Name = "manageSessionsToolStripMenuItem";
            this.manageSessionsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.manageSessionsToolStripMenuItem.Text = "Manage Sessions";
            this.manageSessionsToolStripMenuItem.Click += new System.EventHandler(this.manageSessionsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(153, 6);
            // 
            // saveSessionToolStripMenuItem
            // 
            this.saveSessionToolStripMenuItem.Image = global::Seeker.Properties.Resources.seekerSessionsSave16;
            this.saveSessionToolStripMenuItem.Name = "saveSessionToolStripMenuItem";
            this.saveSessionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveSessionToolStripMenuItem.Text = "Save session";
            this.saveSessionToolStripMenuItem.Click += new System.EventHandler(this.saveSessionToolStripMenuItem_Click);
            // 
            // savedSessionsToolStripMenuItem
            // 
            this.savedSessionsToolStripMenuItem.Image = global::Seeker.Properties.Resources.seekerSessions16;
            this.savedSessionsToolStripMenuItem.Name = "savedSessionsToolStripMenuItem";
            this.savedSessionsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.savedSessionsToolStripMenuItem.Text = "Saved sessions";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Image = global::Seeker.Properties.Resources.seekerReport;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Visible = false;
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Image = global::Seeker.Properties.Resources.sessionClearAll;
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.clearAllToolStripMenuItem.Text = "Clear all";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 6);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Image = global::Seeker.Properties.Resources.logout24;
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.logoutToolStripMenuItem1.Text = "Lo&gout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Seeker.Properties.Resources.exit24;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cMenuSeekUser
            // 
            this.cMenuSeekUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seekUserToolStripMenuItem});
            this.cMenuSeekUser.Name = "cMenuSeekUSer";
            this.cMenuSeekUser.Size = new System.Drawing.Size(130, 26);
            this.cMenuSeekUser.Opening += new System.ComponentModel.CancelEventHandler(this.cMenuSeekUser_Opening);
            // 
            // seekUserToolStripMenuItem
            // 
            this.seekUserToolStripMenuItem.Image = global::Seeker.Properties.Resources.seekUser24;
            this.seekUserToolStripMenuItem.Name = "seekUserToolStripMenuItem";
            this.seekUserToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.seekUserToolStripMenuItem.Text = "Seek User: ";
            this.seekUserToolStripMenuItem.Click += new System.EventHandler(this.seekUserToolStripMenuItem_Click);
            // 
            // cMenuSeekComputer
            // 
            this.cMenuSeekComputer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seekComputerToolStripMenuItem4});
            this.cMenuSeekComputer.Name = "cMenuSeekUSer";
            this.cMenuSeekComputer.Size = new System.Drawing.Size(152, 26);
            this.cMenuSeekComputer.Opening += new System.ComponentModel.CancelEventHandler(this.cMenuSeekComputer_Opening);
            // 
            // seekComputerToolStripMenuItem4
            // 
            this.seekComputerToolStripMenuItem4.Image = global::Seeker.Properties.Resources.seekComputer24;
            this.seekComputerToolStripMenuItem4.Name = "seekComputerToolStripMenuItem4";
            this.seekComputerToolStripMenuItem4.Size = new System.Drawing.Size(151, 22);
            this.seekComputerToolStripMenuItem4.Text = "Seek Computer:";
            this.seekComputerToolStripMenuItem4.Click += new System.EventHandler(this.seekComputerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(32, 19);
            // 
            // cMenuSeekGroup
            // 
            this.cMenuSeekGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seekGroupToolStripMenuItem6});
            this.cMenuSeekGroup.Name = "cMenuSeekUSer";
            this.cMenuSeekGroup.Size = new System.Drawing.Size(134, 26);
            this.cMenuSeekGroup.Opening += new System.ComponentModel.CancelEventHandler(this.cMenuSeekGroup_Opening);
            // 
            // seekGroupToolStripMenuItem6
            // 
            this.seekGroupToolStripMenuItem6.Image = global::Seeker.Properties.Resources.groupMembertIcon16;
            this.seekGroupToolStripMenuItem6.Name = "seekGroupToolStripMenuItem6";
            this.seekGroupToolStripMenuItem6.Size = new System.Drawing.Size(133, 22);
            this.seekGroupToolStripMenuItem6.Text = "Seek Group:";
            this.seekGroupToolStripMenuItem6.Click += new System.EventHandler(this.seekGroupToolStripMenuItem_Click);
            // 
            // cMenuSeekOu
            // 
            this.cMenuSeekOu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seekOuToolStripMenuItem7});
            this.cMenuSeekOu.Name = "cMenuSeekUSer";
            this.cMenuSeekOu.Size = new System.Drawing.Size(123, 26);
            this.cMenuSeekOu.Opening += new System.ComponentModel.CancelEventHandler(this.cMenuSeekOu_Opening);
            // 
            // seekOuToolStripMenuItem7
            // 
            this.seekOuToolStripMenuItem7.Image = global::Seeker.Properties.Resources.ouIcon;
            this.seekOuToolStripMenuItem7.Name = "seekOuToolStripMenuItem7";
            this.seekOuToolStripMenuItem7.Size = new System.Drawing.Size(122, 22);
            this.seekOuToolStripMenuItem7.Text = "Seek OU: ";
            this.seekOuToolStripMenuItem7.Click += new System.EventHandler(this.seekOuToolStripMenuItem_Click);
            // 
            // imgListObjType
            // 
            this.imgListObjType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListObjType.ImageStream")));
            this.imgListObjType.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListObjType.Images.SetKeyName(0, "User");
            this.imgListObjType.Images.SetKeyName(1, "userMember");
            this.imgListObjType.Images.SetKeyName(2, "userMemberSelected");
            this.imgListObjType.Images.SetKeyName(3, "computer");
            this.imgListObjType.Images.SetKeyName(4, "computerMember");
            this.imgListObjType.Images.SetKeyName(5, "computerMemberSelected");
            this.imgListObjType.Images.SetKeyName(6, "fNetDb");
            this.imgListObjType.Images.SetKeyName(7, "fNetDbMember");
            this.imgListObjType.Images.SetKeyName(8, "fNetDbSelected");
            this.imgListObjType.Images.SetKeyName(9, "Group");
            this.imgListObjType.Images.SetKeyName(10, "groupMember");
            this.imgListObjType.Images.SetKeyName(11, "groupMemberSelected");
            this.imgListObjType.Images.SetKeyName(12, "unknowObject");
            this.imgListObjType.Images.SetKeyName(13, "ouIcon");
            this.imgListObjType.Images.SetKeyName(14, "ouMemberIcon.png");
            this.imgListObjType.Images.SetKeyName(15, "ouMemberSelectedIcon.png");
            this.imgListObjType.Images.SetKeyName(16, "seekerSession");
            // 
            // cMenuSeekUnk
            // 
            this.cMenuSeekUnk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seekUnknowToolStripMenuItem8});
            this.cMenuSeekUnk.Name = "cMenuSeekUSer";
            this.cMenuSeekUnk.Size = new System.Drawing.Size(153, 48);
            this.cMenuSeekUnk.Opening += new System.ComponentModel.CancelEventHandler(this.cMenuSeekUnk_Opening);
            // 
            // seekUnknowToolStripMenuItem8
            // 
            this.seekUnknowToolStripMenuItem8.Image = global::Seeker.Properties.Resources.newSeek24;
            this.seekUnknowToolStripMenuItem8.Name = "seekUnknowToolStripMenuItem8";
            this.seekUnknowToolStripMenuItem8.Size = new System.Drawing.Size(152, 22);
            this.seekUnknowToolStripMenuItem8.Text = "Seek Unknow: ";
            this.seekUnknowToolStripMenuItem8.Click += new System.EventHandler(this.seekUnknowToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(193, 98);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seeker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cMenuTray.ResumeLayout(false);
            this.cMenuSeekUser.ResumeLayout(false);
            this.cMenuSeekComputer.ResumeLayout(false);
            this.cMenuSeekGroup.ResumeLayout(false);
            this.cMenuSeekOu.ResumeLayout(false);
            this.cMenuSeekUnk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyMain;
        public System.Windows.Forms.ContextMenuStrip cMenuSeekUser;
        private System.Windows.Forms.ToolStripMenuItem seekUserToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip cMenuSeekComputer;
        private System.Windows.Forms.ToolStripMenuItem seekComputerToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        public System.Windows.Forms.ContextMenuStrip cMenuSeekGroup;
        private System.Windows.Forms.ToolStripMenuItem seekGroupToolStripMenuItem6;
        public System.Windows.Forms.ContextMenuStrip cMenuSeekOu;
        private System.Windows.Forms.ToolStripMenuItem seekOuToolStripMenuItem7;
        public System.Windows.Forms.ImageList imgListObjType;
        public System.Windows.Forms.ContextMenuStrip cMenuSeekUnk;
        private System.Windows.Forms.ToolStripMenuItem seekUnknowToolStripMenuItem8;
        private System.Windows.Forms.ContextMenuStrip cMenuTray;
        private System.Windows.Forms.ToolStripMenuItem newSeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem saveSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savedSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

