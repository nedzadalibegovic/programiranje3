using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationLogin {
    public partial class mdiMain : Form {
        public mdiMain() {
            ShowSplashScreen();
            InitializeComponent();

            Database.UserLoggedIn += Database_UserLoggedIn;

            dgvUsers.DataSource = Database.Users;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.Columns.OfType<DataGridViewImageColumn>().ToList().ForEach(column => column.ImageLayout = DataGridViewImageCellLayout.Zoom);

            TopMost = true;
            Load += (object sender, EventArgs e) => { TopMost = false; };
        }

        private async void ShowSplashScreen() {
            await Task.Run(() => {
                using (var splash = new frmSplash()) {
                    splash.ShowDialog();
                }
            });
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
            Database.Query(txtSearch.Text);
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
