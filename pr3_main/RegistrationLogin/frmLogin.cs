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

        private void textBox_Validating(object sender, CancelEventArgs e) {
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrEmpty(textBox.Text)) {
                errorProvider.SetError(textBox, "Field is required!");
                e.Cancel = true;
            } else {
                errorProvider.SetError(textBox, null);
            }
        }
    }
}
