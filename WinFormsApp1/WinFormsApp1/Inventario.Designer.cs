namespace WinFormsApp1
{
    partial class Inventario
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
            this.button4 = new System.Windows.Forms.Button();
            this.bt_ej = new System.Windows.Forms.Button();
            this.dg_inv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_um = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dt_fa = new System.Windows.Forms.DateTimePicker();
            this.cb_act = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ntb_mer = new System.Windows.Forms.NumericUpDown();
            this.ntb_uv = new System.Windows.Forms.NumericUpDown();
            this.ntb_pr = new System.Windows.Forms.NumericUpDown();
            this.ntb_ex = new System.Windows.Forms.NumericUpDown();
            this.ntb_pu = new System.Windows.Forms.NumericUpDown();
            this.ntb_cos = new System.Windows.Forms.NumericUpDown();
            this.cb_dep = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_des = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_ac = new System.Windows.Forms.GroupBox();
            this.rb_ed = new System.Windows.Forms.RadioButton();
            this.rb_ag = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_descu = new System.Windows.Forms.Button();
            this.bt_depa = new System.Windows.Forms.Button();
            this.dg_des = new System.Windows.Forms.DataGridView();
            this.dg_dep = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_inv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_mer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_uv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_pr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_ex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_pu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_cos)).BeginInit();
            this.gb_ac.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_des)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dep)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Location = new System.Drawing.Point(836, 636);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 40);
            this.button4.TabIndex = 12;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_ej
            // 
            this.bt_ej.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_ej.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_ej.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_ej.Location = new System.Drawing.Point(808, 80);
            this.bt_ej.Name = "bt_ej";
            this.bt_ej.Size = new System.Drawing.Size(130, 40);
            this.bt_ej.TabIndex = 11;
            this.bt_ej.Text = "Ejecutar";
            this.bt_ej.UseVisualStyleBackColor = false;
            this.bt_ej.Click += new System.EventHandler(this.bt_ej_Click);
            // 
            // dg_inv
            // 
            this.dg_inv.AllowUserToAddRows = false;
            this.dg_inv.AllowUserToDeleteRows = false;
            this.dg_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
<<<<<<< HEAD
            this.dg_inv.Location = new System.Drawing.Point(12, 389);
