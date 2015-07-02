namespace ExplosionDanger.WinForm
{
    partial class q
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_F = new System.Windows.Forms.TextBox();
            this.rbtn_лвж = new System.Windows.Forms.RadioButton();
            this.rbtn_ош = new System.Windows.Forms.RadioButton();
            this.grpbx_лвж = new System.Windows.Forms.GroupBox();
            this.txbx_EfЛвж = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_rЛвж = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_Pв = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_Mv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbx_ош = new System.Windows.Forms.GroupBox();
            this.txbx_rОш = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbx_m = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_EfОш = new System.Windows.Forms.TextBox();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.txbx_result = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.grpbx_лвж.SuspendLayout();
            this.grpbx_ош.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Площадь разлива, F: ";
            // 
            // txbx_F
            // 
            this.txbx_F.Location = new System.Drawing.Point(349, 51);
            this.txbx_F.Name = "txbx_F";
            this.txbx_F.Size = new System.Drawing.Size(75, 20);
            this.txbx_F.TabIndex = 1;
            this.txbx_F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_F.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // rbtn_лвж
            // 
            this.rbtn_лвж.AutoSize = true;
            this.rbtn_лвж.Checked = true;
            this.rbtn_лвж.Location = new System.Drawing.Point(12, 24);
            this.rbtn_лвж.Name = "rbtn_лвж";
            this.rbtn_лвж.Size = new System.Drawing.Size(388, 17);
            this.rbtn_лвж.TabIndex = 2;
            this.rbtn_лвж.TabStop = true;
            this.rbtn_лвж.Text = "Горение разлитых ЛВЖ, ГЖ или горение твердых горючих материалов";
            this.rbtn_лвж.UseVisualStyleBackColor = true;
            this.rbtn_лвж.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtn_ош
            // 
            this.rbtn_ош.AutoSize = true;
            this.rbtn_ош.Location = new System.Drawing.Point(485, 24);
            this.rbtn_ош.Name = "rbtn_ош";
            this.rbtn_ош.Size = new System.Drawing.Size(109, 17);
            this.rbtn_ош.TabIndex = 3;
            this.rbtn_ош.Text = "\"Огненный шар\"";
            this.rbtn_ош.UseVisualStyleBackColor = true;
            this.rbtn_ош.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // grpbx_лвж
            // 
            this.grpbx_лвж.Controls.Add(this.txbx_EfЛвж);
            this.grpbx_лвж.Controls.Add(this.label6);
            this.grpbx_лвж.Controls.Add(this.txbx_rЛвж);
            this.grpbx_лвж.Controls.Add(this.label4);
            this.grpbx_лвж.Controls.Add(this.txbx_Pв);
            this.grpbx_лвж.Controls.Add(this.label3);
            this.grpbx_лвж.Controls.Add(this.txbx_Mv);
            this.grpbx_лвж.Controls.Add(this.label2);
            this.grpbx_лвж.Controls.Add(this.label1);
            this.grpbx_лвж.Controls.Add(this.txbx_F);
            this.grpbx_лвж.Location = new System.Drawing.Point(12, 48);
            this.grpbx_лвж.Name = "grpbx_лвж";
            this.grpbx_лвж.Size = new System.Drawing.Size(430, 180);
            this.grpbx_лвж.TabIndex = 4;
            this.grpbx_лвж.TabStop = false;
            // 
            // txbx_EfЛвж
            // 
            this.txbx_EfЛвж.Location = new System.Drawing.Point(349, 25);
            this.txbx_EfЛвж.Name = "txbx_EfЛвж";
            this.txbx_EfЛвж.Size = new System.Drawing.Size(75, 20);
            this.txbx_EfЛвж.TabIndex = 9;
            this.txbx_EfЛвж.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_EfЛвж.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Среднеповерхностная плотность теплового потока излучения\r\nпламени, Ef: ";
            // 
            // txbx_rЛвж
            // 
            this.txbx_rЛвж.Location = new System.Drawing.Point(349, 141);
            this.txbx_rЛвж.Name = "txbx_rЛвж";
            this.txbx_rЛвж.Size = new System.Drawing.Size(75, 20);
            this.txbx_rЛвж.TabIndex = 7;
            this.txbx_rЛвж.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_rЛвж.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Расстояние от геометрического центра пролива до облучаемого \r\nобъекта, r:";
            // 
            // txbx_Pв
            // 
            this.txbx_Pв.Location = new System.Drawing.Point(349, 103);
            this.txbx_Pв.Name = "txbx_Pв";
            this.txbx_Pв.Size = new System.Drawing.Size(75, 20);
            this.txbx_Pв.TabIndex = 5;
            this.txbx_Pв.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_Pв.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Плотность окружающего воздуха, Pв:";
            // 
            // txbx_Mv
            // 
            this.txbx_Mv.Location = new System.Drawing.Point(349, 77);
            this.txbx_Mv.Name = "txbx_Mv";
            this.txbx_Mv.Size = new System.Drawing.Size(75, 20);
            this.txbx_Mv.TabIndex = 3;
            this.txbx_Mv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_Mv.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Удельная массовая скорость выгорания топлива, Mv:";
            // 
            // grpbx_ош
            // 
            this.grpbx_ош.Controls.Add(this.txbx_rОш);
            this.grpbx_ош.Controls.Add(this.label8);
            this.grpbx_ош.Controls.Add(this.txbx_m);
            this.grpbx_ош.Controls.Add(this.label7);
            this.grpbx_ош.Controls.Add(this.label5);
            this.grpbx_ош.Controls.Add(this.txbx_EfОш);
            this.grpbx_ош.Location = new System.Drawing.Point(485, 48);
            this.grpbx_ош.Name = "grpbx_ош";
            this.grpbx_ош.Size = new System.Drawing.Size(430, 180);
            this.grpbx_ош.TabIndex = 5;
            this.grpbx_ош.TabStop = false;
            // 
            // txbx_rОш
            // 
            this.txbx_rОш.Location = new System.Drawing.Point(349, 89);
            this.txbx_rОш.Name = "txbx_rОш";
            this.txbx_rОш.Size = new System.Drawing.Size(75, 20);
            this.txbx_rОш.TabIndex = 10;
            this.txbx_rОш.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_rОш.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Расстояние от облучаемого объекта до точки на поверхности\r\nземли непосредственно " +
    "под центром \"огненного шара\", r:\r\n";
            // 
            // txbx_m
            // 
            this.txbx_m.Location = new System.Drawing.Point(349, 51);
            this.txbx_m.Name = "txbx_m";
            this.txbx_m.Size = new System.Drawing.Size(75, 20);
            this.txbx_m.TabIndex = 10;
            this.txbx_m.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_m.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Масса горючего вещества, m:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Среднеповерхностная плотность теплового потока излучения\r\nпламени, (допускаетсяпр" +
    "инимать Ef  равной 450):\r\n ";
            // 
            // txbx_EfОш
            // 
            this.txbx_EfОш.Location = new System.Drawing.Point(349, 25);
            this.txbx_EfОш.Name = "txbx_EfОш";
            this.txbx_EfОш.Size = new System.Drawing.Size(75, 20);
            this.txbx_EfОш.TabIndex = 8;
            this.txbx_EfОш.Text = "450";
            this.txbx_EfОш.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_EfОш.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Location = new System.Drawing.Point(805, 264);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(0, 13);
            this.lbl_warning.TabIndex = 107;
            // 
            // txbx_result
            // 
            this.txbx_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_result.Location = new System.Drawing.Point(485, 265);
            this.txbx_result.Name = "txbx_result";
            this.txbx_result.ReadOnly = true;
            this.txbx_result.Size = new System.Drawing.Size(285, 29);
            this.txbx_result.TabIndex = 106;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(12, 264);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(430, 30);
            this.btn_calculate.TabIndex = 105;
            this.btn_calculate.Text = "Расчитать избыточное давление взрыва ΔР для для горючей пыли\r\n";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // q
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(929, 316);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.txbx_result);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.grpbx_ош);
            this.Controls.Add(this.grpbx_лвж);
            this.Controls.Add(this.rbtn_ош);
            this.Controls.Add(this.rbtn_лвж);
            this.Name = "q";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интенсивность теплового излучения";
            this.grpbx_лвж.ResumeLayout(false);
            this.grpbx_лвж.PerformLayout();
            this.grpbx_ош.ResumeLayout(false);
            this.grpbx_ош.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_F;
        private System.Windows.Forms.RadioButton rbtn_лвж;
        private System.Windows.Forms.RadioButton rbtn_ош;
        private System.Windows.Forms.GroupBox grpbx_лвж;
        private System.Windows.Forms.GroupBox grpbx_ош;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_Mv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_rЛвж;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_Pв;
        private System.Windows.Forms.TextBox txbx_EfЛвж;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_EfОш;
        private System.Windows.Forms.TextBox txbx_rОш;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbx_m;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.TextBox txbx_result;
        private System.Windows.Forms.Button btn_calculate;
    }
}