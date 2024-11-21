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
    public partial class frmAdmin : Form
    {
        bool bandera = false;
        Datos datos = new Datos(); 

        public frmAdmin()
        {
            InitializeComponent();
            LoadTableNames(); 
        }

        public frmAdmin(string usuario, string contraseña)
        {
            InitializeComponent();
            //txtUsuario.Text = usuario;
            //txtPassword.Text = contraseña;
            bandera = true;
            LoadTableNames(); 
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.Show();
        }

        private void btnCrear1_Click(object sender, EventArgs e)
        {
            /* if(MessageBox.Show("¿Estoy seguro que mis datos ingresados son correctos" +
            /* if(MessageBox.Show("¿Estoy seguro que mis datos ingresados son correctos" +
                 "Y no me quejaré sí me equivoco?", "Sistema",
                 MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes) {

                 if ()
                 {

                 }*/
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void butMostrar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedTable = comboBox1.SelectedItem.ToString();
                LoadData(selectedTable); 
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tabla.");
            }
        }

        private void LoadTableNames()
        {
            
            List<string> tableNames = new List<string>
            {
                "Categories",
                "CustomerCustomerDemo",
                "CustomerDemographics",
                "Customers",
                "Employees",
                "EmployeeTerritories",
                "loginNW",
                "Order Details",
                "Orders",
                "Products",
                "Region",
                "roles",
                "Shippers",
                "Suppliers",
                "Territories"
            };

           
            comboBox1.Items.AddRange(tableNames.ToArray());
        }

        private void LoadData(string tableName)
        {
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            dataGridView1.ReadOnly = false;

            if (e.RowIndex >= 0)
            {
                
                string selectedTable = comboBox1.SelectedItem.ToString();
                
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name; 
                object newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                
                object primaryKeyValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value; 
                
                string updateQuery = $"UPDATE {selectedTable} SET {columnName} = @newValue WHERE " +
                    $"{dataGridView1.Columns[0].Name} = @primaryKeyValue"; 

                datos.actualiza(updateQuery, newValue, primaryKeyValue);
            }



        }

        private void butAgregar_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                object primaryKeyValue = dataGridView1.Rows[selectedIndex].Cells[0].Value;
                string selectedTable = comboBox1.SelectedItem.ToString();

                string deleteQuery = $"DELETE FROM {selectedTable} WHERE {dataGridView1.Columns[0].Name} = @primaryKeyValue";
                try
                {
                    datos.eliminar(deleteQuery, primaryKeyValue);
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show("ELIMINADO CON ÉXITOO");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("ERROR AL ELIMINAR, INTENTE DENUEVO");

                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
            



        }
    }
}
