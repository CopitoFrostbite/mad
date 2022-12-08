namespace WinFormsApp1
{
    partial class Devoluciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ntb_idde = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dg_busdd = new System.Windows.Forms.DataGridView();
            this.dg_devo = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt_sel = new System.Windows.Forms.Button();
            this.cb_actd = new System.Windows.Forms.CheckBox();
            this.bt_remd = new System.Windows.Forms.Button();
            this.ntb_cand = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_motd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ntb_totd = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_devo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_cand = new System.Windows.Forms.Button();
            this.bt_regr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_idde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_busdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_devo)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_cand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_totd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntb_idde
            // 
            this.ntb_idde.Location = new System.Drawing.Point(159, 22);
            this.ntb_idde.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_idde.Name = "ntb_idde";
            this.ntb_idde.Size = new System.Drawing.Size(105, 29);
            this.ntb_idde.TabIndex = 27;
            this.ntb_idde.ValueChanged += new System.EventHandler(this.ntb_idde_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "Numero de Recibo:";
            // 
            // dg_busdd
            // 
            this.dg_busdd.AllowUserToAddRows = false;
            this.dg_busdd.AllowUserToDeleteRows = false;
            this.dg_busdd.AllowUserToResizeColumns = false;
            this.dg_busdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_busdd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_busdd.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_busdd.DefaultCellStyle = dataGridViewCellStyle1;
            this.dg_busdd.Location = new System.Drawing.Point(6, 68);
            this.dg_busdd.MultiSelect = false;
            this.dg_busdd.Name = "dg_busdd";
            this.dg_busdd.ReadOnly = true;
            this.dg_busdd.RowTemplate.Height = 25;
            this.dg_busdd.RowTemplate.ReadOnly = true;
            this.dg_busdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_busdd.Size = new System.Drawing.Size(585, 195);
            this.dg_busdd.TabIndex = 29;
            this.dg_busdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_busdd_CellContentClick);
            // 
            // dg_devo
            // 
            this.dg_devo.AllowUserToAddRows = false;
            this.dg_devo.AllowUserToDeleteRows = false;
            this.dg_devo.AllowUserToResizeColumns = false;
            this.dg_devo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_devo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_devo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_devo.Location = new System.Drawing.Point(10, 52);
            this.dg_devo.MultiSelect = false;
            this.dg_devo.Name = "dg_devo";
            this.dg_devo.ReadOnly = true;
            this.dg_devo.RowTemplate.Height = 25;
            this.dg_devo.RowTemplate.ReadOnly = true;
            this.dg_devo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_devo.Size = new System.Drawing.Size(581, 195);
            this.dg_devo.TabIndex = 30;
            this.dg_devo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_devo_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox5.Controls.Add(this.bt_sel);
            this.groupBox5.Controls.Add(this.cb_actd);
            this.groupBox5.Controls.Add(this.bt_remd);
            this.groupBox5.Controls.Add(this.ntb_cand);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.tb_motd);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.dg_busdd);
            this.groupBox5.Controls.Add(this.ntb_idde);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox5.Location = new System.Drawing.Point(16, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(892, 280);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Recibo";
            // 
            // bt_sel
            // 
            this.bt_sel.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_sel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_sel.Location = new System.Drawing.Point(317, 24);
            this.bt_sel.Name = "bt_sel";
            this.bt_sel.Size = new System.Drawing.Size(130, 30);
            this.bt_sel.TabIndex = 38;
            this.bt_sel.Text = "Seleccionar";
            this.bt_sel.UseVisualStyleBackColor = false;
            this.bt_sel.Click += new System.EventHandler(this.bt_sel_Click);
            // 
            // cb_actd
            // 
            this.cb_actd.AutoSize = true;
            this.cb_actd.Location = new System.Drawing.Point(735, 192);
            this.cb_actd.Name = "cb_actd";
            this.cb_actd.Size = new System.Drawing.Size(79, 25);
            this.cb_actd.TabIndex = 36;
            this.cb_actd.Text = "Merma";
            this.cb_actd.UseVisualStyleBackColor = true;
            this.cb_actd.CheckedChanged += new System.EventHandler(this.cb_actd_CheckedChanged);
            // 
            // bt_remd
            // 
            this.bt_remd.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_remd.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_remd.Location = new System.Drawing.Point(735, 233);
            this.bt_remd.Name = "bt_remd";
            this.bt_remd.Size = new System.Drawing.Size(130, 30);
            this.bt_remd.TabIndex = 34;
            this.bt_remd.Text = "Agregar";
            this.bt_remd.UseVisualStyleBackColor = false;
            this.bt_remd.Click += new System.EventHandler(this.bt_remd_Click);
            // 
            // ntb_cand
            // 
            this.ntb_cand.DecimalPlaces = 2;
            this.ntb_cand.Location = new System.Drawing.Point(680, 108);
            this.ntb_cand.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_cand.Name = "ntb_cand";
            this.ntb_cand.Size = new System.Drawing.Size(55, 29);
            this.ntb_cand.TabIndex = 33;
            this.ntb_cand.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Cantidad:";
            // 
            // tb_motd
            // 
            this.tb_motd.Location = new System.Drawing.Point(661, 68);
            this.tb_motd.Name = "tb_motd";
            this.tb_motd.Size = new System.Drawing.Size(213, 29);
            this.tb_motd.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Motivo:";
            // 
            // ntb_totd
            // 
            this.ntb_totd.DecimalPlaces = 2;
            this.ntb_totd.Enabled = false;
            this.ntb_totd.Location = new System.Drawing.Point(649, 52);
            this.ntb_totd.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_totd.Name = "ntb_totd";
            this.ntb_totd.ReadOnly = true;
            this.ntb_totd.Size = new System.Drawing.Size(109, 29);
            this.ntb_totd.TabIndex = 37;
            this.ntb_totd.ThousandsSeparator = true;
            this.ntb_totd.ValueChanged += new System.EventHandler(this.ntb_totd_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(608, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 36;
            this.label12.Text = "Total: $";
            // 
            // bt_devo
            // 
            this.bt_devo.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_devo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_devo.Location = new System.Drawing.Point(735, 122);
            this.bt_devo.Name = "bt_devo";
            this.bt_devo.Size = new System.Drawing.Size(130, 30);
            this.bt_devo.TabIndex = 35;
            this.bt_devo.Text = "Devolver";
            this.bt_devo.UseVisualStyleBackColor = false;
            this.bt_devo.Click += new System.EventHandler(this.bt_devo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.bt_cand);
            this.groupBox1.Controls.Add(this.dg_devo);
            this.groupBox1.Controls.Add(this.ntb_totd);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.bt_devo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(16, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 253);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devolucion";
            // 
            // bt_cand
            // 
            this.bt_cand.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_cand.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_cand.Location = new System.Drawing.Point(255, 16);
            this.bt_cand.Name = "bt_cand";
            this.bt_cand.Size = new System.Drawing.Size(130, 30);
            this.bt_cand.TabIndex = 39;
            this.bt_cand.Text = "Cancelar Articulo";
            this.bt_cand.UseVisualStyleBackColor = false;
            this.bt_cand.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_regr
            // 
            this.bt_regr.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_regr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_regr.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_regr.Location = new System.Drawing.Point(778, 647);
            this.bt_regr.Name = "bt_regr";
            this.bt_regr.Size = new System.Drawing.Size(130, 40);
            this.bt_regr.TabIndex = 40;
            this.bt_regr.Text = "Regresar";
            this.bt_regr.UseVisualStyleBackColor = false;
            this.bt_regr.Click += new System.EventHandler(this.bt_regr_Click);
            // 
            // Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(938, 689);
            this.ControlBox = false;
            this.Controls.Add(this.bt_regr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Devoluciones";
            this.Text = "Devoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.ntb_idde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_busdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_devo)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_cand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_totd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown ntb_idde;
        private Label label11;
        private DataGridView dg_busdd;
        private DataGridView dg_devo;
        private GroupBox groupBox5;
        private Label label1;
        private TextBox tb_motd;
        private NumericUpDown ntb_cand;
        private Label label8;
        private Button bt_remd;
        private Button bt_devo;
        private CheckBox cb_actd;
        private GroupBox groupBox1;
        private NumericUpDown ntb_totd;
        private Label label12;
        private Button bt_sel;
        private Button bt_cand;
        private Button bt_regr;
    }
}