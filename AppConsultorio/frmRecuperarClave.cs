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
            if (VerificarContraseña())
            {
                string salt = Usuarios.SecurityHelper.GenerateSalt(32);
                string passHash = Usuarios.SecurityHelper.HashPassword(txtNuevaContraseña.Text.ToString().Trim(), salt, 10000, 32);

                Usuarios.ResetearContraseña(Usuarios.idUsuarioSelec, passHash, salt);
                MessageBox.Show("Contraseña guardada. Espere a ser habilitado por el admin.", "Modificacion Realizada!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (VerificarUsuario())
            {
                pnlSecundario.Visible = true;
            }
        }
        private bool VerificarUsuario()
        {
            bool ok = false;
            string salt;
            string hashRespuesta;
            int LogFall;
            DataTable tabla = new DataTable();

            Usuarios.RecuperarUsuarioLogin(txtUsuario.Text.ToString().Trim(),ref tabla);
            if (tabla.Rows.Count == 1)
            {
                LogFall = int.Parse(tabla.Rows[0]["LogFall"].ToString());
                if (LogFall < 4)
                {
                    Usuarios.idUsuarioSelec = tabla.Rows[0]["idUsuario"].ToString();

                    Usuarios.VerificarPreguntaSeguridad(Usuarios.idUsuarioSelec, ref tabla);

                    salt = tabla.Rows[0]["Salt"].ToString();
                    hashRespuesta = Usuarios.SecurityHelper.HashPassword(txtRespuestaSeguridad.Text.ToString().Trim(), salt, 10000, 32);

                    if (hashRespuesta == tabla.Rows[0]["Respuesta"].ToString() && cbxPreguntasSeguridad.SelectedValue.ToString() == tabla.Rows[0]["idPregunta"].ToString())
                    {
                        ok = true;
                    }
                    else
                    {
                        Usuarios.AumentarIntentosLogin(Usuarios.idUsuarioSelec);
                        MessageBox.Show("Incorrecto. Intentos restantes: " + (4 - LogFall), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No tiene mas intentos, contacte al administrador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }  
            }
            else
            {
                MessageBox.Show("No se encontro el usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }

            return ok;
        }
        private bool VerificarContraseña()
        {
            bool ok = false;

            if (!string.IsNullOrEmpty(txtNuevaContraseña.Text.ToString().Trim()))
            {
                if (!string.IsNullOrEmpty(txtRepetirContraseña.Text.ToString().Trim()))
                {
                    if (txtNuevaContraseña.Text.ToString().Trim() == txtRepetirContraseña.Text.ToString().Trim())
                    {
                        ok = true;
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Repita la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNuevaContraseña.Focus();
                }
            }
            else
            {
                MessageBox.Show("Complete la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuevaContraseña.Focus();
            }

            return ok;
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
