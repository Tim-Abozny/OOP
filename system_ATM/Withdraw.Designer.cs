
namespace system_ATM
{
    partial class Withdraw
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
            this.label7 = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.atmLabel = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.my_Button();
            this.WithrdawTB = new System.Windows.Forms.TextBox();
            this.backLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.availBalanceLabel = new System.Windows.Forms.Label();
            this.BalanceNumLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.atmLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 89);
            this.panel1.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Font = new System.Drawing.Font("Russo One", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(163, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Withdraw";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.exitLabel.Location = new System.Drawing.Point(343, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(27, 26);
            this.exitLabel.TabIndex = 8;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // atmLabel
            // 
            this.atmLabel.AutoSize = true;
            this.atmLabel.Font = new System.Drawing.Font("Sigmar One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atmLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.atmLabel.Location = new System.Drawing.Point(40, 22);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(296, 48);
            this.atmLabel.TabIndex = 0;
            this.atmLabel.Text = "A T M  S Y S T E M";
            // 
            // withdrawButton
            // 
            this.withdrawButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdrawButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.withdrawButton.ForeColor = System.Drawing.Color.White;
            this.withdrawButton.Location = new System.Drawing.Point(166, 199);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Rounding = 50;
            this.withdrawButton.RoundingEnable = true;
            this.withdrawButton.Size = new System.Drawing.Size(192, 30);
            this.withdrawButton.TabIndex = 66;
            this.withdrawButton.Text = "WITHDRAW";
            this.withdrawButton.UseVisualStyleBackColor = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // WithrdawTB
            // 
            this.WithrdawTB.Font = new System.Drawing.Font("Russo One", 16F);
            this.WithrdawTB.Location = new System.Drawing.Point(166, 150);
            this.WithrdawTB.Name = "WithrdawTB";
            this.WithrdawTB.Size = new System.Drawing.Size(192, 33);
            this.WithrdawTB.TabIndex = 65;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.backLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.backLabel.Location = new System.Drawing.Point(162, 257);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(52, 19);
            this.backLabel.TabIndex = 64;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 11);
            this.panel2.TabIndex = 63;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.amountLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.amountLabel.Location = new System.Drawing.Point(25, 157);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(84, 19);
            this.amountLabel.TabIndex = 62;
            this.amountLabel.Text = "AMOUNT:";
            // 
            // availBalanceLabel
            // 
            this.availBalanceLabel.AutoSize = true;
            this.availBalanceLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.availBalanceLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.availBalanceLabel.Location = new System.Drawing.Point(25, 107);
            this.availBalanceLabel.Name = "availBalanceLabel";
            this.availBalanceLabel.Size = new System.Drawing.Size(183, 19);
            this.availBalanceLabel.TabIndex = 67;
            this.availBalanceLabel.Text = "AVAILABLE BALANCE:";
            // 
            // BalanceNumLabel
            // 
            this.BalanceNumLabel.AutoSize = true;
            this.BalanceNumLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.BalanceNumLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BalanceNumLabel.Location = new System.Drawing.Point(214, 107);
            this.BalanceNumLabel.Name = "BalanceNumLabel";
            this.BalanceNumLabel.Size = new System.Drawing.Size(111, 19);
            this.BalanceNumLabel.TabIndex = 68;
            this.BalanceNumLabel.Text = "BalanceNum";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 290);
            this.Controls.Add(this.BalanceNumLabel);
            this.Controls.Add(this.availBalanceLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.WithrdawTB);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.amountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label atmLabel;
        private System.Windows.Forms.my_Button withdrawButton;
        private System.Windows.Forms.TextBox WithrdawTB;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label availBalanceLabel;
        private System.Windows.Forms.Label BalanceNumLabel;
    }
}