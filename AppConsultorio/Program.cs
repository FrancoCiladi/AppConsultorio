using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsultorio
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
            //Application.Run(new frmLogin());

            frmLogin frmLogin = new frmLogin();
            if(frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMenuPrincipal());
            }
        }
    }
}
