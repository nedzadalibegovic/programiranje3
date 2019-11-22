using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationLogin {
    public partial class frmRegistration : Form {
        public frmRegistration() {
            InitializeComponent();
            txtConfirm.Validating += txtConfirm_Validating;
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                User user = new User(txtFirst.Text, txtLast.Text, txtUsername.Text, txtPassword.Text);
                Database.Register(user);
                Close();
            }
        }

        private void textBox_Validating(object sender, CancelEventArgs e) {
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrEmpty(textBox.Text)) {
                errorProvider.SetError(textBox, "Field is required!");
                e.Cancel = true;
            } else {
                errorProvider.SetError(textBox, null);
            }
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e) {
            if (txtPassword.Text != txtConfirm.Text) {
                errorProvider.SetError(txtConfirm, "Passwords don't match!");
                e.Cancel = true;
            } else {
                errorProvider.SetError(txtConfirm, null);
            }
        }
    }
}
