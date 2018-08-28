namespace Subtitles_Tools
{
    partial class Help_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help_Info));
            this.BtnFaceBook = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnWebsite = new System.Windows.Forms.PictureBox();
            this.BtnGithub = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFaceBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnWebsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFaceBook
            // 
            this.BtnFaceBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFaceBook.Image = global::Subtitles_Tools.Properties.Resources.Facebook;
            this.BtnFaceBook.Location = new System.Drawing.Point(3, 246);
            this.BtnFaceBook.Name = "BtnFaceBook";
            this.BtnFaceBook.Size = new System.Drawing.Size(67, 66);
            this.BtnFaceBook.TabIndex = 2;
            this.BtnFaceBook.TabStop = false;
            this.BtnFaceBook.Click += new System.EventHandler(this.BtnFaceBook_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Subtitles_Tools.Properties.Resources.Logo1_;
            this.pictureBox1.Location = new System.Drawing.Point(4, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnWebsite
            // 
            this.BtnWebsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWebsite.Image = global::Subtitles_Tools.Properties.Resources.Website;
            this.BtnWebsite.Location = new System.Drawing.Point(76, 246);
            this.BtnWebsite.Name = "BtnWebsite";
            this.BtnWebsite.Size = new System.Drawing.Size(67, 66);
            this.BtnWebsite.TabIndex = 3;
            this.BtnWebsite.TabStop = false;
            this.BtnWebsite.Click += new System.EventHandler(this.BtnWebsite_Click);
            // 
            // BtnGithub
            // 
            this.BtnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGithub.Image = global::Subtitles_Tools.Properties.Resources.Github;
            this.BtnGithub.Location = new System.Drawing.Point(149, 246);
            this.BtnGithub.Name = "BtnGithub";
            this.BtnGithub.Size = new System.Drawing.Size(67, 66);
            this.BtnGithub.TabIndex = 4;
            this.BtnGithub.TabStop = false;
            this.BtnGithub.Click += new System.EventHandler(this.BtnGithub_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 312);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Help_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGithub);
            this.Controls.Add(this.BtnWebsite);
            this.Controls.Add(this.BtnFaceBook);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help And Info";
            ((System.ComponentModel.ISupportInitialize)(this.BtnFaceBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnWebsite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGithub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BtnFaceBook;
        private System.Windows.Forms.PictureBox BtnWebsite;
        private System.Windows.Forms.PictureBox BtnGithub;
        private System.Windows.Forms.Label label1;
    }
}