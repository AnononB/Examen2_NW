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
    public partial class frmUsuario : Form
    {
        bool palo = false;
        int ID; 
        Datos datos = new Datos();  

        public frmUsuario()
        {
            InitializeComponent();
        }

        public frmUsuario(String ID)
        {
            InitializeComponent();
        }


        private void linkLabCrear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNewCuenta fNW = new frmNewCuenta();
            fNW.Show();
            this.Close();
        }

        private void btnCancelar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
                string usuario = txtUsuario2.Text;
                string contraseña = txtContra2.Text;

                if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña))
                {
                    // Lógica para verificar el usuario y la contraseña en la base de datos
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña";
                    bool usuarioValido = datos.verificarUsuario(query, usuario, contraseña);

                    if (usuarioValido)
                    {
                        MessageBox.Show("Inicio de sesión exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Aquí puedes abrir el formulario principal de la aplicación
                    frmMenu fm = new frmMenu();
                    fm.Show();
                    this.Close();

                }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //nada
        }
    }
}
