using System;
using System.Windows.Forms;

namespace StudentskaSluzba {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            var isValid = Baza.Login(txtUsername.Text, txtPassword.Text);

            if (isValid) {
                this.Close();
            } else {
                MessageBox.Show("Korisnicko ime ili password nisu ispravni");
            }
        }
    }
}
