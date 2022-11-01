using System;
using System.Diagnostics;
using System.IO;

namespace HAKROS.Classes
{
    static class ClassExecute
    {

        public static Exception ExecuteProcess(string pth, string arguments, bool runas)
        {
            try
            {

                Exception ex = null;

                if (File.Exists(pth) || Directory.Exists(pth))
                {
                    ex = ExecutePath(pth, arguments, runas);
                }
                else
                {
                    var pathSystem32 = @"C:\Windows\System32\" + pth + ".exe";
                    var pathSystem64 = @"C:\Windows\Sysnative\" + pth + ".exe";

                    if (File.Exists(pathSystem32))
                    {
                        ex = ExecutePath(pathSystem32, arguments, runas);
                    }
                    else if (File.Exists(pathSystem64))
                    {
                        ex = ExecutePath(pathSystem64, arguments, runas);
                    }
                    else
                    {
                        ex = ExecutePath(pth, arguments, runas);
                    }

                }
                return ex;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public static Exception ExecutePath(string pth, string arguments, bool runas)
        {
            try
            {
                Process pr = new Process();
                pr.EnableRaisingEvents = true;
                pr.StartInfo.FileName = pth;
                if (runas)
                {
                    pr.StartInfo.Verb = "runas";
                }
                if (arguments != "")
                {
                    pr.StartInfo.Arguments = arguments;
                }
                pr.Start();
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public static Exception LoadPath(string pth)
        {
            try
            {
                Process.Start(pth);
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public static Exception LoadFolderAndSelectFile(string folder, string filepath)
        {
            try
            {
                var argument = "/select, \"" + filepath + "\"";
                Process.Start("explorer.exe", argument);
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

    }
}
