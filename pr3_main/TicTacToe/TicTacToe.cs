using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe {
    public partial class TicTacToe : Form {
        public int NumberOfMoves { get; set; }

        public TicTacToe() {
            InitializeComponent();
            NumberOfMoves = 0;
        }

        private void markMove(object sender, EventArgs e) {
            Button button = sender as Button;

            // check that field is not marked
            if (!string.IsNullOrEmpty(button.Text)) {
                return;
            }

            if (NumberOfMoves % 2 == 0) {
                button.Text = "X";
            } else {
                button.Text = "O";
            }

            NumberOfMoves++;
        }
    }
}
