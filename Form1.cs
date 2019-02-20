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

    }
}




