using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MkDocsGenerator.GeneratePage.InstallComplements
{
    class InstallMkDocs
    {
        public InstallMkDocs()
        {
            string argument = "cd " + Directory.GetCurrentDirectory() + @" & start /wait bat\mkdocs.bat";
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + argument);

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
