using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

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

            //CARGA DE COMBOBOX DE PREGUNTAS DE SEGURIDAD
            DataTable tabla = new DataTable();
            PreguntasSeguridad.RecuperarPreguntasSeguridad(ref tabla);
            cbxPreguntaSeguridad.DataSource = tabla;
            cbxPreguntaSeguridad.DisplayMember = "Descripcion";
            cbxPreguntaSeguridad.ValueMember = "idPregunta";
            cbxPreguntaSeguridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPreguntaSeguridad.SelectedIndex = 0;
        }
        private bool Verificar()
        {
           //VERIFICACION DE CONTROLES
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
                                                    if (!string.IsNullOrEmpty(txtCorreo.Text.ToString()))
                                                    {
                                                        if (!string.IsNullOrEmpty(txtRespuestaSeguridad.Text))
                                                        {
                                                            if (Modulo.ValidarFiltro(txtRespuestaSeguridad.Text.ToString()))
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
                                                                MessageBox.Show("Ingreso un caracter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                txtContraseña.Focus();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Complete la respuesta de seguridad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            txtRespuestaSeguridad.Focus();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Ingrese un correo electronico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        txtCorreo.Focus();
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
                
                DataTable tabla;

                //GENERACION DE SALT
                string salt = Usuarios.SecurityHelper.GenerateSalt(32);
                //SE COMBINA LA SALT GENERADA JUNTO A LA CONTRASEÑA INGRESADA
                string passHash = Usuarios.SecurityHelper.HashPassword(txtContraseña.Text.ToString().Trim(), salt, 10000, 32);

                Usuarios.RegistrarUsuario(txtUsuario.Text.ToString().Trim(), passHash,txtApellido.Text.ToString().Trim(), txtNombre.Text.ToString().Trim(),salt,txtCorreo.Text.ToString().Trim());

                //NECESARIO PARA RECUPERAR EL ID DEL USUARIO RECIEN CREADO, REUTILIZO EL PROCEDURE 'RecuperarUsuarioLogin'
                tabla = new DataTable();
                Usuarios.RecuperarUsuarioLogin(txtUsuario.Text.ToString().Trim(), ref tabla);

                //GENERO NUEVAMENTE OTRA SALT
                string saltRespuesta = Usuarios.SecurityHelper.GenerateSalt(32);
                //COMBINO SALT CON RESPUESTA DE SEGURIDAD INGRESADA
                string respuestaHash = Usuarios.SecurityHelper.HashPassword(txtRespuestaSeguridad.Text.ToString().Trim(), saltRespuesta, 10000, 32);
                string idUsuario = tabla.Rows[0]["idUsuario"].ToString();
                PreguntasSeguridad.RegistrarPreguntaSeguridad(idUsuario, cbxPreguntaSeguridad.SelectedValue.ToString(), respuestaHash, saltRespuesta,Usuarios.GenerarCodigoVerificacion());
                GenerarCorreoElectronico();

                this.Close();
            }
        }

        private void GenerarCorreoElectronico()
        {
            //RECUPERO USUARIO RECIEN CREADO PARA SABER SU ID
            DataTable usuario = new DataTable();
            Usuarios.RecuperarUsuarioLogin(txtUsuario.Text.ToString().Trim(), ref usuario);
            DataTable usuario_seguridad = new DataTable();
            Usuarios.RecuperarUsuarioSeguridad(usuario.Rows[0]["idUsuario"].ToString(), ref usuario_seguridad);

            var email = new MimeMessage();
            string nombreCompleto = txtApellido.Text.ToString().Trim() + " " + txtNombre.Text.ToString().Trim();
            email.From.Add(new MailboxAddress("Consultorio", "franco.ciladi@gmail.com"));
            email.To.Add(new MailboxAddress(nombreCompleto.ToString().Trim(),txtCorreo.Text.ToString().Trim()));

            email.Subject = "Codigo de Verificación";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = "<b>El codigo de verificacion para habilitar la cuenta es: </b>" + usuario_seguridad.Rows[0]["Codigo_Verificacion"].ToString().Trim()
            };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, false);

                smtp.Authenticate("franco.ciladi@gmail.com", "qzfo oahs wpgi pxoa");

                smtp.Send(email);
                smtp.Disconnect(true);
            }

            MessageBox.Show("Correo Enviado!.", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
