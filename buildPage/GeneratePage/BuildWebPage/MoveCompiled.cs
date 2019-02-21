using MkDocsGenerator.GeneratePage.CopyFolder;


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
