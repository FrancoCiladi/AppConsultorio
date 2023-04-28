using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsultorio
{
    public partial class frmCargaPacientes : Form
    {
        public frmCargaPacientes()
        {
            InitializeComponent();
        }

        private void frmCargaPacientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            DataTable tabla = new DataTable();
            Pacientes.RecuperarObrasSociales(ref tabla);
            cbxObrasSociales.DataSource = tabla;
            cbxObrasSociales.DisplayMember = "descripcion";
            cbxObrasSociales.ValueMember = "idObraSocial";
            cbxObrasSociales.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxObrasSociales.SelectedIndex = 0;

            if (Pacientes.Operacion == "MODIFICAR")
            {
                Pacientes.RecuperarPacienteUpdate(Pacientes.idPacienteSelec.ToString(), ref tabla);

                txtApellido.Text = tabla.Rows[0]["apellido"].ToString();
                txtNombre.Text = tabla.Rows[0]["nombre"].ToString();
                txtNroDoc.Text = tabla.Rows[0]["nro_doc"].ToString();
                txtTelefono.Text = tabla.Rows[0]["telefono"].ToString();
                txtCorreo.Text = tabla.Rows[0]["email"].ToString();
                cbxObrasSociales.SelectedValue = tabla.Rows[0]["idObra_Social"].ToString();

            }
            else
            {
                Pacientes.Operacion = "ALTA";

                txtApellido.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtNroDoc.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtCorreo.Text = string.Empty;
                cbxObrasSociales.SelectedIndex = 0;
            }

            //CAMBIAR CUANDO SE EDITA Y CUANDO SE CARGA EL  TITULO DEL FORM Y EL NOMBRE DEL BUTTON usando operacion

        }
    }
}
