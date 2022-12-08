namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_LogEntr = new System.Windows.Forms.Button();
            this.bt_LogSal = new System.Windows.Forms.Button();
            this.tb_LogUs = new System.Windows.Forms.TextBox();
            this.tb_LogPas = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_LogEntr
            // 
            this.bt_LogEntr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bt_LogEntr.FlatAppearance.BorderSize = 0;
            this.bt_LogEntr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_LogEntr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_LogEntr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogEntr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_LogEntr.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_LogEntr.Location = new System.Drawing.Point(188, 183);
            this.bt_LogEntr.Name = "bt_LogEntr";
            this.bt_LogEntr.Size = new System.Drawing.Size(256, 30);
            this.bt_LogEntr.TabIndex = 0;
            this.bt_LogEntr.Text = "ENTRAR";
            this.bt_LogEntr.UseVisualStyleBackColor = false;
            this.bt_LogEntr.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_LogSal
            // 
            this.bt_LogSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bt_LogSal.FlatAppearance.BorderSize = 0;
            this.bt_LogSal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bt_LogSal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_LogSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LogSal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_LogSal.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_LogSal.Location = new System.Drawing.Point(189, 223);
            this.bt_LogSal.Name = "bt_LogSal";
            this.bt_LogSal.Size = new System.Drawing.Size(256, 30);
            this.bt_LogSal.TabIndex = 1;
            this.bt_LogSal.Text = "SALIR";
            this.bt_LogSal.UseVisualStyleBackColor = false;
            this.bt_LogSal.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_LogUs
            // 
            this.tb_LogUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_LogUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_LogUs.Location = new System.Drawing.Point(188, 83);
            this.tb_LogUs.Name = "tb_LogUs";
            this.tb_LogUs.Size = new System.Drawing.Size(257, 23);
            this.tb_LogUs.TabIndex = 3;
            this.tb_LogUs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_LogPas
            // 
            this.tb_LogPas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_LogPas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_LogPas.Location = new System.Drawing.Point(188, 140);
            this.tb_LogPas.Name = "tb_LogPas";
            this.tb_LogPas.Size = new System.Drawing.Size(257, 23);
            this.tb_LogPas.TabIndex = 4;
            this.tb_LogPas.UseSystemPasswordChar = true;
            this.tb_LogPas.TextChanged += new System.EventHandler(this.tb_LogPas_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 281);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(292, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "LOGIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(188, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(188, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "CONTRASEÑA";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(538, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_LogPas);
            this.Controls.Add(this.tb_LogUs);
            this.Controls.Add(this.bt_LogSal);
            this.Controls.Add(this.bt_LogEntr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_LogEntr;
        private Button bt_LogSal;
        private TextBox tb_LogUs;
        private TextBox tb_LogPas;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label2;
    }
}