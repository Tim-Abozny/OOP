
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signUP_label = new System.Windows.Forms.Label();
            this.Pin_TB = new System.Windows.Forms.TextBox();
            this.AccNum_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.my_Button();
            this.my_Button1 = new System.Windows.Forms.my_Button();
            this.managerButton = new System.Windows.Forms.my_Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 110);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(632, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sigmar One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(123, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "B A N K  S Y S T E M";
            // 
            // signUP_label
            // 
            this.signUP_label.AutoSize = true;
            this.signUP_label.Font = new System.Drawing.Font("Russo One", 12F);
            this.signUP_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.signUP_label.Location = new System.Drawing.Point(455, 345);
            this.signUP_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUP_label.Name = "signUP_label";
            this.signUP_label.Size = new System.Drawing.Size(97, 25);
            this.signUP_label.TabIndex = 14;
            this.signUP_label.Text = "SIGN UP";
            this.signUP_label.Click += new System.EventHandler(this.signUP_label_Click);
            // 
            // Pin_TB
            // 
            this.Pin_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.Pin_TB.Font = new System.Drawing.Font("Russo One", 16F);
            this.Pin_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Pin_TB.Location = new System.Drawing.Point(380, 229);
            this.Pin_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pin_TB.Name = "Pin_TB";
            this.Pin_TB.PasswordChar = '*';
            this.Pin_TB.Size = new System.Drawing.Size(255, 40);
            this.Pin_TB.TabIndex = 13;
            // 
            // AccNum_TB
            // 
            this.AccNum_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.AccNum_TB.Font = new System.Drawing.Font("Russo One", 16F);
            this.AccNum_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AccNum_TB.Location = new System.Drawing.Point(380, 158);
            this.AccNum_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccNum_TB.Name = "AccNum_TB";
            this.AccNum_TB.Size = new System.Drawing.Size(255, 40);
            this.AccNum_TB.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 16F);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(191, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "PIN CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 16F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(191, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "ACC NUM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 384);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 14);
            this.panel2.TabIndex = 50;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.loginButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(380, 304);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Rounding = 50;
            this.loginButton.RoundingEnable = true;
            this.loginButton.Size = new System.Drawing.Size(256, 37);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // my_Button1
            // 
            this.my_Button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.my_Button1.Font = new System.Drawing.Font("Russo One", 8F);
            this.my_Button1.ForeColor = System.Drawing.Color.White;
            this.my_Button1.Location = new System.Drawing.Point(8, 345);
            this.my_Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.my_Button1.Name = "my_Button1";
            this.my_Button1.Rounding = 50;
            this.my_Button1.RoundingEnable = true;
            this.my_Button1.Size = new System.Drawing.Size(91, 37);
            this.my_Button1.TabIndex = 51;
            this.my_Button1.Text = "BACK";
            this.my_Button1.UseVisualStyleBackColor = false;
            this.my_Button1.Click += new System.EventHandler(this.my_Button1_Click);
            // 
            // managerButton
            // 
            this.managerButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.managerButton.Font = new System.Drawing.Font("Russo One", 8F);
            this.managerButton.ForeColor = System.Drawing.Color.White;
            this.managerButton.Location = new System.Drawing.Point(107, 345);
            this.managerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.managerButton.Name = "managerButton";
            this.managerButton.Rounding = 50;
            this.managerButton.RoundingEnable = true;
            this.managerButton.Size = new System.Drawing.Size(105, 37);
            this.managerButton.TabIndex = 52;
            this.managerButton.Text = "MANAGER";
            this.managerButton.UseVisualStyleBackColor = false;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Lab1_Forms.Properties.Resources.atm_machine_finance_cash_withdraw_money_icon_153132;
            this.pictureBox1.Location = new System.Drawing.Point(8, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(668, 398);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.my_Button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signUP_label);
            this.Controls.Add(this.Pin_TB);
            this.Controls.Add(this.AccNum_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label signUP_label;
        private System.Windows.Forms.TextBox Pin_TB;
        private System.Windows.Forms.TextBox AccNum_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.my_Button loginButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.my_Button my_Button1;
        private System.Windows.Forms.my_Button managerButton;
    }
}

