using MkDocsGenerator.GeneratePage.CopyFolder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MkDocsGenerator.GeneratePage.CreateNav
{
    class ReadStructure
    {
        String[] folders;
        public ReadStructure(String path)
        {
            folders = Directory.GetDirectories(path);
        }
        public String getNavbar(String path)
        {
            String newContentBar = "nav:\n";
            newContentBar += makeContentBar(1, path);
            return newContentBar;
        }

        private string makeContentBar(int tabs, String path)
        {
            String contentBar = "";
            foreach (var folder in folders)
            {
                for (int i = 0; i < tabs; i++)
                {
                    contentBar += "  ";
                }
                String tempFolder = Path.GetFileName(folder);
                string slash = @"/";
                string backSlash = @"\";
                String tempFolderFile = folder.Substring(path.Length + 1).Replace(backSlash, slash);
                contentBar += "- " + tempFolder + " : ";
                contentBar += "\n";
                tabs++;
                contentBar += getFilesInFolder(folder, tabs, tempFolderFile);
                ReadStructure subfolders = new ReadStructure(folder);
                contentBar += subfolders.makeContentBar(tabs, path);
                if (this.countFolders() == 0)
                {
                    tabs = 1;
                }
                else
                {
                    tabs--;
                }
            }
            return contentBar;
        }

        public int countFolders()
        {
            return folders.Length;
        }

        private string getFilesInFolder(String folder, int tabs, String tempFolderFile)
        {
            String files = "";

            DirectoryInfo di = new DirectoryInfo(folder);
            foreach (var file in di.GetFiles())
            {
                for (int i = 0; i < tabs; i++)
                {
                    files += "  ";
                }
                String name = Path.GetFileNameWithoutExtension(file.Name);
                files += "- '" + name + "' : " + tempFolderFile + ((String.IsNullOrEmpty(tempFolderFile)) ? "" : @"/") + file.Name;
                files += "\n";
            }
            return files;
        }

    }
}


