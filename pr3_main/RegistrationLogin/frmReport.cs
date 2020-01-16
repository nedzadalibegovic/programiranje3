using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegistrationLogin {
    public partial class frmReport : Form {

        public frmReport() {
            InitializeComponent();
        }

        public frmReport(User user, string path = "rptUserCard.rdlc") : this() {
            reportViewer.LocalReport.ReportPath = path;

            var dsUser = new ReportDataSource();
            var dsRoles = new ReportDataSource();

            dsUser.Name = "User";
            dsUser.Value = new List<User>() { user };

            dsRoles.Name = "Roles";
            dsRoles.Value = user.Roles;

            reportViewer.LocalReport.DataSources.Add(dsUser);
            reportViewer.LocalReport.DataSources.Add(dsRoles);
        }

        private void frmReport_Load(object sender, EventArgs e) {
            reportViewer.RefreshReport();
        }
    }
}
