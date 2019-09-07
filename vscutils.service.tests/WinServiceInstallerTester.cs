using System;
using VSC.Utils;
using Xunit;

namespace VSC.Tests.Utils.Service
{
    public class WinServiceInstallerTester
    {
        public WinServiceInstallerTester()
        {
            WinServiceInstaller.WinServiceStatus += new WinServiceInstaller.WinServiceStatusHandler(PrintServiceStatus);
        }

        [Fact]
        public void TestInstall()
        {
            WinServiceInstaller.Install("Sample Test Service");
        }

        private void PrintServiceStatus(string status)
        {
            Console.WriteLine(status);
        }
    }
}