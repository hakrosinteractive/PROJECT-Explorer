using System.Windows.Forms;

namespace HAKROS.Classes
{
    class ClassKeyControl : Form
    {

        public static bool CheckCtrlKey()
        {
            return (ModifierKeys & Keys.Control) == Keys.Control;
        }

        public static bool CheckShiftKey()
        {
            return (ModifierKeys & Keys.Shift) == Keys.Shift;
        }

        public static bool CheckAltKey()
        {
            return (ModifierKeys & Keys.Alt) == Keys.Alt;
        }

        public static bool CheckScrollKey()
        {
            return IsKeyLocked(Keys.Scroll);
        }

        public static bool CheckNumLockKey()
        {
            return IsKeyLocked(Keys.NumLock);
        }

        public static bool CheckCapsLockKey()
        {
            return IsKeyLocked(Keys.CapsLock);
        }

    }
}
