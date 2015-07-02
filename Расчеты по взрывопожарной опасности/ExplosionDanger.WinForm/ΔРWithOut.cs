using System;
using System.Drawing;
using System.Windows.Forms;
using ExplosionDanger.BLL;

namespace ExplosionDanger.WinForm
{
    public partial class ΔРWithOut : Form
    {
        OverpressureCalculationWithOut calculation = new OverpressureCalculationWithOut();
        public ΔРWithOut()
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
        private void txbx_w_Leave(object sender, EventArgs e)
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
        private void txbx_Pн_Leave(object sender, EventArgs e)
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
        private void txbx_Leave(object sender, EventArgs e)
        {
            if (txbx_Hт.Text.Trim() == "" ||
                txbx_Aв.Text.Trim() == "" ||
                txbx_τ.Text.Trim() == "" ||
                txbx_Z.Text.Trim() == "" ||
                txbx_Pв.Text.Trim() == "" ||
                txbx_T0.Text.Trim() == "" ||
                txbx_Vсвоб.Text.Trim() == "" ||
                txbx_tp.Text.Trim() == "" ||
                txbx_Nc.Text.Trim() == "" ||
                txbx_No.Text.Trim() == "" ||
                txbx_Nh.Text.Trim() == "" ||
                txbx_Nx.Text.Trim() == "")
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
            calculation.Hт = double.Parse(txbx_Hт.Text.Trim());
            calculation.Aв = double.Parse(txbx_Aв.Text.Trim());
            calculation.τ = double.Parse(txbx_τ.Text.Trim());
            calculation.Pв = double.Parse(txbx_Pв.Text.Trim());
            calculation.M = double.Parse(txbx_M.Text.Trim());
            calculation.P1 = (txbx_P1.Text.Trim() != "") ? double.Parse(txbx_P1.Text.Trim()) : 0;
            calculation.V = (txbx_V.Text.Trim() != "") ? double.Parse(txbx_V.Text.Trim()) : 0;
            calculation.q = (txbx_q.Text.Trim() != "") ? double.Parse(txbx_q.Text.Trim()) : 0;
            calculation.τ712 = (txbx_τ712.Text.Trim() != "") ? double.Parse(txbx_τ712.Text.Trim()) : 0;
            calculation.P2 = (txbx_P2.Text.Trim() != "") ? double.Parse(txbx_P2.Text.Trim()) : 0;
            calculation.r = (txbx_r.Text.Trim() != "") ? double.Parse(txbx_r.Text.Trim()) : 0;
            calculation.L = (txbx_L.Text.Trim() != "") ? double.Parse(txbx_L.Text.Trim()) : 0;
            calculation.W = (txbx_W.Text.Trim() != "") ? double.Parse(txbx_W.Text.Trim()) : 0;
            calculation.Fи = (txbx_Fu.Text.Trim() != "") ? double.Parse(txbx_Fu.Text.Trim()) : 0;
            calculation.τисп = (txbx_τисп.Text.Trim() != "") ? double.Parse(txbx_τисп.Text.Trim()) : 0;
            calculation.η = (txbx_η.Text.Trim() != "") ? double.Parse(txbx_η.Text.Trim()) : 0;
            calculation.Pн = (txbx_Pн.Text.Trim() != "") ? double.Parse(txbx_Pн.Text.Trim()) : 0;
            calculation.A = (txbx_A.Text.Trim() != "") ? double.Parse(txbx_A.Text.Trim()) : 0;
            calculation.B = (txbx_B.Text.Trim() != "") ? double.Parse(txbx_B.Text.Trim()) : 0;
            calculation.C = (txbx_C.Text.Trim() != "") ? double.Parse(txbx_C.Text.Trim()) : 0;
            calculation.Z = double.Parse(txbx_Z.Text.Trim());
            calculation.T0 = double.Parse(txbx_T0.Text.Trim());
            calculation.Vсвоб = double.Parse(txbx_Vсвоб.Text.Trim());
            calculation.tp = double.Parse(txbx_tp.Text.Trim());
            calculation.Nc = double.Parse(txbx_Nc.Text.Trim());
            calculation.Nh = double.Parse(txbx_Nh.Text.Trim());
            calculation.No = double.Parse(txbx_No.Text.Trim());
            calculation.Nx = double.Parse(txbx_Nx.Text.Trim());


            txbx_result.Text = calculation.ΔP().ToString();
        }
    }
}
