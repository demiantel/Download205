using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Downloader205
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            string nombrePrograma = "";
            var arguments = Environment.GetCommandLineArgs();

            string argumentos = arguments[1];
            argumentos = "gimp-2/1&3&5";
            nombrePrograma = argumentos.Split('/')[0];

            string combos = argumentos.Split('/')[1];

            Application.Run(new frmPrincipal(nombrePrograma, combos));

        }


        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("JsonFx.Json.dll"))
            {
                byte[] assemblyData = new byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }
    }
}
