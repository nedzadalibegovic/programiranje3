using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezbe_2019_11_09_wfa {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            Form login = new frmLogin();
            login.ShowDialog();
        }

        private void btnRegistracija_Click(object sender, EventArgs e) {
            Form registracija = new frmRegistracija();
            registracija.ShowDialog();
        }
    }
}
