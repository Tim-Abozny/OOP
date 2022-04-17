
namespace OOP_Lab1_Forms
{
    partial class WithdrawClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawClient));
            this.BalanceNumLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.WithrdawTB = new System.Windows.Forms.TextBox();
            this.backLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.atmLabel = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.my_Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BalanceNumLabel
            // 
            this.BalanceNumLabel.AutoSize = true;
            this.BalanceNumLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.BalanceNumLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BalanceNumLabel.Location = new System.Drawing.Point(214, 107);
            this.BalanceNumLabel.Name = "BalanceNumLabel";
            this.BalanceNumLabel.Size = new System.Drawing.Size(111, 19);
            this.BalanceNumLabel.TabIndex = 76;
            this.BalanceNumLabel.Text = "BalanceNum";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.balanceLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.balanceLabel.Location = new System.Drawing.Point(25, 107);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(183, 19);
            this.balanceLabel.TabIndex = 75;
            this.balanceLabel.Text = "AVAILABLE BALANCE:";
            // 
            // WithrdawTB
            // 
            this.WithrdawTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.WithrdawTB.Font = new System.Drawing.Font("Russo One", 16F);
            this.WithrdawTB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.WithrdawTB.Location = new System.Drawing.Point(166, 150);
            this.WithrdawTB.Name = "WithrdawTB";
            this.WithrdawTB.Size = new System.Drawing.Size(192, 33);
            this.WithrdawTB.TabIndex = 73;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.backLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.backLabel.Location = new System.Drawing.Point(162, 257);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(52, 19);
            this.backLabel.TabIndex = 72;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 11);
            this.panel2.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Russo One", 12F);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "AMOUNT:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.atmLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 89);
            this.panel1.TabIndex = 77;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLabel.Location = new System.Drawing.Point(346, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(27, 26);
            this.exitLabel.TabIndex = 8;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // atmLabel
            // 
            this.atmLabel.AutoSize = true;
            this.atmLabel.Font = new System.Drawing.Font("Sigmar One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atmLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.atmLabel.Location = new System.Drawing.Point(25, 23);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(327, 48);
            this.atmLabel.TabIndex = 0;
            this.atmLabel.Text = "B A N K  S Y S T E M";
            // 
            // withdrawButton
            // 
            this.withdrawButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.withdrawButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.withdrawButton.ForeColor = System.Drawing.Color.White;
            this.withdrawButton.Location = new System.Drawing.Point(166, 199);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Rounding = 50;
            this.withdrawButton.RoundingEnable = true;
            this.withdrawButton.Size = new System.Drawing.Size(192, 30);
            this.withdrawButton.TabIndex = 74;
            this.withdrawButton.Text = "WITHDRAW";
            this.withdrawButton.UseVisualStyleBackColor = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // WithdrawClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(373, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BalanceNumLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.WithrdawTB);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WithdrawClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawClient";
            this.Load += new System.EventHandler(this.WithdrawClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BalanceNumLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.my_Button withdrawButton;
        private System.Windows.Forms.TextBox WithrdawTB;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label atmLabel;
    }
}