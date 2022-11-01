using System;
using System.Diagnostics;

namespace HAKROS.Classes
{
    static class ClassPriorizer
    {

        static public bool IsEnabled = false;


        public static void SetNewPriority(Process pr, ProcessPriorityClass priorityClass, bool flushMemory)
        {
            if (pr.PriorityClass != priorityClass)
            {
                pr.PriorityClass = priorityClass;

            }

            if (flushMemory)
            {
                ClassMemory.FlushProcess(pr);
            }

            bool changeAffinity = false;

            if (changeAffinity)
            {
                SetNewAffinity(pr);
            }

        }

        private static void SetNewAffinity(Process pr)
        {
            try
            {
                long maskvalue = GetMaskValue(pr);

                var curval = pr.ProcessorAffinity.ToString();
                var newval = ((IntPtr)maskvalue).ToString();

                if (curval != newval)
                {
                    pr.ProcessorAffinity = (IntPtr)maskvalue;
                }
            }
            catch
            {
                //Error !!
            }
        }

        private static long GetMaskValue(Process pr)
        {
            long maskvalue = 0;
            if (pr.PriorityClass == ProcessPriorityClass.BelowNormal)
            {
                maskvalue = 0x00000001;
            }
            else if (pr.PriorityClass == ProcessPriorityClass.High)
            {
                maskvalue = 255;
            }
            else
            {
                maskvalue = 255;
            }
            return maskvalue;
        }

    }
}
