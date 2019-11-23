using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskaSluzba {
    public partial class frmKorisnici : Form {

        public frmKorisnici() {
            InitializeComponent();
            dgwKorisnici.AutoGenerateColumns = false;
            //dgwKorisnici_Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            dgwKorisnici_Refresh();
        }

        private void dgwKorisnici_Refresh() {
            dgwKorisnici.DataSource = null;
            dgwKorisnici.DataSource = Baza.Korisnici;
        }

        private void frmKorisnici_Load(object sender, EventArgs e) {
            dgwKorisnici_Refresh();
        }

        private void dgwKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            var selected = dgwKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            frmRegistracija frm = new frmRegistracija(selected);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
