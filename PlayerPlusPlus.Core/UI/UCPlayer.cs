using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using System.Reflection;
using System.IO;
using Microsoft.WindowsAPICodePack.Taskbar;
namespace PlayerPlusPlus.Core
{
    public partial class UCPlayer : UserControl
    {
        TaskbarManager Taskbar = TaskbarManager.Instance;
        public Vlc.DotNet.Forms.VlcControl vlcControl;
        public event EventHandler EditSubtitles;
        public event FilePlayDele NewFilePlayed;
        public UCPlayer()
        {
            GlobalMouseHandler gmh = new GlobalMouseHandler();
            gmh.TheMouseMoved += () =>
            {
                if (OnFullScreen)
                {
                    ShowControls = Cursor.Position.Y >= fullscreen.Height - 100;
                }
            };
            Application.AddMessageFilter(gmh);
            InitializeComponent();
            InitPlayer();

            trackBar.MouseUp += (s, e) =>
            {
                trackBar.Value = (int)(((e.X - 8) / (double)trackBar.Width) * trackBar.Maximum);
                trackBar_Scroll(s, e);
            };
            ApplyDragoDrop(Controls);
            CheckForIllegalCrossThreadCalls = false;
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
            this.vlcControl.Size = PlayerPnl.Size;
            PlayerPnl.SizeChanged += (s, e) => { this.vlcControl.Size = PlayerPnl.Size; };
            this.vlcControl.Spu = -1;
            this.vlcControl.TabIndex = 0;
            this.vlcControl.Text = "vlcControl1";
            this.vlcControl.VlcLibDirectory = null;
            this.vlcControl.VlcMediaplayerOptions = null;
            this.vlcControl.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl_VlcLibDirectoryNeeded);
            this.vlcControl.LengthChanged += OnVlcMediaLengthChanged;
            this.vlcControl.PositionChanged += OnVlcPositionChanged;
            this.vlcControl.Click += BtnPlay_Click;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

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
            if (!string.IsNullOrEmpty(FilePath))
            {
                if (IsStopped)
                {
                    vlcControl.Play(new Uri(FilePath));
                    IsRunning = false;//Will be Changed in next
                }
                if (IsRunning)
                    BtnPlayPause.Image = Properties.Resources.next_16x16;
                else
                    BtnPlayPause.Image = Properties.Resources.pause_16x16;
                IsRunning = !IsRunning;
                vlcControl.Pause();
                IsStopped = false;
            }
        }
        TimeSpan totalTime;
        private void OnVlcMediaLengthChanged(object sender, VlcMediaPlayerLengthChangedEventArgs e)
        {
            totalTime = new TimeSpan((long)e.NewLength);
            UpdateTime(new TimeSpan());
            trackBar.Maximum = (int)(vlcControl.Length);
        }
        private void OnVlcPositionChanged(object sender, VlcMediaPlayerPositionChangedEventArgs e)
        {
            var position = vlcControl.GetCurrentMedia().Duration.Ticks * e.NewPosition;
            var currentTime = new TimeSpan((long)position);
            try
            {
                UpdateTime(currentTime);
                trackBar.Value = (int)currentTime.TotalMilliseconds;
                Taskbar.SetProgressValue(trackBar.Value, trackBar.Maximum);
            }
            catch (Exception ex)
            {
            }
        }

