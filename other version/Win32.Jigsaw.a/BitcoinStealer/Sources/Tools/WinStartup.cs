using System;
using System.IO;
using Microsoft.Win32;

namespace Main.Tools
{
    internal static class WinStartup
    {
        internal static void Set(StartupMethodType startupMethod)
        {
            switch (startupMethod)
            {
                case StartupMethodType.Registry:
                    try
                    {
                        SetStartupRegistry(Config.FinalExePath);
                    }
                    catch
                    {
                        SetStartupFolder();
                    }
                    break;
                case StartupMethodType.StartupFolder:
                    SetStartupFolder();
                    break;
            }
        }

        private static void SetStartupFolder()
        {
            if (Config.FinalExeRelativePath == null) return;
            var startupExePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup),
                Path.GetFileName(Config.FinalExeRelativePath));
            Config.FinalExePath = startupExePath;
        }

        internal enum StartupMethodType
        {
            StartupFolder,
            Registry
        }

        private static void SetStartupRegistry(string exePath)
        {
            var rk = Registry.CurrentUser.OpenSubKey
                (@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (rk == null) return;

            rk.SetValue(Path.GetFileName(exePath), exePath);
        }

        
    }
}
