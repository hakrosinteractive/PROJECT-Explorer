using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HAKROS.Classes
{
    static class ClassActiveProcess
    {

        [DllImport("USER32.DLL")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("USER32.DLL")]
        private static extern IntPtr GetForegroundWindow();

        public static Process GetActiveProcess()
        {
            try
            {
                IntPtr hWnd = GetForegroundWindow();
                uint pid;
                GetWindowThreadProcessId(hWnd, out pid);
                var pr = Process.GetProcessById((int)pid);
                return pr;
            }
            catch
            {
                return null;
            }
        }


    }
}
