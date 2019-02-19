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
            if (new TestPython().testPython() == true)
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
            else
            {
                return false;
            }
        }
    }
}
