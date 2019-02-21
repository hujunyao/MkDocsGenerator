using MkDocsGenerator.GeneratePage;
using MkDocsGenerator.GeneratePage.BuildWebPage;
using MkDocsGenerator.GeneratePage.CopyFolder;
using MkDocsGenerator.GeneratePage.CreateNav;
using MkDocsGenerator.GeneratePage.Directories;
using System.IO;

namespace MkDocsGenerator.InputOutputFolder
{
    class GenerateWebPage
    {
        public GenerateWebPage(string inputFolder, string outputFolder)
        {
            if (new CheckComplements().Check() == true)
            {
                Home.buildPage.listboxResultados.Items.Add("Los complementos están instalados correctamente");

                Home.buildPage.listboxResultados.Items.Add("Generando nueva barra de navegación...");
                string contentBar = new ReadStructure(inputFolder).getNavbar(inputFolder);
                Home.buildPage.listboxResultados.Items.Add("Creando archivo mkdocs.yml...");
                new WriteStructure(contentBar);

                Home.buildPage.listboxResultados.Items.Add(@"Eliminando archivos existentes de la carpeta \MkDocs\docs...");
                string DocsFolder = Directory.GetCurrentDirectory() + @"\MkDocs\docs";
                new RemoveDocs(DocsFolder);
                Home.buildPage.listboxResultados.Items.Add(@"Copiando nuevos archivos markdown al directorio \MkDocs\docs...");
                new DirectoryCopy().CopyAllDirectory(inputFolder, DocsFolder, true);

                Home.buildPage.listboxResultados.Items.Add("Eliminando archivos de la carpeta de salida...");
                new RemoveDocs(outputFolder);

                Home.buildPage.listboxResultados.Items.Add("Construyendo nueva página...");
                new Compile();

                Home.buildPage.listboxResultados.Items.Add("Copiando archivos de la nueva página a la carpeta seleccionado...");
                new MoveCompiled(Directory.GetCurrentDirectory() + @"\MkDocs\site", outputFolder);

                Home.buildPage.listboxResultados.Items.Add("El proceso se ha terminado exitosamente");
            }
            else
            {
                Home.buildPage.listboxResultados.Items.Add("No se ha podido instalar alguno de los complementos");
            }
        }
    }
}
