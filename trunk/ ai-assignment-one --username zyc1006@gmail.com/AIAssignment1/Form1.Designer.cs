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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clSpunkees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPlinks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWorkbenches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSpunks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnPlonks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSePlonks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clBligees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBligs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(310, 134);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spunkees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bligees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
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
            this.groupBox1.Location = new System.Drawing.Point(31, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees";
            // 
            // txTotalPl
            // 
            this.txTotalPl.Location = new System.Drawing.Point(99, 84);
            this.txTotalPl.Name = "txTotalPl";
            this.txTotalPl.Size = new System.Drawing.Size(33, 21);
            this.txTotalPl.TabIndex = 6;
            this.txTotalPl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txTotalBlige
            // 
            this.txTotalBlige.Location = new System.Drawing.Point(99, 56);
            this.txTotalBlige.Name = "txTotalBlige";
            this.txTotalBlige.Size = new System.Drawing.Size(33, 21);
            this.txTotalBlige.TabIndex = 5;
            this.txTotalBlige.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txTotalSp
            // 
            this.txTotalSp.Location = new System.Drawing.Point(99, 29);
            this.txTotalSp.Name = "txTotalSp";
            this.txTotalSp.Size = new System.Drawing.Size(33, 21);
            this.txTotalSp.TabIndex = 4;
            this.txTotalSp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txTotalWb);
            this.groupBox2.Controls.Add(this.txTotalBlig);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(229, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 99);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // txTotalWb
            // 
            this.txTotalWb.Location = new System.Drawing.Point(100, 56);
            this.txTotalWb.Name = "txTotalWb";
            this.txTotalWb.Size = new System.Drawing.Size(33, 21);
            this.txTotalWb.TabIndex = 7;
            this.txTotalWb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txTotalBlig
            // 
            this.txTotalBlig.Location = new System.Drawing.Point(100, 29);
            this.txTotalBlig.Name = "txTotalBlig";
            this.txTotalBlig.Size = new System.Drawing.Size(33, 21);
            this.txTotalBlig.TabIndex = 6;
            this.txTotalBlig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bligs:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Workbenches:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSpunkees,
            this.clPlinks,
            this.clWorkbenches,
            this.clSpunks,
            this.clUnPlonks,
            this.clSePlonks});
            this.dataGridView1.Location = new System.Drawing.Point(31, 177);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 36;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(554, 219);
            this.dataGridView1.TabIndex = 6;
            // 
            // clSpunkees
            // 
            this.clSpunkees.HeaderText = "Spunkees";
            this.clSpunkees.Name = "clSpunkees";
            this.clSpunkees.ReadOnly = true;
            this.clSpunkees.Width = 78;
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
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(88, 411);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "SEARCH";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBligees,
            this.clBligs});
            this.dataGridView2.Location = new System.Drawing.Point(654, 134);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowHeadersWidth = 36;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(179, 262);
            this.dataGridView2.TabIndex = 9;
            // 
            // clBligees
            // 
            this.clBligees.HeaderText = "Bligees";
            this.clBligees.Name = "clBligees";
            this.clBligees.ReadOnly = true;
            this.clBligees.Width = 72;
            // 
            // clBligs
            // 
            this.clBligs.HeaderText = "Bligs";
            this.clBligs.Name = "clBligs";
            this.clBligs.ReadOnly = true;
            this.clBligs.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 457);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "AI Assignment One";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBligees;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBligs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpunkees;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPlinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWorkbenches;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSpunks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnPlonks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSePlonks;
    }
}

