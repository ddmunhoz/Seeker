namespace Seeker
{
    partial class frmSearchDialog
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tbpSearch = new System.Windows.Forms.TabPage();
            this.rtBoxSearchQuery = new System.Windows.Forms.RichTextBox();
            this.tbpResults = new System.Windows.Forms.TabPage();
            this.lvResults = new System.Windows.Forms.ListView();
            this.objName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblSearchOptions = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pBoxProgress = new System.Windows.Forms.PictureBox();
            this.tblMain.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tbpSearch.SuspendLayout();
            this.tbpResults.SuspendLayout();
            this.tblSearchOptions.SuspendLayout();
            this.tblActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tblMain.Controls.Add(this.btnSearch, 1, 1);
            this.tblMain.Controls.Add(this.tbMain, 0, 1);
            this.tblMain.Controls.Add(this.tblSearchOptions, 0, 0);
            this.tblMain.Controls.Add(this.tblActions, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tblMain.Size = new System.Drawing.Size(626, 335);
            this.tblMain.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(536, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Check Names";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tbpSearch);
            this.tbMain.Controls.Add(this.tbpResults);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.Location = new System.Drawing.Point(3, 25);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(527, 273);
            this.tbMain.TabIndex = 1;
            // 
            // tbpSearch
            // 
            this.tbpSearch.Controls.Add(this.rtBoxSearchQuery);
            this.tbpSearch.Location = new System.Drawing.Point(4, 22);
            this.tbpSearch.Name = "tbpSearch";
            this.tbpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSearch.Size = new System.Drawing.Size(519, 247);
            this.tbpSearch.TabIndex = 0;
            this.tbpSearch.Text = "Search";
            this.tbpSearch.UseVisualStyleBackColor = true;
            // 
            // rtBoxSearchQuery
            // 
            this.rtBoxSearchQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBoxSearchQuery.Location = new System.Drawing.Point(3, 3);
            this.rtBoxSearchQuery.Name = "rtBoxSearchQuery";
            this.rtBoxSearchQuery.Size = new System.Drawing.Size(513, 241);
            this.rtBoxSearchQuery.TabIndex = 0;
            this.rtBoxSearchQuery.Text = "";
            // 
            // tbpResults
            // 
            this.tbpResults.Controls.Add(this.lvResults);
            this.tbpResults.Location = new System.Drawing.Point(4, 22);
            this.tbpResults.Name = "tbpResults";
            this.tbpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResults.Size = new System.Drawing.Size(519, 247);
            this.tbpResults.TabIndex = 1;
            this.tbpResults.Text = "Results";
            this.tbpResults.UseVisualStyleBackColor = true;
            // 
            // lvResults
            // 
            this.lvResults.CheckBoxes = true;
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.objName,
            this.objAccount,
            this.objFolder});
            this.lvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResults.FullRowSelect = true;
            this.lvResults.Location = new System.Drawing.Point(3, 3);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(513, 241);
            this.lvResults.TabIndex = 5;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // objName
            // 
            this.objName.Text = "Name(UPN)";
            this.objName.Width = 205;
            // 
            // objAccount
            // 
            this.objAccount.Text = "SamAccount";
            this.objAccount.Width = 107;
            // 
            // objFolder
            // 
            this.objFolder.Text = "In Folder";
            this.objFolder.Width = 149;
            // 
            // tblSearchOptions
            // 
            this.tblSearchOptions.ColumnCount = 3;
            this.tblSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tblSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tblSearchOptions.Controls.Add(this.label1, 0, 0);
            this.tblSearchOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearchOptions.Location = new System.Drawing.Point(3, 3);
            this.tblSearchOptions.Name = "tblSearchOptions";
            this.tblSearchOptions.RowCount = 1;
            this.tblSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearchOptions.Size = new System.Drawing.Size(527, 16);
            this.tblSearchOptions.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the object names to select(semicolon separeted):";
            // 
            // tblActions
            // 
            this.tblActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblActions.ColumnCount = 4;
            this.tblMain.SetColumnSpan(this.tblActions, 2);
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tblActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblActions.Controls.Add(this.btnCancel, 3, 0);
            this.tblActions.Controls.Add(this.btnOK, 2, 0);
            this.tblActions.Controls.Add(this.pBoxProgress, 1, 0);
            this.tblActions.Location = new System.Drawing.Point(139, 304);
            this.tblActions.Name = "tblActions";
            this.tblActions.RowCount = 1;
            this.tblActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblActions.Size = new System.Drawing.Size(484, 28);
            this.tblActions.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(397, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 22);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Enabled = false;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(305, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 22);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pBoxProgress
            // 
            this.pBoxProgress.Image = global::Seeker.Properties.Resources.pBarGreen;
            this.pBoxProgress.Location = new System.Drawing.Point(224, 3);
            this.pBoxProgress.Name = "pBoxProgress";
            this.pBoxProgress.Size = new System.Drawing.Size(75, 22);
            this.pBoxProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxProgress.TabIndex = 38;
            this.pBoxProgress.TabStop = false;
            this.pBoxProgress.Visible = false;
            // 
            // frmSearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 335);
            this.Controls.Add(this.tblMain);
            this.Name = "frmSearchDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Usersm Computers, or Groups";
            this.tblMain.ResumeLayout(false);
            this.tbMain.ResumeLayout(false);
            this.tbpSearch.ResumeLayout(false);
            this.tbpResults.ResumeLayout(false);
            this.tblSearchOptions.ResumeLayout(false);
            this.tblSearchOptions.PerformLayout();
            this.tblActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tbpSearch;
        private System.Windows.Forms.RichTextBox rtBoxSearchQuery;
        private System.Windows.Forms.TabPage tbpResults;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader objName;
        private System.Windows.Forms.ColumnHeader objAccount;
        private System.Windows.Forms.ColumnHeader objFolder;
        private System.Windows.Forms.TableLayoutPanel tblSearchOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblActions;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pBoxProgress;
    }
}