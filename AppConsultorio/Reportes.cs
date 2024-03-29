﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace AppConsultorio
{
    internal class Reportes 
    {
        public static void RecuperarInfoReportesMensual(int mes,int año,string idMedico ,ref DataTable tabla)
        {
            try
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "RECUPERAR_INFO_REPORTES_MENSUAL";
                Comando.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
                Comando.Parameters.Add("@año", SqlDbType.Int).Value = año;
                Comando.Parameters.Add("@idMedico", SqlDbType.Int).Value = idMedico;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       
    }
        
    
}
