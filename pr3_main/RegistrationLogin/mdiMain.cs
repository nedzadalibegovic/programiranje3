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

            dgwUsers.DataSource = Database.Users;
            dgwUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwUsers.Columns.OfType<DataGridViewImageColumn>().ToList().ForEach(column => column.ImageLayout = DataGridViewImageCellLayout.Zoom);
        }

        private void DGV_Refresh(User _) {
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
                dgwUsers.DataSource = Database.Users;
            } else {
                dgwUsers.DataSource = Database.QueryString(txtSearch.Text);
            }
        }

        private void dgwUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) {
                return;
            }

            using (frmRegistration frm = new frmRegistration(dgwUsers.SelectedRows[0].DataBoundItem as User)) {
                frm.ShowDialog();
            }
        }
    }
}
