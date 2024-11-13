namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loanAmount = new System.Windows.Forms.TextBox();
            this.loanTenure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.monthlyEMI = new System.Windows.Forms.TextBox();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.totalInterest = new System.Windows.Forms.TextBox();
            this.principalAmount = new System.Windows.Forms.TextBox();
            this.rOI = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.numValidation1 = new System.Windows.Forms.Label();
            this.numValidation2 = new System.Windows.Forms.Label();
            this.numValidation3 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.rOI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan EMI Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Principal Loan Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rate of Interest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loan Tenure";
            // 
            // loanAmount
            // 
            this.loanAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmount.Location = new System.Drawing.Point(220, 84);
            this.loanAmount.Name = "loanAmount";
            this.loanAmount.Size = new System.Drawing.Size(399, 29);
            this.loanAmount.TabIndex = 4;
            this.loanAmount.TextChanged += new System.EventHandler(this.loanAmount_TextChanged);
            // 
            // loanTenure
            // 
            this.loanTenure.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanTenure.Location = new System.Drawing.Point(220, 194);
            this.loanTenure.Name = "loanTenure";
            this.loanTenure.Size = new System.Drawing.Size(90, 29);
            this.loanTenure.TabIndex = 6;
            this.loanTenure.TextChanged += new System.EventHandler(this.loanTenure_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Monthly EMI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Interest:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Principal Amount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(342, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total Amount:";
            // 
            // monthlyEMI
            // 
            this.monthlyEMI.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyEMI.Location = new System.Drawing.Point(479, 302);
            this.monthlyEMI.Name = "monthlyEMI";
            this.monthlyEMI.ReadOnly = true;
            this.monthlyEMI.Size = new System.Drawing.Size(138, 29);
            this.monthlyEMI.TabIndex = 12;
            this.monthlyEMI.Text = "0";
            // 
            // totalAmount
            // 
            this.totalAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.Location = new System.Drawing.Point(479, 449);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            this.totalAmount.Size = new System.Drawing.Size(138, 29);
            this.totalAmount.TabIndex = 13;
            this.totalAmount.Text = "0";
            // 
            // totalInterest
            // 
            this.totalInterest.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInterest.Location = new System.Drawing.Point(479, 400);
            this.totalInterest.Name = "totalInterest";
            this.totalInterest.ReadOnly = true;
            this.totalInterest.Size = new System.Drawing.Size(138, 29);
            this.totalInterest.TabIndex = 14;
            this.totalInterest.Text = "0";
            // 
            // principalAmount
            // 
            this.principalAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalAmount.Location = new System.Drawing.Point(479, 348);
            this.principalAmount.Name = "principalAmount";
            this.principalAmount.ReadOnly = true;
            this.principalAmount.Size = new System.Drawing.Size(138, 29);
            this.principalAmount.TabIndex = 15;
            this.principalAmount.Text = "0";
            // 
            // rOI
            // 
            this.rOI.DecimalPlaces = 1;
            this.rOI.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rOI.Location = new System.Drawing.Point(220, 139);
            this.rOI.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.rOI.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rOI.Name = "rOI";
            this.rOI.Size = new System.Drawing.Size(90, 32);
            this.rOI.TabIndex = 16;
            this.rOI.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rOI.ValueChanged += new System.EventHandler(this.rOI_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(316, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Years";
            // 
            // pieChart1
            // 
            this.pieChart1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChart1.Location = new System.Drawing.Point(12, 302);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(284, 176);
            this.pieChart1.TabIndex = 19;
            this.pieChart1.Text = "pieChart1";
            // 
            // numValidation1
            // 
            this.numValidation1.AutoSize = true;
            this.numValidation1.ForeColor = System.Drawing.Color.Red;
            this.numValidation1.Location = new System.Drawing.Point(217, 116);
            this.numValidation1.Name = "numValidation1";
            this.numValidation1.Size = new System.Drawing.Size(0, 13);
            this.numValidation1.TabIndex = 20;
            // 
            // numValidation2
            // 
            this.numValidation2.AutoSize = true;
            this.numValidation2.ForeColor = System.Drawing.Color.Red;
            this.numValidation2.Location = new System.Drawing.Point(217, 174);
            this.numValidation2.Name = "numValidation2";
            this.numValidation2.Size = new System.Drawing.Size(0, 13);
            this.numValidation2.TabIndex = 21;
            // 
            // numValidation3
            // 
            this.numValidation3.AutoSize = true;
            this.numValidation3.ForeColor = System.Drawing.Color.Red;
            this.numValidation3.Location = new System.Drawing.Point(217, 226);
            this.numValidation3.Name = "numValidation3";
            this.numValidation3.Size = new System.Drawing.Size(0, 13);
            this.numValidation3.TabIndex = 22;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar1.LargeChange = 1000;
            this.hScrollBar1.Location = new System.Drawing.Point(220, 116);
            this.hScrollBar1.Maximum = 100000000;
            this.hScrollBar1.Minimum = 100000;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(399, 17);
            this.hScrollBar1.SmallChange = 100;
            this.hScrollBar1.TabIndex = 23;
            this.hScrollBar1.Value = 100000;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar2.Location = new System.Drawing.Point(220, 174);
            this.hScrollBar2.Maximum = 30;
            this.hScrollBar2.Minimum = 1;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(399, 17);
            this.hScrollBar2.TabIndex = 0;
            this.hScrollBar2.Value = 1;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar4
            // 
            this.hScrollBar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar4.Location = new System.Drawing.Point(220, 226);
            this.hScrollBar4.Maximum = 30;
            this.hScrollBar4.Minimum = 1;
            this.hScrollBar4.Name = "hScrollBar4";
            this.hScrollBar4.Size = new System.Drawing.Size(399, 17);
            this.hScrollBar4.TabIndex = 26;
            this.hScrollBar4.Value = 1;
            this.hScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar4_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 524);
            this.Controls.Add(this.hScrollBar4);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.numValidation3);
            this.Controls.Add(this.numValidation2);
            this.Controls.Add(this.numValidation1);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rOI);
            this.Controls.Add(this.principalAmount);
            this.Controls.Add(this.totalInterest);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.monthlyEMI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loanTenure);
            this.Controls.Add(this.loanAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.rOI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loanAmount;
        private System.Windows.Forms.TextBox loanTenure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox monthlyEMI;
        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.TextBox totalInterest;
        private System.Windows.Forms.TextBox principalAmount;
        private System.Windows.Forms.NumericUpDown rOI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label numValidation1;
        private System.Windows.Forms.Label numValidation2;
        private System.Windows.Forms.Label numValidation3;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar4;
    }
}

