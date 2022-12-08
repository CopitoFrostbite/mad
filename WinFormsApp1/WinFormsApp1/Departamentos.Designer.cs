namespace WinFormsApp1
{
    partial class Departamentos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_elll = new System.Windows.Forms.RadioButton();
            this.rb_eddd = new System.Windows.Forms.RadioButton();
            this.rb_aggg = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_ag = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_dev = new System.Windows.Forms.CheckBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dg_dep = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_elll);
            this.groupBox2.Controls.Add(this.rb_eddd);
            this.groupBox2.Controls.Add(this.rb_aggg);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 49);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accion";
            // 
            // rb_elll
            // 
            this.rb_elll.AutoSize = true;
            this.rb_elll.Location = new System.Drawing.Point(168, 22);
            this.rb_elll.Name = "rb_elll";
            this.rb_elll.Size = new System.Drawing.Size(68, 19);
            this.rb_elll.TabIndex = 11;
            this.rb_elll.Text = "Eliminar";
            this.rb_elll.UseVisualStyleBackColor = true;
            this.rb_elll.CheckedChanged += new System.EventHandler(this.rb_elll_CheckedChanged);
            // 
            // rb_eddd
            // 
            this.rb_eddd.AutoSize = true;
            this.rb_eddd.Location = new System.Drawing.Point(107, 22);
            this.rb_eddd.Name = "rb_eddd";
            this.rb_eddd.Size = new System.Drawing.Size(55, 19);
            this.rb_eddd.TabIndex = 9;
            this.rb_eddd.Text = "Editar";
            this.rb_eddd.UseVisualStyleBackColor = true;
            this.rb_eddd.CheckedChanged += new System.EventHandler(this.rb_eddd_CheckedChanged);
            // 
            // rb_aggg
            // 
            this.rb_aggg.AutoSize = true;
            this.rb_aggg.Checked = true;
            this.rb_aggg.Location = new System.Drawing.Point(10, 22);
            this.rb_aggg.Name = "rb_aggg";
            this.rb_aggg.Size = new System.Drawing.Size(67, 19);
            this.rb_aggg.TabIndex = 8;
            this.rb_aggg.TabStop = true;
            this.rb_aggg.Text = "Agregar";
            this.rb_aggg.UseVisualStyleBackColor = true;
            this.rb_aggg.CheckedChanged += new System.EventHandler(this.rb_aggg_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(539, 452);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 39;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_ag
            // 
            this.bt_ag.Location = new System.Drawing.Point(539, 183);
            this.bt_ag.Name = "bt_ag";
            this.bt_ag.Size = new System.Drawing.Size(102, 23);
            this.bt_ag.TabIndex = 38;
            this.bt_ag.Text = "Ejecutar";
            this.bt_ag.UseVisualStyleBackColor = true;
            this.bt_ag.Click += new System.EventHandler(this.bt_ag_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_dev);
            this.groupBox1.Controls.Add(this.tb_nom);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 61);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Descuentos";
            // 
            // cb_dev
            // 
            this.cb_dev.AutoSize = true;
            this.cb_dev.Location = new System.Drawing.Point(392, 25);
            this.cb_dev.Name = "cb_dev";
            this.cb_dev.Size = new System.Drawing.Size(86, 19);
            this.cb_dev.TabIndex = 35;
            this.cb_dev.Text = "Devolucion";
            this.cb_dev.UseVisualStyleBackColor = true;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(127, 19);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(119, 23);
            this.tb_nom.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombre:";
            // 
            // dg_dep
            // 
            this.dg_dep.AllowUserToAddRows = false;
            this.dg_dep.AllowUserToDeleteRows = false;
            this.dg_dep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dep.Location = new System.Drawing.Point(12, 183);
            this.dg_dep.MultiSelect = false;
            this.dg_dep.Name = "dg_dep";
            this.dg_dep.ReadOnly = true;
            this.dg_dep.RowTemplate.Height = 25;
            this.dg_dep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dep.Size = new System.Drawing.Size(488, 292);
            this.dg_dep.TabIndex = 36;
            this.dg_dep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dep_CellContentClick);
            this.dg_dep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dep_CellContentClick_1);
            this.dg_dep.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dep_CellContentClick);
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 505);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_ag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_dep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Departamentos";
            this.Text = "Departamentos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private RadioButton rb_elll;
        private RadioButton rb_eddd;
        private RadioButton rb_aggg;
        private Button button4;
        private Button bt_ag;
        private GroupBox groupBox1;
        private TextBox tb_nom;
        private Label label9;
        private DataGridView dg_dep;
        private CheckBox cb_dev;
    }
}