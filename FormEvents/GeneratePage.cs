using MkDocsGenerator.GeneratePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MkDocsGenerator.InputOutputFolder
{
    class GenerateWebPage
    {
        public GenerateWebPage(string inputFolder, string outputFolder)
        {
            if (new CheckComplements().Check() == true)
            {

            }
            else
            {
                Program.f1.listboxResultados.Items.Add("aaaaaaaaaaaaaa");
            }
        }
    }
}
