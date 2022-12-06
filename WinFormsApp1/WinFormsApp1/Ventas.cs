using Microsoft.VisualBasic;
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
    public partial class Ventas : Form
    {
        
        public Ventas()
        {
            InitializeComponent();
            
            lb_time.Text = DateTime.Now.ToString();
            timer1.Enabled = true;
            if (rb_id.Checked == true) tb_nom.Enabled = false;
            else ntb_id.Enabled = false;
            var obj = new EnlaceDB();
            var tabla = new DataTable();
            tabla = obj.Consulta("spGestionPago", "SE", 0, "");

            foreach (DataRow row in tabla.Rows)
            {
                cb_met.Items.Add(row["Metodo"].ToString());
            }
            

        }

        private DataTable table = new DataTable();
        private DataTable table2 = new DataTable();
        private DataTable tablep = new DataTable();
        private string use = "";
        private string user = "";
        private int caj = 0;
        private int id = 0;
        private int id2 = 0;
        private int idp = 1;
        private int idp2 = 1;
        public String getuse()
        {
            return this.use;
        }
        public void setuse(string x)
        {
            this.use = x;
        }

        public void setuser(string x)
        {
            this.lb_caj2.Text = x;
        }

        public void setcaja(string x)
        {
            this.lb_caja.Text = x;
        }

        public void setuser2(string x)
        {
            this.user = x;
        }

        public void setcaja2(int x)
        {
            this.caj = x;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString();
        }

        private void rb_id_CheckedChanged(object sender, EventArgs e)
        {
            ntb_id.Enabled = true;
            tb_nom.Enabled = false;
        }

        private void rb_nom_CheckedChanged(object sender, EventArgs e)
        {
            ntb_id.Enabled = false;
            tb_nom.Enabled = true;
        }

        

        

        private void ntb_id_ValueChanged(object sender, EventArgs e)
        {
            var obj = new EnlaceDB();
            var tablab = new DataTable();
            tablab = obj.Consulta("spGestionInventario", "SE5", Convert.ToInt32(ntb_id.Value),"");
            dg_bus.DataSource = tablab;
            table = tablab;
            dg_bus.Columns["Precio"].DefaultCellStyle.Format = "c2";
            dg_bus.Columns["Descuento"].DefaultCellStyle.Format = "n0";
            dg_bus.ClearSelection();
            
        }

        private void ntb_id_TextChanged(object sender, EventArgs e)
        {
           // var obj = new EnlaceDB();
           // var tablab = new DataTable();
           // tablab = obj.Consulta("spGestionInventario", "SE", Convert.ToInt32(ntb_id.Text));
           // dg_bus.DataSource = tablab;
           
        }

        private void tb_nom_TextChanged(object sender, EventArgs e)
        {
            var obj = new EnlaceDB();
            var tablab = new DataTable();
            tablab = obj.Consulta("spGestionInventario", "SE4", 0, tb_nom.Text);
            dg_bus.DataSource = tablab;
            table = tablab;

            dg_bus.Columns["Precio"].DefaultCellStyle.Format = "c2";
            dg_bus.Columns["Descuento"].DefaultCellStyle.Format = "n0";
            dg_bus.ClearSelection();
            
        }

        private void dg_bus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // String x = "";
            // if (e.RowIndex > -1) x = table.Rows[e.RowIndex]["Activo"].ToString();
            // if (x == "True") tb_des.Text = table.Rows[e.RowIndex]["Porcentaje"].ToString();
            // else tb_des.Text = "";
            // if (e.RowIndex > -1) tb_pre.Text = table.Rows[e.RowIndex]["Precio_U"].ToString();
            // if (e.RowIndex > -1)
            //    tb_ex.Text = table.Rows[e.RowIndex]["Existencia"].ToString();


            if (e.RowIndex > -1) id = Convert.ToInt32(table.Rows[e.RowIndex]["ID"]) ;
        }

        private void tb_ex_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_agr_Click(object sender, EventArgs e)
        {
            var msg = "";
            var obj = new EnlaceDB();
            var tablab = new DataTable();
            if (ntb_can.Value != 0 && dg_bus.SelectedRows.Count != 0 && id != 0)
            { 
                obj.Add_Articulos("IN", id, ntb_can.Value);

               
                tablab = obj.Consulta("spGestionArticulos", "SE", 0, "");
               dg_lis.DataSource = tablab;
                table2 = tablab;
                dg_lis.Columns["Precio"].DefaultCellStyle.Format = "c2";
                dg_lis.Columns["Descuento"].DefaultCellStyle.Format = "c2";
                dg_lis.Columns["Subtotal"].DefaultCellStyle.Format = "c2";
                dg_lis.Columns["Total"].DefaultCellStyle.Format = "c2";
                dg_lis.ClearSelection();
                decimal i = 0;
                decimal j = 0;
                foreach (DataRow table2 in table2.Rows)

                {

                    i += Convert.ToDecimal(table2["Total"]);

                }

                ntb_tot.Value = i;

                foreach (DataRow table2 in table2.Rows)

                {

                    j += (Convert.ToInt32(table2["Descuento"])) * (Convert.ToDecimal(table2["Cantidad"]));

                }
                ntb_des.Value = j;
            }
            else 
            {
                msg = "Asegurese de seleccionar un articulo y su cantidad sea mayor a 0";
                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void ntb_can_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_rem_Click(object sender, EventArgs e)
        {
            var msg = "";
            msg = "Confirme que desea remover el articulo  " + id2.ToString();
            if (id2 == 0)
            {
                msg = "Debe existir articulos para eliminarlos";
                MessageBox.Show(msg, "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show(msg, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes && dg_bus.SelectedRows.Count != 0 && id2 != 0)
            {
                var obj = new EnlaceDB();
                var tablab = new DataTable();
                if (dg_bus.SelectedRows.Count != 0 && id2 != 0)
                {
                    msg = "El articulo  " + id2.ToString() + " fue eliminado";
                    MessageBox.Show(msg, "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    obj.Add_Articulos("DE", id2, 0);


                    tablab = obj.Consulta("spGestionArticulos", "SE", 0, "");
                    dg_lis.DataSource = tablab;
                    table2 = tablab;
                    dg_lis.Columns["Precio"].DefaultCellStyle.Format = "c2";
                    dg_lis.Columns["Descuento"].DefaultCellStyle.Format = "c2";
                    dg_lis.Columns["Subtotal"].DefaultCellStyle.Format = "c2";
                    dg_lis.Columns["Total"].DefaultCellStyle.Format = "c2";
                    dg_lis.ClearSelection();
                    int i = 0;
                    int j = 0;
                    foreach (DataRow table2 in table2.Rows)

                    {

                        i += Convert.ToInt32(table2["Total"]);

                    }
                    ntb_tot.Value = i;
                    foreach (DataRow table2 in table2.Rows)

                    {

                        j += (Convert.ToInt32(table2["Descuento"])) * (Convert.ToInt32(table2["Cantidad"]));

                    }
                    ntb_des.Value = j;
                    id2 = 0;
                }
                else
                {
                    msg = "Asegurese de seleccionar un articulo";
                    MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else return;
           
        }

        private void dg_lis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) id2 = Convert.ToInt32(table2.Rows[e.RowIndex]["Articulo"]);
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

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

        private void cb_met_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_pag_Click(object sender, EventArgs e)
        {
            var msg = "";
            var obj = new EnlaceDB();
            var tablab = new DataTable();
            if (cb_met.SelectedIndex != -1 && ntb_tot.Value > 0 && idp != 0 && ntb_pag.Value != 0)
            {
                obj.Add_Pagos("IN", idp, cb_met.SelectedIndex, ntb_pag.Value);


                tablab = obj.Consulta("spGestionPagos", "SE", 0, "");
                dg_p.DataSource = tablab;
                tablep = tablab;
                dg_p.Columns["Monto"].DefaultCellStyle.Format = "c2";

                dg_p.ClearSelection();
                decimal i = 0;
                foreach (DataRow tablep in tablep.Rows)

                {

                    i += Convert.ToDecimal(tablep["Monto"]);

                }

                ntb_pagt.Value = i;
                idp++;
            }
            else 
            {
                msg = "Asegurese de seleccionar un metodo de pago y que este sea mayor a 0";
                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ntb_pag_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ntb_pagt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_vent_Click(object sender, EventArgs e)
        {
            var msg = "";
            if (ntb_pagt.Value >= ntb_tot.Value && ntb_tot.Value > 0) 
            {

                msg = "Pago aceptado";
                MessageBox.Show(msg, "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var obj = new EnlaceDB();
                
                obj.Add_Ventas("UP2", 0, "",ntb_des.Value, ntb_tot.Value, ntb_pagt.Value);
                obj.Add_Ticket("IN", 0, (ntb_pagt.Value - ntb_tot.Value));
                DataTable a = new DataTable();
                DataTable b = new DataTable();
                b = obj.Consulta("spGestionArticulos", "SE4", 0, "");
                foreach (DataRow tablep in b.Rows)

                {
                    obj.Add_Inventario2("UP2",Convert.ToInt32(tablep["Articulo"]), Convert.ToDecimal(tablep["Cantidad"]));


                }
                a = obj.Consulta("spGestionArticulos", "SE3", 0, "");
                pdfman.recibo(a);
                obj.Add_Ventas("IN", caj, user, 0,0,0);
                
                rb_id.Checked= true;
                ClearTextBoxes(this.Controls);
                ntb_des.Text = "0";
                ntb_des.Value = 0;
                ntb_tot.Value = 0;
                ntb_pagt.Value = 0;
             
                dg_bus.DataSource = null;
                dg_lis.DataSource = null;
                dg_p.DataSource = null;
                cb_met.SelectedIndex=-1;
                
            }
            else 
            {
                msg = "Faltan fondos o seleccionar al menos un articulo";
                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var msg = "";
            msg = "Seguro que desea regresar? se anulara la venta actual!" ;
            if (MessageBox.Show(msg, "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                var obj = new EnlaceDB();
                obj.Del_Pagos("DE2",0);
                obj.Del_Articulos("DE2");
                obj.Del_Ventas("DE");

                this.Close();
            }
            else return;
            
        }

        private void dg_bus_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lb_caj2_Click(object sender, EventArgs e)
        {

        }

        private void bt_remp_Click(object sender, EventArgs e)
        {
            var msg = "";
            msg = "Confirme que desea remover el pago  " + idp2.ToString();
            if (idp2 == 0) 
            {
                msg = "Debe existir pago para eliminarlo" ;
                MessageBox.Show(msg, "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (MessageBox.Show(msg, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes && idp2 != 0 && dg_p.SelectedRows.Count != 0)
            {
                var obj = new EnlaceDB();
                var tablab = new DataTable();
                if (dg_p.SelectedRows.Count != 0 && idp2 != 0)
                {
                    

                    msg = "El pago  " + idp2.ToString() + " fue eliminado";
                    MessageBox.Show(msg, "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    obj.Del_Pagos("DE", idp2);



                    
                    tablab = obj.Consulta("spGestionPagos", "SE", 0, "");
                    dg_p.DataSource = tablab;
                    tablep = tablab;
                    dg_p.Columns["Monto"].DefaultCellStyle.Format = "c2";

                    dg_p.ClearSelection();
                    decimal i = 0;
                    foreach (DataRow tablep in tablep.Rows)

                    {

                        i += Convert.ToDecimal(tablep["Monto"]);

                    }

                    ntb_pagt.Value = i;
                    idp++;
                    idp2 = 0;
                }
                else
                {
                    msg = "Asegurese de seleccionar un articulo";
                    MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else return;
        }

        private void dg_p_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) idp2 = Convert.ToInt32(tablep.Rows[e.RowIndex]["Pago"]);
        }

        private void ntb_des_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
