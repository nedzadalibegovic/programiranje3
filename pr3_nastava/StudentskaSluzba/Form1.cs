using System;
using System.Windows.Forms;

namespace StudentskaSluzba {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e) {
            frmRegistracija frm = new frmRegistracija();
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
