using MkDocsGenerator.generateMd.Pandoc;
using MkDocsGenerator.generateMd.WordHandling;
using System.IO;

namespace MkDocsGenerator.generateMd.FormEvents
{
    class GenerateMdFile
    {
        public GenerateMdFile(string inputFile, string outputFolder, int start, int end, int total, bool completeDocument)
        {
            string outputTempFile = Directory.GetCurrentDirectory() + @"\tempDoc.docx";
            if (completeDocument)
            {
                new CopyDocument(inputFile, outputTempFile);
            }
            else
            {
                new SelectedPages(inputFile, outputTempFile, start, end, total);
            }
            new ConvertDocxMd(outputTempFile, outputFolder);


        }
    }
}
