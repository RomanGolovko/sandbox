namespace Garage.Presentation
{
    partial class ChoosingDB
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
            this.grpbx_choosingDB = new System.Windows.Forms.GroupBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.rbtn_mySQL = new System.Windows.Forms.RadioButton();
            this.rbtn_LiteDB = new System.Windows.Forms.RadioButton();
            this.grpbx_choosingDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_choosingDB
            // 
            this.grpbx_choosingDB.Controls.Add(this.btn_ok);
            this.grpbx_choosingDB.Controls.Add(this.rbtn_mySQL);
            this.grpbx_choosingDB.Controls.Add(this.rbtn_LiteDB);
            this.grpbx_choosingDB.Location = new System.Drawing.Point(13, 13);
            this.grpbx_choosingDB.Name = "grpbx_choosingDB";
            this.grpbx_choosingDB.Size = new System.Drawing.Size(196, 146);
            this.grpbx_choosingDB.TabIndex = 0;
            this.grpbx_choosingDB.TabStop = false;
            this.grpbx_choosingDB.Text = "Vehicle Department";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(115, 117);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // rbtn_mySQL
            // 
            this.rbtn_mySQL.AutoSize = true;
            this.rbtn_mySQL.Location = new System.Drawing.Point(6, 67);
            this.rbtn_mySQL.Name = "rbtn_mySQL";
            this.rbtn_mySQL.Size = new System.Drawing.Size(60, 17);
            this.rbtn_mySQL.TabIndex = 1;
            this.rbtn_mySQL.Text = "MySQL";
            this.rbtn_mySQL.UseVisualStyleBackColor = true;
            // 
            // rbtn_LiteDB
            // 
            this.rbtn_LiteDB.AutoSize = true;
            this.rbtn_LiteDB.Checked = true;
            this.rbtn_LiteDB.Location = new System.Drawing.Point(6, 44);
            this.rbtn_LiteDB.Name = "rbtn_LiteDB";
            this.rbtn_LiteDB.Size = new System.Drawing.Size(57, 17);
            this.rbtn_LiteDB.TabIndex = 0;
            this.rbtn_LiteDB.TabStop = true;
            this.rbtn_LiteDB.Text = "LiteDB";
            this.rbtn_LiteDB.UseVisualStyleBackColor = true;
            // 
            // ChoosingDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 175);
            this.Controls.Add(this.grpbx_choosingDB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoosingDB";
            this.Text = "Data Base";
            this.grpbx_choosingDB.ResumeLayout(false);
            this.grpbx_choosingDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_choosingDB;
        private System.Windows.Forms.Button btn_ok;
        internal System.Windows.Forms.RadioButton rbtn_mySQL;
        internal System.Windows.Forms.RadioButton rbtn_LiteDB;
    }
}