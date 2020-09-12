using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlayerPlusPlus
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }
        public Player(string FilePath) : this()
        {
            ucPlayer1.Play(FilePath);
            Text = FilePath;
        }
    }
}
