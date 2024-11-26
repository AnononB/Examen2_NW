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
    public partial class frmCliente : Form
    {
        Datos datos = new Datos(); 

        public frmCliente()
        {
            InitializeComponent();
            LoadTableNames(); 
        }

        private void LoadTableNames()
        {
           
            List<string> tableNames = new List<string>
            {
                "Customers",
                "Orders",
                "Products"
            };

            comboBox1.Items.AddRange(tableNames.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Opcional: puedes manejar el evento de cambio de selección si necesitas hacer algo al cambiar la tabla seleccionada
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes manejar los eventos de clic en las celdas aquí si es necesario
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

        private void LoadData(string tableName, int limit = 5)
        {
            // Consulta SQL para seleccionar los datos limitados a una cantidad especificada
            DataSet ds = datos.consulta($"SELECT TOP {limit} * FROM {tableName}");
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0]; // Asignar el DataSet al DataGridView
            }
            else
            {
                MessageBox.Show("No se encontraron datos.");
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
