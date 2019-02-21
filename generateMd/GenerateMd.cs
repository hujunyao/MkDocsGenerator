using MkDocsGenerator.generateMd.FormEvents;
using MkDocsGenerator.generateMd.WordHandling;
using MkDocsGenerator.InputOutputFolder;
using System;
using System.Windows.Forms;

namespace MkDocsGenerator
{
    public partial class GenerateMd : Form
    {
        private string inputFile;
        private string outputFolder;
        int pageCount = 0;

        public GenerateMd()
        {
            InitializeComponent();
        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            inputFile = new LoadFile().GetFile();
            txtDocumento.Text = inputFile;
            if (!String.IsNullOrEmpty(inputFile))
            {
                pnlPages.Enabled = true;
                pageCount = new PagesCount().GetPagesCount(inputFile);
                nudTo.Value = pageCount;
                nudTo.Maximum = pageCount;
            }
            else
            {
                pnlPages.Enabled = false;
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            outputFolder = new LoadFolder().GetFolder();
            txtSalida.Text = outputFolder;
        }

        private void BuildPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragWindow.ReleaseCapture();
                DragWindow.SendMessage(Handle, DragWindow.WM_NCLBUTTONDOWN, DragWindow.HT_CAPTION, 0);
            }
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (inputFile != null || outputFolder != null)
            {
                richtextResult.Text = "";
                new GenerateMdFile(inputFile, outputFolder, Convert.ToInt32(nudFrom.Value), Convert.ToInt32(nudTo.Value), pageCount, rbCompletePage.Checked);
            }
            else
            {
                MessageBox.Show("No se han seleccionado los directorios");
            }
        }

        private void rbCompletePage_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCompletePage.Checked)
            {
                pnlSelectedPages.Enabled = false;
            }
        }

        private void rbSelectedPages_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSelectedPages.Checked)
            {
                pnlSelectedPages.Enabled = true;
            }
        }
    }
}
