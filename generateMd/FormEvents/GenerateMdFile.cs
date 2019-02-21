using Microsoft.Office.Interop.Word;
using MkDocsGenerator.generateMd.Pandoc;
using MkDocsGenerator.generateMd.WordHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MkDocsGenerator.generateMd.FormEvents
{
    class GenerateMdFile
    {
        public GenerateMdFile(string inputFile, string outputFolder)
        {
            //new SelectedPages(inputFile, outputFolder);
            new ConvertDocxMd(inputFile, outputFolder);
        }
    }
}
