namespace Garage.Presentation
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbx_garage = new System.Windows.Forms.GroupBox();
            this.tbcntrl_garage = new System.Windows.Forms.TabControl();
            this.tbpg_garageDrivers = new System.Windows.Forms.TabPage();
            this.txbx_driverSearch = new System.Windows.Forms.TextBox();
            this.btn_driverSearch = new System.Windows.Forms.Button();
            this.btn_deleteDriver = new System.Windows.Forms.Button();
            this.btn_editDriver = new System.Windows.Forms.Button();
            this.btn_addDriver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_driverCategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_driverMedicine = new System.Windows.Forms.TextBox();
            this.txbx_driverPhoneNum = new System.Windows.Forms.TextBox();
            this.txbx_driverBirthDate = new System.Windows.Forms.TextBox();
            this.txbx_driverName = new System.Windows.Forms.TextBox();
            this.dgv_drivers = new System.Windows.Forms.DataGridView();
            this.tbpg_garageVehicles = new System.Windows.Forms.TabPage();
            this.btn_vehicleSearch = new System.Windows.Forms.Button();
            this.txbx_vehicleSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_vehicleDriveName = new System.Windows.Forms.TextBox();
            this.txbx_vehicleInsurance = new System.Windows.Forms.TextBox();
            this.txbx_vehicleReleaseDate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbx_vehicleNextTechServ = new System.Windows.Forms.TextBox();
            this.btn_delVehicle = new System.Windows.Forms.Button();
            this.btn_editVehicle = new System.Windows.Forms.Button();
            this.btn_addVehicle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txbx_vehicleMileage = new System.Windows.Forms.TextBox();
            this.txbx_vehicleVinCode = new System.Windows.Forms.TextBox();
            this.txbx_vehicleColor = new System.Windows.Forms.TextBox();
            this.txbx_vehicleStateNum = new System.Windows.Forms.TextBox();
            this.txbx_vehicleBrand = new System.Windows.Forms.TextBox();
            this.dgv_vehicle = new System.Windows.Forms.DataGridView();
            this.DriverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbx_garage.SuspendLayout();
            this.tbcntrl_garage.SuspendLayout();
            this.tbpg_garageDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drivers)).BeginInit();
            this.tbpg_garageVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbx_garage
            // 
            this.grpbx_garage.Controls.Add(this.tbcntrl_garage);
            this.grpbx_garage.Location = new System.Drawing.Point(12, 12);
            this.grpbx_garage.Name = "grpbx_garage";
            this.grpbx_garage.Size = new System.Drawing.Size(654, 404);
            this.grpbx_garage.TabIndex = 0;
            this.grpbx_garage.TabStop = false;
            this.grpbx_garage.Text = "Vehicle Department";
            // 
            // tbcntrl_garage
            // 
            this.tbcntrl_garage.Controls.Add(this.tbpg_garageDrivers);
            this.tbcntrl_garage.Controls.Add(this.tbpg_garageVehicles);
            this.tbcntrl_garage.Location = new System.Drawing.Point(6, 19);
            this.tbcntrl_garage.Name = "tbcntrl_garage";
            this.tbcntrl_garage.SelectedIndex = 0;
            this.tbcntrl_garage.Size = new System.Drawing.Size(640, 379);
            this.tbcntrl_garage.TabIndex = 0;
            // 
            // tbpg_garageDrivers
            // 
            this.tbpg_garageDrivers.Controls.Add(this.txbx_driverSearch);
            this.tbpg_garageDrivers.Controls.Add(this.btn_driverSearch);
            this.tbpg_garageDrivers.Controls.Add(this.btn_deleteDriver);
            this.tbpg_garageDrivers.Controls.Add(this.btn_editDriver);
            this.tbpg_garageDrivers.Controls.Add(this.btn_addDriver);
            this.tbpg_garageDrivers.Controls.Add(this.label5);
            this.tbpg_garageDrivers.Controls.Add(this.txbx_driverCategory);
            this.tbpg_garageDrivers.Controls.Add(this.label4);
            this.tbpg_garageDrivers.Controls.Add(this.label3);
            this.tbpg_garageDrivers.Controls.Add(this.label2);
            this.tbpg_garageDrivers.Controls.Add(this.label1);
            this.tbpg_garageDrivers.Controls.Add(this.txbx_driverMedicine);
            this.tbpg_garageDrivers.Controls.Add(this.txbx_driverPhoneNum);
            this.tbpg_garageDrivers.Controls.Add(this.txbx_driverBirthDate);
            this.tbpg_garageDrivers.Controls.Add(this.txbx_driverName);
            this.tbpg_garageDrivers.Controls.Add(this.dgv_drivers);
            this.tbpg_garageDrivers.Location = new System.Drawing.Point(4, 22);
            this.tbpg_garageDrivers.Name = "tbpg_garageDrivers";
            this.tbpg_garageDrivers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_garageDrivers.Size = new System.Drawing.Size(632, 353);
            this.tbpg_garageDrivers.TabIndex = 0;
            this.tbpg_garageDrivers.Text = "Drivers";
            this.tbpg_garageDrivers.UseVisualStyleBackColor = true;
            // 
            // txbx_driverSearch
            // 
            this.txbx_driverSearch.Location = new System.Drawing.Point(7, 18);
            this.txbx_driverSearch.Name = "txbx_driverSearch";
            this.txbx_driverSearch.Size = new System.Drawing.Size(406, 20);
            this.txbx_driverSearch.TabIndex = 55;
            // 
            // btn_driverSearch
            // 
            this.btn_driverSearch.Location = new System.Drawing.Point(435, 18);
            this.btn_driverSearch.Name = "btn_driverSearch";
            this.btn_driverSearch.Size = new System.Drawing.Size(186, 20);
            this.btn_driverSearch.TabIndex = 54;
            this.btn_driverSearch.Text = "Search";
            this.btn_driverSearch.UseVisualStyleBackColor = true;
            this.btn_driverSearch.Click += new System.EventHandler(this.btn_driverSearch_Click);
            // 
            // btn_deleteDriver
            // 
            this.btn_deleteDriver.Location = new System.Drawing.Point(421, 309);
            this.btn_deleteDriver.Name = "btn_deleteDriver";
            this.btn_deleteDriver.Size = new System.Drawing.Size(200, 23);
            this.btn_deleteDriver.TabIndex = 53;
            this.btn_deleteDriver.Text = "Delete Driver";
            this.btn_deleteDriver.UseVisualStyleBackColor = true;
            this.btn_deleteDriver.Click += new System.EventHandler(this.btn_deleteDriver_Click);
            // 
            // btn_editDriver
            // 
            this.btn_editDriver.Location = new System.Drawing.Point(213, 309);
            this.btn_editDriver.Name = "btn_editDriver";
            this.btn_editDriver.Size = new System.Drawing.Size(200, 23);
            this.btn_editDriver.TabIndex = 52;
            this.btn_editDriver.Text = "Edit Driver";
            this.btn_editDriver.UseVisualStyleBackColor = true;
            this.btn_editDriver.Click += new System.EventHandler(this.btn_editDriver_Click);
            // 
            // btn_addDriver
            // 
            this.btn_addDriver.Location = new System.Drawing.Point(7, 309);
            this.btn_addDriver.Name = "btn_addDriver";
            this.btn_addDriver.Size = new System.Drawing.Size(200, 23);
            this.btn_addDriver.TabIndex = 51;
            this.btn_addDriver.Text = "Add Driver";
            this.btn_addDriver.UseVisualStyleBackColor = true;
            this.btn_addDriver.Click += new System.EventHandler(this.btn_addDriver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Category";
            // 
            // txbx_driverCategory
            // 
            this.txbx_driverCategory.Location = new System.Drawing.Point(435, 96);
            this.txbx_driverCategory.Name = "txbx_driverCategory";
            this.txbx_driverCategory.Size = new System.Drawing.Size(186, 20);
            this.txbx_driverCategory.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Medical Certificate Best Before";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Date of birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // txbx_driverMedicine
            // 
            this.txbx_driverMedicine.Location = new System.Drawing.Point(493, 148);
            this.txbx_driverMedicine.Name = "txbx_driverMedicine";
            this.txbx_driverMedicine.Size = new System.Drawing.Size(128, 20);
            this.txbx_driverMedicine.TabIndex = 24;
            // 
            // txbx_driverPhoneNum
            // 
            this.txbx_driverPhoneNum.Location = new System.Drawing.Point(435, 122);
            this.txbx_driverPhoneNum.Name = "txbx_driverPhoneNum";
            this.txbx_driverPhoneNum.Size = new System.Drawing.Size(186, 20);
            this.txbx_driverPhoneNum.TabIndex = 23;
            // 
            // txbx_driverBirthDate
            // 
            this.txbx_driverBirthDate.Location = new System.Drawing.Point(435, 70);
            this.txbx_driverBirthDate.Name = "txbx_driverBirthDate";
            this.txbx_driverBirthDate.Size = new System.Drawing.Size(186, 20);
            this.txbx_driverBirthDate.TabIndex = 22;
            // 
            // txbx_driverName
            // 
            this.txbx_driverName.Location = new System.Drawing.Point(435, 44);
            this.txbx_driverName.Name = "txbx_driverName";
            this.txbx_driverName.Size = new System.Drawing.Size(186, 20);
            this.txbx_driverName.TabIndex = 21;
            // 
            // dgv_drivers
            // 
            this.dgv_drivers.AllowUserToAddRows = false;
            this.dgv_drivers.AllowUserToDeleteRows = false;
            this.dgv_drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_drivers.Location = new System.Drawing.Point(6, 44);
            this.dgv_drivers.Name = "dgv_drivers";
            this.dgv_drivers.ReadOnly = true;
            this.dgv_drivers.Size = new System.Drawing.Size(300, 225);
            this.dgv_drivers.TabIndex = 20;
            this.dgv_drivers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_drivers_CellEnter);
            this.dgv_drivers.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // tbpg_garageVehicles
            // 
            this.tbpg_garageVehicles.Controls.Add(this.btn_vehicleSearch);
            this.tbpg_garageVehicles.Controls.Add(this.txbx_vehicleSearch);
            this.tbpg_garageVehicles.Controls.Add(this.label6);
            this.tbpg_garageVehicles.Controls.Add(this.txbx_vehicleDriveName);
            this.tbpg_garageVehicles.Controls.Add(this.txbx_vehicleInsurance);
            this.tbpg_garageVehicles.Controls.Add(this.txbx_vehicleReleaseDate);
            this.tbpg_garageVehicles.Controls.Add(this.label15);
            this.tbpg_garageVehicles.Controls.Add(this.label10);
            this.tbpg_garageVehicles.Controls.Add(this.txbx_vehicleNextTechServ);
            this.tbpg_garageVehicles.Controls.Add(this.btn_delVehicle);
            this.tbpg_garageVehicles.Controls.Add(this.btn_editVehicle);
            this.tbpg_garageVehicles.Controls.Add(this.btn_addVehicle);
            this.tbpg_garageVehicles.Controls.Add(this.label14);
            this.tbpg_garageVehicles.Controls.Add(this.label13);
            this.tbpg_garageVehicles.Controls.Add(this.label12);
            this.tbpg_garageVehicles.Controls.Add(this.label11);
            this.tbpg_garageVehicles.Controls.Add(this.label9);
            this.tbpg_garageVehicles.Controls.Add(this.label8);
            this.tbpg_garageVehicles.Controls.Add(this.label7);
            this.tbpg_garageVehicles.Controls.Add(this.label16);
            this.tbpg_garageVehicles.Controls.Add(this.txbx_vehicleMileage);
            this.tbpg_garageVehicles.Controls.Add(this.txbx_vehicleVinCode);
            this.tbpg_garageVehicles.Controls.Add(this.txbx_vehicleColor);
            this.tbpg_garageVehicles.Controls.Add(this.txbx_vehicleStateNum);
            this.tbpg_garageVehicles.Controls.Add(this.txbx_vehicleBrand);
            this.tbpg_garageVehicles.Controls.Add(this.dgv_vehicle);
            this.tbpg_garageVehicles.Location = new System.Drawing.Point(4, 22);
            this.tbpg_garageVehicles.Name = "tbpg_garageVehicles";
            this.tbpg_garageVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tbpg_garageVehicles.Size = new System.Drawing.Size(632, 353);
            this.tbpg_garageVehicles.TabIndex = 1;
            this.tbpg_garageVehicles.Text = "Vehicles";
            this.tbpg_garageVehicles.UseVisualStyleBackColor = true;
            // 
            // btn_vehicleSearch
            // 
            this.btn_vehicleSearch.Location = new System.Drawing.Point(435, 18);
            this.btn_vehicleSearch.Name = "btn_vehicleSearch";
            this.btn_vehicleSearch.Size = new System.Drawing.Size(186, 20);
            this.btn_vehicleSearch.TabIndex = 59;
            this.btn_vehicleSearch.Text = "Search";
            this.btn_vehicleSearch.UseVisualStyleBackColor = true;
            this.btn_vehicleSearch.Click += new System.EventHandler(this.btn_vehicleSearch_Click);
            // 
            // txbx_vehicleSearch
            // 
            this.txbx_vehicleSearch.Location = new System.Drawing.Point(7, 18);
            this.txbx_vehicleSearch.Name = "txbx_vehicleSearch";
            this.txbx_vehicleSearch.Size = new System.Drawing.Size(406, 20);
            this.txbx_vehicleSearch.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Driver";
            // 
            // txbx_vehicleDriveName
            // 
            this.txbx_vehicleDriveName.Location = new System.Drawing.Point(434, 95);
            this.txbx_vehicleDriveName.Name = "txbx_vehicleDriveName";
            this.txbx_vehicleDriveName.Size = new System.Drawing.Size(186, 20);
            this.txbx_vehicleDriveName.TabIndex = 56;
            // 
            // txbx_vehicleInsurance
            // 
            this.txbx_vehicleInsurance.Location = new System.Drawing.Point(447, 225);
            this.txbx_vehicleInsurance.Name = "txbx_vehicleInsurance";
            this.txbx_vehicleInsurance.Size = new System.Drawing.Size(173, 20);
            this.txbx_vehicleInsurance.TabIndex = 55;
            // 
            // txbx_vehicleReleaseDate
            // 
            this.txbx_vehicleReleaseDate.Location = new System.Drawing.Point(434, 147);
            this.txbx_vehicleReleaseDate.Name = "txbx_vehicleReleaseDate";
            this.txbx_vehicleReleaseDate.Size = new System.Drawing.Size(186, 20);
            this.txbx_vehicleReleaseDate.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(331, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Tech Serv After";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(599, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "km";
            // 
            // txbx_vehicleNextTechServ
            // 
            this.txbx_vehicleNextTechServ.Location = new System.Drawing.Point(434, 251);
            this.txbx_vehicleNextTechServ.Name = "txbx_vehicleNextTechServ";
            this.txbx_vehicleNextTechServ.Size = new System.Drawing.Size(162, 20);
            this.txbx_vehicleNextTechServ.TabIndex = 51;
            // 
            // btn_delVehicle
            // 
            this.btn_delVehicle.Location = new System.Drawing.Point(421, 309);
            this.btn_delVehicle.Name = "btn_delVehicle";
            this.btn_delVehicle.Size = new System.Drawing.Size(200, 23);
            this.btn_delVehicle.TabIndex = 50;
            this.btn_delVehicle.Text = "Delete Vehicle";
            this.btn_delVehicle.UseVisualStyleBackColor = true;
            this.btn_delVehicle.Click += new System.EventHandler(this.btn_delVehicle_Click);
            // 
            // btn_editVehicle
            // 
            this.btn_editVehicle.Location = new System.Drawing.Point(213, 309);
            this.btn_editVehicle.Name = "btn_editVehicle";
            this.btn_editVehicle.Size = new System.Drawing.Size(200, 23);
            this.btn_editVehicle.TabIndex = 49;
            this.btn_editVehicle.Text = "Edit Vehicle";
            this.btn_editVehicle.UseVisualStyleBackColor = true;
            this.btn_editVehicle.Click += new System.EventHandler(this.btn_editVehicle_Click);
            // 
            // btn_addVehicle
            // 
            this.btn_addVehicle.Location = new System.Drawing.Point(7, 309);
            this.btn_addVehicle.Name = "btn_addVehicle";
            this.btn_addVehicle.Size = new System.Drawing.Size(200, 23);
            this.btn_addVehicle.TabIndex = 48;
            this.btn_addVehicle.Text = "Add Vehicle";
            this.btn_addVehicle.UseVisualStyleBackColor = true;
            this.btn_addVehicle.Click += new System.EventHandler(this.btn_addVehicle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(599, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "km";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Insurance Best Before";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Release Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(331, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Brand";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Mileage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "VIN Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "State Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(331, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Color";
            // 
            // txbx_vehicleMileage
            // 
            this.txbx_vehicleMileage.Location = new System.Drawing.Point(434, 199);
            this.txbx_vehicleMileage.Name = "txbx_vehicleMileage";
            this.txbx_vehicleMileage.Size = new System.Drawing.Size(162, 20);
            this.txbx_vehicleMileage.TabIndex = 39;
            // 
            // txbx_vehicleVinCode
            // 
            this.txbx_vehicleVinCode.Location = new System.Drawing.Point(434, 173);
            this.txbx_vehicleVinCode.Name = "txbx_vehicleVinCode";
            this.txbx_vehicleVinCode.Size = new System.Drawing.Size(186, 20);
            this.txbx_vehicleVinCode.TabIndex = 38;
            // 
            // txbx_vehicleColor
            // 
            this.txbx_vehicleColor.Location = new System.Drawing.Point(434, 121);
            this.txbx_vehicleColor.Name = "txbx_vehicleColor";
            this.txbx_vehicleColor.Size = new System.Drawing.Size(186, 20);
            this.txbx_vehicleColor.TabIndex = 37;
            // 
            // txbx_vehicleStateNum
            // 
            this.txbx_vehicleStateNum.Location = new System.Drawing.Point(434, 69);
            this.txbx_vehicleStateNum.Name = "txbx_vehicleStateNum";
            this.txbx_vehicleStateNum.Size = new System.Drawing.Size(186, 20);
            this.txbx_vehicleStateNum.TabIndex = 36;
            // 
            // txbx_vehicleBrand
            // 
            this.txbx_vehicleBrand.Location = new System.Drawing.Point(434, 43);
            this.txbx_vehicleBrand.Name = "txbx_vehicleBrand";
            this.txbx_vehicleBrand.Size = new System.Drawing.Size(186, 20);
            this.txbx_vehicleBrand.TabIndex = 35;
            // 
            // dgv_vehicle
            // 
            this.dgv_vehicle.AllowUserToAddRows = false;
            this.dgv_vehicle.AllowUserToDeleteRows = false;
            this.dgv_vehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverId});
            this.dgv_vehicle.Location = new System.Drawing.Point(6, 44);
            this.dgv_vehicle.Name = "dgv_vehicle";
            this.dgv_vehicle.ReadOnly = true;
            this.dgv_vehicle.Size = new System.Drawing.Size(300, 225);
            this.dgv_vehicle.TabIndex = 34;
            this.dgv_vehicle.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vehicle_CellEnter);
            this.dgv_vehicle.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // DriverId
            // 
            this.DriverId.DataPropertyName = "DriverId";
            this.DriverId.HeaderText = "DriverId";
            this.DriverId.Name = "DriverId";
            this.DriverId.ReadOnly = true;
            this.DriverId.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 431);
            this.Controls.Add(this.grpbx_garage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Vehicle Department";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpbx_garage.ResumeLayout(false);
            this.tbcntrl_garage.ResumeLayout(false);
            this.tbpg_garageDrivers.ResumeLayout(false);
            this.tbpg_garageDrivers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drivers)).EndInit();
            this.tbpg_garageVehicles.ResumeLayout(false);
            this.tbpg_garageVehicles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcntrl_garage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpg_garageVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverId;
        private System.Windows.Forms.GroupBox grpbx_garage;
        private System.Windows.Forms.TabPage tbpg_garageDrivers;
        private System.Windows.Forms.Button btn_deleteDriver;
        private System.Windows.Forms.Button btn_editDriver;
        private System.Windows.Forms.Button btn_addDriver;
        private System.Windows.Forms.TextBox txbx_driverCategory;
        private System.Windows.Forms.TextBox txbx_driverMedicine;
        private System.Windows.Forms.TextBox txbx_driverPhoneNum;
        private System.Windows.Forms.TextBox txbx_driverBirthDate;
        private System.Windows.Forms.TextBox txbx_driverName;
        private System.Windows.Forms.DataGridView dgv_drivers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_vehicleDriveName;
        private System.Windows.Forms.TextBox txbx_vehicleInsurance;
        private System.Windows.Forms.TextBox txbx_vehicleReleaseDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbx_vehicleNextTechServ;
        private System.Windows.Forms.Button btn_delVehicle;
        private System.Windows.Forms.Button btn_editVehicle;
        private System.Windows.Forms.Button btn_addVehicle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbx_vehicleMileage;
        private System.Windows.Forms.TextBox txbx_vehicleVinCode;
        private System.Windows.Forms.TextBox txbx_vehicleColor;
        private System.Windows.Forms.TextBox txbx_vehicleStateNum;
        private System.Windows.Forms.TextBox txbx_vehicleBrand;
        private System.Windows.Forms.DataGridView dgv_vehicle;
        private System.Windows.Forms.TextBox txbx_driverSearch;
        private System.Windows.Forms.Button btn_driverSearch;
        private System.Windows.Forms.Button btn_vehicleSearch;
        private System.Windows.Forms.TextBox txbx_vehicleSearch;
    }
}

