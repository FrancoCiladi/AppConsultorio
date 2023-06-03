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
        private Form activeForm;
        private Button currentButton;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            this.CenterToScreen();
            if (Usuarios.AccesoLog == 30)
            {
                btnInfo.Visible = false;
            }
            else if (Usuarios.AccesoLog == 10)
            {
                OpenChildForm(new frmListadoUsuarios(), sender);
                pnlMenuPrincipal.Enabled = false;
            }
            Usuarios.RecuperarUsuarioLogeado(Usuarios.idUsuarioLog, ref tabla);
            
            btnUsuario.Text = tabla.Rows[0]["UsuarioNombre"].ToString();
        }
       
        private void ActivarBoton(object btnSender)
        {
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
            ActivarBoton(sender);
            OpenChildForm(new frmTurnos(), sender);
            pnlBotonesInfo.Visible = false;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            OpenChildForm(new frmPacientes(), sender);
            pnlBotonesInfo.Visible = false;
        }

        private void btnTurnosHistoricos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            OpenChildForm(new frmTurnosHistoricos(), sender);
            pnlBotonesInfo.Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            pnlBotonesInfo.Visible = true;
        }


        private void btnInfoTurnosRealizados_Click_1(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            OpenChildForm(new frmInfoTurnosRealizados(), sender);
        }

        private void btnInfoTurnosCancelados_Click_1(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            OpenChildForm(new frmInfoTurnosCancelados(), sender);
        }

        private void btnCancelacionesPacientes_Click_1(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            OpenChildForm(new frmInfoCancelacionesPacientes(), sender);
        }

        private void btnTotalImportes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            OpenChildForm(new frmInfoImportes(), sender);
        }

        private void btnCancelacionesPacientes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            OpenChildForm(new frmInfoCancelacionesPacientes(), sender);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


    }
}
