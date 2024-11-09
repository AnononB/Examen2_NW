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
    public partial class frmLogin : Form
    {
        bool bandera = false;
        public frmLogin()
        {
            InitializeComponent();
            
        }
        public frmLogin(string nombre,string aPaterno, string aMaterno, string CURP, string fecha)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtApaterno.Text = aPaterno;
            txtAmaterno.Text = aMaterno;
            dtpFecha.Value = Convert.ToDateTime(fecha);
            msbCURP.Text = CURP;
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
            if(MessageBox.Show("¿Estoy seguro que mis datos ingresados son correctos" +
                "Y no me quejaré sí me equivoco?", "Sistema",
                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes) {

                if ()
                {

                }
        }
    }
}
