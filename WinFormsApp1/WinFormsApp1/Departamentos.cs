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
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
            var obj = new EnlaceDB();
            var tabla = new DataTable();
           
            tabla = obj.Consulta("spGestionDepartamento", "SE3", 0, "");

            dg_dep.DataSource = tabla;
            table = tabla;
            


            dg_dep.ClearSelection();
        }

        private DataTable table = new DataTable();
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
            if (tb_nom.Text.Length == 0)
            {
                msg = "Falta la  descripcion";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!Regex.IsMatch(tb_nom.Text, "^[a-zA-ZáíóúñÑéÉÁÍÓÚ+ +0-9]+$"))
            {
                msg = "Se permite a-z A-Z acentos, numeros y espacios en el nombre";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }

            return true;

        }

        private void dg_dep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = Convert.ToInt32(table.Rows[e.RowIndex]["Clave"]);
                tb_nom.Text = (table.Rows[e.RowIndex]["Nombre"].ToString());
                cb_dev.Checked = Convert.ToBoolean((table.Rows[e.RowIndex]["Devolucion"]));


                

            }
        }

        private void bt_ag_Click(object sender, EventArgs e)
        {
            var msg = "";
            if (rb_aggg.Checked && this.isValid())
            {

                msg = "El Departamento " + tb_nom.Text + " fue agregado";
                MessageBox.Show(msg, "Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_nom.Enabled= true;
                cb_dev.Enabled= true;
                var obj = new EnlaceDB();
                var tabla = new DataTable();
               
                obj.Add_Departamento("IN", 0, tb_nom.Text, cb_dev.Checked);
                tabla = obj.Consulta("spGestionDepartamento", "SE3", 0, "");
                
                table = tabla;
               
                dg_dep.DataSource = table;
                dg_dep.ClearSelection();
                ClearTextBoxes(this.Controls);
            }
            if (rb_eddd.Checked && this.isValid())
            {
               
                if (id == 0) 
                {
                    msg = "No se puede editar ";
                    MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return ;
                }
                else
                {
                    msg = "El Departamento " + tb_nom.Text + " fue editado";
                    MessageBox.Show(msg, "Editado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                var obj = new EnlaceDB();
                var tabla = new DataTable();

                obj.Add_Departamento("UP", id, tb_nom.Text, cb_dev.Checked);
                tabla = obj.Consulta("spGestionDepartamento", "SE3", 0, "");

                table = tabla;

                dg_dep.DataSource = table;
                dg_dep.ClearSelection();
                ClearTextBoxes(this.Controls);
            }

            if (rb_elll.Checked )
            {
                
                if (id == 0)
                {
                    msg = "No se puede eliminar ";
                    MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                msg = "Confirme que desea eliminar el departamento  " + tb_nom.Text;
                if (MessageBox.Show(msg, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {

                    msg = "El Departamento " + tb_nom.Text + " fue eliminado";
                    MessageBox.Show(msg, "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var obj = new EnlaceDB();
                    var tabla = new DataTable();

                    obj.Add_Departamento("DE", id, tb_nom.Text, cb_dev.Checked);
                    tabla = obj.Consulta("spGestionDepartamento", "SE3", 0, "");

                    table = tabla;

                    dg_dep.DataSource = table;
                    dg_dep.ClearSelection();
                    ClearTextBoxes(this.Controls);
                }
                else return;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_aggg_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            tb_nom.Enabled = true;
            cb_dev.Enabled = true;
        }

        private void rb_eddd_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            tb_nom.Enabled = true;
            cb_dev.Enabled = true;
        }

        private void rb_elll_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            tb_nom.Enabled = false;
            cb_dev.Enabled = false;
        }

        private void dg_dep_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
