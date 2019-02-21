using Microsoft.Office.Interop.Word;
using System;

using word = Microsoft.Office.Interop.Word;

namespace MkDocsGenerator.generateMd.WordHandling
{
    class PagesCount
    {
        public int GetPagesCount(string doc)
        {
            Microsoft.Office.Interop.Word.Application wordApplication = new Microsoft.Office.Interop.Word.Application();
            try
            {
                Microsoft.Office.Interop.Word.Document myDoc = wordApplication.Documents.Open(doc);
                wordApplication.Visible = false;
                object What = Microsoft.Office.Interop.Word.WdGoToItem.wdGoToPage;
                object Which = Microsoft.Office.Interop.Word.WdGoToDirection.wdGoToAbsolute;
                object Miss = System.Reflection.Missing.Value;
                word.Pages pages = wordApplication.ActiveWindow.ActivePane.Pages;
                return pages.Count;
            }
            catch
            {
                throw new Exception("Ocurrió un error al leer el número de páginas");
            }
            finally
            {
                ((_Application)wordApplication).Quit();
                wordApplication = null;
            }
        }
    }
}
