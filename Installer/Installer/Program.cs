using System;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Security.Principal;

namespace Installer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool IsRunningAsAdministrator() { WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent(); WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity); return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator); }

            if (!IsRunningAsAdministrator())
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase);
                processStartInfo.UseShellExecute = true;
                processStartInfo.Verb = "runas";
                Process.Start(processStartInfo);
                Application.Exit();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.Run(new Form1());
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs e)
        {
            if (e.Name.Contains("XanderUI"))
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Installer.Resources.XanderUI.dll"))
            {
                byte[] assemblyData = new byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
            else
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Installer.Resources.ConfigParser.dll"))
            {
                byte[] assemblyData = new byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }
    }
}
