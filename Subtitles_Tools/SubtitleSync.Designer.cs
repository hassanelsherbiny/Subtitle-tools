namespace Subtitles_Tools
{
    partial class SubtitleSync
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubtitleSync));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.SubTitlesGrv = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.LblCurrentTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTotalTime = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.LblFilePath = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Sync = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UnloadBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ManualShift = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_FileCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.MnueItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubTitlesGrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.MenuItem_Sync,
            this.MenuItem_Save,
            this.MenuItem_SaveAs,
            this.MenuItem_UnloadBtn,
            this.MenuItem_ManualShift,
            this.MenuItem_FileCapture,
            this.MnueItem_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 87);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnPause
            // 
            this.BtnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPause.Font = new System.Drawing.Font("Tahoma", 6.25F, System.Drawing.FontStyle.Bold);
            this.BtnPause.Location = new System.Drawing.Point(3, 2);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(23, 23);
            this.BtnPause.TabIndex = 3;
            this.BtnPause.Text = "||";
            this.toolTip1.SetToolTip(this.BtnPause, "Pause");
            this.BtnPause.UseVisualStyleBackColor = true;
            // 
            // BtnStop
            // 
            this.BtnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStop.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.Location = new System.Drawing.Point(32, 2);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(23, 23);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "[]";
            this.toolTip1.SetToolTip(this.BtnStop, "Stop");
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // SubTitlesGrv
            // 
            this.SubTitlesGrv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubTitlesGrv.BackgroundColor = System.Drawing.Color.White;
            this.SubTitlesGrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubTitlesGrv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubTitlesGrv.Location = new System.Drawing.Point(0, 0);
            this.SubTitlesGrv.Name = "SubTitlesGrv";
            this.SubTitlesGrv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SubTitlesGrv.Size = new System.Drawing.Size(312, 283);
            this.SubTitlesGrv.TabIndex = 8;
            this.SubTitlesGrv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubTitlesGrv_CellEndEdit);
            this.SubTitlesGrv.DoubleClick += new System.EventHandler(this.SubTitlesGrv_DoubleClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.LblCurrentTime);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.LblTotalTime);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(620, 38);
            this.splitContainer2.SplitterDistance = 105;
            this.splitContainer2.TabIndex = 0;
            // 
            // LblCurrentTime
            // 
            this.LblCurrentTime.AutoSize = true;
            this.LblCurrentTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblCurrentTime.Location = new System.Drawing.Point(84, 0);
            this.LblCurrentTime.Name = "LblCurrentTime";
            this.LblCurrentTime.Size = new System.Drawing.Size(73, 13);
            this.LblCurrentTime.TabIndex = 6;
            this.LblCurrentTime.Text = "00:00:00,000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(73, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // LblTotalTime
            // 
            this.LblTotalTime.AutoSize = true;
            this.LblTotalTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTotalTime.Location = new System.Drawing.Point(0, 0);
            this.LblTotalTime.Name = "LblTotalTime";
            this.LblTotalTime.Size = new System.Drawing.Size(73, 13);
            this.LblTotalTime.TabIndex = 4;
            this.LblTotalTime.Text = "00:00:00,000";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.LblFilePath);
            this.splitContainer3.Panel1.Controls.Add(this.trackBar);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.BtnStop);
            this.splitContainer3.Panel2.Controls.Add(this.BtnPause);
            this.splitContainer3.Size = new System.Drawing.Size(511, 38);
            this.splitContainer3.SplitterDistance = 458;
            this.splitContainer3.TabIndex = 0;
            // 
            // LblFilePath
            // 
            this.LblFilePath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblFilePath.Location = new System.Drawing.Point(0, 13);
            this.LblFilePath.Name = "LblFilePath";
            this.LblFilePath.Size = new System.Drawing.Size(458, 25);
            this.LblFilePath.TabIndex = 5;
            // 
            // trackBar
            // 
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar.Location = new System.Drawing.Point(0, 0);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(458, 45);
            this.trackBar.TabIndex = 4;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(620, 312);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 87);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer4.Size = new System.Drawing.Size(936, 312);
            this.splitContainer4.SplitterDistance = 312;
            this.splitContainer4.TabIndex = 9;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.TxtSearch);
            this.splitContainer5.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.SubTitlesGrv);
            this.splitContainer5.Size = new System.Drawing.Size(312, 312);
            this.splitContainer5.SplitterDistance = 25;
            this.splitContainer5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtSearch.Location = new System.Drawing.Point(0, 25);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(312, 20);
            this.TxtSearch.TabIndex = 3;
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Image = global::Subtitles_Tools.Properties.Resources.Open1;
            this.fileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.fileToolStripMenuItem.Text = "Load";
            this.fileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.fileToolStripMenuItem.ToolTipText = "Select a fIle To Sync its Subtitles";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Load_Click);
            // 
            // MenuItem_Sync
            // 
            this.MenuItem_Sync.Image = global::Subtitles_Tools.Properties.Resources.Sync;
            this.MenuItem_Sync.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuItem_Sync.Name = "MenuItem_Sync";
            this.MenuItem_Sync.Size = new System.Drawing.Size(76, 83);
            this.MenuItem_Sync.Text = "Sync";
            this.MenuItem_Sync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuItem_Sync.ToolTipText = "Select a subtitle And Sync To Current Time Of Player";
            this.MenuItem_Sync.Click += new System.EventHandler(this.MenuItem_Sync_Click);
            // 
            // MenuItem_UnloadBtn
            // 
            this.MenuItem_UnloadBtn.Image = global::Subtitles_Tools.Properties.Resources.Unload;
            this.MenuItem_UnloadBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuItem_UnloadBtn.Name = "MenuItem_UnloadBtn";
            this.MenuItem_UnloadBtn.Size = new System.Drawing.Size(76, 83);
            this.MenuItem_UnloadBtn.Text = "Unload";
            this.MenuItem_UnloadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuItem_UnloadBtn.Click += new System.EventHandler(this.MenuItem_UnloadBtn_Click);
            // 
            // MenuItem_ManualShift
            // 
            this.MenuItem_ManualShift.Image = global::Subtitles_Tools.Properties.Resources.ManualShift;
            this.MenuItem_ManualShift.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuItem_ManualShift.Name = "MenuItem_ManualShift";
            this.MenuItem_ManualShift.Size = new System.Drawing.Size(86, 83);
            this.MenuItem_ManualShift.Text = "Manual Shift";
            this.MenuItem_ManualShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuItem_ManualShift.Click += new System.EventHandler(this.MenuItem_ManualShift_Click);
            // 
            // MenuItem_FileCapture
            // 
            this.MenuItem_FileCapture.Image = global::Subtitles_Tools.Properties.Resources.FileCapture;
            this.MenuItem_FileCapture.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuItem_FileCapture.Name = "MenuItem_FileCapture";
            this.MenuItem_FileCapture.Size = new System.Drawing.Size(82, 83);
            this.MenuItem_FileCapture.Text = "File Capture";
            this.MenuItem_FileCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuItem_FileCapture.Click += new System.EventHandler(this.MenuItem_FileCapture_Click);
            // 
            // MnueItem_help
            // 
            this.MnueItem_help.Image = global::Subtitles_Tools.Properties.Resources.Help_icon_72a7cf_svg;
            this.MnueItem_help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnueItem_help.Name = "MnueItem_help";
            this.MnueItem_help.Size = new System.Drawing.Size(76, 83);
            this.MnueItem_help.Text = "Help";
            this.MnueItem_help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MnueItem_help.Click += new System.EventHandler(this.MnueItem_help_Click);
            // 
            // MenuItem_Save
            // 
            this.MenuItem_Save.Image = global::Subtitles_Tools.Properties.Resources.Save;
            this.MenuItem_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuItem_Save.Name = "MenuItem_Save";
            this.MenuItem_Save.Size = new System.Drawing.Size(91, 83);
            this.MenuItem_Save.Text = "Save Subtitles";
            this.MenuItem_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuItem_Save.ToolTipText = "Save The Current Subtitles With It\'s Modifications To Current Subtitle File";
            this.MenuItem_Save.Click += new System.EventHandler(this.MenuItem_Save_Click);
            // 
            // MenuItem_SaveAs
            // 
            this.MenuItem_SaveAs.Image = global::Subtitles_Tools.Properties.Resources.SaveAs;
            this.MenuItem_SaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuItem_SaveAs.Name = "MenuItem_SaveAs";
            this.MenuItem_SaveAs.Size = new System.Drawing.Size(107, 83);
            this.MenuItem_SaveAs.Text = "Save Subtitles As";
            this.MenuItem_SaveAs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuItem_SaveAs.ToolTipText = "Save The Current Subtitles With It\'s Modifications To a File";
            this.MenuItem_SaveAs.Click += new System.EventHandler(this.MenuItem_SaveAs_Click);
            // 
            // SubtitleSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 399);
            this.Controls.Add(this.splitContainer4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SubtitleSync";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subtitles Sync";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubTitlesGrv)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Sync;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView SubTitlesGrv;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label LblCurrentTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTotalTime;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label LblFilePath;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ManualShift;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_FileCapture;
        private System.Windows.Forms.ToolStripMenuItem MnueItem_help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_UnloadBtn;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SaveAs;
   
    }
}