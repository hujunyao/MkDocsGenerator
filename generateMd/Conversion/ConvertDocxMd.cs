using MkDocsGenerator.GeneratePage.CopyFolder;
using System;
using System.IO;

namespace MkDocsGenerator.generateMd.Pandoc
{
    class ConvertDocxMd
    {
        string inputFile, outputFolder;

        public ConvertDocxMd(string inputFile, string outputFolder)
        {
            this.inputFile = inputFile;
            this.outputFolder = outputFolder + @"\";
            String fileName = Path.GetFileNameWithoutExtension(inputFile);
            fileName = getFileName(fileName, 0, fileName);
            String media = Path.GetFileNameWithoutExtension(fileName) + "[img]";
            Console.WriteLine(media);
            string command = " cd " + Directory.GetCurrentDirectory() + @"\Complementos\Pandoc && pandoc --extract-media " + media + " " + inputFile + " -t markdown -o " + fileName + ".md";
            runCommand(command);


            File.Move(Directory.GetCurrentDirectory() + @"\Complementos\Pandoc\" + fileName + ".md", outputFolder + @"\" + fileName + ".md");
            new DirectoryCopy().CopyAllDirectory(Directory.GetCurrentDirectory() + @"\Complementos\Pandoc\" + media, outputFolder + @"\" + media, true);
        }


        private String getFileName(String file, int iterator, String originName)
        {
            if (File.Exists(outputFolder + file + ".md"))
            {
                iterator++;
                file = originName + "(" + iterator.ToString() + ")";
                getFileName(file, iterator, originName);
            }
            return Path.GetFileNameWithoutExtension(file);
        }

        private void runCommand(String command)
        {
            var d = System.Diagnostics.Process.Start("CMD.exe", "/c " + command);
            d.WaitForExit();
        }

    }
}
