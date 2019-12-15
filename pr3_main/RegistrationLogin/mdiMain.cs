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
        public mdiMain() {
            InitializeComponent();

            frmSplash splash = new frmSplash();
            splash.ShowDialog();

            Database.UserLoggedIn += Database_UserLoggedIn;
            Database.UserRegistered += DGV_Refresh;
            Database.UserUpdated += DGV_Refresh;

            dgvUsers.DataSource = Database.Users;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.Columns.OfType<DataGridViewImageColumn>().ToList().ForEach(column => column.ImageLayout = DataGridViewImageCellLayout.Zoom);
        }

        private void DGV_Refresh() {
            dgwUsers.DataSource = Database.Users;
        }

        private void Database_UserLoggedIn(User obj) {
            Text = $"{obj.FirstName} ({obj.Username}) {obj.LastName}";
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
            if (txtSearch.TextLength == 0) {
                dgvUsers.DataSource = Database.Users;
            } else {
                dgvUsers.DataSource = Database.Query(txtSearch.Text);
            }
        }

        private void dgwUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) {
                return;
            }

            var userID = (dgvUsers.SelectedRows[0].DataBoundItem as User).ID;

            if (Database.TryGetUser(userID, out User user)) {
                var frm = new frmRegistration(user);
                frm.ShowDialog();
            }
        }
    }
}
