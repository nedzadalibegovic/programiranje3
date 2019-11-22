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
            if (ValidateChildren() && ValidatePicture()) {
                User user = new User(txtFirst.Text, txtLast.Text, txtUsername.Text, txtPassword.Text, picImage.Image);
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

        private void btnLoadImage_Click(object sender, EventArgs e) {
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                picImage.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private bool ValidatePicture() {
            if (picImage.Image == null) {
                errorProvider.SetError(picImage, "Image required!");
            } else {
                errorProvider.SetError(picImage, null);
            }

            return picImage.Image != null;
        }
    }
}
