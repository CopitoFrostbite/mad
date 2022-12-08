namespace WinFormsApp1
{
    partial class Ventas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_caj2 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_caja = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ntb_id = new System.Windows.Forms.NumericUpDown();
            this.dg_bus = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ntb_can = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_agr = new System.Windows.Forms.Button();
            this.rb_id = new System.Windows.Forms.RadioButton();
            this.rb_nom = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dg_p = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt_rem = new System.Windows.Forms.Button();
            this.dg_lis = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_remp = new System.Windows.Forms.Button();
            this.ntb_pag = new System.Windows.Forms.NumericUpDown();
            this.cb_met = new System.Windows.Forms.ComboBox();
            this.bt_pag = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ntb_tot = new System.Windows.Forms.NumericUpDown();
            this.ntb_pagt = new System.Windows.Forms.NumericUpDown();
            this.ntb_des = new System.Windows.Forms.NumericUpDown();
            this.bt_vent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bus)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_can)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_p)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lis)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_pag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_tot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_pagt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_des)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_caj2
            // 
            this.lb_caj2.AutoSize = true;
            this.lb_caj2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_caj2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lb_caj2.Location = new System.Drawing.Point(12, 9);
            this.lb_caj2.Name = "lb_caj2";
            this.lb_caj2.Size = new System.Drawing.Size(128, 21);
            this.lb_caj2.TabIndex = 0;
            this.lb_caj2.Text = "Cajero:\"Nombre\"";
            this.lb_caj2.Click += new System.EventHandler(this.lb_caj2_Click);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_time.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lb_time.Location = new System.Drawing.Point(616, 9);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(62, 21);
            this.lb_time.TabIndex = 1;
            this.lb_time.Text = "\"Fecha\"";
            // 
            // lb_caja
            // 
            this.lb_caja.AutoSize = true;
            this.lb_caja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_caja.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lb_caja.Location = new System.Drawing.Point(378, 9);
            this.lb_caja.Name = "lb_caja";
            this.lb_caja.Size = new System.Drawing.Size(113, 21);
            this.lb_caja.TabIndex = 3;
            this.lb_caja.Text = "Caja:\"Numero\"";
            this.lb_caja.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.ntb_id);
            this.groupBox1.Controls.Add(this.dg_bus);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.rb_id);
            this.groupBox1.Controls.Add(this.rb_nom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_nom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 322);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // ntb_id
            // 
            this.ntb_id.Location = new System.Drawing.Point(213, 22);
            this.ntb_id.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_id.Name = "ntb_id";
            this.ntb_id.Size = new System.Drawing.Size(55, 29);
            this.ntb_id.TabIndex = 20;
            this.ntb_id.ValueChanged += new System.EventHandler(this.ntb_id_ValueChanged);
            this.ntb_id.Enter += new System.EventHandler(this.ntb_id_TextChanged);
            this.ntb_id.Leave += new System.EventHandler(this.ntb_id_TextChanged);
            // 
            // dg_bus
            // 
            this.dg_bus.AllowUserToAddRows = false;
            this.dg_bus.AllowUserToDeleteRows = false;
            this.dg_bus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_bus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_bus.DefaultCellStyle = dataGridViewCellStyle1;
            this.dg_bus.Location = new System.Drawing.Point(26, 57);
            this.dg_bus.MultiSelect = false;
            this.dg_bus.Name = "dg_bus";
            this.dg_bus.ReadOnly = true;
            this.dg_bus.RowTemplate.Height = 25;
            this.dg_bus.RowTemplate.ReadOnly = true;
            this.dg_bus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_bus.Size = new System.Drawing.Size(443, 195);
            this.dg_bus.TabIndex = 16;
            this.dg_bus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_bus_CellContentClick);
<<<<<<< HEAD
<<<<<<< HEAD
           
=======
            this.dg_bus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_bus_CellContentClick_1);
