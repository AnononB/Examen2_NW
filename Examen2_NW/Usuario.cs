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
        public frmUsuario()
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
            frmMenu fm = new frmMenu();
            fm.Show();
        }
    }
}
