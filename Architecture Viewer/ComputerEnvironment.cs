using System;
using System.IO;
using System.Text;
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
        public string installedSoftware;
        public int installedSoftwareCount;
        public string diskInfo;

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

            installedSoftware = GetInstalledSoftware();

            diskInfo = GetDiskInfo();
        }

        private string GetInstalledSoftware()
        {
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            var programs = new StringBuilder();
            using (Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (Microsoft.Win32.RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        string displayName = (string) subkey.GetValue("DisplayName", null);
                        if (displayName != null)
                        {
                            programs.AppendLine(subkey.GetValue("DisplayName") + ";");
                            installedSoftwareCount++;
                        }
                    }
                }
            }
            return "Total programs installed: " + installedSoftwareCount + "\r\n-----------------------\r\n" + programs.ToString();
        }

        private string GetDiskInfo()
        {
            var d = new StringBuilder();
            DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    d.AppendLine("Name: " + drive.Name + " \"" + drive.VolumeLabel + "\"");
                    d.AppendLine("Free space: " + Math.Round(drive.TotalFreeSpace * 1e-6) + "/" + Math.Round(drive.TotalSize * 1e-6));
                    d.AppendLine("Type: " + drive.DriveType + "/" + drive.DriveFormat);
                    d.AppendLine("Status: " + CheckDiskStatus(drive));
                    d.AppendLine("--------------------------");
                }
            }
            return d.ToString();
        }

        private string CheckDiskStatus(DriveInfo drive)
        {
            double spaceUsed = drive.TotalFreeSpace / drive.TotalSize;
            if (spaceUsed < 0.6) { return "OK"; }
            else if (spaceUsed < 0.8) { return "Warning"; }
            else { return "Error"; }
        }
    }
}