>>>>>>> parent of ee9fad9 (final creo)
=======
            this.dg_bus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_bus_CellContentClick_1);
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_bus.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_bus_CellContentClick);
            this.dg_bus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_bus_CellContentClick);
            this.dg_bus.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_bus_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ntb_can);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.bt_agr);
            this.groupBox4.Location = new System.Drawing.Point(187, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 63);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar";
            // 
            // ntb_can
            // 
            this.ntb_can.DecimalPlaces = 2;
            this.ntb_can.Location = new System.Drawing.Point(87, 23);
            this.ntb_can.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_can.Name = "ntb_can";
            this.ntb_can.Size = new System.Drawing.Size(55, 29);
            this.ntb_can.TabIndex = 21;
            this.ntb_can.ValueChanged += new System.EventHandler(this.ntb_can_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cantidad:";
            // 
            // bt_agr
            // 
            this.bt_agr.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_agr.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_agr.Location = new System.Drawing.Point(192, 23);
            this.bt_agr.Name = "bt_agr";
            this.bt_agr.Size = new System.Drawing.Size(130, 30);
            this.bt_agr.TabIndex = 11;
            this.bt_agr.Text = "Agregar";
            this.bt_agr.UseVisualStyleBackColor = false;
            this.bt_agr.Click += new System.EventHandler(this.bt_agr_Click);
            // 
            // rb_id
            // 
            this.rb_id.AutoSize = true;
            this.rb_id.Checked = true;
            this.rb_id.Location = new System.Drawing.Point(6, 22);
            this.rb_id.Name = "rb_id";
            this.rb_id.Size = new System.Drawing.Size(43, 25);
            this.rb_id.TabIndex = 16;
            this.rb_id.TabStop = true;
            this.rb_id.Text = "ID";
            this.rb_id.UseVisualStyleBackColor = true;
            this.rb_id.CheckedChanged += new System.EventHandler(this.rb_id_CheckedChanged);
            // 
            // rb_nom
            // 
            this.rb_nom.AutoSize = true;
            this.rb_nom.Location = new System.Drawing.Point(67, 23);
            this.rb_nom.Name = "rb_nom";
            this.rb_nom.Size = new System.Drawing.Size(86, 25);
            this.rb_nom.TabIndex = 15;
            this.rb_nom.Text = "Nombre";
            this.rb_nom.UseVisualStyleBackColor = true;
            this.rb_nom.CheckedChanged += new System.EventHandler(this.rb_nom_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID:";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(360, 21);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(134, 29);
            this.tb_nom.TabIndex = 8;
            this.tb_nom.TextChanged += new System.EventHandler(this.tb_nom_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Location = new System.Drawing.Point(667, 498);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Total: $";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Location = new System.Drawing.Point(665, 536);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "Pago: $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(593, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descuento Total: $";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dg_p
            // 
            this.dg_p.AllowUserToAddRows = false;
            this.dg_p.AllowUserToDeleteRows = false;
            this.dg_p.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_p.Location = new System.Drawing.Point(23, 63);
            this.dg_p.MultiSelect = false;
            this.dg_p.Name = "dg_p";
            this.dg_p.ReadOnly = true;
            this.dg_p.RowTemplate.Height = 25;
            this.dg_p.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_p.Size = new System.Drawing.Size(331, 176);
            this.dg_p.TabIndex = 7;
            this.dg_p.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_p_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.dg_lis);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(546, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 322);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bt_rem);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox5.Location = new System.Drawing.Point(219, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 63);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Remover";
            // 
            // bt_rem
            // 
            this.bt_rem.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_rem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_rem.Location = new System.Drawing.Point(171, 23);
            this.bt_rem.Name = "bt_rem";
            this.bt_rem.Size = new System.Drawing.Size(130, 30);
            this.bt_rem.TabIndex = 11;
            this.bt_rem.Text = "Remover";
            this.bt_rem.UseVisualStyleBackColor = false;
            this.bt_rem.Click += new System.EventHandler(this.bt_rem_Click);
            // 
            // dg_lis
            // 
            this.dg_lis.AllowUserToAddRows = false;
            this.dg_lis.AllowUserToDeleteRows = false;
            this.dg_lis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_lis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
<<<<<<< HEAD
            this.dg_lis.Location = new System.Drawing.Point(21, 23);
=======
=======
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_lis.Location = new System.Drawing.Point(17, 23);
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_lis.MultiSelect = false;
            this.dg_lis.Name = "dg_lis";
            this.dg_lis.ReadOnly = true;
            this.dg_lis.RowTemplate.Height = 25;
            this.dg_lis.RowTemplate.ReadOnly = true;
            this.dg_lis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_lis.Size = new System.Drawing.Size(526, 224);
            this.dg_lis.TabIndex = 16;
            this.dg_lis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_lis_CellContentClick);
            this.dg_lis.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_lis_CellContentClick);
            this.dg_lis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_lis_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.bt_remp);
            this.groupBox3.Controls.Add(this.ntb_pag);
            this.groupBox3.Controls.Add(this.dg_p);
            this.groupBox3.Controls.Add(this.cb_met);
            this.groupBox3.Controls.Add(this.bt_pag);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Location = new System.Drawing.Point(12, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 258);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pago";
            // 
            // bt_remp
            // 
            this.bt_remp.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_remp.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_remp.Location = new System.Drawing.Point(375, 216);
            this.bt_remp.Name = "bt_remp";
            this.bt_remp.Size = new System.Drawing.Size(130, 30);
            this.bt_remp.TabIndex = 12;
            this.bt_remp.Text = "Remover";
            this.bt_remp.UseVisualStyleBackColor = false;
            this.bt_remp.Click += new System.EventHandler(this.bt_remp_Click);
            // 
            // ntb_pag
            // 
            this.ntb_pag.DecimalPlaces = 2;
            this.ntb_pag.Location = new System.Drawing.Point(269, 26);
            this.ntb_pag.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_pag.Name = "ntb_pag";
            this.ntb_pag.Size = new System.Drawing.Size(103, 29);
            this.ntb_pag.TabIndex = 22;
            this.ntb_pag.ThousandsSeparator = true;
            this.ntb_pag.ValueChanged += new System.EventHandler(this.ntb_pag_ValueChanged);
            // 
            // cb_met
            // 
            this.cb_met.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_met.FormattingEnabled = true;
            this.cb_met.Location = new System.Drawing.Point(77, 24);
            this.cb_met.Name = "cb_met";
            this.cb_met.Size = new System.Drawing.Size(104, 29);
            this.cb_met.TabIndex = 15;
            this.cb_met.SelectedIndexChanged += new System.EventHandler(this.cb_met_SelectedIndexChanged);
            // 
            // bt_pag
            // 
            this.bt_pag.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_pag.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_pag.Location = new System.Drawing.Point(378, 26);
            this.bt_pag.Name = "bt_pag";
            this.bt_pag.Size = new System.Drawing.Size(130, 30);
            this.bt_pag.TabIndex = 11;
            this.bt_pag.Text = "Pagar";
            this.bt_pag.UseVisualStyleBackColor = false;
            this.bt_pag.Click += new System.EventHandler(this.bt_pag_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cantidad: $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Metodo:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Location = new System.Drawing.Point(980, 605);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 30);
            this.button4.TabIndex = 18;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ntb_tot
            // 
            this.ntb_tot.DecimalPlaces = 2;
            this.ntb_tot.Enabled = false;
            this.ntb_tot.Location = new System.Drawing.Point(728, 496);
            this.ntb_tot.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_tot.Name = "ntb_tot";
            this.ntb_tot.ReadOnly = true;
            this.ntb_tot.Size = new System.Drawing.Size(130, 23);
            this.ntb_tot.TabIndex = 23;
            this.ntb_tot.ThousandsSeparator = true;
            this.ntb_tot.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ntb_pagt
            // 
            this.ntb_pagt.DecimalPlaces = 2;
            this.ntb_pagt.Enabled = false;
            this.ntb_pagt.Location = new System.Drawing.Point(728, 534);
            this.ntb_pagt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_pagt.Name = "ntb_pagt";
            this.ntb_pagt.ReadOnly = true;
            this.ntb_pagt.Size = new System.Drawing.Size(130, 23);
            this.ntb_pagt.TabIndex = 24;
            this.ntb_pagt.ThousandsSeparator = true;
            this.ntb_pagt.ValueChanged += new System.EventHandler(this.ntb_pagt_ValueChanged);
            // 
            // ntb_des
            // 
            this.ntb_des.DecimalPlaces = 2;
            this.ntb_des.Enabled = false;
            this.ntb_des.Location = new System.Drawing.Point(728, 460);
            this.ntb_des.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_des.Name = "ntb_des";
            this.ntb_des.ReadOnly = true;
            this.ntb_des.Size = new System.Drawing.Size(130, 23);
            this.ntb_des.TabIndex = 25;
            this.ntb_des.ThousandsSeparator = true;
            this.ntb_des.ValueChanged += new System.EventHandler(this.ntb_des_ValueChanged);
            // 
            // bt_vent
            // 
            this.bt_vent.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_vent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_vent.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_vent.Location = new System.Drawing.Point(911, 468);
            this.bt_vent.Name = "bt_vent";
            this.bt_vent.Size = new System.Drawing.Size(97, 70);
            this.bt_vent.TabIndex = 26;
            this.bt_vent.Text = "Completar Venta";
            this.bt_vent.UseVisualStyleBackColor = false;
            this.bt_vent.Click += new System.EventHandler(this.bt_vent_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1123, 640);
            this.ControlBox = false;
            this.Controls.Add(this.bt_vent);
            this.Controls.Add(this.ntb_des);
            this.Controls.Add(this.ntb_pagt);
            this.Controls.Add(this.ntb_tot);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_caja);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_caj2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Ventas";
            this.Text = "Completar Venta";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bus)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_can)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_p)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_lis)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_pag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_tot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_pagt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_des)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_caj2;
        private Label lb_time;
        private Label lb_caja;
        private GroupBox groupBox1;
        private Button bt_agr;
        private Label label6;
        private TextBox tb_nom;
        private Label label5;
        private Label label7;
        private DataGridView dg_p;
        private GroupBox groupBox2;
        private DataGridView dg_lis;
        private GroupBox groupBox3;
        private ComboBox cb_met;
        private Button bt_pag;
        private Label label9;
        private Label label10;
        private Button button4;
        private RadioButton rb_id;
        private RadioButton rb_nom;
        private Label label11;
        private GroupBox groupBox4;
        private Label label8;
        private Label label12;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dg_bus;
        private NumericUpDown ntb_id;
        private NumericUpDown ntb_can;
        private GroupBox groupBox5;
        private Button bt_rem;
        private NumericUpDown ntb_pag;
        private NumericUpDown ntb_tot;
        private NumericUpDown ntb_pagt;
        private NumericUpDown ntb_des;
        private Button bt_vent;
        private Button bt_remp;
    }
}