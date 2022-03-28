
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
            this.depositButton = new System.Windows.Forms.my_Button();
            this.DepositTB = new System.Windows.Forms.TextBox();
            this.Back_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // Back_label
            // 
            this.Back_label.AutoSize = true;
            this.Back_label.Font = new System.Drawing.Font("Russo One", 12F);
            this.Back_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Back_label.Location = new System.Drawing.Point(170, 178);
            this.Back_label.Name = "Back_label";
            this.Back_label.Size = new System.Drawing.Size(52, 19);
            this.Back_label.TabIndex = 64;
            this.Back_label.Text = "BACK";
            this.Back_label.Click += new System.EventHandler(this.Back_label_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Russo One", 12F);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(25, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 62;
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
            this.panel1.Size = new System.Drawing.Size(381, 89);
            this.panel1.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(354, 0);
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
            // DepositClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(381, 211);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.DepositTB);
            this.Controls.Add(this.Back_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label Back_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}