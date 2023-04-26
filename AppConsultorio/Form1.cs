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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void lblNuevoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lblRepetirContraseña.Visible = true;
            this.txtRepetirContraseña.Visible =true;
            this.btnRegistrar.Visible = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro con exito. Espere a la habilitacion de su cuenta.", "Registracion Completada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //verificacion de login, ver clase ejercicio 8 programacion 3
            //esto de abajo es una prueba para llevar de un form a otro
            this.Hide();
            frmPacientes frmPacientes = new frmPacientes();
            frmPacientes.ShowDialog();
            
        }
    }
}
