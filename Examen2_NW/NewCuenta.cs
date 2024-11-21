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

namespace Examen2_NW
{
    public partial class frmNewCuenta : Form
    {
        Datos datos = new Datos();
        public frmNewCuenta()
        {
            InitializeComponent();
        }

        private void btnNWcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCrear_Click(object sender, EventArgs e)
        {
                           
            string nombre = txtAddNombre.Text;
            string usuario = txtAddUsuario.Text;
            string contraseña = txtAddContra.Text;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña) && !string.IsNullOrEmpty(nombre))
                {
                    
                    string query = "INSERT INTO Usuarios (Usuario, Contraseña, Nombre) VALUES (@usuario, @contraseña, @nombre)";
                    datos.insertar(query, usuario, contraseña, nombre);
                    MessageBox.Show("Usuario registrado con éxito!", "Registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmUsuario fUs = new frmUsuario();
                fUs.Show();
                this.Close();
            }
                else
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

        private void frmNewCuenta_Load(object sender, EventArgs e)
        {
            frmUsuario fUs = new frmUsuario();
            fUs.Show();
        }
    }
}
