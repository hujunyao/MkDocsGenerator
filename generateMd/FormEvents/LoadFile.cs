using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MkDocsGenerator.generateMd.FormEvents
{
    class LoadFile
    {
        public string GetFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return openFileDialog.InitialDirectory + openFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }
    }
}
