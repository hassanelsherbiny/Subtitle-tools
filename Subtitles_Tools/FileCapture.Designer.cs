namespace Subtitles_Tools
{
    partial class FileCapture
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FileCapture_BtnCapture = new System.Windows.Forms.Button();
            this.FileCapture_TxtPath = new System.Windows.Forms.TextBox();
            this.FileCapture_BtnBrowse = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FileCapture_BtnCapture);
            this.groupBox2.Controls.Add(this.FileCapture_TxtPath);
            this.groupBox2.Controls.Add(this.FileCapture_BtnBrowse);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 99);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Capture";
            // 
            // FileCapture_BtnCapture
            // 
            this.FileCapture_BtnCapture.Location = new System.Drawing.Point(6, 66);
            this.FileCapture_BtnCapture.Name = "FileCapture_BtnCapture";
            this.FileCapture_BtnCapture.Size = new System.Drawing.Size(270, 23);
            this.FileCapture_BtnCapture.TabIndex = 12;
            this.FileCapture_BtnCapture.Text = "Capture";
            this.FileCapture_BtnCapture.UseVisualStyleBackColor = true;
            this.FileCapture_BtnCapture.Click += new System.EventHandler(this.FileCapture_BtnCapture_Click);
            // 
            // FileCapture_TxtPath
            // 
            this.FileCapture_TxtPath.Location = new System.Drawing.Point(6, 20);
            this.FileCapture_TxtPath.Name = "FileCapture_TxtPath";
            this.FileCapture_TxtPath.Size = new System.Drawing.Size(189, 20);
            this.FileCapture_TxtPath.TabIndex = 13;
            // 
            // FileCapture_BtnBrowse
            // 
            this.FileCapture_BtnBrowse.Location = new System.Drawing.Point(201, 18);
            this.FileCapture_BtnBrowse.Name = "FileCapture_BtnBrowse";
            this.FileCapture_BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.FileCapture_BtnBrowse.TabIndex = 12;
            this.FileCapture_BtnBrowse.Text = "Browse";
            this.FileCapture_BtnBrowse.UseVisualStyleBackColor = true;
            this.FileCapture_BtnBrowse.Click += new System.EventHandler(this.FileCapture_BtnBrowse_Click);
            // 
            // FileCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 124);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileCapture";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulk File Capture";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FileCapture_BtnCapture;
        private System.Windows.Forms.TextBox FileCapture_TxtPath;
        private System.Windows.Forms.Button FileCapture_BtnBrowse;
    }
}