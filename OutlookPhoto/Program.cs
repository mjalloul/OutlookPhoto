﻿using System;
using System.Windows.Forms;

namespace OutlookPhoto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OutlookPhotoForm(args));
        }
    }
}
