using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Vlc.DotNet.Core;

namespace Subtitles_Tools
{
    public partial class SubtitleSync : Form
    {
        Vlc.DotNet.Forms.VlcControl vlcControl = new Vlc.DotNet.Forms.VlcControl();
        string VideoFilePath;
        string SrtFilePath;
        string AllowedVideoTypes = "Video Files|*.mkv;*.avi;*.mp4|All Files|*.*";
        List<SubTitleItem> SubTitleItems { get; set; }
        bool OnEdit = false;
        public SubtitleSync()
        {
            InitializeComponent();
            InitPlayer();
            CheckForIllegalCrossThreadCalls = false;
            ApplyDragoDrop(Controls);
        }

        void ApplyDragoDrop(Control.ControlCollection c)
        {
            foreach (Control control in c)
            {
                control.DragDrop += FileDragDrop;
                control.DragEnter += FileDragEnter;
                control.AllowDrop = true;
                ApplyDragoDrop(control.Controls);
            }
        }
        #region   Player Init And Events
        void InitPlayer()
        {
            this.vlcControl = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl
            // 
            this.vlcControl.BackColor = System.Drawing.Color.Black;
            this.vlcControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vlcControl.Location = new System.Drawing.Point(0, 0);
            this.vlcControl.Name = "vlcControl";
            this.vlcControl.Size = new System.Drawing.Size(944, 501);
            this.vlcControl.Spu = -1;
            this.vlcControl.TabIndex = 0;
            this.vlcControl.Text = "vlcControl1";
            this.vlcControl.VlcLibDirectory = null;
            this.vlcControl.VlcMediaplayerOptions = null;
            this.vlcControl.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl_VlcLibDirectoryNeeded);
            this.vlcControl.LengthChanged += OnVlcMediaLengthChanged;
            this.vlcControl.PositionChanged += OnVlcPositionChanged;
            this.vlcControl.Click += BtnPause_Click;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            splitContainer1.Panel1.Controls.Add(this.vlcControl);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).EndInit();
            this.ResumeLayout(false);

        }
        private void vlcControl_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {

        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            vlcControl.Pause();
        }
        private void OnVlcMediaLengthChanged(object sender, VlcMediaPlayerLengthChangedEventArgs e)
        {
            var totalTime = new TimeSpan((long)e.NewLength);
            LblTotalTime.Text = string.Format("{0:00}:{1:00}:{2:00},{3:000}",
                        totalTime.Hours,
                        totalTime.Minutes,
                        totalTime.Seconds,
                        totalTime.Milliseconds);
            trackBar.Maximum = (int)(vlcControl.Length);
        }
        private void OnVlcPositionChanged(object sender, VlcMediaPlayerPositionChangedEventArgs e)
        {
            var position = vlcControl.GetCurrentMedia().Duration.Ticks * e.NewPosition;
            var currentTime = new TimeSpan((long)position);

            LblCurrentTime.Text = string.Format("{0:00}:{1:00}:{2:00},{3:000}",
            currentTime.Hours,
            currentTime.Minutes,
            currentTime.Seconds,
            currentTime.Milliseconds);
            trackBar.Value = (int)currentTime.TotalMilliseconds;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            vlcControl.Stop();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var ToBeChanged = 5000f / vlcControl.Length;
            if (keyData == Keys.Right)
            {
                vlcControl.Position += ToBeChanged;
                return true;
            }
            else if (keyData == Keys.Left)
            {
                vlcControl.Position -= ToBeChanged;
                return true;
            }
            else if (keyData == Keys.Space && !OnEdit)
            {
                vlcControl.Pause();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            vlcControl.Position = (float)((decimal)trackBar.Value / vlcControl.Length);
        }
        #endregion

        #region Methods
        bool IsSubtitleCounter(string str)
        {
            if (str.Contains(" "))
                str = str.Replace(" ", "");
            int counter = 0;
            return int.TryParse(str, out counter);
        }
        bool IsTimeLine(string str, out TimeSpan start, out TimeSpan end)
        {
            if (str.Contains(" "))
                str = str.Replace(" ", "");
            Regex regex = new Regex(@"(?<time>(?<startHour>\d+):(?<startMinut>\d+):(?<startSecond>\d+),(?<startMiliSecond>\d+)--\>(?<endHour>\d+):(?<endMinut>\d+):(?<endSecond>\d+),(?<endMiliSecond>\d+))");

            Match match = regex.Match(str);
            if (match.Success)
            {
                int startHour = int.Parse(match.Groups["startHour"].Value);
                int startMinut = int.Parse(match.Groups["startMinut"].Value);
                int startSecond = int.Parse(match.Groups["startSecond"].Value);
                int startMiliSecond = int.Parse(match.Groups["startMiliSecond"].Value);
                int endHour = int.Parse(match.Groups["endHour"].Value);
                int endMinut = int.Parse(match.Groups["endMinut"].Value);
                int endSecond = int.Parse(match.Groups["endSecond"].Value);
                int endMiliSecond = int.Parse(match.Groups["endMiliSecond"].Value);
                start = new TimeSpan(0, startHour, startMinut, startSecond, startMiliSecond);
                end = new TimeSpan(0, endHour, endMinut, endSecond, endMiliSecond);
            }
            else
            {
                start = new TimeSpan();
                end = new TimeSpan();
            }
            return match.Success;

        }
        void LoadVideo(string VideoPath)
        {
            LblFilePath.Text = VideoFilePath = VideoPath;
            SrtFilePath = Path.Combine(Path.GetDirectoryName(VideoPath), Path.GetFileNameWithoutExtension(VideoPath) + ".srt");
            //Fill Grid
            if (File.Exists(SrtFilePath))
            {
                SubTitleItems = new List<SubTitleItem>();
                var lines = System.IO.File.ReadAllLines(SrtFilePath, Encoding.Default);
                bool ReadText = false;
                TimeSpan start = new TimeSpan(), end = new TimeSpan(), ts1, ts2;
                string Text = "";
                foreach (var line in lines)
                {
                    if (IsTimeLine(line, out ts1, out ts2))
                    {
                        start = ts1;
                        end = ts2;
                        ReadText = true;
                    }
                    else if (IsSubtitleCounter(line) || string.IsNullOrEmpty(line))
                    {
                        if (!string.IsNullOrEmpty(Text))
                        {
                            SubTitleItems.Add(new SubTitleItem() { Start = start, End = end, Text = Text });
                            ReadText = false;
                            Text = "";
                        }
                    }
                    else if (ReadText)
                    {
                        Text += line + Environment.NewLine;
                    }

                }

                SubTitlesGrv.DataSource = SubTitleItems;
                vlcControl.Play(new Uri(VideoFilePath));
            }
            else
            {
                LblFilePath.Text = "";
                var result = MessageBox.Show(this, "Srt File Not Found, Want To Select It?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Srt File|*.srt|All Files|*.*";
                    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    { 
                        File.Copy(ofd.FileName, SrtFilePath);
                        LoadVideo(VideoPath);
                    }
                }
            }
        }
        #endregion

        #region Menu Buttons
        private void MenuItem_Load_Click(object sender, EventArgs e)
        {
            if (vlcControl.State == Vlc.DotNet.Core.Interops.Signatures.MediaStates.Playing)
                vlcControl.Stop();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = AllowedVideoTypes;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadVideo(ofd.FileName);
            }
        }

        private void MenuItem_Sync_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(VideoFilePath))
            {
                if (!string.IsNullOrEmpty(SrtFilePath))
                {
                     if(vlcControl.IsPlaying)
                     {
                         vlcControl.Pause();
                     }
                    var SelectedSubtitles = SubTitleItems[SubTitlesGrv.SelectedRows[0].Index];
                    var position = vlcControl.GetCurrentMedia().Duration.Ticks * vlcControl.Position;
                    var currentTime = new TimeSpan((long)position);
                    var Shift = currentTime - SelectedSubtitles.Start;
                    SubTitleItems.ShiftAll(Shift);
                    SubTitleItems.WriteToFile(SrtFilePath);
                    //Reload Video And Seek To Current Position
                    var currentPos = vlcControl.Position;
                    vlcControl.Stop();
                    vlcControl.Play(new Uri(VideoFilePath));
                    vlcControl.Position = currentPos; vlcControl.Pause();

                    MessageBox.Show("Sync Done", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(this, "Srt File Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Load File First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void MenuItem_ManualShift_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(VideoFilePath))
            {
                if (!string.IsNullOrEmpty(SrtFilePath))
                {
                    ManualShift msFrm = new ManualShift(SubTitleItems, SrtFilePath);
                    msFrm.ShowDialog();
                }
                else
                    MessageBox.Show(this, "Srt File Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Load File First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MenuItem_FileCapture_Click(object sender, EventArgs e)
        {
            FileCapture fcFrm = new FileCapture();
            fcFrm.ShowDialog();
        }

        private void MnueItem_help_Click(object sender, EventArgs e)
        {
            Help_Info hiFrm = new Help_Info();
            hiFrm.ShowDialog();
        }

        private void MenuItem_UnloadBtn_Click(object sender, EventArgs e)
        {
            vlcControl.Stop();
            VideoFilePath = SrtFilePath = LblFilePath.Text = null;
            LblCurrentTime.Text = LblTotalTime.Text = "00:00:00,000";
            SubTitlesGrv.DataSource = null;
        }

        #endregion

        #region Drag Drop
        private void FileDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void FileDragDrop(object sender, DragEventArgs e)
        {
            var file = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            var filetype = Path.GetExtension(file);
            if (AllowedVideoTypes.Contains(filetype))
            {
                LoadVideo(file);
            }
            else
            {
                MessageBox.Show(this, "Please Add Only Video Files", "File Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        int SearchResultIndex = -1;
        string LastSearchedText = "";
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(TxtSearch.Text))
                {
                    if (LastSearchedText != TxtSearch.Text)
                    {
                        SearchResultIndex = -1;//Rest Result Counter
                        LastSearchedText = TxtSearch.Text;
                    }
                    var searchResult = SubTitleItems.Where(x => x.Text.ToLower().Contains(TxtSearch.Text));
                    if (searchResult.Any())
                    {
                        SearchResultIndex = SearchResultIndex < searchResult.Count() - 1 ? SearchResultIndex + 1 : 0;
                        int RowIndex = SubTitleItems.IndexOf(searchResult.ToList()[SearchResultIndex]);

                        SubTitlesGrv.Rows[SubTitlesGrv.SelectedRows[0].Index].Selected = false;//Unselect The Selected Row
                        SubTitlesGrv.Rows[RowIndex].Selected = true;
                        SubTitlesGrv.FirstDisplayedScrollingRowIndex = SubTitlesGrv.SelectedRows[0].Index;
                    }
                }
            }
        }

        private void SubTitlesGrv_DoubleClick(object sender, EventArgs e)
        {
            //   SubTitlesGrv
            SubTitlesGrv.BeginEdit(true);
            OnEdit = true;
        }

        private void MenuItem_SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Srt File|*.srt|All Files|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SubTitleItems.WriteToFile(sfd.FileName);
                MessageBox.Show(this, "Subtitles Saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MenuItem_Save_Click(object sender, EventArgs e)
        {
            SubTitleItems.WriteToFile(SrtFilePath);
            MessageBox.Show(this, "Subtitles Saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SubTitlesGrv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            OnEdit = false;
        }


        #region Subtitles Events



        #endregion


    }
}
