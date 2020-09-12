using PlayerPlusPlus.Core;
using Subtitles_Tools;

namespace PlayerPlusPlus
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.ucPlayer1 = new  UCPlayer();
            this.SuspendLayout();
            // 
            // ucPlayer1
            // 
            this.ucPlayer1.BackColor = System.Drawing.Color.White;
            this.ucPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlayer1.FilePath = null;
            this.ucPlayer1.Location = new System.Drawing.Point(0, 0);
            this.ucPlayer1.Name = "ucPlayer1";
            this.ucPlayer1.OnEdit = false;
            this.ucPlayer1.OnFullScreen = false;
            this.ucPlayer1.ShowControls = true;
            this.ucPlayer1.Size = new System.Drawing.Size(800, 450);
            this.ucPlayer1.TabIndex = 0;
            this.ucPlayer1.TotalTime = "00:00:00,000";
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Player";
            this.Text = "Player++";
            this.ResumeLayout(false);

        }

        #endregion

        private UCPlayer ucPlayer1;
    }
}