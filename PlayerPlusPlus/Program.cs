﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PlayerPlusPlus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args != null && args.Any())
            {
                Application.Run(new Player(args[0]));
            }
            else
            {
                Application.Run(new Player());
            }
        }
    }
}
