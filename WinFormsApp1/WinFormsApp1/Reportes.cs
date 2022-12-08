using Aspose.Pdf;
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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            var obj = new EnlaceDB();
            var tabla = new DataTable();
            tabla = obj.Consulta("spGestionDepartamento", "SE2", 0, "");
            

            foreach (DataRow row in tabla.Rows)
            {
                cb_metr.Items.Add(row["Departamento"].ToString());
            }
            cb_metr.Items.Add("Todos");
            cb_metr.SelectedItem = "Todos";
            tabla = obj.Consulta("spGestionCaja", "SE3", 0, "");
            foreach (DataRow row in tabla.Rows)
            {
                cb_caj.Items.Add(row["Numero"].ToString());
            }
            cb_caj.Items.Insert(0,"Todos");
            cb_caj.SelectedItem = "Todos";
            tabla = obj.Consulta("spGestionUsuarios", "SE6", 0, "");
            foreach (DataRow row in tabla.Rows)
            {
                cb_caje.Items.Add(row["Usuario"].ToString());
            }
            cb_caje.Items.Insert(0, "Todos");
            cb_caje.SelectedItem = "Todos";

        }

        private void bt_bus_Click(object sender, EventArgs e)
        {
            if (rb_inv.Checked) 
            {
                var obj = new EnlaceDB();
                var tabla2 = new DataTable();
                tabla2 = obj.Rep_Inventario("SE", cb_ago.Checked, cb_em.Checked, cb_mer.Checked, cb_metr.Text);
               
                dg_rep.DataSource = tabla2;
                dg_rep.Columns["Precio"].DefaultCellStyle.Format = "c2";
                dg_rep.Columns["Costo"].DefaultCellStyle.Format = "c2";
            }
            if (rb_ven.Checked)
            {
                var obj = new EnlaceDB();
                var tabla2 = new DataTable();
                tabla2 = obj.Rep_Ventas("SE", dt_fini.Text, dt_ffin.Text, cb_caj.SelectedIndex, cb_metr.Text);

                dg_rep.DataSource = tabla2;
                dg_rep.Columns["Precio_U"].DefaultCellStyle.Format = "c2";
                dg_rep.Columns["Subtotal"].DefaultCellStyle.Format = "c2";
                dg_rep.Columns["Descuento"].DefaultCellStyle.Format = "c2";
                dg_rep.Columns["Venta"].DefaultCellStyle.Format = "c2";
                dg_rep.Columns["Utilidad"].DefaultCellStyle.Format = "c2";
            }
            if (rb_caj.Checked)
            {
                var obj = new EnlaceDB();
                var tabla2 = new DataTable();
                tabla2 = obj.Rep_Cajero("SE", dt_fini.Text, dt_ffin.Text, cb_caj.Text, cb_metr.Text);

                dg_rep.DataSource = tabla2;               
                dg_rep.Columns["Venta"].DefaultCellStyle.Format = "c2";
                dg_rep.Columns["Utilidad"].DefaultCellStyle.Format = "c2";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_inv_CheckedChanged(object sender, EventArgs e)
        {
            cb_metr.Show();
            label11.Show();
            cb_ago.Show();
            cb_em.Show();
            cb_mer.Show();
            label1.Hide();
            cb_caj.Hide();
            dt_fini.Hide();
            dt_ffin.Hide();
            label2.Hide();
            cb_caje.Hide();
            label3.Hide();
            label4.Hide();
            dg_rep.DataSource = null;
        }

        private void rb_ven_CheckedChanged(object sender, EventArgs e)
        {
            cb_metr.Show();
            label11.Show();
            cb_ago.Hide();
            cb_em.Hide();
            cb_mer.Hide();
            label1.Show();
            cb_caj.Show();
            dt_fini.Show();
            dt_ffin.Show();
            label2.Hide();
            cb_caje.Hide();
            label3.Show();
            label4.Show();
            dg_rep.DataSource = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rb_caj_CheckedChanged(object sender, EventArgs e)
        {
            cb_metr.Show();
            label11.Show();
            cb_ago.Hide();
            cb_em.Hide();
            cb_mer.Hide();
            label1.Hide();
            cb_caj.Hide();
            dt_fini.Show();
            dt_ffin.Show();
            label2.Show();
            cb_caje.Show();
            label3.Show();
            label4.Show();
            dg_rep.DataSource = null;
        }

        private void dg_rep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
