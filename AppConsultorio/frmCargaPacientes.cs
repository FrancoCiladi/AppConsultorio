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
    public partial class frmCargaPacientes : Form
    {
        public frmCargaPacientes()
        {
            InitializeComponent();
        }

        private void frmCargaPacientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //CAMBIAR CUANDO SE EDITA Y CUANDO SE CARGA EL  TITULO DEL FORM Y EL NOMBRE DEL BUTTON usando operacion

        }
    }
}
