using System;
using System.Drawing;
using System.Windows.Forms;
using ExplosionDanger.BLL;

namespace ExplosionDanger.WinForm
{
    public partial class q : Form
    {
        ThermalRadiationIntensity calculation = new ThermalRadiationIntensity();
        public q()
        {
            InitializeComponent();

            grpbx_ош.Enabled = false;
            btn_calculate.Enabled = false;
        }

        // фильтр ввода данных
        private void txbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод только цифр
            double result;
            if (double.TryParse(e.KeyChar.ToString(), out result)
                || e.KeyChar == 8   // клавиша backspace
                || e.KeyChar == 44  // запятая
                || e.KeyChar == 46) // точка
                e.Handled = false;
            else
                e.Handled = true;

            // заменяет "." на ","
            if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        // деактивирует кнопку если поля не заполнены
        private void txbx_Leave(object sender, EventArgs e)
        {
            if (rbtn_лвж.Checked)
            {
                if (txbx_EfЛвж.Text.Trim() == "" ||
                      txbx_F.Text.Trim() == "" ||
                      txbx_Mv.Text.Trim() == "" ||
                      txbx_Pв.Text.Trim() == "" ||
                      txbx_rЛвж.Text.Trim() == "")
                {
                    btn_calculate.Enabled = false;
                    lbl_warning.ForeColor = Color.Red;
                    lbl_warning.Text = "Не все данные\n заполнены!!!";
                }
                else
                {
                    btn_calculate.Enabled = true;
                    lbl_warning.Text = "";
                }
            }
            else
            {
                if (txbx_EfОш.Text.Trim() == "" ||
                      txbx_m.Text.Trim() == "" ||
                      txbx_rОш.Text.Trim() == "")
                {
                    btn_calculate.Enabled = false;
                    lbl_warning.ForeColor = Color.Red;
                    lbl_warning.Text = "Не все данные\n заполнены!!!";
                }
                else
                {
                    btn_calculate.Enabled = true;
                    lbl_warning.Text = "";
                }
            }
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_лвж.Checked)
            {
                grpbx_лвж.Enabled = true;
                grpbx_ош.Enabled = false;
                txbx_EfОш.Text = "";
                txbx_m.Text = "";
                txbx_rОш.Text = "";
            }
            else
            {
                grpbx_лвж.Enabled = false;
                grpbx_ош.Enabled = true;
                txbx_EfЛвж.Text = "";
                txbx_F.Text = "";
                txbx_Mv.Text = "";
                txbx_Pв.Text = "";
                txbx_rЛвж.Text = "";
                txbx_EfОш.Text = "450";
            }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            calculation.лвжFlag = rbtn_лвж.Checked;
            calculation.Ef = (rbtn_лвж.Checked) ? double.Parse(txbx_EfЛвж.Text.Trim()) : double.Parse(txbx_EfОш.Text.Trim());
            calculation.F = (txbx_F.Text.Trim() != "") ? double.Parse(txbx_F.Text.Trim()) : 0;
            calculation.Mv = (txbx_Mv.Text.Trim() != "") ? double.Parse(txbx_Mv.Text.Trim()) : 0;
            calculation.Pв = (txbx_Pв.Text.Trim() != "") ? double.Parse(txbx_Pв.Text.Trim()) : 0;
            calculation.r = (rbtn_лвж.Checked) ? double.Parse(txbx_rЛвж.Text.Trim()) : double.Parse(txbx_rОш.Text.Trim());
            calculation.m = (txbx_m.Text.Trim() != "") ? double.Parse(txbx_m.Text.Trim()) : 0;

            txbx_result.Text = calculation.q().ToString();
        }
    }
}
