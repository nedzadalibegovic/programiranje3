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
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                User user = new User(txtFirst.Text, txtLast.Text, txtUsername.Text, txtPassword.Text, User.ImageToByteArray(picImage.Image));
                Database.Register(user);
                Close();
            }
        }

        public override bool ValidateChildren() {
            List<TextBox> textBoxes = Controls.OfType<TextBox>().ToList();

            if (textBoxes.Count(x => string.IsNullOrEmpty(x.Text)) > 0) {
                textBoxes.FindAll(x => string.IsNullOrEmpty(x.Text)).ForEach(x => errorProvider.SetError(x, "Field required!"));
                textBoxes.FindAll(x => !string.IsNullOrEmpty(x.Text)).ForEach(x => errorProvider.SetError(x, null));
                return false;
            } else {
                textBoxes.FindAll(x => !string.IsNullOrEmpty(x.Text)).ForEach(x => errorProvider.SetError(x, null));
            }

            if (txtPassword.Text != txtConfirm.Text) {
                errorProvider.SetError(txtConfirm, "Passwords don't match!");
                return false;
            } else {
                errorProvider.SetError(txtConfirm, null);
            }

            if (picImage.Image == null) {
                errorProvider.SetError(picImage, "Image required!");
                return false;
            } else {
                errorProvider.SetError(picImage, null);
            }

            errorProvider.Clear();
            return true;
        }

        private void btnLoadImage_Click(object sender, EventArgs e) {
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                picImage.Image = Image.FromFile(fileDialog.FileName);
            }
        }
    }
}
