using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace InstallerV2
{
    internal class Extensions
    {
        public static ConfigManager package = new ConfigManager(Properties.Resources.package);

        public static string installation_path;

        public static int page_index = 0;

        public static List<Page> pages = new List<Page>(new Page[] { new eula(), new path(), new installation(), new finish() });

        static MainWindow mw;

        public static void LoadWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    mw = (window as MainWindow);
                }
            }
        }

        public static void Back()
        {
            LoadWindow();
            page_index -= 1;
            mw.frame1.NavigationService.Navigate(pages[page_index - 1]);
        }

        public static void Forward()
        {
            LoadWindow();
            mw.frame1.NavigationService.Navigate(pages[page_index]);
            page_index += 1;
        }

        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        public static string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {
            if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            if (value < 0) { return "-" + SizeSuffix(-value, decimalPlaces); }
            if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }

        public static void RegisterControlPanelProgram(string appName, string publisher, string installLocation, string displayicon, string uninstallString, string version)
        {
            string Install_Reg_Loc = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

            RegistryKey hKey = (Registry.LocalMachine).OpenSubKey(Install_Reg_Loc, true);

            RegistryKey appKey = hKey.CreateSubKey(appName);

            appKey.SetValue("DisplayName", (object)appName, RegistryValueKind.String);

            appKey.SetValue("Publisher", (object)publisher, RegistryValueKind.String);

            appKey.SetValue("InstallLocation",
                        (object)installLocation, RegistryValueKind.ExpandString);

            appKey.SetValue("DisplayIcon", (object)displayicon, RegistryValueKind.String);

            appKey.SetValue("UninstallString",
                    (object)uninstallString, RegistryValueKind.ExpandString);

            appKey.SetValue("DisplayVersion", (object)version, RegistryValueKind.String);
        }
    }
}
