using Aspose.Pdf;
using Aspose.Pdf.Operators;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Devoluciones : Form
    {
        
        public Devoluciones()
        {
            InitializeComponent();
        }
        private DataTable tabled = new DataTable();
        private DataTable tabled2 = new DataTable();
        private int idd = 0;
        private int idd2 = 0;
        private int ido = 0;
        private int ido2 = 0;
        private decimal sub = 0;
        private decimal can = 0;
        bool devo = false;
        private void cb_actd_CheckedChanged(object sender, EventArgs e)
        {

        }

        public bool isValid()
        {

            var msg = "";
            if (tb_motd.Text.Length == 0)
            {
                msg = "Falta el motivo";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
           

            if (ntb_cand.Value == 0)
            {
                msg = "La cantidad debe ser mayor a 0";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (ntb_cand.Value > can)
            {
                msg = "La cantidad no debe superar a los articulos comprados";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (devo == false) 
            {
                msg = "Este articulo no permite la devolucion";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            
            return true;

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

        private void ntb_idde_ValueChanged(object sender, EventArgs e)
        {
            var obj = new EnlaceDB();
            var tablab = new DataTable();
            tablab = obj.Consulta("spGestionRecibo", "SE2", Convert.ToInt32(ntb_idde.Value), "");
            dg_busdd.DataSource = tablab;
            tabled = tablab;
            dg_busdd.Columns["Precio"].DefaultCellStyle.Format = "c2";
            
            dg_busdd.Columns["Descuento"].DefaultCellStyle.Format = "n0";
            dg_busdd.Columns["Subtotal"].DefaultCellStyle.Format = "c2";
            dg_busdd.Columns["TotalProd"].DefaultCellStyle.Format = "c2";
            dg_busdd.ClearSelection();
        }

        private void bt_devo_Click(object sender, EventArgs e)
        {
            var msg = "";
            if ( ntb_totd.Value > 0)
            {

                msg = "Devolucion aceptada";
                MessageBox.Show(msg, "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var obj = new EnlaceDB();

                DataTable a = new DataTable();
                DataTable b = new DataTable();
                b = obj.Consulta("spGestionDevoluciones", "SE", ido, "");
                foreach (DataRow tablep in b.Rows)

                {
                   if (!Convert.ToBoolean(tablep["Merma"])) obj.Add_Inventario2("UP3", Convert.ToInt32(tablep["Articulo"]), Convert.ToDecimal(tablep["Cantidad"]));
                   else obj.Add_Inventario2("UP4", Convert.ToInt32(tablep["Articulo"]), Convert.ToDecimal(tablep["Cantidad"]));

                }
                a = obj.Consulta("spGestionDevoluciones", "SE", ido, "");
                pdfman.devo(a,Convert.ToDecimal( ntb_totd.Value));      

                
                ClearTextBoxes(this.Controls);
                
                dg_busdd.DataSource = null;
                dg_devo.DataSource = null;              
               
                ntb_idde.Enabled= true;
                idd = 0;
                idd2 = 0;
                ido = 0;
                ido2 = 0;
                sub = 0;
                can = 0;
                devo = false;
                ntb_totd.Value= 0;
                ntb_totd.ResetText();

    }
            else
            {
                msg = "Faltan fondos o seleccionar al menos un articulo";
                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dg_busdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) 
            {
                ido = Convert.ToInt32(tabled.Rows[e.RowIndex]["Orden"]);
                idd = Convert.ToInt32(tabled.Rows[e.RowIndex]["Articulo"]);
                sub = Convert.ToDecimal(tabled.Rows[e.RowIndex]["Subtotal"]);
                can = Convert.ToDecimal(tabled.Rows[e.RowIndex]["Cantidad"]);
                devo = Convert.ToBoolean(tabled.Rows[e.RowIndex]["Devolucion"]);
            }
            
        }

        private void bt_remd_Click(object sender, EventArgs e)
        {
            var msg = "";
            var obj = new EnlaceDB();
            var tablab = new DataTable();
            if (ntb_cand.Value != 0 && dg_busdd.SelectedRows.Count != 0 && idd != 0 && this.isValid() && ntb_idde.Enabled == false)
            {
                obj.Add_Devolucion("IN", ido, idd, tb_motd.Text, cb_actd.Checked, ntb_cand.Value, sub, ntb_cand.Value * sub);


                tablab = obj.Consulta("spGestionDevoluciones", "SE", ido, "");
                dg_devo.DataSource = tablab;
                tabled2 = tablab;

                dg_devo.Columns["Subtotal"].DefaultCellStyle.Format = "c2";
                dg_devo.Columns["Total"].DefaultCellStyle.Format = "c2";
                dg_devo.ClearSelection();
                decimal i = 0;
               
                foreach (DataRow table2 in tabled2.Rows)

                {

                    i += Convert.ToDecimal(table2["Total"]);

                }

                ntb_totd.Value = i;

                
            }
            else
            {
                msg = "Asegurese de seleccionar un recibo , un articulo y su cantidad sea mayor a 0";
                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void bt_sel_Click(object sender, EventArgs e)
        {
            
            //var obj = new EnlaceDB();
            //var tablab = new DataTable();

            //tablab = obj.Consulta("spGestionDevoluciones", "SE", Convert.ToInt32( ntb_idde.Value), "");
            //dg_devo.DataSource = tablab;
            //tabled2 = tablab;
            ntb_idde.Enabled= false;
            //dg_devo.Columns["Subtotal"].DefaultCellStyle.Format = "c2";
            //dg_devo.Columns["Total"].DefaultCellStyle.Format = "c2";
            //dg_devo.ClearSelection();
        }

        private void dg_devo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idd2 = Convert.ToInt32(tabled2.Rows[e.RowIndex]["Articulo"]);
            ido2 = Convert.ToInt32(tabled2.Rows[e.RowIndex]["Recibo"]);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var msg = "";
            msg = "Confirme que desea remover el articulo  " + idd2.ToString();
            if (idd2 == 0)
            {
                msg = "Debe existir articulos para eliminarlos";
                MessageBox.Show(msg, "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show(msg, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes && dg_devo.SelectedRows.Count != 0 && idd2 != 0)
            {
                var obj = new EnlaceDB();
                var tablab = new DataTable();
                if (dg_devo.SelectedRows.Count != 0 && idd2 != 0)
                {
                    msg = "El articulo  " + idd2.ToString() + " fue eliminado";
                    MessageBox.Show(msg, "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    obj.Del_Devolucion("DE", ido2, idd2);


                    tablab = obj.Consulta("spGestionDevoluciones", "SE", ido, "");
                    dg_devo.DataSource = tablab;
                    tabled2 = tablab;

                    dg_devo.Columns["Subtotal"].DefaultCellStyle.Format = "c2";
                    dg_devo.Columns["Total"].DefaultCellStyle.Format = "c2";
                   
                    decimal i = 0;

                    foreach (DataRow table2 in tabled2.Rows)

                    {

                        i += Convert.ToDecimal(table2["Total"]);

                    }

                    ntb_totd.Value = i;
                    idd2 = 0;
                    ido2= 0;
                    dg_devo.ClearSelection();
                }
                else
                {
                    msg = "Asegurese de seleccionar un articulo";
                    MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else return;
        }

        private void dg_devo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ntb_totd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_regr_Click(object sender, EventArgs e)
        {
            var msg = "";
            msg = "Seguro que desea regresar? se anulara la devolucion actual!";
            if (MessageBox.Show(msg, "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                if(dg_devo.SelectedRows.Count != 0) 
                {
                    msg = "Elimine los articulos existentes";
                    MessageBox.Show(msg, "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else this.Close();


            }
            else return;
        }
    }
}
