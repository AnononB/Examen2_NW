using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_NW
{
    public partial class frmDirector : Form
    {
        Datos datos = new Datos(); // Instancia de tu clase Datos

        public frmDirector()
        {
            InitializeComponent();
            LoadTableNames(); // Cargar nombres de las tablas relevantes al inicializar el formulario
        }

        private void LoadTableNames()
        {
            // Lista de nombres de las tablas relevantes
            List<string> tableNames = new List<string>
            {
                "Customers",
                "Employees",
                "Orders",
                "Products",
                "Suppliers"
            };

            // Poblar el ComboBox con los nombres de las tablas
            comboBox1.Items.AddRange(tableNames.ToArray());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes manejar los eventos de clic en las celdas aquí si es necesario
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Opcional: puedes manejar el evento de cambio de selección si necesitas hacer algo al cambiar la tabla seleccionada
        }

        private void butMostrar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedTable = comboBox1.SelectedItem.ToString();
                LoadData(selectedTable); // Llama a LoadData con el nombre de la tabla seleccionada
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tabla.");
            }
        }

        private void LoadData(string tableName)
        {
            // Consulta SQL para seleccionar los datos de la tabla especificada
            DataSet ds = datos.consulta($"SELECT * FROM {tableName}");
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0]; // Asignar el DataSet al DataGridView
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }
    }
}
