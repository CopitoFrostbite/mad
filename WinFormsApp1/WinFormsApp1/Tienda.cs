using Aspose.Pdf;
using Aspose.Pdf.Operators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
            var obj = new EnlaceDB();
            var tabla = new DataTable();
            
            tabla = obj.Consulta("spGestionTienda", "SE", 0, "");
            
            
            table = tabla;
            tb_nomt.Text = (table.Rows[0]["Nombre"].ToString());
            tb_suct.Text = (table.Rows[0]["Sucursal"].ToString());
            tb_dirt.Text = (table.Rows[0]["Direccion"].ToString());
            tb_ms1.Text = (table.Rows[0]["Mensaje1"].ToString());
            tb_ms2.Text = (table.Rows[0]["Mensaje2"].ToString());
            tb_mi1.Text = (table.Rows[0]["Mensaje3"].ToString());
            tb_mi2.Text = (table.Rows[0]["Mensaje4"].ToString());
        }
        private DataTable table = new DataTable();
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bt_agt_Click(object sender, EventArgs e)
        {
            var obj = new EnlaceDB();
            var tabla = new DataTable();
            
            obj.Tienda("UP", tb_nomt.Text, tb_suct.Text, tb_dirt.Text, tb_ms1.Text, tb_ms2.Text, tb_mi1.Text, tb_mi2.Text);
            tabla = obj.Consulta("spGestionTienda", "SE", 0, "");

            table = tabla;

            tb_nomt.Text = (table.Rows[0]["Nombre"].ToString());
            tb_suct.Text = (table.Rows[0]["Sucursal"].ToString());
            tb_dirt.Text = (table.Rows[0]["Direccion"].ToString());
            tb_ms1.Text = (table.Rows[0]["Mensaje1"].ToString());
            tb_ms2.Text = (table.Rows[0]["Mensaje2"].ToString());
            tb_mi1.Text = (table.Rows[0]["Mensaje3"].ToString());
            tb_mi2.Text = (table.Rows[0]["Mensaje4"].ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
