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
    public partial class frmADatos : Form
    {
        private string selectedTable;
        private Datos datos;

        public frmADatos(string selectedTable)
        {
            InitializeComponent();
            this.selectedTable = selectedTable;
            this.datos = new Datos();
            InicializarDataGridView();
        }

        private void InicializarDataGridView()
        {
            DataSet ds = datos.consulta($"SELECT * FROM {selectedTable} WHERE 1 = 0");
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridViewAgregar.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron columnas.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dataGridViewAgregar.EndEdit();

            List<string> columns = new List<string>();
            List<object> values = new List<object>();

            foreach (DataGridViewColumn column in dataGridViewAgregar.Columns)
            {
                columns.Add(column.Name);
            }

            foreach (DataGridViewRow row in dataGridViewAgregar.Rows)
            {
                if (row.IsNewRow) continue;

                values.Clear();
                foreach (DataGridViewColumn column in dataGridViewAgregar.Columns)
                {
                    values.Add(row.Cells[column.Name].Value ?? DBNull.Value);
                }

                datos.insertarDinamico(selectedTable, columns, values);
            }

            MessageBox.Show("Datos agregados correctamente.");

            // Refrescar el DataGridView original en frmAdmin
            ((frmAdmin)this.Owner).ReloadData();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

