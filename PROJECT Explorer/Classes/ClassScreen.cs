
using System.Windows.Forms;

namespace HAKROS.Classes
{
    public static class ClassScreen
    {

        public static Screen GetPrimaryScreen()
        {
            var screens = Screen.AllScreens;
            foreach (var scr in screens)
            {
                if (scr.Primary == true)
                {
                    return scr;
                }
            }
            return null;
        }

        public static Screen GetSecondaryScreen()
        {
            var screens = Screen.AllScreens;
            foreach (var scr in screens)
            {
                if (scr.Primary == false)
                {
                    return scr;
                }
            }
            return null;
        }

    }
}
