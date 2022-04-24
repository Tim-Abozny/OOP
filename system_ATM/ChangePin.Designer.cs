
namespace system_ATM
{
    partial class ChangePin
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
            this.backLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.newPinLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.my_Button();
            this.ConfirmPinTB = new System.Windows.Forms.TextBox();
            this.NewPinTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(370, 89);
            this.panel1.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Font = new System.Drawing.Font("Russo One", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(163, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Pincode";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.exitLabel.Location = new System.Drawing.Point(343, 0);
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
            this.atmLabel.Location = new System.Drawing.Point(50, 22);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(296, 48);
            this.atmLabel.TabIndex = 0;
            this.atmLabel.Text = "A T M  S Y S T E M";
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.backLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.backLabel.Location = new System.Drawing.Point(162, 257);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(52, 19);
            this.backLabel.TabIndex = 49;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 11);
            this.panel2.TabIndex = 48;
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.confirmLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.confirmLabel.Location = new System.Drawing.Point(25, 169);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(125, 19);
            this.confirmLabel.TabIndex = 45;
            this.confirmLabel.Text = "CONFIRM PIN:";
            // 
            // newPinLabel
            // 
            this.newPinLabel.AutoSize = true;
            this.newPinLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.newPinLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.newPinLabel.Location = new System.Drawing.Point(25, 111);
            this.newPinLabel.Name = "newPinLabel";
            this.newPinLabel.Size = new System.Drawing.Size(86, 19);
            this.newPinLabel.TabIndex = 44;
            this.newPinLabel.Text = "NEW PIN:";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.changeButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(166, 210);
            this.changeButton.Name = "changeButton";
            this.changeButton.Rounding = 50;
            this.changeButton.RoundingEnable = true;
            this.changeButton.Size = new System.Drawing.Size(192, 30);
            this.changeButton.TabIndex = 52;
            this.changeButton.Text = "CHANGE";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // ConfirmPinTB
            // 
            this.ConfirmPinTB.Font = new System.Drawing.Font("Russo One", 16F);
            this.ConfirmPinTB.Location = new System.Drawing.Point(166, 162);
            this.ConfirmPinTB.Name = "ConfirmPinTB";
            this.ConfirmPinTB.Size = new System.Drawing.Size(192, 33);
            this.ConfirmPinTB.TabIndex = 51;
            // 
            // NewPinTB
            // 
            this.NewPinTB.Font = new System.Drawing.Font("Russo One", 16F);
            this.NewPinTB.Location = new System.Drawing.Point(166, 104);
            this.NewPinTB.Name = "NewPinTB";
            this.NewPinTB.Size = new System.Drawing.Size(192, 33);
            this.NewPinTB.TabIndex = 50;
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 290);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.ConfirmPinTB);
            this.Controls.Add(this.NewPinTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.newPinLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label atmLabel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label newPinLabel;
        private System.Windows.Forms.my_Button changeButton;
        private System.Windows.Forms.TextBox ConfirmPinTB;
        private System.Windows.Forms.TextBox NewPinTB;
        private System.Windows.Forms.Label label7;
    }
}