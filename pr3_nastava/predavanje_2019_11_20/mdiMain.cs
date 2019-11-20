using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace predavanje_2019_11_20 {
    public partial class mdiMain : Form {
        public mdiMain() {
            InitializeComponent();
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e) {
            KorisniciAdmin ka = new KorisniciAdmin();
            ka.MdiParent = this;
            ka.Show();
        }
    }
}
