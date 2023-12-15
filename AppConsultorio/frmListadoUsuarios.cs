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
    public partial class frmListadoUsuarios : Form
    {
        public frmListadoUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            rbActivos.Checked = true;
            cbxFiltrado.Items.Add("Apellido");
            cbxFiltrado.Items.Add("Nombre");
            cbxFiltrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFiltrado.SelectedIndex = 0;
        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (txtFiltrado.Text.Length >= 3)
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
            //CAMBIO DE PACIENTES AL CHECKEAR RADIOBUTTON           
        }

        private void rbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (txtFiltrado.Text.Length >= 3)
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
            //CAMBIO DE PACIENTES AL CHEQUEAR RADIOBUTTON            
        }
        private void CargarGridView()
        {
            int cantUsuarios = 0;
            DataTable tabla = new DataTable();

            if (rbActivos.Checked == true)
            {
                if (cbxFiltrado.SelectedIndex == 0)
                {
                    Usuarios.RecuperarUsuariosListado(1, 0, txtFiltrado.Text.ToString().Trim(), ref tabla);
                }
                else
                {
                    Usuarios.RecuperarUsuariosListado(1, 1, txtFiltrado.Text.ToString().Trim(), ref tabla);
                }
            }
            else
            {
                if (cbxFiltrado.SelectedIndex == 0)
                {
                    Usuarios.RecuperarUsuariosListado(0, 0, txtFiltrado.Text.ToString().Trim(), ref tabla);
                }
                else
                {
                    Usuarios.RecuperarUsuariosListado(0, 1, txtFiltrado.Text.ToString().Trim(), ref tabla);
                }
            }

            dgvUsuarios.DataSource = tabla;
            dgvUsuarios.Columns["idUsuario"].Visible = false;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            cantUsuarios = tabla.Rows.Count;

            lblCantUsuarios.Text = "Cant. de Usuarios: " + cantUsuarios;

        }
        private void frmUsuarios_Activated(object sender, EventArgs e)
        {
            CargarGridView();
        }
        private void deshabilitarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                //DESHABILITO USUARIO Y PASA A ESTAR INACTIVO
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Usuarios.DeshabilitarUsuario(Usuarios.idUsuarioSelec);
                CargarGridView();
            }
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                //ELIMINO EL USUARIO DE LA BD LLAMANDO AL PROCEDURE
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Usuarios.EliminarUsuario(Usuarios.idUsuarioSelec);
                CargarGridView();
            }
        }

        private void resetearIntentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                //RESETEO LA CANTIDAD DE INTENTOS DE LOGIN DEL USUARIO
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Usuarios.ResetearIntentosLogin(Usuarios.idUsuarioSelec);
                CargarGridView();
            }
        }

        private void habilitarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                //HABILITO USUARIOS INACTIVOS
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Usuarios.HabilitarUsuario(Usuarios.idUsuarioSelec);
                CargarGridView();
            }
        }

        private void frmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                //CONVIERTO GRUPO DE USUARIO A ADMIN
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Grupos.UpdateGrupo(Usuarios.idUsuarioSelec, 1);
                MessageBox.Show("Grupo modificado con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridView();
            }
        }

        private void medicoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                //CONVIERTO GRUPO DE USUARIO A MEDICO/A
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Grupos.UpdateGrupo(Usuarios.idUsuarioSelec, 2);
                MessageBox.Show("Grupo modificado con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridView();
            }
        }

        private void secretariaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                //CONVIERTO GRUPO DE USUARIO A SECRETARIA
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Grupos.UpdateGrupo(Usuarios.idUsuarioSelec, 3);
                MessageBox.Show("Grupo modificado con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridView();
            }
        }

        private void resetearIntentosRecClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.CurrentRow != null)
            {
                //RESETEO LA CANTIDAD DE INTENTOS DE RECUPERACION DE CLAVE DEL USUARIO
                Usuarios.idUsuarioSelec = dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                Usuarios.ResetearIntentosResetearClave(Usuarios.idUsuarioSelec);
                CargarGridView();
            }
        }

        private void txtFiltrado_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltrado.Text.Length >= 3)
            {
                CargarGridView();
            }
            else
            {
                dgvUsuarios.DataSource = null;
            }
        }
    }
}
