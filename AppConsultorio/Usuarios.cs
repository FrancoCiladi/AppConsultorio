using System;
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
    internal class Usuarios : Modulo
    {
        public static string idUsuarioSelec;

        public static void RegistrarUsuario(string usuario,string pass,string apellido, string nombre, string idGrupo)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "REGISTRAR_USUARIO";
                Comando.Parameters.Add("@usuario", SqlDbType.NVarChar, 30).Value = usuario;
                Comando.Parameters.Add("@pass", SqlDbType.NVarChar, 30).Value = pass;
                Comando.Parameters.Add("@apellido", SqlDbType.NChar, 30).Value = apellido;
                Comando.Parameters.Add("@nombre", SqlDbType.NChar, 30).Value = nombre;
                Comando.Parameters.Add("@idGrupo", SqlDbType.Int).Value = idGrupo;

                Comando.ExecuteNonQuery();

                MessageBox.Show("Usuario Registrado!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void EliminarUsuario(string idUsuarioSelec)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "ELIMINAR_USUARIO";
                Comando.Parameters.Add("@idUsuarioSelec", SqlDbType.Int).Value = idUsuarioSelec;

                Comando.ExecuteNonQuery();

                MessageBox.Show("Usuario eliminado.", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeshabilitarUsuario(string idUsuarioSelec)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "DESHABILITAR_USUARIO";
                Comando.Parameters.Add("@idUsuarioSelec", SqlDbType.Int).Value = idUsuarioSelec;

                Comando.ExecuteNonQuery();

                MessageBox.Show("Usuario deshabilitado.", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RecuperarGrupos(ref DataTable Tabla)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "RECUPERAR_GRUPOS";
                Tabla = new DataTable();
                Tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void RecuperarUsuarioLogin(string usuario, ref DataTable Tabla)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "RECUPERAR_USUARIO_LOGIN";
                Comando.Parameters.Add("@usuario", SqlDbType.NVarChar, 30).Value = usuario;
                Tabla = new DataTable();
                Tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void RecuperarUsuariosActivos(ref DataTable tabla)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "RECUPERAR_USUARIOS_ACTIVOS";
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void RecuperarUsuariosInactivos(ref DataTable tabla)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "RECUPERAR_USUARIOS_INACTIVOS";
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static string GenerarHash256(string cadena)
        {
           System.Security.Cryptography.SHA256CryptoServiceProvider AlgoritmoHash = new System.Security.Cryptography.SHA256CryptoServiceProvider();
            byte[] inputBytes;
            byte[] hashBytes;
            string Salida;

            inputBytes = System.Text.Encoding.UTF8.GetBytes(cadena);
            hashBytes = AlgoritmoHash.ComputeHash(inputBytes);

            Salida = "";
            foreach (byte b in hashBytes)
            {
                Salida = Salida + b.ToString("x2");
            }

            return Salida;
        }
        public static void VerificarUsuarioNuevo(string usuario, ref DataTable Tabla)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "VERIFICAR_USUARIO_NUEVO";
                Comando.Parameters.Add("@usuario", SqlDbType.NVarChar, 30).Value = usuario;
                Tabla = new DataTable();
                Tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
