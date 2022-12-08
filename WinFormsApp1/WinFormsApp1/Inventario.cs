using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;
using Microsoft.SqlServer.Server;

namespace WinFormsApp1
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            var obj = new EnlaceDB();
            var tabla = new DataTable();
            var tabla2 = new DataTable();
            tabla = obj.Consulta("spGestionInventario", "SE6", 0, "");
            tabla2 = obj.Consulta("spGestionInventario", "SE7", 0, "");
            dg_inv.DataSource = tabla2;
            table = tabla;
            table2 = tabla2;
            var tabla3 = new DataTable();
            var tabla4 = new DataTable();
            var tabla5 = new DataTable();
            tabla3 = obj.Consulta("spGestionDepartamento", "SE2", 0, "");
            dg_dep.DataSource = tabla3;
            foreach (DataRow row in tabla3.Rows)
            {
                cb_dep.Items.Add(row["Clave"].ToString());
                
            }
            tabla4 = obj.Consulta("spGestionDescuentos", "SE2", 0, "");
            dg_des.DataSource = tabla4;
            foreach (DataRow row in tabla4.Rows)
            {
                
                    cb_des.Items.Add(row["ID_Descuento"].ToString());
                
            }
            tabla5 = obj.Consulta("spGestionUnidades", "SE2", 0, "");
            
            foreach (DataRow row in tabla5.Rows)
            {

                cb_um.Items.Add(row["Nombre"].ToString());

            }
            cb_des.SelectedIndex= 0;
            cb_dep.SelectedIndex = 0;
            table3 = tabla3;

            dt_fa.Enabled = false;
            cb_act.Enabled = false;
            ntb_uv.Enabled = false;
            ntb_mer.Enabled = false;
            table4 = tabla4;
            dg_inv.ClearSelection();
            
        }
        private DataTable table = new DataTable();
        private DataTable table2 = new DataTable();
        private DataTable table3 = new DataTable();
        private DataTable table4 = new DataTable();
        private int id = 0;
        private string use = "";
        private void Inventario_Load(object sender, EventArgs e)
        {
            
        }

        public String getuse()
        {
            return this.use;
        }
        public void setuse(string x)
        {
            this.use = x;
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public bool isValid()
        {

            var msg = "";
            if (tb_desc.Text.Length == 0)
            {
                msg = "Falta la  descripcion";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!Regex.IsMatch(tb_desc.Text, "^[a-zA-ZáíóúñÑéÉÁÍÓÚ+ +0-9]+$"))
            {
                msg = "Se permite a-z A-Z acentos, numeros y espacios en la descripcion";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
               
            }

            if (cb_um.Text.Length == 0)
            {
                msg = "Falta la  unidad de medida";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            

            if (ntb_ex.Value <= 0)
            {
                msg = "Existencia debe ser mayor a 0";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
               
            }

            if (ntb_ex.Value <= 0)
            {
                msg = "Existencia debe ser mayor a 0";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }

            
            if (ntb_cos.Value <= 0)
            {
                msg = "Costo debe ser mayor a 0";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }
            

            if (ntb_pu.Value <= 0)
            {
                msg = "Precio Unitario debe ser mayor a 0";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }

            if (ntb_pu.Value < ntb_cos.Value)
            {
                msg = "Precio debe ser mayor a costo";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }

           

            return true;
            
        }

        


        private void rb_ag_CheckedChanged(object sender, EventArgs e)
        {
            dt_fa.Enabled = false;
            cb_act.Enabled = false;
            ntb_uv.Enabled = false;
            ntb_mer.Enabled = false;

            ClearTextBoxes(this.Controls);
        }

        private void cb_dep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dg_inv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if (e.RowIndex > -1)
            {
                id = Convert.ToInt32(table.Rows[e.RowIndex]["ID"]);
                tb_desc.Text = (table.Rows[e.RowIndex]["Descripcion"].ToString());
                cb_um.SelectedIndex = Convert.ToInt32(table.Rows[e.RowIndex]["U_Medida"]);  
                
                ntb_cos.Text = table.Rows[e.RowIndex]["Costo"].ToString();               
                ntb_pu.Text = (table.Rows[e.RowIndex]["Precio_U"].ToString());
                DateTime d = DateTime.Parse(table.Rows[e.RowIndex]["Fecha_Alta"].ToString());
                dt_fa.Text = d.ToString("yyyy-MM-dd");
                ntb_ex.Text = (table.Rows[e.RowIndex]["Existencia"].ToString());
                ntb_pr.Text = (table.Rows[e.RowIndex]["Pun_Reorden"].ToString());
                cb_act.Checked = Convert.ToBoolean((table.Rows[e.RowIndex]["Eliminado"]));
                ntb_uv.Text = (table.Rows[e.RowIndex]["U_Vendidas"].ToString());
                ntb_mer.Text = (table.Rows[e.RowIndex]["Merma"].ToString());           
                cb_dep.SelectedIndex = Convert.ToInt32(table.Rows[e.RowIndex]["Clave"]);
                if ((table.Rows[e.RowIndex]["Descuento"] != DBNull.Value)) cb_des.SelectedIndex = Convert.ToInt32(table.Rows[e.RowIndex]["Descuento"]);
                else cb_des.SelectedIndex = -1;


            }
        }

        private void bt_ej_Click(object sender, EventArgs e)
        {
            var msg = "";
            if (rb_ag.Checked && this.isValid())
            {
                msg = "El Articulo " + tb_desc.Text + " fue agregado";
                MessageBox.Show(msg, "Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                var obj = new EnlaceDB();
                var tabla = new DataTable();
                var tabla2 = new DataTable();
                
              
                obj.Add_Inventario("IN", 0, cb_um.SelectedIndex, tb_desc.Text, ntb_cos.Value, ntb_pu.Value, ntb_ex.Value, ntb_pr.Value, Convert.ToInt32(cb_dep.Text), Convert.ToInt32(cb_des.Text), "", false, 0, 0,use);
                tabla = obj.Consulta("spGestionInventario", "SE6", 0, "");
                tabla2 = obj.Consulta("spGestionInventario", "SE7", 0, "");
                table = tabla;
                table2 = tabla2;
                dg_inv.DataSource = table2;
                dg_inv.ClearSelection();
                ClearTextBoxes(this.Controls);
            }
            if (rb_ed.Checked && this.isValid())
            {
                msg = "El Articulo " + tb_desc.Text + " fue editado";
                MessageBox.Show(msg, "Editado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                var obj = new EnlaceDB();
                var tabla = new DataTable();
                var tabla2 = new DataTable();
                obj.Add_Inventario("UP", id, cb_um.SelectedIndex, tb_desc.Text, ntb_cos.Value, ntb_pu.Value, ntb_ex.Value, ntb_pr.Value, Convert.ToInt32(cb_dep.Text), Convert.ToInt32(cb_des.Text), dt_fa.Text, cb_act.Checked, ntb_uv.Value,ntb_mer.Value,use );
                tabla = obj.Consulta("spGestionInventario", "SE6", 0, "");
                tabla2 = obj.Consulta("spGestionInventario", "SE7", 0, "");
                table = tabla;
                table2 = tabla2;
                dg_inv.DataSource = table2;
                dg_inv.ClearSelection();
                ClearTextBoxes(this.Controls);
            }
        }

        private void rb_ed_CheckedChanged(object sender, EventArgs e)
        {
            dt_fa.Enabled = true;
            cb_act.Enabled = true;
            ntb_uv.Enabled = true;
            ntb_mer.Enabled = true;
            ClearTextBoxes(this.Controls);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void act() 
        {
            var obj = new EnlaceDB();
            var tabla3 = new DataTable();
            var tabla4 = new DataTable();
            tabla3 = obj.Consulta("spGestionDepartamento", "SE2", 0, "");
            cb_dep.Items.Clear();
            dg_dep.DataSource = tabla3;
            foreach (DataRow row in tabla3.Rows)
            {
                cb_dep.Items.Add(row["Clave"].ToString());
            }
            tabla4 = obj.Consulta("spGestionDescuentos", "SE2", 0, "");
            cb_des.Items.Clear();
            dg_des.DataSource = tabla4;
            foreach (DataRow row in tabla4.Rows)
            {
                cb_des.Items.Add(row["ID_Descuento"].ToString());
            }

            dg_inv.ClearSelection();
            cb_des.SelectedIndex = 0;
            cb_dep.SelectedIndex = 0;
            table3 = tabla3;
            table4= tabla4;
        }

        private void bt_descu_Click(object sender, EventArgs e)
        {
            Descuentos descuentos= new Descuentos();
            descuentos.ShowDialog();
            act();
        }

        private void Descuentos_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_depa_Click(object sender, EventArgs e)
        {
            Departamentos departamentos= new Departamentos();
            departamentos.ShowDialog();
            act();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tb_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg_des_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                
                cb_des.SelectedIndex = Convert.ToInt32(table4.Rows[e.RowIndex]["ID_Descuento"]);
                


            }
        }

        private void dg_dep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cb_dep.SelectedIndex = Convert.ToInt32(table3.Rows[e.RowIndex]["Clave"]);
               


            }
        }
    }
}
