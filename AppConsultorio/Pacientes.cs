using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppConsultorio
{
    internal class Pacientes : Modulo
    {
        public static string idPacienteSelec;
        public static void RecuperarPacientes(string apellido, ref DataTable Tabla)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = cadenaConexion;
            Conexion.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "RECUPERAR_PACIENTES";
            Comando.Parameters.Add("@apellido", SqlDbType.NChar, 40).Value = apellido;
            Tabla = new DataTable();
            Tabla.Load(Comando.ExecuteReader());

            Conexion.Close();
        }
        public static void RecuperarPacienteUpdate(string idPacienteSelec, ref DataTable tabla)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = cadenaConexion;
            Conexion.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "RECUPERAR_PACIENTE_UPDATE";
            Comando.Parameters.Add("@idPacienteSelec", SqlDbType.Int).Value = idPacienteSelec;
            tabla = new DataTable();
            tabla.Load(Comando.ExecuteReader());

            Conexion.Close();
        }
        public static void RecuperarObrasSociales(ref DataTable tabla)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = cadenaConexion;
            Conexion.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "RECUPERAR_OBRAS_SOCIALES";
            tabla = new DataTable();
            tabla.Load(Comando.ExecuteReader());

            Conexion.Close();
        }
    }
}
