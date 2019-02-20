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
            String newContentBar = "nav:\n";
            newContentBar += makeContentBar(1);
            return newContentBar;
        }



        private string makeContentBar(int tabs)
        {
            String contentBar = "";
            foreach (var folder in folders)
            {
                for (int i = 0; i < tabs; i++)
                {
                    contentBar += "  ";
                }
                String tempFolder = Path.GetFileName(folder);
                contentBar += "- " + tempFolder + " : ";
                contentBar += "\n";
                DirectoryInfo di = new DirectoryInfo(folder);
                foreach (var file in di.GetFiles())
                {
                    for (int i = 0; i < tabs; i++)
                    {
                        contentBar += "  ";
                    }
                    String name = Path.GetFileNameWithoutExtension(file.Name);
                    contentBar += "- " + name + " : " + tempFolder + @"/" + file.Name;
                    contentBar += "\n";
                }
                ReadStructure subfolders = new ReadStructure();
                subfolders.loadContentFolder(folder);
                tabs++;
                contentBar += subfolders.makeContentBar(tabs);
                tabs = 1;
            }
            return contentBar;
        }
    }
}
