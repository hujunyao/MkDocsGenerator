using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MkDocsGenerator.generateMd.WordHandling
{
    class SelectedPages
    {
        public SelectedPages(string inputFile, string outputFolder)
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            object oMissing = System.Reflection.Missing.Value;
            try
            {
                // Create a new Microsoft Word application object
                
                word.Visible = true;

                //word.Visible = false;
                //word.ScreenUpdating = false;

                // Cast as Object for word Open method
                Object filename = inputFile;

                // Use the dummy value as a placeholder for optional arguments
                Microsoft.Office.Interop.Word.Document doc = word.Documents.Open(ref filename, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                //doc.Activate();
                object what = WdGoToItem.wdGoToPage;
                object which = WdGoToDirection.wdGoToFirst;

                object count = 1;
                Range startRange = word.Selection.GoTo(ref what, ref which, ref count, ref oMissing);
                object count2 = (int)count + 1;
                Range endRange = word.Selection.GoTo(ref what, ref which, ref count2, ref oMissing);
                endRange.SetRange(startRange.Start, endRange.End - 1);
                endRange.Select();
                word.Selection.Copy();
                //word.Documents.Close();
                //word.Quit();

                word.Documents.Add();
                word.Selection.Paste();

                //Microsoft.Office.Interop.Word.Application word1 = new Microsoft.Office.Interop.Word.Application();
                object outputFileName = outputFolder + @"\doc.docx";
                object fileFormat = WdSaveFormat.wdFormatPDF;

                word.ActiveDocument.SaveAs(ref outputFileName,
                    ref fileFormat, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                word.Documents.Close(ref saveChanges, ref oMissing, ref oMissing);
                doc = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                ((_Application)word).Quit(ref oMissing, ref oMissing, ref oMissing);
                word = null;
            }
        }
    }
}
