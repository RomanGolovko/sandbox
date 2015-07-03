using System;
using System.Windows.Forms;
using Garage.Infrastructure;

namespace Garage.Presentation
{
    public partial class NewEditVehicle : Form
    {
        GarageContoller repository;
        bool LiteDb;
        bool MsSql;
        bool addFlag = false;

        public NewEditVehicle(bool addFlag, bool LiteDb, bool MsSql)
        {
            InitializeComponent();

            this.LiteDb = LiteDb;
            this.MsSql = MsSql;

            repository = new GarageContoller(LiteDb, MsSql);

            if (addFlag)
            {
                txbx_id.Text = Guid.NewGuid().ToString();
                this.addFlag = addFlag;
            }
        }

        // disable save button if brand, state number, vin code or mileage is empty
        private void txbx_Leave(object sender, EventArgs e)
        {
            if (txbx_brand.Text.Trim() == "" ||
                txbx_stateNum.Text.Trim() == "" ||
                txbx_vinCode.Text.Trim() == "" ||
                txbx_mileage.Text.Trim() == "")
                btn_saveVehicle.Enabled = false;
            else
                btn_saveVehicle.Enabled = true;
        }

        // save data button handler
        private void btn_saveVehicle_Click(object sender, EventArgs e)
        {
            if (repository.UpsertVehicle(txbx_brand.Text.Trim(),
                                          txbx_stateNum.Text.Trim(),
                                          txbx_color.Text.Trim(),
                                          dtp_releaseDate.Value,
                                          txbx_vinCode.Text.Trim(),
                                          txbx_mileage.Text.Trim(),
                                          dtp_insurance.Value,
                                          cmbx_driver.SelectedValue.ToString(),
                                          txbx_id.Text.Trim(),
                                          addFlag))
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.No;
        }
    }
}
