﻿
namespace OOP_Lab1_Forms
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BalanceNumLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransferTB = new System.Windows.Forms.TextBox();
            this.backLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.transferButton = new System.Windows.Forms.my_Button();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientsListBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 110);
            this.panel1.TabIndex = 85;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Azure;
            this.exitLabel.Font = new System.Drawing.Font("Sigmar One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitLabel.Location = new System.Drawing.Point(491, 0);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(33, 33);
            this.exitLabel.TabIndex = 8;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sigmar One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "B A N K  S Y S T E M";
            // 
            // BalanceNumLabel
            // 
            this.BalanceNumLabel.AutoSize = true;
            this.BalanceNumLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.BalanceNumLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BalanceNumLabel.Location = new System.Drawing.Point(285, 132);
            this.BalanceNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceNumLabel.Name = "BalanceNumLabel";
            this.BalanceNumLabel.Size = new System.Drawing.Size(140, 25);
            this.BalanceNumLabel.TabIndex = 84;
            this.BalanceNumLabel.Text = "BalanceNum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 12F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "AVAILABLE BALANCE:";
            // 
            // TransferTB
            // 
            this.TransferTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.TransferTB.Font = new System.Drawing.Font("Russo One", 16F);
            this.TransferTB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TransferTB.Location = new System.Drawing.Point(261, 224);
            this.TransferTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TransferTB.Name = "TransferTB";
            this.TransferTB.Size = new System.Drawing.Size(255, 40);
            this.TransferTB.TabIndex = 81;
            this.TransferTB.TextChanged += new System.EventHandler(this.TransferTB_TextChanged);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.backLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.backLabel.Location = new System.Drawing.Point(233, 399);
            this.backLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(66, 25);
            this.backLabel.TabIndex = 80;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 14);
            this.panel2.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Russo One", 12F);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(39, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 78;
            this.label4.Text = "AMOUNT:";
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.transferButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.transferButton.ForeColor = System.Drawing.Color.White;
            this.transferButton.Location = new System.Drawing.Point(261, 338);
            this.transferButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transferButton.Name = "transferButton";
            this.transferButton.Rounding = 50;
            this.transferButton.RoundingEnable = true;
            this.transferButton.Size = new System.Drawing.Size(256, 37);
            this.transferButton.TabIndex = 82;
            this.transferButton.Text = "TRANSFER";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // ResultTB
            // 
            this.ResultTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ResultTB.Font = new System.Drawing.Font("Russo One", 16F);
            this.ResultTB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ResultTB.Location = new System.Drawing.Point(261, 272);
            this.ResultTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.ReadOnly = true;
            this.ResultTB.Size = new System.Drawing.Size(255, 40);
            this.ResultTB.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 12F);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(39, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 86;
            this.label3.Text = "RESULT (%):";
            // 
            // clientsListBox
            // 
            this.clientsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.clientsListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientsListBox.Font = new System.Drawing.Font("Russo One", 12F);
            this.clientsListBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.Location = new System.Drawing.Point(261, 167);
            this.clientsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(255, 33);
            this.clientsListBox.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Russo One", 12F);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(39, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "TRANSFER TO:";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(528, 439);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clientsListBox);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BalanceNumLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransferTB);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transferButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BalanceNumLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TransferTB;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.my_Button transferButton;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox clientsListBox;
        private System.Windows.Forms.Label label5;
    }
}