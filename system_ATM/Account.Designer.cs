
namespace system_ATM
{
    partial class Account
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
            this.label14 = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.atmLabel = new System.Windows.Forms.Label();
            this.accNumLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.educationLabel = new System.Windows.Forms.Label();
            this.OccupationLabel = new System.Windows.Forms.Label();
            this.dOfBLabel = new System.Windows.Forms.Label();
            this.AccNum_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.FName_TB = new System.Windows.Forms.TextBox();
            this.Address_TB = new System.Windows.Forms.TextBox();
            this.Phone_TB = new System.Windows.Forms.TextBox();
            this.Pin_TB = new System.Windows.Forms.TextBox();
            this.Education_TB = new System.Windows.Forms.ComboBox();
            this.Occupation_TB = new System.Windows.Forms.ComboBox();
            this.Dob_TB = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signUpButton = new System.Windows.Forms.my_Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.atmLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 89);
            this.panel1.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.MintCream;
            this.label14.Font = new System.Drawing.Font("Russo One", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Location = new System.Drawing.Point(383, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Sign up";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.exitLabel.Location = new System.Drawing.Point(809, 0);
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
            this.atmLabel.Location = new System.Drawing.Point(268, 9);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(296, 48);
            this.atmLabel.TabIndex = 0;
            this.atmLabel.Text = "A T M  S Y S T E M";
            // 
            // accNumLabel
            // 
            this.accNumLabel.AutoSize = true;
            this.accNumLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.accNumLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.accNumLabel.Location = new System.Drawing.Point(18, 108);
            this.accNumLabel.Name = "accNumLabel";
            this.accNumLabel.Size = new System.Drawing.Size(83, 19);
            this.accNumLabel.TabIndex = 16;
            this.accNumLabel.Text = "ACC NUM";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.nameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nameLabel.Location = new System.Drawing.Point(18, 162);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 19);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "NAME";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.fNameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fNameLabel.Location = new System.Drawing.Point(18, 221);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(66, 19);
            this.fNameLabel.TabIndex = 18;
            this.fNameLabel.Text = "FNAME";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.addressLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addressLabel.Location = new System.Drawing.Point(18, 283);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(88, 19);
            this.addressLabel.TabIndex = 19;
            this.addressLabel.Text = "ADDRESS";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.phoneLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.phoneLabel.Location = new System.Drawing.Point(498, 108);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(66, 19);
            this.phoneLabel.TabIndex = 20;
            this.phoneLabel.Text = "PHONE";
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.pinLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pinLabel.Location = new System.Drawing.Point(498, 159);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(39, 19);
            this.pinLabel.TabIndex = 21;
            this.pinLabel.Text = "PIN";
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.educationLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.educationLabel.Location = new System.Drawing.Point(498, 218);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(104, 19);
            this.educationLabel.TabIndex = 23;
            this.educationLabel.Text = "EDUCATION";
            // 
            // OccupationLabel
            // 
            this.OccupationLabel.AutoSize = true;
            this.OccupationLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.OccupationLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.OccupationLabel.Location = new System.Drawing.Point(498, 280);
            this.OccupationLabel.Name = "OccupationLabel";
            this.OccupationLabel.Size = new System.Drawing.Size(114, 19);
            this.OccupationLabel.TabIndex = 24;
            this.OccupationLabel.Text = "OCCUPATION";
            // 
            // dOfBLabel
            // 
            this.dOfBLabel.AutoSize = true;
            this.dOfBLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.dOfBLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dOfBLabel.Location = new System.Drawing.Point(498, 340);
            this.dOfBLabel.Name = "dOfBLabel";
            this.dOfBLabel.Size = new System.Drawing.Size(44, 19);
            this.dOfBLabel.TabIndex = 25;
            this.dOfBLabel.Text = "DOB";
            // 
            // AccNum_TB
            // 
            this.AccNum_TB.Font = new System.Drawing.Font("Russo One", 12F);
            this.AccNum_TB.Location = new System.Drawing.Point(127, 105);
            this.AccNum_TB.Name = "AccNum_TB";
            this.AccNum_TB.Size = new System.Drawing.Size(192, 27);
            this.AccNum_TB.TabIndex = 26;
            // 
            // Name_TB
            // 
            this.Name_TB.Font = new System.Drawing.Font("Russo One", 12F);
            this.Name_TB.Location = new System.Drawing.Point(127, 159);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(192, 27);
            this.Name_TB.TabIndex = 27;
            // 
            // FName_TB
            // 
            this.FName_TB.Font = new System.Drawing.Font("Russo One", 12F);
            this.FName_TB.Location = new System.Drawing.Point(127, 218);
            this.FName_TB.Name = "FName_TB";
            this.FName_TB.Size = new System.Drawing.Size(192, 27);
            this.FName_TB.TabIndex = 28;
            // 
            // Address_TB
            // 
            this.Address_TB.Font = new System.Drawing.Font("Russo One", 12F);
            this.Address_TB.Location = new System.Drawing.Point(127, 280);
            this.Address_TB.Multiline = true;
            this.Address_TB.Name = "Address_TB";
            this.Address_TB.Size = new System.Drawing.Size(192, 84);
            this.Address_TB.TabIndex = 29;
            // 
            // Phone_TB
            // 
            this.Phone_TB.Font = new System.Drawing.Font("Russo One", 12F);
            this.Phone_TB.Location = new System.Drawing.Point(629, 108);
            this.Phone_TB.Name = "Phone_TB";
            this.Phone_TB.Size = new System.Drawing.Size(192, 27);
            this.Phone_TB.TabIndex = 30;
            // 
            // Pin_TB
            // 
            this.Pin_TB.Font = new System.Drawing.Font("Russo One", 12F);
            this.Pin_TB.Location = new System.Drawing.Point(629, 156);
            this.Pin_TB.Name = "Pin_TB";
            this.Pin_TB.Size = new System.Drawing.Size(192, 27);
            this.Pin_TB.TabIndex = 31;
            // 
            // Education_TB
            // 
            this.Education_TB.Font = new System.Drawing.Font("Russo One", 12F);
            this.Education_TB.FormattingEnabled = true;
            this.Education_TB.Items.AddRange(new object[] {
            "NONE",
            "SCHOOL",
            "UNIVERSITY"});
            this.Education_TB.Location = new System.Drawing.Point(629, 219);
            this.Education_TB.Name = "Education_TB";
            this.Education_TB.Size = new System.Drawing.Size(192, 27);
            this.Education_TB.TabIndex = 34;
            // 
            // Occupation_TB
            // 
            this.Occupation_TB.Font = new System.Drawing.Font("Russo One", 12F);
            this.Occupation_TB.FormattingEnabled = true;
            this.Occupation_TB.Items.AddRange(new object[] {
            "NONE",
            "EMPLOYEE",
            "SELF-EMPLOYMENT",
            "RETIRED"});
            this.Occupation_TB.Location = new System.Drawing.Point(629, 277);
            this.Occupation_TB.Name = "Occupation_TB";
            this.Occupation_TB.Size = new System.Drawing.Size(192, 27);
            this.Occupation_TB.TabIndex = 35;
            // 
            // Dob_TB
            // 
            this.Dob_TB.Font = new System.Drawing.Font("Russo One", 12F);
            this.Dob_TB.Location = new System.Drawing.Point(629, 337);
            this.Dob_TB.Name = "Dob_TB";
            this.Dob_TB.Size = new System.Drawing.Size(192, 27);
            this.Dob_TB.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 11);
            this.panel2.TabIndex = 37;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.backLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.backLabel.Location = new System.Drawing.Point(382, 425);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(52, 19);
            this.backLabel.TabIndex = 40;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::system_ATM.Properties.Resources.atm_machine_finance_cash_withdraw_money_icon_153132;
            this.pictureBox1.Location = new System.Drawing.Point(340, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(314, 382);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Rounding = 50;
            this.signUpButton.RoundingEnable = true;
            this.signUpButton.Size = new System.Drawing.Size(190, 40);
            this.signUpButton.TabIndex = 39;
            this.signUpButton.Text = "SIGN UP";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 463);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Dob_TB);
            this.Controls.Add(this.Occupation_TB);
            this.Controls.Add(this.Education_TB);
            this.Controls.Add(this.Pin_TB);
            this.Controls.Add(this.Phone_TB);
            this.Controls.Add(this.Address_TB);
            this.Controls.Add(this.FName_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.AccNum_TB);
            this.Controls.Add(this.dOfBLabel);
            this.Controls.Add(this.OccupationLabel);
            this.Controls.Add(this.educationLabel);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.accNumLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
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
        private System.Windows.Forms.Label accNumLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.Label OccupationLabel;
        private System.Windows.Forms.Label dOfBLabel;
        private System.Windows.Forms.TextBox AccNum_TB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox FName_TB;
        private System.Windows.Forms.TextBox Address_TB;
        private System.Windows.Forms.TextBox Phone_TB;
        private System.Windows.Forms.TextBox Pin_TB;
        private System.Windows.Forms.ComboBox Education_TB;
        private System.Windows.Forms.ComboBox Occupation_TB;
        private System.Windows.Forms.DateTimePicker Dob_TB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.my_Button signUpButton;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label label14;
    }
}