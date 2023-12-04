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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        private bool VerificarContraseña()
        {
            bool ok = false;
            DataTable tabla;
            string HashPass;
            string salt; 
            if (!string.IsNullOrEmpty(txtContraseñaActual.Text))
            {
                tabla = new DataTable();
                Usuarios.RecuperarUsuarioLogeado(Usuarios.idUsuarioLog, ref tabla);
                //RECUPERO LA SALT DEL USUARIO EN LA BD Y CREO UN HASH CON LA CONTRASEÑA INGRESADA
                salt = tabla.Rows[0]["Salt"].ToString();
                HashPass = Usuarios.SecurityHelper.HashPassword(txtContraseñaActual.Text.ToString().Trim(), salt, 10000, 32);

                if (HashPass == tabla.Rows[0]["Pass"].ToString().Trim())
                {
                    //SI EL HASH CREADO COINCIDE CON EL HASH EN LA BD PROCEDO A VERIFICAR
                    if (!string.IsNullOrEmpty(txtNuevaContraseña.Text))
                    {
                        if (!string.IsNullOrEmpty(txtRepetirContraseña.Text))
                        {
                            if (txtNuevaContraseña.Text.Trim() == txtRepetirContraseña.Text.Trim())
                            {
                                //AMBAS CONTRASEÑAS COINCIDEN Y SE MODIFICA LA CONTRASEÑA 
                                ok = true;
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas no coinciden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);                               
                            }
                        }
                        else
                        {
                            MessageBox.Show("Repita la contraseña nueva.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtRepetirContraseña.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Complete la nueva contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNuevaContraseña.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña actual incorrecta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseñaActual.Focus();
                }
            }
            else
            {
                MessageBox.Show("Complete la contraseña actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseñaActual.Focus();
            }
            return ok;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarContraseña())
            {
                //PREGUNTO AL USUARIO SI REALMENTE DESEA PROSEGUIR CON EL CAMBIO DE CLAVE
                DialogResult dialogresult = MessageBox.Show("Al cambiar la contraseña debera ingresar nuevamente, ¿desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogresult == DialogResult.Yes)
                {
                    string salt = Usuarios.SecurityHelper.GenerateSalt(32);
                    string passHash = Usuarios.SecurityHelper.HashPassword(txtNuevaContraseña.Text.ToString().Trim(), salt, 10000, 32);

                    Usuarios.CambiarContraseña(Usuarios.idUsuarioLog.ToString(), passHash, salt);
                    //GUARDO LA NUEVA CONTRASEÑA Y VUELVO AL FORM DE LOGIN

                    MessageBox.Show("Contraseña modificada.", "Contraseña modificada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
     
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            DataTable tabla = new DataTable();

            //CARGO LOS DATOS DEL USUARIO

            Usuarios.RecuperarUsuarioEditar(Usuarios.idUsuarioLog, ref tabla);
            txtApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txtUsuario.Text = tabla.Rows[0]["Usuario"].ToString();
            txtCorreo.Text = tabla.Rows[0]["Correo"].ToString();
        }
        private bool VerificarUpdateUsuario()
        {
            //VERIFICACION DE MODIFICACION DE DATOS DEL USUARIO : NOMBRE,APELLIDO,NOMBRE DE USUARIO,CORREO
            bool ok = false;
            DataTable tabla = new DataTable();
            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    if (!string.IsNullOrEmpty(txtUsuario.Text))
                    {
                        if(!string.IsNullOrEmpty(txtCorreo.Text))
                        {
                            Usuarios.VerificarUpdateUsuario(Usuarios.idUsuarioLog, txtUsuario.Text.Trim(), ref tabla);
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
                            MessageBox.Show("Ingrese un correo electronico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUsuario.Focus();
                        }                      
                    }
                    else
                    {
                        MessageBox.Show("Complete el usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Complete el nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Complete el apellido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
            }
            return ok;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarUpdateUsuario())
            {
                //VERIFICACION EXITOSA -> UPDATE DE DATOS EN LA BD
                Usuarios.UpdateUsuario(Usuarios.idUsuarioLog, txtApellido.Text.Trim(), txtNombre.Text.Trim(), txtUsuario.Text.Trim());
                MessageBox.Show("Modificacion realizada con exito!", "Modificacion realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
