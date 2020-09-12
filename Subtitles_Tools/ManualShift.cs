using PlayerPlusPlus.Core;
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
    public partial class ManualShift : Form
    {
        List<SubTitleItem> subtitles { get; set; }
        string SrtFilePath;
        public ManualShift(List<SubTitleItem> subtitles, string SrtFilePath)
        {
            InitializeComponent();
            this.subtitles = subtitles;
            this.SrtFilePath = SrtFilePath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void BtnShift_Click(object sender, EventArgs e)
        {
            var Shift = new TimeSpan(0, (int)hr.Value, (int)mnt.Value, (int)sec.Value, (int)ms.Value);
            subtitles.ShiftAll(Shift);
            subtitles.WriteToFile(SrtFilePath);
            MessageBox.Show("DONE");
        }


       
    }
}
