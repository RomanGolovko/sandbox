namespace ExplosionDanger.WinForm
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
            this.grpbx_main = new System.Windows.Forms.GroupBox();
            this.btn_fireLoad = new System.Windows.Forms.Button();
            this.btn_ΔР_combustibleDust = new System.Windows.Forms.Button();
            this.btn_ΔР_withOut = new System.Windows.Forms.Button();
            this.btn_ΔР_with = new System.Windows.Forms.Button();
            this.btn_q = new System.Windows.Forms.Button();
            this.grpbx_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_main
            // 
            this.grpbx_main.Controls.Add(this.btn_q);
            this.grpbx_main.Controls.Add(this.btn_fireLoad);
            this.grpbx_main.Controls.Add(this.btn_ΔР_combustibleDust);
            this.grpbx_main.Controls.Add(this.btn_ΔР_withOut);
            this.grpbx_main.Controls.Add(this.btn_ΔР_with);
            this.grpbx_main.Location = new System.Drawing.Point(13, 13);
            this.grpbx_main.Name = "grpbx_main";
            this.grpbx_main.Size = new System.Drawing.Size(687, 284);
            this.grpbx_main.TabIndex = 0;
            this.grpbx_main.TabStop = false;
            this.grpbx_main.Text = "Расчеты";
            // 
            // btn_fireLoad
            // 
            this.btn_fireLoad.Location = new System.Drawing.Point(6, 156);
            this.btn_fireLoad.Name = "btn_fireLoad";
            this.btn_fireLoad.Size = new System.Drawing.Size(663, 26);
            this.btn_fireLoad.TabIndex = 6;
            this.btn_fireLoad.Text = "Величина пожарной нагрузки";
            this.btn_fireLoad.UseVisualStyleBackColor = true;
            this.btn_fireLoad.Click += new System.EventHandler(this.btn_fireLoad_Click);
            // 
            // btn_ΔР_combustibleDust
            // 
            this.btn_ΔР_combustibleDust.Location = new System.Drawing.Point(6, 114);
            this.btn_ΔР_combustibleDust.Name = "btn_ΔР_combustibleDust";
            this.btn_ΔР_combustibleDust.Size = new System.Drawing.Size(663, 26);
            this.btn_ΔР_combustibleDust.TabIndex = 4;
            this.btn_ΔР_combustibleDust.Text = "Избыточного давления взрыва для горючей пыли";
            this.btn_ΔР_combustibleDust.UseVisualStyleBackColor = true;
            this.btn_ΔР_combustibleDust.Click += new System.EventHandler(this.btn_ΔР_combustibleDust_Click);
            // 
            // btn_ΔР_withOut
            // 
            this.btn_ΔР_withOut.Location = new System.Drawing.Point(6, 71);
            this.btn_ΔР_withOut.Name = "btn_ΔР_withOut";
            this.btn_ΔР_withOut.Size = new System.Drawing.Size(663, 26);
            this.btn_ΔР_withOut.TabIndex = 3;
            this.btn_ΔР_withOut.Text = "Избыточное давление взрыва ΔР для всех остальных индивидуальных горючих веществ";
            this.btn_ΔР_withOut.UseVisualStyleBackColor = true;
            this.btn_ΔР_withOut.Click += new System.EventHandler(this.btn_ΔР_withOut_Click);
            // 
            // btn_ΔР_with
            // 
            this.btn_ΔР_with.Location = new System.Drawing.Point(6, 30);
            this.btn_ΔР_with.Name = "btn_ΔР_with";
            this.btn_ΔР_with.Size = new System.Drawing.Size(663, 26);
            this.btn_ΔР_with.TabIndex = 1;
            this.btn_ΔР_with.Text = "Избыточное давление взрыва ΔР для индивидуальных горючих веществ, которые состоят" +
    " из атомов С, Н, О, N, CI, Br, I, F";
            this.btn_ΔР_with.UseVisualStyleBackColor = true;
            this.btn_ΔР_with.Click += new System.EventHandler(this.btn_ΔР_with_Click);
            // 
            // btn_q
            // 
            this.btn_q.Location = new System.Drawing.Point(6, 205);
            this.btn_q.Name = "btn_q";
            this.btn_q.Size = new System.Drawing.Size(663, 26);
            this.btn_q.TabIndex = 7;
            this.btn_q.Text = "Иинтенсивность теплового излучения\r\n";
            this.btn_q.UseVisualStyleBackColor = true;
            this.btn_q.Click += new System.EventHandler(this.btn_q_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 318);
            this.Controls.Add(this.grpbx_main);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчеты пожарной опасности";
            this.grpbx_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_main;
        private System.Windows.Forms.Button btn_ΔР_with;
        private System.Windows.Forms.Button btn_fireLoad;
        private System.Windows.Forms.Button btn_ΔР_combustibleDust;
        private System.Windows.Forms.Button btn_ΔР_withOut;
        private System.Windows.Forms.Button btn_q;
    }
}

