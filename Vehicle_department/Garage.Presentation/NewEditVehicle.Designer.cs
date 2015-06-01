namespace Garage.Presentation
{
    partial class NewEditVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbx_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbx_mileage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbx_color = new System.Windows.Forms.TextBox();
            this.cmbx_driver = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_stateNum = new System.Windows.Forms.TextBox();
            this.btn_saveVehicle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_insurance = new System.Windows.Forms.DateTimePicker();
            this.dtp_releaseDate = new System.Windows.Forms.DateTimePicker();
            this.txbx_vinCode = new System.Windows.Forms.TextBox();
            this.txbx_brand = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbx_id);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txbx_mileage);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbx_color);
            this.groupBox1.Controls.Add(this.cmbx_driver);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbx_stateNum);
            this.groupBox1.Controls.Add(this.btn_saveVehicle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_insurance);
            this.groupBox1.Controls.Add(this.dtp_releaseDate);
            this.groupBox1.Controls.Add(this.txbx_vinCode);
            this.groupBox1.Controls.Add(this.txbx_brand);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle";
            // 
            // txbx_id
            // 
            this.txbx_id.Location = new System.Drawing.Point(234, 237);
            this.txbx_id.Name = "txbx_id";
            this.txbx_id.Size = new System.Drawing.Size(100, 20);
            this.txbx_id.TabIndex = 37;
            this.txbx_id.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Mileage";
            // 
            // txbx_mileage
            // 
            this.txbx_mileage.Location = new System.Drawing.Point(107, 184);
            this.txbx_mileage.Name = "txbx_mileage";
            this.txbx_mileage.Size = new System.Drawing.Size(228, 20);
            this.txbx_mileage.TabIndex = 35;
            this.txbx_mileage.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Release Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Color";
            // 
            // txbx_color
            // 
            this.txbx_color.Location = new System.Drawing.Point(107, 106);
            this.txbx_color.Name = "txbx_color";
            this.txbx_color.Size = new System.Drawing.Size(228, 20);
            this.txbx_color.TabIndex = 32;
            // 
            // cmbx_driver
            // 
            this.cmbx_driver.DisplayMember = "Name";
            this.cmbx_driver.FormattingEnabled = true;
            this.cmbx_driver.Location = new System.Drawing.Point(107, 79);
            this.cmbx_driver.Name = "cmbx_driver";
            this.cmbx_driver.Size = new System.Drawing.Size(228, 21);
            this.cmbx_driver.TabIndex = 31;
            this.cmbx_driver.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Driver Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "State Number";
            // 
            // txbx_stateNum
            // 
            this.txbx_stateNum.Location = new System.Drawing.Point(107, 52);
            this.txbx_stateNum.Name = "txbx_stateNum";
            this.txbx_stateNum.Size = new System.Drawing.Size(228, 20);
            this.txbx_stateNum.TabIndex = 28;
            this.txbx_stateNum.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // btn_saveVehicle
            // 
            this.btn_saveVehicle.Location = new System.Drawing.Point(260, 287);
            this.btn_saveVehicle.Name = "btn_saveVehicle";
            this.btn_saveVehicle.Size = new System.Drawing.Size(75, 23);
            this.btn_saveVehicle.TabIndex = 27;
            this.btn_saveVehicle.Text = "Сохранить";
            this.btn_saveVehicle.UseVisualStyleBackColor = true;
            this.btn_saveVehicle.Click += new System.EventHandler(this.btn_saveVehicle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Insurance Best Before";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "VIN code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Brand";
            // 
            // dtp_insurance
            // 
            this.dtp_insurance.Location = new System.Drawing.Point(124, 210);
            this.dtp_insurance.Name = "dtp_insurance";
            this.dtp_insurance.Size = new System.Drawing.Size(211, 20);
            this.dtp_insurance.TabIndex = 23;
            // 
            // dtp_releaseDate
            // 
            this.dtp_releaseDate.Location = new System.Drawing.Point(107, 132);
            this.dtp_releaseDate.Name = "dtp_releaseDate";
            this.dtp_releaseDate.Size = new System.Drawing.Size(228, 20);
            this.dtp_releaseDate.TabIndex = 22;
            // 
            // txbx_vinCode
            // 
            this.txbx_vinCode.Location = new System.Drawing.Point(107, 158);
            this.txbx_vinCode.Name = "txbx_vinCode";
            this.txbx_vinCode.Size = new System.Drawing.Size(228, 20);
            this.txbx_vinCode.TabIndex = 21;
            this.txbx_vinCode.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // txbx_brand
            // 
            this.txbx_brand.Location = new System.Drawing.Point(107, 26);
            this.txbx_brand.Name = "txbx_brand";
            this.txbx_brand.Size = new System.Drawing.Size(228, 20);
            this.txbx_brand.TabIndex = 20;
            this.txbx_brand.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // NewEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 353);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewEditVehicle";
            this.Text = "Vehicle Department";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        protected internal System.Windows.Forms.TextBox txbx_mileage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.TextBox txbx_color;
        protected internal System.Windows.Forms.ComboBox cmbx_driver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.TextBox txbx_stateNum;
        private System.Windows.Forms.Button btn_saveVehicle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.DateTimePicker dtp_insurance;
        protected internal System.Windows.Forms.DateTimePicker dtp_releaseDate;
        protected internal System.Windows.Forms.TextBox txbx_vinCode;
        protected internal System.Windows.Forms.TextBox txbx_brand;
        protected internal System.Windows.Forms.TextBox txbx_id;
    }
}