using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; 
namespace Examen2_NW
{
    public partial class FormGrafica : Form
    {
        private Datos datos = new Datos(); 

        public FormGrafica()
        {
            InitializeComponent();
        }

        private void butGrafica_Click(object sender, EventArgs e)
        {
            GenerarGraficaAltos();
        }

        private void butMedio_Click(object sender, EventArgs e)
        {
            GenerarGraficaMedios();
        }

        private void butBajo_Click(object sender, EventArgs e)
        {
            GenerarGraficaBajos();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void GenerarGraficaAltos()
        {
            // Crear el gráfico
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill
            };

            // Configurar el área del gráfico
            ChartArea chartArea = new ChartArea("AreaPrincipal");
            chart.ChartAreas.Add(chartArea);
            chartArea.AxisX.LabelStyle.Angle = -90; // Rotar etiquetas en el eje X
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.Title = "Productos";
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            chartArea.AxisY.Title = "Unidades en Stock";

            // Crear la serie de datos
            Series series = new Series("Unidades en Stock")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };

            try
            {
                // Consultar la base de datos y agregar puntos a la serie
                DataSet ds = datos.consulta("SELECT TOP 5 ProductName, UnitsInStock FROM Products ORDER BY UnitsInStock DESC");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        string nombreProducto = fila["ProductName"].ToString();
                        int unidadesStock = Convert.ToInt32(fila["UnitsInStock"]);

                        series.Points.AddXY(nombreProducto, unidadesStock);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos o el DataSet está vacío.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al consultar la base de datos: {ex.Message}");
            }

            // Configuración adicional del gráfico
            chart.Titles.Add("Unidades en Stock por Producto - Altos");
            series.Color = Color.Orange;
            series.IsValueShownAsLabel = true;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;

            chart.Series.Add(series);

            // Limpiar el panel y agregar el gráfico
            panel2.Controls.Clear();
            panel2.Controls.Add(chart);
        }

        private void GenerarGraficaMedios()
        {
            // Crear el gráfico
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill
            };

            // Configurar el área del gráfico
            ChartArea chartArea = new ChartArea("AreaPrincipal");
            chart.ChartAreas.Add(chartArea);
            chartArea.AxisX.LabelStyle.Angle = -90; // Rotar etiquetas en el eje X
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.Title = "Productos";
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            chartArea.AxisY.Title = "Unidades en Stock";

            // Crear la serie de datos
            Series series = new Series("Unidades en Stock")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };

            try
            {
                // Consultar la base de datos y agregar puntos a la serie
                DataSet ds = datos.consulta(@"WITH RankedProducts AS (
                                                SELECT ProductName, UnitsInStock, 
                                                NTILE(3) OVER (ORDER BY UnitsInStock) AS StockRank
                                                FROM Products
                                            )
                                            SELECT ProductName, UnitsInStock 
                                            FROM RankedProducts 
                                            WHERE StockRank = 2");

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        string nombreProducto = fila["ProductName"].ToString();
                        int unidadesStock = Convert.ToInt32(fila["UnitsInStock"]);

                        series.Points.AddXY(nombreProducto, unidadesStock);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos o el DataSet está vacío.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al consultar la base de datos: {ex.Message}");
            }

            // Configuración adicional del gráfico
            chart.Titles.Add("Unidades en Stock por Producto - Medios");
            series.Color = Color.Green;
            series.IsValueShownAsLabel = true;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;

            chart.Series.Add(series);

            // Limpiar el panel y agregar el gráfico
            panel2.Controls.Clear();
            panel2.Controls.Add(chart);
        }

        private void GenerarGraficaBajos()
        {
            // Crear el gráfico
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill
            };

            // Configurar el área del gráfico
            ChartArea chartArea = new ChartArea("AreaPrincipal");
            chart.ChartAreas.Add(chartArea);
            chartArea.AxisX.LabelStyle.Angle = -90; // Rotar etiquetas en el eje X
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.Title = "Productos";
            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            chartArea.AxisY.Title = "Unidades en Stock";

            // Crear la serie de datos
            Series series = new Series("Unidades en Stock")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };

            try
            {
                // Consultar la base de datos y agregar puntos a la serie
                DataSet ds = datos.consulta(@"WITH RankedProducts AS (
                                                SELECT ProductName, UnitsInStock, 
                                                NTILE(3) OVER (ORDER BY UnitsInStock) AS StockRank
                                                FROM Products
                                            )
                                            SELECT ProductName, UnitsInStock 
                                            FROM RankedProducts 
                                            WHERE StockRank = 1");

                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        string nombreProducto = fila["ProductName"].ToString();
                        int unidadesStock = Convert.ToInt32(fila["UnitsInStock"]);

                        series.Points.AddXY(nombreProducto, unidadesStock);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos o el DataSet está vacío.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al consultar la base de datos: {ex.Message}");
            }

            // Configuración adicional del gráfico
            chart.Titles.Add("Unidades en Stock por Producto - Bajos");
            series.Color = Color.Blue;
            series.IsValueShownAsLabel = true;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;

            chart.Series.Add(series);

            // Limpiar el panel y agregar el gráfico
            panel2.Controls.Clear();
            panel2.Controls.Add(chart);
        }
    }
}
