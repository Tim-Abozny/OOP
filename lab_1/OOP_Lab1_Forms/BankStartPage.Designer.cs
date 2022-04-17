
namespace OOP_Lab1_Forms
{
    partial class BankStartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankStartPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.atmLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.forestBankPicture = new System.Windows.Forms.PictureBox();
            this.bsuirBankPicture = new System.Windows.Forms.PictureBox();
            this.betaBankPicture = new System.Windows.Forms.PictureBox();
            this.bsuirBankLabel = new System.Windows.Forms.Label();
            this.betaBankLabel = new System.Windows.Forms.Label();
            this.forestBankLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forestBankPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsuirBankPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaBankPicture)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(433, 89);
            this.panel1.TabIndex = 16;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLabel.Location = new System.Drawing.Point(405, 0);
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
            this.atmLabel.Location = new System.Drawing.Point(56, 22);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(327, 48);
            this.atmLabel.TabIndex = 0;
            this.atmLabel.Text = "B A N K  S Y S T E M";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 11);
            this.panel2.TabIndex = 50;
            // 
            // forestBankPicture
            // 
            this.forestBankPicture.Image = global::OOP_Lab1_Forms.Properties.Resources.bank_icon_129219;
            this.forestBankPicture.Location = new System.Drawing.Point(301, 123);
            this.forestBankPicture.Name = "forestBankPicture";
            this.forestBankPicture.Size = new System.Drawing.Size(131, 130);
            this.forestBankPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forestBankPicture.TabIndex = 19;
            this.forestBankPicture.TabStop = false;
            this.forestBankPicture.Click += new System.EventHandler(this.forestBankPicture_Click);
            this.forestBankPicture.MouseLeave += new System.EventHandler(this.forestBankPicture_MouseLeave);
            this.forestBankPicture.MouseHover += new System.EventHandler(this.forestBankPicture_MouseHover);
            // 
            // bsuirBankPicture
            // 
            this.bsuirBankPicture.Image = global::OOP_Lab1_Forms.Properties.Resources.bank_icon_129525;
            this.bsuirBankPicture.Location = new System.Drawing.Point(0, 123);
            this.bsuirBankPicture.Name = "bsuirBankPicture";
            this.bsuirBankPicture.Size = new System.Drawing.Size(131, 130);
            this.bsuirBankPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bsuirBankPicture.TabIndex = 18;
            this.bsuirBankPicture.TabStop = false;
            this.bsuirBankPicture.Click += new System.EventHandler(this.bsuirBankPicture_Click);
            this.bsuirBankPicture.MouseLeave += new System.EventHandler(this.bsuirBankPicture_MouseLeave);
            this.bsuirBankPicture.MouseHover += new System.EventHandler(this.bsuirBankPicture_MouseHover);
            // 
            // betaBankPicture
            // 
            this.betaBankPicture.Image = global::OOP_Lab1_Forms.Properties.Resources.bank_88995;
            this.betaBankPicture.Location = new System.Drawing.Point(153, 123);
            this.betaBankPicture.Name = "betaBankPicture";
            this.betaBankPicture.Size = new System.Drawing.Size(131, 130);
            this.betaBankPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.betaBankPicture.TabIndex = 17;
            this.betaBankPicture.TabStop = false;
            this.betaBankPicture.Click += new System.EventHandler(this.betaBankPicture_Click);
            this.betaBankPicture.MouseLeave += new System.EventHandler(this.betaBankPicture_MouseLeave);
            this.betaBankPicture.MouseHover += new System.EventHandler(this.betaBankPicture_MouseHover);
            // 
            // bsuirBankLabel
            // 
            this.bsuirBankLabel.AutoSize = true;
            this.bsuirBankLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.bsuirBankLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bsuirBankLabel.Location = new System.Drawing.Point(5, 101);
            this.bsuirBankLabel.Name = "bsuirBankLabel";
            this.bsuirBankLabel.Size = new System.Drawing.Size(112, 19);
            this.bsuirBankLabel.TabIndex = 51;
            this.bsuirBankLabel.Text = "BSUIR BANK";
            // 
            // betaBankLabel
            // 
            this.betaBankLabel.AutoSize = true;
            this.betaBankLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.betaBankLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.betaBankLabel.Location = new System.Drawing.Point(169, 110);
            this.betaBankLabel.Name = "betaBankLabel";
            this.betaBankLabel.Size = new System.Drawing.Size(100, 19);
            this.betaBankLabel.TabIndex = 52;
            this.betaBankLabel.Text = "BETA BANK";
            // 
            // forestBankLabel
            // 
            this.forestBankLabel.AutoSize = true;
            this.forestBankLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.forestBankLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.forestBankLabel.Location = new System.Drawing.Point(300, 101);
            this.forestBankLabel.Name = "forestBankLabel";
            this.forestBankLabel.Size = new System.Drawing.Size(123, 19);
            this.forestBankLabel.TabIndex = 53;
            this.forestBankLabel.Text = "FOREST BANK";
            // 
            // BankStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(433, 274);
            this.Controls.Add(this.forestBankLabel);
            this.Controls.Add(this.betaBankLabel);
            this.Controls.Add(this.bsuirBankLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.forestBankPicture);
            this.Controls.Add(this.bsuirBankPicture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.betaBankPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankStartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankStartPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forestBankPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsuirBankPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaBankPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label atmLabel;
        private System.Windows.Forms.PictureBox betaBankPicture;
        private System.Windows.Forms.PictureBox bsuirBankPicture;
        private System.Windows.Forms.PictureBox forestBankPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label bsuirBankLabel;
        private System.Windows.Forms.Label betaBankLabel;
        private System.Windows.Forms.Label forestBankLabel;
    }
}