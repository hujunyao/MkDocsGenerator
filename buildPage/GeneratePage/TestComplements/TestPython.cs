using Microsoft.Win32;
using System;

namespace MkDocsGenerator.GeneratePage
{
    class TestPython
    {
        public Boolean testPython()
        {

            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        String tempname = "";
                        if (subkey.GetValue("DisplayName") != null)
                        {
                            tempname = subkey.GetValue("DisplayName").ToString();
                        }
                        if (tempname.ToLower().Contains("python"))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
