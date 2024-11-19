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
    public partial class frmAlta : Form
    {
        bool bandera = false;
        public frmAlta()
        {
            InitializeComponent();

        }
        public frmAlta(string usuario, string contraseña)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
            txtPassword.Text = contraseña;
            bandera = true;
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
    }
}
