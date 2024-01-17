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
    public partial class frmInfoTurnosCancelados : Form
    {
        public frmInfoTurnosCancelados()
        {
            InitializeComponent();
        }

        private void frmInfoTurnosCancelados_Load(object sender, EventArgs e)
        {
            //CREO LISTA DE AÑOS EMPEZANDO POR EL PRIMERO HASTA EL ACTUAL
            List<int> años = Enumerable.Range(2023, (DateTime.Now.Year - 2023 + 1)).Reverse().ToList();
            //CARGO EL COMBOBOX CON TODOS LOS AÑOS GENERADOS HASTA LA ACTUALIDAD
            foreach (int año in años)
            {
                cbxAño.Items.Add(año);
            }
            cbxAño.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAño.SelectedIndex = 0;

            //LIMPIO EL CHART PARA PREVENIR QUE SE GENERE DE MANERA ERRONEA 
            chartTurnosCancelados.Series["Turnos Cancelados"].Points.Clear();
            fillChart();

        }
        private void fillChart()
        {
            int  TotalTurnosCancelados;

            TotalTurnosCancelados = 0;

            //Necesario para que no oculte meses en el chart
            chartTurnosCancelados.ChartAreas.FirstOrDefault().AxisX.Interval = 1;

            //Mostrar valor exacto de cada barra
            chartTurnosCancelados.Series["Turnos Cancelados"].IsValueShownAsLabel = true;

            //Eliminar gridlines
            chartTurnosCancelados.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartTurnosCancelados.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

            //Hacer que el valor de las labels de barras tengan mejor visibilidad
            chartTurnosCancelados.Series["Turnos Cancelados"].Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold);

            for (int i = 1; i <= 12; i++)
            {
                DataTable tabla = new DataTable();
                Reportes.RecuperarInfoReportesMensual(i, int.Parse(cbxAño.Text.Trim()), ref tabla);
                TotalTurnosCancelados = TotalTurnosCancelados + int.Parse(tabla.Rows[0]["Cancelados"].ToString());
                switch (i)
                {
                    case 1:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Enero", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                    case 2:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Febrero", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                    case 3:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Marzo", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                    case 4:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Abril", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                    case 5:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Mayo", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                    case 6:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Junio", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                    case 7:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Julio", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                    case 8:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Agosto", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                    case 9:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Septiembre", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                    case 10:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Octubre", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                    case 11:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Noviembre", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                    case 12:
                        this.chartTurnosCancelados.Series["Turnos Cancelados"].Points.AddXY("Diciembre", tabla.Rows[0]["Cancelados"].ToString());
                        break;
                }
            }
            lblTotalTurnosCancelados.Text = "Total Turnos Cancelados: " + TotalTurnosCancelados.ToString();
        }

        private void cbxAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartTurnosCancelados.Series["Turnos Cancelados"].Points.Clear();
            fillChart();
        }
    }
}
