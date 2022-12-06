namespace WinFormsApp1
{
    partial class Reportes
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
            this.rb_ven = new System.Windows.Forms.RadioButton();
            this.rb_inv = new System.Windows.Forms.RadioButton();
            this.rb_caj = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_rep = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dt_ffin = new System.Windows.Forms.DateTimePicker();
            this.dt_fini = new System.Windows.Forms.DateTimePicker();
            this.cb_caj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_em = new System.Windows.Forms.CheckBox();
            this.cb_metr = new System.Windows.Forms.ComboBox();
            this.cb_mer = new System.Windows.Forms.CheckBox();
            this.cb_ago = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_bus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rep)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_ven
            // 
            this.rb_ven.AutoSize = true;
            this.rb_ven.Location = new System.Drawing.Point(15, 22);
            this.rb_ven.Name = "rb_ven";
            this.rb_ven.Size = new System.Drawing.Size(119, 19);
            this.rb_ven.TabIndex = 0;
            this.rb_ven.TabStop = true;
            this.rb_ven.Text = "Reporte de Ventas";
            this.rb_ven.UseVisualStyleBackColor = true;
            this.rb_ven.CheckedChanged += new System.EventHandler(this.rb_ven_CheckedChanged);
            // 
            // rb_inv
            // 
            this.rb_inv.AutoSize = true;
            this.rb_inv.Location = new System.Drawing.Point(137, 22);
            this.rb_inv.Name = "rb_inv";
            this.rb_inv.Size = new System.Drawing.Size(138, 19);
            this.rb_inv.TabIndex = 1;
            this.rb_inv.TabStop = true;
            this.rb_inv.Text = "Reporte de Inventario";
            this.rb_inv.UseVisualStyleBackColor = true;
            this.rb_inv.CheckedChanged += new System.EventHandler(this.rb_inv_CheckedChanged);
            // 
            // rb_caj
            // 
            this.rb_caj.AutoSize = true;
            this.rb_caj.Location = new System.Drawing.Point(285, 22);
            this.rb_caj.Name = "rb_caj";
            this.rb_caj.Size = new System.Drawing.Size(108, 19);
            this.rb_caj.TabIndex = 2;
            this.rb_caj.TabStop = true;
            this.rb_caj.Text = "Reporte de Caja";
            this.rb_caj.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_ven);
            this.groupBox1.Controls.Add(this.rb_caj);
            this.groupBox1.Controls.Add(this.rb_inv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes";
            // 
            // dg_rep
            // 
            this.dg_rep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_rep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rep.Location = new System.Drawing.Point(18, 240);
            this.dg_rep.MultiSelect = false;
            this.dg_rep.Name = "dg_rep";
            this.dg_rep.ReadOnly = true;
            this.dg_rep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_rep.Size = new System.Drawing.Size(855, 405);
            this.dg_rep.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(798, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dt_ffin);
            this.groupBox3.Controls.Add(this.dt_fini);
            this.groupBox3.Controls.Add(this.cb_caj);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cb_em);
            this.groupBox3.Controls.Add(this.cb_metr);
            this.groupBox3.Controls.Add(this.cb_mer);
            this.groupBox3.Controls.Add(this.cb_ago);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(746, 125);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // dt_ffin
            // 
            this.dt_ffin.CustomFormat = "yyyy-MM-dd";
            this.dt_ffin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ffin.Location = new System.Drawing.Point(583, 24);
            this.dt_ffin.Name = "dt_ffin";
            this.dt_ffin.Size = new System.Drawing.Size(119, 23);
            this.dt_ffin.TabIndex = 34;
            // 
            // dt_fini
            // 
            this.dt_fini.CustomFormat = "yyyy-MM-dd";
            this.dt_fini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fini.Location = new System.Drawing.Point(427, 24);
            this.dt_fini.Name = "dt_fini";
            this.dt_fini.Size = new System.Drawing.Size(119, 23);
            this.dt_fini.TabIndex = 33;
            // 
            // cb_caj
            // 
            this.cb_caj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_caj.FormattingEnabled = true;
            this.cb_caj.Location = new System.Drawing.Point(291, 22);
            this.cb_caj.Name = "cb_caj";
            this.cb_caj.Size = new System.Drawing.Size(104, 23);
            this.cb_caj.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Caja:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_em
            // 
            this.cb_em.AutoSize = true;
            this.cb_em.Location = new System.Drawing.Point(427, 24);
            this.cb_em.Name = "cb_em";
            this.cb_em.Size = new System.Drawing.Size(122, 19);
            this.cb_em.TabIndex = 25;
            this.cb_em.Text = "Existencia Minima";
            this.cb_em.UseVisualStyleBackColor = true;
            // 
            // cb_metr
            // 
            this.cb_metr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_metr.FormattingEnabled = true;
            this.cb_metr.Location = new System.Drawing.Point(117, 22);
            this.cb_metr.Name = "cb_metr";
            this.cb_metr.Size = new System.Drawing.Size(104, 23);
            this.cb_metr.TabIndex = 23;
            // 
            // cb_mer
            // 
            this.cb_mer.AutoSize = true;
            this.cb_mer.Location = new System.Drawing.Point(629, 24);
            this.cb_mer.Name = "cb_mer";
            this.cb_mer.Size = new System.Drawing.Size(89, 19);
            this.cb_mer.TabIndex = 6;
            this.cb_mer.Text = "Con Merma";
            this.cb_mer.UseVisualStyleBackColor = true;
            // 
            // cb_ago
            // 
            this.cb_ago.AutoSize = true;
            this.cb_ago.Location = new System.Drawing.Point(285, 24);
            this.cb_ago.Name = "cb_ago";
            this.cb_ago.Size = new System.Drawing.Size(72, 19);
            this.cb_ago.TabIndex = 5;
            this.cb_ago.Text = "Agotado";
            this.cb_ago.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Departamento:";
            // 
            // bt_bus
            // 
            this.bt_bus.Location = new System.Drawing.Point(798, 116);
            this.bt_bus.Name = "bt_bus";
            this.bt_bus.Size = new System.Drawing.Size(75, 23);
            this.bt_bus.TabIndex = 21;
            this.bt_bus.Text = "Buscar:";
            this.bt_bus.UseVisualStyleBackColor = true;
            this.bt_bus.Click += new System.EventHandler(this.bt_bus_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 663);
            this.ControlBox = false;
            this.Controls.Add(this.bt_bus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dg_rep);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rep)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton rb_ven;
        private RadioButton rb_inv;
        private RadioButton rb_caj;
        private GroupBox groupBox1;
        private DataGridView dg_rep;
        private Button button4;
        private GroupBox groupBox3;
        private CheckBox cb_mer;
        private CheckBox cb_ago;
        private Label label11;
        private ComboBox cb_metr;
        private CheckBox cb_em;
        private Button bt_bus;
        private ComboBox cb_caj;
        private Label label1;
        private DateTimePicker dt_ffin;
        private DateTimePicker dt_fini;
    }
}