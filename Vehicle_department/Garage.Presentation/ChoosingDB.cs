using System;
using System.Windows.Forms;

namespace Garage.Presentation
{
    public partial class ChoosingDB : Form
    {
        public ChoosingDB()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(rbtn_LiteDB.Checked, rbtn_mySQL.Checked);
            main.ShowDialog();
        }
    }
}
