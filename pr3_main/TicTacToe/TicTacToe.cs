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

        public delegate void WinnerHandler(string Winner);
        public static event WinnerHandler OnWin;

        public TicTacToe() {
            InitializeComponent();
            NumberOfMoves = 0;

            OnWin += TicTacToe_OnWin;
        }

        private void TicTacToe_OnWin(string Winner) {
            MessageBox.Show(Winner);
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

            if (CheckWin()) {
                if ((NumberOfMoves - 1) % 2 == 0) {
                    OnWin("X wins!");
                } else {
                    OnWin("O wins!");
                }

                Reset();
            }
        }

        private bool CheckWin() {
            // 1st row
            if (CheckSeq(button1, button2, button3)) {
                MarkSeq(button1, button2, button3);
                return true;
            }

            // 2nd row
            if (CheckSeq(button4, button5, button6)) {
                MarkSeq(button4, button5, button6);
                return true;
            }

            // 3rd row
            if (CheckSeq(button7, button8, button9)) {
                MarkSeq(button7, button8, button9);
                return true;
            }

            // main diagonal
            if (CheckSeq(button3, button5, button7)) {
                MarkSeq(button3, button5, button7);
                return true;
            }

            // other diagonal
            if (CheckSeq(button1, button5, button9)) {
                MarkSeq(button1, button5, button9);
                return true;
            }

            // 1st column
            if (CheckSeq(button1, button4, button7)) {
                MarkSeq(button1, button4, button7);
                return true;
            }

            // 2nd column
            if (CheckSeq(button2, button5, button8)) {
                MarkSeq(button2, button5, button8);
                return true;
            }

            // 3rd column
            if (CheckSeq(button3, button6, button9)) {
                MarkSeq(button3, button6, button9);
                return true;
            }

            if (NumberOfMoves == 9) {
                MessageBox.Show("It's a draw!");
                Reset();
            }

            return false;
        }

        private bool CheckSeq(Button button1, Button button2, Button button3) {
            if (string.IsNullOrEmpty(button1.Text) || string.IsNullOrEmpty(button2.Text) || string.IsNullOrEmpty(button3.Text)) {
                return false;
            }

            if (button1.Text == button2.Text && button2.Text == button3.Text) {
                return true;
            }

            return false;
        }

        private void MarkSeq(params Button[] list) {
            foreach (var button in list) {
                button.ForeColor = Color.Red;
            }
        }

        private void Reset() {
            foreach (var button in Controls.OfType<Button>()) {
                button.Text = "";
                button.ForeColor = Color.Black;
            }

            NumberOfMoves = 0;
        }
    }
}
