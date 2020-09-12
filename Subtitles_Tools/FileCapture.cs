using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Subtitles_Tools
{
    public partial class FileCapture : Form
    {
        public FileCapture()
        {
            InitializeComponent();
        }

        private void FileCapture_BtnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FileCapture_TxtPath.Text = fbd.SelectedPath;
            }
        }

        private void FileCapture_BtnCapture_Click(object sender, EventArgs e)
        {
            string[] AllowedExt = new string[] { ".mkv" };
            string[] AllowedSRTExt = new string[] { ".srt" };
            if (!Directory.Exists(FileCapture_TxtPath.Text))
            {
                MessageBox.Show("Folder Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var files = Directory.GetFiles(FileCapture_TxtPath.Text);
            foreach (var video in files)
            {
                string VideoPath = video.Trim();
                if (AllowedExt.Contains(Path.GetExtension(VideoPath).ToLower()))
                {
                    //var data = ExtracSeasonAndEposide(Path.GetFileNameWithoutExtension(VideoPath).ToUpper(), @"S(?<season>\d{1,2})E(?<episode>\d{1,2})");
                    var data = (ExtracSeasonAndEposide(Path.GetFileNameWithoutExtension(VideoPath).ToUpper(), @"S(?<season>\d{1,2}) E(?<episode>\d{1,2})"));
                    var q = data.ToList();
                     
                    if (data.Any())
                    {
                        CaptureWithPattern(VideoPath, data, "S{0}E{1}", AllowedExt, AllowedSRTExt);
                        CaptureWithPattern(VideoPath, data, "S{0} E{1}", AllowedExt, AllowedSRTExt);
                        CaptureWithPattern(VideoPath, data, "E{1}", AllowedExt, AllowedSRTExt);
                        CaptureWithPattern(VideoPath, data, "{1}", AllowedExt, AllowedSRTExt); 
                    }
                }
            }
            MessageBox.Show("DONE", "All Files Renamed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void CaptureWithPattern(string VideoPath, Dictionary<string, string> data, string Pattern, string[] AllowedExt, string[] AllowedSRTExt)
        {
            string eposide = string.Format(Pattern, data.FirstOrDefault().Key, data.FirstOrDefault().Value);
            var srtFiles = Directory.GetFiles(FileCapture_TxtPath.Text, "*.*", SearchOption.AllDirectories)
           .Select(f => new FileInfo(f)).Where(x => AllowedSRTExt.Contains(Path.GetExtension(x.FullName).ToLower()));
            foreach (var srtfile in srtFiles)
            {
                if (srtfile.Name.Trim().ToUpper().Contains(eposide))
                {
                    //make backup
                    string backup = FileCapture_TxtPath.Text + "/Backup";
                    if (!Directory.Exists(backup))
                    {
                        Directory.CreateDirectory(backup);
                    }
                    string SrtFileBackup = Path.Combine(backup, srtfile.Name);
                    if (!File.Exists(SrtFileBackup))
                    {
                        File.Copy(srtfile.FullName, SrtFileBackup);
                    }
                    //rename
                    var NewSrtFile = Path.Combine(FileCapture_TxtPath.Text, Path.GetFileNameWithoutExtension(VideoPath) + ".srt");
                    if (!File.Exists(NewSrtFile))
                    {
                        File.Move(srtfile.FullName, NewSrtFile);
                    }
                }
            }
        }
        Dictionary<string, string> ExtracSeasonAndEposide(string filename, string Pattern)
        {
            var result = new Dictionary<string, string>();
            Regex regex = new Regex(Pattern);

            Match match = regex.Match(filename);
            if (match.Success)
            {
                string season = match.Groups["season"].Value;
                string episode = match.Groups["episode"].Value;
                result.Add(season, episode);
            }

            return result;
        }
    }
}
