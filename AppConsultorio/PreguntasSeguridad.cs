using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsultorio
{
    internal class PreguntasSeguridad
    {
        public static void RecuperarPreguntasSeguridad(ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_PREGUNTAS_SEGURIDAD";
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void VerificarPreguntaSeguridad(string idUsuario, ref DataTable tabla)
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
                Comando.CommandText = "VERIFICAR_PREGUNTA_SEGURIDAD";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void RegistrarPreguntaSeguridad(string idUsuario, string idPregunta, string respuesta, string salt)
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
                Comando.CommandText = "REGISTRAR_PREGUNTA_SEGURIDAD";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                Comando.Parameters.Add("@idPregunta", SqlDbType.Int).Value = idPregunta;
                Comando.Parameters.Add("@respuesta", SqlDbType.NVarChar, 128).Value = respuesta;
                Comando.Parameters.Add("@salt", SqlDbType.NVarChar, 128).Value = salt;
                Comando.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
