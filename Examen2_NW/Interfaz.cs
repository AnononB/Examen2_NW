namespace Examen2_NW
{
    public partial class frmMenuInicio : Form
    {
        public frmMenuInicio()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearToolStripMenuItem_Click(Object sender, EventArgs e)
        {

        }

        private void frmMenuInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNewCuenta fnw = new frmNewCuenta();
            fnw.Show();
        }
    }
}
