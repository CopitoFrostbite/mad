using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace WinFormsApp1
{

    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var us = tb_LogUs.Text;
            var pa = tb_LogPas.Text;
            var con= new EnlaceDB();

            if (con.Autentificar(us, pa))
            {
                Main main = new Main();
                main.setuse(us);             
               
                main.setC((bool)con.obtenertabla.Rows[0]["Nivel_cuenta"]);
               
                main.ShowDialog();
                

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var msg = "";
            msg = "Seguro que desea Salir de la aplicacion? ";
            if (MessageBox.Show(msg, "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else return;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_LogPas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}