using MkDocsGenerator.generateMd.FormEvents;
using MkDocsGenerator.InputOutputFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MkDocsGenerator
{
    public partial class GenerateMd : Form
    {
        private string inputFile;
        private string outputFolder;

        public GenerateMd()
        {
            InitializeComponent();
        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            inputFile = new LoadFile().GetFile();
            txtDocumento.Text = inputFile;
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
                new GenerateMdFile(inputFile, outputFolder);
            }
            else
            {
                MessageBox.Show("No se han seleccionado los directorios");
            }
        }
    }
}
