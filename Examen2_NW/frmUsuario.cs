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
            frmMenu fm = new frmMenu();
            fm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //nada
        }
    }
}
