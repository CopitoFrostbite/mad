using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private string use = "";

        private bool C = false;

        public bool getC()
        {
           return this.C;
        }
        public void setC(bool x)
        {
            this.C = x;
        }
        public void setuse(string x) 
        {
            this.use = x;
        }

        public String getuse()
        {
            return this.use;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            var obj = new EnlaceDB();
            var tabla = new DataTable();
           
            tabla = obj.Consulta("spGestionInventario","SE8",0,"");
            dataGridView1.DataSource = tabla;
            lb_US.Text = "Usuario: " + use ;

            var obj2 = new EnlaceDB();
           
            obj2.Consulta("spGestionDescuentos","UP2",0,"");
            if (this.getC())
            {
                this.bt_ven.Hide();
                this.gb_ges.Show();
                this.bt_caja.Show();
                this.bt_inv.Show();
                this.bt_usu.Show();
                this.bt_rep.Show();
                this.bt_caja.Show();
                this.cb_caj.Hide();
                this.lb_caj.Hide();
                this.bt_ti.Show();
                this.bt_rec.Show();
                this.bt_devol.Show();
            }
            else
            {
                this.bt_ven.Show();
                this.gb_ges.Hide();
                this.bt_caja.Hide();
                this.bt_inv.Hide();
                this.bt_usu.Hide();
                this.bt_rep.Hide();
                this.bt_caja.Hide();
                this.cb_caj.Show();
                this.lb_caj.Show();
                this.bt_ti.Hide();
                this.bt_rec.Hide();
                this.bt_devol.Hide();
                tabla = obj.Consulta("spGestionCaja", "SE2", 0,"");
               
                foreach (DataRow row in tabla.Rows)
                {
                    cb_caj.Items.Add(row["Numero"].ToString());
                }

            }

        }

        private void awaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Personal_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_ven_Click(object sender, EventArgs e)
        {
            if (cb_caj.SelectedIndex != -1)
            {
                
                Ventas ventas = new Ventas();
                ventas.setcaja2(Convert.ToInt32(cb_caj.Text));
                ventas.setuser2(use);
                ventas.setuser("Cajero: " + use);
                ventas.setcaja("Caja: " + cb_caj.Text);
                var obj = new EnlaceDB();
                obj.Add_Ventas("IN", Convert.ToInt32(cb_caj.Text), use,0,0,0);
                ventas.ShowDialog();
            }
            else 
            {
                var msg = "";
                msg = "Seleccione una caja";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cb_caj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_inv_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.ShowDialog();
        }

        private void bt_caja_Click(object sender, EventArgs e)
        {
            Cajas cajas = new Cajas();
            cajas.ShowDialog();
        }

        private void bt_ti_Click(object sender, EventArgs e)
        {
            Tienda tienda= new Tienda();
            tienda.ShowDialog();
        }

        private void bt_devol_Click(object sender, EventArgs e)
        {
            Devoluciones devoluciones= new Devoluciones();
            devoluciones.ShowDialog();
        }

        private void bt_reg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_rec_Click(object sender, EventArgs e)
        {
            Recibo recibo= new Recibo();
            recibo.ShowDialog();
        }

        private void bt_rep_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.ShowDialog();
        }
    }
}
