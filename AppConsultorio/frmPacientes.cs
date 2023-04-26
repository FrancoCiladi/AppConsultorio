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
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

        }

        private void editarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaPacientes frmCargaPacientes= new frmCargaPacientes();
            frmCargaPacientes.ShowDialog();
        }

        private void cargarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaPacientes frmCargaPacientes = new frmCargaPacientes();
            frmCargaPacientes.ShowDialog();
        }

        private void verTurnosPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTurnosPaciente frmTurnosPaciente = new frmTurnosPaciente();
            frmTurnosPaciente.ShowDialog();
        }

        private void txtFiltroApellido_TextChanged(object sender, EventArgs e)
        {
            //ir cargando el gv a medida que escribe el apellido de los pacientes, minimo 3 caracteres, verificar caracteres al principio antes de cargar
        }
    }
}
