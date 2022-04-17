
namespace OOP_Lab1_Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.atmLabel = new System.Windows.Forms.Label();
            this.signUP_label = new System.Windows.Forms.Label();
            this.Pin_TB = new System.Windows.Forms.TextBox();
            this.AccNum_TB = new System.Windows.Forms.TextBox();
            this.pinCodeLabel = new System.Windows.Forms.Label();
            this.accNumLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.my_Button();
            this.backButton = new System.Windows.Forms.my_Button();
            this.managerButton = new System.Windows.Forms.my_Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.atmLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 89);
            this.panel1.TabIndex = 8;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLabel.Location = new System.Drawing.Point(474, 0);
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
            this.atmLabel.Location = new System.Drawing.Point(92, 24);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(327, 48);
            this.atmLabel.TabIndex = 0;
            this.atmLabel.Text = "B A N K  S Y S T E M";
            // 
            // signUP_label
            // 
            this.signUP_label.AutoSize = true;
            this.signUP_label.Font = new System.Drawing.Font("Russo One", 12F);
            this.signUP_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.signUP_label.Location = new System.Drawing.Point(341, 280);
            this.signUP_label.Name = "signUP_label";
            this.signUP_label.Size = new System.Drawing.Size(78, 19);
            this.signUP_label.TabIndex = 14;
            this.signUP_label.Text = "SIGN UP";
            this.signUP_label.Click += new System.EventHandler(this.signUP_label_Click);
            // 
            // Pin_TB
            // 
            this.Pin_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.Pin_TB.Font = new System.Drawing.Font("Russo One", 16F);
            this.Pin_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Pin_TB.Location = new System.Drawing.Point(285, 186);
            this.Pin_TB.Name = "Pin_TB";
            this.Pin_TB.PasswordChar = '*';
            this.Pin_TB.Size = new System.Drawing.Size(192, 33);
            this.Pin_TB.TabIndex = 13;
            // 
            // AccNum_TB
            // 
            this.AccNum_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.AccNum_TB.Font = new System.Drawing.Font("Russo One", 16F);
            this.AccNum_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AccNum_TB.Location = new System.Drawing.Point(285, 128);
            this.AccNum_TB.Name = "AccNum_TB";
            this.AccNum_TB.Size = new System.Drawing.Size(192, 33);
            this.AccNum_TB.TabIndex = 12;
            // 
            // pinCodeLabel
            // 
            this.pinCodeLabel.AutoSize = true;
            this.pinCodeLabel.Font = new System.Drawing.Font("Russo One", 16F);
            this.pinCodeLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pinCodeLabel.Location = new System.Drawing.Point(143, 189);
            this.pinCodeLabel.Name = "pinCodeLabel";
            this.pinCodeLabel.Size = new System.Drawing.Size(120, 26);
            this.pinCodeLabel.TabIndex = 11;
            this.pinCodeLabel.Text = "PIN CODE";
            // 
            // accNumLabel
            // 
            this.accNumLabel.AutoSize = true;
            this.accNumLabel.Font = new System.Drawing.Font("Russo One", 16F);
            this.accNumLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.accNumLabel.Location = new System.Drawing.Point(143, 131);
            this.accNumLabel.Name = "accNumLabel";
            this.accNumLabel.Size = new System.Drawing.Size(116, 26);
            this.accNumLabel.TabIndex = 10;
            this.accNumLabel.Text = "ACC NUM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 11);
            this.panel2.TabIndex = 50;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.loginButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(285, 247);
            this.loginButton.Name = "loginButton";
            this.loginButton.Rounding = 50;
            this.loginButton.RoundingEnable = true;
            this.loginButton.Size = new System.Drawing.Size(192, 30);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.backButton.Font = new System.Drawing.Font("Russo One", 8F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(6, 280);
            this.backButton.Name = "backButton";
            this.backButton.Rounding = 50;
            this.backButton.RoundingEnable = true;
            this.backButton.Size = new System.Drawing.Size(68, 30);
            this.backButton.TabIndex = 51;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // managerButton
            // 
            this.managerButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.managerButton.Font = new System.Drawing.Font("Russo One", 8F);
            this.managerButton.ForeColor = System.Drawing.Color.White;
            this.managerButton.Location = new System.Drawing.Point(80, 280);
            this.managerButton.Name = "managerButton";
            this.managerButton.Rounding = 50;
            this.managerButton.RoundingEnable = true;
            this.managerButton.Size = new System.Drawing.Size(79, 30);
            this.managerButton.TabIndex = 52;
            this.managerButton.Text = "MANAGER";
            this.managerButton.UseVisualStyleBackColor = false;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Lab1_Forms.Properties.Resources.atm_machine_finance_cash_withdraw_money_icon_153132;
            this.pictureBox1.Location = new System.Drawing.Point(6, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(501, 323);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signUP_label);
            this.Controls.Add(this.Pin_TB);
            this.Controls.Add(this.AccNum_TB);
            this.Controls.Add(this.pinCodeLabel);
            this.Controls.Add(this.accNumLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label atmLabel;
        private System.Windows.Forms.Label signUP_label;
        private System.Windows.Forms.TextBox Pin_TB;
        private System.Windows.Forms.TextBox AccNum_TB;
        private System.Windows.Forms.Label pinCodeLabel;
        private System.Windows.Forms.Label accNumLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.my_Button loginButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.my_Button backButton;
        private System.Windows.Forms.my_Button managerButton;
    }
}

