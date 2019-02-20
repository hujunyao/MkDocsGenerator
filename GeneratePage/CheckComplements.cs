using MkDocsGenerator.GeneratePage.InstallComplements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MkDocsGenerator.GeneratePage
{
    class CheckComplements
    {
        public bool Check()
        {
            Program.f1.listboxResultados.Items.Add("Vereficando Python...");
            if (Python())
            {
                Program.f1.listboxResultados.Items.Add("Vereficando MkDocs...");
                if (MkDocs())
                {
                    return true;
                }
                else
                {
                    Program.f1.listboxResultados.Items.Add("Instalando MkDocs...");
                    new InstallMkDocs();
                    if (!MkDocs())
                    {
                        return false;
                    }
                    else
                    {
                        Check();
                    }
                }
            }
            else
            {
                Program.f1.listboxResultados.Items.Add("Instalando Python...");
                new InstallPython();
                Console.WriteLine("Finish");
                if (!Python())
                {
                    return false;
                }
                else
                {
                    Check();
                }
            }
            return false;
        }

        public bool Python()
        {
            if (new TestPython().testPython() == true)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public bool MkDocs()
        {
            if (new TestMkDocs().testMkDocs() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
