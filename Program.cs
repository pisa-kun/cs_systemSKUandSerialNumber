using System;
using System.Management;

namespace wmiSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var managementClass = new ManagementClass("Win32_ComputerSystem"))
            {
                managementClass.Get();
 
                // WMIのオブジェクトのコレクションを取得する
                using (var managementObjectCollection = managementClass.GetInstances())
                { 
                    // WMIのオブジェクトを列挙する
                    foreach (var managementObject in managementObjectCollection)
                    {
                        Console.WriteLine($"SystemSKUNumber: {managementObject["SystemSKUNumber"]}");
                        // WMIのオブジェクトのリソースを開放する
                        managementObject.Dispose();
                    }
                }
            }

            using (var managementClass = new ManagementClass("Win32_BIOS"))
            {
                managementClass.Get();
 
                // WMIのオブジェクトのコレクションを取得する
                using (var managementObjectCollection = managementClass.GetInstances())
                { 
                    // WMIのオブジェクトを列挙する
                    foreach (var managementObject in managementObjectCollection)
                    {
                        Console.WriteLine($"SerialNumber: {managementObject["SerialNumber"]}");
                        // WMIのオブジェクトのリソースを開放する
                        managementObject.Dispose();
                    }
                }
            }
        }
    }
}
