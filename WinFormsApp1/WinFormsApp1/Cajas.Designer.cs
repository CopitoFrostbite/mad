namespace WinFormsApp1
{
    partial class Cajas
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
            this.bt_reg = new System.Windows.Forms.Button();
            this.bt_ag = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_dis = new System.Windows.Forms.CheckBox();
            this.ntb_num = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_elc = new System.Windows.Forms.RadioButton();
            this.rb_edc = new System.Windows.Forms.RadioButton();
            this.rb_agc = new System.Windows.Forms.RadioButton();
            this.dg_caj = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_num)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_caj)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_reg
            // 
            this.bt_reg.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_reg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_reg.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_reg.Location = new System.Drawing.Point(243, 572);
            this.bt_reg.Name = "bt_reg";
            this.bt_reg.Size = new System.Drawing.Size(130, 30);
            this.bt_reg.TabIndex = 17;
            this.bt_reg.Text = "Regresar";
            this.bt_reg.UseVisualStyleBackColor = false;
            this.bt_reg.Click += new System.EventHandler(this.bt_reg_Click);
            // 
            // bt_ag
            // 
            this.bt_ag.BackColor = System.Drawing.SystemColors.ControlText;
            this.bt_ag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_ag.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_ag.Location = new System.Drawing.Point(243, 236);
            this.bt_ag.Name = "bt_ag";
            this.bt_ag.Size = new System.Drawing.Size(130, 30);
            this.bt_ag.TabIndex = 16;
            this.bt_ag.Text = "Ejecutar";
            this.bt_ag.UseVisualStyleBackColor = false;
            this.bt_ag.Click += new System.EventHandler(this.bt_ag_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.cb_dis);
            this.groupBox1.Controls.Add(this.ntb_num);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(27, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 112);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Caja";
            // 
            // cb_dis
            // 
            this.cb_dis.AutoSize = true;
            this.cb_dis.Location = new System.Drawing.Point(231, 37);
            this.cb_dis.Name = "cb_dis";
            this.cb_dis.Size = new System.Drawing.Size(103, 25);
            this.cb_dis.TabIndex = 38;
            this.cb_dis.Text = "Disponible";
            this.cb_dis.UseVisualStyleBackColor = true;
            // 
            // ntb_num
            // 
            this.ntb_num.Enabled = false;
            this.ntb_num.Location = new System.Drawing.Point(101, 33);
            this.ntb_num.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ntb_num.Name = "ntb_num";
            this.ntb_num.Size = new System.Drawing.Size(103, 29);
            this.ntb_num.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.rb_elc);
            this.groupBox2.Controls.Add(this.rb_edc);
            this.groupBox2.Controls.Add(this.rb_agc);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(27, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 49);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accion";
            // 
            // rb_elc
            // 
            this.rb_elc.AutoSize = true;
            this.rb_elc.Location = new System.Drawing.Point(184, 22);
            this.rb_elc.Name = "rb_elc";
            this.rb_elc.Size = new System.Drawing.Size(85, 25);
            this.rb_elc.TabIndex = 11;
            this.rb_elc.Text = "Eliminar";
            this.rb_elc.UseVisualStyleBackColor = true;
            // 
            // rb_edc
            // 
            this.rb_edc.AutoSize = true;
            this.rb_edc.Location = new System.Drawing.Point(107, 22);
            this.rb_edc.Name = "rb_edc";
            this.rb_edc.Size = new System.Drawing.Size(68, 25);
            this.rb_edc.TabIndex = 9;
            this.rb_edc.Text = "Editar";
            this.rb_edc.UseVisualStyleBackColor = true;
            // 
            // rb_agc
            // 
            this.rb_agc.AutoSize = true;
            this.rb_agc.Checked = true;
            this.rb_agc.Location = new System.Drawing.Point(10, 22);
            this.rb_agc.Name = "rb_agc";
            this.rb_agc.Size = new System.Drawing.Size(84, 25);
            this.rb_agc.TabIndex = 8;
            this.rb_agc.TabStop = true;
            this.rb_agc.Text = "Agregar";
            this.rb_agc.UseVisualStyleBackColor = true;
            // 
            // dg_caj
            // 
            this.dg_caj.AllowUserToAddRows = false;
            this.dg_caj.AllowUserToDeleteRows = false;
            this.dg_caj.AllowUserToResizeColumns = false;
            this.dg_caj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_caj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_caj.ColumnHeadersVisible = false;
            this.dg_caj.Location = new System.Drawing.Point(27, 291);
            this.dg_caj.MultiSelect = false;
            this.dg_caj.Name = "dg_caj";
            this.dg_caj.ReadOnly = true;
            this.dg_caj.RowTemplate.Height = 25;
            this.dg_caj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_caj.Size = new System.Drawing.Size(337, 263);
            this.dg_caj.TabIndex = 14;
            this.dg_caj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_usu_CellContentClick);
            this.dg_caj.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_usu_CellContentClick);
            // 
            // Cajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(395, 614);
            this.ControlBox = false;
            this.Controls.Add(this.dg_caj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_reg);
            this.Controls.Add(this.bt_ag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Cajas";
            this.Text = "Cajas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_num)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_caj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_reg;
        private Button bt_ag;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton rb_elc;
        private RadioButton rb_edc;
        private RadioButton rb_agc;
        private NumericUpDown ntb_num;
        private CheckBox cb_dis;
        private DataGridView dg_caj;
    }
}