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
    public partial class frmTurnosPaciente : Form
    {
        public frmTurnosPaciente()
        {
            InitializeComponent();
        }

        private void dgvTurnosPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuando haga doble click en uno de los turnos aparecera el detalle con las observaciones
            frmDetalleTurno frmDetalleTurno = new frmDetalleTurno();
            frmDetalleTurno.ShowDialog();
        }
    }
}
