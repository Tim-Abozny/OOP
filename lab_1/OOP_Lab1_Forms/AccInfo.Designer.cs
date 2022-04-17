
namespace OOP_Lab1_Forms
{
    partial class AccInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.atmLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.my_Button();
            this.Pin_TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Surname_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientLogin_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.atmLabel);
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 89);
            this.panel1.TabIndex = 16;
            // 
            // atmLabel
            // 
            this.atmLabel.AutoSize = true;
            this.atmLabel.Font = new System.Drawing.Font("Sigmar One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atmLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.atmLabel.Location = new System.Drawing.Point(12, 21);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(327, 48);
            this.atmLabel.TabIndex = 9;
            this.atmLabel.Text = "B A N K  S Y S T E M";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLabel.Location = new System.Drawing.Point(347, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(27, 26);
            this.exitLabel.TabIndex = 8;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.backButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(93, 283);
            this.backButton.Name = "backButton";
            this.backButton.Rounding = 50;
            this.backButton.RoundingEnable = true;
            this.backButton.Size = new System.Drawing.Size(192, 30);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Pin_TB
            // 
            this.Pin_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.Pin_TB.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pin_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Pin_TB.Location = new System.Drawing.Point(128, 238);
            this.Pin_TB.Name = "Pin_TB";
            this.Pin_TB.ReadOnly = true;
            this.Pin_TB.Size = new System.Drawing.Size(192, 27);
            this.Pin_TB.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Russo One", 12F);
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(16, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "PIN";
            // 
            // ID_TB
            // 
            this.ID_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ID_TB.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ID_TB.Location = new System.Drawing.Point(128, 205);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.ReadOnly = true;
            this.ID_TB.Size = new System.Drawing.Size(192, 27);
            this.ID_TB.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Russo One", 12F);
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(16, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "CLIENT_ID";
            // 
            // Surname_TB
            // 
            this.Surname_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.Surname_TB.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Surname_TB.Location = new System.Drawing.Point(128, 172);
            this.Surname_TB.Name = "Surname_TB";
            this.Surname_TB.ReadOnly = true;
            this.Surname_TB.Size = new System.Drawing.Size(192, 27);
            this.Surname_TB.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Russo One", 12F);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(16, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "FNAME";
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.Name_TB.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name_TB.Location = new System.Drawing.Point(128, 139);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.ReadOnly = true;
            this.Name_TB.Size = new System.Drawing.Size(192, 27);
            this.Name_TB.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 12F);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "NAME";
            // 
            // ClientLogin_TB
            // 
            this.ClientLogin_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientLogin_TB.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientLogin_TB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ClientLogin_TB.Location = new System.Drawing.Point(128, 106);
            this.ClientLogin_TB.Name = "ClientLogin_TB";
            this.ClientLogin_TB.ReadOnly = true;
            this.ClientLogin_TB.Size = new System.Drawing.Size(192, 27);
            this.ClientLogin_TB.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 12F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "LOGIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 11);
            this.panel2.TabIndex = 51;
            // 
            // AccInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(372, 330);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pin_TB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ID_TB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Surname_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.ClientLogin_TB);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccInfo";
            this.Load += new System.EventHandler(this.AccInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.my_Button backButton;
        private System.Windows.Forms.Label atmLabel;
        private System.Windows.Forms.TextBox Pin_TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ID_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Surname_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientLogin_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}