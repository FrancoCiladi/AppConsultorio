using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace AppConsultorio
{
    internal class Turnos 
    {
        public static string idTurnoSelec;
        public static DateTime fecha;
        public static string idMedicoSelec;
        public static void RecuperarTurnosReservados(DateTime fechaDesde,DateTime fechaHasta,string idMedicoSelec,ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_TURNOS";
                Comando.Parameters.Add("@fechaDesde", SqlDbType.DateTime).Value = fechaDesde;
                Comando.Parameters.Add("@fechaHasta", SqlDbType.DateTime).Value = fechaHasta;
                Comando.Parameters.Add("@idMedico", SqlDbType.Int).Value = idMedicoSelec;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        
        public static void CancelarTurno(string idTurnoSelec)
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
                Comando.CommandText = "CANCELAR_TURNO";
                Comando.Parameters.Add("@idTurnoSelec", SqlDbType.Int).Value = idTurnoSelec;
                Comando.ExecuteNonQuery();

                MessageBox.Show("El turno fue cancelado.", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void EliminarTurno(string idTurnoSelec)
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
                Comando.CommandText = "ELIMINAR_TURNO";
                Comando.Parameters.Add("@idTurnoSelec", SqlDbType.Int).Value = idTurnoSelec;
                Comando.ExecuteNonQuery();

                MessageBox.Show("El turno fue eliminado.", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void VerificarDisponibilidadTurno(DateTime fechaDesde, DateTime fechaHasta,string idMedico, ref DataTable tabla)
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
                Comando.CommandText = "VERIFICAR_TURNO";
                Comando.Parameters.Add("@fechaDesde", SqlDbType.DateTime).Value = fechaDesde;
                Comando.Parameters.Add("@fechaHasta", SqlDbType.DateTime).Value = fechaHasta;
                Comando.Parameters.Add("@idMedico", SqlDbType.Int).Value = idMedico;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void VerificarTurnoUpdate(string idTurnoSelec,DateTime fechaDesde, DateTime fechaHasta,string idMedicoSelec, ref DataTable tabla)
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
                Comando.CommandText = "VERIFICAR_TURNO_UPDATE";
                Comando.Parameters.Add("@idTurnoSelec", SqlDbType.Int).Value = idTurnoSelec;
                Comando.Parameters.Add("@fechaDesde", SqlDbType.DateTime).Value = fechaDesde;
                Comando.Parameters.Add("@fechaHasta", SqlDbType.DateTime).Value = fechaHasta;
                Comando.Parameters.Add("@idMedico", SqlDbType.Int).Value = idMedicoSelec;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public static void VerificarTurnoPacienteUpdate(string idTurnoSelec,DateTime fecha, string idPacienteSelec, ref DataTable tabla)
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
                Comando.CommandText = "VERIFICAR_TURNO_DIA_PACIENTE_UPDATE";
                Comando.Parameters.Add("@idTurnoSelec", SqlDbType.Int).Value = idTurnoSelec;
                Comando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
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
        public static void AgregarTurno(DateTime fechaDesde, DateTime fechaHasta, string idPacienteSelec,string idMedico)
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
                Comando.CommandText = "AGREGAR_TURNO";
                Comando.Parameters.Add("fechaDesde", SqlDbType.DateTime).Value = fechaDesde;
                Comando.Parameters.Add("fechaHasta", SqlDbType.DateTime).Value = fechaHasta;
                Comando.Parameters.Add("@idPacienteSelec", SqlDbType.Int).Value = idPacienteSelec;
                Comando.Parameters.Add("@idMedico", SqlDbType.Int).Value = idMedico;
                Comando.ExecuteNonQuery();

                MessageBox.Show("Turno asignado!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void CambiarEstadoTurno()
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
                Comando.CommandText = "CAMBIAR_ESTADO_TURNO";
                Comando.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ActualizarFechaTurno(string idTurnoSelec,DateTime fechaDesde,DateTime fechaHasta)
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
                Comando.CommandText = "ACTUALIZAR_FECHA_TURNO";
                Comando.Parameters.Add("@idTurnoSelec", SqlDbType.Int).Value = idTurnoSelec;
                Comando.Parameters.Add("@fechaDesde", SqlDbType.DateTime).Value = fechaDesde;
                Comando.Parameters.Add("@fechaHasta", SqlDbType.DateTime).Value = fechaHasta;
                Comando.ExecuteNonQuery();

                MessageBox.Show("Turno Modificado!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void IngresarImporte(string importe, string idTurnoSelec)
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
                Comando.CommandText = "INGRESAR_IMPORTE";
                Comando.Parameters.Add("@idTurnoSelec", SqlDbType.Int).Value = idTurnoSelec;
                Comando.Parameters.Add("@importe", SqlDbType.Int).Value = importe;
                Comando.ExecuteNonQuery();

                MessageBox.Show("Importe Ingresado!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RecuperarImporte(string idTurnoSelec, ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_IMPORTE";
                Comando.Parameters.Add("@idTurnoSelec", SqlDbType.Int).Value = idTurnoSelec;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GuardarObservaciones(string observaciones, string idTurnoSelec)
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
                Comando.CommandText = "GUARDAR_OBSERVACIONES";
                Comando.Parameters.Add("@idTurnoSelec", SqlDbType.Int).Value = idTurnoSelec;
                Comando.Parameters.Add("@observaciones", SqlDbType.VarChar,1500).Value = observaciones;
                Comando.ExecuteNonQuery();

                MessageBox.Show("Observacion guardada.", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RecuperarObservacion(string idTurnoSelec, ref DataTable tabla)
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
                Comando.CommandText = "RECUPERAR_OBSERVACION";
                Comando.Parameters.Add("@idTurnoSelec", SqlDbType.Int).Value = idTurnoSelec;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
