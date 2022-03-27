
namespace OOP_Lab1_Forms
{
    partial class Home
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
            this.AccountInfoButton = new System.Windows.Forms.my_Button();
            this.AccNumLabel = new System.Windows.Forms.Label();
            this.Logout_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountInfoButton
            // 
            this.AccountInfoButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AccountInfoButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.AccountInfoButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AccountInfoButton.Location = new System.Drawing.Point(368, 204);
            this.AccountInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.AccountInfoButton.Name = "AccountInfoButton";
            this.AccountInfoButton.Rounding = 10;
            this.AccountInfoButton.RoundingEnable = true;
            this.AccountInfoButton.Size = new System.Drawing.Size(54, 50);
            this.AccountInfoButton.TabIndex = 52;
            this.AccountInfoButton.Text = "ATM";
            this.AccountInfoButton.UseVisualStyleBackColor = false;
            this.AccountInfoButton.Click += new System.EventHandler(this.AccountInfoButton_Click);
            // 
            // AccNumLabel
            // 
            this.AccNumLabel.AutoSize = true;
            this.AccNumLabel.BackColor = System.Drawing.Color.Lavender;
            this.AccNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccNumLabel.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccNumLabel.ForeColor = System.Drawing.Color.Navy;
            this.AccNumLabel.Location = new System.Drawing.Point(375, 165);
            this.AccNumLabel.Name = "AccNumLabel";
            this.AccNumLabel.Size = new System.Drawing.Size(41, 16);
            this.AccNumLabel.TabIndex = 51;
            this.AccNumLabel.Text = "0000";
            // 
            // Logout_label
            // 
            this.Logout_label.AutoSize = true;
            this.Logout_label.Font = new System.Drawing.Font("Russo One", 12F);
            this.Logout_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Logout_label.Location = new System.Drawing.Point(355, 332);
            this.Logout_label.Name = "Logout_label";
            this.Logout_label.Size = new System.Drawing.Size(76, 19);
            this.Logout_label.TabIndex = 50;
            this.Logout_label.Text = "LOGOUT";
            this.Logout_label.Click += new System.EventHandler(this.Logout_label_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 11);
            this.panel2.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(773, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 26);
            this.label5.TabIndex = 53;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Lab1_Forms.Properties.Resources.atm_machine_finance_cash_withdraw_money_icon_153132;
            this.pictureBox1.Location = new System.Drawing.Point(329, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AccountInfoButton);
            this.Controls.Add(this.AccNumLabel);
            this.Controls.Add(this.Logout_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.my_Button AccountInfoButton;
        private System.Windows.Forms.Label AccNumLabel;
        private System.Windows.Forms.Label Logout_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}