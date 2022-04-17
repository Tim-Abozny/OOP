
namespace OOP_Lab1_Forms
{
    partial class SignUpClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.atmLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.my_Button();
            this.backLabel = new System.Windows.Forms.Label();
            this.ClientLogin_TB = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Surname_TB = new System.Windows.Forms.TextBox();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.ID_TB = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pin_TB = new System.Windows.Forms.TextBox();
            this.pinCodeLabel = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(488, 89);
            this.panel1.TabIndex = 16;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLabel.Location = new System.Drawing.Point(461, 0);
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
            this.atmLabel.Location = new System.Drawing.Point(94, 22);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(327, 48);
            this.atmLabel.TabIndex = 0;
            this.atmLabel.Text = "B A N K  S Y S T E M";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.signUpButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(153, 281);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Rounding = 50;
            this.signUpButton.RoundingEnable = true;
            this.signUpButton.Size = new System.Drawing.Size(192, 30);
            this.signUpButton.TabIndex = 23;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.backLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.backLabel.Location = new System.Drawing.Point(226, 314);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(52, 19);
            this.backLabel.TabIndex = 22;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // ClientLogin_TB
            // 
            this.ClientLogin_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientLogin_TB.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientLogin_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ClientLogin_TB.Location = new System.Drawing.Point(124, 100);
            this.ClientLogin_TB.Name = "ClientLogin_TB";
            this.ClientLogin_TB.Size = new System.Drawing.Size(192, 27);
            this.ClientLogin_TB.TabIndex = 20;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.loginLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.loginLabel.Location = new System.Drawing.Point(12, 103);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(61, 19);
            this.loginLabel.TabIndex = 18;
            this.loginLabel.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Lab1_Forms.Properties.Resources.atm_machine_finance_cash_withdraw_money_icon_153132;
            this.pictureBox1.Location = new System.Drawing.Point(340, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.Name_TB.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name_TB.Location = new System.Drawing.Point(124, 133);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(192, 27);
            this.Name_TB.TabIndex = 25;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.nameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.nameLabel.Location = new System.Drawing.Point(12, 136);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 19);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "NAME";
            // 
            // Surname_TB
            // 
            this.Surname_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.Surname_TB.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Surname_TB.Location = new System.Drawing.Point(124, 166);
            this.Surname_TB.Name = "Surname_TB";
            this.Surname_TB.Size = new System.Drawing.Size(192, 27);
            this.Surname_TB.TabIndex = 27;
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.fNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fNameLabel.Location = new System.Drawing.Point(12, 169);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(66, 19);
            this.fNameLabel.TabIndex = 26;
            this.fNameLabel.Text = "FNAME";
            // 
            // ID_TB
            // 
            this.ID_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ID_TB.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ID_TB.Location = new System.Drawing.Point(124, 199);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.ReadOnly = true;
            this.ID_TB.Size = new System.Drawing.Size(192, 27);
            this.ID_TB.TabIndex = 29;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.IDLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.IDLabel.Location = new System.Drawing.Point(12, 202);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(95, 19);
            this.IDLabel.TabIndex = 28;
            this.IDLabel.Text = "CLIENT_ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 11);
            this.panel2.TabIndex = 38;
            // 
            // Pin_TB
            // 
            this.Pin_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.Pin_TB.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pin_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Pin_TB.Location = new System.Drawing.Point(124, 232);
            this.Pin_TB.Name = "Pin_TB";
            this.Pin_TB.Size = new System.Drawing.Size(192, 27);
            this.Pin_TB.TabIndex = 40;
            // 
            // pinCodeLabel
            // 
            this.pinCodeLabel.AutoSize = true;
            this.pinCodeLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.pinCodeLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pinCodeLabel.Location = new System.Drawing.Point(12, 235);
            this.pinCodeLabel.Name = "pinCodeLabel";
            this.pinCodeLabel.Size = new System.Drawing.Size(39, 19);
            this.pinCodeLabel.TabIndex = 39;
            this.pinCodeLabel.Text = "PIN";
            // 
            // SignUpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(488, 350);
            this.Controls.Add(this.Pin_TB);
            this.Controls.Add(this.pinCodeLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ID_TB);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.Surname_TB);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.ClientLogin_TB);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpClient";
            this.Load += new System.EventHandler(this.SignUpClient_Load);
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
        private System.Windows.Forms.my_Button signUpButton;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.TextBox ClientLogin_TB;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox Surname_TB;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.TextBox ID_TB;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Pin_TB;
        private System.Windows.Forms.Label pinCodeLabel;
    }
}