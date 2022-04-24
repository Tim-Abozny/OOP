
namespace system_ATM
{
    partial class Balance
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
            this.accNumLogo = new System.Windows.Forms.Label();
            this.balanceLogo = new System.Windows.Forms.Label();
            this.AccNumLabel = new System.Windows.Forms.Label();
            this.BalanceNumLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Font = new System.Drawing.Font("Russo One", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(165, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Balance";
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
            this.atmLabel.Location = new System.Drawing.Point(51, 22);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(296, 48);
            this.atmLabel.TabIndex = 0;
            this.atmLabel.Text = "A T M  S Y S T E M";
            // 
            // accNumLogo
            // 
            this.accNumLogo.AutoSize = true;
            this.accNumLogo.Font = new System.Drawing.Font("Russo One", 12F);
            this.accNumLogo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.accNumLogo.Location = new System.Drawing.Point(25, 118);
            this.accNumLogo.Name = "accNumLogo";
            this.accNumLogo.Size = new System.Drawing.Size(166, 19);
            this.accNumLogo.TabIndex = 17;
            this.accNumLogo.Text = "ACCOUNT NUMBER:";
            // 
            // balanceLogo
            // 
            this.balanceLogo.AutoSize = true;
            this.balanceLogo.Font = new System.Drawing.Font("Russo One", 12F);
            this.balanceLogo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.balanceLogo.Location = new System.Drawing.Point(25, 188);
            this.balanceLogo.Name = "balanceLogo";
            this.balanceLogo.Size = new System.Drawing.Size(140, 19);
            this.balanceLogo.TabIndex = 18;
            this.balanceLogo.Text = "YOUR BALANCE:";
            // 
            // AccNumLabel
            // 
            this.AccNumLabel.AutoSize = true;
            this.AccNumLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.AccNumLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AccNumLabel.Location = new System.Drawing.Point(197, 118);
            this.AccNumLabel.Name = "AccNumLabel";
            this.AccNumLabel.Size = new System.Drawing.Size(120, 19);
            this.AccNumLabel.TabIndex = 19;
            this.AccNumLabel.Text = "AccNumLabel";
            // 
            // BalanceNumLabel
            // 
            this.BalanceNumLabel.AutoSize = true;
            this.BalanceNumLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.BalanceNumLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BalanceNumLabel.Location = new System.Drawing.Point(197, 188);
            this.BalanceNumLabel.Name = "BalanceNumLabel";
            this.BalanceNumLabel.Size = new System.Drawing.Size(156, 19);
            this.BalanceNumLabel.TabIndex = 20;
            this.BalanceNumLabel.Text = "BalanceNumLabel";
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.backLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.backLabel.Location = new System.Drawing.Point(166, 257);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(52, 19);
            this.backLabel.TabIndex = 42;
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
            this.panel2.TabIndex = 41;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 290);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BalanceNumLabel);
            this.Controls.Add(this.AccNumLabel);
            this.Controls.Add(this.balanceLogo);
            this.Controls.Add(this.accNumLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label atmLabel;
        private System.Windows.Forms.Label accNumLogo;
        private System.Windows.Forms.Label balanceLogo;
        private System.Windows.Forms.Label AccNumLabel;
        private System.Windows.Forms.Label BalanceNumLabel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}