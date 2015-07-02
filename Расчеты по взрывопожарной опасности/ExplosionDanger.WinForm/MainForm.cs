using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplosionDanger.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_ΔР_with_Click(object sender, EventArgs e)
        {
            ΔРWith ΔРwith = new ΔРWith();
            ΔРwith.ShowDialog();
        }

        private void btn_ΔР_withOut_Click(object sender, EventArgs e)
        {
            ΔРWithOut ΔРwithOut = new ΔРWithOut();
            ΔРwithOut.ShowDialog();
        }

        private void btn_ΔР_combustibleDust_Click(object sender, EventArgs e)
        {
            ΔРСombDust ΔРСombDust = new ΔРСombDust();
            ΔРСombDust.ShowDialog();
        }

        private void btn_fireLoad_Click(object sender, EventArgs e)
        {

        }

        private void btn_q_Click(object sender, EventArgs e)
        {

        }
    }
}
