using AppConsultorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppConsultorio
{
    public partial class frmAgregarPacientes : Form
    {
        public frmAgregarPacientes()
        {
            InitializeComponent();
        }

        private void frmCargaPacientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            DataTable tabla = new DataTable();
            Pacientes.RecuperarObrasSociales(ref tabla);
            cbxObrasSociales.DataSource = tabla;
            cbxObrasSociales.DisplayMember = "descripcion";
            cbxObrasSociales.ValueMember = "idObraSocial";
            cbxObrasSociales.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxObrasSociales.SelectedIndex = 0;

            if (Pacientes.Operacion == "MODIFICAR")
            {
                Pacientes.RecuperarPacienteUpdate(Pacientes.idPacienteSelec.ToString(), ref tabla);

                txtApellido.Text = tabla.Rows[0]["apellido"].ToString().Trim();
                txtNombre.Text = tabla.Rows[0]["nombre"].ToString().Trim();
                txtNroDoc.Text = tabla.Rows[0]["nro_doc"].ToString().Trim();
                txtTelefono.Text = tabla.Rows[0]["telefono"].ToString().Trim();
                txtCorreo.Text = tabla.Rows[0]["email"].ToString().Trim();
                cbxObrasSociales.SelectedValue = tabla.Rows[0]["idObra_Social"].ToString().Trim();
                this.Text = "Modificar Paciente";
                btnAgregarPaciente.Text = "Guardar Cambios";

            }
            else
            {
                Pacientes.Operacion = "ALTA";

                txtApellido.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtNroDoc.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtCorreo.Text = string.Empty;
                cbxObrasSociales.SelectedIndex = 0;
                
                this.Text = "Agregar Paciente";
                btnAgregarPaciente.Text = "Guardar";
            }
        }
        private bool Verificar()
        {
            DataTable tabla = new DataTable();
            bool ok = false;
            int nrodoc;

            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    if ((!string.IsNullOrEmpty(txtNroDoc.Text)) && (int.TryParse(txtNroDoc.Text, out nrodoc)))
                    {
                        if (!string.IsNullOrEmpty(txtTelefono.Text))
                        {
                            if (VerificarTelefono(txtTelefono.Text))
                            {
                                if (Pacientes.Operacion.Equals("ALTA"))
                                {
                                    Pacientes.VerificarInsertPaciente(txtNroDoc.Text, ref tabla);
                                }
                                else
                                {
                                    Pacientes.VerificarUpdatePaciente(txtNroDoc.Text, Pacientes.idPacienteSelec.ToString(), ref tabla);
                                }
                                if (tabla.Rows.Count == 0)
                                {
                                    ok = true;
                                }
                                else
                                {
                                    MessageBox.Show("Ya se encuentra un paciente con el mismo DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtNroDoc.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar un nro. de telefono valido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtTelefono.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar un nro. de telefono.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTelefono.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar el nro. de documento del paciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNroDoc.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar el nombre del paciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe completar el apellido del paciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();                   
            }
            return ok;
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                if (Pacientes.Operacion.Equals("ALTA"))
                {
                    string estado = "ACT";
                    Pacientes.InsertarPaciente(txtNroDoc.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text, txtCorreo.Text, estado, cbxObrasSociales.SelectedValue.ToString());
                    this.Close();
                }
                else
                {
                    Pacientes.ActualizarPaciente(Pacientes.idPacienteSelec, txtNroDoc.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text, txtCorreo.Text, cbxObrasSociales.SelectedValue.ToString());
                    this.Close();
                }
            }
        }

        private bool VerificarTelefono(string telefono)
        {
            bool ok = false;

            if (telefono.All(char.IsDigit))
            {
                ok = true;
            }
            return ok;
        }
    }
}
