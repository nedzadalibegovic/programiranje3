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
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                User user = Database.Login(txtUsername.Text, txtPassword.Text);

                if (user == null) {
                    MessageBox.Show("Incorrect username or password");

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                } else {
                    MessageBox.Show($"Welcome {user?.FirstName} {user?.LastName}!");
                    Close();
                }
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtUsername.Text)) {
                errorProvider.SetError(txtUsername, "Username field empty!");
                e.Cancel = true;
            } else {
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtPassword.Text)) {
                errorProvider.SetError(txtPassword, "Password field empty!");
                e.Cancel = true;
            } else {
                errorProvider.SetError(txtPassword, null);
            }
        }
    }
}
