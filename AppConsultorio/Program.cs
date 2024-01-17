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

            //POR DEFAULT ABRO EL FORM DE LOGIN Y SI EL LOGIN ES CORRECTO SE PROCEDE CON EL RESTO DEL PROCESO DE INICIO DE LA APLICACION
            frmLogin frmLogin = new frmLogin();
            frmTurnos prueba = new frmTurnos();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMenuPrincipal());
            }

        }
    }
}
