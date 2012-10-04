namespace WindowsFormsApplication1
{
    partial class AdjustmentCaculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.MessageArea = new System.Windows.Forms.GroupBox();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.tbESpExcess = new System.Windows.Forms.TextBox();
            this.tbEBExcess = new System.Windows.Forms.TextBox();
            this.tbEPExcess = new System.Windows.Forms.TextBox();
            this.tbTWExcess = new System.Windows.Forms.TextBox();
            this.tbTBExcess = new System.Windows.Forms.TextBox();
            this.tbESpAdjustment = new System.Windows.Forms.TextBox();
            this.tbEBAdjustment = new System.Windows.Forms.TextBox();
            this.tbEPAdjustment = new System.Windows.Forms.TextBox();
            this.tbTWAdjustment = new System.Windows.Forms.TextBox();
            this.tbTBAdjustment = new System.Windows.Forms.TextBox();
            this.MessageArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Average Excess";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adjustment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "<- ESp ->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "<- EB ->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "<- TW ->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "<- EP ->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "<- TB ->";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(90, 216);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MessageArea
            // 
            this.MessageArea.Controls.Add(this.MessageBox);
            this.MessageArea.Location = new System.Drawing.Point(17, 7);
            this.MessageArea.Name = "MessageArea";
            this.MessageArea.Size = new System.Drawing.Size(225, 52);
            this.MessageArea.TabIndex = 18;
            this.MessageArea.TabStop = false;
            this.MessageArea.Text = "Messages";
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(6, 16);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessageBox.Size = new System.Drawing.Size(213, 30);
            this.MessageBox.TabIndex = 0;
            // 
            // tbESpExcess
            // 
            this.tbESpExcess.Location = new System.Drawing.Point(23, 78);
            this.tbESpExcess.Name = "tbESpExcess";
            this.tbESpExcess.Size = new System.Drawing.Size(80, 20);
            this.tbESpExcess.TabIndex = 19;
            // 
            // tbEBExcess
            // 
            this.tbEBExcess.Location = new System.Drawing.Point(23, 104);
            this.tbEBExcess.Name = "tbEBExcess";
            this.tbEBExcess.Size = new System.Drawing.Size(80, 20);
            this.tbEBExcess.TabIndex = 20;
            // 
            // tbEPExcess
            // 
            this.tbEPExcess.Location = new System.Drawing.Point(23, 130);
            this.tbEPExcess.Name = "tbEPExcess";
            this.tbEPExcess.Size = new System.Drawing.Size(80, 20);
            this.tbEPExcess.TabIndex = 21;
            // 
            // tbTWExcess
            // 
            this.tbTWExcess.Location = new System.Drawing.Point(23, 156);
            this.tbTWExcess.Name = "tbTWExcess";
            this.tbTWExcess.Size = new System.Drawing.Size(80, 20);
            this.tbTWExcess.TabIndex = 22;
            // 
            // tbTBExcess
            // 
            this.tbTBExcess.Location = new System.Drawing.Point(23, 182);
            this.tbTBExcess.Name = "tbTBExcess";
            this.tbTBExcess.Size = new System.Drawing.Size(80, 20);
            this.tbTBExcess.TabIndex = 23;
            // 
            // tbESpAdjustment
            // 
            this.tbESpAdjustment.Location = new System.Drawing.Point(156, 78);
            this.tbESpAdjustment.Name = "tbESpAdjustment";
            this.tbESpAdjustment.Size = new System.Drawing.Size(80, 20);
            this.tbESpAdjustment.TabIndex = 24;
            // 
            // tbEBAdjustment
            // 
            this.tbEBAdjustment.Location = new System.Drawing.Point(156, 104);
            this.tbEBAdjustment.Name = "tbEBAdjustment";
            this.tbEBAdjustment.Size = new System.Drawing.Size(80, 20);
            this.tbEBAdjustment.TabIndex = 25;
            // 
            // tbEPAdjustment
            // 
            this.tbEPAdjustment.Location = new System.Drawing.Point(156, 130);
            this.tbEPAdjustment.Name = "tbEPAdjustment";
            this.tbEPAdjustment.Size = new System.Drawing.Size(80, 20);
            this.tbEPAdjustment.TabIndex = 26;
            // 
            // tbTWAdjustment
            // 
            this.tbTWAdjustment.Location = new System.Drawing.Point(156, 156);
            this.tbTWAdjustment.Name = "tbTWAdjustment";
            this.tbTWAdjustment.Size = new System.Drawing.Size(80, 20);
            this.tbTWAdjustment.TabIndex = 27;
            // 
            // tbTBAdjustment
            // 
            this.tbTBAdjustment.Location = new System.Drawing.Point(156, 182);
            this.tbTBAdjustment.Name = "tbTBAdjustment";
            this.tbTBAdjustment.Size = new System.Drawing.Size(80, 20);
            this.tbTBAdjustment.TabIndex = 28;
            // 
            // AdjustmentCaculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 258);
            this.Controls.Add(this.tbTBAdjustment);
            this.Controls.Add(this.tbTWAdjustment);
            this.Controls.Add(this.tbEPAdjustment);
            this.Controls.Add(this.tbEBAdjustment);
            this.Controls.Add(this.tbESpAdjustment);
            this.Controls.Add(this.tbTBExcess);
            this.Controls.Add(this.tbTWExcess);
            this.Controls.Add(this.tbEPExcess);
            this.Controls.Add(this.tbEBExcess);
            this.Controls.Add(this.tbESpExcess);
            this.Controls.Add(this.MessageArea);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdjustmentCaculator";
            this.Text = "Adjustment Calculator";
            this.MessageArea.ResumeLayout(false);
            this.MessageArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox MessageArea;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.TextBox tbESpExcess;
        private System.Windows.Forms.TextBox tbEBExcess;
        private System.Windows.Forms.TextBox tbEPExcess;
        private System.Windows.Forms.TextBox tbTWExcess;
        private System.Windows.Forms.TextBox tbTBExcess;
        private System.Windows.Forms.TextBox tbESpAdjustment;
        private System.Windows.Forms.TextBox tbEBAdjustment;
        private System.Windows.Forms.TextBox tbEPAdjustment;
        private System.Windows.Forms.TextBox tbTWAdjustment;
        private System.Windows.Forms.TextBox tbTBAdjustment;
    }
}

