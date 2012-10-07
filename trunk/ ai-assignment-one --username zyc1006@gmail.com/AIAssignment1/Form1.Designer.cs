namespace AIAssignment1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txTotalPl = new System.Windows.Forms.TextBox();
            this.txTotalBlige = new System.Windows.Forms.TextBox();
            this.txTotalSp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txTotalWb = new System.Windows.Forms.TextBox();
            this.txTotalBlig = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.clTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSpunkees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BligeesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPlinks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkbenches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BligsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSpunks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnPlonks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSePlonks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBlInfo = new System.Windows.Forms.DataGridView();
            this.clHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBligs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBligeesNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBligeesFast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMessage = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMessageBox = new System.Windows.Forms.TextBox();
            this.btStep = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.dgvAction = new System.Windows.Forms.DataGridView();
            this.claTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSBF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSearch = new System.Windows.Forms.Button();
            this.ExcessResources = new System.Windows.Forms.GroupBox();
            this.tbAverageExcessBox = new System.Windows.Forms.TextBox();
            this.gbExcessListArea = new System.Windows.Forms.GroupBox();
            this.gbActionListArea = new System.Windows.Forms.GroupBox();
            this.gbBligStatusArea = new System.Windows.Forms.GroupBox();
            this.gbInputsArea = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbBruteForceLim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlInfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAction)).BeginInit();
            this.ExcessResources.SuspendLayout();
            this.gbExcessListArea.SuspendLayout();
            this.gbActionListArea.SuspendLayout();
            this.gbBligStatusArea.SuspendLayout();
            this.gbInputsArea.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(176, 25);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(70, 25);
            this.btStart.TabIndex = 8;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spunkees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bligees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plinks:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txTotalPl);
            this.groupBox1.Controls.Add(this.txTotalBlige);
            this.groupBox1.Controls.Add(this.txTotalSp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees";
            // 
            // txTotalPl
            // 
            this.txTotalPl.Location = new System.Drawing.Point(102, 73);
            this.txTotalPl.Name = "txTotalPl";
            this.txTotalPl.Size = new System.Drawing.Size(33, 20);
            this.txTotalPl.TabIndex = 6;
            this.txTotalPl.Text = "10";
            this.txTotalPl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txTotalBlige
            // 
            this.txTotalBlige.Location = new System.Drawing.Point(102, 44);
            this.txTotalBlige.Name = "txTotalBlige";
            this.txTotalBlige.Size = new System.Drawing.Size(33, 20);
            this.txTotalBlige.TabIndex = 5;
            this.txTotalBlige.Text = "10";
            this.txTotalBlige.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txTotalSp
            // 
            this.txTotalSp.Location = new System.Drawing.Point(102, 15);
            this.txTotalSp.Name = "txTotalSp";
            this.txTotalSp.Size = new System.Drawing.Size(33, 20);
            this.txTotalSp.TabIndex = 4;
            this.txTotalSp.Text = "10";
            this.txTotalSp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txTotalWb);
            this.groupBox2.Controls.Add(this.txTotalBlig);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // txTotalWb
            // 
            this.txTotalWb.Location = new System.Drawing.Point(102, 15);
            this.txTotalWb.Name = "txTotalWb";
            this.txTotalWb.Size = new System.Drawing.Size(33, 20);
            this.txTotalWb.TabIndex = 7;
            this.txTotalWb.Text = "10";
            this.txTotalWb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txTotalBlig
            // 
            this.txTotalBlig.Location = new System.Drawing.Point(102, 43);
            this.txTotalBlig.Name = "txTotalBlig";
            this.txTotalBlig.Size = new System.Drawing.Size(33, 20);
            this.txTotalBlig.TabIndex = 6;
            this.txTotalBlig.Text = "10";
            this.txTotalBlig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bligs:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Workbenches:";
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.AllowUserToResizeColumns = false;
            this.dgvInfo.AllowUserToResizeRows = false;
            this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTime,
            this.clSpunkees,
            this.BligeesColumn,
            this.clPlinks,
            this.clWorkbenches,
            this.BligsColumn,
            this.clSpunks,
            this.clUnPlonks,
            this.clSePlonks});
            this.dgvInfo.Location = new System.Drawing.Point(8, 21);
            this.dgvInfo.MultiSelect = false;
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvInfo.RowHeadersVisible = false;
            this.dgvInfo.RowHeadersWidth = 36;
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInfo.Size = new System.Drawing.Size(428, 203);
            this.dgvInfo.TabIndex = 6;
            this.dgvInfo.SelectionChanged += new System.EventHandler(this.dgvInfo_SelectionChanged);
            // 
            // clTime
            // 
            this.clTime.HeaderText = "h";
            this.clTime.MinimumWidth = 45;
            this.clTime.Name = "clTime";
            this.clTime.ReadOnly = true;
            this.clTime.ToolTipText = "Time";
            this.clTime.Width = 45;
            // 
            // clSpunkees
            // 
            this.clSpunkees.HeaderText = "ESp";
            this.clSpunkees.MinimumWidth = 45;
            this.clSpunkees.Name = "clSpunkees";
            this.clSpunkees.ReadOnly = true;
            this.clSpunkees.ToolTipText = "Spunkees";
            this.clSpunkees.Width = 48;
            // 
            // BligeesColumn
            // 
            this.BligeesColumn.HeaderText = "EB";
            this.BligeesColumn.MinimumWidth = 45;
            this.BligeesColumn.Name = "BligeesColumn";
            this.BligeesColumn.ReadOnly = true;
            this.BligeesColumn.ToolTipText = "Bligees";
            this.BligeesColumn.Width = 45;
            // 
            // clPlinks
            // 
            this.clPlinks.HeaderText = "EP";
            this.clPlinks.MinimumWidth = 45;
            this.clPlinks.Name = "clPlinks";
            this.clPlinks.ReadOnly = true;
            this.clPlinks.ToolTipText = "Plinks";
            this.clPlinks.Width = 45;
            // 
            // clWorkbenches
            // 
            this.clWorkbenches.HeaderText = "TW";
            this.clWorkbenches.MinimumWidth = 45;
            this.clWorkbenches.Name = "clWorkbenches";
            this.clWorkbenches.ReadOnly = true;
            this.clWorkbenches.ToolTipText = "Workbenches";
            this.clWorkbenches.Width = 45;
            // 
            // BligsColumn
            // 
            this.BligsColumn.HeaderText = "TB";
            this.BligsColumn.MinimumWidth = 45;
            this.BligsColumn.Name = "BligsColumn";
            this.BligsColumn.ReadOnly = true;
            this.BligsColumn.ToolTipText = "Bligs";
            this.BligsColumn.Width = 45;
            // 
            // clSpunks
            // 
            this.clSpunks.HeaderText = "RS";
            this.clSpunks.MinimumWidth = 45;
            this.clSpunks.Name = "clSpunks";
            this.clSpunks.ReadOnly = true;
            this.clSpunks.ToolTipText = "Spunks";
            this.clSpunks.Width = 45;
            // 
            // clUnPlonks
            // 
            this.clUnPlonks.HeaderText = "RUP";
            this.clUnPlonks.MinimumWidth = 45;
            this.clUnPlonks.Name = "clUnPlonks";
            this.clUnPlonks.ReadOnly = true;
            this.clUnPlonks.ToolTipText = "Unserviced Plonks";
            this.clUnPlonks.Width = 48;
            // 
            // clSePlonks
            // 
            this.clSePlonks.HeaderText = "RSP";
            this.clSePlonks.MinimumWidth = 45;
            this.clSePlonks.Name = "clSePlonks";
            this.clSePlonks.ReadOnly = true;
            this.clSePlonks.ToolTipText = "Serviced Plonks";
            this.clSePlonks.Width = 48;
            // 
            // dgvBlInfo
            // 
            this.dgvBlInfo.AllowUserToAddRows = false;
            this.dgvBlInfo.AllowUserToDeleteRows = false;
            this.dgvBlInfo.AllowUserToResizeColumns = false;
            this.dgvBlInfo.AllowUserToResizeRows = false;
            this.dgvBlInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvBlInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvBlInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clHour,
            this.clBligs,
            this.clBligeesNormal,
            this.clBligeesFast});
            this.dgvBlInfo.Location = new System.Drawing.Point(7, 21);
            this.dgvBlInfo.MultiSelect = false;
            this.dgvBlInfo.Name = "dgvBlInfo";
            this.dgvBlInfo.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvBlInfo.RowHeadersVisible = false;
            this.dgvBlInfo.RowHeadersWidth = 22;
            this.dgvBlInfo.RowTemplate.Height = 23;
            this.dgvBlInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBlInfo.Size = new System.Drawing.Size(253, 251);
            this.dgvBlInfo.TabIndex = 9;
            // 
            // clHour
            // 
            this.clHour.HeaderText = "Hours";
            this.clHour.Name = "clHour";
            this.clHour.ReadOnly = true;
            this.clHour.Width = 60;
            // 
            // clBligs
            // 
            this.clBligs.HeaderText = "Bligs";
            this.clBligs.Name = "clBligs";
            this.clBligs.ReadOnly = true;
            this.clBligs.Width = 60;
            // 
            // clBligeesNormal
            // 
            this.clBligeesNormal.HeaderText = "BligeesNormal";
            this.clBligeesNormal.Name = "clBligeesNormal";
            this.clBligeesNormal.ReadOnly = true;
            this.clBligeesNormal.Width = 108;
            // 
            // clBligeesFast
            // 
            this.clBligeesFast.HeaderText = "BligeesFast";
            this.clBligeesFast.Name = "clBligeesFast";
            this.clBligeesFast.ReadOnly = true;
            this.clBligeesFast.Width = 96;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(18, 31);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 13);
            this.lbMessage.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMessageBox);
            this.groupBox3.Controls.Add(this.lbMessage);
            this.groupBox3.Location = new System.Drawing.Point(176, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 171);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
            // 
            // tbMessageBox
            // 
            this.tbMessageBox.Location = new System.Drawing.Point(6, 21);
            this.tbMessageBox.Multiline = true;
            this.tbMessageBox.Name = "tbMessageBox";
            this.tbMessageBox.ReadOnly = true;
            this.tbMessageBox.Size = new System.Drawing.Size(318, 142);
            this.tbMessageBox.TabIndex = 21;
            // 
            // btStep
            // 
            this.btStep.Enabled = false;
            this.btStep.Location = new System.Drawing.Point(176, 56);
            this.btStep.Name = "btStep";
            this.btStep.Size = new System.Drawing.Size(70, 25);
            this.btStep.TabIndex = 9;
            this.btStep.Text = "STEP";
            this.btStep.UseVisualStyleBackColor = true;
            this.btStep.Click += new System.EventHandler(this.btStep_Click);
            // 
            // btRun
            // 
            this.btRun.Enabled = false;
            this.btRun.Location = new System.Drawing.Point(176, 87);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(70, 25);
            this.btRun.TabIndex = 12;
            this.btRun.Text = "RUN";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // dgvAction
            // 
            this.dgvAction.AllowUserToAddRows = false;
            this.dgvAction.AllowUserToDeleteRows = false;
            this.dgvAction.AllowUserToResizeColumns = false;
            this.dgvAction.AllowUserToResizeRows = false;
            this.dgvAction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvAction.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claTime,
            this.clMS,
            this.clSBN,
            this.clSBF,
            this.clFP,
            this.clSP});
            this.dgvAction.Location = new System.Drawing.Point(10, 20);
            this.dgvAction.MultiSelect = false;
            this.dgvAction.Name = "dgvAction";
            this.dgvAction.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAction.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvAction.RowHeadersVisible = false;
            this.dgvAction.RowHeadersWidth = 36;
            this.dgvAction.RowTemplate.Height = 23;
            this.dgvAction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAction.Size = new System.Drawing.Size(292, 203);
            this.dgvAction.TabIndex = 13;
            this.dgvAction.SelectionChanged += new System.EventHandler(this.dgvAction_SelectionChanged);
            // 
            // claTime
            // 
            this.claTime.HeaderText = "h";
            this.claTime.MinimumWidth = 45;
            this.claTime.Name = "claTime";
            this.claTime.ReadOnly = true;
            this.claTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.claTime.ToolTipText = "Time";
            this.claTime.Width = 45;
            // 
            // clMS
            // 
            this.clMS.HeaderText = "MS";
            this.clMS.MinimumWidth = 45;
            this.clMS.Name = "clMS";
            this.clMS.ReadOnly = true;
            this.clMS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clMS.ToolTipText = "Make Spunks";
            this.clMS.Width = 45;
            // 
            // clSBN
            // 
            this.clSBN.HeaderText = "SBN";
            this.clSBN.MinimumWidth = 45;
            this.clSBN.Name = "clSBN";
            this.clSBN.ReadOnly = true;
            this.clSBN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clSBN.ToolTipText = "Service Bligs (Normal)";
            this.clSBN.Width = 45;
            // 
            // clSBF
            // 
            this.clSBF.HeaderText = "SBF";
            this.clSBF.MinimumWidth = 45;
            this.clSBF.Name = "clSBF";
            this.clSBF.ReadOnly = true;
            this.clSBF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clSBF.ToolTipText = "Service Bligs (Fast)";
            this.clSBF.Width = 45;
            // 
            // clFP
            // 
            this.clFP.HeaderText = "FP";
            this.clFP.MinimumWidth = 45;
            this.clFP.Name = "clFP";
            this.clFP.ReadOnly = true;
            this.clFP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clFP.ToolTipText = "Find Plonks";
            this.clFP.Width = 45;
            // 
            // clSP
            // 
            this.clSP.HeaderText = "SP";
            this.clSP.MinimumWidth = 45;
            this.clSP.Name = "clSP";
            this.clSP.ReadOnly = true;
            this.clSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clSP.ToolTipText = "Service Plonks";
            this.clSP.Width = 45;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(6, 27);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 25);
            this.btSearch.TabIndex = 14;
            this.btSearch.Text = "FIRE!";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // ExcessResources
            // 
            this.ExcessResources.Controls.Add(this.tbAverageExcessBox);
            this.ExcessResources.Location = new System.Drawing.Point(252, 12);
            this.ExcessResources.Name = "ExcessResources";
            this.ExcessResources.Size = new System.Drawing.Size(254, 108);
            this.ExcessResources.TabIndex = 16;
            this.ExcessResources.TabStop = false;
            this.ExcessResources.Text = "Average excess";
            // 
            // tbAverageExcessBox
            // 
            this.tbAverageExcessBox.Location = new System.Drawing.Point(6, 16);
            this.tbAverageExcessBox.Multiline = true;
            this.tbAverageExcessBox.Name = "tbAverageExcessBox";
            this.tbAverageExcessBox.ReadOnly = true;
            this.tbAverageExcessBox.Size = new System.Drawing.Size(242, 85);
            this.tbAverageExcessBox.TabIndex = 0;
            // 
            // gbExcessListArea
            // 
            this.gbExcessListArea.Controls.Add(this.dgvInfo);
            this.gbExcessListArea.Location = new System.Drawing.Point(7, 302);
            this.gbExcessListArea.Name = "gbExcessListArea";
            this.gbExcessListArea.Size = new System.Drawing.Size(446, 236);
            this.gbExcessListArea.TabIndex = 17;
            this.gbExcessListArea.TabStop = false;
            this.gbExcessListArea.Text = "Resources left at hour\'s end";
            // 
            // gbActionListArea
            // 
            this.gbActionListArea.Controls.Add(this.dgvAction);
            this.gbActionListArea.Location = new System.Drawing.Point(467, 302);
            this.gbActionListArea.Name = "gbActionListArea";
            this.gbActionListArea.Size = new System.Drawing.Size(312, 236);
            this.gbActionListArea.TabIndex = 18;
            this.gbActionListArea.TabStop = false;
            this.gbActionListArea.Text = "Plan (actions by hour)";
            // 
            // gbBligStatusArea
            // 
            this.gbBligStatusArea.Controls.Add(this.dgvBlInfo);
            this.gbBligStatusArea.Location = new System.Drawing.Point(512, 11);
            this.gbBligStatusArea.Name = "gbBligStatusArea";
            this.gbBligStatusArea.Size = new System.Drawing.Size(267, 283);
            this.gbBligStatusArea.TabIndex = 19;
            this.gbBligStatusArea.TabStop = false;
            this.gbBligStatusArea.Text = "Blig status";
            // 
            // gbInputsArea
            // 
            this.gbInputsArea.Controls.Add(this.groupBox1);
            this.gbInputsArea.Controls.Add(this.groupBox2);
            this.gbInputsArea.Location = new System.Drawing.Point(7, 12);
            this.gbInputsArea.Name = "gbInputsArea";
            this.gbInputsArea.Size = new System.Drawing.Size(163, 202);
            this.gbInputsArea.TabIndex = 20;
            this.gbInputsArea.TabStop = false;
            this.gbInputsArea.Text = "Input resources";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbBruteForceLim);
            this.groupBox4.Controls.Add(this.btSearch);
            this.groupBox4.Location = new System.Drawing.Point(7, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 59);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Brute force";
            // 
            // tbBruteForceLim
            // 
            this.tbBruteForceLim.Location = new System.Drawing.Point(88, 30);
            this.tbBruteForceLim.Name = "tbBruteForceLim";
            this.tbBruteForceLim.Size = new System.Drawing.Size(69, 20);
            this.tbBruteForceLim.TabIndex = 15;
            this.tbBruteForceLim.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Resources:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 546);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbActionListArea);
            this.Controls.Add(this.gbExcessListArea);
            this.Controls.Add(this.gbBligStatusArea);
            this.Controls.Add(this.gbInputsArea);
            this.Controls.Add(this.ExcessResources);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.btStep);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "AI Assignment One";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlInfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAction)).EndInit();
            this.ExcessResources.ResumeLayout(false);
            this.ExcessResources.PerformLayout();
            this.gbExcessListArea.ResumeLayout(false);
            this.gbActionListArea.ResumeLayout(false);
            this.gbBligStatusArea.ResumeLayout(false);
            this.gbInputsArea.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txTotalPl;
        private System.Windows.Forms.TextBox txTotalBlige;
        private System.Windows.Forms.TextBox txTotalSp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txTotalWb;
        private System.Windows.Forms.TextBox txTotalBlig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.DataGridView dgvBlInfo;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBligs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBligeesNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBligeesFast;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.DataGridView dgvAction;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.GroupBox ExcessResources;
        private System.Windows.Forms.GroupBox gbExcessListArea;
        private System.Windows.Forms.TextBox tbAverageExcessBox;
        private System.Windows.Forms.GroupBox gbActionListArea;
        private System.Windows.Forms.GroupBox gbBligStatusArea;
        private System.Windows.Forms.GroupBox gbInputsArea;
        private System.Windows.Forms.TextBox tbMessageBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpunkees;
        private System.Windows.Forms.DataGridViewTextBoxColumn BligeesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPlinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkbenches;
        private System.Windows.Forms.DataGridViewTextBoxColumn BligsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpunks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnPlonks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSePlonks;
        private System.Windows.Forms.DataGridViewTextBoxColumn claTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBruteForceLim;
    }
}

