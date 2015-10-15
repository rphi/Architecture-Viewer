using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace Architecture_Viewer
{
    class ComputerEnvironment
    {
        public bool is64;
        public string os;
        public string osVerString;
        public string servicePack;
        public double ramTotal;
        public double ramFree;
        public double ramUsed;
        public DateTime timestamp;
        public string computerName;

        public ComputerEnvironment()
        {
            var cinfo = new ComputerInfo();

            is64 = Environment.Is64BitOperatingSystem;
            os = cinfo.OSFullName;
            osVerString = Environment.OSVersion.VersionString;
            if (Environment.OSVersion.ServicePack.Length != 0)
            {
                servicePack = Environment.OSVersion.ServicePack;
            }
            else
            {
                servicePack = "n/a";
            }

            ramTotal = Math.Ceiling(cinfo.TotalPhysicalMemory * 1e-6);
            ramFree = Math.Ceiling(cinfo.AvailablePhysicalMemory * 1e-6);
            ramUsed = (1 - (ramFree / ramTotal)) * 100;

            computerName = Environment.MachineName;

            timestamp = DateTime.Now;
        }
    }
}
