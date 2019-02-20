using MkDocsGenerator.GeneratePage;
using MkDocsGenerator.GeneratePage.BuildWebPage;
using MkDocsGenerator.GeneratePage.CopyFolder;
using MkDocsGenerator.GeneratePage.CreateNav;
using MkDocsGenerator.GeneratePage.Directories;
using System;
using System.Collections.Generic;
using System.IO;
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
                Program.f1.listboxResultados.Items.Add("Los complementos están instalados correctamente");

                Program.f1.listboxResultados.Items.Add("Generando nueva barra de navegación...");
                string contentBar = new ReadStructure().loadContentFolder(inputFolder);
                Console.Write(contentBar);
                Program.f1.listboxResultados.Items.Add("Creando archivo mkdocs.yml...");
                new WriteStructure(contentBar);

                Program.f1.listboxResultados.Items.Add(@"Eliminando archivos existentes de la carpeta \MkDocs\docs...");
                string DocsFolder = Directory.GetCurrentDirectory() + @"\MkDocs\docs";
                new RemoveDocs(DocsFolder);
                Program.f1.listboxResultados.Items.Add(@"Copiando nuevos archivos markdown al directorio \MkDocs\docs...");
                new DirectoryCopy().CopyAllDirectory(inputFolder, DocsFolder, true);

                Program.f1.listboxResultados.Items.Add("Eliminando archivos de la carpeta de salida...");
                new RemoveDocs(outputFolder);

                Program.f1.listboxResultados.Items.Add("Construyendo nueva página...");
                new Compile();

                Program.f1.listboxResultados.Items.Add("Copiando archivos de la nueva página a la carpeta seleccionado...");
                new MoveCompiled(Directory.GetCurrentDirectory() + @"\MkDocs\site", outputFolder);

                Program.f1.listboxResultados.Items.Add("El proceso se ha terminado exitosamente");
            }
            else
            {
                Program.f1.listboxResultados.Items.Add("No se ha podido instalar alguno de los complementos");
            }
        }
    }
}
