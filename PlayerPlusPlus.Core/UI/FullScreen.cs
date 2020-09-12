using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlayerPlusPlus.Core
{
    public partial class FullScreen : Form
    {
        UCPlayer UCPlayer1;

        Control ParentContainer;

        public FullScreen(UCPlayer uCPlayer, Control parentContainer)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            //TopMost = true;
            this.Controls.Add(uCPlayer);
            UCPlayer1 = uCPlayer;
            UCPlayer1.ShowControls = false;
            UCPlayer1.Dock = DockStyle.Fill;
            Text = System.IO.Path.GetFileNameWithoutExtension(uCPlayer.FilePath);
            ParentContainer = parentContainer;
        }
        void ExitFullScreen()
        {
            UCPlayer1.OnFullScreen = false;
            UCPlayer1.ShowControls = true;
            ParentContainer.Controls.Add(UCPlayer1);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void FullScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitFullScreen();
        }
    }

}
