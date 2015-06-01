using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using Garage.Infrastructure;
using Garage.Domain;

namespace Garage.Presentation
{
    public partial class MainForm : Form
    {
        GarageContext db;
        DAL dal = new DAL();
        public MainForm()
        {
            InitializeComponent();

            db = new GarageContext();

            db.Drivers.Load();
            dgv_drivers.DataSource = db.Drivers.Local.ToBindingList();

            db.Vehicles.Load();
            dgv_vehicle.DataSource = db.Vehicles.Local.ToBindingList();

            Settings();
        }

        void Settings()
        {
            try
            {
                dgv_drivers.Columns["Id"].Visible = false;
                dgv_drivers.Columns["BirthDate"].Visible = false;
                dgv_drivers.Columns["Category"].Visible = false;
                dgv_drivers.Columns["PhoneNum"].Visible = false;
                dgv_drivers.Columns["MedicalCertificate"].Visible = false;
                dgv_drivers.TopLeftHeaderCell.Value = "#";

                dgv_vehicle.Columns["Id"].Visible = false;
                dgv_vehicle.Columns["Color"].Visible = false;
                dgv_vehicle.Columns["ReleaseDate"].Visible = false;
                dgv_vehicle.Columns["VinCode"].Visible = false;
                dgv_vehicle.Columns["Mileage"].Visible = false;
                dgv_vehicle.Columns["Insurance"].Visible = false;
                dgv_vehicle.Columns["NextTechServ"].Visible = false;
                dgv_vehicle.Columns["DriverId"].Visible = false;
                dgv_vehicle.Columns["Driver"].Visible = false;
                dgv_vehicle.TopLeftHeaderCell.Value = "#";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            dal.Reminder();
        }

        private void dgv_drivers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txbx_driverName.Text = dgv_drivers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbx_driverBirthDate.Text = dgv_drivers.Rows[e.RowIndex].Cells[2].Value.ToString();
            txbx_driverCategory.Text = dgv_drivers.Rows[e.RowIndex].Cells[3].Value.ToString();
            txbx_driverPhoneNum.Text = dgv_drivers.Rows[e.RowIndex].Cells[4].Value.ToString();
            txbx_driverMedicine.Text = dgv_drivers.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dgv_vehicle_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (db.Vehicles.Count() > 0)
            {
                txbx_vehicleBrand.Text = dgv_vehicle.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbx_vehicleStateNum.Text = dgv_vehicle.Rows[e.RowIndex].Cells[2].Value.ToString();
                txbx_vehicleColor.Text = dgv_vehicle.Rows[e.RowIndex].Cells[3].Value.ToString();
                txbx_vehicleReleaseDate.Text = dgv_vehicle.Rows[e.RowIndex].Cells[4].Value.ToString();
                txbx_vehicleVinCode.Text = dgv_vehicle.Rows[e.RowIndex].Cells[5].Value.ToString();
                txbx_vehicleMileage.Text = dgv_vehicle.Rows[e.RowIndex].Cells[6].Value.ToString();
                txbx_vehicleInsurance.Text = dgv_vehicle.Rows[e.RowIndex].Cells[7].Value.ToString();
                txbx_vehicleNextTechServ.Text = dgv_vehicle.Rows[e.RowIndex].Cells[8].Value.ToString();

                // search current driver via Id
                Guid id;
                bool converted = Guid.TryParse(dgv_drivers[0, e.RowIndex].Value.ToString(), out id);
                if (converted == false)
                    return;

                var driver = dal.CurrentDriver(id);
                txbx_vehicleDriveName.Text = driver.Name;
            }
        }

