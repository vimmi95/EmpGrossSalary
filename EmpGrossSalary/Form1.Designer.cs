namespace EmpGrossSalary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtname = new TextBox();
            txtsal = new TextBox();
            groupBox1 = new GroupBox();
            btnsubmit = new Button();
            txtnsal = new TextBox();
            txtallowance = new TextBox();
            txtgsal = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtepf = new TextBox();
            txtetf = new TextBox();
            label5 = new Label();
            label4 = new Label();
            chkepf = new CheckBox();
            chkeft = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 26);
            label1.Name = "label1";
            label1.Size = new Size(376, 31);
            label1.TabIndex = 0;
            label1.Text = "Employee Gross Salary Calculator ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 83);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 120);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Salary";
            label3.Click += label3_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(249, 80);
            txtname.Name = "txtname";
            txtname.Size = new Size(196, 27);
            txtname.TabIndex = 3;
            // 
            // txtsal
            // 
            txtsal.Location = new Point(249, 120);
            txtsal.Name = "txtsal";
            txtsal.Size = new Size(196, 27);
            txtsal.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnsubmit);
            groupBox1.Controls.Add(txtnsal);
            groupBox1.Controls.Add(txtallowance);
            groupBox1.Controls.Add(txtgsal);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtepf);
            groupBox1.Controls.Add(txtetf);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(chkepf);
            groupBox1.Controls.Add(chkeft);
            groupBox1.Location = new Point(69, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 244);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate :";
            // 
            // btnsubmit
            // 
            btnsubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsubmit.Location = new Point(355, 194);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(180, 51);
            btnsubmit.TabIndex = 12;
            btnsubmit.Text = "CALCULATE";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // txtnsal
            // 
            txtnsal.Location = new Point(415, 129);
            txtnsal.Name = "txtnsal";
            txtnsal.Size = new Size(159, 27);
            txtnsal.TabIndex = 11;
            // 
            // txtallowance
            // 
            txtallowance.Location = new Point(115, 169);
            txtallowance.Name = "txtallowance";
            txtallowance.Size = new Size(159, 27);
            txtallowance.TabIndex = 10;
            // 
            // txtgsal
            // 
            txtgsal.Location = new Point(115, 126);
            txtgsal.Name = "txtgsal";
            txtgsal.Size = new Size(159, 27);
            txtgsal.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(306, 133);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 8;
            label8.Text = "Net Salary : ";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 172);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 7;
            label7.Text = "Allowance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 129);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 6;
            label6.Text = "Gross Salary";
            label6.Click += label6_Click;
            // 
            // txtepf
            // 
            txtepf.Location = new Point(264, 74);
            txtepf.Name = "txtepf";
            txtepf.Size = new Size(159, 27);
            txtepf.TabIndex = 5;
            // 
            // txtetf
            // 
            txtetf.Location = new Point(264, 40);
            txtetf.Name = "txtetf";
            txtetf.Size = new Size(159, 27);
            txtetf.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(134, 74);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 3;
            label5.Text = "EPF Amount :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 44);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 2;
            label4.Text = "ETF Amount:";
            // 
            // chkepf
            // 
            chkepf.AutoSize = true;
            chkepf.Location = new Point(36, 70);
            chkepf.Name = "chkepf";
            chkepf.Size = new Size(54, 24);
            chkepf.TabIndex = 1;
            chkepf.Text = "EPF";
            chkepf.UseVisualStyleBackColor = true;
            // 
            // chkeft
            // 
            chkeft.AutoSize = true;
            chkeft.Location = new Point(36, 40);
            chkeft.Name = "chkeft";
            chkeft.Size = new Size(54, 24);
            chkeft.TabIndex = 0;
            chkeft.Text = "ETF";
            chkeft.UseVisualStyleBackColor = true;
            chkeft.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(txtsal);
            Controls.Add(txtname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gross Salary Calculator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtname;
        private TextBox txtsal;
        private GroupBox groupBox1;
        private CheckBox chkepf;
        private CheckBox chkeft;
        private Label label5;
        private Label label4;
        private TextBox txtepf;
        private TextBox txtetf;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtnsal;
        private TextBox txtallowance;
        private TextBox txtgsal;
        private Button btnsubmit;
    }
}
