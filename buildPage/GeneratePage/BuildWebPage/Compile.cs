using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MkDocsGenerator.GeneratePage.BuildWebPage
{
    class Compile
    {
        public Compile()
        {
            string argument = "cd " + Directory.GetCurrentDirectory() + @"\MkDocs & mkdocs build";
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + argument);
            Console.WriteLine(argument);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            using (Process process = new Process())
            {
                process.StartInfo = procStartInfo;
                process.Start();
                process.WaitForExit();
            }
        }
    }
}
