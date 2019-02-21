using System.IO;

namespace MkDocsGenerator.generateMd.WordHandling
{
    class CopyDocument
    {
        public CopyDocument(string document, string destination)
        {
            if (File.Exists(destination))
            {
                File.Delete(destination);
            }
            File.Copy(document, destination);
        }
    }
}
