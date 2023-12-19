//using AppConsultorio.ConsultorioDataSetTableAdapters;
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
    public partial class frmPacientes : Form 
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (Usuarios.AccesoLog > 20)
            {
                //DESHABILITO OPCIONES EN EL CASO DE NIVEL DE ACCESO >20 == SECRETARIA
                mnuPacientes.Items[3].Visible = false;
            }
            cbxObrasSociales.Visible = false;

            cbxFiltrado.Items.Add("Apellido");
            cbxFiltrado.Items.Add("Nombre");
            cbxFiltrado.Items.Add("Obra Social");
            cbxFiltrado.SelectedIndex = 0;
            cbxFiltrado.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable tabla = new DataTable();
            //CARGO EL COMBOBOX CON OBRAS SOCIALES
            ObrasSociales.RecuperarObrasSociales(ref tabla);           
            cbxObrasSociales.DataSource = tabla;
            cbxObrasSociales.DisplayMember = "descripcion";
            cbxObrasSociales.ValueMember = "idObraSocial";
            cbxObrasSociales.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxObrasSociales.SelectedIndex = 0;

        }

        private void editarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvPacientes.CurrentRow != null){
                //SELECCIONO PACIENTE EN GRIDVIEW Y GUARDO SU ID PARA CARGAR SUS DATOS EN EL FORM DE CARGA
                Modulo.Operacion = "MODIFICAR";
                Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
                frmAgregarPacientes frmCargaPacientes = new frmAgregarPacientes();
                frmCargaPacientes.ShowDialog();
            }     
        }

        private void cargarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulo.Operacion = "ALTA";
            frmAgregarPacientes frmCargaPacientes = new frmAgregarPacientes();
            frmCargaPacientes.ShowDialog();
        }

        private void verTurnosPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvPacientes.CurrentRow != null)
            {
                //VEO TURNOS DE PACIENTES SELECCIONADOS GUARDANDO SU ID
                Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
                frmTurnosPaciente frmTurnosPaciente = new frmTurnosPaciente();
                frmTurnosPaciente.ShowDialog();
            }
            
        }


        private void CargarGridView()
        {
            if (cbxFiltrado.SelectedIndex <= 1)
            {
                if (string.IsNullOrEmpty(txtFiltro.Text) == false && txtFiltro.Text.Trim().Length >= 3)
                {
                    //CARGO EL GRIDVIEW SOLO SI EL TEXTBOX DE APELLIDO TIENE 3 O MAS CARACTERES
                    DataTable Tabla = new DataTable();
                    DataGridViewLinkColumn col;
                    col = new DataGridViewLinkColumn();

                    Pacientes.RecuperarPacientes(cbxFiltrado.SelectedIndex,0,txtFiltro.Text, ref Tabla);
                    this.dgvPacientes.DataSource = Tabla;
                    this.dgvPacientes.Columns["idPaciente"].Visible = false;
                    this.dgvPacientes.Columns["fecha_registro"].Visible = false;
                    this.dgvPacientes.Columns["idObra_Social"].Visible = false;
                    this.dgvPacientes.Columns["Telefono"].Visible = false;

                    col.DataPropertyName = "Telefono";
                    col.Name = "Telefono";
                    col.DisplayIndex = 3;
                    this.dgvPacientes.Columns.Add(col);
                }
                else
                {
                    dgvPacientes.DataSource = null;
                }
            }
            else
            {
                
                DataTable Tabla = new DataTable();
                DataGridViewLinkColumn col;
                col = new DataGridViewLinkColumn();

                Pacientes.RecuperarPacientes(cbxFiltrado.SelectedIndex,int.Parse(cbxObrasSociales.SelectedValue.ToString()), txtFiltro.Text, ref Tabla);
                this.dgvPacientes.DataSource = Tabla;
                this.dgvPacientes.Columns["idPaciente"].Visible = false;
                this.dgvPacientes.Columns["estado"].Visible = false;
                this.dgvPacientes.Columns["fecha_registro"].Visible = false;
                this.dgvPacientes.Columns["idObra_Social"].Visible = false;
                this.dgvPacientes.Columns["Telefono"].Visible = false;

                col.DataPropertyName = "Telefono";
                col.Name = "Telefono";
                col.DisplayIndex = 3;
                this.dgvPacientes.Columns.Add(col);
                
                
            }
            

        }
        private void txtFiltroApellido_TextChanged(object sender, EventArgs e)
        {
           //VERIFICO QUE EL USUARIO NO INGRESE CARACTERES NO PERMITIDOS
            if (Modulo.ValidarFiltro(txtFiltro.Text.ToString()) == true)
            {
                CargarGridView();
            }
            else
            {
                MessageBox.Show("Ingreso caracter no permitido.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFiltro.Focus();
            }
            
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //AL HACER CLICK EN NUM DE TELEFONO DE PACIENTES SE ABRIRA WHATSAPP WEB Y UN CHAT AL NUMERO DEL PACIENTE
            if (this.dgvPacientes.Columns[this.dgvPacientes.CurrentCell.ColumnIndex].HeaderText == "Telefono")
            {
                Process.Start("https://wa.me/+54" + this.dgvPacientes.CurrentCell.EditedFormattedValue);
            }
        }


        private void eliminarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {

                Pacientes.idPacienteSelec = this.dgvPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();

                Pacientes.EliminarPaciente(Pacientes.idPacienteSelec);

                CargarGridView();
            }
        }

        private void cbxFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = null;

            if (cbxFiltrado.SelectedIndex == 2)
            {
                cbxObrasSociales.Visible = true;
                txtFiltro.Visible = false;
                txtFiltro.Text = null;
            }
            else
            {
                cbxObrasSociales.Visible = false;
                txtFiltro.Visible = true;
                txtFiltro.Text = null;
            }
        }

        private void cbxObrasSociales_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGridView();
        }

        private void frmPacientes_Activated(object sender, EventArgs e)
        {
            CargarGridView();
        }
    }
}
