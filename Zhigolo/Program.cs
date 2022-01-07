using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zhigolo.Properties;

namespace Zhigolo
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += AppDomain_AssemblyResolve;
            Assembly AppDomain_AssemblyResolve(object sender, ResolveEventArgs args)
            {
                if (args.Name.Contains("TLSharp.Core"))
                    return Assembly.Load(Resources.TLSharp_Core);
                if (args.Name.Contains("TeleSharp.TL"))
                    return Assembly.Load(Resources.TeleSharp_TL);
                return null;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
