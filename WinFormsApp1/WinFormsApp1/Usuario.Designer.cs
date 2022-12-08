namespace WinFormsApp1
{
    partial class Usuario
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
            this.dg_usu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_con2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dt_nac = new System.Windows.Forms.DateTimePicker();
            this.dt_fin = new System.Windows.Forms.DateTimePicker();
            this.cb_act = new System.Windows.Forms.CheckBox();
            this.lb_ing = new System.Windows.Forms.Label();
            this.cb_ad = new System.Windows.Forms.CheckBox();
            this.tb_usu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_con = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_mat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_nomi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_cur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.bt_ag = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rb_ag = new System.Windows.Forms.RadioButton();
            this.rb_ed = new System.Windows.Forms.RadioButton();
            this.rb_el = new System.Windows.Forms.RadioButton();
            this.gb_ac = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_usu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_ac.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_usu
            // 
            this.dg_usu.AllowUserToAddRows = false;
            this.dg_usu.AllowUserToDeleteRows = false;
            this.dg_usu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dg_usu.Location = new System.Drawing.Point(12, 481);
=======
            this.dg_usu.Location = new System.Drawing.Point(12, 277);
>>>>>>> parent of ee9fad9 (final creo)
            this.dg_usu.MultiSelect = false;
            this.dg_usu.Name = "dg_usu";
            this.dg_usu.ReadOnly = true;
            this.dg_usu.RowTemplate.Height = 25;
            this.dg_usu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_usu.Size = new System.Drawing.Size(488, 251);
            this.dg_usu.TabIndex = 0;
            this.dg_usu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_usu_CellContentClick);
            this.dg_usu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_usu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.tb_con2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dt_nac);
            this.groupBox1.Controls.Add(this.dt_fin);
            this.groupBox1.Controls.Add(this.cb_act);
            this.groupBox1.Controls.Add(this.lb_ing);
            this.groupBox1.Controls.Add(this.cb_ad);
            this.groupBox1.Controls.Add(this.tb_usu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_con);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_mat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_pat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_cor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_nomi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_cur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_nom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 398);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Usuario";
            // 
            // tb_con2
            // 
            this.tb_con2.Location = new System.Drawing.Point(317, 166);
            this.tb_con2.Name = "tb_con2";
            this.tb_con2.Size = new System.Drawing.Size(234, 29);
            this.tb_con2.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "Confirmar Contraseña:";
            // 
            // dt_nac
            // 
            this.dt_nac.CustomFormat = "yyyy-MM-dd";
            this.dt_nac.Enabled = false;
            this.dt_nac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_nac.Location = new System.Drawing.Point(20, 347);
            this.dt_nac.Name = "dt_nac";
            this.dt_nac.Size = new System.Drawing.Size(119, 29);
            this.dt_nac.TabIndex = 33;
            this.dt_nac.ValueChanged += new System.EventHandler(this.dt_nac_ValueChanged);
            // 
            // dt_fin
            // 
            this.dt_fin.CustomFormat = "yyyy-MM-dd";
            this.dt_fin.Enabled = false;
            this.dt_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fin.Location = new System.Drawing.Point(18, 283);
            this.dt_fin.Name = "dt_fin";
            this.dt_fin.Size = new System.Drawing.Size(125, 29);
            this.dt_fin.TabIndex = 32;
            // 
            // cb_act
            // 
            this.cb_act.AutoSize = true;
            this.cb_act.Location = new System.Drawing.Point(438, 337);
            this.cb_act.Name = "cb_act";
            this.cb_act.Size = new System.Drawing.Size(72, 25);
            this.cb_act.TabIndex = 10;
            this.cb_act.Text = "Activo";
            this.cb_act.UseVisualStyleBackColor = true;
            // 
            // lb_ing
            // 
            this.lb_ing.AutoSize = true;
            this.lb_ing.Location = new System.Drawing.Point(10, 259);
            this.lb_ing.Name = "lb_ing";
            this.lb_ing.Size = new System.Drawing.Size(130, 21);
            this.lb_ing.TabIndex = 8;
            this.lb_ing.Text = "Fecha de Ingreso:";
            // 
            // cb_ad
            // 
            this.cb_ad.AutoSize = true;
            this.cb_ad.Location = new System.Drawing.Point(319, 336);
            this.cb_ad.Name = "cb_ad";
            this.cb_ad.Size = new System.Drawing.Size(75, 25);
            this.cb_ad.TabIndex = 7;
            this.cb_ad.Text = "Admin";
            this.cb_ad.UseVisualStyleBackColor = true;
            // 
            // tb_usu
            // 
            this.tb_usu.Location = new System.Drawing.Point(18, 47);
            this.tb_usu.Name = "tb_usu";
            this.tb_usu.Size = new System.Drawing.Size(235, 29);
            this.tb_usu.TabIndex = 4;
            this.tb_usu.TextChanged += new System.EventHandler(this.tb_usu_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Usuario:";
            // 
            // tb_con
            // 
            this.tb_con.Location = new System.Drawing.Point(317, 105);
            this.tb_con.Name = "tb_con";
            this.tb_con.Size = new System.Drawing.Size(234, 29);
            this.tb_con.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha de Nacimiento:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contraseña:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_mat
            // 
            this.tb_mat.Location = new System.Drawing.Point(20, 223);
            this.tb_mat.Name = "tb_mat";
            this.tb_mat.Size = new System.Drawing.Size(231, 29);
            this.tb_mat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido Materno:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_pat
            // 
            this.tb_pat.Location = new System.Drawing.Point(20, 166);
            this.tb_pat.Name = "tb_pat";
            this.tb_pat.Size = new System.Drawing.Size(231, 29);
            this.tb_pat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_cor
            // 
            this.tb_cor.Location = new System.Drawing.Point(317, 286);
            this.tb_cor.Name = "tb_cor";
            this.tb_cor.Size = new System.Drawing.Size(234, 29);
            this.tb_cor.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Correo:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_nomi
            // 
            this.tb_nomi.Location = new System.Drawing.Point(317, 226);
            this.tb_nomi.Name = "tb_nomi";
            this.tb_nomi.Size = new System.Drawing.Size(234, 29);
            this.tb_nomi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nomina:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_cur
            // 
            this.tb_cur.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_cur.Location = new System.Drawing.Point(317, 49);
            this.tb_cur.Name = "tb_cur";
            this.tb_cur.Size = new System.Drawing.Size(234, 29);
            this.tb_cur.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "CURP:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(20, 108);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(231, 29);
            this.tb_nom.TabIndex = 2;
            // 
            // bt_ag
            // 
            this.bt_ag.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_ag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_ag.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_ag.Location = new System.Drawing.Point(515, 481);
            this.bt_ag.Name = "bt_ag";
            this.bt_ag.Size = new System.Drawing.Size(130, 30);
            this.bt_ag.TabIndex = 5;
            this.bt_ag.Text = "Ejecutar";
            this.bt_ag.UseVisualStyleBackColor = false;
            this.bt_ag.Click += new System.EventHandler(this.bt_ag_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Location = new System.Drawing.Point(515, 700);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rb_ag
            // 
            this.rb_ag.AutoSize = true;
            this.rb_ag.Checked = true;
            this.rb_ag.Location = new System.Drawing.Point(10, 22);
            this.rb_ag.Name = "rb_ag";
            this.rb_ag.Size = new System.Drawing.Size(84, 25);
            this.rb_ag.TabIndex = 8;
            this.rb_ag.TabStop = true;
            this.rb_ag.Text = "Agregar";
            this.rb_ag.UseVisualStyleBackColor = true;
            this.rb_ag.CheckedChanged += new System.EventHandler(this.rb_ag_CheckedChanged);
            // 
            // rb_ed
            // 
            this.rb_ed.AutoSize = true;
            this.rb_ed.Location = new System.Drawing.Point(100, 22);
            this.rb_ed.Name = "rb_ed";
            this.rb_ed.Size = new System.Drawing.Size(68, 25);
            this.rb_ed.TabIndex = 9;
            this.rb_ed.Text = "Editar";
            this.rb_ed.UseVisualStyleBackColor = true;
            this.rb_ed.CheckedChanged += new System.EventHandler(this.rb_ed_CheckedChanged);
            // 
            // rb_el
            // 
            this.rb_el.AutoSize = true;
            this.rb_el.Location = new System.Drawing.Point(179, 22);
            this.rb_el.Name = "rb_el";
            this.rb_el.Size = new System.Drawing.Size(85, 25);
            this.rb_el.TabIndex = 11;
            this.rb_el.Text = "Eliminar";
            this.rb_el.UseVisualStyleBackColor = true;
            this.rb_el.CheckedChanged += new System.EventHandler(this.rb_el_CheckedChanged);
            // 
            // gb_ac
            // 
            this.gb_ac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gb_ac.Controls.Add(this.rb_el);
            this.gb_ac.Controls.Add(this.rb_ed);
            this.gb_ac.Controls.Add(this.rb_ag);
            this.gb_ac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_ac.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_ac.Location = new System.Drawing.Point(12, 6);
            this.gb_ac.Name = "gb_ac";
            this.gb_ac.Size = new System.Drawing.Size(270, 49);
            this.gb_ac.TabIndex = 12;
            this.gb_ac.TabStop = false;
            this.gb_ac.Text = "Accion";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(682, 744);
            this.ControlBox = false;
            this.Controls.Add(this.gb_ac);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_ag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_usu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_usu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_ac.ResumeLayout(false);
            this.gb_ac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dg_usu;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox tb_con;
        private Label label4;
        private TextBox tb_mat;
        private Label label3;
        private TextBox tb_pat;
        private Label label2;
        private Label label8;
        private TextBox tb_nomi;
        private Label label7;
        private Label label6;
        private TextBox tb_cur;
        private Label label5;
        private TextBox tb_nom;
        private Button bt_ag;
        private Button button4;
        private TextBox tb_usu;
        private Label label9;
        private TextBox tb_cor;
        private CheckBox cb_ad;
        private RadioButton rb_ag;
        private RadioButton rb_ed;
        private RadioButton rb_el;
        private GroupBox gb_ac;
        private CheckBox cb_act;
        private Label lb_ing;
        private DateTimePicker dt_nac;
        private DateTimePicker dt_fin;
        private TextBox tb_con2;
        private Label label10;
    }
}