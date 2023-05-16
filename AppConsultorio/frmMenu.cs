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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (Usuarios.AccesoLog > 20)
            {
                btnInfo.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.ShowDialog();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            frmTurnos frmTurnos = new frmTurnos();
            frmTurnos.ShowDialog();
        }

        private void btnTurnosHistoricos_Click(object sender, EventArgs e)
        {
            frmTurnosHistoricos frmTurnosHistoricos = new frmTurnosHistoricos();
            frmTurnosHistoricos.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfo frmInfo = new frmInfo();
            frmInfo.ShowDialog();
        }
    }
}
