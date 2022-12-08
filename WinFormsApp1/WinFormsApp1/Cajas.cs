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
    public partial class Cajas : Form
    {
        public Cajas()
        {
            InitializeComponent();
            var obj = new EnlaceDB();
            var tabla = new DataTable();

            tabla = obj.Consulta("spGestionCaja", "SE3", 0, "");

            dg_caj.DataSource = tabla;
            table = tabla;



            dg_caj.ClearSelection();
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

        private void dg_usu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = Convert.ToInt32(table.Rows[e.RowIndex]["Numero"]);
                
                ntb_num.Value = id;
                cb_dis.Checked = Convert.ToBoolean((table.Rows[e.RowIndex]["Disponibilidad"]));




            }
        }

        private void bt_ag_Click(object sender, EventArgs e)
        {
            var msg = "";
            if (rb_agc.Checked)
            {
                msg = "La caja " + id.ToString() + " fue agregada";
                MessageBox.Show(msg, "Agregada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var obj = new EnlaceDB();
                var tabla = new DataTable();

                obj.Add_Caja("IN", 0, true);
                tabla = obj.Consulta("spGestionCaja", "SE3", 0, "");

                table = tabla;

                dg_caj.DataSource = table;
                dg_caj.ClearSelection();
                ClearTextBoxes(this.Controls);
            }
            if (rb_edc.Checked)
            {
                msg = "La caja " + id.ToString() + " fue editada";
                MessageBox.Show(msg, "Editada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var obj = new EnlaceDB();
                var tabla = new DataTable();

                obj.Add_Caja("UP", id, cb_dis.Checked);
                tabla = obj.Consulta("spGestionCaja", "SE3", 0, "");

                table = tabla;

                dg_caj.DataSource = table;
                dg_caj.ClearSelection();
                ClearTextBoxes(this.Controls);
            }

            if (rb_elc.Checked)
            {
                msg = "Confirme que desea eliminar la caja  " + id.ToString();

                if (MessageBox.Show(msg, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    msg = "La caja " + id.ToString() + " fue eliminada";
                    MessageBox.Show(msg, "Eliminada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    var obj = new EnlaceDB();
                    var tabla = new DataTable();

                    obj.Del_Caja("DE", id);
                    tabla = obj.Consulta("spGestionCaja", "SE3", 0, "");

                    table = tabla;

                    dg_caj.DataSource = table;
                    dg_caj.ClearSelection();
                    ClearTextBoxes(this.Controls);
                }
                else return;
               
            }
        }

        private void bt_reg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
