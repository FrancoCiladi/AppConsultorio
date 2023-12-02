using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppConsultorio
{
    public partial class frmTurnos : Form
    {
        public frmTurnos()
        {
            InitializeComponent();
        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            
            //AL CARGAR EL FORMS DE TURNOS SE HACE UN UPDATE DE TODOS AQUELLOS TURNOS CUYA FECHA ES ANTERIOR AL DIA ACTUAL
            Turnos.CambiarEstadoTurno();

            cbxTurnosCategorias.Items.Add("Dia");
            cbxTurnosCategorias.Items.Add("Semana");
            cbxTurnosCategorias.Items.Add("Mes");
            cbxTurnosCategorias.SelectedIndex = 0;

            cbxMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            
            CargarGridViewTurnos();
            CargarGridViewPacientes();
            CargarComboBoxMeses();

            cbxMeses.SelectedIndex = 0;

            //NO PERMITO LA SELECCION DE DIAS ANTERIORES AL ACTUAL PARA ASIGNACION DE TURNOS
            this.dtpFecha.MinDate = DateTime.Today;

            if (Usuarios.AccesoLog > 20)
            {
                //OCULTO CONTROL EN CASO DE SECRETARIA
                mnuTurnos.Items[2].Visible = false;
            }
        }

        private void CargarGridViewTurnos()
        {
            DataTable tabla = new DataTable();
            //EN BASE AL COMBOBOX DE CATEGORIA DE TURNOS SE CARGARAN LOS CORRESPONDIENTES AL DIA,SEMANA O MES           
            switch (cbxTurnosCategorias.SelectedIndex)
            {
                case 0:
                    Turnos.RecuperarTurnosReservadosDia(ref tabla);
                    break;
                case 1:
                    Turnos.RecuperarTurnosReservadosSemana(ref tabla);
                    break;
                case 2:
                    Turnos.RecuperarTurnosReservadosMes(DateTime.Now.Month, ref tabla);
                    if (cbxMeses.SelectedIndex > 0)
                    {
                        Turnos.RecuperarTurnosReservadosMes(Turnos.mes, ref tabla);
                    }
                    break;
            }
        
            this.dgvTurnos.DataSource = tabla;

            this.dgvTurnos.AllowUserToAddRows = false;
            this.dgvTurnos.AllowUserToDeleteRows = false;

            this.dgvTurnos.Columns["idTurno"].Visible = false;
            this.dgvTurnos.Columns["importe"].Visible = false;
            this.dgvTurnos.Columns["Estado"].Visible = false;
            this.dgvTurnos.Columns["fecha_creacion"].Visible = false;
            this.dgvTurnos.Columns["observaciones"].Visible = false;
            this.dgvTurnos.Columns["idPaciente"].Visible = false;
            this.dgvTurnos.Columns["fecha_cancelacion"].Visible = false;
            this.dgvTurnos.Columns["Descripcion"].HeaderText = "Obra Social";

        }


        private void frmTurnos_Activated(object sender, EventArgs e)
        {
            CargarGridViewTurnos();
        }

        private void cancelarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvTurnos.CurrentRow != null)
            {
                Turnos.idTurnoSelec = this.dgvTurnos.CurrentRow.Cells["idTurno"].Value.ToString();
                Pacientes.idPacienteSelec = this.dgvTurnos.CurrentRow.Cells["idPaciente"].Value.ToString();
                DialogResult dialogresult = MessageBox.Show("¿Desea cancelar el turno?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //PREGUNTO SI REALMENTE DESEA CANCELAR EL TURNO
                if (dialogresult == DialogResult.Yes)
                {
                    dialogresult = MessageBox.Show("¿Desea notificar al paciente?","",MessageBoxButtons.YesNo);
                    //PREGUNTO SI DESEA NOTIFICAR AL PACIENTE DE LA CANCELACION
                    if (dialogresult == DialogResult.Yes)
                    {
                        //EN CASO AFIRMATIVO LA CANCELACION PROVIENE DEL MEDICO/A Y SE RECUPERARA EL NUMERO DEL PACIENTE Y ABRIRA UNA INSTANCIA DE WHATSAPP WEB
                        DataTable tabla = new DataTable();
                        Pacientes.RecuperarTelefonoPaciente(Pacientes.idPacienteSelec, ref tabla);
                        Process.Start("https://wa.me/+54" + tabla.Rows[0]["telefono"].ToString().Trim());
                        //AL HABERLO CANCELADO EL MEDICO AL TURNO ES IRRELEVANTE LA INFORMACION DEL TURNO POR LO TANTO SE PROCEDE A ELIMINARLO DE LA BD
                        Turnos.EliminarTurno(Turnos.idTurnoSelec);
                    }
                    else
                    {
                        //EN CASO DE NO HABER NOTIFICADO AL PACIENTE SIGNIFICA QUE ESTE LO CANCELO Y SE CAMBIA UNICAMENTE EL ESTADO DEL TURNO A CANCELADO
                        //SIRVE PARA LA INFO DE CANCELACIONES POR PACIENTE
                        Turnos.CancelarTurno(Turnos.idTurnoSelec);
                    }   
                }       
            }
        }

        private void CargarGridViewPacientes()
        {
            if (string.IsNullOrEmpty(txtFiltrar.Text) == false && txtFiltrar.Text.Trim().Length >= 3)
            {
                //CARGO GRIDVIEW UNICAMENTE CUANDO HAY 3 O MAS CARACTERES EN EL TEXTBOX DE FILTRO POR APELLIDO 
                DataTable Tabla = new DataTable();
                DataGridViewLinkColumn col;
                col = new DataGridViewLinkColumn();

                Pacientes.RecuperarPacientesActivos(txtFiltrar.Text, ref Tabla);
                this.dgvPacientes.DataSource = Tabla;
                this.dgvPacientes.Columns["idPaciente"].Visible = false;
                this.dgvPacientes.Columns["estado"].Visible = false;
                this.dgvPacientes.Columns["fecha_registro"].Visible = false;
                this.dgvPacientes.Columns["idObra_Social"].Visible = false;
                this.dgvPacientes.Columns["Telefono"].Visible = false;
                this.dgvPacientes.AllowUserToAddRows = false;
                this.dgvPacientes.AllowUserToDeleteRows = false;

                //AGREGO COLUMNA ESPECIAL CON EL NUMERO DE TELEFONO DEL PACIENTE
                col.DataPropertyName = "Telefono";
                col.Name = "Telefono";
                col.DisplayIndex = 3;
                this.dgvPacientes.Columns.Add(col);
            }
            else
            {
                //VACIO EL GRIDVIEW SIEMPRE QUE NO HAYA 3 O MAS CARACTERES EN EL TEXTBOX DE FILTRO
                dgvPacientes.DataSource = null;
            }
        }

        private void txtFiltrar_TextChanged_1(object sender, EventArgs e)
        {
            //VERIFICO EL TEXTBOX DE FILTRADO DE PACIENTES POR APELLIDO
            if (Modulo.ValidarFiltro(txtFiltrar.Text.ToString()) == true)
            {
                CargarGridViewPacientes();
            }
            else
            {
                MessageBox.Show("Ingreso caracter no permitido.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFiltrar.Focus();
            }
        }



        private void btnAsignarTurno_Click_1(object sender, EventArgs e)
        {
            //VERIFICO QUE SE HAYA SELECCIONADO UN PACIENTE PARA ASIGNAR TURNO
            if (this.dgvPacientes.SelectedRows.Count != 0)
            {
                //VERIFICO LA DISPONIBILIDAD DEL TURNO
                if (VerificarTurno())
                {
                    //AGREGO EL TURNO A LA BD
                    string fecha = dtpFecha.Value.ToShortDateString();
                    string hora = dtpHora.Value.ToShortTimeString();
                    Turnos.AgregarTurno(fecha, hora, Pacientes.idPacienteSelec);

                }
            }
            else
            {
                MessageBox.Show("Debe asignar el turno a un paciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool VerificarTurno()
        {
            //VERIFICACION DE DISPONIBILIDAD DE TURNO 
            bool ok;
            ok = false;

            DataTable tabla = new DataTable();
            string fecha = dtpFecha.Value.ToShortDateString();
            string hora = dtpHora.Value.ToShortTimeString();
            //VERIFICO PRIMERO SI EL PACIENTE TIENE TURNOS ASIGNADOS EN EL DIA SELECCIONADO
            Turnos.VerificarTurnoPaciente(fecha, Pacientes.idPacienteSelec, ref tabla);
            if (tabla.Rows.Count == 0)
            {
                //VERIFICO QUE EL TURNO ESTE DISPONIBLE
                Turnos.VerificarDisponibilidadTurno(fecha, hora, ref tabla);
                if (tabla.Rows.Count == 0)
                {
                    ok = true;
                }
                else
                {
                    MessageBox.Show("Turno no disponible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se puede asignar mas de un turno por dia al paciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ok;
        }



        private void ingresarImporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvTurnos.CurrentRow != null)
            {
                //CAMBIO EL IMPORTE DEL TURNO SELECCIONADO
                Turnos.idTurnoSelec = this.dgvTurnos.CurrentRow.Cells["idTurno"].Value.ToString();
                frmImporte frmImporte = new frmImporte();
                frmImporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void observacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTurnos.CurrentRow != null)
            {
                //ACCEDO A LAS OBSERVACIONES DEL TURNO SELECCIONADO
                Turnos.idTurnoSelec = this.dgvTurnos.CurrentRow.Cells["idTurno"].Value.ToString();
                frmObservaciones frmObservaciones = new frmObservaciones();
                frmObservaciones.ShowDialog();
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EXPORTE LOS TURNOS DEL GRIDVIEW PARA HACER UN REPORTE
            if (dgvTurnos.Rows.Count  > 0)
            {
                DataTable tabla = new DataTable();
                switch (cbxTurnosCategorias.SelectedIndex)
                {
                    case 0:
                        Turnos.Seleccion = 0;
                        break;
                    case 1:
                        Turnos.Seleccion = 1;
                        break;
                    case 2:
                        Turnos.Seleccion = 2;
                        break;
                }
                frmReporteTurnos frmReporteTurnos = new frmReporteTurnos();
                frmReporteTurnos.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay nada para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            //ABRO FORMS PARA CARGAR NUEVO PACIENTE
            frmAgregarPacientes frmAgregarPacientes = new frmAgregarPacientes();
            frmAgregarPacientes.ShowDialog();
        }

        private void cbxTurnosCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CargarGridViewTurnos();
            if (cbxTurnosCategorias.SelectedIndex == 2)
            {
                cbxMeses.Enabled = true;
                cbxMeses.SelectedIndex = 1;
            }
            else
            {
                cbxMeses.Enabled = false;
            }
        }
        private void CargarComboBoxMeses()
        {
            //CREO UN ARRAY CON TODOS LOS MESES
            string[] meses = new string[13];

            meses[0] = "Seleccione...";
            meses[1] = "Enero";
            meses[2] = "Febrero";
            meses[3] = "Marzo";
            meses[4] = "Abril";
            meses[5] = "Mayo";
            meses[6] = "Junio";
            meses[7] = "Julio";
            meses[8] = "Agosto";
            meses[9] = "Septiembre";
            meses[10] = "Octubre";
            meses[11] = "Noviembre";
            meses[12] = "Diciembre";

            cbxMeses.Items.Add(meses[0]);

            //DEPENDIENDO DEL MES, CARGO UNICAMENTE EL ACTUAL Y LOS FUTUROS
            for (int i = 1; i < 13; i++)
            {
                if (i >= DateTime.Now.Month)
                {
                    cbxMeses.Items.Add(meses[i]);
                }
            }
        }
        private void dgvPacientes_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ASIGNO EL ID DE PACIENTE A UNA VARIABLE GLOBAL PARA LUEGO SER USADA DURANTE LA ASIGNACION DE TURNOS
            Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
        }

        private void cbxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMeses.SelectedIndex > 0)
            {
                switch (cbxMeses.Text)
                {
                    case "Enero":
                        Turnos.mes = 1;
                        break;
                    case "Febrero":
                        Turnos.mes = 2;
                        break;
                    case "Marzo":
                        Turnos.mes = 3;
                        break;
                    case "Abril":
                        Turnos.mes = 4;
                        break;
                    case "Mayo":
                        Turnos.mes = 5;
                        break;
                    case "Junio":
                        Turnos.mes = 6;
                        break;
                    case "Julio":
                        Turnos.mes = 7;
                        break;
                    case "Agosto":
                        Turnos.mes = 8;
                        break;
                    case "Septiembre":
                        Turnos.mes = 9;
                        break;
                    case "Octubre":
                        Turnos.mes = 10;
                        break;
                    case "Noviembre":
                        Turnos.mes = 11;
                        break;
                    case "Diciembre":
                        Turnos.mes = 12;
                        break;
                }
            }
            else
            {
                Turnos.mes = 0;
            }

            if (cbxMeses.SelectedIndex > 0)
            {
                CargarGridViewTurnos();
            }
        }

        private void modificarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvPacientes.CurrentRow != null)
            {
                //SELECCIONO PACIENTE EN GRIDVIEW Y GUARDO SU ID PARA CARGAR SUS DATOS EN EL FORM DE CARGA
                Modulo.Operacion = "MODIFICAR";
                Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
                frmAgregarPacientes frmCargaPacientes = new frmAgregarPacientes();
                frmCargaPacientes.ShowDialog();
            }
            CargarGridViewPacientes();
        }

        private void eliminarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                //VERIFICO QUE EL PACIENTE A ELIMINAR NO TENGA TURNOS ASIGNADOS, EN CASO DE QUE SI SE IMPOSIBILITA LA ELIMINACION, CASO CONTRARIO SE PROCEDE A ELIMINARLO DE LA BD
                DataTable tabla = new DataTable();
                Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
                Pacientes.RecuperarTurnosPaciente(Pacientes.idPacienteSelec, ref tabla);
                if (tabla.Rows.Count == 0)
                {
                    Pacientes.EliminarPaciente(Pacientes.idPacienteSelec);
                }
                else
                {
                    MessageBox.Show("No se pueden eliminar pacientes con turnos asignados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargarGridViewPacientes();
            }
        }
    }
    
}
