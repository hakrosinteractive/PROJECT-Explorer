using HAKROS.Forms;
using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace HAKROS.Classes
{
    static class ClassBackup
    {

        static public string GetWindowTitle(string ModuleName = "")
        {
            if (ModuleName != "")
            {
                return GetAppName() + " " + GetVersion() + " - " + ModuleName;
            }
            else
            {
                return GetAppName() + " " + GetVersion();
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

        static public Icon GetIcon()
        {
            var aux = new FrmAux();
            return aux.GetIcon();
        }

        static public string GetDateForLog()
        {
            var dateForLog = "[" + DateTime.Now.ToLongTimeString().Replace(" ", "] [") + "] - ";
            Thread.Sleep(100);
            return dateForLog;
        }

        static public DialogResult MsgBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(text, caption, buttons, icon);
        }

        static public string GetDateStamp(DateTime date)
        {
            return date.ToString("yyyyMMdd");
        }

        static public string GetTimeStamp(DateTime date)
        {
            return date.ToString("HHmmss");
        }

        static public bool StartWithNumber(string input)
        {
            try
            {
                if (!string.IsNullOrEmpty(input))
                {
                    return char.IsNumber(input[0]);
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

        static public string RemoveSymbols(string input)
        {
            var output = input;
            try
            {
                if (!string.IsNullOrEmpty(input))
                {
                    output = "";
                    foreach (var c in input.ToCharArray())
                    {
                        if (char.IsLetter(c) || char.IsNumber(c))
                        {
                            output += c;
                        }
                        else
                        {
                            output += " ";
                        }
                    }
                }
            }
            catch
            {
                //Error !!
            }
            return output;
        }

    }
}
