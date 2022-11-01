using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HAKROS.Classes
{
    static class ClassMemory
    {

        [DllImport("KERNEL32.DLL", EntryPoint = "SetProcessWorkingSetSize", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetProcessWorkingSetSize32Bit (IntPtr pProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

        [DllImport("KERNEL32.DLL", EntryPoint = "SetProcessWorkingSetSize", SetLastError = true,  CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetProcessWorkingSetSize64Bit (IntPtr pProcess, long dwMinimumWorkingSetSize, long dwMaximumWorkingSetSize);

        public static Exception FlushProcess(Process pr)
        {
            try
            {
                if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                {
                    SetProcessWorkingSetSize32Bit(pr.Handle, -1, -1);
                }
                else
                {
                    SetProcessWorkingSetSize64Bit(pr.Handle, -1, -1);
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

    }
}
