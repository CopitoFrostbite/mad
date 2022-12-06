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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_LogEntr
            // 
            this.bt_LogEntr.Location = new System.Drawing.Point(161, 103);
            this.bt_LogEntr.Name = "bt_LogEntr";
            this.bt_LogEntr.Size = new System.Drawing.Size(59, 21);
            this.bt_LogEntr.TabIndex = 0;
            this.bt_LogEntr.Text = "Entrar";
            this.bt_LogEntr.UseVisualStyleBackColor = true;
            this.bt_LogEntr.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_LogSal
            // 
            this.bt_LogSal.Location = new System.Drawing.Point(233, 103);
            this.bt_LogSal.Name = "bt_LogSal";
            this.bt_LogSal.Size = new System.Drawing.Size(60, 21);
            this.bt_LogSal.TabIndex = 1;
            this.bt_LogSal.Text = "Salir";
            this.bt_LogSal.UseVisualStyleBackColor = true;
            this.bt_LogSal.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_LogUs
            // 
            this.tb_LogUs.Location = new System.Drawing.Point(132, 20);
            this.tb_LogUs.Name = "tb_LogUs";
            this.tb_LogUs.Size = new System.Drawing.Size(161, 23);
            this.tb_LogUs.TabIndex = 3;
            this.tb_LogUs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_LogPas
            // 
            this.tb_LogPas.Location = new System.Drawing.Point(132, 60);
            this.tb_LogPas.Name = "tb_LogPas";
            this.tb_LogPas.Size = new System.Drawing.Size(161, 23);
            this.tb_LogPas.TabIndex = 4;
            this.tb_LogPas.UseSystemPasswordChar = true;
            this.tb_LogPas.TextChanged += new System.EventHandler(this.tb_LogPas_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 136);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_LogPas);
            this.Controls.Add(this.tb_LogUs);
            this.Controls.Add(this.bt_LogSal);
            this.Controls.Add(this.bt_LogEntr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
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
        private Label label1;
        private Label label2;
    }
}