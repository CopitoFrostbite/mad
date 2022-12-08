namespace WinFormsApp1
{
    partial class Recibo
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
            this.gb_ac = new System.Windows.Forms.GroupBox();
            this.rb_not = new System.Windows.Forms.RadioButton();
            this.rb_rec = new System.Windows.Forms.RadioButton();
            this.bt_regr = new System.Windows.Forms.Button();
            this.bt_busr = new System.Windows.Forms.Button();
            this.dg_rec = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_fr = new System.Windows.Forms.DateTimePicker();
            this.cb_cajr = new System.Windows.Forms.ComboBox();
            this.rb_fr = new System.Windows.Forms.RadioButton();
            this.rb_idr = new System.Windows.Forms.RadioButton();
            this.ntb_idr = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_imp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ntb_select = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ntb_selec = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_ac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rec)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_idr)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_selec)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ac
            // 
            this.gb_ac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gb_ac.Controls.Add(this.rb_not);
            this.gb_ac.Controls.Add(this.rb_rec);
            this.gb_ac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_ac.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_ac.Location = new System.Drawing.Point(22, 9);
            this.gb_ac.Name = "gb_ac";
            this.gb_ac.Size = new System.Drawing.Size(247, 59);
            this.gb_ac.TabIndex = 17;
            this.gb_ac.TabStop = false;
            this.gb_ac.Text = "Accion";
            // 
            // rb_not
            // 
            this.rb_not.AutoSize = true;
            this.rb_not.Location = new System.Drawing.Point(107, 22);
            this.rb_not.Name = "rb_not";
            this.rb_not.Size = new System.Drawing.Size(138, 25);
            this.rb_not.TabIndex = 9;
            this.rb_not.Text = "Nota de Credito";
            this.rb_not.UseVisualStyleBackColor = true;
            this.rb_not.CheckedChanged += new System.EventHandler(this.rb_not_CheckedChanged);
            // 
            // rb_rec
            // 
            this.rb_rec.AutoSize = true;
            this.rb_rec.Checked = true;
            this.rb_rec.Location = new System.Drawing.Point(10, 22);
            this.rb_rec.Name = "rb_rec";
            this.rb_rec.Size = new System.Drawing.Size(75, 25);
            this.rb_rec.TabIndex = 8;
            this.rb_rec.TabStop = true;
            this.rb_rec.Text = "Recibo";
            this.rb_rec.UseVisualStyleBackColor = true;
            this.rb_rec.CheckedChanged += new System.EventHandler(this.rb_agr_CheckedChanged);
            // 
            // bt_regr
            // 
            this.bt_regr.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_regr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_regr.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_regr.Location = new System.Drawing.Point(768, 461);
            this.bt_regr.Name = "bt_regr";
            this.bt_regr.Size = new System.Drawing.Size(130, 30);
            this.bt_regr.TabIndex = 16;
            this.bt_regr.Text = "Regresar";
            this.bt_regr.UseVisualStyleBackColor = false;
            this.bt_regr.Click += new System.EventHandler(this.bt_regr_Click);
            // 
            // bt_busr
            // 
            this.bt_busr.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_busr.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_busr.Location = new System.Drawing.Point(525, 59);
            this.bt_busr.Name = "bt_busr";
            this.bt_busr.Size = new System.Drawing.Size(130, 30);
            this.bt_busr.TabIndex = 15;
            this.bt_busr.Text = "Buscar";
            this.bt_busr.UseVisualStyleBackColor = false;
            this.bt_busr.Click += new System.EventHandler(this.bt_busr_Click);
            // 
            // dg_rec
            // 
            this.dg_rec.AllowUserToAddRows = false;
            this.dg_rec.AllowUserToDeleteRows = false;
            this.dg_rec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_rec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
<<<<<<< HEAD
            this.dg_rec.Location = new System.Drawing.Point(22, 199);
