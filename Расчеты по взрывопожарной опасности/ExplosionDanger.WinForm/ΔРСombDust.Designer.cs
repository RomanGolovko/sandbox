namespace ExplosionDanger.WinForm
{
    partial class ΔРСombDust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ΔРСombDust));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_F = new System.Windows.Forms.TextBox();
            this.txbx_Hт = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_Vсвоб = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbx_Pв = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbx_Kвз = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_T0 = new System.Windows.Forms.TextBox();
            this.txbx_τ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbx_q = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbx_mап = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbx_Kп = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbx_Kубор = new System.Windows.Forms.TextBox();
            this.txbx_n = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbx_Kг = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txbx_β1 = new System.Windows.Forms.TextBox();
            this.txbx_β2 = new System.Windows.Forms.TextBox();
            this.txbx_M2j = new System.Windows.Forms.TextBox();
            this.txbx_M1j = new System.Windows.Forms.TextBox();
            this.txbx_α = new System.Windows.Forms.TextBox();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.txbx_result = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Теплота сгорания, Hт:";
            // 
            // txbx_F
            // 
            this.txbx_F.Location = new System.Drawing.Point(401, 85);
            this.txbx_F.Name = "txbx_F";
            this.txbx_F.Size = new System.Drawing.Size(75, 20);
            this.txbx_F.TabIndex = 3;
            this.txbx_F.Text = "1";
            this.txbx_F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_F.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // txbx_Hт
            // 
            this.txbx_Hт.Location = new System.Drawing.Point(831, 21);
            this.txbx_Hт.Name = "txbx_Hт";
            this.txbx_Hт.Size = new System.Drawing.Size(75, 20);
            this.txbx_Hт.TabIndex = 1;
            this.txbx_Hт.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_Hт.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Свободный объем помещения, Vсвоб:";
            // 
            // txbx_Vсвоб
            // 
            this.txbx_Vсвоб.Location = new System.Drawing.Point(831, 53);
            this.txbx_Vсвоб.Name = "txbx_Vсвоб";
            this.txbx_Vсвоб.Size = new System.Drawing.Size(75, 20);
            this.txbx_Vсвоб.TabIndex = 2;
            this.txbx_Vсвоб.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_Vсвоб.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Плотность воздуха до взрыва, Pв:";
            // 
            // txbx_Pв
            // 
            this.txbx_Pв.Location = new System.Drawing.Point(831, 85);
            this.txbx_Pв.Name = "txbx_Pв";
            this.txbx_Pв.Size = new System.Drawing.Size(75, 20);
            this.txbx_Pв.TabIndex = 4;
            this.txbx_Pв.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_Pв.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 52);
            this.label4.TabIndex = 10;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // txbx_Kвз
            // 
            this.txbx_Kвз.Location = new System.Drawing.Point(401, 156);
            this.txbx_Kвз.Name = "txbx_Kвз";
            this.txbx_Kвз.Size = new System.Drawing.Size(75, 20);
            this.txbx_Kвз.TabIndex = 6;
            this.txbx_Kвз.Text = "0,9";
            this.txbx_Kвз.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_Kвз.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Начальная температура воздуха, T0:";
            // 
            // txbx_T0
            // 
            this.txbx_T0.Location = new System.Drawing.Point(831, 120);
            this.txbx_T0.Name = "txbx_T0";
            this.txbx_T0.Size = new System.Drawing.Size(75, 20);
            this.txbx_T0.TabIndex = 5;
            this.txbx_T0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_T0.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // txbx_τ
            // 
            this.txbx_τ.Location = new System.Drawing.Point(831, 156);
            this.txbx_τ.Name = "txbx_τ";
            this.txbx_τ.Size = new System.Drawing.Size(75, 20);
            this.txbx_τ.TabIndex = 7;
            this.txbx_τ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_τ.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Время перекрывания, которое определяется по п. 7.1. 2 в, τ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(317, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Масса горючей пыли, которая поступает в помещение из \r\nаппарата, (принимают в соо" +
    "тветствии с п. 7.1.1 и 7.1.3), mап;";
            // 
            // txbx_q
            // 
            this.txbx_q.Location = new System.Drawing.Point(401, 203);
            this.txbx_q.Name = "txbx_q";
            this.txbx_q.Size = new System.Drawing.Size(75, 20);
            this.txbx_q.TabIndex = 8;
            this.txbx_q.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_q.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(356, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Расход, с которым продолжают поступать пылевидные вещества в \r\nаварийный аппаратп" +
    "о трубопроводам до момента их перекрытия, q:";
            // 
            // txbx_mап
            // 
            this.txbx_mап.Location = new System.Drawing.Point(831, 203);
            this.txbx_mап.Name = "txbx_mап";
            this.txbx_mап.Size = new System.Drawing.Size(75, 20);
            this.txbx_mап.TabIndex = 9;
            this.txbx_mап.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_mап.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(364, 78);
            this.label10.TabIndex = 20;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // txbx_Kп
            // 
            this.txbx_Kп.Location = new System.Drawing.Point(401, 304);
            this.txbx_Kп.Name = "txbx_Kп";
            this.txbx_Kп.Size = new System.Drawing.Size(75, 20);
            this.txbx_Kп.TabIndex = 10;
            this.txbx_Kп.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_Kп.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(508, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 91);
            this.label11.TabIndex = 22;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // txbx_Kубор
            // 
            this.txbx_Kубор.Location = new System.Drawing.Point(831, 304);
            this.txbx_Kубор.Name = "txbx_Kубор";
            this.txbx_Kубор.Size = new System.Drawing.Size(75, 20);
            this.txbx_Kубор.TabIndex = 11;
            this.txbx_Kубор.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_Kубор.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // txbx_n
            // 
            this.txbx_n.Location = new System.Drawing.Point(831, 343);
            this.txbx_n.Name = "txbx_n";
            this.txbx_n.Size = new System.Drawing.Size(75, 20);
            this.txbx_n.TabIndex = 13;
            this.txbx_n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_n.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(309, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Доля горючей пыли в общей массе собравшейся пыли, Kг:";
            // 
            // txbx_Kг
            // 
            this.txbx_Kг.Location = new System.Drawing.Point(401, 343);
            this.txbx_Kг.Name = "txbx_Kг";
            this.txbx_Kг.Size = new System.Drawing.Size(75, 20);
            this.txbx_Kг.TabIndex = 12;
            this.txbx_Kг.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_Kг.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(508, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(275, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Количество едениц оборудования, которое пылит, n:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(335, 26);
            this.label14.TabIndex = 28;
            this.label14.Text = "Доля выделяющейся в объем помещения пыли, оседающей на \r\nтруднодоступных для убор" +
    "ки поверхностях помещения, β1:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(508, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(317, 26);
            this.label15.TabIndex = 29;
            this.label15.Text = "Доля выделяющейся в объем помещения пыли, оседающей\r\nна доступных для уборки пове" +
    "рхностях помещения, β2:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(508, 412);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(311, 26);
            this.label16.TabIndex = 30;
            this.label16.Text = "Масса пыли, которая попадает в объем помещения за \r\nпериод времени между генераль" +
    "ными уборками пыли, M1j:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 412);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(355, 26);
            this.label17.TabIndex = 31;
            this.label17.Text = "Масса пыли, которая выделяется единицей оборудования, которое \r\nпылит, за период " +
    "времени между текущими уборками, M2j:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 454);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(601, 26);
            this.label18.TabIndex = 32;
            this.label18.Text = "Доля пыли, которая попадает в объем помещения и которая удаляется вытяжными венти" +
    "ляционными системами. \r\n(В случае отсутствия экспериментальных данных принимают " +
    "α = 0):";
            // 
            // txbx_β1
            // 
            this.txbx_β1.Location = new System.Drawing.Point(401, 380);
            this.txbx_β1.Name = "txbx_β1";
            this.txbx_β1.Size = new System.Drawing.Size(75, 20);
            this.txbx_β1.TabIndex = 14;
            this.txbx_β1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_β1.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // txbx_β2
            // 
            this.txbx_β2.Location = new System.Drawing.Point(831, 380);
            this.txbx_β2.Name = "txbx_β2";
            this.txbx_β2.Size = new System.Drawing.Size(75, 20);
            this.txbx_β2.TabIndex = 15;
            this.txbx_β2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_β2.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // txbx_M2j
            // 
            this.txbx_M2j.Location = new System.Drawing.Point(401, 420);
            this.txbx_M2j.Name = "txbx_M2j";
            this.txbx_M2j.Size = new System.Drawing.Size(75, 20);
            this.txbx_M2j.TabIndex = 16;
            this.txbx_M2j.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_M2j.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // txbx_M1j
            // 
            this.txbx_M1j.Location = new System.Drawing.Point(831, 420);
            this.txbx_M1j.Name = "txbx_M1j";
            this.txbx_M1j.Size = new System.Drawing.Size(75, 20);
            this.txbx_M1j.TabIndex = 17;
            this.txbx_M1j.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_M1j.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // txbx_α
            // 
            this.txbx_α.Location = new System.Drawing.Point(831, 462);
            this.txbx_α.Name = "txbx_α";
            this.txbx_α.Size = new System.Drawing.Size(75, 20);
            this.txbx_α.TabIndex = 18;
            this.txbx_α.Text = "0";
            this.txbx_α.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.txbx_α.Leave += new System.EventHandler(this.txbx_Leave);
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Location = new System.Drawing.Point(831, 496);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(0, 13);
            this.lbl_warning.TabIndex = 104;
            // 
            // txbx_result
            // 
            this.txbx_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_result.Location = new System.Drawing.Point(511, 497);
            this.txbx_result.Name = "txbx_result";
            this.txbx_result.ReadOnly = true;
            this.txbx_result.Size = new System.Drawing.Size(314, 29);
            this.txbx_result.TabIndex = 103;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(15, 496);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(459, 30);
            this.btn_calculate.TabIndex = 19;
            this.btn_calculate.Text = "Расчитать избыточное давление взрыва ΔР для для горючей пыли\r\n";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // ΔРСombDust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(934, 538);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.txbx_result);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txbx_α);
            this.Controls.Add(this.txbx_M1j);
            this.Controls.Add(this.txbx_M2j);
            this.Controls.Add(this.txbx_β2);
            this.Controls.Add(this.txbx_β1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbx_Kг);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbx_n);
            this.Controls.Add(this.txbx_Kубор);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbx_Kп);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbx_mап);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbx_q);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbx_τ);
            this.Controls.Add(this.txbx_T0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbx_Kвз);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbx_Pв);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_Vсвоб);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbx_Hт);
            this.Controls.Add(this.txbx_F);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ΔРСombDust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Избыточное давления взрыва для горючей пыли";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_KeyPress);
            this.Leave += new System.EventHandler(this.txbx_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_F;
        private System.Windows.Forms.TextBox txbx_Hт;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_Vсвоб;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbx_Pв;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbx_Kвз;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_T0;
        private System.Windows.Forms.TextBox txbx_τ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbx_q;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbx_mап;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbx_Kп;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbx_Kубор;
        private System.Windows.Forms.TextBox txbx_n;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbx_Kг;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbx_β1;
        private System.Windows.Forms.TextBox txbx_β2;
        private System.Windows.Forms.TextBox txbx_M2j;
        private System.Windows.Forms.TextBox txbx_M1j;
        private System.Windows.Forms.TextBox txbx_α;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.TextBox txbx_result;
        private System.Windows.Forms.Button btn_calculate;
    }
}