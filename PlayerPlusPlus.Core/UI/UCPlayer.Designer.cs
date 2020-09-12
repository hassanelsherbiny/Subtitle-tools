namespace PlayerPlusPlus.Core
{
    partial class UCPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayerPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.ControlPnl = new System.Windows.Forms.Panel();
            this.ButtonsPnl = new System.Windows.Forms.Panel();
            this.BtnEditSubtitle = new System.Windows.Forms.Button();
            this.BtnFullScreen = new System.Windows.Forms.Button();
            this.BtnPlayPause = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnSeekNext = new System.Windows.Forms.Button();
            this.BtnPreviousFile = new System.Windows.Forms.Button();
            this.BtnNextFile = new System.Windows.Forms.Button();
            this.BtnSeekBack = new System.Windows.Forms.Button();
            this.LblTime = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.ControlPnl.SuspendLayout();
            this.ButtonsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PlayerPnl);
            this.panel1.Controls.Add(this.ControlPnl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 414);
            this.panel1.TabIndex = 0;
            // 
            // PlayerPnl
            // 
            this.PlayerPnl.BackColor = System.Drawing.Color.Black;
            this.PlayerPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerPnl.Location = new System.Drawing.Point(0, 0);
            this.PlayerPnl.Name = "PlayerPnl";
            this.PlayerPnl.Size = new System.Drawing.Size(584, 366);
            this.PlayerPnl.TabIndex = 13;
            // 
            // ControlPnl
            // 
            this.ControlPnl.BackColor = System.Drawing.Color.Transparent;
            this.ControlPnl.Controls.Add(this.ButtonsPnl);
            this.ControlPnl.Controls.Add(this.LblTime);
            this.ControlPnl.Controls.Add(this.trackBar);
            this.ControlPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPnl.Location = new System.Drawing.Point(0, 366);
            this.ControlPnl.Name = "ControlPnl";
            this.ControlPnl.Size = new System.Drawing.Size(584, 48);
            this.ControlPnl.TabIndex = 12;
            this.ControlPnl.SizeChanged += new System.EventHandler(this.ControlPnl_SizeChanged);
            // 
            // ButtonsPnl
            // 
            this.ButtonsPnl.Controls.Add(this.BtnEditSubtitle);
            this.ButtonsPnl.Controls.Add(this.BtnFullScreen);
            this.ButtonsPnl.Controls.Add(this.BtnPlayPause);
            this.ButtonsPnl.Controls.Add(this.BtnStop);
            this.ButtonsPnl.Controls.Add(this.BtnSeekNext);
            this.ButtonsPnl.Controls.Add(this.BtnPreviousFile);
            this.ButtonsPnl.Controls.Add(this.BtnNextFile);
            this.ButtonsPnl.Controls.Add(this.BtnSeekBack);
            this.ButtonsPnl.Location = new System.Drawing.Point(201, 16);
            this.ButtonsPnl.Name = "ButtonsPnl";
            this.ButtonsPnl.Size = new System.Drawing.Size(232, 29);
            this.ButtonsPnl.TabIndex = 22;
            // 
            // BtnEditSubtitle
            // 
            this.BtnEditSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditSubtitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditSubtitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditSubtitle.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditSubtitle.Image = global::PlayerPlusPlus.Core.Properties.Resources.editname_16x16;
            this.BtnEditSubtitle.Location = new System.Drawing.Point(206, 3);
            this.BtnEditSubtitle.Name = "BtnEditSubtitle";
            this.BtnEditSubtitle.Size = new System.Drawing.Size(23, 23);
            this.BtnEditSubtitle.TabIndex = 19;
            this.BtnEditSubtitle.UseVisualStyleBackColor = true;
            this.BtnEditSubtitle.Click += new System.EventHandler(this.BtnEditSubtitle_Click);
            // 
            // BtnFullScreen
            // 
            this.BtnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFullScreen.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFullScreen.Image = global::PlayerPlusPlus.Core.Properties.Resources.group2_16x16;
            this.BtnFullScreen.Location = new System.Drawing.Point(177, 3);
            this.BtnFullScreen.Name = "BtnFullScreen";
            this.BtnFullScreen.Size = new System.Drawing.Size(23, 23);
            this.BtnFullScreen.TabIndex = 19;
            this.BtnFullScreen.UseVisualStyleBackColor = true;
            this.BtnFullScreen.Click += new System.EventHandler(this.BtnFullScreen_Click);
            // 
            // BtnPlayPause
            // 
            this.BtnPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPlayPause.Font = new System.Drawing.Font("Tahoma", 6.25F, System.Drawing.FontStyle.Bold);
            this.BtnPlayPause.Image = global::PlayerPlusPlus.Core.Properties.Resources.next_16x16;
            this.BtnPlayPause.Location = new System.Drawing.Point(61, 3);
            this.BtnPlayPause.Name = "BtnPlayPause";
            this.BtnPlayPause.Size = new System.Drawing.Size(23, 23);
            this.BtnPlayPause.TabIndex = 21;
            this.BtnPlayPause.UseVisualStyleBackColor = true;
            this.BtnPlayPause.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStop.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.Image = global::PlayerPlusPlus.Core.Properties.Resources.stop_16x16;
            this.BtnStop.Location = new System.Drawing.Point(90, 3);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(23, 23);
            this.BtnStop.TabIndex = 20;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnSeekNext
            // 
            this.BtnSeekNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeekNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeekNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSeekNext.Font = new System.Drawing.Font("Tahoma", 6.25F, System.Drawing.FontStyle.Bold);
            this.BtnSeekNext.Image = global::PlayerPlusPlus.Core.Properties.Resources.doublenext_16x16;
            this.BtnSeekNext.Location = new System.Drawing.Point(119, 3);
            this.BtnSeekNext.Name = "BtnSeekNext";
            this.BtnSeekNext.Size = new System.Drawing.Size(23, 23);
            this.BtnSeekNext.TabIndex = 21;
            this.BtnSeekNext.UseVisualStyleBackColor = true;
            this.BtnSeekNext.Click += new System.EventHandler(this.BtnSeekNext_Click);
            // 
            // BtnPreviousFile
            // 
            this.BtnPreviousFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPreviousFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPreviousFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPreviousFile.Font = new System.Drawing.Font("Tahoma", 6.25F, System.Drawing.FontStyle.Bold);
            this.BtnPreviousFile.Image = global::PlayerPlusPlus.Core.Properties.Resources.doublefirst_16x16;
            this.BtnPreviousFile.Location = new System.Drawing.Point(3, 3);
            this.BtnPreviousFile.Name = "BtnPreviousFile";
            this.BtnPreviousFile.Size = new System.Drawing.Size(23, 23);
            this.BtnPreviousFile.TabIndex = 21;
            this.BtnPreviousFile.UseVisualStyleBackColor = true;
            // 
            // BtnNextFile
            // 
            this.BtnNextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNextFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNextFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNextFile.Font = new System.Drawing.Font("Tahoma", 6.25F, System.Drawing.FontStyle.Bold);
            this.BtnNextFile.Image = global::PlayerPlusPlus.Core.Properties.Resources.doublelast_16x16;
            this.BtnNextFile.Location = new System.Drawing.Point(148, 3);
            this.BtnNextFile.Name = "BtnNextFile";
            this.BtnNextFile.Size = new System.Drawing.Size(23, 23);
            this.BtnNextFile.TabIndex = 21;
            this.BtnNextFile.UseVisualStyleBackColor = true;
            // 
            // BtnSeekBack
            // 
            this.BtnSeekBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeekBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeekBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSeekBack.Font = new System.Drawing.Font("Tahoma", 6.25F, System.Drawing.FontStyle.Bold);
            this.BtnSeekBack.Image = global::PlayerPlusPlus.Core.Properties.Resources.doubleprev_16x16;
            this.BtnSeekBack.Location = new System.Drawing.Point(32, 3);
            this.BtnSeekBack.Name = "BtnSeekBack";
            this.BtnSeekBack.Size = new System.Drawing.Size(23, 23);
            this.BtnSeekBack.TabIndex = 21;
            this.BtnSeekBack.UseVisualStyleBackColor = true;
            this.BtnSeekBack.Click += new System.EventHandler(this.BtnSeekBack_Click);
            // 
            // LblTime
            // 
            this.LblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTime.Location = new System.Drawing.Point(439, 19);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(138, 26);
            this.LblTime.TabIndex = 15;
            this.LblTime.Text = "00:00:00,000";
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.White;
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar.Location = new System.Drawing.Point(0, 0);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(584, 45);
            this.trackBar.TabIndex = 14;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // UCPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UCPlayer";
            this.Size = new System.Drawing.Size(584, 414);
            this.Load += new System.EventHandler(this.UCPlayer_Load);
            this.panel1.ResumeLayout(false);
            this.ControlPnl.ResumeLayout(false);
            this.ControlPnl.PerformLayout();
            this.ButtonsPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel PlayerPnl;
        private System.Windows.Forms.Panel ControlPnl;
        private System.Windows.Forms.Button BtnFullScreen;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPlayPause;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button BtnPreviousFile;
        private System.Windows.Forms.Button BtnSeekBack;
        private System.Windows.Forms.Button BtnNextFile;
        private System.Windows.Forms.Button BtnSeekNext;
        private System.Windows.Forms.Panel ButtonsPnl;
        private System.Windows.Forms.Button BtnEditSubtitle;
    }
}
