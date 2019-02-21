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
    public partial class Home : Form
    {

        public static BuildPage buildPage;
        public static GenerateMd generateMd;

        public Home()
        {
            InitializeComponent();
        }

        private void btnBuildPage_Click(object sender, EventArgs e)
        {
            buildPage = new BuildPage();
            this.Hide();
            buildPage.ShowDialog();
            this.Show();
        }

        private void btnGenerateMd_Click(object sender, EventArgs e)
        {
            generateMd = new GenerateMd();
            this.Hide();
            generateMd.ShowDialog();
            this.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
            Application.Exit();
        }
    }
}
