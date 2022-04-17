
namespace OOP_Lab1_Forms
{
    partial class DepositClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositClient));
            this.depositButton = new System.Windows.Forms.my_Button();
            this.DepositTB = new System.Windows.Forms.TextBox();
            this.backLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.atmLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.depositButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.depositButton.ForeColor = System.Drawing.Color.White;
            this.depositButton.Location = new System.Drawing.Point(134, 134);
            this.depositButton.Name = "depositButton";
            this.depositButton.Rounding = 50;
            this.depositButton.RoundingEnable = true;
            this.depositButton.Size = new System.Drawing.Size(192, 30);
            this.depositButton.TabIndex = 66;
            this.depositButton.Text = "DEPOSIT";
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // DepositTB
            // 
            this.DepositTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.DepositTB.Font = new System.Drawing.Font("Russo One", 16F);
            this.DepositTB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DepositTB.Location = new System.Drawing.Point(134, 95);
            this.DepositTB.Name = "DepositTB";
            this.DepositTB.Size = new System.Drawing.Size(192, 33);
            this.DepositTB.TabIndex = 65;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.backLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.backLabel.Location = new System.Drawing.Point(170, 178);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(52, 19);
            this.backLabel.TabIndex = 64;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.Back_label_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 11);
            this.panel2.TabIndex = 63;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.amountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.amountLabel.Location = new System.Drawing.Point(25, 104);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(84, 19);
            this.amountLabel.TabIndex = 62;
            this.amountLabel.Text = "AMOUNT:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.atmLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 89);
            this.panel1.TabIndex = 67;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLabel.Location = new System.Drawing.Point(354, 0);
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
            // DepositClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(381, 211);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.DepositTB);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.amountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepositClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.my_Button depositButton;
        private System.Windows.Forms.TextBox DepositTB;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label atmLabel;
    }
}