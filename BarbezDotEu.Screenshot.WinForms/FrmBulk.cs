// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the MIT License.

using ScreenshotOnePro.Logic;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ScreenshotOnePro
{
    public partial class FrmBulk : Form
    {
        internal BulkOperationType BulkOperationType { get; private set; }

        internal WorkFinishedDelegate WorkFinishedDelegate { get; set; }

        internal WorkFinishedDelegate ProgressBarDelegate { get; set; }

        internal WorkFinishedDelegate ToggleUIDelegate { get; set; }

        private bool canClose = true;

        internal string[] Uris
        {
            get
            {
                return tbUrls.Text.Split(new string[] { Environment.NewLine, ",", ";", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToArray();
            }
        }

        internal string[] Args => tbAdvanced.Lines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

        internal bool Polite => cbPolite.Checked;

        internal bool Invoked { get; set; }

        public FrmBulk()
        {
            InitializeComponent();
            ProgressBarDelegate = new WorkFinishedDelegate(TickBar);
            ToggleUIDelegate = new WorkFinishedDelegate(ResetUI);
            InitAbout();
        }

        private void InitAbout()
        {
            Text = AssemblyTitle;
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = string.Format("Version {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            textBoxDescription.Text = AssemblyDescription + Environment.NewLine + Environment.NewLine
                + Constants.THANKS + Environment.NewLine + Environment.NewLine
                + Constants.THIRDPARTY;

            llBarbezEu.Links.Add(0, llBarbezEu.Text.Length, llBarbezEu.Text);
        }

        private void ResetUI()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() =>
                {
                    ToggleUI();
                }));
            }
            else
            {
                ToggleUI();
            }
        }

        private void TickBar()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() =>
                {
                    pbProgress.Value++;
                }));
            }
            else
            {
                pbProgress.Value++;
            }
        }

        private void FrmBulk_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!canClose)
            {
                e.Cancel = true;
            }
            canClose = true;
        }

        private void ToggleUI(int itemCount = 100)
        {
            if (btnAdvanced.Enabled)
            {
                btnAdvanced.Enabled = false;
                lblAdvanced.Enabled = false;
                lblUrls.Enabled = false;
                cbPolite.Enabled = false;
                tbAdvanced.Enabled = false;
                tbUrls.Enabled = false;
                tcBulk.Enabled = false;
                pbProgress.Visible = true;
                pbProgress.Maximum = itemCount;
                pbProgress.Value = 0;
            }
            else
            {
                btnAdvanced.Enabled = true;
                lblAdvanced.Enabled = true;
                lblUrls.Enabled = true;
                cbPolite.Enabled = true;
                tbAdvanced.Enabled = true;
                tbUrls.Enabled = true;
                tcBulk.Enabled = true;
            }
        }

        private void BtnAdvanced_Click(object sender, EventArgs e)
        {
            switch (tcBulk.SelectedIndex)
            {
                case 0:
                    BulkOperationType = BulkOperationType.UrlsOnly;
                    break;
                case 1:
                    BulkOperationType = BulkOperationType.Advanced;
                    break;
            }

            canClose = false;
            ToggleUI(Uris.Length);
            WorkFinishedDelegate.Invoke();
        }

        private void TpAbout_Enter(object sender, EventArgs e)
        {
            btnAdvanced.Visible = false;
            cbPolite.Visible = false;
        }

        private void TpAbout_Leave(object sender, EventArgs e)
        {
            btnAdvanced.Visible = true;
            cbPolite.Visible = true;
        }

        #region Assembly Attribute Accessors
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void LlBarbezEu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Generic.OpenUri(llBarbezEu.Text);
        }
    }
}
