using MkDocsGenerator.GeneratePage.CopyFolder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MkDocsGenerator.GeneratePage.BuildWebPage
{
    class MoveCompiled
    {
        public MoveCompiled(string current, string outputFolder)
        {
            new DirectoryCopy().CopyAllDirectory(current, outputFolder, true);
        }
    }
}
