using MkDocsGenerator.GeneratePage.BuildWebPage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MkDocsGenerator.GeneratePage.CreateNav
{
    class WriteStructure
    {
        public WriteStructure(string navText)
        {
            bool InsideNav = false;
            string FilePath = Directory.GetCurrentDirectory() + @"\MkDocs\mkdocs.yml";
            string NewFilePath = Directory.GetCurrentDirectory() + @"\MkDocs\mkdocs2.yml";
            if (File.Exists(FilePath))
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Equals("#endnav"))
                        {
                            InsideNav = false;
                            using (StreamWriter file = new StreamWriter(NewFilePath, true))
                            {
                                file.Write(navText);
                                file.WriteLine();
                                file.Close();
                            }
                        }
                        else if (line.Equals("nav:") || InsideNav == true)
                        {
                            InsideNav = true;
                        }
                        else
                        {
                            using (StreamWriter file = new StreamWriter(NewFilePath, true))
                            {
                                file.WriteLine(line);
                                file.Close();
                            }
                        }
                    }
                    sr.Close();
                }
                File.Delete(FilePath);
                File.Move(NewFilePath, Directory.GetCurrentDirectory() + @"\MkDocs\mkdocs.yml");
            }
            else
            {
                throw new FileNotFoundException("No se ha encontrado el archivo de configuración mkdocs.yml dentro de la plantilla");
            }
        }
    }
}
