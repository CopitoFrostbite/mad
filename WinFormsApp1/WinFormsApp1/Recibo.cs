using Aspose.Pdf;
using Aspose.Pdf.Operators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Recibo : Form
    {
        public Recibo()
        {
            InitializeComponent();
            var obj = new EnlaceDB();
            var tabla = new DataTable();
            tabla = obj.Consulta("spGestionCaja", "SE2", 0, "");

            foreach (DataRow row in tabla.Rows)
            {
                cb_cajr.Items.Add(row["Numero"].ToString());
            }
            dt_fr.Enabled= false;
            cb_cajr.Enabled= false;
            ntb_selec.Enabled= false;
            ntb_selec.Value = 0;
            ntb_select.Enabled = false;
            ntb_select.Value = 0;
        }

        private DataTable tablerec = new DataTable();
        private DataTable tablerec2 = new DataTable();
        private void rb_agr_CheckedChanged(object sender, EventArgs e)
        {
            rb_fr.Enabled = true;
            ntb_selec.Value = 0;
            ntb_select.Value = 0;
            dg_rec.DataSource = null;
            ntb_idr.Enabled = true;
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        private void dt_fr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rb_not_CheckedChanged(object sender, EventArgs e)
        {
            dt_fr.Enabled = false;
            rb_fr.Enabled = false;
            cb_cajr.Enabled = false;
            rb_idr.Checked= true;
            ntb_selec.Value = 0;
            ntb_select.Value = 0;
            dg_rec.DataSource = null;
            ntb_idr.Enabled = true;
        }

        private void rb_idr_CheckedChanged(object sender, EventArgs e)
        {
            dt_fr.Enabled = false;
            cb_cajr.Enabled = false;
            
            ntb_selec.Value = 0;
            ntb_select.Value = 0;
            dg_rec.DataSource = null;
            ntb_idr.Enabled = true;
        }

        private void rb_fr_CheckedChanged(object sender, EventArgs e)
        {
            dt_fr.Enabled = true;
            cb_cajr.Enabled = true;
            ntb_idr.Enabled = false;
            ntb_selec.Value = 0;
            ntb_select.Value = 0;
            dg_rec.DataSource = null;

        }

        public bool isValid()
        {

            var msg = "";
            if (ntb_idr.Value  == 0)
            {
                msg = "Seleccione una ID";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
          
            return true;

        }

        public bool isValid2()
        {

            var msg = "";
            if (cb_cajr.SelectedIndex == -1)
            {
                msg = "Seleccione una caja";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;

        }

        public bool isValid3()
        {

            var msg = "";
            if (dg_rec.CurrentRow == null)
            {
                msg = "Seleccione una fila";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;

        }

        private void bt_busr_Click(object sender, EventArgs e)
        {
          
            var obj = new EnlaceDB();
            var tablab = new DataTable();
            if (rb_rec.Checked == true) 
            {
                if (rb_idr.Checked == true && this.isValid()) 
                {
                   tablab= obj.Consulta("spGestionRecibo", "SE3",Convert.ToInt32( ntb_idr.Value), "");
                   dg_rec.DataSource=tablab;
                    dg_rec.Columns["Precio"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["Descuento"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["DescuentoTotal"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["Subtotal"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["Total"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["TotalProd"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["Pago"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["Cantidad"].DefaultCellStyle.Format = "n2";
                    tablerec = tablab;
                    tablab = obj.Consulta("spGestionRecibo", "SE5", Convert.ToInt32(ntb_idr.Value), "");
                    tablerec2 = tablab;


                }
                
                if (rb_fr.Checked == true && this.isValid2()) 
                {
                    tablab = obj.Consulta("spGestionRecibo", "SE4", Convert.ToInt32(cb_cajr.Text), dt_fr.Text);
                    dg_rec.DataSource = tablab;
                    dg_rec.Columns["Precio"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["Descuento"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["DescuentoTotal"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["Subtotal"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["Total"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["TotalProd"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["Pago"].DefaultCellStyle.Format = "c2";
                    dg_rec.Columns["Cantidad"].DefaultCellStyle.Format = "n2";
                    tablerec = tablab;
                    tablab = obj.Consulta("spGestionRecibo", "SE6", Convert.ToInt32(cb_cajr.Text), dt_fr.Text);
                    tablerec2 = tablab;
                }
            }
            if(rb_not.Checked == true && this.isValid()) 
            {
                decimal i = 0;
                tablab = obj.Consulta("spGestionDevoluciones", "SE2", Convert.ToInt32(ntb_idr.Value), "");
                dg_rec.DataSource = tablab;
               
               
                dg_rec.Columns["Subtotal"].DefaultCellStyle.Format = "c2";
                dg_rec.Columns["Total"].DefaultCellStyle.Format = "c2";               
               
                dg_rec.Columns["Cantidad"].DefaultCellStyle.Format = "n2";
                tablerec = tablab;
                foreach (DataRow table2 in tablerec.Rows)

                {

                    i += Convert.ToDecimal(table2["Total"]);

                }

                ntb_select.Value = i;
               
            }
        }

        private void dg_rec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && rb_rec.Checked == true) 
            {
                ntb_selec.Value = Convert.ToInt32(tablerec.Rows[e.RowIndex]["Orden"]);
                ntb_select.Value = Convert.ToInt32(tablerec.Rows[e.RowIndex]["Total"]);

            }
            
            if (e.RowIndex > -1 && rb_not.Checked == true) 
            {
                ntb_selec.Value = Convert.ToInt32(tablerec.Rows[e.RowIndex]["Recibo"]);
            }
        }

        private void bt_imp_Click(object sender, EventArgs e)
        {
            var msg = "";
            if ( rb_rec.Checked == true && this.isValid3())
            {

                pdfman.recibo(tablerec2);
                msg = "Archivo generado";
                MessageBox.Show(msg, "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }

            if ( rb_not.Checked == true && this.isValid3())
            {
                pdfman.devo(tablerec, Convert.ToDecimal(ntb_select.Value));
                msg = "Archivo generado";
                MessageBox.Show(msg, "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void bt_regr_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
