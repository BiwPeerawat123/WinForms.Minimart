using System.Windows.Forms;

namespace WinForms.Minimart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void จดการขอมลหมวดหมสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.MdiParent = this;
            frm.Show();
        }

        private void จดการขอมลพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployees frm = new frmEmployees();
            frm.MdiParent = this;
            frm.Show();
        }

        private void จดการขอมลสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
