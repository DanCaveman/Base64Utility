using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;

namespace Base64Utility
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var iocContainer = ConfigureIoC();
            Application.Run(new Form1());
        }

        private static IContainer ConfigureIoC()
        {
            var builder = new ContainerBuilder();

            // Register individual components
            var assemblys = new Assembly[]
            {
                Assembly.GetExecutingAssembly()
            };

            builder.RegisterAssemblyModules(assemblys);
            

            var container = builder.Build();

            return container;
        }
    }
}