        void UpdateTime(TimeSpan currentTime)
        {
            LblTime.Text = string.Format("{0:00}:{1:00}:{2:00},{3:000}/{4:00}:{5:00}:{6:00},{7:000}",
                      currentTime.Hours,
                      currentTime.Minutes,
                      currentTime.Seconds,
                      currentTime.Milliseconds,

                      totalTime.Hours,
                      totalTime.Minutes,
                      totalTime.Seconds,
                      totalTime.Milliseconds

                               );
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {

        }
        public void Stop()
        {
            if (vlcControl.State == Vlc.DotNet.Core.Interops.Signatures.MediaStates.Playing)
                vlcControl.Stop();
            this.BtnPlayPause.Image = Properties.Resources.next_16x16;
            IsStopped = true;
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
            else if (keyData == Keys.C)
            {
                ShowControls = !ShowControls;
                return true;
            }
            else if (keyData == Keys.Space && !OnEdit)
            {
                BtnPlay_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                vlcControl.Position = (float)((decimal)trackBar.Value / vlcControl.Length);
            }
            catch (Exception)
            {
            }
        }
        #endregion


        #region Properties
        public string FilePath { get; set; }
        //public string CurrentTime { get { return LblCurrentTime.Text; } set { LblCurrentTime.Text = value; } }
        public string TotalTime { get { return LblTime.Text; } set { LblTime.Text = value; } }


        public bool ShowControls
        {
            get
            {
                return ControlPnl.Visible;
            }
            set
            {
                ControlPnl.Visible = value;
            }
        }
        public bool OnEdit { get; set; }
        public bool OnFullScreen { get; set; }

        public void Pause()
        {
            if (vlcControl.IsPlaying)
            {
                vlcControl.Pause();
            }
        }

        bool IsRunning { get; set; }
        bool IsStopped { get; set; }
        FullScreen fullscreen;

        public long Position
        {
            get
            {
                return (long)(vlcControl.GetCurrentMedia().Duration.Ticks * vlcControl.Position);
            }
            set {
                vlcControl.Position = value;
            }
        }
        #endregion

        private void BtnFullScreen_Click(object sender, EventArgs e)
        {
            if (OnFullScreen)
            {
                OnFullScreen = !OnFullScreen;
                fullscreen.Close();
            }
            else
            {
                fullscreen = new FullScreen(this, Parent);
                OnFullScreen = !OnFullScreen;
                fullscreen.ShowDialog();
            }
        }


        private void ControlPnl_SizeChanged(object sender, EventArgs e)
        {
            var pnlCenter = ButtonsPnl.Parent.Size.Width / 2 - (ButtonsPnl.Width / 2);
            ButtonsPnl.Location = new Point(pnlCenter, ButtonsPnl.Location.Y);
            PlayerPnl.Controls.Add(this.vlcControl);

        }

        private void BtnSeekNext_Click(object sender, EventArgs e)
        {
            var ToBeChanged = 5000f / vlcControl.Length;
            vlcControl.Position += ToBeChanged;
        }

        private void BtnSeekBack_Click(object sender, EventArgs e)
        {
            var ToBeChanged = 5000f / vlcControl.Length;
            vlcControl.Position -= ToBeChanged;
        }
        #region Drag Drop
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
                Play(file);
            }
            else
            {
                MessageBox.Show(this, "Please Add Only Video Files", "File Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #endregion

        private void BtnEditSubtitle_Click(object sender, EventArgs e)
        {
            TimeSpan ts = TimeSpan.FromMilliseconds(trackBar.Value);
            EditSubtitles?.Invoke(ts, null);
        }

        public void Play(string FilePath)
        {
            this.FilePath = FilePath;
            vlcControl.Play(new Uri(FilePath));
            NewFilePlayed?.Invoke(FilePath);
            IsRunning = true;
            IsStopped = false;
            this.BtnPlayPause.Image = Properties.Resources.pause_16x16;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            BtnFullScreen_Click(null, null);
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void UCPlayer_Load(object sender, EventArgs e)
        {
            if (UiHelper.IsInRunTime)
            {
                vlcControl.Video.IsMouseInputEnabled = false;
                vlcControl.Video.IsKeyInputEnabled = false;
                vlcControl.DoubleClick += (s, ex) =>
                {
                    BtnPlay_Click(null, null);
                };
                vlcControl.MouseDoubleClick += (s, ex) =>
                {
                    BtnFullScreen_Click(null, null);
                };
            }
        }
    }

    public delegate void FilePlayDele(string file);
}
