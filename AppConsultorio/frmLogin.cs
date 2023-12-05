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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtCodigoVerificacion.Visible = false;
            lblCodigo.Visible = false;
            lnkNuevoCodigo.Visible = false;
        }

        private void lblNuevoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ABRO FORMS DE CARGA DE USUARIOS AL HACER CLICK EN LABEL NUEVO USUARIO
            frmCargaUsuarios frmCargaUsuarios = new frmCargaUsuarios();
            frmCargaUsuarios.ShowDialog();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Start();             
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            //SI EL USUARIO APRETA TECLA ENTER EN EL CAMPO CONTRASEÑA LLAMARA AL PROCESO DE VERIFICACION DE LOGIN
            if (e.KeyCode == Keys.Enter)
            {
                Start();
            }
        }
        private void Start()
        {
            DataTable tabla;
            string HashPass;
            string salt;
            int LogFall;

            if (!string.IsNullOrEmpty(txtUsuario.Text.ToString().Trim()))
            {
                if (!string.IsNullOrEmpty(txtContraseña.Text.ToString().Trim()))
                {
                    if (Modulo.ValidarFiltro(txtUsuario.Text.ToString()))
                    {
                        tabla = new DataTable();
                        Usuarios.RecuperarUsuarioLogin(txtUsuario.Text.ToString().Trim(), ref tabla);
                        //VERIFICO QUE EL USUARIO EXISTA
                        if (tabla.Rows.Count == 1)
                        {
                            //SI EXISTE VERIFICO LA CANTIDAD DE INTENTOS DE LOGIN
                            LogFall = int.Parse(tabla.Rows[0]["LogFall"].ToString());
                            if (LogFall < 4)
                            {                               
                                //SI TIENE INTENTOS RESTANTES RECUPERO LA SALT, GENERO UN HASH DE LA CONTRASEÑA INGRESADA Y SE COMPARA CON LA ALMACENADA EN BD
                                salt = tabla.Rows[0]["Salt"].ToString();
                                HashPass = Usuarios.SecurityHelper.HashPassword(txtContraseña.Text.ToString().Trim(), salt, 10000, 32);
                                if (HashPass == tabla.Rows[0]["Pass"].ToString().Trim())
                                {
                                    //CONTRASEÑAS COINCIDEN, PROCEDO A VERIFICAR ESTADO DE USUARIO
                                    switch (tabla.Rows[0]["Activo"])
                                    {
                                        //VERIFICO SI ES UN USUARIO RECIEN REGISTRADO PARA PEDIR CODIGO DE VERIFICACION
                                        case -1:
                                            txtCodigoVerificacion.Visible = true;
                                            lblCodigo.Visible = true;
                                            lnkNuevoCodigo.Visible = true;

                                            if (!string.IsNullOrEmpty(txtCodigoVerificacion.Text.ToString()))
                                            {
                                                DataTable usuario_Seguridad = new DataTable();
                                                Usuarios.RecuperarUsuarioSeguridad(tabla.Rows[0]["idUsuario"].ToString(), ref usuario_Seguridad);

                                                if (usuario_Seguridad.Rows[0]["Codigo_Verificacion"].ToString().Trim() == txtCodigoVerificacion.Text.ToString().Trim())
                                                {
                                                    Usuarios.HabilitarUsuario(tabla.Rows[0]["idUsuario"].ToString());
                                                    txtCodigoVerificacion.Visible = false;
                                                    lblCodigo.Visible = false;
                                                    lnkNuevoCodigo.Visible = false;
                                                    tabla = new DataTable();
                                                    Usuarios.RecuperarUsuarioLogin(txtUsuario.Text.ToString().Trim(), ref tabla);

                                                    Usuarios.ResetearIntentosLogin(tabla.Rows[0]["idUsuario"].ToString());

                                                    Usuarios.idUsuarioLog = tabla.Rows[0]["idUsuario"].ToString();
                                                    Usuarios.AccesoLog = int.Parse(tabla.Rows[0]["Acceso"].ToString());

                                                    this.DialogResult = DialogResult.OK;

                                                    this.Close();
                                                }
                                                else
                                                {
                                                    Usuarios.AumentarIntentosLogin(tabla.Rows[0]["idUsuario"].ToString());
                                                    MessageBox.Show("Codigo incorrecto. Intentos restantes: " + (4 - LogFall), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    return;
                                                }
                                            }
                                            break;
                                        case 0:
                                            MessageBox.Show("El usuario no se encuentra activo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            break;
                                        case 1:
                                            //USUARIO ACTIVO -> RESETEO INTENTOS LOGIN, GUARDO SU ID Y NIVEL DE ACCESO Y SE ACCEDE A LA APLICACION
                                            Usuarios.ResetearIntentosLogin(tabla.Rows[0]["idUsuario"].ToString());

                                            Usuarios.idUsuarioLog = tabla.Rows[0]["idUsuario"].ToString();
                                            Usuarios.AccesoLog = int.Parse(tabla.Rows[0]["Acceso"].ToString());

                                            this.DialogResult = DialogResult.OK;

                                            this.Close();
                                        break;

                                    }
                                    
                                    
                                }
                                else
                                {
                                    //CONTRASEÑA INCORRECTA -> AUMENTO DE INTENTOS DE LOGIN
                                    Usuarios.AumentarIntentosLogin(tabla.Rows[0]["idUsuario"].ToString());
                                    MessageBox.Show("Contraseña incorrecta. Intentos restantes: " + (4 - LogFall), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El usuario se encuentra bloqueado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El logeo es incorrecto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Ingrese una contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }

        }

        private void lblOlvideContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //AL HACER CLICK EN LABEL DE OLVIDAR CONTRASEÑA SE PROCEDE A LLAMAR AL FORM PARA RECUPERAR CLAVE
            frmRecuperarClave frmRecuperarClave = new frmRecuperarClave();
            frmRecuperarClave.ShowDialog();
        }

        private void lnkNuevoCodigo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text))
            {
                //RECUPERO EL USUARIO PARA EXTRAER SU ID
                DataTable usuario = new DataTable();
                Usuarios.RecuperarUsuarioLogin(txtUsuario.Text.ToString(), ref usuario);
                if (usuario.Rows.Count == 1)
                {
                    //LLAMO AL PROCEDIMIENTO QUE GENERA UN NUEVO CODIGO Y SE REALIZA UN UPDATE
                    Usuarios.GenerarNuevoCodigoVerificacion(usuario.Rows[0]["idUsuario"].ToString(), Usuarios.GenerarCodigoVerificacion().ToString());

                    //RECUPERO EL CODIGO GENERADO PARA ENVIARLO POR CORREO
                    DataTable usuario_seguridad = new DataTable();
                    Usuarios.RecuperarUsuarioSeguridad(usuario.Rows[0]["idUsuario"].ToString(), ref usuario_seguridad);

                    //GENERO UN CORREO ELECTRONICO CON EL CODIGO GENERADO

                    var email = new MimeMessage();

                    email.From.Add(new MailboxAddress("Consultorio", "franco.ciladi@gmail.com"));
                    email.To.Add(new MailboxAddress(usuario.Rows[0]["NombreCompleto"].ToString(), usuario.Rows[0]["Correo"].ToString()));

                    email.Subject = "Codigo de Verificación";
                    email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                    {
                        Text = "<b>El codigo de verificacion para habilitar la cuenta es: </b>" + usuario_seguridad.Rows[0]["Codigo_Verificacion"].ToString()                      
                    };

                    using (var smtp = new SmtpClient())
                    {
                        smtp.Connect("smtp.gmail.com", 587, false);

                        smtp.Authenticate("franco.ciladi@gmail.com", "qzfo oahs wpgi pxoa");

                        smtp.Send(email);
                        smtp.Disconnect(true);
                    }

                    MessageBox.Show("Se ha enviado un codigo de verificacion a su correo que debera ser ingresado en su proximo logeo. El codigo expira pasados los 10 min.", "Codigo Generado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario para poder generar un nuevo codigo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
               
        }
    }
}