        private void btn_addDriver_Click(object sender, EventArgs e)
        {
            NewEditDriver addDriver = new NewEditDriver(true);
            if (addDriver.ShowDialog() == DialogResult.OK)
                MessageBox.Show("New driver was succecfuly added", "Vehicle Department",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("New driver was not added!", "Vehicle Department",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_editDriver_Click(object sender, EventArgs e)
        {
            if (dgv_drivers.SelectedRows.Count > 0)
            {
                // search current driver via Id
                int index = dgv_drivers.SelectedRows[0].Index;
                Guid id;
                bool converted = Guid.TryParse(dgv_drivers[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                var currentDriver = dal.CurrentDriver(id);
                NewEditDriver editDriver = new NewEditDriver(false);
                try
                {
                    editDriver.txbx_name.Text = currentDriver.Name;
                    editDriver.dtp_birthDate.Value = currentDriver.BirthDate;
                    editDriver.txbx_category.Text = currentDriver.Category;
                    editDriver.txbx_phoneNum.Text = currentDriver.PhoneNum;
                    editDriver.dtp_medicine.Value = currentDriver.MedicalCertificate;
                    editDriver.txbx_id.Text = currentDriver.Id.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (editDriver.ShowDialog() == DialogResult.OK)
                    MessageBox.Show("Driver was succecfuly edited", "Vehicle Department",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Driver was not edited!", "Vehicle Department",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_deleteDriver_Click(object sender, EventArgs e)
        {
            if (dgv_drivers.SelectedRows.Count > 0)
            {
                // search current driver via Id
                int index = dgv_drivers.SelectedRows[0].Index;
                Guid id;
                bool converted = Guid.TryParse(dgv_drivers[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                if (dal.DelDriver(id))
                    MessageBox.Show("Driver was succecfuly deleted", "Vehicle Department",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Driver was not deleted!", "Vehicle Department",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            NewEditVehicle addVehicle = new NewEditVehicle(true);

            // fill ComboBox
            List<Driver> drivers = db.Drivers.ToList();
            addVehicle.cmbx_driver.DataSource = drivers;   // DataSource
            addVehicle.cmbx_driver.ValueMember = "Id";     // returned value
            addVehicle.cmbx_driver.DisplayMember = "Name"; // dispayed value

            if (addVehicle.ShowDialog() == DialogResult.OK)
                MessageBox.Show("New vehicle was succecfuly added", "Vehicle Department",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("New vehicle was not added", "Vehicle Department",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_editVehicle_Click(object sender, EventArgs e)
        {
            if (dgv_vehicle.SelectedRows.Count > 0)
            {
                // search current vehicle via Id
                int index = dgv_vehicle.SelectedRows[0].Index;
                Guid id;
                bool converted = Guid.TryParse(dgv_vehicle[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                var currentVehicle = dal.CurrentVehicle(id);
                NewEditVehicle editVehicle = new NewEditVehicle(false);
                try
                {
                    editVehicle.txbx_brand.Text = currentVehicle.Brand;
                    editVehicle.txbx_stateNum.Text = currentVehicle.StateNum;
                    editVehicle.txbx_color.Text = currentVehicle.Color;
                    editVehicle.dtp_releaseDate.Value = currentVehicle.ReleaseDate;
                    editVehicle.txbx_vinCode.Text = currentVehicle.VinCode;
                    editVehicle.txbx_mileage.Text = currentVehicle.Mileage.ToString();
                    editVehicle.dtp_insurance.Value = currentVehicle.Insurance;
                    editVehicle.txbx_id.Text = currentVehicle.Id.ToString();
                    // fill ComboBox
                    List<Driver> drivers = db.Drivers.ToList();
                    editVehicle.cmbx_driver.DataSource = drivers;   // DataSource
                    editVehicle.cmbx_driver.ValueMember = "Id";     // returned value
                    editVehicle.cmbx_driver.DisplayMember = "Name"; // dispayed value
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (editVehicle.ShowDialog() == DialogResult.OK)
                    MessageBox.Show("Vehicle was succecfuly edited", "Vehicle Department",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Vehicle was not edited!", "Vehicle Department",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delVehicle_Click(object sender, EventArgs e)
        {
            if (dgv_vehicle.SelectedRows.Count > 0)
            {
                // search current vehicle via Id
                int index = dgv_vehicle.SelectedRows[0].Index;
                Guid id;
                bool converted = Guid.TryParse(dgv_vehicle[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                if (dal.DelVehicle(id))
                    MessageBox.Show("Vehicle was succecfuly deleted", "Vehicle Department",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Vehicle was not deleted!", "Vehicle Department",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You wont to quit?", "Vehicle Department",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object headValue = ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value;
            if (headValue == null || !headValue.Equals((e.RowIndex + 1).ToString()))
                ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }
    }
}
