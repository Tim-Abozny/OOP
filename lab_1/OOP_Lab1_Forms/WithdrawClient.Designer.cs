
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
            this.BalanceNumLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WithrdawTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 12F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "AVAILABLE BALANCE:";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Russo One", 12F);
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(162, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 19);
            this.label13.TabIndex = 72;
            this.label13.Text = "BACK";
            this.label13.Click += new System.EventHandler(this.label13_Click);
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
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 89);
            this.panel1.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(346, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sigmar One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "B A N K  S Y S T E M";
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.WithrdawTB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.my_Button withdrawButton;
        private System.Windows.Forms.TextBox WithrdawTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}