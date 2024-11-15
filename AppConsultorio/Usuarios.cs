﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;

namespace AppConsultorio
{
    internal class Usuarios 
    {
        public static string idUsuarioSelec;
        public static string idUsuarioLog;
        public static int AccesoLog;
        public static void RegistrarUsuario(string usuario,string pass,string apellido, string nombre,string salt,string correo)
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
                Comando.CommandText = "REGISTRAR_USUARIO";
                Comando.Parameters.Add("@usuario", SqlDbType.NVarChar, 30).Value = usuario;
                Comando.Parameters.Add("@pass", SqlDbType.Char, 64).Value = pass;
                Comando.Parameters.Add("@apellido", SqlDbType.NChar, 30).Value = apellido;
                Comando.Parameters.Add("@nombre", SqlDbType.NChar, 30).Value = nombre;
                Comando.Parameters.Add("@salt", SqlDbType.NVarChar,128).Value = salt;
                Comando.Parameters.Add("@correo", SqlDbType.NChar, 50).Value = correo;

                Comando.ExecuteNonQuery();

                MessageBox.Show("Registro exitoso. Se le enviara un correo electronico con un codigo de verificacion. Aguarde mientras se genera.", "Usuario Registrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void EliminarUsuario(string idUsuarioSelec, string idGrupo)
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
                Comando.CommandText = "ELIMINAR_USUARIO";
                Comando.Parameters.Add("@idUsuarioSelec", SqlDbType.Int).Value = idUsuarioSelec;
                Comando.Parameters.Add("@idGrupo", SqlDbType.Int).Value = idGrupo;
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
                string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
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
        public static void HabilitarUsuario(string idUsuarioSelec)
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
                Comando.CommandText = "HABILITAR_USUARIO";
                Comando.Parameters.Add("@idUsuarioSelec", SqlDbType.Int).Value = idUsuarioSelec;

                Comando.ExecuteNonQuery();

                MessageBox.Show("Usuario habilitado.", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public static void RecuperarUsuarioLogin(string usuario, ref DataTable Tabla)
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
        public static void RecuperarUsuarioLogeado(string idUsuarioLog, ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_USUARIO_LOGEADO";
                Comando.Parameters.Add("@idUsuarioLog", SqlDbType.Int).Value = idUsuarioLog;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void RecuperarUsuarioEditar(string idUsuarioLog, ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_USUARIO_EDITAR";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuarioLog;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void UpdateUsuario(string idUsuario, string apellido, string nombre, string usuario)
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
                Comando.CommandText = "UPDATE_USUARIO";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                Comando.Parameters.Add("@apellido", SqlDbType.NChar,30).Value = apellido;
                Comando.Parameters.Add("@nombre", SqlDbType.NChar,30).Value = nombre;
                Comando.Parameters.Add("@usuario", SqlDbType.NVarChar,30).Value = usuario;
                Comando.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public static void VerificarUpdateUsuario(string idUsuario, string usuario, ref DataTable tabla)
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
                Comando.CommandText = "VERIFICAR_UPDATE_USUARIO";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                Comando.Parameters.Add("@usuario", SqlDbType.NVarChar,30).Value = usuario;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void RecuperarUsuariosListado(int estado,int opcion_filtrado,string texto,ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_USUARIOS_LISTADO";
                Comando.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                Comando.Parameters.Add("@opcion_filtrado", SqlDbType.Int).Value = opcion_filtrado;
                Comando.Parameters.Add("@texto", SqlDbType.NVarChar,30).Value = texto;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public class SecurityHelper
        {
            public static string GenerateSalt(int nSalt)
            {
                var saltBytes = new byte[nSalt];

                using (var provider = new RNGCryptoServiceProvider())
                {
                    provider.GetNonZeroBytes(saltBytes);
                }

                return Convert.ToBase64String(saltBytes);
            }

            public static string HashPassword(string password, string salt, int nIterations, int nHash)
            {
                var saltBytes = Convert.FromBase64String(salt);

                using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, nIterations))
                {
                    return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(nHash));
                }
            }
        }



        public static void VerificarUsuarioNuevo(string usuario, ref DataTable Tabla)
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
        public static void ResetearIntentosLogin(string idUsuario) 
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
                Comando.CommandText = "UPDATE_RESET_INTENTOS_LOGIN";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;

                Comando.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ResetearIntentosResetearClave(string idUsuario)
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
                Comando.CommandText = "UPDATE_RESET_INTENTOS_RESETEAR_CLAVE";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;

                Comando.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AumentarIntentosLogin(string idUsuario)
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
                Comando.CommandText = "UPDATE_AUMENTAR_INTENTOS_LOGIN";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;

                Comando.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AumentarIntentosResetearClave(string idUsuario)
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
                Comando.CommandText = "UPDATE_AUMENTAR_INTENTOS_RESETEAR_CLAVE";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;

                Comando.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void CambiarContraseña(string idUsuario, string contraseña,string salt)
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
                Comando.CommandText = "CAMBIAR_CLAVE";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                Comando.Parameters.Add("@pass", SqlDbType.NVarChar,128).Value = contraseña;
                Comando.Parameters.Add("@salt", SqlDbType.NVarChar, 128).Value = salt;
                Comando.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ResetearContraseña(string idUsuario, string contraseña, string salt)
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
                Comando.CommandText = "RESETEAR_CLAVE";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                Comando.Parameters.Add("@pass", SqlDbType.NVarChar, 128).Value = contraseña;
                Comando.Parameters.Add("@salt", SqlDbType.NVarChar, 128).Value = salt;
                Comando.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public static void RecuperarUsuarioSeguridad(string idUsuario, ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_USUARIO_SEGURIDAD";
                Comando.Parameters.Add("idUsuario", SqlDbType.Int).Value = idUsuario;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static string GenerarCodigoVerificacion()
        {
            Random ran = new Random();

            String cadena = "abcdefghijklmnopqrstuvwxyz0123456789";

            int length = 6;

            String random = "";

            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(cadena.Length);
                random = random + cadena.ElementAt(a);
            }

            return (random.ToUpper());

        }

        public static void GenerarNuevoCodigoVerificacion(string idUsuario, string codigo)
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
                Comando.CommandText = "GENERAR_NUEVO_CODIGO_VERIFICACION";
                Comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                Comando.Parameters.Add("@codigo", SqlDbType.NVarChar, 6).Value = codigo;
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
