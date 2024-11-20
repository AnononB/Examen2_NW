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
        Datos datos = new Datos(); // Instancia de clase Datos

        public frmAdmin()
        {
            InitializeComponent();
            LoadTableNames(); // Cargar nombres de las tablas al inicializar el formulario
        }

        public frmAdmin(string usuario, string contraseña)
        {
            InitializeComponent();
            //txtUsuario.Text = usuario;
            //txtPassword.Text = contraseña;
            bandera = true;
            LoadTableNames(); // Cargar nombres de las tablas al inicializar el formulario
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
                LoadData(selectedTable); // Llama a LoadData con el nombre de la tabla seleccionada
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tabla.");
            }
        }

        private void LoadTableNames()
        {
            // Lista de nombres de las tablas
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

            // Poblar el ComboBox con los nombres de las tablas
            comboBox1.Items.AddRange(tableNames.ToArray());
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