=======
=======
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_rec.Location = new System.Drawing.Point(22, 192);
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_rec.MultiSelect = false;
            this.dg_rec.Name = "dg_rec";
            this.dg_rec.ReadOnly = true;
            this.dg_rec.RowTemplate.Height = 25;
            this.dg_rec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_rec.Size = new System.Drawing.Size(676, 292);
            this.dg_rec.TabIndex = 13;
            this.dg_rec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_rec_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dt_fr);
            this.groupBox1.Controls.Add(this.cb_cajr);
            this.groupBox1.Controls.Add(this.rb_fr);
            this.groupBox1.Controls.Add(this.bt_busr);
            this.groupBox1.Controls.Add(this.rb_idr);
            this.groupBox1.Controls.Add(this.ntb_idr);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(22, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 97);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fecha:";
            // 
            // dt_fr
            // 
            this.dt_fr.CustomFormat = "yyyy-MM-dd";
            this.dt_fr.Enabled = false;
            this.dt_fr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fr.Location = new System.Drawing.Point(175, 59);
            this.dt_fr.Name = "dt_fr";
            this.dt_fr.Size = new System.Drawing.Size(136, 29);
            this.dt_fr.TabIndex = 32;
            this.dt_fr.ValueChanged += new System.EventHandler(this.dt_fr_ValueChanged);
            // 
            // cb_cajr
            // 
            this.cb_cajr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cajr.FormattingEnabled = true;
            this.cb_cajr.Location = new System.Drawing.Point(377, 59);
            this.cb_cajr.Name = "cb_cajr";
            this.cb_cajr.Size = new System.Drawing.Size(121, 29);
            this.cb_cajr.TabIndex = 27;
            // 
            // rb_fr
            // 
            this.rb_fr.AutoSize = true;
            this.rb_fr.Location = new System.Drawing.Point(61, 24);
            this.rb_fr.Name = "rb_fr";
            this.rb_fr.Size = new System.Drawing.Size(111, 25);
            this.rb_fr.TabIndex = 24;
            this.rb_fr.Text = "Fecha y caja";
            this.rb_fr.UseVisualStyleBackColor = true;
            this.rb_fr.CheckedChanged += new System.EventHandler(this.rb_fr_CheckedChanged);
            // 
            // rb_idr
            // 
            this.rb_idr.AutoSize = true;
            this.rb_idr.Checked = true;
            this.rb_idr.Location = new System.Drawing.Point(10, 24);
            this.rb_idr.Name = "rb_idr";
            this.rb_idr.Size = new System.Drawing.Size(43, 25);
            this.rb_idr.TabIndex = 25;
            this.rb_idr.TabStop = true;
            this.rb_idr.Text = "ID";
            this.rb_idr.UseVisualStyleBackColor = true;
            this.rb_idr.CheckedChanged += new System.EventHandler(this.rb_idr_CheckedChanged);
            // 
            // ntb_idr
            // 
            this.ntb_idr.Location = new System.Drawing.Point(38, 59);
            this.ntb_idr.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_idr.Name = "ntb_idr";
            this.ntb_idr.Size = new System.Drawing.Size(55, 29);
            this.ntb_idr.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Caja:";
            // 
            // bt_imp
            // 
            this.bt_imp.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_imp.Location = new System.Drawing.Point(30, 126);
            this.bt_imp.Name = "bt_imp";
            this.bt_imp.Size = new System.Drawing.Size(130, 30);
            this.bt_imp.TabIndex = 18;
            this.bt_imp.Text = "Imprimir";
            this.bt_imp.UseVisualStyleBackColor = false;
            this.bt_imp.Click += new System.EventHandler(this.bt_imp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.ntb_select);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ntb_selec);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bt_imp);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(738, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 173);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imprimir Recibo/Nota";
            // 
            // ntb_select
            // 
            this.ntb_select.Location = new System.Drawing.Point(82, 78);
            this.ntb_select.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_select.Name = "ntb_select";
            this.ntb_select.Size = new System.Drawing.Size(55, 29);
            this.ntb_select.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Total:";
            // 
            // ntb_selec
            // 
            this.ntb_selec.Location = new System.Drawing.Point(82, 32);
            this.ntb_selec.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_selec.Name = "ntb_selec";
            this.ntb_selec.Size = new System.Drawing.Size(55, 29);
            this.ntb_selec.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Numero:";
            // 
            // Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(925, 509);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_ac);
            this.Controls.Add(this.bt_regr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_rec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Recibo";
            this.Text = "Recibo";
            this.gb_ac.ResumeLayout(false);
            this.gb_ac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_idr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_selec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_ac;
        private RadioButton rb_not;
        private RadioButton rb_rec;
        private Button bt_regr;
        private Button bt_busr;
        private DataGridView dg_rec;
        private GroupBox groupBox1;
        private RadioButton rb_fr;
        private RadioButton rb_idr;
        private NumericUpDown ntb_idr;
        private Label label10;
        private Label label11;
        private ComboBox cb_cajr;
        private DateTimePicker dt_fr;
        private Button bt_imp;
        private Label label1;
        private GroupBox groupBox2;
        private NumericUpDown ntb_selec;
        private Label label2;
        private NumericUpDown ntb_select;
        private Label label3;
    }
}