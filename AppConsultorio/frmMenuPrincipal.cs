using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsultorio
{
    public partial class frmMenuPrincipal : Form
    {
        //FORM ACTIVO
        private Form activeForm;
        //BOTON ACTUAL
        private Button currentButton;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            this.CenterToScreen();
            //HABILITO/DESHABILITO FUNCIONES DE LA APP EN BASE A SU NIVEL DE ACCESO
            if (Usuarios.AccesoLog == 30)
            {
                btnInfo.Visible = false;
            }
            else if (Usuarios.AccesoLog == 10)
            {
                //SI EL USUARIO ES ADMIN SOLO PUEDE VER EL LISTADO DE USUARIOS Y TODO LO RELEVANTE A USUARIOS
                OpenChildForm(new frmListadoUsuarios(), sender);
                btnTurnos.Enabled = false;
                btnPacientes.Enabled = false;
                btnInfo.Enabled = false;
                btnTurnosHistoricos.Enabled = false;
            }
            Usuarios.RecuperarUsuarioLogeado(Usuarios.idUsuarioLog, ref tabla);
            
            btnUsuario.Text = tabla.Rows[0]["UsuarioNombre"].ToString();
            //BOTON CON NOMBRE DE USUARIO PARA EDICION DE USUARIO/CAMBIO DE CONTRASEÑA
        }
       
        private void ActivarBoton(object btnSender)
        {
            //AL ACTIVAR UN BOTON DEL MENU PRINCIPAL CAMBIO SU APARENCIA
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    BotonDefault();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.LightSeaGreen;
                    currentButton.Font = new System.Drawing.Font("Liberation Sans", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));           
                }
            }
        }
        private void BotonDefault()
        {
            //AL CAMBIAR DE UN BOTON A OTRO RESTAURO EL BOTON VIEJO A SU ESTADO ORIGINAL
            foreach (Control previousBtn in pnlMenuPrincipal.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Teal;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Liberation Sans", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            //PROCESO NECESARIO PARA CARGAR FORMS DENTRO DEL PANEL CONTENEDOR DE FORMS DENTRO DEL MENU PRINCIPAL
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlChildForms.Controls.Add(childForm);
            this.pnlChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;
        }
        private void btnTurnos_Click(object sender, EventArgs e)
        {
            //MUESTRO FORMS TURNOS
            ActivarBoton(sender);
            OpenChildForm(new frmTurnos(), sender);
            pnlBotonesInfo.Visible = false;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
           //MUESTRO FORMS PACIENTES
            ActivarBoton(sender);
            OpenChildForm(new frmPacientes(), sender);
            pnlBotonesInfo.Visible = false;
        }

        private void btnTurnosHistoricos_Click(object sender, EventArgs e)
        {
            //MUESTRO FORMS TURNOS HISTORICOS
            ActivarBoton(sender);
            OpenChildForm(new frmTurnosHistoricos(), sender);
            pnlBotonesInfo.Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //HABILITO EL PANEL CONTENEDOR DE BOTONES RELACIONADOS A INFO
            ActivarBoton(sender);
            pnlBotonesInfo.Visible = true;
        }


        private void btnInfoTurnosRealizados_Click_1(object sender, EventArgs e)
        {
            //MUESTRO FORMS CON INFO DE TURNOS REALIZADOS
            ActivarBoton(sender);
            OpenChildForm(new frmInfoTurnosRealizados(), sender);
        }

        private void btnInfoTurnosCancelados_Click_1(object sender, EventArgs e)
        {
            //MUESTRO FORMS CON INFO DE TURNOS CANCELADOS
            ActivarBoton(sender);
            OpenChildForm(new frmInfoTurnosCancelados(), sender);
        }

        private void btnTotalImportes_Click(object sender, EventArgs e)
        {
            //MUESTRO FORMS CON INFO DE IMPORTES
            ActivarBoton(sender);
            OpenChildForm(new frmInfoImportes(), sender);
        }

        private void btnCancelacionesPacientes_Click(object sender, EventArgs e)
        {
            //MUESTRO FORMS CON INFO CANTIDAD DE CANCELACIONES POR PACIENTES
            ActivarBoton(sender);
            OpenChildForm(new frmInfoCancelacionesPacientes(), sender);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //AL CERRAR SESION SE RESETEA LA APLICACION Y SE VUELVE AL FORMULARIO DE LOGIN
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            //ABRO EL FORMS PARA LA EDICION DE USUARIO
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }
    }
}
