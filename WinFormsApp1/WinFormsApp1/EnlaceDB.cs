using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace WinFormsApp1
{
    public class EnlaceDB
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }

        private static void conectar()
        {
            //string cnn = ConfigurationManager.AppSettings["desarrollo1"];
            string cnn = ConfigurationManager.ConnectionStrings["MAD"].ToString();
            _conexion = new SqlConnection(cnn);
            _conexion.Open();
        }
        private static void desconectar()
        {
            _conexion.Close();
        }

        public bool Autentificar(string us, string ps)
        {
            bool isValid = false;
            var msg = "";
            try
            {
                conectar();
                string qry = "SPLogin";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar,20);
                parametro1.Value = us;
                var parametro2 = _comandosql.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 20);
                parametro2.Value = ps;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    isValid = true;
                   bool x = (bool)_tabla.Rows[0]["Nivel_cuenta"];
                    
                }
                else
                {
                    msg = "Usuario y/o contraseña incorrecta";
                    MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch(SqlException e)
            {
                isValid = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return isValid;
        }

        public DataTable Consulta(String SP,String AC, int param1,String param2)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = SP;
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;
                var param = _comandosql.Parameters.Add("@Accion",SqlDbType.Char, 3);
              //  if (SP == "spGestionUsuario")
              //  {
              //      var parametro1 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 20);
              //      parametro1.Value = param1;
              //  }

                if (SP == "spGestionInventario" && AC == "SE5" )
                {
                    var parametro1 = _comandosql.Parameters.Add("@ID", SqlDbType.Int);     
                    
                    parametro1.Value = (param1);                    
                }

                if (SP == "spGestionInventario" && AC == "SE4")
                {                    
                    var parametro2 = _comandosql.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50);
                    parametro2.Value = (param2);
                }
                if (SP == "spGestionRecibo" && AC == "SE2" || SP == "spGestionRecibo" && AC == "SE3" || SP == "spGestionRecibo" && AC == "SE5")
                {
                    var parametro2 = _comandosql.Parameters.Add("@N_Ticket", SqlDbType.Int);
                    parametro2.Value = (param1);
                }
                if (SP == "spGestionRecibo" && AC == "SE4" || SP == "spGestionRecibo" && AC == "SE6")
                {
                    var parametro2 = _comandosql.Parameters.Add("@caja", SqlDbType.Int);
                    parametro2.Value = (param1);
                    var parametro1 = _comandosql.Parameters.Add("@fecha", SqlDbType.Date);
                    parametro1.Value = (param2);
                }
                if (SP == "spGestionDevoluciones" && AC == "SE" || SP == "spGestionDevoluciones" && AC == "SE2")
                {
                    var parametro2 = _comandosql.Parameters.Add("@Recibo", SqlDbType.Int);
                    parametro2.Value = (param1);
                }

                param.Value = AC;
                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public  bool Desc()
        {
            var msg = "";
           
            try
            {
                conectar();
                string qry = "spGestionDescuentos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;
                var param = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                
                param.Value = "UP2";
                _adaptador.SelectCommand = _comandosql;
                

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return true;
        }

        public DataTable get_Deptos(string opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_Gestiona_Deptos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1);
                parametro1.Value = opc;


                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public bool Add_Articulos(string opc, int art, decimal can)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionArticulos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Articulo", SqlDbType.Int);
                parametro2.Value = art;
                var parametro3 = _comandosql.Parameters.Add("@Cantidad", SqlDbType.Decimal , 13);
                _comandosql.Parameters["@Cantidad"].Precision = 13;
                _comandosql.Parameters["@Cantidad"].Scale = 2;
                parametro3.Value = can;


                _comandosql.Prepare();
               _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Del_Articulos(string opc )
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionArticulos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                
               


                _comandosql.Prepare();
                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Add_Devolucion(string opc, int rec, int ide, string mot, bool mer, decimal can,decimal sub, decimal tot)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionDevoluciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro4 = _comandosql.Parameters.Add("@Recibo", SqlDbType.Int);
                parametro4.Value = rec;
                var parametro2 = _comandosql.Parameters.Add("@ID_Dev", SqlDbType.Int);
                parametro2.Value = ide;
                var parametro5 = _comandosql.Parameters.Add("@Motivo", SqlDbType.VarChar,30);
                parametro5.Value = mot;
                var parametro6 = _comandosql.Parameters.Add("@Merma", SqlDbType.Bit);
                parametro6.Value = mer;
                var parametro3 = _comandosql.Parameters.Add("@Cantidad", SqlDbType.Decimal, 13);
                _comandosql.Parameters["@Cantidad"].Precision = 13;
                _comandosql.Parameters["@Cantidad"].Scale = 2;
                parametro3.Value = can;
               
                var parametro7 = _comandosql.Parameters.Add("@Subtotal", SqlDbType.SmallMoney);
                parametro7.Value = sub;
                var parametro8 = _comandosql.Parameters.Add("@Total", SqlDbType.SmallMoney);
                parametro8.Value = tot;


                _comandosql.Prepare();
                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Del_Devolucion(string opc, int rec, int ide)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionDevoluciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro4 = _comandosql.Parameters.Add("@Recibo", SqlDbType.Int);
                parametro4.Value = rec;
                var parametro2 = _comandosql.Parameters.Add("@ID_Dev", SqlDbType.Int);
                parametro2.Value = ide;
                


                _comandosql.Prepare();
                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Add_Caja(string opc, int id, bool dis)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionCaja";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Numero", SqlDbType.Int);
                parametro2.Value = id;
                var parametro4 = _comandosql.Parameters.Add("@Disponibilidad", SqlDbType.Bit);
                parametro4.Value = dis;
                



                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Del_Caja(string opc, int id)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionCaja";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Numero", SqlDbType.Int);
                parametro2.Value = id;
               




                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Add_Departamento(string opc, int id, string nom, bool dev)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionDepartamento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Clave", SqlDbType.Int);
                parametro2.Value = id;
                var parametro4 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 30);
                parametro4.Value = nom;
                var parametro5 = _comandosql.Parameters.Add("@Devolucion", SqlDbType.Bit);
                parametro5.Value = dev;
               


                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Del_Departamento(string opc, int id)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionDepartamento";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Clave", SqlDbType.Int);
                parametro2.Value = id;
                


                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Add_Descuentos(string opc, int id, string des, string fi, string ff, int por)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionDescuentos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@ID_Des", SqlDbType.Int);
                parametro2.Value = id;                
                var parametro4 = _comandosql.Parameters.Add("@Descripcion", SqlDbType.VarChar, 30);
                parametro4.Value = des;
                var parametro5 = _comandosql.Parameters.Add("@Fecha_I", SqlDbType.Date);
                parametro5.Value = fi;
                var parametro6 = _comandosql.Parameters.Add("@Fecha_F", SqlDbType.Date);
                parametro6.Value = ff;
                var parametro7 = _comandosql.Parameters.Add("@Porcentaje", SqlDbType.Int);
                parametro7.Value = por;
                

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Del_Descuentos(string opc, int id)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionDescuentos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@ID_Des", SqlDbType.Int);
                parametro2.Value = id;
                


                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Add_Inventario(string opc, int id, int um, string des, decimal cos, decimal pu, decimal exi, decimal pr, int cla, int desc, string fech, bool eli, decimal uv, decimal mer)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionInventario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@ID", SqlDbType.Int);
                parametro2.Value = id;
                var parametro3 = _comandosql.Parameters.Add("@U_Medida", SqlDbType.Int);
                parametro3.Value = um;
                var parametro4 = _comandosql.Parameters.Add("@Descripcion", SqlDbType.VarChar, 30);
                parametro4.Value = des;
                var parametro5 = _comandosql.Parameters.Add("@Costo", SqlDbType.SmallMoney, 30);
                parametro5.Value = cos;
                var parametro6 = _comandosql.Parameters.Add("@Precio_U", SqlDbType.SmallMoney, 30);
                parametro6.Value = pu;
                var parametro7 = _comandosql.Parameters.Add("@Existencia", SqlDbType.Decimal, 13);
                _comandosql.Parameters["@Existencia"].Precision = 13;
                _comandosql.Parameters["@Existencia"].Scale = 2;
                parametro7.Value = exi;
                var parametro8 = _comandosql.Parameters.Add("@Pun_Reorden", SqlDbType.Decimal, 13);
                _comandosql.Parameters["@Pun_Reorden"].Precision = 13;
                _comandosql.Parameters["@Pun_Reorden"].Scale = 2;
                parametro8.Value = pr;
                var parametro9 = _comandosql.Parameters.Add("@Clave", SqlDbType.Int);
                parametro9.Value = cla;
                var parametro10 = _comandosql.Parameters.Add("@Descuento", SqlDbType.Int);
                parametro10.Value = desc;
                if (opc == "UP")
                {
                    var parametro14 = _comandosql.Parameters.Add("@Fecha_Alta", SqlDbType.Date);
                    parametro14.Value = fech;
                    var parametro12 = _comandosql.Parameters.Add("@Eliminado", SqlDbType.Bit);
                    parametro12.Value = eli;
                    var parametro11 = _comandosql.Parameters.Add("@U_Vendidas", SqlDbType.Decimal, 13);
                    _comandosql.Parameters["@U_Vendidas"].Precision = 13;
                    _comandosql.Parameters["@U_Vendidas"].Scale = 2;
                    parametro11.Value = uv;
                    var parametro13 = _comandosql.Parameters.Add("@Merma", SqlDbType.Decimal, 13);
                    _comandosql.Parameters["@Merma"].Precision = 13;
                    _comandosql.Parameters["@Merma"].Scale = 2;
                    parametro13.Value = mer;
                }
                _comandosql.Prepare();
                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Add_Inventario2(string opc, int id, decimal exi  )
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionInventario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@ID", SqlDbType.Int);
                parametro2.Value = id;
                
                var parametro7 = _comandosql.Parameters.Add("@Existencia", SqlDbType.Decimal, 13);
                _comandosql.Parameters["@Existencia"].Precision = 13;
                _comandosql.Parameters["@Existencia"].Scale = 2;
                parametro7.Value = exi;




                _comandosql.Prepare();
                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public DataTable Rep_Inventario(string opc, bool exi, bool reo, bool mer, string dep)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spReporteInventario";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                if (dep != "Todos") 
                {
                    var parametro4 = _comandosql.Parameters.Add("@Departamento", SqlDbType.VarChar, 20);
                    parametro4.Value = dep;
                }
                else 
                {
                    var parametro4 = _comandosql.Parameters.AddWithValue("@Departamento", DBNull.Value);
                    
                }

                if (exi == true)
                {
                    var parametro7 = _comandosql.Parameters.Add("@Existencia", SqlDbType.Bit, 13);
                    parametro7.Value = exi;
                }
                else
                {
                    var parametro4 = _comandosql.Parameters.AddWithValue("@Existencia", DBNull.Value);
                }
                if (reo == true)
                {
                    var parametro2 = _comandosql.Parameters.Add("@Pun_Reorden", SqlDbType.Bit, 13);
                    parametro2.Value = reo;
                }
                else
                {
                    var parametro4 = _comandosql.Parameters.AddWithValue("@Pun_Reorden", DBNull.Value);
                }
                if (mer == true)
                {
                    var parametro3 = _comandosql.Parameters.Add("@Merma", SqlDbType.Bit, 13);
                    parametro3.Value = mer;
                }
                else
                {
                    var parametro4 = _comandosql.Parameters.AddWithValue("@Merma", DBNull.Value);
                }


                _adaptador.SelectCommand = _comandosql;


                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {
                
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable Rep_Ventas(string opc, string dat1, string dat2, int caj, string dep)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spReporteVentas";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@fechai", SqlDbType.Date);
                parametro2.Value = dat1;
                var parametro3 = _comandosql.Parameters.Add("@fechaf", SqlDbType.Date);
                parametro3.Value = dat2;
                if (dep != "Todos")
                {
                    var parametro4 = _comandosql.Parameters.Add("@Departamento", SqlDbType.VarChar, 20);
                    parametro4.Value = dep;
                }
                else
                {
                    var parametro4 = _comandosql.Parameters.AddWithValue("@Departamento", DBNull.Value);

                }

                if (caj != 0)
                {
                    var parametro7 = _comandosql.Parameters.Add("@Caja", SqlDbType.Int);
                    parametro7.Value = caj;
                }
                else
                {
                    var parametro4 = _comandosql.Parameters.AddWithValue("@Caja", DBNull.Value);
                }
               


                _adaptador.SelectCommand = _comandosql;


                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {

                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable Rep_Cajero(string opc, string dat1, string dat2, string caj, string dep)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "spReporteCaja";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@fechai", SqlDbType.Date);
                parametro2.Value = dat1;
                var parametro3 = _comandosql.Parameters.Add("@fechaf", SqlDbType.Date);
                parametro3.Value = dat2;
                if (dep != "Todos")
                {
                    var parametro4 = _comandosql.Parameters.Add("@Departamento", SqlDbType.VarChar, 20);
                    parametro4.Value = dep;
                }
                else
                {
                    var parametro4 = _comandosql.Parameters.AddWithValue("@Departamento", DBNull.Value);

                }

                if (caj != "Todos")
                {
                    var parametro7 = _comandosql.Parameters.Add("@Cajero", SqlDbType.VarChar,20);
                    parametro7.Value = caj;
                }
                else
                {
                    var parametro4 = _comandosql.Parameters.AddWithValue("@Cajero", DBNull.Value);
                }



                _adaptador.SelectCommand = _comandosql;


                _adaptador.Fill(tabla);

            }
            catch (SqlException e)
            {

                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public bool Add_Usuario( string opc, string usu, string nom, string pat, string mat, string con, string cur, string nac, string nomi, string cor,string ing, bool niv, bool est,int id)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar,30);
                parametro2.Value = usu;
                var parametro3 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 30);
                parametro3.Value = nom;
                var parametro4 = _comandosql.Parameters.Add("@Ap_Pat", SqlDbType.VarChar, 30);
                parametro4.Value = pat;
                var parametro5 = _comandosql.Parameters.Add("@Ap_Mat", SqlDbType.VarChar, 30);
                parametro5.Value = mat;
                var parametro6 = _comandosql.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 30);
                parametro6.Value = con;
                var parametro7 = _comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 16);
                parametro7.Value = cur;
                var parametro8 = _comandosql.Parameters.Add("@F_nac", SqlDbType.Date);
                parametro8.Value = nac;
                var parametro9 = _comandosql.Parameters.Add("@Nomina", SqlDbType.VarChar, 30);
                parametro9.Value = nomi;
                var parametro10 = _comandosql.Parameters.Add("@Correo", SqlDbType.VarChar, 30);
                parametro10.Value = cor;
                if (opc == "UP")
                {
                    var parametro14 = _comandosql.Parameters.Add("@Fec_Ing", SqlDbType.Date);
                    parametro14.Value = ing;
                }

                var parametro11 = _comandosql.Parameters.Add("@Nivel_Cuenta", SqlDbType.Bit);
                parametro11.Value = niv;
                var parametro12 = _comandosql.Parameters.Add("@Estado", SqlDbType.Bit);
                parametro12.Value = est;

                var parametro13 = _comandosql.Parameters.Add("@ID", SqlDbType.Int);
                parametro13.Value = id;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Tienda(string opc, string nom , string suc, string dir, string ms1, string ms2, string mi1, string mi2)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionTienda";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 30);
                parametro2.Value = nom;
                var parametro3 = _comandosql.Parameters.Add("@Sucursal", SqlDbType.VarChar, 30);
                parametro3.Value = suc;
                var parametro4 = _comandosql.Parameters.Add("@Direccion", SqlDbType.VarChar, 30);
                parametro4.Value = dir;
                var parametro5 = _comandosql.Parameters.Add("@Mensaje1", SqlDbType.VarChar, 30);
                parametro5.Value = ms1;
                var parametro6 = _comandosql.Parameters.Add("@Mensaje2", SqlDbType.VarChar, 30);
                parametro6.Value = ms2;
                var parametro7 = _comandosql.Parameters.Add("@Mensaje3", SqlDbType.VarChar, 16);
                parametro7.Value = mi1;
                var parametro8 = _comandosql.Parameters.Add("@Mensaje4", SqlDbType.VarChar, 16);
                parametro8.Value = mi2;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Del_Usuario(string opc, int id)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionUsuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                

                var parametro13 = _comandosql.Parameters.Add("@ID", SqlDbType.Int);
                parametro13.Value = id;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Add_Pagos(string opc, int num, int met, decimal mont)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionPagos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Num_Pago", SqlDbType.Int);
                parametro2.Value = num;
                var parametro3 = _comandosql.Parameters.Add("@M_Pago", SqlDbType.Int);
                parametro3.Value = met;
                var parametro4 = _comandosql.Parameters.Add("@Monto", SqlDbType.SmallMoney);
                parametro4.Value = mont;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Del_Pagos(string opc, int num)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionPagos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Num_Pago", SqlDbType.Int);
                parametro2.Value = num;

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

        public bool Add_Ticket(string opc, int ti,  decimal cam)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionRecibo";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@N_Ticket", SqlDbType.Int);
                parametro2.Value = ti;
                var parametro3 = _comandosql.Parameters.Add("@Cambio", SqlDbType.SmallMoney);
                parametro3.Value = cam;

                

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool Add_Ventas(string opc,int caja, string user,decimal desc, decimal tot, decimal pag)
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionVentas";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                var parametro2 = _comandosql.Parameters.Add("@Caja", SqlDbType.Int);
                parametro2.Value = caja;
                var parametro3 = _comandosql.Parameters.Add("@Cajero", SqlDbType.VarChar, 30);
                parametro3.Value = user;

                if (opc == "UP2")
                {
                    var parametro4 = _comandosql.Parameters.Add("@Descuento", SqlDbType.SmallMoney);
                    parametro4.Value = desc;
                    var parametro14 = _comandosql.Parameters.Add("@Total", SqlDbType.SmallMoney);
                    parametro14.Value = tot;
                    var parametro5 = _comandosql.Parameters.Add("@Pago", SqlDbType.SmallMoney);
                    parametro5.Value = pag;
                }

                _adaptador.InsertCommand = _comandosql;
                
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();                
            }

            return add;
        }

        public bool Del_Ventas(string opc )
        {
            var msg = "";
            var add = true;
            try
            {
                conectar();
                string qry = "spGestionVentas";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Accion", SqlDbType.Char, 3);
                parametro1.Value = opc;
                
                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }

    }
}
