using System;
using System.Diagnostics;
using System.Reflection;

namespace VSC.Utils
{
    internal static class WinServiceInstaller
    {
        private static string APP_EXECUTABLE_PATH = Assembly.GetExecutingAssembly().Location.Remove(Assembly.GetExecutingAssembly().Location.Length - 4) + ".exe";
        private const string ServiceControllerEXE = "sc.exe";

        public static void Uninstall(string serviceName)
        {
            Stop(serviceName); // stop service before uninstall

            Console.WriteLine("Uninstall Service");

            RunProcess("delete " + serviceName);
        }

        private static void Stop(string serviceName)
        {
            Console.WriteLine("Stopping Service");
            RunProcess("stop " + serviceName);            
        }

        public static void Install(string serviceName)
        {
            string processArguments = string.Format("create {0} displayname=\"{1}\" binpath=\"{2}\"", serviceName, serviceName, APP_EXECUTABLE_PATH);
            RunProcess(processArguments);
        }

        private static void RunProcess(string arguments)
        {
            var process = new Process();
            var processInfo = new ProcessStartInfo();
            processInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            processInfo.FileName = ServiceControllerEXE;
            processInfo.Arguments = arguments;
            process.StartInfo = processInfo;
            process.Start();
            process.WaitForExit();
        }
    }
}