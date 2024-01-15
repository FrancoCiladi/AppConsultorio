using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsCalendar;

namespace AppConsultorio
{
    public partial class pruebaCalendario : Form
    {
        List<CalendarItem> _items = new List<CalendarItem>();
        CalendarItem contextItem = null;
        public pruebaCalendario()
        {
            InitializeComponent();
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;
        }

        private void RecuperarTurnos()
        {
            //LIMPIO EL CALENDARIO Y VACIO LA LISTA DE ITEMS PARA NO GENERAR DUPLICADOS
            calendarioGrande.Items.Clear();
            _items.Clear();
            //RECUPERO TODOS LOS DATOS RELEVANTES DE LOS TURNOS
            DataTable tabla = new DataTable();
            Turnos.RecuperarTurnosReservadosSemana(ref tabla);
            //PROPIEDADES DE LOS TURNOS
            DateTime desde;
            DateTime hasta;
            string paciente;
            string idTurno;
            string idPaciente;
            string telefono;
            string estado;
            string importe;
            string obraSocial;
            DateTime fechaCreacion;
            DateTime fechaCancelacion;
            string observaciones;


            for (int i = 0; i < tabla.Rows.Count; i++)
            {                   
                //ASIGNO A LAS PROPIEDADES LOS VALORES DEVUELTOS POR CADA ROW RECUPERADA DE LA BD
                desde = DateTime.Parse(tabla.Rows[i]["fechaDesde"].ToString());
                hasta = DateTime.Parse(tabla.Rows[i]["fechaHasta"].ToString());
                paciente = tabla.Rows[i]["Paciente"].ToString();
                idTurno = tabla.Rows[i]["idTurno"].ToString();
                idPaciente = tabla.Rows[i]["idPaciente"].ToString();
                telefono = tabla.Rows[i]["Telefono"].ToString();
                estado = tabla.Rows[i]["Estado"].ToString();
                obraSocial = tabla.Rows[i]["Descripcion"].ToString();
                fechaCreacion = DateTime.Parse(tabla.Rows[i]["fecha_creacion"].ToString());
                DateTime.TryParse(tabla.Rows[i]["fecha_cancelacion"].ToString(), out fechaCancelacion);
                observaciones = tabla.Rows[i]["observaciones"].ToString();
                importe = tabla.Rows[i]["importe"].ToString();

                //CREO UN OBJ CALENDARITEM Y LO AGREGO AL LISTADO DE ITEMS PARA LUEGO LLAMAR AL PROCEDIMIENTO QUE LOS CARGA EN LA VISTA DEL CALENDARIO
                CalendarItem cal = new CalendarItem(calendarioGrande, desde, hasta, paciente, idTurno, idPaciente, telefono, obraSocial, importe, estado, fechaCreacion, fechaCancelacion);

                _items.Add(cal);
            }
            CargarCalendario();
        }

        private void CargarCalendario()
        {
            
            foreach (CalendarItem item in _items)
            {
                if (calendarioGrande.ViewIntersects(item))
                {
                    calendarioGrande.Items.Add(item);
                }
            }
        }

        private void calendarioGrande_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {
            RecuperarTurnos();
        }

        private void calendarioGrande_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            DataTable tabla = new DataTable();
            Turnos.VerificarDisponibilidadTurno(e.Item.StartDate, e.Item.EndDate, ref tabla);
            if (tabla.Rows.Count > 0)
            {
                MessageBox.Show("Horario no disponible.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                Modulo.Operacion = "Asignar Turno";
                frmPacientes frmPacientes = new frmPacientes();
                frmPacientes.ShowDialog();

                Turnos.VerificarTurnoPaciente(e.Item.Date, Pacientes.idPacienteSelec, ref tabla);
                if (tabla.Rows.Count == 0)
                {
                    Turnos.AgregarTurno(e.Item.Date, e.Item.EndDate, Pacientes.idPacienteSelec);
                    RecuperarTurnos();
                }
                else
                {
                    MessageBox.Show("El paciente ya tiene un turno asignado en el dia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }                     
        }

        private void pruebaCalendario_Load(object sender, EventArgs e)
        {
            RecuperarTurnos();
            this.CenterToScreen();
        }

        private void calendarioGrande_LoadItems_1(object sender, CalendarLoadEventArgs e)
        {
            CargarCalendario();
        }

        private void calendarioGrande_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            Turnos.idTurnoSelec = e.Item.IdTurno;
            Pacientes.idPacienteSelec = e.Item.IdPaciente;
            Turnos.fecha = e.Item.StartDate;
            frmInfoTurno frmInfoTurno = new frmInfoTurno(e.Item.Text, e.Item.Telefono, e.Item.ObraSocial, e.Item.IdTurno, e.Item.IdPaciente);
            frmInfoTurno.ShowDialog();
            calendarioGrande.Items.Clear();
            RecuperarTurnos();
        }
    }
}
