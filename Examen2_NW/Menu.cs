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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin fa = new frmAdmin();
            fa.Show();
        }

        private void directorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDirector fd = new frmDirector();
            fd.Show();
        }

        private void subdirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubdirector fsd = new frmSubdirector();
            fsd.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.Show();
        }
    }
}
