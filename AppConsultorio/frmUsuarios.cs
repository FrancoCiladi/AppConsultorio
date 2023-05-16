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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            CargarGridView();

        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActivos.Checked)
            {
                CargarGridView();
                rbActivos.Checked = true;
                rbInactivos.Checked = false;
            }
            else
            {
                rbActivos.Checked = false;
                rbInactivos.Checked = true;
            }
        }

        private void rbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInactivos.Checked)
            {
                CargarGridView();
                rbActivos.Checked = false;
                rbInactivos.Checked = true;
            }
            else
            {
                rbActivos.Checked = true;
                rbInactivos.Checked = false;
            }
        }
        private void CargarGridView()
        {
            DataTable tabla = new DataTable();
            if (rbActivos.Checked == true)
            {
                Usuarios.RecuperarUsuariosActivos(ref tabla);
            }
            else
            {
                Usuarios.RecuperarUsuariosInactivos(ref tabla);
            }
            dgvUsuarios.DataSource = tabla;
            dgvUsuarios.Columns["idUsuario"].Visible = false;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
        }
        private void frmUsuarios_Activated(object sender, EventArgs e)
        {
            CargarGridView();
        }
        private void deshabilitarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Usuarios.DeshabilitarUsuario(Usuarios.idUsuarioSelec);
            }
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Usuarios.EliminarUsuario(Usuarios.idUsuarioSelec);
            }
        }

        private void resetearIntentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Usuarios.ResetearIntentosLogin(Usuarios.idUsuarioSelec);
            }
        }

        private void habilitarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Usuarios.HabilitarUsuario(Usuarios.idUsuarioSelec);
            }
        }

        private void frmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
