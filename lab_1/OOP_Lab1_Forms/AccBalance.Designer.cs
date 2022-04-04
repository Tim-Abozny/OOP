
namespace OOP_Lab1_Forms
{
    partial class AccBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccBalance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.balanceNumLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.accNumLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 110);
            this.panel1.TabIndex = 85;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLabel.Location = new System.Drawing.Point(461, 0);
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
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "B A N K  S Y S T E M";
            // 
            // balanceNumLabel
            // 
            this.balanceNumLabel.AutoSize = true;
            this.balanceNumLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.balanceNumLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.balanceNumLabel.Location = new System.Drawing.Point(293, 207);
            this.balanceNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceNumLabel.Name = "balanceNumLabel";
            this.balanceNumLabel.Size = new System.Drawing.Size(140, 25);
            this.balanceNumLabel.TabIndex = 84;
            this.balanceNumLabel.Text = "BalanceNum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 12F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(7, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "AVAILABLE BALANCE:";
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.backLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.backLabel.Location = new System.Drawing.Point(215, 273);
            this.backLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(66, 25);
            this.backLabel.TabIndex = 80;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 300);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 14);
            this.panel2.TabIndex = 79;
            // 
            // accNumLabel
            // 
            this.accNumLabel.AutoSize = true;
            this.accNumLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.accNumLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.accNumLabel.Location = new System.Drawing.Point(293, 148);
            this.accNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accNumLabel.Name = "accNumLabel";
            this.accNumLabel.Size = new System.Drawing.Size(150, 25);
            this.accNumLabel.TabIndex = 87;
            this.accNumLabel.Text = "AccNumLabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Russo One", 12F);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(7, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 86;
            this.label4.Text = "ACCOUNT NUMBER:";
            // 
            // AccBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(500, 314);
            this.Controls.Add(this.accNumLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.balanceNumLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccBalance";
            this.Load += new System.EventHandler(this.AccBalance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceNumLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label accNumLabel;
        private System.Windows.Forms.Label label4;
    }
}