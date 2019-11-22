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

            dgwUsers.DataSource = Database.Users;
            dgwUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Database_UserRegistered(User obj) {
            DGW_Rerfresh(Database.Users);
        }

        private void DGW_Rerfresh(List<User> list) {
            dgwUsers.DataSource = null;
            dgwUsers.DataSource = list;
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
            //form.MdiParent = this;
            form.ShowDialog();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e) {
            frmRegistration form = new frmRegistration();
            //form.MdiParent = this;
            form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            DGW_Rerfresh(Database.QueryString(txtSearch.Text));
        }
    }
}
