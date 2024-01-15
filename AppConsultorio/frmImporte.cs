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
    public partial class frmImporte : Form
    {
        public frmImporte()
        {
            InitializeComponent();
        }

        private void frmImporte_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            DataTable tabla = new DataTable();
            Turnos.RecuperarImporte(Turnos.idTurnoSelec, ref tabla);
            txtImporte.Text = tabla.Rows[0]["importe"].ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarImporte(txtImporte.Text))
            {
                //VERIFICACION CORRECTA, LLAMO A PROCEDURE CORRESPONDIENTE
                Turnos.IngresarImporte(txtImporte.Text, Turnos.idTurnoSelec);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar un importe valido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtImporte.Focus();
            }
            
        }
        private bool VerificarImporte(string importe)
        {
            //VERIFICO QUE EL IMPORTE INGRESADO SEAN NUMEROS
            bool ok = false;

            if (importe.All(char.IsDigit))
            {
                ok = true;
            }
            return ok;
        }
    }
}
