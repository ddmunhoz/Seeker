namespace Seeker
{
    partial class frmSessionManager
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
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader4;
            System.Windows.Forms.ColumnHeader columnHeader5;
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pBoxProgressUserSessions = new System.Windows.Forms.PictureBox();
            this.lblSessionCounter = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pBoxProgressSessionObjects = new System.Windows.Forms.PictureBox();
            this.lblSessionObjectsCounter = new System.Windows.Forms.Label();
            this.tblActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveSession = new System.Windows.Forms.Button();
            this.btnExportSession = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnImportSession = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.lvUserSessions = new Seeker.Library.BufferedListView();
            this.lvSessionObjects = new Seeker.Library.BufferedListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressUserSessions)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressSessionObjects)).BeginInit();
            this.tblActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.splitMain, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tblActions, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(849, 532);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(3, 3);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitMain.Size = new System.Drawing.Size(843, 491);
            this.splitMain.SplitterDistance = 420;
            this.splitMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lvUserSessions, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBoxProgressUserSessions, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSessionCounter, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 491);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Sessions:";
            // 
            // pBoxProgressUserSessions
            // 
            this.pBoxProgressUserSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxProgressUserSessions.Image = global::Seeker.Properties.Resources.pBarGreen;
            this.pBoxProgressUserSessions.Location = new System.Drawing.Point(342, 3);
            this.pBoxProgressUserSessions.Name = "pBoxProgressUserSessions";
            this.pBoxProgressUserSessions.Size = new System.Drawing.Size(75, 23);
            this.pBoxProgressUserSessions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxProgressUserSessions.TabIndex = 37;
            this.pBoxProgressUserSessions.TabStop = false;
            this.pBoxProgressUserSessions.Visible = false;
            // 
            // lblSessionCounter
            // 
            this.lblSessionCounter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSessionCounter.AutoSize = true;
            this.lblSessionCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionCounter.Location = new System.Drawing.Point(73, 8);
            this.lblSessionCounter.Name = "lblSessionCounter";
            this.lblSessionCounter.Size = new System.Drawing.Size(14, 13);
            this.lblSessionCounter.TabIndex = 36;
            this.lblSessionCounter.Text = "0";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.lvSessionObjects, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pBoxProgressSessionObjects, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSessionObjectsCounter, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(419, 491);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Member objects:";
            // 
            // pBoxProgressSessionObjects
            // 
            this.pBoxProgressSessionObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxProgressSessionObjects.Image = global::Seeker.Properties.Resources.pBarGreen;
            this.pBoxProgressSessionObjects.Location = new System.Drawing.Point(342, 3);
            this.pBoxProgressSessionObjects.Name = "pBoxProgressSessionObjects";
            this.pBoxProgressSessionObjects.Size = new System.Drawing.Size(75, 23);
            this.pBoxProgressSessionObjects.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxProgressSessionObjects.TabIndex = 37;
            this.pBoxProgressSessionObjects.TabStop = false;
            this.pBoxProgressSessionObjects.Visible = false;
            // 
            // lblSessionObjectsCounter
            // 
            this.lblSessionObjectsCounter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSessionObjectsCounter.AutoSize = true;
            this.lblSessionObjectsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionObjectsCounter.Location = new System.Drawing.Point(113, 8);
            this.lblSessionObjectsCounter.Name = "lblSessionObjectsCounter";
            this.lblSessionObjectsCounter.Size = new System.Drawing.Size(14, 13);
            this.lblSessionObjectsCounter.TabIndex = 36;
            this.lblSessionObjectsCounter.Text = "0";
            // 
            // tblActions
            // 
            this.tblActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblActions.ColumnCount = 4;
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblActions.Controls.Add(this.btnRemoveSession, 0, 0);
            this.tblActions.Controls.Add(this.btnExportSession, 1, 0);
            this.tblActions.Controls.Add(this.btnExit, 3, 0);
            this.tblActions.Controls.Add(this.btnImportSession, 2, 0);
            this.tblActions.Location = new System.Drawing.Point(557, 500);
            this.tblActions.Name = "tblActions";
            this.tblActions.RowCount = 1;
            this.tblActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblActions.Size = new System.Drawing.Size(289, 29);
            this.tblActions.TabIndex = 1;
            // 
            // btnRemoveSession
            // 
            this.btnRemoveSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSession.Enabled = false;
            this.btnRemoveSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSession.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveSession.Name = "btnRemoveSession";
            this.btnRemoveSession.Size = new System.Drawing.Size(66, 23);
            this.btnRemoveSession.TabIndex = 34;
            this.btnRemoveSession.Text = "Remove";
            this.btnRemoveSession.UseVisualStyleBackColor = true;
            this.btnRemoveSession.Click += new System.EventHandler(this.btnRemoveSession_Click);
            // 
            // btnExportSession
            // 
            this.btnExportSession.Enabled = false;
            this.btnExportSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportSession.Location = new System.Drawing.Point(75, 3);
            this.btnExportSession.Name = "btnExportSession";
            this.btnExportSession.Size = new System.Drawing.Size(66, 23);
            this.btnExportSession.TabIndex = 35;
            this.btnExportSession.Text = "Export";
            this.btnExportSession.UseVisualStyleBackColor = true;
            this.btnExportSession.Click += new System.EventHandler(this.btnExportSession_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(219, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 23);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnImportSession
            // 
            this.btnImportSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportSession.Location = new System.Drawing.Point(147, 3);
            this.btnImportSession.Name = "btnImportSession";
            this.btnImportSession.Size = new System.Drawing.Size(66, 23);
            this.btnImportSession.TabIndex = 35;
            this.btnImportSession.Text = "Import";
            this.btnImportSession.UseVisualStyleBackColor = true;
            this.btnImportSession.Click += new System.EventHandler(this.btnImportSession_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // lvUserSessions
            // 
            this.lvUserSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUserSessions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader3,
            columnHeader2});
            this.tableLayoutPanel1.SetColumnSpan(this.lvUserSessions, 3);
            this.lvUserSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUserSessions.FullRowSelect = true;
            this.lvUserSessions.Location = new System.Drawing.Point(3, 32);
            this.lvUserSessions.Name = "lvUserSessions";
            this.lvUserSessions.Size = new System.Drawing.Size(414, 456);
            this.lvUserSessions.TabIndex = 35;
            this.lvUserSessions.UseCompatibleStateImageBehavior = false;
            this.lvUserSessions.View = System.Windows.Forms.View.Details;
            this.lvUserSessions.SelectedIndexChanged += new System.EventHandler(this.lvUserSessions_SelectedIndexChanged);
            this.lvUserSessions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvUserSessions_MouseClick);
            this.lvUserSessions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvUserSessions_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Description";
            columnHeader1.Width = 161;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Count";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 144;
            // 
            // lvSessionObjects
            // 
            this.lvSessionObjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSessionObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader4,
            columnHeader5});
            this.tableLayoutPanel3.SetColumnSpan(this.lvSessionObjects, 3);
            this.lvSessionObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSessionObjects.FullRowSelect = true;
            this.lvSessionObjects.Location = new System.Drawing.Point(3, 32);
            this.lvSessionObjects.Name = "lvSessionObjects";
            this.lvSessionObjects.Size = new System.Drawing.Size(414, 456);
            this.lvSessionObjects.TabIndex = 35;
            this.lvSessionObjects.UseCompatibleStateImageBehavior = false;
            this.lvSessionObjects.View = System.Windows.Forms.View.Details;
            this.lvSessionObjects.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSessionObjects_MouseClick);
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Type";
            columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Data";
            columnHeader5.Width = 180;
            // 
            // frmSessionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 532);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmSessionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Session Management";
            this.Load += new System.EventHandler(this.frmSessionManager_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressUserSessions)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressSessionObjects)).EndInit();
            this.tblActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pBoxProgressUserSessions;
        private System.Windows.Forms.SplitContainer splitMain;
        private Library.BufferedListView lvUserSessions;
        private Library.BufferedListView lvSessionObjects;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSessionCounter;
        private System.Windows.Forms.Label lblSessionObjectsCounter;
        private System.Windows.Forms.PictureBox pBoxProgressSessionObjects;
        private System.Windows.Forms.TableLayoutPanel tblActions;
        private System.Windows.Forms.Button btnRemoveSession;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExportSession;
        private System.Windows.Forms.Button btnImportSession;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;

    }
}