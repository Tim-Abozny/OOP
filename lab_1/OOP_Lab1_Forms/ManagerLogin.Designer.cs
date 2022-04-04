
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
            this.label1 = new System.Windows.Forms.Label();
            this.clientButton = new System.Windows.Forms.my_Button();
            this.backButton = new System.Windows.Forms.my_Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.my_Button();
            this.Pin_TB = new System.Windows.Forms.TextBox();
            this.AccNum_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 110);
            this.panel1.TabIndex = 53;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Maroon;
            this.exitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.Azure;
            this.exitLabel.Location = new System.Drawing.Point(635, 0);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(35, 35);
            this.exitLabel.TabIndex = 8;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
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
            // clientButton
            // 
            this.clientButton.BackColor = System.Drawing.Color.Maroon;
            this.clientButton.Font = new System.Drawing.Font("Russo One", 8F);
            this.clientButton.ForeColor = System.Drawing.Color.White;
            this.clientButton.Location = new System.Drawing.Point(107, 345);
            this.clientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientButton.Name = "clientButton";
            this.clientButton.Rounding = 50;
            this.clientButton.RoundingEnable = true;
            this.clientButton.Size = new System.Drawing.Size(105, 37);
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
            this.backButton.Location = new System.Drawing.Point(8, 345);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Rounding = 50;
            this.backButton.RoundingEnable = true;
            this.backButton.Size = new System.Drawing.Size(91, 37);
            this.backButton.TabIndex = 62;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 384);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 14);
            this.panel2.TabIndex = 61;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Maroon;
            this.loginButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(380, 304);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Rounding = 50;
            this.loginButton.RoundingEnable = true;
            this.loginButton.Size = new System.Drawing.Size(256, 37);
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
            this.Pin_TB.Location = new System.Drawing.Point(380, 229);
            this.Pin_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pin_TB.Name = "Pin_TB";
            this.Pin_TB.PasswordChar = '*';
            this.Pin_TB.Size = new System.Drawing.Size(255, 40);
            this.Pin_TB.TabIndex = 58;
            // 
            // AccNum_TB
            // 
            this.AccNum_TB.BackColor = System.Drawing.Color.IndianRed;
            this.AccNum_TB.Font = new System.Drawing.Font("Russo One", 16F);
            this.AccNum_TB.ForeColor = System.Drawing.Color.Maroon;
            this.AccNum_TB.Location = new System.Drawing.Point(380, 158);
            this.AccNum_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccNum_TB.Name = "AccNum_TB";
            this.AccNum_TB.Size = new System.Drawing.Size(255, 40);
            this.AccNum_TB.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 16F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(191, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 33);
            this.label3.TabIndex = 56;
            this.label3.Text = "PIN CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 16F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(191, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 33);
            this.label2.TabIndex = 55;
            this.label2.Text = "ACC NUM";
            // 
            // keyButton
            // 
            this.keyButton.BackColor = System.Drawing.Color.Azure;
            this.keyButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.keyButton.ForeColor = System.Drawing.Color.Transparent;
            this.keyButton.Location = new System.Drawing.Point(53, 233);
            this.keyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keyButton.Name = "keyButton";
            this.keyButton.Rounding = 10;
            this.keyButton.RoundingEnable = false;
            this.keyButton.Size = new System.Drawing.Size(43, 9);
            this.keyButton.TabIndex = 64;
            this.keyButton.UseVisualStyleBackColor = false;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP_Lab1_Forms.Properties.Resources.Golden_key;
            this.pictureBox2.Location = new System.Drawing.Point(452, 345);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Lab1_Forms.Properties.Resources.atm_icon_31876;
            this.pictureBox1.Location = new System.Drawing.Point(8, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(673, 398);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.Pin_TB);
            this.Controls.Add(this.AccNum_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.my_Button clientButton;
        private System.Windows.Forms.my_Button backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.my_Button loginButton;
        private System.Windows.Forms.TextBox Pin_TB;
        private System.Windows.Forms.TextBox AccNum_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.my_Button keyButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}