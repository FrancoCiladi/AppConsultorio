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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActivos.Checked)
            {
                rbActivos.Checked = true;
                rbInactivos.Checked = false;
            }
            else
            {
                rbActivos.Checked = false;
                rbInactivos.Checked = true;
            }
        }

        private void rbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInactivos.Checked)
            {
                rbActivos.Checked = false;
                rbInactivos.Checked = true;
            }
            else
            {
                rbActivos.Checked = true;
                rbInactivos.Checked = false;
            }
        }
    }
}
