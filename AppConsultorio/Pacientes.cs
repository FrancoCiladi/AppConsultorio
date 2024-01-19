using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Configuration;

namespace AppConsultorio
{
    internal class Pacientes : Modulo
    {
        public static string idPacienteSelec;
        public static int opcionFiltrado;
        public static int seleccion_OS;
        public static string textoFiltrar;
        public static void RecuperarPacientes(int opcion_filtrado,int seleccion_OS,string texto, ref DataTable Tabla)
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
                Comando.CommandText = "RECUPERAR_PACIENTES";
                Comando.Parameters.Add("@opcion_filtrado", SqlDbType.Int).Value = opcion_filtrado;
                Comando.Parameters.Add("@seleccion_OS", SqlDbType.Int).Value = seleccion_OS;
                Comando.Parameters.Add("@texto", SqlDbType.VarChar,30).Value = texto;
                Tabla = new DataTable();
                Tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void RecuperarPacientesListado(int opcion_filtrado, int seleccion_OS, string texto, ref DataTable Tabla)
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
                Comando.CommandText = "RECUPERAR_PACIENTES_LISTADO";
                Comando.Parameters.Add("@opcion_filtrado", SqlDbType.Int).Value = opcion_filtrado;
                Comando.Parameters.Add("@seleccion_OS", SqlDbType.Int).Value = seleccion_OS;
                Comando.Parameters.Add("@texto", SqlDbType.VarChar, 30).Value = texto;
                Tabla = new DataTable();
                Tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void RecuperarPacienteUpdate(string idPacienteSelec, ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_PACIENTE_UPDATE";
                Comando.Parameters.Add("@idPacienteSelec", SqlDbType.Int).Value = idPacienteSelec;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }    

        public static void VerificarInsertPaciente(string nro_doc,ref DataTable tabla)
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
                Comando.CommandText = "VERIFICAR_INSERT_PACIENTE";
                Comando.Parameters.Add("@nro_doc", SqlDbType.NChar, 8).Value = nro_doc;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void VerificarUpdatePaciente(string nro_doc,string idPacienteSelec, ref DataTable tabla)
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
                Comando.CommandText = "VERIFICAR_UPDATE_PACIENTE";
                Comando.Parameters.Add("@nro_doc", SqlDbType.NChar, 8).Value = nro_doc;
                Comando.Parameters.Add("@idPacienteSelec", SqlDbType.Int).Value = idPacienteSelec;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void InsertarPaciente(string nro_doc,string apellido,string nombre,string telefono,string email,string estado,string idObraSocial)
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
                Comando.CommandText = "INSERTAR_PACIENTES";
                Comando.Parameters.Add("@nro_doc", SqlDbType.NChar, 8).Value = nro_doc;
                Comando.Parameters.Add("@apellido", SqlDbType.NChar, 40).Value = apellido;
                Comando.Parameters.Add("@nombre", SqlDbType.NChar, 40).Value = nombre;
                Comando.Parameters.Add("@telefono", SqlDbType.NChar, 20).Value = telefono;
                Comando.Parameters.Add("@email", SqlDbType.NChar, 40).Value = email;
                Comando.Parameters.Add("@estado", SqlDbType.NChar, 3).Value = estado;
                Comando.Parameters.Add("@idObrasocial", SqlDbType.Int).Value = idObraSocial;

                Comando.ExecuteNonQuery();

                MessageBox.Show("Carga realizada con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ActualizarPaciente(string idPacienteSelec,string nro_doc, string apellido, string nombre, string telefono, string email, string idObraSocial)
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
                Comando.CommandText = "ACTUALIZAR_PACIENTE";
                Comando.Parameters.Add("@idPacienteSelec", SqlDbType.NChar, 8).Value = idPacienteSelec;
                Comando.Parameters.Add("@nro_doc", SqlDbType.NChar, 8).Value = nro_doc;
                Comando.Parameters.Add("@apellido", SqlDbType.NChar, 40).Value = apellido;
                Comando.Parameters.Add("@nombre", SqlDbType.NChar, 40).Value = nombre;
                Comando.Parameters.Add("@telefono", SqlDbType.NChar, 20).Value = telefono;
                Comando.Parameters.Add("@email", SqlDbType.NChar, 40).Value = email;
                Comando.Parameters.Add("@idObrasocial", SqlDbType.Int).Value = idObraSocial;

                Comando.ExecuteNonQuery();

                MessageBox.Show("Modificacion realizada con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RecuperarTurnosPacienteRealizados(string idPacienteSelec, ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_TURNOS_PACIENTE_REALIZADOS";
                Comando.Parameters.Add("@idPacienteSelec", SqlDbType.Int).Value = idPacienteSelec;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void RecuperarTurnosPacienteReservados(string idPacienteSelec, ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_TURNOS_PACIENTE_RESERVADOS";
                Comando.Parameters.Add("@idPacienteSelec", SqlDbType.Int).Value = idPacienteSelec;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void EliminarPaciente(string idPacienteSelec)
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
                Comando.CommandText = "ELIMINAR_PACIENTE";
                Comando.Parameters.Add("@idPacienteSelec", SqlDbType.NChar, 8).Value = idPacienteSelec;
                Comando.ExecuteNonQuery();

                MessageBox.Show("El paciente fue eliminado.", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        public static void RecuperarTelefonoPaciente(string idPacienteSelec, ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_TELEFONO_PACIENTE";
                Comando.Parameters.Add("@idPacienteSelec", SqlDbType.Int).Value = idPacienteSelec;
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
