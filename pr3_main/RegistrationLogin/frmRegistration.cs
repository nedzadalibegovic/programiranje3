using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RegistrationLogin {
    public partial class frmRegistration : Form {
        public User SentUser { get; set; }

        public frmRegistration(User sentUser = null) {
            InitializeComponent();

            clbRoles.DataSource = Database.Roles;

            SentUser = sentUser;
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                var roles = clbRoles.CheckedItems.Cast<Role>().ToList();

                if (SentUser == null) {
                    Database.Register(txtFirst.Text, txtLast.Text, txtUsername.Text, txtPassword.Text, User.ImageToByteArray(picImage.Image), roles);
                } else {
                    SentUser.Update(SentUser.ID, txtFirst.Text, txtLast.Text, txtUsername.Text, txtPassword.Text, User.ImageToByteArray(picImage.Image), roles);
                    Database.Update(SentUser.ID, SentUser);
                }

                Close();
            }
        }

        public override bool ValidateChildren() {
            List<TextBox> textBoxes = Controls.OfType<TextBox>().ToList();
            bool txtAll = true, txtPass = true, pbImg = true;

            if (textBoxes.Count(x => string.IsNullOrEmpty(x.Text)) > 0) {
                textBoxes.FindAll(x => string.IsNullOrEmpty(x.Text)).ForEach(x => errorProvider.SetError(x, "Field required!"));
                txtAll = false;
            } else {
                textBoxes.FindAll(x => !string.IsNullOrEmpty(x.Text)).ForEach(x => errorProvider.SetError(x, null));
            }

            if (txtPassword.Text != txtConfirm.Text) {
                errorProvider.SetError(txtConfirm, "Passwords don't match!");
                txtPass = false;
            } else {
                errorProvider.SetError(txtConfirm, null);
            }

            if (picImage.Image == null) {
                errorProvider.SetError(picImage, "Image required!");
                pbImg = false;
            } else {
                errorProvider.SetError(picImage, null);
            }

            return txtAll && txtPass && pbImg;
        }

        private void btnLoadImage_Click(object sender, EventArgs e) {
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                picImage.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void frmRegistration_Load(object sender, EventArgs e) {
            txtFirst.Text = SentUser?.FirstName;
            txtLast.Text = SentUser?.LastName;
            txtUsername.Text = SentUser?.Username;
            txtPassword.Text = SentUser?.Password;
            picImage.Image = User.ByteArrayToImage(SentUser?.AccountPicture);

            for (int i = 0; i < clbRoles.Items.Count; i++) {
                var role = clbRoles.Items[i] as Role;

                if (SentUser?.Roles?.Find(x => x.ID == role.ID) != null) {
                    clbRoles.SetItemChecked(i, true);
                }
            }
        }
    }
}
