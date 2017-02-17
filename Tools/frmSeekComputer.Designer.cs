using genEx;

namespace Seeker
{
    partial class frmSeekComputer
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
            this.tbControlMachineInfo = new System.Windows.Forms.TabControl();
            this.tbPMachineInfo = new System.Windows.Forms.TabPage();
            this.tblMachineInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLapsExpDate = new System.Windows.Forms.Label();
            this.lblLapsPasswordData = new System.Windows.Forms.Label();
            this.lblLapsPassNotice = new System.Windows.Forms.Label();
            this.lblLapsExpDateNotice = new System.Windows.Forms.Label();
            this.btnGetLapsPass = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMachineChangedDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMachineCreationDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMachineLastLogon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMachineProcessor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMachineMemory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMachineDisk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMachineDN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMachineOS = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.tblActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopyUserData = new System.Windows.Forms.Button();
            this.btnCollectObject = new System.Windows.Forms.Button();
            this.tbpMemberOf = new System.Windows.Forms.TabPage();
            this.tblMemberOf = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lViewResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpAdvanced = new System.Windows.Forms.TabPage();
            this.tbLayoutAdvanced = new System.Windows.Forms.TableLayoutPanel();
            this.dGridAdvanced = new System.Windows.Forms.DataGridView();
            this.pBoxProgressAdvanced = new System.Windows.Forms.PictureBox();
            this.tbMachineDetails = new System.Windows.Forms.TabControl();
            this.tbpProcess = new System.Windows.Forms.TabPage();
            this.dGridMachineProcess = new System.Windows.Forms.DataGridView();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tbControlMachineInfo.SuspendLayout();
            this.tbPMachineInfo.SuspendLayout();
            this.tblMachineInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblActions.SuspendLayout();
            this.tbpMemberOf.SuspendLayout();
            this.tblMemberOf.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tbpAdvanced.SuspendLayout();
            this.tbLayoutAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAdvanced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressAdvanced)).BeginInit();
            this.tbMachineDetails.SuspendLayout();
            this.tbpProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridMachineProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlMachineInfo
            // 
            this.tbControlMachineInfo.Controls.Add(this.tbPMachineInfo);
            this.tbControlMachineInfo.Controls.Add(this.tbpMemberOf);
            this.tbControlMachineInfo.Controls.Add(this.tbpAdvanced);
            this.tbControlMachineInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlMachineInfo.Location = new System.Drawing.Point(0, 0);
            this.tbControlMachineInfo.Name = "tbControlMachineInfo";
            this.tbControlMachineInfo.SelectedIndex = 0;
            this.tbControlMachineInfo.Size = new System.Drawing.Size(545, 459);
            this.tbControlMachineInfo.TabIndex = 0;
            // 
            // tbPMachineInfo
            // 
            this.tbPMachineInfo.Controls.Add(this.tblMachineInfo);
            this.tbPMachineInfo.Location = new System.Drawing.Point(4, 22);
            this.tbPMachineInfo.Name = "tbPMachineInfo";
            this.tbPMachineInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPMachineInfo.Size = new System.Drawing.Size(537, 433);
            this.tbPMachineInfo.TabIndex = 2;
            this.tbPMachineInfo.Text = "Machine";
            this.tbPMachineInfo.UseVisualStyleBackColor = true;
            // 
            // tblMachineInfo
            // 
            this.tblMachineInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMachineInfo.ColumnCount = 3;
            this.tblMachineInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tblMachineInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMachineInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tblMachineInfo.Controls.Add(this.label11, 0, 11);
            this.tblMachineInfo.Controls.Add(this.label10, 0, 10);
            this.tblMachineInfo.Controls.Add(this.tableLayoutPanel1, 1, 10);
            this.tblMachineInfo.Controls.Add(this.btnGetLapsPass, 2, 10);
            this.tblMachineInfo.Controls.Add(this.label9, 0, 9);
            this.tblMachineInfo.Controls.Add(this.lblMachineChangedDate, 1, 9);
            this.tblMachineInfo.Controls.Add(this.label8, 0, 8);
            this.tblMachineInfo.Controls.Add(this.lblMachineCreationDate, 1, 8);
            this.tblMachineInfo.Controls.Add(this.label7, 0, 7);
            this.tblMachineInfo.Controls.Add(this.lblMachineLastLogon, 1, 7);
            this.tblMachineInfo.Controls.Add(this.label6, 0, 6);
            this.tblMachineInfo.Controls.Add(this.lblMachineProcessor, 1, 6);
            this.tblMachineInfo.Controls.Add(this.label5, 0, 5);
            this.tblMachineInfo.Controls.Add(this.lblMachineMemory, 1, 5);
            this.tblMachineInfo.Controls.Add(this.label2, 0, 4);
            this.tblMachineInfo.Controls.Add(this.lblMachineDisk, 1, 4);
            this.tblMachineInfo.Controls.Add(this.label3, 0, 3);
            this.tblMachineInfo.Controls.Add(this.lblMachineDN, 1, 3);
            this.tblMachineInfo.Controls.Add(this.label1, 0, 2);
            this.tblMachineInfo.Controls.Add(this.lblMachineOS, 1, 2);
            this.tblMachineInfo.Controls.Add(this.label4, 0, 1);
            this.tblMachineInfo.Controls.Add(this.lblMachineName, 1, 1);
            this.tblMachineInfo.Controls.Add(this.tblActions, 0, 0);
            this.tblMachineInfo.Location = new System.Drawing.Point(3, 3);
            this.tblMachineInfo.Name = "tblMachineInfo";
            this.tblMachineInfo.RowCount = 13;
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tblMachineInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblMachineInfo.Size = new System.Drawing.Size(528, 424);
            this.tblMachineInfo.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "LAPS Exp Date:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "LAPS Password:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.50871F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.49129F));
            this.tableLayoutPanel1.Controls.Add(this.lblLapsExpDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLapsPasswordData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLapsPassNotice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLapsExpDateNotice, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(97, 239);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tblMachineInfo.SetRowSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.27273F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 45);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // lblLapsExpDate
            // 
            this.lblLapsExpDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLapsExpDate.AutoSize = true;
            this.lblLapsExpDate.Location = new System.Drawing.Point(4, 26);
            this.lblLapsExpDate.Name = "lblLapsExpDate";
            this.lblLapsExpDate.Size = new System.Drawing.Size(83, 13);
            this.lblLapsExpDate.TabIndex = 1;
            this.lblLapsExpDate.Text = "*******************";
            this.lblLapsExpDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // lblLapsPasswordData
            // 
            this.lblLapsPasswordData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLapsPasswordData.AutoSize = true;
            this.lblLapsPasswordData.Location = new System.Drawing.Point(4, 4);
            this.lblLapsPasswordData.Name = "lblLapsPasswordData";
            this.lblLapsPasswordData.Size = new System.Drawing.Size(83, 13);
            this.lblLapsPasswordData.TabIndex = 1;
            this.lblLapsPasswordData.Text = "*******************";
            this.lblLapsPasswordData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // lblLapsPassNotice
            // 
            this.lblLapsPassNotice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLapsPassNotice.AutoSize = true;
            this.lblLapsPassNotice.ForeColor = System.Drawing.Color.Red;
            this.lblLapsPassNotice.Location = new System.Drawing.Point(130, 4);
            this.lblLapsPassNotice.Name = "lblLapsPassNotice";
            this.lblLapsPassNotice.Size = new System.Drawing.Size(0, 13);
            this.lblLapsPassNotice.TabIndex = 1;
            this.lblLapsPassNotice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // lblLapsExpDateNotice
            // 
            this.lblLapsExpDateNotice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLapsExpDateNotice.AutoSize = true;
            this.lblLapsExpDateNotice.ForeColor = System.Drawing.Color.Red;
            this.lblLapsExpDateNotice.Location = new System.Drawing.Point(130, 26);
            this.lblLapsExpDateNotice.Name = "lblLapsExpDateNotice";
            this.lblLapsExpDateNotice.Size = new System.Drawing.Size(0, 13);
            this.lblLapsExpDateNotice.TabIndex = 1;
            this.lblLapsExpDateNotice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // btnGetLapsPass
            // 
            this.btnGetLapsPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetLapsPass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGetLapsPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLapsPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetLapsPass.Image = global::Seeker.Properties.Resources._0431;
            this.btnGetLapsPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetLapsPass.Location = new System.Drawing.Point(403, 251);
            this.btnGetLapsPass.Name = "btnGetLapsPass";
            this.tblMachineInfo.SetRowSpan(this.btnGetLapsPass, 2);
            this.btnGetLapsPass.Size = new System.Drawing.Size(121, 28);
            this.btnGetLapsPass.TabIndex = 26;
            this.btnGetLapsPass.Text = "Get LAPS";
            this.btnGetLapsPass.UseVisualStyleBackColor = false;
            this.btnGetLapsPass.Click += new System.EventHandler(this.btnGetLapsPass_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Changed Date:";
            // 
            // lblMachineChangedDate
            // 
            this.lblMachineChangedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachineChangedDate.AutoSize = true;
            this.lblMachineChangedDate.Location = new System.Drawing.Point(97, 215);
            this.lblMachineChangedDate.Name = "lblMachineChangedDate";
            this.lblMachineChangedDate.Size = new System.Drawing.Size(79, 13);
            this.lblMachineChangedDate.TabIndex = 1;
            this.lblMachineChangedDate.Text = "Changed Date:";
            this.lblMachineChangedDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Creation Date:";
            // 
            // lblMachineCreationDate
            // 
            this.lblMachineCreationDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachineCreationDate.AutoSize = true;
            this.lblMachineCreationDate.Location = new System.Drawing.Point(97, 189);
            this.lblMachineCreationDate.Name = "lblMachineCreationDate";
            this.lblMachineCreationDate.Size = new System.Drawing.Size(75, 13);
            this.lblMachineCreationDate.TabIndex = 1;
            this.lblMachineCreationDate.Text = "Creation Date:";
            this.lblMachineCreationDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Last Logon:";
            // 
            // lblMachineLastLogon
            // 
            this.lblMachineLastLogon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachineLastLogon.AutoSize = true;
            this.lblMachineLastLogon.Location = new System.Drawing.Point(97, 166);
            this.lblMachineLastLogon.Name = "lblMachineLastLogon";
            this.lblMachineLastLogon.Size = new System.Drawing.Size(63, 13);
            this.lblMachineLastLogon.TabIndex = 1;
            this.lblMachineLastLogon.Text = "Last Logon:";
            this.lblMachineLastLogon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Processor:";
            // 
            // lblMachineProcessor
            // 
            this.lblMachineProcessor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachineProcessor.AutoSize = true;
            this.lblMachineProcessor.Location = new System.Drawing.Point(97, 145);
            this.lblMachineProcessor.Name = "lblMachineProcessor";
            this.lblMachineProcessor.Size = new System.Drawing.Size(57, 13);
            this.lblMachineProcessor.TabIndex = 1;
            this.lblMachineProcessor.Text = "Processor:";
            this.lblMachineProcessor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Memory:";
            // 
            // lblMachineMemory
            // 
            this.lblMachineMemory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachineMemory.AutoSize = true;
            this.lblMachineMemory.Location = new System.Drawing.Point(97, 124);
            this.lblMachineMemory.Name = "lblMachineMemory";
            this.lblMachineMemory.Size = new System.Drawing.Size(47, 13);
            this.lblMachineMemory.TabIndex = 3;
            this.lblMachineMemory.Text = "Memory:";
            this.lblMachineMemory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disk:";
            // 
            // lblMachineDisk
            // 
            this.lblMachineDisk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachineDisk.AutoSize = true;
            this.lblMachineDisk.Location = new System.Drawing.Point(97, 103);
            this.lblMachineDisk.Name = "lblMachineDisk";
            this.lblMachineDisk.Size = new System.Drawing.Size(31, 13);
            this.lblMachineDisk.TabIndex = 1;
            this.lblMachineDisk.Text = "Disk:";
            this.lblMachineDisk.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DN:";
            // 
            // lblMachineDN
            // 
            this.lblMachineDN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachineDN.AutoSize = true;
            this.lblMachineDN.Location = new System.Drawing.Point(97, 82);
            this.lblMachineDN.Name = "lblMachineDN";
            this.lblMachineDN.Size = new System.Drawing.Size(26, 13);
            this.lblMachineDN.TabIndex = 0;
            this.lblMachineDN.Text = "DN:";
            this.lblMachineDN.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "O.S:";
            // 
            // lblMachineOS
            // 
            this.lblMachineOS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachineOS.AutoSize = true;
            this.lblMachineOS.Location = new System.Drawing.Point(97, 61);
            this.lblMachineOS.Name = "lblMachineOS";
            this.lblMachineOS.Size = new System.Drawing.Size(28, 13);
            this.lblMachineOS.TabIndex = 2;
            this.lblMachineOS.Text = "O.S:";
            this.lblMachineOS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // lblMachineName
            // 
            this.lblMachineName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(97, 40);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(38, 13);
            this.lblMachineName.TabIndex = 0;
            this.lblMachineName.Text = "Name:";
            this.lblMachineName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblMachineName_MouseDoubleClick);
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
            this.tblActions.Size = new System.Drawing.Size(92, 35);
            this.tblActions.TabIndex = 30;
            // 
            // btnCopyUserData
            // 
            this.btnCopyUserData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopyUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyUserData.Image = global::Seeker.Properties.Resources.copy24;
            this.btnCopyUserData.Location = new System.Drawing.Point(8, 3);
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
            this.btnCollectObject.Location = new System.Drawing.Point(54, 3);
            this.btnCollectObject.Name = "btnCollectObject";
            this.btnCollectObject.Size = new System.Drawing.Size(29, 29);
            this.btnCollectObject.TabIndex = 10;
            this.btnCollectObject.UseVisualStyleBackColor = true;
            this.btnCollectObject.Click += new System.EventHandler(this.btnCollectObject_Click);
            // 
            // tbpMemberOf
            // 
            this.tbpMemberOf.Controls.Add(this.tblMemberOf);
            this.tbpMemberOf.Location = new System.Drawing.Point(4, 22);
            this.tbpMemberOf.Name = "tbpMemberOf";
            this.tbpMemberOf.Size = new System.Drawing.Size(537, 432);
            this.tbpMemberOf.TabIndex = 3;
            this.tbpMemberOf.Text = "Member Of";
            this.tbpMemberOf.UseVisualStyleBackColor = true;
            this.tbpMemberOf.Enter += new System.EventHandler(this.tbpMemberOf_Enter);
            // 
            // tblMemberOf
            // 
            this.tblMemberOf.ColumnCount = 1;
            this.tblMemberOf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 537F));
            this.tblMemberOf.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tblMemberOf.Controls.Add(this.lViewResults, 0, 0);
            this.tblMemberOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMemberOf.Location = new System.Drawing.Point(0, 0);
            this.tblMemberOf.Name = "tblMemberOf";
            this.tblMemberOf.RowCount = 2;
            this.tblMemberOf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMemberOf.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMemberOf.Size = new System.Drawing.Size(537, 432);
            this.tblMemberOf.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.Controls.Add(this.btnApply, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRemove, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(307, 401);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(227, 28);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(155, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(69, 22);
            this.btnApply.TabIndex = 35;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(79, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(69, 22);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 22);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add...";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lViewResults
            // 
            this.lViewResults.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lViewResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.tblMemberOf.SetColumnSpan(this.lViewResults, 4);
            this.lViewResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lViewResults.FullRowSelect = true;
            this.lViewResults.HideSelection = false;
            this.lViewResults.Location = new System.Drawing.Point(3, 3);
            this.lViewResults.MultiSelect = false;
            this.lViewResults.Name = "lViewResults";
            this.lViewResults.Size = new System.Drawing.Size(531, 392);
            this.lViewResults.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lViewResults.TabIndex = 31;
            this.lViewResults.UseCompatibleStateImageBehavior = false;
            this.lViewResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Active Directory Domain Services Folder";
            this.columnHeader4.Width = 338;
            // 
            // tbpAdvanced
            // 
            this.tbpAdvanced.Controls.Add(this.tbLayoutAdvanced);
            this.tbpAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tbpAdvanced.Name = "tbpAdvanced";
            this.tbpAdvanced.Size = new System.Drawing.Size(537, 432);
            this.tbpAdvanced.TabIndex = 4;
            this.tbpAdvanced.Text = "Advanced";
            this.tbpAdvanced.UseVisualStyleBackColor = true;
            this.tbpAdvanced.Enter += new System.EventHandler(this.tbpAdvanced_Enter);
            // 
            // tbLayoutAdvanced
            // 
            this.tbLayoutAdvanced.ColumnCount = 1;
            this.tbLayoutAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutAdvanced.Controls.Add(this.dGridAdvanced, 0, 0);
            this.tbLayoutAdvanced.Controls.Add(this.pBoxProgressAdvanced, 0, 1);
            this.tbLayoutAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutAdvanced.Location = new System.Drawing.Point(0, 0);
            this.tbLayoutAdvanced.Name = "tbLayoutAdvanced";
            this.tbLayoutAdvanced.RowCount = 2;
            this.tbLayoutAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbLayoutAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLayoutAdvanced.Size = new System.Drawing.Size(537, 432);
            this.tbLayoutAdvanced.TabIndex = 0;
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
            this.dGridAdvanced.Size = new System.Drawing.Size(531, 397);
            this.dGridAdvanced.TabIndex = 11;
            // 
            // pBoxProgressAdvanced
            // 
            this.pBoxProgressAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxProgressAdvanced.Image = global::Seeker.Properties.Resources.pBarGreen;
            this.pBoxProgressAdvanced.Location = new System.Drawing.Point(459, 406);
            this.pBoxProgressAdvanced.Name = "pBoxProgressAdvanced";
            this.pBoxProgressAdvanced.Size = new System.Drawing.Size(75, 23);
            this.pBoxProgressAdvanced.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxProgressAdvanced.TabIndex = 42;
            this.pBoxProgressAdvanced.TabStop = false;
            this.pBoxProgressAdvanced.Visible = false;
            // 
            // tbMachineDetails
            // 
            this.tbMachineDetails.Controls.Add(this.tbpProcess);
            this.tbMachineDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbMachineDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMachineDetails.Location = new System.Drawing.Point(0, 0);
            this.tbMachineDetails.Name = "tbMachineDetails";
            this.tbMachineDetails.SelectedIndex = 0;
            this.tbMachineDetails.Size = new System.Drawing.Size(150, 46);
            this.tbMachineDetails.TabIndex = 1;
            this.tbMachineDetails.Click += new System.EventHandler(this.tbMachineDetails_Click);
            // 
            // tbpProcess
            // 
            this.tbpProcess.Controls.Add(this.dGridMachineProcess);
            this.tbpProcess.Location = new System.Drawing.Point(4, 22);
            this.tbpProcess.Name = "tbpProcess";
            this.tbpProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProcess.Size = new System.Drawing.Size(534, 218);
            this.tbpProcess.TabIndex = 1;
            this.tbpProcess.Text = "Process";
            this.tbpProcess.UseVisualStyleBackColor = true;
            // 
            // dGridMachineProcess
            // 
            this.dGridMachineProcess.AllowUserToAddRows = false;
            this.dGridMachineProcess.AllowUserToDeleteRows = false;
            this.dGridMachineProcess.AllowUserToOrderColumns = true;
            this.dGridMachineProcess.AllowUserToResizeRows = false;
            this.dGridMachineProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridMachineProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridMachineProcess.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGridMachineProcess.Location = new System.Drawing.Point(3, 3);
            this.dGridMachineProcess.MultiSelect = false;
            this.dGridMachineProcess.Name = "dGridMachineProcess";
            this.dGridMachineProcess.ReadOnly = true;
            this.dGridMachineProcess.RowHeadersVisible = false;
            this.dGridMachineProcess.Size = new System.Drawing.Size(528, 212);
            this.dGridMachineProcess.TabIndex = 12;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.tbControlMachineInfo);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tbMachineDetails);
            this.splitMain.Panel2Collapsed = true;
            this.splitMain.Size = new System.Drawing.Size(545, 459);
            this.splitMain.SplitterDistance = 25;
            this.splitMain.TabIndex = 2;
            // 
            // frmSeekComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(545, 459);
            this.Controls.Add(this.splitMain);
            this.Name = "frmSeekComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeekComputer";
            this.Load += new System.EventHandler(this.frmSeekComputer_Load);
            this.Move += new System.EventHandler(this.frmSeekComputer_Move);
            this.Resize += new System.EventHandler(this.frmSeekComputer_Resize);
            this.tbControlMachineInfo.ResumeLayout(false);
            this.tbPMachineInfo.ResumeLayout(false);
            this.tblMachineInfo.ResumeLayout(false);
            this.tblMachineInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblActions.ResumeLayout(false);
            this.tbpMemberOf.ResumeLayout(false);
            this.tblMemberOf.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tbpAdvanced.ResumeLayout(false);
            this.tbLayoutAdvanced.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridAdvanced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProgressAdvanced)).EndInit();
            this.tbMachineDetails.ResumeLayout(false);
            this.tbpProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridMachineProcess)).EndInit();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlMachineInfo;
        private System.Windows.Forms.TabPage tbPMachineInfo;
        private System.Windows.Forms.TableLayoutPanel tblMachineInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tbpMemberOf;
        private System.Windows.Forms.TableLayoutPanel tblMemberOf;
        private System.Windows.Forms.ListView lViewResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblMachineOS;
        private System.Windows.Forms.Label lblMachineDN;
        private System.Windows.Forms.Label lblMachineDisk;
        private System.Windows.Forms.Label lblMachineMemory;
        private System.Windows.Forms.Label lblMachineProcessor;
        private System.Windows.Forms.Label lblMachineLastLogon;
        private System.Windows.Forms.Label lblMachineCreationDate;
        private System.Windows.Forms.Label lblMachineChangedDate;
        //private System.Windows.Forms.ListView lvMachineProcess;        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tbMachineDetails;
        private System.Windows.Forms.TabPage tbpProcess;
        private System.Windows.Forms.DataGridView dGridMachineProcess;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLapsPasswordData;
        private System.Windows.Forms.Button btnGetLapsPass;
        private System.Windows.Forms.TabPage tbpAdvanced;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLapsExpDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLapsPassNotice;
        private System.Windows.Forms.Label lblLapsExpDateNotice;
        private System.Windows.Forms.TableLayoutPanel tbLayoutAdvanced;
        private System.Windows.Forms.PictureBox pBoxProgressAdvanced;
        private System.Windows.Forms.DataGridView dGridAdvanced;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TableLayoutPanel tblActions;
        private System.Windows.Forms.Button btnCopyUserData;
        private System.Windows.Forms.Button btnCollectObject;

    }
}