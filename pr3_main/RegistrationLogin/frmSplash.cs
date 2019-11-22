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
    public partial class frmSplash : Form {
        public frmSplash() {
            InitializeComponent();
            timerClose.Start();
        }

        private void frmSplash_Load(object sender, EventArgs e) {
            Opacity = 0;

            timerFade.Tick += new EventHandler(fadeIn);
            timerFade.Start();
        }


        private void frmSplash_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;

            timerFade.Tick += new EventHandler(fadeOut);
            timerFade.Start();

            if (Opacity == 0) {
                e.Cancel = false;
            }
        }

        void fadeIn(object sender, EventArgs e) {
            if (Opacity >= 1) {
                timerFade.Stop();
                timerFade.Tick -= fadeIn;
            } else {
                Opacity += 0.05;
            }
        }

        void fadeOut(object sender, EventArgs e) {
            if (Opacity <= 0) {
                timerFade.Stop();
                Close();
            } else {
                Opacity -= 0.05;
            }
        }

        private void timerClose_Tick(object sender, EventArgs e) {
            timerClose.Stop();
            Close();
        }
    }
}
