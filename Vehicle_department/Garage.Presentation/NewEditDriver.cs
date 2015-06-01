using System;
using System.Windows.Forms;
using Garage.Infrastructure;

namespace Garage.Presentation
{
    public partial class NewEditDriver : Form
    {
        DAL dal = new DAL();
        bool addFlag = false;

        public NewEditDriver(bool addFlag)
        {
            InitializeComponent();

            if (addFlag)
            {
                txbx_id.Text = Guid.NewGuid().ToString();
                this.addFlag = addFlag;
            }
        }

        // disable save button if name is empty
        private void txbx_name_Leave(object sender, EventArgs e)
        {
            if (txbx_name.Text.Trim() == "")
                btn_saveDriver.Enabled = false;
            else
                btn_saveDriver.Enabled = true;
        }

        // save data button handler
        private void btn_saveDriver_Click(object sender, EventArgs e)
        {
            if (dal.AddEditDriver(txbx_name.Text.Trim(),
                                  dtp_birthDate.Value,
                                  txbx_category.Text.Trim(),
                                  txbx_phoneNum.Text.Trim(),
                                  dtp_medicine.Value,
                                  txbx_id.Text.Trim(), 
                                  addFlag))
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.No;
        }
    }
}
