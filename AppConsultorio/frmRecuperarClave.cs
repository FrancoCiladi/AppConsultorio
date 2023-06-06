using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppConsultorio
{
    public partial class frmRecuperarClave : Form
    {
        public frmRecuperarClave()
        {
            InitializeComponent();
        }



        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            pnlSecundario.Visible = true;
        }

        private void frmRecuperarClave_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            DataTable tabla = new DataTable();
            Usuarios.RecuperarPreguntasSeguridad(ref tabla);
            cbxPreguntasSeguridad.DataSource = tabla;
            cbxPreguntasSeguridad.DisplayMember = "Descripcion";
            cbxPreguntasSeguridad.ValueMember = "idPregunta";
            cbxPreguntasSeguridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPreguntasSeguridad.SelectedIndex = 0;
        }
    }
}
