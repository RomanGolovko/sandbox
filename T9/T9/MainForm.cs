using System;
using System.Windows.Forms;
using T9_Spelling.BLL;

namespace T9
{
    public partial class MainForm : Form
    {
        Replace replace = new Replace();
        public MainForm()
        {
            InitializeComponent();
        }

        private void txbx_result_KeyPress(object sender, KeyPressEventArgs e)
        {
            int result;
            // handle only numbers and control characters
            if (int.TryParse(e.KeyChar.ToString(), out result) ||   // numbers validation
                e.KeyChar == 32 ||                                  // break space button
                e.KeyChar == 8 ||                                   // back space button
                e.KeyChar == 71 ||                                  // home button
                e.KeyChar == 75 ||                                  // left button
                e.KeyChar == 77 ||                                  // right button
                e.KeyChar == 79)                                    // end button
                e.Handled = false;
            else
                e.Handled = true;

            // replaces the numbers on the letters
            switch (e.KeyChar)
            {
                case '2': 
                case '3': 
                case '4':
                case '5': 
                case '6': 
                case '7':
                case '8': 
                case '9': e.KeyChar = replace.ReplaceNumbers(e.KeyChar); break;
                case '0':
                    {
                        e.KeyChar = replace.ReplaceNumbers(e.KeyChar);
                        txbx_result.Text = replace.ReplaceLetters(txbx_result.Text);
                    } break;
                case ' ': txbx_result.Text = replace.ReplaceLetters(txbx_result.Text); break;
                default:
                    if (e.KeyChar != 8)
                        MessageBox.Show("Wrong key!\nUse only numbers from 2 to 9 (include 0), arrows (<- ->), back space or break space",
                        "T9 Spelling", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
            }
        }

        private void btn_2_Click(object sender, System.EventArgs e)
        {
            txbx_result.Text += 'A';
        }

        private void btn_3_Click(object sender, System.EventArgs e)
        {
            txbx_result.Text += 'D';
        }

        private void btn_4_Click(object sender, System.EventArgs e)
        {
            txbx_result.Text += 'G';
        }

        private void btn_5_Click(object sender, System.EventArgs e)
        {
            txbx_result.Text += 'J';
        }

        private void btn_6_Click(object sender, System.EventArgs e)
        {
            txbx_result.Text += 'M';
        }

        private void btn_7_Click(object sender, System.EventArgs e)
        {
            txbx_result.Text += 'P';
        }

        private void btn_8_Click(object sender, System.EventArgs e)
        {
            txbx_result.Text += 'T';
        }

        private void btn_9_Click(object sender, System.EventArgs e)
        {
            txbx_result.Text += 'W';
        }

        private void btn_0_Click(object sender, System.EventArgs e)
        {
            txbx_result.Text += ' ';
            txbx_result.Text = replace.ReplaceLetters(txbx_result.Text);
        }

        private void tutorialToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(
                @"Print your messages by pressing buttons or numbers, for example:
                press '2' to print 'A', 
                press '2' button two times to print 'B',
                press '2' button three times to print 'C', etc",
                "T9 Spelling", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Uri uri = new Uri("https://code.google.com/codejam/contest/dashboard?c=351101#s=p2");
            MessageBox.Show("Test task by condition " + uri + "fulfilled by Roman Golovko", 
                "T9 Spelling", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You realy wont to quit?", "T9 Spelling",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}