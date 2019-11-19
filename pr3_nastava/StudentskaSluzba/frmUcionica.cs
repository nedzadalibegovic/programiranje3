using System;
using System.Windows.Forms;

namespace StudentskaSluzba {
    public partial class frmUcionica : Form {
        public frmUcionica() {
            InitializeComponent();

            Baza.OnUcionicaSnimljen += Baza_OnUcionicaSnimljen;
        }

        private void Baza_OnUcionicaSnimljen(Ucionica obj) {
            MessageBox.Show($"Ucionica {obj.Naziv} snimljena!");
        }

        private void btnSend_Click(object sender, EventArgs e) {
            Ucionica ucionica = new Ucionica() { Naziv = txtNaziv.Text, Zauzeto = chkZauzeto.Checked };

            Baza.SnimiUcionicu(ucionica);

            Close();
        }
    }
}
