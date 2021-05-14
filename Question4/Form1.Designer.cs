
namespace Question4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMarkHeading = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.btnNextMark = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMarkHeading
            // 
            this.lblMarkHeading.AutoSize = true;
            this.lblMarkHeading.Location = new System.Drawing.Point(12, 47);
            this.lblMarkHeading.Name = "lblMarkHeading";
            this.lblMarkHeading.Size = new System.Drawing.Size(155, 20);
            this.lblMarkHeading.TabIndex = 0;
            this.lblMarkHeading.Text = "Individual Assignment";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(13, 89);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(154, 27);
            this.txtMark.TabIndex = 2;
            // 
            // btnNextMark
            // 
            this.btnNextMark.Location = new System.Drawing.Point(13, 137);
            this.btnNextMark.Name = "btnNextMark";
            this.btnNextMark.Size = new System.Drawing.Size(154, 29);
            this.btnNextMark.TabIndex = 3;
            this.btnNextMark.Text = "Next Mark";
            this.btnNextMark.UseVisualStyleBackColor = true;
            this.btnNextMark.Click += new System.EventHandler(this.btnNextMark_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(196, 316);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(500, 35);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Display Results :";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(191, 81);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(493, 216);
            this.txtResults.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNextMark);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.lblMarkHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarkHeading;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Button btnNextMark;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResults;
    }
}

