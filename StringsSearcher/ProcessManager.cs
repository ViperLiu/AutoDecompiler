using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace MASToolBox
{
    class ProcessManager
    {
        public static List<Process> ProcessList = new List<Process>();
        
        public static void TerminateAllProcess()
        {
            foreach(var p in ProcessList)
            {
                if (p == null)
                    continue;
                KillProcess(p.Id);
            }
        }

        public static void KillProcess(int pid)
        {
            // Cannot close 'system idle process'.
            if (pid == 0)
            {
                return;
            }
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
              ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                KillProcess(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch
            {
                // Process already exited.
                //MessageBox.Show(e.Message);
            }
        }
    }
}
