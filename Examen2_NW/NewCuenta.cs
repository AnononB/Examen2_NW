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
    public partial class frmNewCuenta : Form
    {
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
            frmUsuario fUs = new frmUsuario();
            fUs.Show();
        }
    }
}
