using System;
using System.IO;

namespace MkDocsGenerator.GeneratePage
{
    class TestPip
    {
        private Boolean testPip()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c pip list";
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;

            p.Start();

            StreamReader outputWriter = p.StandardOutput;
            String errorReader = p.StandardError.ReadToEnd();
            String line = outputWriter.ReadLine();
            while (line != null)
            {
                if (line.ToLower().Contains("mkdocs"))
                {
                    return true;

                }
                line = outputWriter.ReadLine();
            }
            return false;
        }
    }
}
