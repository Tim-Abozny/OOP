
namespace OOP_Lab1_Forms
{
    partial class ClientHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientHome));
            this.AccNumLabel = new System.Windows.Forms.Label();
            this.Logout_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.banTimer = new System.Windows.Forms.Timer(this.components);
            this.companyButton = new System.Windows.Forms.my_Button();
            this.blockButton = new System.Windows.Forms.my_Button();
            this.transferButton = new System.Windows.Forms.my_Button();
            this.balanceButton = new System.Windows.Forms.my_Button();
            this.withdrawButton = new System.Windows.Forms.my_Button();
            this.depositButton = new System.Windows.Forms.my_Button();
            this.AccountInfoButton = new System.Windows.Forms.my_Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AccNumLabel
            // 
            this.AccNumLabel.AutoSize = true;
            this.AccNumLabel.BackColor = System.Drawing.Color.Lavender;
            this.AccNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccNumLabel.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccNumLabel.ForeColor = System.Drawing.Color.Navy;
            this.AccNumLabel.Location = new System.Drawing.Point(355, 133);
            this.AccNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccNumLabel.Name = "AccNumLabel";
            this.AccNumLabel.Size = new System.Drawing.Size(50, 20);
            this.AccNumLabel.TabIndex = 51;
            this.AccNumLabel.Text = "0000";
            // 
            // Logout_label
            // 
            this.Logout_label.AutoSize = true;
            this.Logout_label.Font = new System.Drawing.Font("Russo One", 12F);
            this.Logout_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Logout_label.Location = new System.Drawing.Point(329, 295);
            this.Logout_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Logout_label.Name = "Logout_label";
            this.Logout_label.Size = new System.Drawing.Size(95, 25);
            this.Logout_label.TabIndex = 50;
            this.Logout_label.Text = "LOGOUT";
            this.Logout_label.Click += new System.EventHandler(this.Logout_label_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 14);
            this.panel2.TabIndex = 49;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLabel.Location = new System.Drawing.Point(725, 0);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(33, 33);
            this.exitLabel.TabIndex = 53;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 110);
            this.panel1.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sigmar One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(179, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 61);
            this.label2.TabIndex = 0;
            this.label2.Text = "B A N K  S Y S T E M";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Lab1_Forms.Properties.Resources.atm_machine_finance_cash_withdraw_money_icon_153132;
            this.pictureBox1.Location = new System.Drawing.Point(292, 119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // banTimer
            // 
            this.banTimer.Tick += new System.EventHandler(this.banTimer_Tick);
            // 
            // companyButton
            // 
            this.companyButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.companyButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.companyButton.ForeColor = System.Drawing.Color.White;
            this.companyButton.Location = new System.Drawing.Point(489, 242);
            this.companyButton.Margin = new System.Windows.Forms.Padding(4);
            this.companyButton.Name = "companyButton";
            this.companyButton.Rounding = 50;
            this.companyButton.RoundingEnable = true;
            this.companyButton.Size = new System.Drawing.Size(256, 37);
            this.companyButton.TabIndex = 60;
            this.companyButton.Text = "COMPANY";
            this.companyButton.UseVisualStyleBackColor = false;
            this.companyButton.Click += new System.EventHandler(this.companyButton_Click);
            // 
            // blockButton
            // 
            this.blockButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.blockButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.blockButton.ForeColor = System.Drawing.Color.White;
            this.blockButton.Location = new System.Drawing.Point(489, 180);
            this.blockButton.Margin = new System.Windows.Forms.Padding(4);
            this.blockButton.Name = "blockButton";
            this.blockButton.Rounding = 50;
            this.blockButton.RoundingEnable = true;
            this.blockButton.Size = new System.Drawing.Size(256, 37);
            this.blockButton.TabIndex = 59;
            this.blockButton.Text = "BAN CARD";
            this.blockButton.UseVisualStyleBackColor = false;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.transferButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.transferButton.ForeColor = System.Drawing.Color.White;
            this.transferButton.Location = new System.Drawing.Point(489, 116);
            this.transferButton.Margin = new System.Windows.Forms.Padding(4);
            this.transferButton.Name = "transferButton";
            this.transferButton.Rounding = 50;
            this.transferButton.RoundingEnable = true;
            this.transferButton.Size = new System.Drawing.Size(256, 37);
            this.transferButton.TabIndex = 58;
            this.transferButton.Text = "TRANSFER";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // balanceButton
            // 
            this.balanceButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.balanceButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.balanceButton.ForeColor = System.Drawing.Color.White;
            this.balanceButton.Location = new System.Drawing.Point(16, 242);
            this.balanceButton.Margin = new System.Windows.Forms.Padding(4);
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.Rounding = 50;
            this.balanceButton.RoundingEnable = true;
            this.balanceButton.Size = new System.Drawing.Size(256, 37);
            this.balanceButton.TabIndex = 57;
            this.balanceButton.Text = "BALANCE";
            this.balanceButton.UseVisualStyleBackColor = false;
            this.balanceButton.Click += new System.EventHandler(this.balanceButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.withdrawButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.withdrawButton.ForeColor = System.Drawing.Color.White;
            this.withdrawButton.Location = new System.Drawing.Point(16, 180);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(4);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Rounding = 50;
            this.withdrawButton.RoundingEnable = true;
            this.withdrawButton.Size = new System.Drawing.Size(256, 37);
            this.withdrawButton.TabIndex = 56;
            this.withdrawButton.Text = "WITHDRAW";
            this.withdrawButton.UseVisualStyleBackColor = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.depositButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.depositButton.ForeColor = System.Drawing.Color.White;
            this.depositButton.Location = new System.Drawing.Point(16, 116);
            this.depositButton.Margin = new System.Windows.Forms.Padding(4);
            this.depositButton.Name = "depositButton";
            this.depositButton.Rounding = 50;
            this.depositButton.RoundingEnable = true;
            this.depositButton.Size = new System.Drawing.Size(256, 37);
            this.depositButton.TabIndex = 54;
            this.depositButton.Text = "DEPOSIT";
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // AccountInfoButton
            // 
            this.AccountInfoButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AccountInfoButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.AccountInfoButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AccountInfoButton.Location = new System.Drawing.Point(344, 155);
            this.AccountInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountInfoButton.Name = "AccountInfoButton";
            this.AccountInfoButton.Rounding = 10;
            this.AccountInfoButton.RoundingEnable = true;
            this.AccountInfoButton.Size = new System.Drawing.Size(72, 62);
            this.AccountInfoButton.TabIndex = 52;
            this.AccountInfoButton.Text = "ATM";
            this.AccountInfoButton.UseVisualStyleBackColor = false;
            this.AccountInfoButton.Click += new System.EventHandler(this.AccountInfoButton_Click);
            // 
            // ClientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(761, 336);
            this.Controls.Add(this.companyButton);
            this.Controls.Add(this.blockButton);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.balanceButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.AccountInfoButton);
            this.Controls.Add(this.AccNumLabel);
            this.Controls.Add(this.Logout_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.my_Button depositButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.my_Button withdrawButton;
        private System.Windows.Forms.my_Button balanceButton;
        private System.Windows.Forms.my_Button transferButton;
        private System.Windows.Forms.my_Button blockButton;
        private System.Windows.Forms.my_Button companyButton;
        private System.Windows.Forms.Timer banTimer;
    }
}