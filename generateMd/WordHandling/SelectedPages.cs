using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Windows.Forms;

namespace MkDocsGenerator.generateMd.WordHandling
{
    class SelectedPages
    {
        public SelectedPages(string inputFile, string outputTempFile, int start, int end, int total)
        {

            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            object oMissing = System.Reflection.Missing.Value;

            try
            {
                word.Visible = true;
                Object filename = inputFile;

                Microsoft.Office.Interop.Word.Document doc = word.Documents.Open(ref filename, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            word.Documents.Add();


            Range Selection = doc.Range();

            Selection.Start = Selection.GoTo(
                    What: WdGoToItem.wdGoToPage,
                    Which: WdGoToDirection.wdGoToFirst,
                    Count: start
                ).Start;


            if (end == total)
            {
                Selection.End = doc.Range().End;
            }
            else
            {
                Selection.End = Selection.GoTo(
                    What: WdGoToItem.wdGoToPage,
                    Which: WdGoToDirection.wdGoToAbsolute,
                    Count: end + 1
                ).Start - 1;
            }

            Selection.Copy();
            word.Selection.Paste();
            Clipboard.Clear();

            object outputFileName = outputTempFile;

            word.ActiveDocument.SaveAs(ref outputFileName,
                ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
            word.Documents.Close(ref saveChanges, ref oMissing, ref oMissing);
            doc = null;
            }
            catch
            {
                if (File.Exists(outputTempFile))
                {
                    File.Delete(outputTempFile);
                }
                throw new Exception("Ocurrió un error durante el proceso de selección de páginas");
            }
            finally
            {
                ((_Application)word).Quit();
                word = null;
            }
        }
    }
}
