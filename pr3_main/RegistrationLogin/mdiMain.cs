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
    public partial class mdiMain : Form {
        private int childFormNumber = 0;

        public mdiMain() {
            InitializeComponent();

            frmSplash splash = new frmSplash();
            splash.ShowDialog();

            Database.UserLoggedIn += Database_UserLoggedIn;
            Database.UserRegistered += Database_UserRegistered;
            Database.UserUpdated += Database_UserRegistered;

            dgwUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DGW_Rerfresh(Database.Users);
        }

        private void Database_UserRegistered(User obj) {
            DGW_Rerfresh(Database.Users);
        }

        private void DGW_Rerfresh(List<User> list) {
            dgwUsers.DataSource = null;
            dgwUsers.DataSource = list;

            var imageColumns = dgwUsers.Columns.OfType<DataGridViewImageColumn>().ToList();
            imageColumns.ForEach(column => column.ImageLayout = DataGridViewImageCellLayout.Zoom);
        }

        private void Database_UserLoggedIn(User obj) {
            Text = $"{obj.FirstName} ({obj.Username}) {obj.LastName}";
        }

        private void ShowNewForm(object sender, EventArgs e) {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e) {
            frmLogin form = new frmLogin();
            form.ShowDialog();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e) {
            frmRegistration form = new frmRegistration();
            form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            DGW_Rerfresh(Database.QueryString(txtSearch.Text));
        }

        private void dgwUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            using (frmRegistration frm = new frmRegistration(dgwUsers.SelectedRows[0].DataBoundItem as User)) {
                frm.ShowDialog();
            }
        }
    }
}
