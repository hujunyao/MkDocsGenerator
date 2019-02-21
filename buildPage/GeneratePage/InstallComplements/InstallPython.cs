using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MkDocsGenerator.GeneratePage.InstallComplements
{
    class InstallPython
    {
        public InstallPython()
        {
            string argument = "cd " + Directory.GetCurrentDirectory() + @" & start /wait Complementos\python-3.7.1.exe";
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
