﻿using System;
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
        public const string cadenaConexion = "Data Source=FRANCOPC\\SQLEXPRESS;Initial Catalog=Consultorio;Persist Security Info=True;User ID=sa;Password=TurnItUp_41134538";

        public static string Operacion;


        public static bool ValidarFiltro(string cadena)
        {
            string[] caracteres = new string[] {"\'","%","\""};
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

    }
}