using PlayerPlusPlus.Core;

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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Sync = new System.Windows.Forms.ToolStripMenuItem();
            this.SyncAllNext = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UnloadBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ManualShift = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_FileCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.MnueItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SubTitlesGrv = new System.Windows.Forms.DataGridView();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UCPlayer1 = new  UCPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubTitlesGrv)).BeginInit();
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
            this.SyncAllNext,
            this.MenuItem_Save,
            this.MenuItem_SaveAs,
            this.MenuItem_UnloadBtn,
            this.MenuItem_ManualShift,
            this.MenuItem_FileCapture,
            this.MnueItem_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 87);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            // SyncAllNext
            // 
            this.SyncAllNext.Image = global::Subtitles_Tools.Properties.Resources.Sync;
            this.SyncAllNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SyncAllNext.Name = "SyncAllNext";
            this.SyncAllNext.Size = new System.Drawing.Size(88, 83);
            this.SyncAllNext.Text = "Sync All Next";
            this.SyncAllNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SyncAllNext.ToolTipText = "Select a subtitle And Sync To Current Time Of Player";
            this.SyncAllNext.Click += new System.EventHandler(this.SyncAllNext_Click);
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
            this.MnueItem_help.Image = global::Subtitles_Tools.Properties.Resources.Help_icon;
            this.MnueItem_help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnueItem_help.Name = "MnueItem_help";
            this.MnueItem_help.Size = new System.Drawing.Size(76, 83);
            this.MnueItem_help.Text = "Help";
            this.MnueItem_help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MnueItem_help.Click += new System.EventHandler(this.MnueItem_help_Click);
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
            this.SubTitlesGrv.Size = new System.Drawing.Size(329, 283);
            this.SubTitlesGrv.TabIndex = 8;
            this.SubTitlesGrv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubTitlesGrv_CellEndEdit);
            this.SubTitlesGrv.DoubleClick += new System.EventHandler(this.SubTitlesGrv_DoubleClick);
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
            this.splitContainer4.Panel2.Controls.Add(this.UCPlayer1);
            this.splitContainer4.Size = new System.Drawing.Size(987, 312);
            this.splitContainer4.SplitterDistance = 329;
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
            this.splitContainer5.Size = new System.Drawing.Size(329, 312);
            this.splitContainer5.SplitterDistance = 25;
            this.splitContainer5.TabIndex = 0;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtSearch.Location = new System.Drawing.Point(0, 25);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(329, 20);
            this.TxtSearch.TabIndex = 3;
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCPlayer1
            // 
            //this.UCPlayer1.CurrentTime = "00:00:00,000";
            this.UCPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCPlayer1.FilePath = "";
            this.UCPlayer1.Location = new System.Drawing.Point(0, 0);
            this.UCPlayer1.Name = "UCPlayer1";
            this.UCPlayer1.OnEdit = false;
            this.UCPlayer1.Size = new System.Drawing.Size(654, 312);
            this.UCPlayer1.TabIndex = 0;
            this.UCPlayer1.TotalTime = "00:00:00,000";
            // 
            // SubtitleSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 399);
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
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ManualShift;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_FileCapture;
        private System.Windows.Forms.ToolStripMenuItem MnueItem_help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_UnloadBtn;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem SyncAllNext;
        private UCPlayer UCPlayer1;
    }
}