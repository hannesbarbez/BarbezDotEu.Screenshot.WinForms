// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the MIT License.

using ScreenshotOnePro.Logic;
using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace ScreenshotOnePro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Generic.IsADefaultWindowsServiceAccount(WindowsIdentity.GetCurrent().Name))
            {
                // Prevent the app to be run under a service account
                Application.Exit();

                // Same same but different
                Thread.CurrentThread.Abort();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain(args));
        }
    }
}
