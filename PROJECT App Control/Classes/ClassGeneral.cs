using System.Reflection;
using System.Windows.Forms;

namespace HAKROS.Classes
{
    static class ClassGeneral
    {

        static public string GetWindowTitle()
        {
            return GetAppName() + " " + GetVersion();
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

    }

}
