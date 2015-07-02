using System;
using System.Drawing;
using System.Windows.Forms;
using ExplosionDanger.BLL;

namespace ExplosionDanger.WinForm
{
    public partial class ΔРСombDust : Form
    {
        OverpressureCalculationCombDust calculation = new OverpressureCalculationCombDust();
        public ΔРСombDust()
        {
            InitializeComponent();

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
            if (txbx_Hт.Text.Trim() == "" ||
                txbx_Vсвоб.Text.Trim() == "" ||
                txbx_F.Text.Trim() == "" ||
                txbx_Pв.Text.Trim() == "" ||
                txbx_T0.Text.Trim() == "" ||
                txbx_Kвз.Text.Trim() == "" ||
                txbx_τ.Text.Trim() == "" ||
                txbx_q.Text.Trim() == "" ||
                txbx_mап.Text.Trim() == "" ||
                txbx_Kп.Text.Trim() == "" ||
                txbx_Kубор.Text.Trim() == "" ||
                txbx_Kг.Text.Trim() == "" ||
                txbx_n.Text.Trim() == "" ||
                txbx_β1.Text.Trim() == "" ||
                txbx_β2.Text.Trim() == "" ||
                txbx_M1j.Text.Trim() == "" ||
                txbx_M2j.Text.Trim() == "" ||
                txbx_α.Text.Trim() == "")
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

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            calculation.Hт = double.Parse(txbx_Hт.Text.Trim());
            calculation.Vсвоб = double.Parse(txbx_Vсвоб.Text.Trim());
            calculation.F = double.Parse(txbx_F.Text.Trim());
            calculation.Pв = double.Parse(txbx_Pв.Text.Trim());
            calculation.T0 = double.Parse(txbx_T0.Text.Trim());
            calculation.Kвз = double.Parse(txbx_Kвз.Text.Trim());
            calculation.τ = double.Parse(txbx_τ.Text.Trim());
            calculation.q = double.Parse(txbx_q.Text.Trim());
            calculation.mап = double.Parse(txbx_mап.Text.Trim());
            calculation.Kп = double.Parse(txbx_Kп.Text.Trim());
            calculation.Kубор = double.Parse(txbx_Kубор.Text.Trim());
            calculation.Kг = double.Parse(txbx_Kг.Text.Trim());
            calculation.n = double.Parse(txbx_n.Text.Trim());
            calculation.β1 = double.Parse(txbx_β1.Text.Trim());
            calculation.β2 = double.Parse(txbx_β2.Text.Trim());
            calculation.M1j = double.Parse(txbx_M1j.Text.Trim());
            calculation.M2j = double.Parse(txbx_M2j.Text.Trim());
            calculation.α = double.Parse(txbx_α.Text.Trim());

            txbx_result.Text = calculation.ΔP().ToString();
        }
    }
}
