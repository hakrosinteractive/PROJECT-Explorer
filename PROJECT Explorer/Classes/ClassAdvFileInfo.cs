using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.IO;

/*
Add following NuGet packages to project:
Microsoft.WindowsAPICodePack-Shell by Microsoft
Microsoft.WindowsAPICodePack-Core by Microsoft (optional)
*/

namespace HAKROS.Classes
{
    class ClassAdvFileInfo
    {

        public static string GetTitle(string pth)
        {
            try
            {
                if (File.Exists(pth))
                {
                    return ShellFile.FromFilePath(pth).Properties.System.Title.Value;
                }
            }
            catch (Exception)
            {
                //Error !!
            }
            return "";
        }

        public static string GetDescription(string pth)
        {
            try
            {
                if (File.Exists(pth))
                {
                    return ShellFile.FromFilePath(pth).Properties.System.FileDescription.Value;
                }
            }
            catch (Exception)
            {
                //Error !!
            }
            return "";
        }

        public static string[] GetAuthor(string pth)
        {
            try
            {
                if (File.Exists(pth))
                {
                    return ShellFile.FromFilePath(pth).Properties.System.Author.Value;
                }
            }
            catch (Exception)
            {
                //Error !!
            }
            return null;
        }



    }
}
