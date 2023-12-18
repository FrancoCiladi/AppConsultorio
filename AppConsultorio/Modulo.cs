using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppConsultorio
{
    internal class Modulo 
    {
        //STRING PARA PODER VERIFICAR QUE TIPO DE OPERACION REALIZAR SI UNA MODIFICACION O UN ALTA
        public static string Operacion;

        //FUNCION PARA PODER VALIDAR LOS FILTROS DE DIVERSOS FORMS
        public static bool ValidarFiltro(string cadena)
        {
            string[] caracteres = new string[] {"\'","%","\"","*"};
            bool ok = true;

            for (int i = 0;i < caracteres.Length -1;i++)
            {
                if (cadena.Contains(caracteres[i]))
                {
                    ok = false;
                }
            }
            return ok;
        }

        public static bool ValidarEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