=======
=======
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_inv.Location = new System.Drawing.Point(18, 290);
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_inv.MultiSelect = false;
            this.dg_inv.Name = "dg_inv";
            this.dg_inv.ReadOnly = true;
            this.dg_inv.RowTemplate.Height = 25;
            this.dg_inv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_inv.Size = new System.Drawing.Size(251, 287);
            this.dg_inv.TabIndex = 7;
            this.dg_inv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_inv_CellContentClick);
            this.dg_inv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_inv_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.cb_um);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dt_fa);
            this.groupBox1.Controls.Add(this.cb_act);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ntb_mer);
            this.groupBox1.Controls.Add(this.ntb_uv);
            this.groupBox1.Controls.Add(this.ntb_pr);
            this.groupBox1.Controls.Add(this.ntb_ex);
            this.groupBox1.Controls.Add(this.ntb_pu);
            this.groupBox1.Controls.Add(this.ntb_cos);
            this.groupBox1.Controls.Add(this.cb_dep);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_des);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_desc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(18, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 303);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Inventario";
            // 
            // cb_um
            // 
            this.cb_um.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_um.FormattingEnabled = true;
            this.cb_um.Location = new System.Drawing.Point(10, 112);
            this.cb_um.Name = "cb_um";
            this.cb_um.Size = new System.Drawing.Size(149, 29);
            this.cb_um.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 23);
            this.label14.TabIndex = 33;
            this.label14.Text = "Inventario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 21);
            this.label13.TabIndex = 32;
            this.label13.Text = "Fecha Alta:";
            // 
            // dt_fa
            // 
            this.dt_fa.CustomFormat = "yyyy-MM-dd";
            this.dt_fa.Enabled = false;
            this.dt_fa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fa.Location = new System.Drawing.Point(10, 225);
            this.dt_fa.Name = "dt_fa";
            this.dt_fa.Size = new System.Drawing.Size(130, 29);
            this.dt_fa.TabIndex = 31;
            // 
            // cb_act
            // 
            this.cb_act.AutoSize = true;
            this.cb_act.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_act.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cb_act.Location = new System.Drawing.Point(534, 167);
            this.cb_act.Name = "cb_act";
            this.cb_act.Size = new System.Drawing.Size(104, 27);
            this.cb_act.TabIndex = 15;
            this.cb_act.Text = "Eliminado";
            this.cb_act.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Location = new System.Drawing.Point(643, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 21);
            this.label12.TabIndex = 30;
            this.label12.Text = "$";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Location = new System.Drawing.Point(589, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "$";
            // 
            // ntb_mer
            // 
            this.ntb_mer.DecimalPlaces = 2;
            this.ntb_mer.Location = new System.Drawing.Point(326, 167);
            this.ntb_mer.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_mer.Name = "ntb_mer";
            this.ntb_mer.Size = new System.Drawing.Size(103, 29);
            this.ntb_mer.TabIndex = 28;
            // 
            // ntb_uv
            // 
            this.ntb_uv.DecimalPlaces = 2;
            this.ntb_uv.Location = new System.Drawing.Point(326, 112);
            this.ntb_uv.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_uv.Name = "ntb_uv";
            this.ntb_uv.Size = new System.Drawing.Size(103, 29);
            this.ntb_uv.TabIndex = 27;
            // 
            // ntb_pr
            // 
            this.ntb_pr.DecimalPlaces = 2;
            this.ntb_pr.Location = new System.Drawing.Point(326, 56);
            this.ntb_pr.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_pr.Name = "ntb_pr";
            this.ntb_pr.Size = new System.Drawing.Size(103, 29);
            this.ntb_pr.TabIndex = 26;
            // 
            // ntb_ex
            // 
            this.ntb_ex.DecimalPlaces = 2;
            this.ntb_ex.Location = new System.Drawing.Point(10, 167);
            this.ntb_ex.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_ex.Name = "ntb_ex";
            this.ntb_ex.Size = new System.Drawing.Size(103, 29);
            this.ntb_ex.TabIndex = 25;
            // 
            // ntb_pu
            // 
            this.ntb_pu.DecimalPlaces = 2;
            this.ntb_pu.Location = new System.Drawing.Point(534, 112);
            this.ntb_pu.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_pu.Name = "ntb_pu";
            this.ntb_pu.Size = new System.Drawing.Size(128, 29);
            this.ntb_pu.TabIndex = 24;
            this.ntb_pu.ThousandsSeparator = true;
            // 
            // ntb_cos
            // 
            this.ntb_cos.DecimalPlaces = 2;
            this.ntb_cos.Location = new System.Drawing.Point(530, 51);
            this.ntb_cos.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_cos.Name = "ntb_cos";
            this.ntb_cos.Size = new System.Drawing.Size(132, 29);
            this.ntb_cos.TabIndex = 23;
            this.ntb_cos.ThousandsSeparator = true;
            // 
            // cb_dep
            // 
            this.cb_dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dep.FormattingEnabled = true;
            this.cb_dep.Location = new System.Drawing.Point(626, 266);
            this.cb_dep.Name = "cb_dep";
            this.cb_dep.Size = new System.Drawing.Size(88, 29);
            this.cb_dep.TabIndex = 3;
            this.cb_dep.SelectedIndexChanged += new System.EventHandler(this.cb_dep_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Departamento:";
            // 
            // cb_des
            // 
            this.cb_des.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_des.FormattingEnabled = true;
            this.cb_des.Location = new System.Drawing.Point(376, 266);
            this.cb_des.Name = "cb_des";
            this.cb_des.Size = new System.Drawing.Size(88, 29);
            this.cb_des.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(530, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Precio Unitario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(530, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Costo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidad de Medida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(326, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Merma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(326, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Unidades Vendidas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Descuento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Existencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(326, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Punto de Reorden:";
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(10, 51);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(254, 29);
            this.tb_desc.TabIndex = 2;
            this.tb_desc.TextChanged += new System.EventHandler(this.tb_desc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion:";
            // 
            // gb_ac
            // 
            this.gb_ac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gb_ac.Controls.Add(this.rb_ed);
            this.gb_ac.Controls.Add(this.rb_ag);
            this.gb_ac.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_ac.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_ac.Location = new System.Drawing.Point(18, 12);
            this.gb_ac.Name = "gb_ac";
            this.gb_ac.Size = new System.Drawing.Size(190, 51);
            this.gb_ac.TabIndex = 14;
            this.gb_ac.TabStop = false;
            this.gb_ac.Text = "Accion";
            // 
            // rb_ed
            // 
            this.rb_ed.AutoSize = true;
            this.rb_ed.Location = new System.Drawing.Point(107, 22);
            this.rb_ed.Name = "rb_ed";
            this.rb_ed.Size = new System.Drawing.Size(72, 27);
            this.rb_ed.TabIndex = 9;
            this.rb_ed.Text = "Editar";
            this.rb_ed.UseVisualStyleBackColor = true;
            this.rb_ed.CheckedChanged += new System.EventHandler(this.rb_ed_CheckedChanged);
            // 
            // rb_ag
            // 
            this.rb_ag.AutoSize = true;
            this.rb_ag.Checked = true;
            this.rb_ag.Location = new System.Drawing.Point(10, 22);
            this.rb_ag.Name = "rb_ag";
            this.rb_ag.Size = new System.Drawing.Size(89, 27);
            this.rb_ag.TabIndex = 8;
            this.rb_ag.TabStop = true;
            this.rb_ag.Text = "Agregar";
            this.rb_ag.UseVisualStyleBackColor = true;
            this.rb_ag.CheckedChanged += new System.EventHandler(this.rb_ag_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.bt_descu);
            this.groupBox2.Controls.Add(this.bt_depa);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(797, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 166);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar";
            // 
            // bt_descu
            // 
            this.bt_descu.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_descu.Location = new System.Drawing.Point(18, 97);
            this.bt_descu.Name = "bt_descu";
            this.bt_descu.Size = new System.Drawing.Size(130, 40);
            this.bt_descu.TabIndex = 17;
            this.bt_descu.Text = "Descuento";
            this.bt_descu.UseVisualStyleBackColor = false;
            this.bt_descu.Click += new System.EventHandler(this.bt_descu_Click);
            // 
            // bt_depa
            // 
            this.bt_depa.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_depa.Location = new System.Drawing.Point(18, 32);
            this.bt_depa.Name = "bt_depa";
            this.bt_depa.Size = new System.Drawing.Size(130, 40);
            this.bt_depa.TabIndex = 16;
            this.bt_depa.Text = "Departamento";
            this.bt_depa.UseVisualStyleBackColor = false;
            this.bt_depa.Click += new System.EventHandler(this.bt_depa_Click);
            // 
            // dg_des
            // 
            this.dg_des.AllowUserToAddRows = false;
            this.dg_des.AllowUserToDeleteRows = false;
            this.dg_des.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
<<<<<<< HEAD
            this.dg_des.Location = new System.Drawing.Point(269, 389);
=======
=======
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_des.Location = new System.Drawing.Point(275, 290);
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_des.MultiSelect = false;
            this.dg_des.Name = "dg_des";
            this.dg_des.ReadOnly = true;
            this.dg_des.RowTemplate.Height = 25;
            this.dg_des.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_des.Size = new System.Drawing.Size(251, 287);
            this.dg_des.TabIndex = 16;
            this.dg_des.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_des_CellContentClick);
            // 
            // dg_dep
            // 
            this.dg_dep.AllowUserToAddRows = false;
            this.dg_dep.AllowUserToDeleteRows = false;
            this.dg_dep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
<<<<<<< HEAD
            this.dg_dep.Location = new System.Drawing.Point(526, 389);
=======
=======
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_dep.Location = new System.Drawing.Point(532, 290);
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_dep.MultiSelect = false;
            this.dg_dep.Name = "dg_dep";
            this.dg_dep.ReadOnly = true;
            this.dg_dep.RowTemplate.Height = 25;
            this.dg_dep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dep.Size = new System.Drawing.Size(251, 287);
            this.dg_dep.TabIndex = 17;
            this.dg_dep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dep_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(13, 391);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 21);
            this.label15.TabIndex = 35;
            this.label15.Text = "Inventario";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(278, 391);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 21);
            this.label16.TabIndex = 36;
            this.label16.Text = "Descuento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(529, 391);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 21);
            this.label17.TabIndex = 37;
            this.label17.Text = "Departamento";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(978, 696);
            this.ControlBox = false;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dg_dep);
            this.Controls.Add(this.dg_des);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_ac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_ej);
            this.Controls.Add(this.dg_inv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dg_inv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_mer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_uv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_pr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_ex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_pu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_cos)).EndInit();
            this.gb_ac.ResumeLayout(false);
            this.gb_ac.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_des)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button4;
        private Button bt_ej;
        private DataGridView dg_inv;
        private GroupBox groupBox1;
        private ComboBox cb_des;
        private ComboBox cb_dep;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label5;
        private TextBox tb_desc;
        private Label label1;
        private GroupBox gb_ac;
        private RadioButton rb_ed;
        private RadioButton rb_ag;
        private NumericUpDown ntb_cos;
        private Label label12;
        private Label label11;
        private NumericUpDown ntb_mer;
        private NumericUpDown ntb_uv;
        private NumericUpDown ntb_pr;
        private NumericUpDown ntb_ex;
        private NumericUpDown ntb_pu;
        private CheckBox cb_act;
        private DateTimePicker dt_fa;
        private Label label13;
        private GroupBox groupBox2;
        private Button bt_descu;
        private Button bt_depa;
        private DataGridView dg_des;
        private DataGridView dg_dep;
        private Label label14;
        private ComboBox cb_um;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}