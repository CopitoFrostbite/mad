namespace WinFormsApp1
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_US = new System.Windows.Forms.Label();
            this.bt_usu = new System.Windows.Forms.Button();
            this.bt_caja = new System.Windows.Forms.Button();
            this.bt_inv = new System.Windows.Forms.Button();
            this.gb_ges = new System.Windows.Forms.GroupBox();
            this.bt_ven = new System.Windows.Forms.Button();
            this.bt_rep = new System.Windows.Forms.Button();
            this.bt_reg = new System.Windows.Forms.Button();
            this.cb_caj = new System.Windows.Forms.ComboBox();
            this.lb_caj = new System.Windows.Forms.Label();
            this.bt_ti = new System.Windows.Forms.Button();
            this.bt_rec = new System.Windows.Forms.Button();
            this.bt_devol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_ges.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(505, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventario en punto de reorden";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_US
            // 
            this.lb_US.AutoSize = true;
            this.lb_US.Location = new System.Drawing.Point(12, 9);
            this.lb_US.Name = "lb_US";
            this.lb_US.Size = new System.Drawing.Size(122, 15);
            this.lb_US.TabIndex = 2;
            this.lb_US.Text = "Bienvenido: \"Usuario\"";
            this.lb_US.Click += new System.EventHandler(this.label2_Click);
            // 
            // bt_usu
            // 
            this.bt_usu.Location = new System.Drawing.Point(19, 22);
            this.bt_usu.Name = "bt_usu";
            this.bt_usu.Size = new System.Drawing.Size(75, 23);
            this.bt_usu.TabIndex = 3;
            this.bt_usu.Text = "Usuarios";
            this.bt_usu.UseVisualStyleBackColor = true;
            this.bt_usu.Click += new System.EventHandler(this.Personal_Click);
            // 
            // bt_caja
            // 
            this.bt_caja.Location = new System.Drawing.Point(19, 67);
            this.bt_caja.Name = "bt_caja";
            this.bt_caja.Size = new System.Drawing.Size(75, 23);
            this.bt_caja.TabIndex = 4;
            this.bt_caja.Text = "Cajas";
            this.bt_caja.UseVisualStyleBackColor = true;
            this.bt_caja.Click += new System.EventHandler(this.bt_caja_Click);
            // 
            // bt_inv
            // 
            this.bt_inv.Location = new System.Drawing.Point(19, 113);
            this.bt_inv.Name = "bt_inv";
            this.bt_inv.Size = new System.Drawing.Size(75, 23);
            this.bt_inv.TabIndex = 5;
            this.bt_inv.Text = "Inventario";
            this.bt_inv.UseVisualStyleBackColor = true;
            this.bt_inv.Click += new System.EventHandler(this.bt_inv_Click);
            // 
            // gb_ges
            // 
            this.gb_ges.Controls.Add(this.bt_usu);
            this.gb_ges.Controls.Add(this.bt_inv);
            this.gb_ges.Controls.Add(this.bt_caja);
            this.gb_ges.Location = new System.Drawing.Point(568, 127);
            this.gb_ges.Name = "gb_ges";
            this.gb_ges.Size = new System.Drawing.Size(115, 156);
            this.gb_ges.TabIndex = 6;
            this.gb_ges.TabStop = false;
            this.gb_ges.Text = "Gestion";
            this.gb_ges.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_ven
            // 
            this.bt_ven.Location = new System.Drawing.Point(585, 67);
            this.bt_ven.Name = "bt_ven";
            this.bt_ven.Size = new System.Drawing.Size(75, 23);
            this.bt_ven.TabIndex = 3;
            this.bt_ven.Text = "Ventas";
            this.bt_ven.UseVisualStyleBackColor = true;
            this.bt_ven.Click += new System.EventHandler(this.bt_ven_Click);
            // 
            // bt_rep
            // 
            this.bt_rep.Location = new System.Drawing.Point(585, 332);
            this.bt_rep.Name = "bt_rep";
            this.bt_rep.Size = new System.Drawing.Size(75, 23);
            this.bt_rep.TabIndex = 6;
            this.bt_rep.Text = "Reportes";
            this.bt_rep.UseVisualStyleBackColor = true;
            this.bt_rep.Click += new System.EventHandler(this.bt_rep_Click);
            // 
            // bt_reg
            // 
            this.bt_reg.Location = new System.Drawing.Point(585, 382);
            this.bt_reg.Name = "bt_reg";
            this.bt_reg.Size = new System.Drawing.Size(75, 23);
            this.bt_reg.TabIndex = 8;
            this.bt_reg.Text = "Salir";
            this.bt_reg.UseVisualStyleBackColor = true;
            this.bt_reg.Click += new System.EventHandler(this.bt_reg_Click);
            // 
            // cb_caj
            // 
            this.cb_caj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_caj.FormattingEnabled = true;
            this.cb_caj.Location = new System.Drawing.Point(395, 67);
            this.cb_caj.Name = "cb_caj";
            this.cb_caj.Size = new System.Drawing.Size(121, 23);
            this.cb_caj.TabIndex = 9;
            this.cb_caj.SelectedIndexChanged += new System.EventHandler(this.cb_caj_SelectedIndexChanged);
            // 
            // lb_caj
            // 
            this.lb_caj.AutoSize = true;
            this.lb_caj.Location = new System.Drawing.Point(258, 71);
            this.lb_caj.Name = "lb_caj";
            this.lb_caj.Size = new System.Drawing.Size(104, 15);
            this.lb_caj.TabIndex = 10;
            this.lb_caj.Text = "Seleccione su Caja";
            this.lb_caj.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // bt_ti
            // 
            this.bt_ti.Location = new System.Drawing.Point(587, 21);
            this.bt_ti.Name = "bt_ti";
            this.bt_ti.Size = new System.Drawing.Size(75, 23);
            this.bt_ti.TabIndex = 11;
            this.bt_ti.Text = "Tienda";
            this.bt_ti.UseVisualStyleBackColor = true;
            this.bt_ti.Click += new System.EventHandler(this.bt_ti_Click);
            // 
            // bt_rec
            // 
            this.bt_rec.Location = new System.Drawing.Point(585, 71);
            this.bt_rec.Name = "bt_rec";
            this.bt_rec.Size = new System.Drawing.Size(75, 23);
            this.bt_rec.TabIndex = 12;
            this.bt_rec.Text = "Recibo";
            this.bt_rec.UseVisualStyleBackColor = true;
            this.bt_rec.Click += new System.EventHandler(this.bt_rec_Click);
            // 
            // bt_devol
            // 
            this.bt_devol.Location = new System.Drawing.Point(585, 289);
            this.bt_devol.Name = "bt_devol";
            this.bt_devol.Size = new System.Drawing.Size(75, 23);
            this.bt_devol.TabIndex = 13;
            this.bt_devol.Text = "Devolucion";
            this.bt_devol.UseVisualStyleBackColor = true;
            this.bt_devol.Click += new System.EventHandler(this.bt_devol_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(709, 435);
            this.ControlBox = false;
            this.Controls.Add(this.bt_devol);
            this.Controls.Add(this.bt_rec);
            this.Controls.Add(this.bt_ti);
            this.Controls.Add(this.lb_caj);
            this.Controls.Add(this.cb_caj);
            this.Controls.Add(this.bt_ven);
            this.Controls.Add(this.bt_reg);
            this.Controls.Add(this.bt_rep);
            this.Controls.Add(this.gb_ges);
            this.Controls.Add(this.lb_US);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_ges.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label lb_US;
        private Button bt_usu;
        private Button bt_caja;
        private Button bt_inv;
        private GroupBox gb_ges;
        private Button bt_ven;
        private Button bt_rep;
        private Button bt_reg;
        private ComboBox cb_caj;
        private Label lb_caj;
        private Button bt_ti;
        private Button bt_rec;
        private Button bt_devol;
    }
}