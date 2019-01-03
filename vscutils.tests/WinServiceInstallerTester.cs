using System;
using VSC.Utils;
using Xunit;

namespace VSC.Utils.Tests
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
            WinServiceInstaller.Install("Sampele Test Service");
        }

        private void PrintServiceStatus(string status)
        {
            Console.WriteLine(status);
        }
    }
}