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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExcessResources = new System.Windows.Forms.GroupBox();
            this.gbExcessListArea = new System.Windows.Forms.GroupBox();
            this.tbAverageExcessBox = new System.Windows.Forms.TextBox();
            this.gbActionListArea = new System.Windows.Forms.GroupBox();
            this.gbBligStatusArea = new System.Windows.Forms.GroupBox();
            this.gbInputsArea = new System.Windows.Forms.GroupBox();
            this.tbMessageBox = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfo.RowHeadersVisible = false;
            this.dgvInfo.RowHeadersWidth = 36;
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInfo.Size = new System.Drawing.Size(542, 196);
            this.dgvInfo.TabIndex = 6;
            this.dgvInfo.SelectionChanged += new System.EventHandler(this.dgvInfo_SelectionChanged);
            // 
            // clTime
            // 
            this.clTime.HeaderText = "Time";
            this.clTime.Name = "clTime";
            this.clTime.ReadOnly = true;
            this.clTime.Width = 54;
            // 
            // clSpunkees
            // 
            this.clSpunkees.HeaderText = "Spunkees";
            this.clSpunkees.Name = "clSpunkees";
            this.clSpunkees.ReadOnly = true;
            this.clSpunkees.Width = 78;
            // 
            // BligeesColumn
            // 
            this.BligeesColumn.HeaderText = "Bligees";
            this.BligeesColumn.Name = "BligeesColumn";
            this.BligeesColumn.ReadOnly = true;
            this.BligeesColumn.Width = 72;
            // 
            // clPlinks
            // 
            this.clPlinks.HeaderText = "Plinks";
            this.clPlinks.Name = "clPlinks";
            this.clPlinks.ReadOnly = true;
            this.clPlinks.Width = 66;
            // 
            // clWorkbenches
            // 
            this.clWorkbenches.HeaderText = "Workbenches";
            this.clWorkbenches.Name = "clWorkbenches";
            this.clWorkbenches.ReadOnly = true;
            this.clWorkbenches.Width = 96;
            // 
            // BligsColumn
            // 
            this.BligsColumn.HeaderText = "Bligs";
            this.BligsColumn.Name = "BligsColumn";
            this.BligsColumn.ReadOnly = true;
            this.BligsColumn.Width = 60;
            // 
            // clSpunks
            // 
            this.clSpunks.HeaderText = "Spunks";
            this.clSpunks.Name = "clSpunks";
            this.clSpunks.ReadOnly = true;
            this.clSpunks.Width = 66;
            // 
            // clUnPlonks
            // 
            this.clUnPlonks.HeaderText = "Unserviced Plonks";
            this.clUnPlonks.Name = "clUnPlonks";
            this.clUnPlonks.ReadOnly = true;
            this.clUnPlonks.Width = 121;
            // 
            // clSePlonks
            // 
            this.clSePlonks.HeaderText = "Serviced Plonks";
            this.clSePlonks.Name = "clSePlonks";
            this.clSePlonks.ReadOnly = true;
            this.clSePlonks.Width = 78;
            // 
            // dgvBlInfo
            // 
            this.dgvBlInfo.AllowUserToAddRows = false;
            this.dgvBlInfo.AllowUserToDeleteRows = false;
            this.dgvBlInfo.AllowUserToResizeColumns = false;
            this.dgvBlInfo.AllowUserToResizeRows = false;
            this.dgvBlInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvBlInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBlInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clHour,
            this.clBligs,
            this.clBligeesNormal,
            this.clBligeesFast});
            this.dgvBlInfo.Location = new System.Drawing.Point(6, 19);
            this.dgvBlInfo.MultiSelect = false;
            this.dgvBlInfo.Name = "dgvBlInfo";
            this.dgvBlInfo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBlInfo.RowHeadersVisible = false;
            this.dgvBlInfo.RowHeadersWidth = 22;
            this.dgvBlInfo.RowTemplate.Height = 23;
            this.dgvBlInfo.Size = new System.Drawing.Size(253, 232);
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
            this.groupBox3.Size = new System.Drawing.Size(330, 88);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claTime,
            this.clMS,
            this.clSBN,
            this.clSBF,
            this.clFP,
            this.clSP});
            this.dgvAction.Location = new System.Drawing.Point(10, 19);
            this.dgvAction.MultiSelect = false;
            this.dgvAction.Name = "dgvAction";
            this.dgvAction.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAction.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAction.RowHeadersVisible = false;
            this.dgvAction.RowHeadersWidth = 36;
            this.dgvAction.RowTemplate.Height = 23;
            this.dgvAction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAction.Size = new System.Drawing.Size(184, 198);
            this.dgvAction.TabIndex = 13;
            this.dgvAction.SelectionChanged += new System.EventHandler(this.dgvAction_SelectionChanged);
            // 
            // claTime
            // 
            this.claTime.HeaderText = "Time";
            this.claTime.Name = "claTime";
            this.claTime.ReadOnly = true;
            this.claTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.claTime.Width = 35;
            // 
            // clMS
            // 
            this.clMS.HeaderText = "MS";
            this.clMS.Name = "clMS";
            this.clMS.ReadOnly = true;
            this.clMS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clMS.Width = 23;
            // 
            // clSBN
            // 
            this.clSBN.HeaderText = "SBN";
            this.clSBN.Name = "clSBN";
            this.clSBN.ReadOnly = true;
            this.clSBN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clSBN.Width = 29;
            // 
            // clSBF
            // 
            this.clSBF.HeaderText = "SBF";
            this.clSBF.Name = "clSBF";
            this.clSBF.ReadOnly = true;
            this.clSBF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clSBF.Width = 29;
            // 
            // clFP
            // 
            this.clFP.HeaderText = "FP";
            this.clFP.Name = "clFP";
            this.clFP.ReadOnly = true;
            this.clFP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clFP.Width = 23;
            // 
            // clSP
            // 
            this.clSP.HeaderText = "SP";
            this.clSP.Name = "clSP";
            this.clSP.ReadOnly = true;
            this.clSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clSP.Width = 23;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(7, 238);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 25);
            this.btSearch.TabIndex = 14;
            this.btSearch.Text = "SEARCH";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
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
            // gbExcessListArea
            // 
            this.gbExcessListArea.Controls.Add(this.dgvInfo);
            this.gbExcessListArea.Location = new System.Drawing.Point(7, 269);
            this.gbExcessListArea.Name = "gbExcessListArea";
            this.gbExcessListArea.Size = new System.Drawing.Size(557, 227);
            this.gbExcessListArea.TabIndex = 17;
            this.gbExcessListArea.TabStop = false;
            this.gbExcessListArea.Text = "Resources left at hour\'s end";
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
            // gbActionListArea
            // 
            this.gbActionListArea.Controls.Add(this.dgvAction);
            this.gbActionListArea.Location = new System.Drawing.Point(570, 269);
            this.gbActionListArea.Name = "gbActionListArea";
            this.gbActionListArea.Size = new System.Drawing.Size(204, 227);
            this.gbActionListArea.TabIndex = 18;
            this.gbActionListArea.TabStop = false;
            this.gbActionListArea.Text = "Actions (by hour)";
            // 
            // gbBligStatusArea
            // 
            this.gbBligStatusArea.Controls.Add(this.dgvBlInfo);
            this.gbBligStatusArea.Location = new System.Drawing.Point(512, 12);
            this.gbBligStatusArea.Name = "gbBligStatusArea";
            this.gbBligStatusArea.Size = new System.Drawing.Size(262, 257);
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
            // tbMessageBox
            // 
            this.tbMessageBox.Location = new System.Drawing.Point(6, 19);
            this.tbMessageBox.Multiline = true;
            this.tbMessageBox.Name = "tbMessageBox";
            this.tbMessageBox.ReadOnly = true;
            this.tbMessageBox.Size = new System.Drawing.Size(318, 63);
            this.tbMessageBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 502);
            this.Controls.Add(this.gbInputsArea);
            this.Controls.Add(this.gbBligStatusArea);
            this.Controls.Add(this.gbActionListArea);
            this.Controls.Add(this.gbExcessListArea);
            this.Controls.Add(this.ExcessResources);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btSearch);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn claTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpunkees;
        private System.Windows.Forms.DataGridViewTextBoxColumn BligeesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPlinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkbenches;
        private System.Windows.Forms.DataGridViewTextBoxColumn BligsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpunks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnPlonks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSePlonks;
        private System.Windows.Forms.GroupBox ExcessResources;
        private System.Windows.Forms.GroupBox gbExcessListArea;
        private System.Windows.Forms.TextBox tbAverageExcessBox;
        private System.Windows.Forms.GroupBox gbActionListArea;
        private System.Windows.Forms.GroupBox gbBligStatusArea;
        private System.Windows.Forms.GroupBox gbInputsArea;
        private System.Windows.Forms.TextBox tbMessageBox;
    }
}

