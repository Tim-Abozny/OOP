
namespace system_ATM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.atmLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pinCodeLabel = new System.Windows.Forms.Label();
            this.AccNum_TB = new System.Windows.Forms.TextBox();
            this.Pin_TB = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.my_Button();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.atmLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 89);
            this.panel1.TabIndex = 0;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.exitLabel.Location = new System.Drawing.Point(505, 0);
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
            this.atmLabel.Location = new System.Drawing.Point(129, 18);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(296, 48);
            this.atmLabel.TabIndex = 0;
            this.atmLabel.Text = "A T M  S Y S T E M";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Russo One", 16F);
            this.nameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nameLabel.Location = new System.Drawing.Point(149, 169);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(116, 26);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "ACC NUM";
            // 
            // pinCodeLabel
            // 
            this.pinCodeLabel.AutoSize = true;
            this.pinCodeLabel.Font = new System.Drawing.Font("Russo One", 16F);
            this.pinCodeLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pinCodeLabel.Location = new System.Drawing.Point(149, 227);
            this.pinCodeLabel.Name = "pinCodeLabel";
            this.pinCodeLabel.Size = new System.Drawing.Size(120, 26);
            this.pinCodeLabel.TabIndex = 3;
            this.pinCodeLabel.Text = "PIN CODE";
            // 
            // AccNum_TB
            // 
            this.AccNum_TB.Font = new System.Drawing.Font("Russo One", 16F);
            this.AccNum_TB.Location = new System.Drawing.Point(291, 166);
            this.AccNum_TB.Name = "AccNum_TB";
            this.AccNum_TB.Size = new System.Drawing.Size(192, 33);
            this.AccNum_TB.TabIndex = 4;
            // 
            // Pin_TB
            // 
            this.Pin_TB.Font = new System.Drawing.Font("Russo One", 16F);
            this.Pin_TB.Location = new System.Drawing.Point(291, 224);
            this.Pin_TB.Name = "Pin_TB";
            this.Pin_TB.PasswordChar = '*';
            this.Pin_TB.Size = new System.Drawing.Size(192, 33);
            this.Pin_TB.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(291, 285);
            this.loginButton.Name = "loginButton";
            this.loginButton.Rounding = 50;
            this.loginButton.RoundingEnable = true;
            this.loginButton.Size = new System.Drawing.Size(192, 30);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.signUpLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.signUpLabel.Location = new System.Drawing.Point(347, 318);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(78, 19);
            this.signUpLabel.TabIndex = 7;
            this.signUpLabel.Text = "SIGN UP";
            this.signUpLabel.Click += new System.EventHandler(this.signUpLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::system_ATM.Properties.Resources.atm_machine_finance_cash_withdraw_money_icon_153132;
            this.pictureBox1.Location = new System.Drawing.Point(12, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 356);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.Pin_TB);
            this.Controls.Add(this.AccNum_TB);
            this.Controls.Add(this.pinCodeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label atmLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label pinCodeLabel;
        private System.Windows.Forms.TextBox AccNum_TB;
        private System.Windows.Forms.TextBox Pin_TB;
        private System.Windows.Forms.my_Button loginButton;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label exitLabel;
    }
}