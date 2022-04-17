
namespace OOP_Lab1_Forms
{
    partial class ManagerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.atmLabel = new System.Windows.Forms.Label();
            this.clientButton = new System.Windows.Forms.my_Button();
            this.backButton = new System.Windows.Forms.my_Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.my_Button();
            this.Pin_TB = new System.Windows.Forms.TextBox();
            this.AccNum_TB = new System.Windows.Forms.TextBox();
            this.pinCodeLabel = new System.Windows.Forms.Label();
            this.accNumLabel = new System.Windows.Forms.Label();
            this.keyButton = new System.Windows.Forms.my_Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.atmLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 89);
            this.panel1.TabIndex = 53;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Maroon;
            this.exitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.Azure;
            this.exitLabel.Location = new System.Drawing.Point(476, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(29, 28);
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
            // clientButton
            // 
            this.clientButton.BackColor = System.Drawing.Color.Maroon;
            this.clientButton.Font = new System.Drawing.Font("Russo One", 8F);
            this.clientButton.ForeColor = System.Drawing.Color.White;
            this.clientButton.Location = new System.Drawing.Point(80, 280);
            this.clientButton.Name = "clientButton";
            this.clientButton.Rounding = 50;
            this.clientButton.RoundingEnable = true;
            this.clientButton.Size = new System.Drawing.Size(79, 30);
            this.clientButton.TabIndex = 63;
            this.clientButton.Text = "CLIENT";
            this.clientButton.UseVisualStyleBackColor = false;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Maroon;
            this.backButton.Font = new System.Drawing.Font("Russo One", 8F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(6, 280);
            this.backButton.Name = "backButton";
            this.backButton.Rounding = 50;
            this.backButton.RoundingEnable = true;
            this.backButton.Size = new System.Drawing.Size(68, 30);
            this.backButton.TabIndex = 62;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 11);
            this.panel2.TabIndex = 61;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Maroon;
            this.loginButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(285, 247);
            this.loginButton.Name = "loginButton";
            this.loginButton.Rounding = 50;
            this.loginButton.RoundingEnable = true;
            this.loginButton.Size = new System.Drawing.Size(192, 30);
            this.loginButton.TabIndex = 60;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Pin_TB
            // 
            this.Pin_TB.BackColor = System.Drawing.Color.IndianRed;
            this.Pin_TB.Font = new System.Drawing.Font("Russo One", 16F);
            this.Pin_TB.ForeColor = System.Drawing.Color.Maroon;
            this.Pin_TB.Location = new System.Drawing.Point(285, 186);
            this.Pin_TB.Name = "Pin_TB";
            this.Pin_TB.PasswordChar = '*';
            this.Pin_TB.Size = new System.Drawing.Size(192, 33);
            this.Pin_TB.TabIndex = 58;
            // 
            // AccNum_TB
            // 
            this.AccNum_TB.BackColor = System.Drawing.Color.IndianRed;
            this.AccNum_TB.Font = new System.Drawing.Font("Russo One", 16F);
            this.AccNum_TB.ForeColor = System.Drawing.Color.Maroon;
            this.AccNum_TB.Location = new System.Drawing.Point(285, 128);
            this.AccNum_TB.Name = "AccNum_TB";
            this.AccNum_TB.Size = new System.Drawing.Size(192, 33);
            this.AccNum_TB.TabIndex = 57;
            // 
            // pinCodeLabel
            // 
            this.pinCodeLabel.AutoSize = true;
            this.pinCodeLabel.Font = new System.Drawing.Font("Russo One", 16F);
            this.pinCodeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.pinCodeLabel.Location = new System.Drawing.Point(143, 189);
            this.pinCodeLabel.Name = "pinCodeLabel";
            this.pinCodeLabel.Size = new System.Drawing.Size(120, 26);
            this.pinCodeLabel.TabIndex = 56;
            this.pinCodeLabel.Text = "PIN CODE";
            // 
            // accNumLabel
            // 
            this.accNumLabel.AutoSize = true;
            this.accNumLabel.Font = new System.Drawing.Font("Russo One", 16F);
            this.accNumLabel.ForeColor = System.Drawing.Color.Maroon;
            this.accNumLabel.Location = new System.Drawing.Point(143, 131);
            this.accNumLabel.Name = "accNumLabel";
            this.accNumLabel.Size = new System.Drawing.Size(116, 26);
            this.accNumLabel.TabIndex = 55;
            this.accNumLabel.Text = "ACC NUM";
            // 
            // keyButton
            // 
            this.keyButton.BackColor = System.Drawing.Color.Azure;
            this.keyButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.keyButton.ForeColor = System.Drawing.Color.Transparent;
            this.keyButton.Location = new System.Drawing.Point(40, 189);
            this.keyButton.Name = "keyButton";
            this.keyButton.Rounding = 10;
            this.keyButton.RoundingEnable = false;
            this.keyButton.Size = new System.Drawing.Size(32, 7);
            this.keyButton.TabIndex = 64;
            this.keyButton.UseVisualStyleBackColor = false;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP_Lab1_Forms.Properties.Resources.Golden_key;
            this.pictureBox2.Location = new System.Drawing.Point(339, 280);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Lab1_Forms.Properties.Resources.atm_icon_31876;
            this.pictureBox1.Location = new System.Drawing.Point(6, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(505, 323);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.Pin_TB);
            this.Controls.Add(this.AccNum_TB);
            this.Controls.Add(this.pinCodeLabel);
            this.Controls.Add(this.accNumLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label atmLabel;
        private System.Windows.Forms.my_Button clientButton;
        private System.Windows.Forms.my_Button backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.my_Button loginButton;
        private System.Windows.Forms.TextBox Pin_TB;
        private System.Windows.Forms.TextBox AccNum_TB;
        private System.Windows.Forms.Label pinCodeLabel;
        private System.Windows.Forms.Label accNumLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.my_Button keyButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}