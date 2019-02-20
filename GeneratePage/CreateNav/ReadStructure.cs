using MkDocsGenerator.GeneratePage.CopyFolder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MkDocsGenerator.GeneratePage.CreateNav
{
    class ReadStructure
    {
        String[] folders;

        public string loadContentFolder(String path)
        {
            folders = Directory.GetDirectories(path);
            return writeInMkDocsYml(path);
        }

        public string writeInMkDocsYml(String path)
        {
            String newContentBar = "pages:\n";
            foreach (var folder in folders)
            {
                String tempFolder = Path.GetFileName(folder);
                newContentBar += "- " + tempFolder + ": ";
                newContentBar += "\n";
                newContentBar += "  ";
                DirectoryInfo di = new DirectoryInfo(folder);
                foreach (var file in di.GetFiles())
                {
                    newContentBar += "  ";
                    String name = Path.GetFileNameWithoutExtension(file.Name);
                    newContentBar += "- " + name + ": " + tempFolder + @"/" + file.Name;
                    newContentBar += "\n";
                }

            }
            return newContentBar;
        }
    }
}
