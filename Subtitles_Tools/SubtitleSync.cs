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
using DateTimeX;
using PlayerPlusPlus.Core;

namespace Subtitles_Tools
{
    public partial class SubtitleSync : Form
    {
        string VideoFilePath;
        string SrtFilePath;

        List<SubTitleItem> SubTitleItems { get; set; }
        public SubtitleSync()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            UCPlayer1.EditSubtitles += (ts, ex) =>
            {
                var currentime = (TimeSpan?)ts;
                SelectClosestSubTitle(currentime);
            };
            ApplyDragoDrop(this.Controls);
            UCPlayer1.NewFilePlayed += (file) => { LoadVideo(file, true); };
            //LoadVideo(@"F:\Movies\Series\Dark\S1\Dark S01E04 .mkv");
        }
        public SubtitleSync(string FilePath) : this()
        {
            LoadVideo(FilePath);
        }
        void SelectClosestSubTitle(TimeSpan? time)
        {
            var closesttime = time.ClosestTime(SubTitleItems.Select(x => x.Start as TimeSpan?).ToArray());
            var ClosestSubtitle = SubTitleItems.FirstOrDefault(x => x.Start == closesttime);
            var index = SubTitleItems.IndexOf(ClosestSubtitle);
            SubTitlesGrv.ClearSelection();
            if (index != -1)
            {
                SubTitlesGrv.Rows[index].Selected = true;
                SubTitlesGrv.FirstDisplayedScrollingRowIndex = SubTitlesGrv.SelectedRows[0].Index;
                SubTitlesGrv.Refresh();
            }
        }



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
        public void LoadVideo(string VideoPath, bool FromEvent = false)
        {
            Text = VideoFilePath = VideoPath;

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
                if (!FromEvent)
                    UCPlayer1.Play(VideoFilePath);
            }
            else
            {
                UCPlayer1.FilePath = "";
                var result = MessageBox.Show(this, "Srt File Not Found, Want To Select It?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Srt File|*.srt|All Files|*.*";
                    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        File.Copy(ofd.FileName, SrtFilePath);
                        if (!FromEvent)
                            LoadVideo(VideoFilePath);
                    }
                }
            }
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
        private void FileDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void FileDragDrop(object sender, DragEventArgs e)
        {
            var file = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            var filetype = Path.GetExtension(file);
            if (Settings.AllowedVideoTypes.Contains(filetype))
            {
                LoadVideo(file);
            }
            else
            {
                MessageBox.Show(this, "Please Add Only Video Files", "File Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Menu Buttons
        private void MenuItem_Load_Click(object sender, EventArgs e)
        {
            UCPlayer1.Stop();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = Settings.AllowedVideoTypes;
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
                    UCPlayer1.Pause();
                    var SelectedSubtitles = SubTitleItems[SubTitlesGrv.SelectedRows[0].Index];

                    var currentTime = new TimeSpan((long)UCPlayer1.Position);
                    var Shift = currentTime - SelectedSubtitles.Start;
                    SubTitleItems.ShiftAll(Shift);
                    SubTitleItems.WriteToFile(SrtFilePath);
                    //Reload Video And Seek To Current Position
                    var currentPos = UCPlayer1.Position;
                    UCPlayer1.Stop();
                    UCPlayer1.Play(VideoFilePath);
                    UCPlayer1.Position = currentPos;
                    UCPlayer1.Pause();

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
            UCPlayer1.Stop();
            VideoFilePath = SrtFilePath = UCPlayer1.FilePath = null;
            //UCPlayer1.CurrentTime = UCPlayer1.TotalTime = "00:00:00,000";
            SubTitlesGrv.DataSource = null;
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
            UCPlayer1.OnEdit = true;
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
            UCPlayer1.OnEdit = false;
        }



        #region Subtitles Events



        #endregion

        private void SyncAllNext_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(VideoFilePath))
            {
                if (!string.IsNullOrEmpty(SrtFilePath))
                {

                    UCPlayer1.Pause();
                    var currentIndex = SubTitlesGrv.SelectedRows[0].Index;
                    var SelectedSubtitles = SubTitleItems[currentIndex];
                    var position = UCPlayer1.Position;
                    var currentTime = new TimeSpan((long)position);
                    var Shift = currentTime - SelectedSubtitles.Start;
                    SubTitleItems.ShiftAllAfterIndex(Shift, currentIndex);
                    SubTitleItems.WriteToFile(SrtFilePath);
                    //Reload Video And Seek To Current Position
                    var currentPos = UCPlayer1.Position;
                    UCPlayer1.Stop();
                    UCPlayer1.Play(VideoFilePath);
                    UCPlayer1.Position = currentPos;
                    UCPlayer1.Pause();

                    MessageBox.Show("Sync Done", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(this, "Srt File Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Load File First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnFullScreen_Click(object sender, EventArgs e)
        {
            var S = Screen.FromHandle(Handle); //to find the screen the control in on
            var fi = S.GetType().GetField("hmonitor", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            IntPtr screenhandle = (IntPtr)fi.GetValue(S); //to get the screen handle
            //FullScreen fs = new FullScreen(vlcControl, splitContainer2, splitContainer1);
            //fs.ShowDialog();
        }

    }
}
