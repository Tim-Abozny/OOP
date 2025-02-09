﻿
namespace OOP_Lab1_Forms
{
    partial class MessageRect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageRect));
            this.exitButton = new System.Windows.Forms.my_Button();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.exitButton.Font = new System.Drawing.Font("Russo One", 12F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(0, 138);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rounding = 50;
            this.exitButton.RoundingEnable = false;
            this.exitButton.Size = new System.Drawing.Size(52, 32);
            this.exitButton.TabIndex = 55;
            this.exitButton.Text = "OK";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exceptionLabel.Font = new System.Drawing.Font("Russo One", 12F);
            this.exceptionLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.exceptionLabel.Location = new System.Drawing.Point(0, 0);
            this.exceptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(112, 25);
            this.exceptionLabel.TabIndex = 85;
            this.exceptionLabel.Text = "exception";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exceptionLabel);
            this.panel1.Location = new System.Drawing.Point(4, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 30);
            this.panel1.TabIndex = 86;
            // 
            // MessageRect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(951, 170);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MessageRect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageRect";
            this.Load += new System.EventHandler(this.MessageRect_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.my_Button exitButton;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.Panel panel1;
    }
}