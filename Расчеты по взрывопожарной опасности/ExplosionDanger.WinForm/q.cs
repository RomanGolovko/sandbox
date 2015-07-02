using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //private void txbx_Leave(object sender, EventArgs e)
        //{
        //    if (rbtn_лвж.Checked)
        //        if (txbx_Hт.Text.Trim() == "" ||
        //            txbx_Vсвоб.Text.Trim() == "" ||
        //            txbx_F.Text.Trim() == "" ||
        //            txbx_Pв.Text.Trim() == "" ||
        //            txbx_T0.Text.Trim() == "" ||
        //            txbx_Kвз.Text.Trim() == "" ||
        //            txbx_τ.Text.Trim() == "" ||
        //            txbx_q.Text.Trim() == "" ||
        //            txbx_mап.Text.Trim() == "" ||
        //            txbx_Kп.Text.Trim() == "" ||
        //            txbx_Kубор.Text.Trim() == "" ||
        //            txbx_Kг.Text.Trim() == "" ||
        //            txbx_n.Text.Trim() == "" ||
        //            txbx_β1.Text.Trim() == "" ||
        //            txbx_β2.Text.Trim() == "" ||
        //            txbx_M1j.Text.Trim() == "" ||
        //            txbx_M2j.Text.Trim() == "" ||
        //            txbx_α.Text.Trim() == "")
        //        {
        //            btn_calculate.Enabled = false;
        //            lbl_warning.ForeColor = Color.Red;
        //            lbl_warning.Text = "Не все данные\n заполнены!!!";
        //        }
        //        else
        //        {
        //            btn_calculate.Enabled = true;
        //            lbl_warning.Text = "";
        //        }
        //}

    }
}
