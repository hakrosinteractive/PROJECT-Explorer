using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace HAKROS.Classes
{
    static class ClassSecurity
    {

        static public bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        static public bool ExecuteAsAdmin()
        {
            try
            {
                var proc = new Process();
                proc.StartInfo.FileName = Application.ExecutablePath;
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.Verb = "runas";
                proc.Start();

                return true;

            }
            catch
            {
                //Error
            }

            return false;

        }

        static public bool InExecution()
        {
            var k = 0;
            try
            {
                var currentname = Assembly.GetExecutingAssembly().GetName().Name.ToLowerInvariant();
                var ps = Process.GetProcesses();
                foreach (var p in ps)
                {
                    var pname = p.ProcessName.ToLowerInvariant();
                    if (pname == currentname)
                    {
                        k += 1;
                    }
                }
            }
            catch
            {
                //Error!!
            }
            return (k >= 2);
        }

    }

}
