using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextCompressionLzwFormApplication.View;

namespace TextCompressionLzwFormApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>+
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LzwMainWindow()); 

        }
    }
}
