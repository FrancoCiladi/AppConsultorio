using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppConsultorio
{
    internal class Turnos : Modulo
    {
        public static string idTurnoSelec;
        public static string Observacion;

        public static void RecuperarTurnosReservadosDia(ref DataTable tabla)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "RECUPERAR_TURNOS_DIA_RESERVADOS";
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RecuperarTurnosReservadosSemana(ref DataTable tabla)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "RECUPERAR_TURNOS_SEMANA_RESERVADOS";
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RecuperarTurnosReservadosMes(ref DataTable tabla)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "RECUPERAR_TURNOS_MES_RESERVADOS";
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RecuperarTurnosRealizadosAño(ref DataTable tabla)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "RECUPERAR_TURNOS_AÑO_REALIZADOS";
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RecuperarTurnosCanceladosAño(ref DataTable tabla)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "RECUPERAR_TURNOS_AÑO_CANCELADOS";
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
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "ELIMINAR_TURNO";
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
        public static void VerificarDisponibilidadTurno(string fecha, string hora, ref DataTable tabla)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "VERIFICAR_TURNO";
                Comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                Comando.Parameters.Add("@hora", SqlDbType.Time).Value = hora;
                tabla = new DataTable();
                tabla.Load(Comando.ExecuteReader());

                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AgregarTurno(string fecha, string hora, string idPacienteSelec)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                Conexion.ConnectionString = cadenaConexion;
                Conexion.Open();

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "AGREGAR_TURNO";
                Comando.Parameters.Add("@idPacienteSelec", SqlDbType.Int).Value = idPacienteSelec;
                Comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                Comando.Parameters.Add("@hora", SqlDbType.Time).Value = hora;
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
        public static void IngresarImporte(string importe, string idTurnoSelec)
        {
            try
            {
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
        public static void GuardarObservaciones(string observaciones, string idTurnoSelec)
        {
            try
            {
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
