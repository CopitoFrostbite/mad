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
            cb_metr.SelectedItem= "Todos";
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
