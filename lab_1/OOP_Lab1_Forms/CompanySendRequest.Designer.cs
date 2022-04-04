
namespace OOP_Lab1_Forms
{
    partial class CompanySendRequest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SalaryTB = new System.Windows.Forms.TextBox();
            this.CreditTB = new System.Windows.Forms.TextBox();
            this.InstallmentTB = new System.Windows.Forms.TextBox();
            this.periodListBox = new System.Windows.Forms.ComboBox();
            this.sumLabel = new System.Windows.Forms.Label();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.sendCrInReq = new System.Windows.Forms.my_Button();
            this.sendSalaryReq = new System.Windows.Forms.my_Button();
            this.noneInstallment = new System.Windows.Forms.my_Button();
            this.noneCredit = new System.Windows.Forms.my_Button();
            this.noneSalary = new System.Windows.Forms.my_Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 110);
            this.panel1.TabIndex = 92;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLabel.Location = new System.Drawing.Point(767, 0);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(33, 33);
            this.exitLabel.TabIndex = 8;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sigmar One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(210, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "B A N K  S Y S T E M";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 455);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 14);
            this.panel2.TabIndex = 88;
            // 
            // SalaryTB
            // 
            this.SalaryTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.SalaryTB.Font = new System.Drawing.Font("Russo One", 16F);
            this.SalaryTB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SalaryTB.Location = new System.Drawing.Point(291, 166);
            this.SalaryTB.Margin = new System.Windows.Forms.Padding(4);
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.Size = new System.Drawing.Size(255, 40);
            this.SalaryTB.TabIndex = 96;
            // 
            // CreditTB
            // 
            this.CreditTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.CreditTB.Font = new System.Drawing.Font("Russo One", 16F);
            this.CreditTB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CreditTB.Location = new System.Drawing.Point(291, 227);
            this.CreditTB.Margin = new System.Windows.Forms.Padding(4);
            this.CreditTB.Name = "CreditTB";
            this.CreditTB.Size = new System.Drawing.Size(255, 40);
            this.CreditTB.TabIndex = 97;
            this.CreditTB.TextChanged += new System.EventHandler(this.CreditTB_TextChanged);
            // 
            // InstallmentTB
            // 
            this.InstallmentTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.InstallmentTB.Font = new System.Drawing.Font("Russo One", 16F);
            this.InstallmentTB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.InstallmentTB.Location = new System.Drawing.Point(291, 286);
            this.InstallmentTB.Margin = new System.Windows.Forms.Padding(4);
            this.InstallmentTB.Name = "InstallmentTB";
            this.InstallmentTB.Size = new System.Drawing.Size(255, 40);
            this.InstallmentTB.TabIndex = 98;
            this.InstallmentTB.TextChanged += new System.EventHandler(this.InstallmentTB_TextChanged);
            // 
            // periodListBox
            // 
            this.periodListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.periodListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodListBox.Font = new System.Drawing.Font("Russo One", 16F);
            this.periodListBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.periodListBox.FormattingEnabled = true;
            this.periodListBox.Items.AddRange(new object[] {
            "3",
            "6",
            "9",
            "12"});
            this.periodListBox.Location = new System.Drawing.Point(594, 226);
            this.periodListBox.Margin = new System.Windows.Forms.Padding(4);
            this.periodListBox.Name = "periodListBox";
            this.periodListBox.Size = new System.Drawing.Size(158, 41);
            this.periodListBox.TabIndex = 102;
            this.periodListBox.SelectedIndexChanged += new System.EventHandler(this.periodListBox_SelectedIndexChanged);
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Russo One", 16F);
            this.sumLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sumLabel.Location = new System.Drawing.Point(386, 129);
            this.sumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(77, 33);
            this.sumLabel.TabIndex = 103;
            this.sumLabel.Text = "SUM";
            // 
            // ResultTB
            // 
            this.ResultTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ResultTB.Font = new System.Drawing.Font("Russo One", 16F);
            this.ResultTB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ResultTB.Location = new System.Drawing.Point(291, 359);
            this.ResultTB.Margin = new System.Windows.Forms.Padding(4);
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.ReadOnly = true;
            this.ResultTB.Size = new System.Drawing.Size(255, 40);
            this.ResultTB.TabIndex = 105;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.resultLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.resultLabel.Location = new System.Drawing.Point(47, 368);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(222, 25);
            this.resultLabel.TabIndex = 104;
            this.resultLabel.Text = "SUM TO RETURN (%):";
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.backLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.backLabel.Location = new System.Drawing.Point(387, 424);
            this.backLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(66, 25);
            this.backLabel.TabIndex = 89;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // sendCrInReq
            // 
            this.sendCrInReq.BackColor = System.Drawing.Color.MidnightBlue;
            this.sendCrInReq.Font = new System.Drawing.Font("Russo One", 12F);
            this.sendCrInReq.ForeColor = System.Drawing.Color.White;
            this.sendCrInReq.Location = new System.Drawing.Point(594, 289);
            this.sendCrInReq.Margin = new System.Windows.Forms.Padding(4);
            this.sendCrInReq.Name = "sendCrInReq";
            this.sendCrInReq.Rounding = 50;
            this.sendCrInReq.RoundingEnable = true;
            this.sendCrInReq.Size = new System.Drawing.Size(158, 37);
            this.sendCrInReq.TabIndex = 101;
            this.sendCrInReq.Text = "SEND CR/IN";
            this.sendCrInReq.UseVisualStyleBackColor = false;
            // 
            // sendSalaryReq
            // 
            this.sendSalaryReq.BackColor = System.Drawing.Color.MidnightBlue;
            this.sendSalaryReq.Font = new System.Drawing.Font("Russo One", 12F);
            this.sendSalaryReq.ForeColor = System.Drawing.Color.White;
            this.sendSalaryReq.Location = new System.Drawing.Point(594, 169);
            this.sendSalaryReq.Margin = new System.Windows.Forms.Padding(4);
            this.sendSalaryReq.Name = "sendSalaryReq";
            this.sendSalaryReq.Rounding = 50;
            this.sendSalaryReq.RoundingEnable = true;
            this.sendSalaryReq.Size = new System.Drawing.Size(158, 37);
            this.sendSalaryReq.TabIndex = 99;
            this.sendSalaryReq.Text = "SEND SALARY";
            this.sendSalaryReq.UseVisualStyleBackColor = false;
            // 
            // noneInstallment
            // 
            this.noneInstallment.BackColor = System.Drawing.Color.MidnightBlue;
            this.noneInstallment.Font = new System.Drawing.Font("Russo One", 12F);
            this.noneInstallment.ForeColor = System.Drawing.Color.White;
            this.noneInstallment.Location = new System.Drawing.Point(13, 289);
            this.noneInstallment.Margin = new System.Windows.Forms.Padding(4);
            this.noneInstallment.Name = "noneInstallment";
            this.noneInstallment.Rounding = 50;
            this.noneInstallment.RoundingEnable = true;
            this.noneInstallment.Size = new System.Drawing.Size(256, 37);
            this.noneInstallment.TabIndex = 95;
            this.noneInstallment.Text = "INSTALLMENT";
            this.noneInstallment.UseVisualStyleBackColor = false;
            // 
            // noneCredit
            // 
            this.noneCredit.BackColor = System.Drawing.Color.MidnightBlue;
            this.noneCredit.Font = new System.Drawing.Font("Russo One", 12F);
            this.noneCredit.ForeColor = System.Drawing.Color.White;
            this.noneCredit.Location = new System.Drawing.Point(13, 230);
            this.noneCredit.Margin = new System.Windows.Forms.Padding(4);
            this.noneCredit.Name = "noneCredit";
            this.noneCredit.Rounding = 50;
            this.noneCredit.RoundingEnable = true;
            this.noneCredit.Size = new System.Drawing.Size(256, 37);
            this.noneCredit.TabIndex = 94;
            this.noneCredit.Text = "CREDIT";
            this.noneCredit.UseVisualStyleBackColor = false;
            // 
            // noneSalary
            // 
            this.noneSalary.BackColor = System.Drawing.Color.MidnightBlue;
            this.noneSalary.Font = new System.Drawing.Font("Russo One", 12F);
            this.noneSalary.ForeColor = System.Drawing.Color.White;
            this.noneSalary.Location = new System.Drawing.Point(13, 169);
            this.noneSalary.Margin = new System.Windows.Forms.Padding(4);
            this.noneSalary.Name = "noneSalary";
            this.noneSalary.Rounding = 50;
            this.noneSalary.RoundingEnable = true;
            this.noneSalary.Size = new System.Drawing.Size(256, 37);
            this.noneSalary.TabIndex = 93;
            this.noneSalary.Text = "SALARY";
            this.noneSalary.UseVisualStyleBackColor = false;
            // 
            // CompanySendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.periodListBox);
            this.Controls.Add(this.sendCrInReq);
            this.Controls.Add(this.sendSalaryReq);
            this.Controls.Add(this.InstallmentTB);
            this.Controls.Add(this.CreditTB);
            this.Controls.Add(this.SalaryTB);
            this.Controls.Add(this.noneInstallment);
            this.Controls.Add(this.noneCredit);
            this.Controls.Add(this.noneSalary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompanySendRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanySendRequest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.my_Button noneSalary;
        private System.Windows.Forms.my_Button noneCredit;
        private System.Windows.Forms.my_Button noneInstallment;
        private System.Windows.Forms.TextBox SalaryTB;
        private System.Windows.Forms.TextBox CreditTB;
        private System.Windows.Forms.TextBox InstallmentTB;
        private System.Windows.Forms.my_Button sendSalaryReq;
        private System.Windows.Forms.my_Button sendCrInReq;
        private System.Windows.Forms.ComboBox periodListBox;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label backLabel;
    }
}