using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
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

        static public string GetMD5FromFile(string filepath)
        {
            if (File.Exists(filepath))
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filepath))
                    {
                        var hash = md5.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
            return "";
        }

        static public string GetHashNameForString(string input, int maxlon = 20)
        {
            var res = GetSHA256FromString(input);
            if (res != "" && res.Length > maxlon)
            {
                res = res.Substring(0, maxlon);
            }
            return res;
        }

        static private string GetSHA256FromString(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }

}
