using System;
using System.Windows;
using System.Reflection;
using System.Security.Principal;
using System.Diagnostics;

namespace InstallerV2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : Application
    {
        public App()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            bool IsRunningAsAdministrator() { WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator); }

            if (!IsRunningAsAdministrator())
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase);
                processStartInfo.UseShellExecute = true;
                processStartInfo.Verb = "runas";
                Process.Start(processStartInfo);
                Current.Shutdown();
            }
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs e)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("InstallerV2.Resources.ConfigParser.dll"))
            {
                byte[] assemblyData = new byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }
    }

}
