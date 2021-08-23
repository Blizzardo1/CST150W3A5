using System.Drawing;
using System.Windows.Forms;

namespace CST150W3A5 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTxt
            // 
            this.outputTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTxt.Location = new System.Drawing.Point(9, 12);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.Size = new System.Drawing.Size(782, 250);
            this.outputTxt.TabIndex = 0;
            // 
            // openBtn
            // 
            this.openBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openBtn.Location = new System.Drawing.Point(9, 266);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Open...";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.openBtn);
            this.Name = "Form1";
            this.Text = "Week 3 Assignment 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox outputTxt;
        private Button openBtn;
    }
}