using System;
using System.Drawing;
using System.Windows.Forms;
using ExplosionDanger.BLL;

namespace ExplosionDanger.WinForm
{
    public partial class ΔРWith : Form
    {
        private OverpressureCalculationWith calculation = new OverpressureCalculationWith();
        public ΔРWith()
        {
            InitializeComponent();

            grpbx_ЛВЖ.Enabled = false;
            btn_calculate.Enabled = false;
        }
        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_ГГ.Checked == true)
            {
                grpbx_ГГ.Enabled = true;
                grpbx_ЛВЖ.Enabled = false;
            }
            else
            {
                grpbx_ГГ.Enabled = false;
                grpbx_ЛВЖ.Enabled = true;
            }
        }

        private void txbx_W_KeyUp(object sender, KeyEventArgs e)
        {
            if (txbx_W.Text.Trim() != "")
            {
                txbx_η.Text = "";
                txbx_Pн.Enabled = false;
                txbx_η.Enabled = false;
                txbx_A.Enabled = false;
                txbx_B.Enabled = false;
                txbx_C.Enabled = false;
            }
            else
            {
                txbx_η.Enabled = true;
                txbx_η.Text = "1";
                txbx_Pн.Enabled = true;
                txbx_η.Enabled = true;
                txbx_A.Enabled = true;
                txbx_B.Enabled = true;
                txbx_C.Enabled = true;
            }
        }

        private void txbx_Pн_KeyUp(object sender, KeyEventArgs e)
        {
            if (txbx_Pн.Text.Trim() != "")
            {
                txbx_A.Enabled = false;
                txbx_B.Enabled = false;
                txbx_C.Enabled = false;
            }
            else
            {
                txbx_A.Enabled = true;
                txbx_B.Enabled = true;
                txbx_C.Enabled = true;
            }
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
        private void txbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txbx_Pmax.Text.Trim()) ||
                string.IsNullOrEmpty(txbx_M.Text.Trim()) ||
                string.IsNullOrEmpty(txbx_Z.Text.Trim()) ||
                string.IsNullOrEmpty(txbx_Vсвоб.Text.Trim()) ||
                string.IsNullOrEmpty(txbx_tp.Text.Trim()))
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
            calculation.ГГflag = rbtn_ГГ.Checked;
            calculation.Pmax = double.Parse(txbx_Pmax.Text.Trim());
            calculation.M = double.Parse(txbx_M.Text.Trim());
            calculation.P1 = (!string.IsNullOrEmpty(txbx_P1.Text.Trim())) ? double.Parse(txbx_P1.Text.Trim()) : 0;
            calculation.V = (!string.IsNullOrEmpty(txbx_V.Text.Trim())) ? double.Parse(txbx_V.Text.Trim()) : 0;
            calculation.q = (!string.IsNullOrEmpty(txbx_q.Text.Trim())) ? double.Parse(txbx_q.Text.Trim()) : 0;
            calculation.τ712 = (!string.IsNullOrEmpty(txbx_τ712.Text.Trim())) ? double.Parse(txbx_τ712.Text.Trim()) : 0;
            calculation.P2 = (!string.IsNullOrEmpty(txbx_P2.Text.Trim())) ? double.Parse(txbx_P2.Text.Trim()) : 0;
            calculation.r = (!string.IsNullOrEmpty(txbx_r.Text.Trim())) ? double.Parse(txbx_r.Text.Trim()) : 0;
            calculation.L = (!string.IsNullOrEmpty(txbx_L.Text.Trim())) ? double.Parse(txbx_L.Text.Trim()) : 0;
            calculation.W = (!string.IsNullOrEmpty(txbx_W.Text.Trim())) ? double.Parse(txbx_W.Text.Trim()) : 0;
            calculation.Fиж = (!string.IsNullOrEmpty(txbx_Fuж.Text.Trim())) ? double.Parse(txbx_Fuж.Text.Trim()) : 0;
            calculation.Fиемк = (!string.IsNullOrEmpty(txbx_Fuемк.Text.Trim())) ? double.Parse(txbx_Fuемк.Text.Trim()) : 0;
            calculation.Fисв = (!string.IsNullOrEmpty(txbx_Fuсв.Text.Trim())) ? double.Parse(txbx_Fuсв.Text.Trim()) : 0;
            calculation.τиспж = (!string.IsNullOrEmpty(txbx_τиспж.Text.Trim())) ? double.Parse(txbx_τиспж.Text.Trim()) : 0;
            calculation.τиспемк = (!string.IsNullOrEmpty(txbx_τиспемк.Text.Trim())) ? double.Parse(txbx_τиспемк.Text.Trim()) : 0;
            calculation.τиспсв = (!string.IsNullOrEmpty(txbx_τиспсв.Text.Trim())) ? double.Parse(txbx_τиспсв.Text.Trim()) : 0;
            calculation.η = (!string.IsNullOrEmpty(txbx_η.Text.Trim())) ? double.Parse(txbx_η.Text.Trim()) : 0;
            calculation.Pн = (!string.IsNullOrEmpty(txbx_Pн.Text.Trim())) ? double.Parse(txbx_Pн.Text.Trim()) : 0;
            calculation.A = (!string.IsNullOrEmpty(txbx_A.Text.Trim())) ? double.Parse(txbx_A.Text.Trim()) : 0;
            calculation.B = (!string.IsNullOrEmpty(txbx_B.Text.Trim())) ? double.Parse(txbx_B.Text.Trim()) : 0;
            calculation.C = (!string.IsNullOrEmpty(txbx_C.Text.Trim())) ? double.Parse(txbx_C.Text.Trim()) : 0;
            calculation.Z = double.Parse(txbx_Z.Text.Trim());
            calculation.Vсвоб = double.Parse(txbx_Vсвоб.Text.Trim());
            calculation.tp = double.Parse(txbx_tp.Text.Trim());
            calculation.Nc = (!string.IsNullOrEmpty(txbx_Nc.Text.Trim())) ? double.Parse(txbx_Nc.Text.Trim()) : 0;
            calculation.Nh = (!string.IsNullOrEmpty(txbx_Nh.Text.Trim())) ? double.Parse(txbx_Nh.Text.Trim()) : 0;
            calculation.No = (!string.IsNullOrEmpty(txbx_No.Text.Trim())) ? double.Parse(txbx_No.Text.Trim()) : 0;
            calculation.Nx = (!string.IsNullOrEmpty(txbx_Nx.Text.Trim())) ? double.Parse(txbx_Nx.Text.Trim()) : 0;

            txbx_result.Text = calculation.ΔР().ToString();
        }
    }
}
