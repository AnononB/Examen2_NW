using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examen2_NW
{
    public partial class frmAdmin : Form
    {
        bool bandera = false;
        Datos datos = new Datos(); 

        public frmAdmin()
        {
            
                InitializeComponent();
                LoadTableNames(); // Cargar nombres de las tablas al inicializar el formulario
                dataGridView1.AllowUserToAddRows = true; // Permitir la adición de nuevas filas
                dataGridView1.RowValidating += dataGridView1_RowValidating; // Suscribir el evento RowValidating
                dataGridView1.CellValueChanged += dataGridView1_CellValueChanged; // Suscribir el evento CellValueChanged
            

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

                // Crear la consulta de actualización
                string updateQuery = $"UPDATE {selectedTable} SET {columnName} = @newValue WHERE {dataGridView1.Columns[0].Name} = @primaryKeyValue";

                // Crear una lista de valores para pasar a la consulta
                List<object> values = new List<object> { newValue, primaryKeyValue };

                // Crear una lista de nombres de parámetros
                List<string> parameterNames = new List<string> { "@newValue", "@primaryKeyValue" };

                datos.actualiza(updateQuery, values, parameterNames); // Pasar la lista de valores y nombres de parámetros
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedTable = comboBox1.SelectedItem.ToString();
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                object newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                object primaryKeyValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                if (newValue != null && !string.IsNullOrWhiteSpace(newValue.ToString()))
                {
                    // Crear la consulta de actualización
                    string updateQuery = $"UPDATE {selectedTable} SET {columnName} = @newValue WHERE {dataGridView1.Columns[0].Name} = @primaryKeyValue";

                    // Crear una lista de valores para pasar a la consulta
                    List<object> values = new List<object> { newValue, primaryKeyValue };

                    // Crear una lista de nombres de parámetros
                    List<string> parameterNames = new List<string> { "@newValue", "@primaryKeyValue" };

                    datos.actualiza(updateQuery, values, parameterNames); // Pasar la lista de valores y nombres de parámetros
                }
            }
        }










        // Método para obtener el nombre de la columna de clave primaria
        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.IsCurrentRowDirty)
            {
                this.BeginInvoke(new Action(() =>
                {
                    dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;

                    var newRow = dataGridView1.Rows[e.RowIndex];
                    string selectedTable = comboBox1.SelectedItem.ToString();

                    // Obtén el nombre de la columna de clave primaria de la tabla seleccionada
                    string primaryKeyColumn = ObtenerNombreClavePrimaria(selectedTable);
                    if (primaryKeyColumn == null)
                    {
                        MessageBox.Show($"No se pudo encontrar la columna de clave primaria en la tabla {selectedTable}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        return;
                    }

                    List<string> columns = new List<string>();
                    List<object> values = new List<object>();

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        columns.Add(column.Name);
                        values.Add(newRow.Cells[column.Name].Value ?? DBNull.Value);
                    }

                    try
                    {
                        bool isUpdating = newRow.Cells[primaryKeyColumn].Value != DBNull.Value;
                        if (isUpdating)
                        {
                            List<string> updateColumns = new List<string>();
                            List<object> updateValues = new List<object>();
                            for (int i = 0; i < columns.Count; i++)
                            {
                                if (columns[i] != primaryKeyColumn)
                                {
                                    updateColumns.Add(columns[i]);
                                    updateValues.Add(values[i]);
                                }
                            }

                            string updateColumnsQuery = string.Join(", ", updateColumns.Select((c, index) => $"{c} = @p{index}"));
                            string updateQuery = $"UPDATE {selectedTable} SET {updateColumnsQuery} WHERE {primaryKeyColumn} = @p{updateColumns.Count}";

                            updateValues.Add(newRow.Cells[primaryKeyColumn].Value);

                            List<string> parameterNames = updateColumns.Select((c, index) => $"@p{index}").ToList();
                            parameterNames.Add($"@p{updateColumns.Count}");

                            datos.actualiza(updateQuery, updateValues, parameterNames);
                        }
                        else
                        {
                            datos.insertarDinamicoConIdentityInsert(selectedTable, columns, values);
                        }

                        LoadData(selectedTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al procesar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    finally
                    {
                        dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                    }
                }));
            }
        }

        // Método para obtener el nombre de la columna de clave primaria
        private string ObtenerNombreClavePrimaria(string tableName)
        {
            switch (tableName)
            {
                case "Employees":
                    return "EmployeeID";
                case "Customers":
                    return "CustomerID";
                case "Categories":
                    return "CategoryID";
                // Añade más condiciones según sea necesario para otras tablas
                default:
                    return null;
            }
        }













    }



}
