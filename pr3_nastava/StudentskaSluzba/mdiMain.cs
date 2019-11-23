using System;
using System.Windows.Forms;

namespace StudentskaSluzba {
    public partial class mdiMain : Form {
        private int childFormNumber = 0;

        public mdiMain() {
            InitializeComponent();
        }

        private void registracijaToolStripMenuItem_Click(object sender, EventArgs e) {
            frmRegistracija frm = new frmRegistracija();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void ucionicaToolStripMenuItem_Click(object sender, EventArgs e) {
            frmUcionica frm = new frmUcionica();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e) {
            frmKorisnici frm = new frmKorisnici();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
