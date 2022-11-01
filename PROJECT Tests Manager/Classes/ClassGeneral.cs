using HAKROS.Forms;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HAKROS.Classes
{
    static class ClassGeneral
    {

        static public bool ExitAuthorised = false;
        static public bool IsBusy = false;

        static readonly public string DirApp = Application.StartupPath + @"\";
        static readonly public string DirTests = DirApp + @"data\tests\";

        static public AutoScaleMode AutoScaleMode = AutoScaleMode.None;

        public static void CreateDirs()
        {
            Directory.CreateDirectory(DirTests);
        }

        static public string GetWindowTitle(string ModuleName = "")
        {
            var admin = (ClassSecurity.IsAdministrator()) ? " - (Administrator)" : "";
            if (ModuleName != "")
            {
                return GetAppName() + " " + GetVersion() + admin + " - " + ModuleName;
            }
            else
            {
                return GetAppName() + " " + GetVersion() + admin;
            }
        }

        static public string GetAppName()
        {
            return Application.ProductName;
        }

        static public string GetVersion()
        {
            var currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
            return currentVersion.Major + "." + currentVersion.Minor + "." + currentVersion.Build;
        }
        
        static public bool LineContainsLetter(string line)
        {
            try
            {
                if (!string.IsNullOrEmpty(line))
                {
                    var containsLetter = false;
                    foreach (var c in line.ToCharArray())
                    {
                        if (char.IsLetter(c))
                        {
                            containsLetter = true;
                            break;
                        }
                    }
                    return containsLetter;
                }
            }
            catch
            {
                //Error !!
            }
            return false;
        }

        static public bool StartWithLetter(string input)
        {
            try
            {
                if (!string.IsNullOrEmpty(input))
                {
                    return char.IsLetter(input[0]);
                }
            }
            catch
            {
                //Error !!
            }
            return false;
        }

    }
}
