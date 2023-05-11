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
    public partial class frmCargaUsuarios : Form
    {
        public frmCargaUsuarios()
        {
            InitializeComponent();
        }

        private void frmCargaUsuarios_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            DataTable tabla = new DataTable();
            Usuarios.RecuperarGrupos(ref tabla);
            cbxGrupos.DataSource = tabla;
            cbxGrupos.DisplayMember = "Grupo";
            cbxGrupos.ValueMember = "idGrupo";
            cbxGrupos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGrupos.SelectedIndex = 0;
        }
        private bool Verificar()
        {
            bool ok = false;
            DataTable tabla = new DataTable();

            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                if (Modulo.ValidarFiltro(txtApellido.Text.ToString()))
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        if (Modulo.ValidarFiltro(txtNombre.Text.ToString()))
                        {
                            if (!string.IsNullOrEmpty(txtUsuario.Text))
                            {
                                if (Modulo.ValidarFiltro(txtUsuario.Text.ToString()))
                                {
                                    if (!string.IsNullOrEmpty(txtContraseña.Text))
                                    {
                                        if (Modulo.ValidarFiltro(txtContraseña.Text.ToString()))
                                        {
                                            if (!string.IsNullOrEmpty(txtRepetirContraseña.Text))
                                            {
                                                if (txtContraseña.Text.ToString().Trim() == txtRepetirContraseña.Text.ToString().Trim())
                                                {
                                                    Usuarios.VerificarUsuarioNuevo(txtUsuario.Text.ToString().Trim(), ref tabla);
                                                    if (tabla.Rows.Count == 0)
                                                    {
                                                        ok = true;
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Nombre de usuario no disponible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        txtUsuario.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Las contraseñas no coinciden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    txtRepetirContraseña.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Debe repetir la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                txtRepetirContraseña.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ingreso un caracter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            txtContraseña.Focus();
                                        }
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe ingresar una constraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtContraseña.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingreso un caracter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtUsuario.Focus();
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtUsuario.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingreso un caracter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNombre.Focus();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNombre.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingreso un caracter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellido.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un apellido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
            }
            return ok;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                string passHash = Usuarios.GenerarHash256(txtContraseña.Text.ToString().Trim());
                MessageBox.Show(passHash.Length.ToString());
                Usuarios.RegistrarUsuario(txtUsuario.Text.ToString().Trim(), passHash.ToString().Trim(),txtApellido.Text.ToString().Trim(), txtNombre.Text.ToString().Trim(),cbxGrupos.SelectedValue.ToString());
                this.Close();
            }
        }
    }
}
