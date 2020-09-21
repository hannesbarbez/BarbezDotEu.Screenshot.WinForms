// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ScreenshotOnePro.Logic
{
    public static class Generic
    {
        private const string DEFAULTWATERMARKEXTENSION = ".png";

        /// <summary>
        /// Checks if the current user is a default Windows Service account (true) or not (false)
        /// </summary>
        /// <param name="username">The username to check</param>
        /// <returns>True if username is a default Windows Service account, otherwise false</returns>
        internal static bool IsADefaultWindowsServiceAccount(string username)
        {
            string[] defWinSrvAccs = new string[] { "BATCH", "CONSOLE LOGON", "CREATOR GROUP", "CREATOR OWNER", "DIALUP", "INTERACTIVE", "IUSR", "LOCAL SERVICE",
                "NETWORK", "NETWORK SERVICE", "OWNER RIGHTS", "REMOTE INTERACTIVE LOGON", "SERVICE", "SYSTEM", "TERMINAL SERVER USER" };
            username = username.ToUpper();
            foreach (string s in defWinSrvAccs)
                if (username.EndsWith(s))
                    return true;
            return false;
        }

        internal static void OpenUri(string uri)
        {
            Process.Start(uri);
        }

        internal static string CalculateMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));
            return sb.ToString();
        }

        internal static string OpenImageSelectionDialog()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                int i = 0;
                int filterindex = 0;
                string result = "";

                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                string sep = string.Empty;
                foreach (ImageCodecInfo c in codecs)
                {
                    string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                    ofd.Filter = String.Format("{0}{1}{2} ({3})|{3}", ofd.Filter, sep, codecName, c.FilenameExtension);
                    if (c.FilenameExtension.ToLower().Contains(DEFAULTWATERMARKEXTENSION))
                        filterindex = i + 1; //Aids in setting the correct default extension
                    sep = "|";
                    i++;
                }

                ofd.Filter = String.Format("{0}{1}{2} ({3})|{3}", ofd.Filter, sep, "All Files", "*.*");
                ofd.FilterIndex = filterindex; //Aids in setting the correct default extension
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    if (File.Exists(fileName))
                    {
                        result = fileName;
                    }
                }

                return result;
            }
        }

        internal static void EndProcessTree(string imageName)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "taskkill",
                Arguments = $"/im {imageName} /f /t",
                CreateNoWindow = true,
                UseShellExecute = false
            }).WaitForExit();
        }
    }
}
