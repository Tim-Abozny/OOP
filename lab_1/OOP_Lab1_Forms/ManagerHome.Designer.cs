
namespace OOP_Lab1_Forms
{
    partial class ManagerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salaryButton = new System.Windows.Forms.my_Button();
            this.installmentButton = new System.Windows.Forms.my_Button();
            this.backButton = new System.Windows.Forms.my_Button();
            this.creditButton = new System.Windows.Forms.my_Button();
            this.requestsListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 89);
            this.panel1.TabIndex = 66;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Maroon;
            this.exitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.Azure;
            this.exitLabel.Location = new System.Drawing.Point(437, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(29, 28);
            this.exitLabel.TabIndex = 8;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sigmar One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "B A N K  S Y S T E M";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 11);
            this.panel2.TabIndex = 73;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_Lab1_Forms.Properties.Resources.atm_icon_31876;
            this.pictureBox1.Location = new System.Drawing.Point(335, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Russo One", 12F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(368, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "REQUESTS";
            // 
            // salaryButton
            // 
            this.salaryButton.BackColor = System.Drawing.Color.Maroon;
            this.salaryButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.salaryButton.ForeColor = System.Drawing.Color.White;
            this.salaryButton.Location = new System.Drawing.Point(255, 95);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Rounding = 50;
            this.salaryButton.RoundingEnable = true;
            this.salaryButton.Size = new System.Drawing.Size(74, 30);
            this.salaryButton.TabIndex = 76;
            this.salaryButton.Text = "SALARY";
            this.salaryButton.UseVisualStyleBackColor = false;
            this.salaryButton.Click += new System.EventHandler(this.salaryButton_Click);
            // 
            // installmentButton
            // 
            this.installmentButton.BackColor = System.Drawing.Color.Maroon;
            this.installmentButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.installmentButton.ForeColor = System.Drawing.Color.White;
            this.installmentButton.Location = new System.Drawing.Point(103, 95);
            this.installmentButton.Name = "installmentButton";
            this.installmentButton.Rounding = 50;
            this.installmentButton.RoundingEnable = true;
            this.installmentButton.Size = new System.Drawing.Size(136, 30);
            this.installmentButton.TabIndex = 75;
            this.installmentButton.Text = "INSTALLMENTS";
            this.installmentButton.UseVisualStyleBackColor = false;
            this.installmentButton.Click += new System.EventHandler(this.installmentButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Maroon;
            this.backButton.Font = new System.Drawing.Font("Russo One", 8F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(368, 249);
            this.backButton.Name = "backButton";
            this.backButton.Rounding = 50;
            this.backButton.RoundingEnable = true;
            this.backButton.Size = new System.Drawing.Size(68, 30);
            this.backButton.TabIndex = 74;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // creditButton
            // 
            this.creditButton.BackColor = System.Drawing.Color.Maroon;
            this.creditButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.creditButton.ForeColor = System.Drawing.Color.White;
            this.creditButton.Location = new System.Drawing.Point(12, 95);
            this.creditButton.Name = "creditButton";
            this.creditButton.Rounding = 50;
            this.creditButton.RoundingEnable = true;
            this.creditButton.Size = new System.Drawing.Size(74, 30);
            this.creditButton.TabIndex = 72;
            this.creditButton.Text = "CREDIT";
            this.creditButton.UseVisualStyleBackColor = false;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // requestsListBox
            // 
            this.requestsListBox.BackColor = System.Drawing.Color.IndianRed;
            this.requestsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestsListBox.Font = new System.Drawing.Font("Russo One", 12F);
            this.requestsListBox.ForeColor = System.Drawing.Color.Maroon;
            this.requestsListBox.FormattingEnabled = true;
            this.requestsListBox.ItemHeight = 19;
            this.requestsListBox.Location = new System.Drawing.Point(12, 131);
            this.requestsListBox.Name = "requestsListBox";
            this.requestsListBox.Size = new System.Drawing.Size(310, 133);
            this.requestsListBox.TabIndex = 77;
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(466, 297);
            this.Controls.Add(this.requestsListBox);
            this.Controls.Add(this.salaryButton);
            this.Controls.Add(this.installmentButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.my_Button backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.my_Button creditButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.my_Button installmentButton;
        private System.Windows.Forms.my_Button salaryButton;
        private System.Windows.Forms.ListBox requestsListBox;
    }
}