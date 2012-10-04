﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AIAssignment1;
using System.Threading;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new AdjustmentCaculator().Show();
            Application.Run(new Form1());
        }
    }
}
