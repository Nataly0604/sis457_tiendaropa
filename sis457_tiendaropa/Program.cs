using CadTiendaropa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClnTiendaropa;
using System.Data.SqlClient;
using CadTiendaropa;

using System.Data.Entity;

namespace sis457_tiendaropa
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autentication());
        }
    }
}
