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
    public partial class frmInfoImportes : Form
    {
        public frmInfoImportes()
        {
            InitializeComponent();
        }
        private void fillChart()
        {
            //PROCESO DE CARGA DEL CHART
            int TotalRecaudado;
            TotalRecaudado = 0;

            //NECESARIO PARA LLEVAR CUENTA TOTAL DE LOS IMPORTES 
            int aux = 0;

            //Necesario para que no oculte meses en el chart
            chartRecaudado.ChartAreas.FirstOrDefault().AxisX.Interval = 1;

            //Mostrar valor exacto de cada barra
            chartRecaudado.Series["Total Recaudado"].IsValueShownAsLabel = true;

            //Eliminar gridlines
            chartRecaudado.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartRecaudado.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

            //Hacer que el valor de las labels de barras tengan mejor visibilidad
            chartRecaudado.Series["Total Recaudado"].Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold);

            for (int i = 1; i <= 12; i++)
            {
                DataTable tabla = new DataTable();
                Reportes.RecuperarInfoReportesMensual(i, int.Parse(cbxAño.Text.Trim()),Usuarios.idUsuarioLog, ref tabla);
                int.TryParse(tabla.Rows[0]["Recaudado"].ToString(), out aux);
                TotalRecaudado = TotalRecaudado + aux;
                switch (i)
                {
                    case 1:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Enero", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                    case 2:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Febrero", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                    case 3:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Marzo", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                    case 4:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Abril", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                    case 5:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Mayo", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                    case 6:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Junio", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                    case 7:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Julio", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                    case 8:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Agosto", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                    case 9:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Septiembre", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                    case 10:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Octubre", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                    case 11:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Noviembre", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                    case 12:
                        this.chartRecaudado.Series["Total Recaudado"].Points.AddXY("Diciembre", tabla.Rows[0]["Recaudado"].ToString());
                        break;
                }

            }
            lblTotalRecaudado.Text = "Total Recaudado: " + TotalRecaudado.ToString();
        }

        private void frmInfoImportes_Load(object sender, EventArgs e)
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
            chartRecaudado.Series["Total Recaudado"].Points.Clear();
            fillChart();
        }

        private void cbxAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartRecaudado.Series["Total Recaudado"].Points.Clear();
            fillChart();
        }
    }
}
