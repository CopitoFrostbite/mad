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
    public partial class Descuentos : Form
    {
        public Descuentos()
        {
            InitializeComponent();

            var obj = new EnlaceDB();
            var tabla = new DataTable();
            var tabla2 = new DataTable();
            tabla = obj.Consulta("spGestionDescuentos", "SE3", 0, "");
            tabla2 = obj.Consulta("spGestionDescuentos", "SE4", 0, "");
            dg_usu.DataSource = tabla2;
            table = tabla;
            table2 = tabla2;

            
            dg_usu.ClearSelection();
        }

        private DataTable table = new DataTable();
        private DataTable table2 = new DataTable();
        private int id = 0;

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

        public bool isValid()
        {

            var msg = "";
            if (tb_des.Text.Length == 0)
            {
                msg = "Falta la  descripcion";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!Regex.IsMatch(tb_des.Text, "^[a-zA-ZáíóúñÑéÉÁÍÓÚ+ +0-9]+$"))
            {
                msg = "Se permite a-z A-Z acentos, numeros y espacios en la descripcion";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }
                       


            if (ntb_desc.Value <= 0)
            {
                msg = "Descuento debe ser mayor a 0";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }


            //if (DateTime.Parse( dt_fi.Text) < DateTime.Now)
            //{
            //    msg = "Fecha inicial debe ser una fecha valida";
            //    MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return false;

            //}

            //if (DateTime.Parse(dt_ff.Text) < DateTime.Now)
            //{
            //    msg = "Fecha final debe ser una fecha valida";
            //    MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return false;

            //}

            if (DateTime.Parse(dt_ff.Text) < DateTime.Parse(dt_fi.Text))
            {
                msg = "Fecha final debe ser despues de fecha inicial";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }




            return true;

        }

        private void dt_fa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dg_usu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 )
            {
                id = Convert.ToInt32(table.Rows[e.RowIndex]["ID"]);
                tb_des.Text = (table.Rows[e.RowIndex]["Descripcion"].ToString());

                DateTime d = DateTime.Parse(table.Rows[e.RowIndex]["Fecha_Inicio"].ToString());
                dt_fi.Text = d.ToString("yyyy-MM-dd");
                DateTime b = DateTime.Parse(table.Rows[e.RowIndex]["Fecha_Final"].ToString());
                dt_ff.Text = b.ToString("yyyy-MM-dd");

                ntb_desc.Text = (table.Rows[e.RowIndex]["Porcentaje"].ToString());
                
            }
        }

        private void bt_ag_Click(object sender, EventArgs e)
        {
            var msg = "";
            if (rb_agg.Checked && this.isValid())
            {
                msg = "El Descuento " + tb_des.Text + " fue agregado";
                MessageBox.Show(msg, "Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                var obj = new EnlaceDB();
                var tabla = new DataTable();
                var tabla2 = new DataTable();
                obj.Add_Descuentos("IN", 0, tb_des.Text, dt_fi.Text,dt_ff.Text,Convert.ToInt32( ntb_desc.Text));
                tabla = obj.Consulta("spGestionDescuentos", "SE3", 0, "");
                tabla2 = obj.Consulta("spGestionDescuentos", "SE4", 0, "");
                table = tabla;
                table2 = tabla2;
                dg_usu.DataSource = table2;
                dg_usu.ClearSelection();
                ClearTextBoxes(this.Controls);
            }
            if (rb_edd.Checked && this.isValid())
            {
               
                if (id == 0)
                {
                    msg = "No se puede editar ";
                    MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                msg = "El Descuento " + tb_des.Text + " fue editado";
                MessageBox.Show(msg, "Editado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var obj = new EnlaceDB();
                var tabla = new DataTable();
                var tabla2 = new DataTable();
                obj.Add_Descuentos("UP", id, tb_des.Text, dt_fi.Text, dt_ff.Text, Convert.ToInt32(ntb_desc.Text));
                tabla = obj.Consulta("spGestionDescuentos", "SE3", 0, "");
                tabla2 = obj.Consulta("spGestionDescuentos", "SE4", 0, "");
                table = tabla;
                table2 = tabla2;
                dg_usu.DataSource = table2;
                dg_usu.ClearSelection();
                ClearTextBoxes(this.Controls);
            }

            if (rb_ell.Checked)
            {
               
                if (id == 0)
                {
                    msg = "No se puede eliminar ";
                    MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                msg = "Confirme que desea eliminar el Descuento  " + tb_des.Text;

                if (MessageBox.Show(msg, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes) 
                {
                    msg = "El Descuento " + tb_des.Text + " fue eliminado";
                    MessageBox.Show(msg, "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    var obj = new EnlaceDB();
                    var tabla = new DataTable();
                    var tabla2 = new DataTable();
                    obj.Del_Descuentos("DE", id);
                    tabla = obj.Consulta("spGestionDescuentos", "SE3", 0, "");
                    tabla2 = obj.Consulta("spGestionDescuentos", "SE4", 0, "");
                    table = tabla;
                    table2 = tabla2;
                    dg_usu.DataSource = table2;
                    dg_usu.ClearSelection();
                    ClearTextBoxes(this.Controls);
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            ntb_desc.Enabled = true;
            tb_des.Enabled = true;
            dt_fi.Enabled = true;
            dt_ff.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            ntb_desc.Enabled = true;
            tb_des.Enabled = true;
            dt_fi.Enabled = true;
            dt_ff.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            ntb_desc.Enabled = false;
            tb_des.Enabled = false;
            dt_fi.Enabled = false;
            dt_ff.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dg_usu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
