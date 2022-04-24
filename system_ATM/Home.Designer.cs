
namespace system_ATM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.atmLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.AccNumLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoButton = new System.Windows.Forms.my_Button();
            this.balanceButton = new System.Windows.Forms.my_Button();
            this.operationsButton = new System.Windows.Forms.my_Button();
            this.withdrawButton = new System.Windows.Forms.my_Button();
            this.changePinButton = new System.Windows.Forms.my_Button();
            this.fastCashButton = new System.Windows.Forms.my_Button();
            this.depositButton = new System.Windows.Forms.my_Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.atmLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 89);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Font = new System.Drawing.Font("Russo One", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(275, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Home";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.exitLabel.Location = new System.Drawing.Point(551, 0);
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
            this.atmLabel.Location = new System.Drawing.Point(69, 20);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(460, 48);
            this.atmLabel.TabIndex = 0;
            this.atmLabel.Text = "SELECT YOUR OPERATION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 11);
            this.panel2.TabIndex = 14;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.logoutLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.logoutLabel.Location = new System.Drawing.Point(258, 313);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(76, 19);
            this.logoutLabel.TabIndex = 15;
            this.logoutLabel.Text = "LOGOUT";
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click);
            // 
            // AccNumLabel
            // 
            this.AccNumLabel.AutoSize = true;
            this.AccNumLabel.BackColor = System.Drawing.Color.Lavender;
            this.AccNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccNumLabel.Font = new System.Drawing.Font("Russo One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccNumLabel.ForeColor = System.Drawing.Color.Navy;
            this.AccNumLabel.Location = new System.Drawing.Point(278, 145);
            this.AccNumLabel.Name = "AccNumLabel";
            this.AccNumLabel.Size = new System.Drawing.Size(41, 16);
            this.AccNumLabel.TabIndex = 46;
            this.AccNumLabel.Text = "0000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::system_ATM.Properties.Resources.atm_machine_finance_cash_withdraw_money_icon_153132;
            this.pictureBox1.Location = new System.Drawing.Point(229, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.infoButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.infoButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.infoButton.Location = new System.Drawing.Point(268, 182);
            this.infoButton.Margin = new System.Windows.Forms.Padding(2);
            this.infoButton.Name = "infoButton";
            this.infoButton.Rounding = 10;
            this.infoButton.RoundingEnable = true;
            this.infoButton.Size = new System.Drawing.Size(54, 50);
            this.infoButton.TabIndex = 47;
            this.infoButton.Text = "ATM";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // balanceButton
            // 
            this.balanceButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.balanceButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.balanceButton.ForeColor = System.Drawing.Color.White;
            this.balanceButton.Location = new System.Drawing.Point(376, 262);
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.Rounding = 50;
            this.balanceButton.RoundingEnable = true;
            this.balanceButton.Size = new System.Drawing.Size(190, 40);
            this.balanceButton.TabIndex = 12;
            this.balanceButton.Text = "BALANCE";
            this.balanceButton.UseVisualStyleBackColor = false;
            this.balanceButton.Click += new System.EventHandler(this.balanceButton_Click);
            // 
            // operationsButton
            // 
            this.operationsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.operationsButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.operationsButton.ForeColor = System.Drawing.Color.White;
            this.operationsButton.Location = new System.Drawing.Point(376, 192);
            this.operationsButton.Name = "operationsButton";
            this.operationsButton.Rounding = 50;
            this.operationsButton.RoundingEnable = true;
            this.operationsButton.Size = new System.Drawing.Size(190, 40);
            this.operationsButton.TabIndex = 11;
            this.operationsButton.Text = "OPERATIONS";
            this.operationsButton.UseVisualStyleBackColor = false;
            this.operationsButton.Click += new System.EventHandler(this.operationsButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdrawButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.withdrawButton.ForeColor = System.Drawing.Color.White;
            this.withdrawButton.Location = new System.Drawing.Point(376, 121);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Rounding = 50;
            this.withdrawButton.RoundingEnable = true;
            this.withdrawButton.Size = new System.Drawing.Size(190, 40);
            this.withdrawButton.TabIndex = 10;
            this.withdrawButton.Text = "WITHDRAW";
            this.withdrawButton.UseVisualStyleBackColor = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // changePinButton
            // 
            this.changePinButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.changePinButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.changePinButton.ForeColor = System.Drawing.Color.White;
            this.changePinButton.Location = new System.Drawing.Point(12, 262);
            this.changePinButton.Name = "changePinButton";
            this.changePinButton.Rounding = 50;
            this.changePinButton.RoundingEnable = true;
            this.changePinButton.Size = new System.Drawing.Size(190, 40);
            this.changePinButton.TabIndex = 9;
            this.changePinButton.Text = "CHANGE PIN";
            this.changePinButton.UseVisualStyleBackColor = false;
            this.changePinButton.Click += new System.EventHandler(this.changePinButton_Click);
            // 
            // fastCashButton
            // 
            this.fastCashButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.fastCashButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.fastCashButton.ForeColor = System.Drawing.Color.White;
            this.fastCashButton.Location = new System.Drawing.Point(12, 192);
            this.fastCashButton.Name = "fastCashButton";
            this.fastCashButton.Rounding = 50;
            this.fastCashButton.RoundingEnable = true;
            this.fastCashButton.Size = new System.Drawing.Size(190, 40);
            this.fastCashButton.TabIndex = 8;
            this.fastCashButton.Text = "FAST CASH";
            this.fastCashButton.UseVisualStyleBackColor = false;
            this.fastCashButton.Click += new System.EventHandler(this.fastCashButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.depositButton.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.ForeColor = System.Drawing.Color.White;
            this.depositButton.Location = new System.Drawing.Point(12, 121);
            this.depositButton.Name = "depositButton";
            this.depositButton.Rounding = 50;
            this.depositButton.RoundingEnable = true;
            this.depositButton.Size = new System.Drawing.Size(190, 40);
            this.depositButton.TabIndex = 7;
            this.depositButton.Text = "DEPOSIT";
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 346);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.AccNumLabel);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.balanceButton);
            this.Controls.Add(this.operationsButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.changePinButton);
            this.Controls.Add(this.fastCashButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label atmLabel;
        private System.Windows.Forms.my_Button depositButton;
        private System.Windows.Forms.my_Button fastCashButton;
        private System.Windows.Forms.my_Button changePinButton;
        private System.Windows.Forms.my_Button withdrawButton;
        private System.Windows.Forms.my_Button operationsButton;
        private System.Windows.Forms.my_Button balanceButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AccNumLabel;
        private System.Windows.Forms.my_Button infoButton;
    }
}