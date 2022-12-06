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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
            var obj = new EnlaceDB();
            var tabla = new DataTable();
            var tabla2 = new DataTable();
            tabla = obj.Consulta("spGestionUsuarios", "SE4", 0, "");
            tabla2 = obj.Consulta("spGestionUsuarios", "SE5", 0, "");
            dg_usu.DataSource = tabla2;
            table = tabla;
            table2 = tabla2;
            
            cb_act.Enabled = false;
            dt_fin.Enabled = false;

            dg_usu.ClearSelection();

        }

        private DataTable table = new DataTable();
        private DataTable table2 = new DataTable();
        private int id = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
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

        public bool isValid()
        {

            var msg = "";
            if (tb_usu.Text.Length == 0)
            {
                msg = "Falta el nombre de Usuario";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!Regex.IsMatch(tb_usu.Text, "^[a-zA-Z0-9_-]*$"))
            {
                msg = "Se permite a-z A-Z , numeros, guion bajo y guion en el Usuario";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }

            if (tb_nom.Text.Length == 0)
            {
                msg = "Falta el nombre";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!Regex.IsMatch(tb_nom.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                msg = "Se permite a-z A-Z , acentos y un espacio en el nombre";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }

            if(tb_pat.Text.Length == 0)
            {
                msg = "Falta el apellido paterno";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!Regex.IsMatch(tb_pat.Text, "[a-zA-ZáéíóúÁÉÍÓÚñÑ]+"))
            {
                msg = "Se permite a-z A-Z y acentos  en el apellido paterno";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }

           
            if (!Regex.IsMatch(tb_mat.Text, "[a-zA-ZáéíóúÁÉÍÓÚñÑ]+"))
            {
                msg = "Se permite a-z A-Z y acentos en el apellido materno ";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }


            if (tb_cur.Text.Length != 18)
            {
                msg = "Deben ser 18 caracteres en el CURP";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!Regex.IsMatch(tb_cur.Text, "^[A-Z]{4}[0-9]{6}[A-Z]{6}[0-9]{2}$"))
            {
                msg = "Ingrese el CURP en el formato AAAA000000AAAAAA00";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }

            if (tb_con.Text.Length == 0)
            {
                msg = "Falta contraseña";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!Regex.IsMatch(tb_con.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$"))
            {
                msg = "La contraseña debe tener 8 caracteres, una minuscula, mayuscula, numero y un @$!%*?&";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }
            else if (tb_con.Text != tb_con2.Text)
            {
                msg = "Las contraseñas no coinciden";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }

            if (tb_nomi.Text.Length == 0)
            {
                msg = "Falta la nomina";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!Regex.IsMatch(tb_usu.Text, "^[a-zA-Z0-9]*$"))
            {
                msg = "Se permite a-z A-Z y numeros en la nomina";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }


            if (tb_cor.Text.Length == 0)
            {
                msg = "Falta la nomina";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (!Regex.IsMatch(tb_cor.Text, "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$"))
            {
                msg = "Ingrese un formato de correo valido";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }

            if (DateTime.Parse(dt_nac.Text) > DateTime.Now)
            {
                msg = "Ingrese una fecha de nacimiento valida";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }

            if (DateTime.Parse(dt_fin.Text) > DateTime.Now && rb_ed.Checked)
            {
                msg = "Ingrese una fecha de nacimiento valida";
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;

            }



            return true;

        }

        private void dg_usu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) 
            { 
                id = Convert.ToInt32(table.Rows[e.RowIndex]["ID"]);
                tb_usu.Text = (table.Rows[e.RowIndex]["Usuario"].ToString());
                tb_nom.Text = (table.Rows[e.RowIndex]["Nombre"].ToString());
                tb_pat.Text = (table.Rows[e.RowIndex]["Ap_Pat"].ToString());
                tb_mat.Text = (table.Rows[e.RowIndex]["Ap_Mat"].ToString());
                tb_con.Text = (table.Rows[e.RowIndex]["Contrasenia"].ToString());
                tb_cur.Text = (table.Rows[e.RowIndex]["CURP"].ToString());
                DateTime d = DateTime.Parse(table.Rows[e.RowIndex]["F_Nac"].ToString());
                dt_nac.Text = d.ToString("yyyy-MM-dd");
                DateTime b = DateTime.Parse(table.Rows[e.RowIndex]["Fec_Ing"].ToString());
                dt_fin.Text = b.ToString("yyyy-MM-dd");

                tb_nomi.Text = (table.Rows[e.RowIndex]["Nomina"].ToString());
                tb_cor.Text = (table.Rows[e.RowIndex]["Correo"].ToString());
                cb_ad.Checked = Convert.ToBoolean((table.Rows[e.RowIndex]["Nivel_cuenta"]));
                cb_act.Checked = Convert.ToBoolean((table.Rows[e.RowIndex]["Nivel_cuenta"]));
            }
        }

        private void bt_ag_Click(object sender, EventArgs e)
        {
            var msg = "";
            if (rb_ag.Checked && this.isValid())
            {
                msg = "El Usuario " + tb_usu.Text + " fue agregado";
                MessageBox.Show(msg, "Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                var obj = new EnlaceDB();
                var tabla = new DataTable();
                var tabla2 = new DataTable();
                obj.Add_Usuario("IN", tb_usu.Text, tb_nom.Text, tb_pat.Text, tb_mat.Text, tb_con.Text, tb_cur.Text, dt_nac.Text, tb_nomi.Text, tb_cor.Text, "", cb_ad.Checked, true, 0);
                tabla = obj.Consulta("spGestionUsuarios", "SE4", 0, "");
                tabla2 = obj.Consulta("spGestionUsuarios", "SE5", 0, "");
                table = tabla;
                table2 = tabla2;
                dg_usu.DataSource = table2;
                dg_usu.ClearSelection();
                ClearTextBoxes(this.Controls);
            }
            if(rb_ed.Checked && this.isValid()) 
            {
                msg = "El Usuario " + tb_usu.Text + " fue editado";
                MessageBox.Show(msg, "Editado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                var obj = new EnlaceDB();
                var tabla = new DataTable();
                var tabla2 = new DataTable();
                obj.Add_Usuario("UP", tb_usu.Text, tb_nom.Text, tb_pat.Text, tb_mat.Text, tb_con.Text, tb_cur.Text, dt_nac.Text, tb_nomi.Text, tb_cor.Text, dt_fin.Text, cb_ad.Checked, cb_act.Checked, id);
                tabla = obj.Consulta("spGestionUsuarios", "SE4", 0, "");
                tabla2 = obj.Consulta("spGestionUsuarios", "SE5", 0, "");
                table = tabla;
                table2 = tabla2;
                dg_usu.DataSource = table2;
                dg_usu.ClearSelection();
                ClearTextBoxes(this.Controls);
            }

            if (rb_el.Checked)
            {
                msg = "Confirme que desea eliminar al Usuario  " + tb_usu.Text ;
                

                if (MessageBox.Show(msg, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    msg = "El Usuario " + tb_usu.Text + " fue eliminado";
                    MessageBox.Show(msg, "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    var obj = new EnlaceDB();
                    var tabla = new DataTable();
                    var tabla2 = new DataTable();
                    obj.Del_Usuario("DE", id);
                    tabla = obj.Consulta("spGestionUsuarios", "SE4", 0, "");
                    tabla2 = obj.Consulta("spGestionUsuarios", "SE5", 0, "");
                    table = tabla;
                    table2 = tabla2;
                    dg_usu.DataSource = table2;
                    dg_usu.ClearSelection();
                    ClearTextBoxes(this.Controls);

                    
                }
                else
                {
                   return;
                }

                

                

            }

        }

        private void bt_ed_Click(object sender, EventArgs e)
        {
            
        }

        private void rb_ag_CheckedChanged(object sender, EventArgs e)
        {
            tb_usu.Enabled = true;
            tb_nom.Enabled = true;
            tb_pat.Enabled = true;
            tb_mat.Enabled = true;
            tb_cur.Enabled = true;
            tb_con.Enabled = true;
            tb_con2.Enabled = true;
            tb_nomi.Enabled = true;
            tb_cor.Enabled = true;
            dt_fin.Enabled = false;            
            cb_act.Enabled = false;
            dt_nac.Enabled = true;
           
            ClearTextBoxes(this.Controls);
        }

        private void rb_ed_CheckedChanged(object sender, EventArgs e)
        {
            tb_usu.Enabled = true;
            tb_nom.Enabled = true;
            tb_pat.Enabled = true;
            tb_mat.Enabled = true;
            tb_cur.Enabled = true;
            tb_con.Enabled = true;
            tb_con2.Enabled = true;
            tb_nomi.Enabled = true;
            tb_cor.Enabled = true;
            dt_fin.Enabled = true;
            cb_act.Enabled = true;
            dt_nac.Enabled = true;
            ClearTextBoxes(this.Controls);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_usu_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_el_CheckedChanged(object sender, EventArgs e)
        {
            tb_usu.Enabled = false;
            tb_nom.Enabled = false;
            tb_pat.Enabled = false;
            tb_mat.Enabled = false;
            tb_cur.Enabled = false;
            tb_con.Enabled = false;
            tb_con2.Enabled = false;
            tb_nomi.Enabled = false;
            tb_cor.Enabled = false;
            dt_fin.Enabled = false;
            cb_act.Enabled = false;
            dt_nac.Enabled = false;
            ClearTextBoxes(this.Controls);
        }
    }
}
