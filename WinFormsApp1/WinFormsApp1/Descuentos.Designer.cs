namespace WinFormsApp1
{
    partial class Descuentos
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
            this.rb_el = new System.Windows.Forms.RadioButton();
            this.rb_ed = new System.Windows.Forms.RadioButton();
            this.rb_ag = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_ag = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ntb_desc = new System.Windows.Forms.NumericUpDown();
            this.dt_ff = new System.Windows.Forms.DateTimePicker();
            this.dt_fi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_usu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_ell = new System.Windows.Forms.RadioButton();
            this.rb_edd = new System.Windows.Forms.RadioButton();
            this.rb_agg = new System.Windows.Forms.RadioButton();
            this.gb_ac.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_desc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_usu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ac
            // 
            this.gb_ac.Controls.Add(this.rb_el);
            this.gb_ac.Controls.Add(this.rb_ed);
            this.gb_ac.Controls.Add(this.rb_ag);
            this.gb_ac.Location = new System.Drawing.Point(86, -55);
            this.gb_ac.Name = "gb_ac";
            this.gb_ac.Size = new System.Drawing.Size(246, 49);
            this.gb_ac.TabIndex = 17;
            this.gb_ac.TabStop = false;
            this.gb_ac.Text = "Accion";
            // 
            // rb_el
            // 
            this.rb_el.AutoSize = true;
            this.rb_el.Location = new System.Drawing.Point(168, 22);
            this.rb_el.Name = "rb_el";
            this.rb_el.Size = new System.Drawing.Size(68, 19);
            this.rb_el.TabIndex = 11;
            this.rb_el.Text = "Eliminar";
            this.rb_el.UseVisualStyleBackColor = true;
            // 
            // rb_ed
            // 
            this.rb_ed.AutoSize = true;
            this.rb_ed.Location = new System.Drawing.Point(107, 22);
            this.rb_ed.Name = "rb_ed";
            this.rb_ed.Size = new System.Drawing.Size(55, 19);
            this.rb_ed.TabIndex = 9;
            this.rb_ed.Text = "Editar";
            this.rb_ed.UseVisualStyleBackColor = true;
            // 
            // rb_ag
            // 
            this.rb_ag.AutoSize = true;
            this.rb_ag.Checked = true;
            this.rb_ag.Location = new System.Drawing.Point(10, 22);
            this.rb_ag.Name = "rb_ag";
            this.rb_ag.Size = new System.Drawing.Size(67, 19);
            this.rb_ag.TabIndex = 8;
            this.rb_ag.TabStop = true;
            this.rb_ag.Text = "Agregar";
            this.rb_ag.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Location = new System.Drawing.Point(521, 613);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_ag
            // 
            this.bt_ag.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_ag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_ag.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_ag.Location = new System.Drawing.Point(521, 351);
            this.bt_ag.Name = "bt_ag";
            this.bt_ag.Size = new System.Drawing.Size(130, 30);
            this.bt_ag.TabIndex = 15;
            this.bt_ag.Text = "Ejecutar";
            this.bt_ag.UseVisualStyleBackColor = false;
            this.bt_ag.Click += new System.EventHandler(this.bt_ag_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.ntb_desc);
            this.groupBox1.Controls.Add(this.dt_ff);
            this.groupBox1.Controls.Add(this.dt_fi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_des);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 223);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Descuentos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ntb_desc
            // 
            this.ntb_desc.Location = new System.Drawing.Point(33, 117);
            this.ntb_desc.Margin = new System.Windows.Forms.Padding(2);
            this.ntb_desc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_desc.Name = "ntb_desc";
            this.ntb_desc.Size = new System.Drawing.Size(80, 29);
            this.ntb_desc.TabIndex = 34;
            // 
            // dt_ff
            // 
            this.dt_ff.CustomFormat = "yyyy-MM-dd";
            this.dt_ff.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ff.Location = new System.Drawing.Point(319, 122);
            this.dt_ff.Name = "dt_ff";
            this.dt_ff.Size = new System.Drawing.Size(200, 29);
            this.dt_ff.TabIndex = 33;
            // 
            // dt_fi
            // 
            this.dt_fi.CustomFormat = "yyyy-MM-dd";
            this.dt_fi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fi.Location = new System.Drawing.Point(319, 52);
            this.dt_fi.Name = "dt_fi";
            this.dt_fi.Size = new System.Drawing.Size(200, 29);
            this.dt_fi.TabIndex = 32;
            this.dt_fi.ValueChanged += new System.EventHandler(this.dt_fa_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "%";
            // 
            // tb_des
            // 
            this.tb_des.Location = new System.Drawing.Point(13, 52);
            this.tb_des.Name = "tb_des";
            this.tb_des.Size = new System.Drawing.Size(257, 29);
            this.tb_des.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descuento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de Inicio:";
            // 
            // dg_usu
            // 
            this.dg_usu.AllowUserToAddRows = false;
            this.dg_usu.AllowUserToDeleteRows = false;
            this.dg_usu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_usu.Location = new System.Drawing.Point(12, 337);
            this.dg_usu.MultiSelect = false;
            this.dg_usu.Name = "dg_usu";
            this.dg_usu.ReadOnly = true;
            this.dg_usu.RowTemplate.Height = 25;
            this.dg_usu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_usu.Size = new System.Drawing.Size(488, 292);
            this.dg_usu.TabIndex = 13;
            this.dg_usu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_usu_CellContentClick);
            this.dg_usu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_usu_CellContentClick_1);
            this.dg_usu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_usu_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.rb_ell);
            this.groupBox2.Controls.Add(this.rb_edd);
            this.groupBox2.Controls.Add(this.rb_agg);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 49);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accion";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rb_ell
            // 
            this.rb_ell.AutoSize = true;
            this.rb_ell.Location = new System.Drawing.Point(168, 22);
            this.rb_ell.Name = "rb_ell";
            this.rb_ell.Size = new System.Drawing.Size(85, 25);
            this.rb_ell.TabIndex = 11;
            this.rb_ell.Text = "Eliminar";
            this.rb_ell.UseVisualStyleBackColor = true;
            this.rb_ell.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_edd
            // 
            this.rb_edd.AutoSize = true;
            this.rb_edd.Location = new System.Drawing.Point(107, 22);
            this.rb_edd.Name = "rb_edd";
            this.rb_edd.Size = new System.Drawing.Size(68, 25);
            this.rb_edd.TabIndex = 9;
            this.rb_edd.Text = "Editar";
            this.rb_edd.UseVisualStyleBackColor = true;
            this.rb_edd.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_agg
            // 
            this.rb_agg.AutoSize = true;
            this.rb_agg.Checked = true;
            this.rb_agg.Location = new System.Drawing.Point(10, 22);
            this.rb_agg.Name = "rb_agg";
            this.rb_agg.Size = new System.Drawing.Size(84, 25);
            this.rb_agg.TabIndex = 8;
            this.rb_agg.TabStop = true;
            this.rb_agg.Text = "Agregar";
            this.rb_agg.UseVisualStyleBackColor = true;
            this.rb_agg.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Descuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(666, 655);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_ac);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_ag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_usu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Descuentos";
            this.Text = "Descuentos";
            this.gb_ac.ResumeLayout(false);
            this.gb_ac.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_desc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_usu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_ac;
        private RadioButton rb_el;
        private RadioButton rb_ed;
        private RadioButton rb_ag;
        private Button button4;
        private Button bt_ag;
        private GroupBox groupBox1;
        private Label label10;
        private TextBox tb_des;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label1;
        private DataGridView dg_usu;
        private DateTimePicker dt_fi;
        private DateTimePicker dt_ff;
        private NumericUpDown ntb_desc;
        private GroupBox groupBox2;
        private RadioButton rb_ell;
        private RadioButton rb_edd;
        private RadioButton rb_agg;
    }
}