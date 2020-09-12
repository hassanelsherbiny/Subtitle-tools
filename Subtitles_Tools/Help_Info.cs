using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Subtitles_Tools
{
    public partial class Help_Info : Form
    {
        public Help_Info()
        {
            InitializeComponent();
        }

        private void BtnGithub_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/hassanelsherbiny/"); 
        }

        private void BtnFaceBook_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://facebook.com/bitsdevelopments1/");
        }

        private void BtnWebsite_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://bits-developments.com");
        }
    }
}
