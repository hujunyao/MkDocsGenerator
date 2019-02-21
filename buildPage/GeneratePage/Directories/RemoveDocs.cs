using System.IO;

namespace MkDocsGenerator.GeneratePage.Directories
{
    class RemoveDocs
    {
        public RemoveDocs(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo file in dir.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo directory in dir.GetDirectories())
            {
                directory.Delete(true);
            }
        }
    }
}