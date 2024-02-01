using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsCalendar;

namespace AppConsultorio
{
    public partial class frmTurnos : Form
    {
        List<CalendarItem> _items = new List<CalendarItem>();
        //CREO UNA FLAG PARA EVITAR CARGAR TURNOS EN EL LOAD Y QUE SOLAMENTE SE CARGUE UNA VEZ SELECCIONADA UNA FECHA
        bool flag = false;
        public frmTurnos()
        {
            InitializeComponent();
            calendarioMes.MonthTitleColor = calendarioMes.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            calendarioMes.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            calendarioMes.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            calendarioMes.DaySelectedTextColor = calendarioMes.ForeColor;
            
        }

        private void RecuperarTurnos(DateTime fechaDesde, DateTime fechaHasta)
        {
            calendarioGrande.Visible = true;
            //LIMPIO EL CALENDARIO Y VACIO LA LISTA DE ITEMS PARA NO GENERAR DUPLICADOS
            calendarioGrande.Items.Clear();
            _items.Clear();
            //RECUPERO TODOS LOS DATOS RELEVANTES DE LOS TURNOS
            DataTable tabla = new DataTable();
            if (Usuarios.AccesoLog == 20)
            {
                Turnos.RecuperarTurnosReservados(fechaDesde, fechaHasta, Usuarios.idUsuarioLog.ToString(), ref tabla) ;
            }
            else
            {
                Turnos.RecuperarTurnosReservados(fechaDesde, fechaHasta,Turnos.idMedicoSelec.ToString(), ref tabla); 
            }

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
                    //SI LOS TURNOS RECUPERADOS SON PASADOS Y REALIZADOS CAMBIO EL COLOR DEL ITEM PARA REFLEJARLO
                    if (item.Estado.Trim() == "Realizado")
                    {
                        item.ApplyColor(Color.Green);
                        calendarioGrande.Invalidate(item);
                    }
                }
            }
        }

        private void calendarioGrande_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {
            RecuperarTurnos(calendarioMes.SelectionStart, calendarioMes.SelectionEnd);
        }

        private void calendarioGrande_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            string fechaDesde;
            string fechaHasta;

            fechaDesde = e.Item.StartDate.ToShortDateString();
            fechaHasta = e.Item.EndDate.ToShortDateString();
            //VERIFICO QUE EL TURNO SEA UN DIA UNICO
            if (fechaDesde == fechaHasta)
            {
                //VERIFICO QUE EL DIA DEL TURNO NO SEA PASADO
                if (e.Item.StartDate >= DateTime.Today)
                {
                    //VERIFICO QUE EL HORARIO ESTE DISPONIBLE
                    DataTable tabla = new DataTable();
                    if (Usuarios.AccesoLog == 20)
                    {
                        Turnos.VerificarDisponibilidadTurno(e.Item.StartDate, e.Item.EndDate,Usuarios.idUsuarioLog.ToString(), ref tabla);
                    }
                    else
                    {
                        Turnos.VerificarDisponibilidadTurno(e.Item.StartDate, e.Item.EndDate,Turnos.idMedicoSelec.ToString(), ref tabla);
                    }                  
                    if (tabla.Rows.Count == 0)
                    {
                        //ABRO UN FORMULARIO CON TODOS LOS PACIENTES PARA QUE SEA SELECCIONADO Y ASIGNADO UN TURNO
                        Modulo.Operacion = "Asignar Turno";
                        frmPacientes frmPacientes = new frmPacientes();
                        frmPacientes.ShowDialog();

                        if (Usuarios.AccesoLog == 20)
                        {
                            Turnos.AgregarTurno(e.Item.Date, e.Item.EndDate, Pacientes.idPacienteSelec, Usuarios.idUsuarioLog);
                        }
                        else
                        {
                            Turnos.AgregarTurno(e.Item.Date, e.Item.EndDate, Pacientes.idPacienteSelec, Turnos.idMedicoSelec.ToString());
                        }

                    }
                    else
                    {
                        MessageBox.Show("Horario no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Fecha invalida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }               
            }
            else
            {
                MessageBox.Show("El turno no puede abarcar mas de un dia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                            
        }

        private void pruebaCalendario_Load(object sender, EventArgs e)
        {
            calendarioGrande.Visible = false;
            this.CenterToScreen();

            if (Usuarios.AccesoLog == 30)
            {
                this.panelCalendarioGrande.Location = new Point(250, 45);
                lblMedico.Visible = true;
                cbxProfesional.Visible = true;

                DataTable tabla = new DataTable();
                Grupos.RecuperarProfesionales(ref tabla);
                cbxProfesional.DataSource = tabla;
                cbxProfesional.DisplayMember = "Profesional";
                cbxProfesional.ValueMember = "idUsuario";
                cbxProfesional.DropDownStyle = ComboBoxStyle.DropDownList;
                cbxProfesional.SelectedIndex = 0;
            }
            else
            {
                this.panelCalendarioGrande.Location = new Point(250, 1);
                lblMedico.Visible = false;
                cbxProfesional.Visible = false;
            }
        }

        private void calendarioGrande_LoadItems_1(object sender, CalendarLoadEventArgs e)
        {
            CargarCalendario();
        }

        private void calendarioGrande_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            //AL HACER DOBLE CLICK EN UN ITEM DEL CALENDARIO ABRO UN FORMULARIO CON LA INFORMACION DE DICHO TURNO
            Turnos.idTurnoSelec = e.Item.IdTurno;
            Pacientes.idPacienteSelec = e.Item.IdPaciente;
            Turnos.fecha = e.Item.StartDate;
            frmInfoTurno frmInfoTurno = new frmInfoTurno(e.Item.Text, e.Item.Telefono, e.Item.ObraSocial, e.Item.IdTurno, e.Item.IdPaciente);
            frmInfoTurno.ShowDialog();
            calendarioGrande.Items.Clear();
            RecuperarTurnos(calendarioMes.SelectionStart, calendarioMes.SelectionEnd);
        }

        private void calendarioGrande_ItemDatesChanged(object sender, CalendarItemEventArgs e)
        {
            //VERIFICO PRIMERO QUE NO SE QUIERA HACER UN UPDATE DE UN TURNO YA REALIZADO
            if(e.Item.Estado.Trim() != "Realizado")
            {
                //AL MODIFICAR UN TURNO YA REGISTRADO EN LA BD SE REALIZA UN UPDATE A LA HORA EN BASE A LA SELECCION DEL USUARIO
                DialogResult dialogresult = MessageBox.Show("¿Desea modificar la fecha/hora del turno?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.Yes)
                {
                    string fechaDesde;
                    string fechaHasta;

                    fechaDesde = e.Item.StartDate.ToShortDateString();
                    fechaHasta = e.Item.EndDate.ToShortDateString();
                    //VERIFICO QUE EL TURNO ABARQUE UN UNICO DIA
                    if (fechaDesde == fechaHasta)
                    {
                        //VERIFICO QUE EL TURNO NO SEA ASIGNADO A UN DIA YA PASADO
                        if (e.Item.StartDate >= DateTime.Today)
                        {
                            //VERIFICO QUE NO HAYA OTRO TURNO ASIGNADO EN EL HORARIO SELECCIONADO
                            DataTable tabla = new DataTable();
                            if (Usuarios.AccesoLog == 20)
                            {
                                Turnos.VerificarTurnoUpdate(e.Item.IdTurno, e.Item.StartDate, e.Item.EndDate,Usuarios.idUsuarioLog.ToString(), ref tabla);
                            }
                            else
                            {
                                Turnos.VerificarTurnoUpdate(e.Item.IdTurno, e.Item.StartDate, e.Item.EndDate,Turnos.idMedicoSelec.ToString(), ref tabla);
                            }

                            if (tabla.Rows.Count == 0)
                            {

                                    Turnos.ActualizarFechaTurno(e.Item.IdTurno, e.Item.StartDate, e.Item.EndDate);
                                    RecuperarTurnos(calendarioMes.SelectionStart, calendarioMes.SelectionEnd);
                               
                            }
                            else
                            {
                                MessageBox.Show("Horario no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                RecuperarTurnos(calendarioMes.SelectionStart, calendarioMes.SelectionEnd);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fecha Invalida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            RecuperarTurnos(calendarioMes.SelectionStart, calendarioMes.SelectionEnd);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El turno no puede abarcar mas de un dia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecuperarTurnos(calendarioMes.SelectionStart, calendarioMes.SelectionEnd);
                        return;
                    }
                }
                else
                {
                    RecuperarTurnos(calendarioMes.SelectionStart, calendarioMes.SelectionEnd);
                }
            }
            else
            {
                MessageBox.Show("No puede modificar el horario de un turno ya realizado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RecuperarTurnos(calendarioMes.SelectionStart, calendarioMes.SelectionEnd);
                return;
            }
        }

        private void calendarioMes_SelectionChanged(object sender, EventArgs e)
        {
            //AL CAMBIAR LOS DIAS SELECCIONADOS DEL CALENDARIO MENSUAL RECUPERO LOS TURNOS ENTRE LAS DOS FECHAS
            calendarioGrande.SetViewRange(calendarioMes.SelectionStart, calendarioMes.SelectionEnd);
            flag = true;
            RecuperarTurnos(calendarioMes.SelectionStart, calendarioMes.SelectionEnd);            
        }

        private void calendarioGrande_DayHeaderClick(object sender, CalendarDayEventArgs e)
        {
            // CUANDO HAGO CLICK EN EL NOMBRE DEL DIA RECUPERO SOLAMENTE LOS TURNOS DEL DIA SELECCIONADO
            DateTime fechaDesde;
            DateTime fechaHasta;

            fechaDesde = DateTime.Parse(e.CalendarDay.Date.ToShortDateString());
            fechaHasta = DateTime.Parse(e.CalendarDay.Date.ToShortDateString()).AddHours(23).AddMinutes(59).AddSeconds(59);

            calendarioGrande.SetViewRange(e.CalendarDay.Date, e.CalendarDay.Date);

            RecuperarTurnos(fechaDesde,fechaHasta);
        }


        private void cbxProfesional_SelectedValueChanged(object sender, EventArgs e)
        {
            Turnos.idMedicoSelec = cbxProfesional.SelectedValue.ToString().Trim();
            if (flag == true)
            {
                RecuperarTurnos(calendarioMes.SelectionStart, calendarioMes.SelectionEnd);
            }          
        }
    }
}
