// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the MIT License.

using ScreenshotOnePro.Logic;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenshotOnePro
{
    public delegate void WorkFinishedDelegate();
    public delegate void ShowResultDelegate(string s);

    public partial class FrmMain : Form
    {
        private const int INTERVAL = 900;
        private int SWidth = 1200;
        private int SHeight = 30000;
        private const int SLEEPTIME = 20;
        private const int AMOUNTOFITERATIONS = 500;

        private string url = "";
        private string args = "";
        private string folder = "";
        private string argUrl = "";
        private string argHeight = "";
        private string argWidth = "";
        private string argReference = "";
        private string argOutputPath = "";
        private string argImageFormat = "Png";
        private string SFileExtension = ".png";
        private string error = "";
        private ImageFormat SImageFormat;

        private const string APPTITLE = "Screenshot One Pro";
        private const string NOWATERMARKSELECTED = "No watermark selected.";
        private string argVersion = "(Latest)";
        private const string LONG = "50000";
        private string argWatermarkUrl = NOWATERMARKSELECTED;
        private const int DEFAULTHEIGHOFFSET = 500;
        private bool endOfRender;
        private bool autorun = false;
        private static readonly FrmBulk frmBulk = new FrmBulk();

        private const string MSSTORERATINGURL = "ms-windows-store://review/?productid=9NSSPDBX83LH";

        private void Window_Error(object sender, HtmlElementErrorEventArgs e)
        {
            e.Handled = true; // Ignore the error and suppress the error dialog box. 
        }

        private void SetImageFormatAndFileExtension()
        {
            switch (argImageFormat.ToLower())
            {
                case "png":
                    SImageFormat = ImageFormat.Png;
                    cbOutputFileType.SelectedIndex = 0;
                    SFileExtension = ".png";
                    break;
                case "gif":
                    SImageFormat = ImageFormat.Gif;
                    cbOutputFileType.SelectedIndex = 1;
                    SFileExtension = ".gif";
                    break;
                case "jpeg":
                    SImageFormat = ImageFormat.Jpeg;
                    cbOutputFileType.SelectedIndex = 2;
                    SFileExtension = ".jpeg";
                    break;
                case "tiff":
                    SImageFormat = ImageFormat.Tiff;
                    cbOutputFileType.SelectedIndex = 3;
                    SFileExtension = ".tiff";
                    break;
                case "bmp":
                    SImageFormat = ImageFormat.Bmp;
                    cbOutputFileType.SelectedIndex = 4;
                    SFileExtension = ".bmp";
                    break;
                default:
                    SImageFormat = ImageFormat.Png;
                    cbOutputFileType.SelectedIndex = 0;
                    SFileExtension = ".png";
                    break;
            }
        }

        public FrmMain(string[] args)
        {
            //ScreenshotOnePro.exe -u http://www.barbez.eu -h 15000 -w 1000 -v 11EdgeMode -r reference [-m C:\Folder With Spaces\image.png]
            //string[] debug = new string[] { "-u", "http://www.barbez.eu", "-h", "15000", "-w", "1000", "-v", "11EdgeMode", "-r", "reference",
            //    "-m", "C:\\Folder", "With", "Spaces\\image.png" };
            //args = debug; //Uncomment te following line to debug

            InitializeComponent();
            Text = APPTITLE;
            lblWatermark.Text = NOWATERMARKSELECTED;
            tbWidth.Text = SWidth.ToString();
            tbHeight.Text = SHeight.ToString();
            cbEmulateIEver.SelectedIndex = 0;
            cbPreset.SelectedIndex = 0;
            cbOutputFileType.SelectedIndex = 0;

            if (args.Length > 0)
            {
                if (SetArguments(args))
                {
                    SetImageFormatAndFileExtension();
                    tbUrl.Text = argUrl;
                    tbWidth.Text = argWidth;
                    tbHeight.Text = argHeight;
                    tbFileReference.Text = GetFilenameSafeString(argReference);

                    switch (argVersion)
                    {
                        case "(Latest)":
                            cbEmulateIEver.SelectedIndex = 0;
                            break;
                        case "(Fake) Edge":
                            cbEmulateIEver.SelectedIndex = 1;
                            break;
                        case "11QuirksMode":
                            cbEmulateIEver.SelectedIndex = 2;
                            break;
                        case "11EdgeMode":
                            cbEmulateIEver.SelectedIndex = 3;
                            break;
                        case "10QuirksMode":
                            cbEmulateIEver.SelectedIndex = 4;
                            break;
                        case "10StandardsMode":
                            cbEmulateIEver.SelectedIndex = 5;
                            break;
                        case "9QuirksMode":
                            cbEmulateIEver.SelectedIndex = 6;
                            break;
                        case "9StandardsMode":
                            cbEmulateIEver.SelectedIndex = 7;
                            break;
                        case "8QuirksMode":
                            cbEmulateIEver.SelectedIndex = 8;
                            break;
                        case "8StandardsMode":
                            cbEmulateIEver.SelectedIndex = 9;
                            break;
                        case "7":
                            cbEmulateIEver.SelectedIndex = 10;
                            break;
                        default:
                            cbEmulateIEver.SelectedIndex = 0;
                            break;
                    }

                    if (argWatermarkUrl != "")
                        if (File.Exists(argWatermarkUrl))
                            lblWatermark.Text = argWatermarkUrl;
                }
            }
            SetInternetExplorerMode();
            if (lblOutputDirectory.Text == "")
                lblOutputDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (autorun)
                BtnTakeAPicture_Click(null, null); //PRO FEATURE
        }

        private bool SetArguments(string[] args)
        {
            try
            {
                //indices of values of respective parameters
                int file = -1; int d = -1; int l = -1; int t = -1; int u = -1; int v = -1; int h = -1; int w = -1; int m = -1; int r = -1;
                for (int i = 0; i < args.Length; i++)
                {
                    switch (args[i])
                    {
                        case "-file":
                            file = i + 1;
                            break;
                        case "-l":
                            l = i + 1;
                            break;
                        case "-t":
                            t = i + 1;
                            break;
                        case "-d":
                            d = i + 1;
                            break;
                        case "-u":
                            u = i + 1;
                            break;
                        case "-h":
                            h = i + 1;
                            break;
                        case "-w":
                            w = i + 1;
                            break;
                        case "-v":
                            v = i + 1;
                            break;
                        case "-r":
                            r = i + 1;
                            break;
                        case "-m":
                            m = i + 1;
                            break;
                    }
                }

                if (l > -1)
                {
                    if (!args[l].EndsWith("\\")) args[l] += "\\";
                    if (Directory.Exists(args[l]))
                    {
                        argOutputPath = args[l];
                        lblOutputDirectory.Text = args[l];
                    }
                }

                if (t > -1) argImageFormat = args[t];
                if (u > -1) argUrl = args[u];
                if (h > -1) argHeight = args[h];
                if (w > -1) argWidth = args[w];
                if (v > -1) argVersion = args[v];
                if (r > -1) argReference = args[r];
                if (d > -1) autorun = true;
                if (m > -1) argWatermarkUrl = args[m];

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ShowGuiWorking()
        {
            btnTakeAPicture.Visible = false;
            tbFileReference.Enabled = false;
            tbHeight.Enabled = false;
            tbWidth.Enabled = false;
            cbEmulateIEver.Enabled = false;
            cbOutputFileType.Enabled = false;
            cbPreset.Enabled = false;
            btnOutputDir.Enabled = false;
            tbUrl.Enabled = false;
            btnWatermarkSelecter.Enabled = false;
            btnNoWatermark.Enabled = false;
            btnBaseOnUrl.Enabled = false;
            btnBig.Enabled = false;
            btnBulk.Enabled = false;
            pbWorking.Style = ProgressBarStyle.Marquee;
        }

        private void ShowGuiDoneWorking()
        {
            btnTakeAPicture.Visible = true;
            tbFileReference.Enabled = true;
            tbHeight.Enabled = true;
            btnOutputDir.Enabled = true;
            tbWidth.Enabled = true;
            cbEmulateIEver.Enabled = true;
            cbPreset.Enabled = true;
            cbOutputFileType.Enabled = true;
            tbUrl.Enabled = true;
            btnNoWatermark.Enabled = true;
            btnWatermarkSelecter.Enabled = true;
            btnBaseOnUrl.Enabled = true;
            btnBig.Enabled = true;
            pbWorking.Style = ProgressBarStyle.Blocks;
            btnBulk.Enabled = true;
        }

        private void BtnTakeAPicture_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFileReference.Text))
            {
                tbFileReference.Text = $"{DateTime.UtcNow.ToString(Constants.FileNameCompatibleDateTime)}_With_ScreenshotOneProApp";
            }
            endOfRender = false;
            WorkFinishedDelegate wfd = new WorkFinishedDelegate(ShowGuiDoneWorking);

            if (CheckForValidInputs())
            {
                ShowGuiWorking();
                url = tbUrl.Text;

                Thread thread = new Thread(() =>
                {
                    RenderImage(this.url);
                        //This will be true if Current thread is not UI thread.
                        if (InvokeRequired)
                        Invoke(wfd);
                    else
                        wfd();
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                if (error == "") error = "Please correctly fill out all fields, then try again." + Environment.NewLine + Environment.NewLine +
                    "None of the fields can be empty and the dimensions can only contain (positive) numbers." + Environment.NewLine + Environment.NewLine +
                    "Also, spaces are not allowed anywhere except in the watermark field.";
                MessageBox.Show(error, APPTITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = "";
            }
        }

        private void SetInternetExplorerMode()
        {
            try
            {
                switch ((string)cbEmulateIEver.SelectedItem)
                {
                    case "(Latest)":
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion();
                        break;
                    case "Edge (Pretending)":
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion(BrowserEmulationVersion.Version12Edge);
                        break;
                    case "11 - Quirks Mode":
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion(BrowserEmulationVersion.Version11);
                        break;
                    case "11 - Edge Mode":
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion(BrowserEmulationVersion.Version11Edge);
                        break;
                    case "10 - Quirks Mode":
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion(BrowserEmulationVersion.Version10);
                        break;
                    case "10 - Standards Mode":
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion(BrowserEmulationVersion.Version10Standards);
                        break;
                    case "9 - Quirks Mode":
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion(BrowserEmulationVersion.Version9);
                        break;
                    case "9 - Standards Mode":
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion(BrowserEmulationVersion.Version9Standards);
                        break;
                    case "8 - Quirks Mode":
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion(BrowserEmulationVersion.Version8);
                        break;
                    case "8 - Standards Mode":
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion(BrowserEmulationVersion.Version8Standards);
                        break;
                    case "7":
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion(BrowserEmulationVersion.Version7);
                        break;
                    default:
                        InternetExplorerBrowserEmulation.SetBrowserEmulationVersion();
                        break;
                }
            }
            catch
            {
                InternetExplorerBrowserEmulation.SetBrowserEmulationVersion();
            }
        }

        private bool CheckForValidInputs()
        {
            bool allGood = true;
            string nmbrs = "0123456789";

            //Check or empty textboxes:
            if (string.IsNullOrEmpty(tbWidth.Text) | string.IsNullOrEmpty(tbHeight.Text) | string.IsNullOrEmpty(tbUrl.Text))
                allGood = false;

            if (allGood)
            {
                //Check for all-numbers input in both the width and height textboxes:
                foreach (char nmbr in tbHeight.Text)
                    if (!nmbrs.Contains(nmbr.ToString())) allGood = false;
                foreach (char nmbr in tbWidth.Text)
                    if (!nmbrs.Contains(nmbr.ToString())) allGood = false;
            }

            if (allGood)
            {
                //Assume by now that the height and width textboxes have been filled out with numbers:
                allGood = int.TryParse(tbHeight.Text, out SHeight);
                if (allGood)
                {
                    allGood = int.TryParse(tbWidth.Text, out SWidth);
                    if (SHeight < 1 | SWidth < 1) allGood = false;
                }
            }

            foreach (char c in Constants.CHARSNOTALLOWEDINFILENAMES)
                if (tbFileReference.Text.Contains(c.ToString()))
                {
                    allGood = false;
                    error = "Character '" + c + "' is not allowed in the file name. Please remove it and try again.";
                    break;
                }
            if (allGood && !tbUrl.Text.StartsWith("file:///")) allGood = Uri.IsWellFormedUriString(tbUrl.Text, UriKind.RelativeOrAbsolute);
            if (allGood && Directory.Exists(lblOutputDirectory.Text)) argOutputPath = lblOutputDirectory.Text;


            switch (cbOutputFileType.SelectedIndex)
            {
                case 0:
                    SImageFormat = ImageFormat.Png;
                    SFileExtension = ".png";
                    break;
                case 1:
                    SImageFormat = ImageFormat.Gif;
                    SFileExtension = ".gif";
                    break;
                case 2:
                    SImageFormat = ImageFormat.Jpeg;
                    SFileExtension = ".jpeg";
                    break;
                case 3:
                    SImageFormat = ImageFormat.Tiff;
                    SFileExtension = ".tiff";
                    break;
                case 4:
                    SImageFormat = ImageFormat.Bmp;
                    SFileExtension = ".bmp";
                    break;
                default:
                    SImageFormat = ImageFormat.Png;
                    cbOutputFileType.SelectedIndex = 0;
                    SFileExtension = ".png";
                    break;
            }

            return allGood;
        }

        void Wb_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress == e.MaximumProgress)
            {
                WebBrowserEx wb = sender as WebBrowserEx;
                wb.ProgressChanged -= Wb_ProgressChanged;
                try
                {
                    int scrollWidth = 0;
                    int scrollHeight = 0;

                    scrollHeight = wb.Document.Body.ScrollRectangle.Height;
                    scrollWidth = wb.Document.Body.ScrollRectangle.Width;
                    wb.Size = new Size(scrollWidth, scrollHeight);

                    Bitmap bitmap = new Bitmap(wb.Width, wb.Height);
                    for (int Xcount = 0; Xcount < bitmap.Width; Xcount++)
                        for (int Ycount = 0; Ycount < bitmap.Height; Ycount++)
                            bitmap.SetPixel(Xcount, Ycount, Color.Black);
                    wb.DrawToBitmap(bitmap, new Rectangle(0, 0, wb.Width, wb.Height));
                }
                catch { }
            }
        }

        private void RenderImage(string url)
        {
            try
            {
                using (WebBrowserEx wb = new WebBrowserEx())
                {
                    wb.DocumentCompleted += Browser_DocumentCompletedSingle;
                    wb.ProgressChanged += Wb_ProgressChanged;
                    wb.ScrollBarsEnabled = false;
                    wb.Navigate(url);
                    wb.Refresh(WebBrowserRefreshOption.Completely);

                    while (wb.IsBusy)
                        Application.DoEvents();
                    for (int i = 0; i < AMOUNTOFITERATIONS; i++)
                        if (wb.ReadyState != WebBrowserReadyState.Complete)
                        {
                            Application.DoEvents();
                            Thread.Sleep(SLEEPTIME);
                        }
                        else
                            break;

                    Thread.Sleep(SLEEPTIME * 50); //To make sure websites are properly rendered
                    Application.DoEvents();
                    endOfRender = true;
                    Browser_DocumentCompletedSingle(wb, new WebBrowserDocumentCompletedEventArgs(wb.Url));
                }
            }
            catch
            {
                if (error == "") error = "Something went wrong.\r\n\r\nCheck if you have a working internet connection. In case that does not help, restart the application and try again.";
                MessageBox.Show(error, APPTITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = "";
            }
        }

        private void Browser_DocumentCompletedSingle(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (endOfRender)
            {
                WebBrowserEx wb = sender as WebBrowserEx;
                wb.Document.Window.Error += new HtmlElementErrorEventHandler(Window_Error);

                try
                {
                    string filename = wb.Document.Title;
                    wb.Width = wb.Document.Body.ScrollRectangle.Width;
                    wb.Height = wb.Document.Body.ScrollRectangle.Height + DEFAULTHEIGHOFFSET;

                    if (wb.Width == 0 | wb.Height == 0)
                    {
                        wb.Height = 1;
                        wb.Width = 1;
                    }

                    wb.MaximumSize = new Size(SWidth, SHeight);
                    wb.Width = SWidth;

                    //Crop images to prevent crashes/reduce required disk space
                    if (wb.Height > SHeight) wb.Height = SHeight;

                    using (Bitmap bitmap = new Bitmap(wb.Width, wb.Height))
                    {
                        DateTime dt = DateTime.Now;
                        if (argOutputPath != "")
                        {
                            folder = argOutputPath;
                            if (!argOutputPath.EndsWith("\\"))
                                folder += "\\";
                        }
                        else folder = Path.GetTempPath();
                        string imagePath = folder + tbFileReference.Text + SFileExtension;

                        NativeMethods.GetImage(wb.ActiveXInstance, bitmap, Color.White); //Solution to get google working: http://stackoverflow.com/posts/27590132/revisions

                        byte[] imgBytes;
                        if (argWatermarkUrl == NOWATERMARKSELECTED)
                            imgBytes = ImageToByte(bitmap);
                        else
                            imgBytes = ImageToByte(bitmap, argWatermarkUrl);
                        File.WriteAllBytes(imagePath, imgBytes);

                        ShowResultDelegate wfd = new ShowResultDelegate(ShowResultOnGui);
                        if (InvokeRequired)
                            Invoke(wfd, imagePath);
                        else
                            ShowResultOnGui(imagePath);

                        if (autorun)
                        {
                            Close();
                            //Application.Exit();
                        }
                    }
                }
                catch
                {
                    if (error == "") error = "Something went wrong.\r\n\r\nPlease try lowering the dimension sizes or check if you have a working internet connection. In case that does not help, restart the application and try again.";
                    MessageBox.Show(error, APPTITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = "";
                }
            }
        }

        private static Image CreateImage(string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                return Image.FromStream(fs);
        }

        private void ShowResultOnGui(string imagePath)
        {
            lblResult.Text = imagePath; //Set result label
            args = "\"" + lblResult.Text + "\"";

            btnCopyToClipboard.Visible = true;
            btnShowFileInFolder.Visible = true;
            btnShowInImageViewer.Visible = true;
            btnCopyOpenShow.Visible = true;
            btnDelete.Visible = true;
            lblRate.Visible = true;
        }

        private static void RunExternalProcess(string appPath, string args, bool awaitFinish = false)
        {
            ProcessStartInfo info = new ProcessStartInfo(appPath, @args)
            {
                UseShellExecute = false,
            };
            Process p = new Process
            {
                StartInfo = info,

            };
            p.Start();
            if (awaitFinish)
                p.WaitForExit();
        }

        private byte[] ImageToByte(Bitmap img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, SImageFormat);
            img.Dispose(); //Dispose all resources - System.Drawing uses unmanaged GDI+ resources
            return ms.ToArray();
        }

        private byte[] ImageToByte(Bitmap img, string watermarkFilePath)
        {
            Image watermark = CreateImage(watermarkFilePath);
            Graphics g = Graphics.FromImage(img);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            int repeatX = 1;
            int repeatY = 1;

            if (watermark.Width > 0) repeatX = 2 + img.Width / watermark.Width;
            if (watermark.Height > 0) repeatY = 2 + img.Height / watermark.Height;

            for (int x = 0; x < repeatX; x++)
                for (int y = 0; y < repeatY; y++)
                    g.DrawImage(watermark, new Point(img.Width - x * watermark.Width, img.Height - y * watermark.Height));

            MemoryStream ms = new MemoryStream();
            img.Save(ms, SImageFormat);

            //Dispose all resources - System.Drawing uses unmanaged GDI+ resources:
            img.Dispose();
            watermark.Dispose();
            g.Flush();

            return ms.ToArray();
        }

        private void LblResult_Click(object sender, EventArgs e)
        {
            BtnShowInImageViewer_Click(sender, e);
        }

        private void BtnShowInImageViewer_Click(object sender, EventArgs e)
        {
            RunExternalProcess("explorer.exe", this.args); //Start default file viewer application
        }

        private void BtnShowFileInFolder_Click(object sender, EventArgs e)
        {
            RunExternalProcess("explorer.exe", "/select," + lblResult.Text); //Start default file viewer application
        }

        private void BtnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblResult.Text); //Copy result location to clipboard
        }

        private void BtnCopyOpenShow_Click(object sender, EventArgs e)
        {
            BtnShowInImageViewer_Click(sender, e);
            BtnShowFileInFolder_Click(sender, e);
            BtnCopyToClipboard_Click(sender, e);
        }

        private void BtnWatermarkSelecter_Click(object sender, EventArgs e)
        {
            string path = Generic.OpenImageSelectionDialog();
            if (!string.IsNullOrWhiteSpace(path))
            {
                lblWatermark.Text = path;
                argWatermarkUrl = path;
            }
        }

        private void LblRate_Click(object sender, EventArgs e)
        {
            Generic.OpenUri(MSSTORERATINGURL);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(lblResult.Text);
                MessageBox.Show("Succesfully deleted the image.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Could not delete file. Please try again manually.", "Can't delete file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetThisAppsName()
        {
            string file = GetType().Assembly.Location;
            return Path.GetFileNameWithoutExtension(file) + ".exe";
        }

        private void CbEmulateIEver_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Render();
            Application.Exit();
        }

        private void Render(string url = null, bool awaitFinish = false, bool autorun = false)
        {
            if (!string.IsNullOrWhiteSpace(url))
                url = " -u " + url;
            else if (!string.IsNullOrEmpty(tbUrl.Text))
                url = " -u " + tbUrl.Text;
            else url = "";
            string ver = "";
            foreach (string s in (((string)cbEmulateIEver.SelectedItem).Split(new char[] { ' ', '-' })))
                ver += s;
            string args = "-v \"" + ver + "\"";
            if (autorun)
                args += " -d Y";
            if (!string.IsNullOrEmpty((string)cbOutputFileType.SelectedItem))
                args += " -t " + (string)cbOutputFileType.SelectedItem;
            args += url;
            if (!string.IsNullOrEmpty(tbHeight.Text)) args += " -h " + tbHeight.Text;
            if (!string.IsNullOrEmpty(tbWidth.Text)) args += " -w " + tbWidth.Text;
            if (!string.IsNullOrEmpty(lblOutputDirectory.Text)) args += " -l \"" + lblOutputDirectory.Text + "\"";
            if (!string.IsNullOrEmpty(tbFileReference.Text)) args += " -r \"" + tbFileReference.Text + "\"";
            if (!string.IsNullOrEmpty(lblWatermark.Text)) args += " -m \"" + lblWatermark.Text + "\"";
            RunExternalProcess(GetThisAppsName(), args, awaitFinish); // "Restart" myself
        }

        private void BtnNoWatermark_Click(object sender, EventArgs e)
        {
            lblWatermark.Text = NOWATERMARKSELECTED;
            argWatermarkUrl = lblWatermark.Text;
        }

        private void BtnBig_Click(object sender, EventArgs e)
        {
            tbHeight.Text = LONG;
            tbWidth.Text = SWidth.ToString();
        }

        private void BtnBaseOnUrl_Click(object sender, EventArgs e)
        {
            tbFileReference.Text = GetFilenameSafeString(tbUrl.Text);
        }

        private string GetFilenameSafeString(string text)
        {
            string[] split = text.Split(Constants.CHARSNOTALLOWEDINFILENAMES, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            for (int i = 0; i < split.Length; i++)
            {
                if (i == split.Length - 1) result += split[i];
                else result += split[i] + "-";
            }
            return result;
        }

        private void BtnOutputDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK)
                lblOutputDirectory.Text = fbd.SelectedPath;
        }

        private void CbPreset_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string[] preset = ((string)cbPreset.SelectedItem).Split(new char[] { 'x' });
            if (preset.Length > 1)
            {
                tbWidth.Text = preset[0];
                tbHeight.Text = preset[1];
            }
        }

        private void BtnBulk_Click(object sender, EventArgs e)
        {
            if (frmBulk.WorkFinishedDelegate == null)
            {
                frmBulk.WorkFinishedDelegate = new WorkFinishedDelegate(RenderInBulkAsync);
            }
            DialogResult dialogResult = frmBulk.ShowDialog();
        }

        internal async void RenderInBulkAsync()
        {
            switch (frmBulk.BulkOperationType)
            {
                case BulkOperationType.UrlsOnly:
                    await Task.Run(() => RunUrlsOnlyBulkOperation());
                    break;
                case BulkOperationType.Advanced:
                    await Task.Run(() => RunAdvancedBulkOperation());
                    break;
                default:
                    break;
            }
            if (frmBulk.Visible)
            {
                frmBulk.Close();
            }
        }

        private void RunAdvancedBulkOperation()
        {
            for (int i = 0; i < frmBulk.Args.Length; i++)
            {
                RunExternalProcess(GetThisAppsName(), frmBulk.Args[i], true);
                frmBulk.ProgressBarDelegate.Invoke();
                if (i < frmBulk.Args.Length - 1)
                    BePolite();
            }
            frmBulk.ToggleUIDelegate.Invoke();
        }

        private void RunUrlsOnlyBulkOperation()
        {
            for (int i = 0; i < frmBulk.Uris.Length; i++)
            {

                Invoke(new MethodInvoker(() =>
                {
                    Render(frmBulk.Uris[i], true, true);
                    frmBulk.ProgressBarDelegate.Invoke();
                }));
                if (i < frmBulk.Uris.Length - 1)
                    BePolite();
            }
            frmBulk.ToggleUIDelegate.Invoke();
        }

        private void BePolite()
        {
            if (frmBulk.Polite)
            {
                Thread.Sleep(new Random(321).Next(INTERVAL, INTERVAL * 4));
            }
        }

        private void BtnPasteUrl_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                tbUrl.Text = clipboardText;
            }
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            var input = string.Empty;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                int filterindex = 0;
                ofd.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                ofd.FilterIndex = filterindex; //Aids in setting the correct default extension
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    if (File.Exists(fileName))
                    {
                        input = fileName;
                    }
                }
            }
            if (!string.IsNullOrEmpty(input))
            {
                input = input.Replace(@"\", @"/");
                tbUrl.Text = "file:///" + input;
            }
        }
    }
}
