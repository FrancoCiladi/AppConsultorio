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
            //CARGO EL COMBOBOX CON OBRAS SOCIALES
            ObrasSociales.RecuperarObrasSociales(ref tabla);
            cbxObrasSociales.DataSource = tabla;
            cbxObrasSociales.DisplayMember = "descripcion";
            cbxObrasSociales.ValueMember = "idObraSocial";
            cbxObrasSociales.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxObrasSociales.SelectedIndex = 0;

            if (Pacientes.Operacion == "MODIFICAR")
            {
                //SI SE MODIFICA PACIENTE SE CARGAN LOS DATOS DEL PACIENTE EN LOS CONTROLES RESPECTIVOS
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
                //PACIENTES NUEVOS = CONTROLES VACIOS
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
            //VERIFICACION DE CONTROLES
            DataTable tabla = new DataTable();
            bool ok = false;
            int nrodoc;

            if (!string.IsNullOrEmpty(txtApellido.Text.ToString().Trim()))
            {
                if (Modulo.ValidarFiltro(txtApellido.Text.ToString().Trim()))
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text.ToString().Trim()))
                    {
                        if (Modulo.ValidarFiltro(txtNombre.Text.ToString().Trim()))
                        {
                            if ((!string.IsNullOrEmpty(txtNroDoc.Text.ToString().Trim())) && (int.TryParse(txtNroDoc.Text.ToString().Trim(), out nrodoc)))
                            {
                                if (Modulo.ValidarFiltro(txtNroDoc.Text.ToString().Trim()))
                                {
                                    if (!string.IsNullOrEmpty(txtTelefono.Text.ToString().Trim()))
                                    {
                                        if (VerificarTelefono(txtTelefono.Text.ToString().Trim()))
                                        {
                                            if (Pacientes.Operacion.Equals("ALTA"))
                                            {
                                                Pacientes.VerificarInsertPaciente(txtNroDoc.Text.ToString().Trim(), ref tabla);
                                            }
                                            else
                                            {
                                                Pacientes.VerificarUpdatePaciente(txtNroDoc.Text.ToString().Trim(), Pacientes.idPacienteSelec.ToString(), ref tabla);
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
                                    MessageBox.Show("Ingreso un caracter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtNroDoc.Focus();
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
                            MessageBox.Show("Ingreso un caracter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNombre.Focus();
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
                    MessageBox.Show("Ingreso un caracter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellido.Focus();
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
            //DEPENDIENDO DE LA OPERACION SE LLAMARA AL PROCEDURE CORRESPONDIENTE
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
            //VERIFICACION DE NUMERO DE TELEFONO VALIDO
            bool ok = false;

            if (telefono.All(char.IsDigit))
            {
                ok = true;
            }
            return ok;
        }
    }
}
