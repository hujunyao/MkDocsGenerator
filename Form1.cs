using MkDocsGenerator.InputOutputFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MkDocsGenerator
{
    public partial class Form1 : Form
    {
        string inputFolder;
        string outputFolder;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstructura_Click(object sender, EventArgs e)
        {
            inputFolder = new LoadFolder().loadFolder();
            txtEstructura.Text = inputFolder;
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            outputFolder = new LoadFolder().loadFolder();
            Console.WriteLine(outputFolder);
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



    }
}




