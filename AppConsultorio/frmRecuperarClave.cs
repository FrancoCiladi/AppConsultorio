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
                //GENERO SALT Y LUEGO GENERO UN HASH DE LA CONTRASEÑA INGRESADA UTILIZANDO LA SALT
                string salt = Usuarios.SecurityHelper.GenerateSalt(32);
                string passHash = Usuarios.SecurityHelper.HashPassword(txtNuevaContraseña.Text.ToString().Trim(), salt, 10000, 32);

                Usuarios.ResetearContraseña(Usuarios.idUsuarioSelec, passHash, salt);
                //UNA VEZ RESETEADA LA CONTRASEÑA POR SEGURIDAD SERA INHABILITADO Y DEBERA SER HABILITADO POR EL ADMIN
                MessageBox.Show("Contraseña guardada. Espere a ser habilitado por el admin.", "Modificacion Realizada!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //SI RESPONDE BIEN A LA PREGUNTA DE SEGURIDAD SE HABILITA EL PANEL CON LOS CONTROLES PARA RESETAR CLAVE
            if (VerificarUsuario())
            {
                pnlPrincipal.Visible = false;
                pnlSecundario.Visible = true;
            }
        }
        private bool VerificarUsuario()
        {
            bool ok = false;
            string salt;
            string hashRespuesta;
            int ResFall;
            DataTable tabla = new DataTable();

            Usuarios.RecuperarUsuarioLogin(txtUsuario.Text.ToString().Trim(),ref tabla);
            //VERIFICO QUE USUARIO EXISTA
            if (tabla.Rows.Count == 1)
            {
                //SI EXISTE VERIFICO SUS INTENTOS DE LOGIN
                ResFall = int.Parse(tabla.Rows[0]["ResFall"].ToString());
                if (ResFall < 4)
                {
                    //SI TIENE INTENTOS RESTANTES VERIFICO SU PREGUNTA Y RESPUESTA DE SEGURIDAD
                    Usuarios.idUsuarioSelec = tabla.Rows[0]["idUsuario"].ToString();

                    PreguntasSeguridad.VerificarPreguntaSeguridad(Usuarios.idUsuarioSelec, ref tabla);

                    //GENERO SALT Y HASH DE RESPUESTA DE SEGURIDAD Y COMPARO LA GENERADA CON LA PASS EN LA BD
                    salt = tabla.Rows[0]["Salt"].ToString();
                    hashRespuesta = Usuarios.SecurityHelper.HashPassword(txtRespuestaSeguridad.Text.ToString().Trim(), salt, 10000, 32);

                    if (hashRespuesta == tabla.Rows[0]["Respuesta"].ToString() && cbxPreguntasSeguridad.SelectedValue.ToString() == tabla.Rows[0]["idPregunta"].ToString())
                    {
                        //PREGUNTA Y RESPUESTA COINCIDEN
                        Usuarios.ResetearIntentosResetearClave(Usuarios.idUsuarioSelec);
                        ok = true;
                    }
                    else
                    {
                        Usuarios.AumentarIntentosResetearClave(Usuarios.idUsuarioSelec);
                        MessageBox.Show("Incorrecto. Intentos restantes: " + (4 - ResFall), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            //VERIFICO LAS CONTRASEÑAS INGRESADAS Y SI AMBAS COINCIDEN
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
            PreguntasSeguridad.RecuperarPreguntasSeguridad(ref tabla);
            cbxPreguntasSeguridad.DataSource = tabla;
            cbxPreguntasSeguridad.DisplayMember = "Descripcion";
            cbxPreguntasSeguridad.ValueMember = "idPregunta";
            cbxPreguntasSeguridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPreguntasSeguridad.SelectedIndex = 0;
        }
    }
}
