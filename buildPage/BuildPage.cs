using MkDocsGenerator.InputOutputFolder;
using System;
using System.IO;
using System.Windows.Forms;

namespace MkDocsGenerator
{
    public partial class BuildPage : Form
    {
        string inputFolder;
        string outputFolder;

        public BuildPage()
        {
            InitializeComponent();
            LoadDocumentsFolder();
        }

        private void btnEstructura_Click(object sender, EventArgs e)
        {
            inputFolder = new LoadFolder().GetFolder();
            txtEstructura.Text = inputFolder;
        }

        private void LoadDocumentsFolder()
        {
            outputFolder = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), @"Documents\Pagina generada");
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            txtSalida.Text = outputFolder;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (inputFolder != null || outputFolder != null)
            {
                listboxResultados.Items.Clear();
                new GenerateWebPage(inputFolder, outputFolder);
            }
            else
            {
                MessageBox.Show("No se han seleccionado los directorios");
            }
        }

        public void InsertText(string text)
        {
            listboxResultados.Items.Add(text);
        }

        private void listboxResultados_SizeChanged(object sender, EventArgs e)
        {
            listboxResultados.SelectedIndex = listboxResultados.Items.Count - 1;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BuildPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragWindow.ReleaseCapture();
                DragWindow.SendMessage(Handle, DragWindow.WM_NCLBUTTONDOWN, DragWindow.HT_CAPTION, 0);
            }
        }


    }
}




