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
    public partial class frmNuevoTurno : Form
    {
        public frmNuevoTurno()
        {
            InitializeComponent();
        }

        private void frmNuevoTurno_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            dtpFecha.MinDate = DateTime.Now;
        }
    }
}
