using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MkDocsGenerator.InputOutputFolder
{
    class LoadFolder
    {
        public string GetFolder()
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string Res = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                return Res;
            }
            else
            {
                return null;
            }
        }
    }
}
