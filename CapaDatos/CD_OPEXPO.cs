using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad.Generales;
using CapaEntidad.pedidos;

namespace CapaDatos
{
   public class CD_OPEXPO
    {
        //private readonly string cadena;
        //SqlConnection cnn;
        //SqlDataReader leer;
        //SqlCommand cmm;
        //private static DataTable dtrecepcionvalidacion;
        //public List<Pedido> Listar()
        //{

        //    List<Pedido> lista = new List<Pedido>();

        //    try
        //    {
        //        using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
        //        {
        //            string query = "select nroPedidoLocal,numBoleta,ordenProduccion,TP.descripcion as FormaPag,IIF(CLI.nombrecomercial=null,CLI.nombrecomercial,CLI.nombres+' '+CLI.apepaterno+' '+CLI.apematerno) as Cliente,ME.nombres+' '+ME.apePaterno+' '+ME.apeMaterno AS Medico,ORE.descripcion as OrigenRec,SU.descripcion as Sucursal,TIOP.descripcion as TipoOP,total,adelanto,saldo,laboratorio,OP.estadoPedido from PEDIDO OP left join Cliente CLI on OP.cli_codigo=CLI.idcliente left join ORIGENRECETA ORE on OP.origenreceta_codigo=ORE.origenreceta_codigo left join MEDICO ME on ME.med_codigo=OP.med_codigo left join SUCURSAL SU on OP.suc_codigo=SU.suc_codigo left join TIPOPEDIDO TIOP on op.tipopedido_codigo=TIOP.tipopedido_codigo left join EMPLEADO EMP on OP.emp_codigo=EMP.emp_codigo left join CLIENTE_TERCERO CLITER on OP.cliTercero_codigo=CLITER.cliTercero_codigo left join DIAGNOSTICO DIA on OP.diagnostico_codigo=DIA.diagnostico_codigo left join TIPOPAGO TP on OP.idtipopago=TP.idtipopago";

        //            SqlCommand cmd = new SqlCommand(query, oconexion);
        //            cmd.CommandType = CommandType.Text;

        //            oconexion.Open();

        //            using (SqlDataReader dr = cmd.ExecuteReader())
        //            {
        //                while (dr.Read())
        //                {
        //                    lista.Add(
        //                        new Pedido()
        //                        {
        //                            nroPedidoLocal = dr["nroPedidoLocal"].ToString(),
        //                            numBoleta = dr["numBoleta"].ToString(),
        //                            ordenProduccion = dr["ordenProduccion"].ToString(),
        //                            FormaPag = dr["FormaPag"].ToString(),
        //                            Cliente = dr["Cliente"].ToString(),
        //                            Medico = dr["Medico"].ToString(),
        //                            OrigenReceta = dr["OrigenRec"].ToString(),
        //                            Sucursal = dr["Sucursal"].ToString(),
        //                            TipoOP = dr["TipoOP"].ToString(),
        //                            //Paciente = dr["Paciente"].ToString(),
        //                            //total = Convert.ToDouble(dr["total"]),
        //                            total = Convert.ToDouble(dr["total"]),
        //                            adelanto = Convert.ToDouble(dr["adelanto"]),
        //                            saldo = Convert.ToDouble(dr["saldo"]),
        //                            laboratorio = dr["laboratorio"].ToString(),
        //                            estadoPedido = dr["estadoPedido"].ToString(),
        //                        });
        //                }
        //            }
        //        }
        //    }
        //    // el Exception es para ver que se esta mostrando con la variable e
        //    catch (Exception e){
        //    
        //        lista = new List<Pedido>();

        //    }
        //    return lista;

        //}
        public List<Pedido> Listar()
        {
            List<Pedido> rptListaPedido = new List<Pedido>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
            {
                SqlCommand cmd = new SqlCommand("LISTAR_OP_TERCEROS", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        rptListaPedido.Add(new Pedido()
                        {
                            nroPedidoLocal = dr["nroPedidoLocal"].ToString(),
                            numBoleta = dr["numBoleta"].ToString(),
                            ordenProduccion = dr["ordenProduccion"].ToString(),
                            FormaPag = dr["FormaPag"].ToString(),
                            Cliente = dr["Cliente"].ToString(),
                            Medico = dr["Medico"].ToString(),
                            //OrigenReceta = dr["OrigenRec"].ToString(),
                            Sucursal = dr["Sucursal"].ToString(),
                            TipoOP = dr["TipoOP"].ToString(),
                            total = Convert.ToDouble(dr["total"]),
                            adelanto = Convert.ToDouble(dr["adelanto"]),
                            saldo = Convert.ToDouble(dr["saldo"]),
                            laboratorio = dr["laboratorio"].ToString(),
                            estadoPedido = dr["estadoPedido"].ToString()

                        });
                    }
                    dr.Close();

                    return rptListaPedido;

                }
                catch (Exception ex)
                {
                    rptListaPedido = null;
                    return rptListaPedido;
                }
            }
        }
        //public DataTable rptListaPedido()
        //{
        //    try
        //    {
        //        cnn = new SqlConnection();
        //        cnn.ConnectionString = cadena;
        //        cnn.Open();
        //        cmm = new SqlCommand("LISTAR_OP_TERCEROS", cnn);
        //        cmm.CommandType = CommandType.StoredProcedure;
        //        DataTable tabla = new DataTable();
        //        SqlDataAdapter da = new SqlDataAdapter(cmm);
        //        da.Fill(tabla);
        //        tabla.TableName = "rptListaPedido";
        //        cnn.Close();
        //        return tabla;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        public class DatosSucursal
        {
            private string CadenaConexion = "Data Source=PANDAFILE;Initial Catalog=BACKUPQF;User ID=sa;Password=INT2021tf;";

            public List<string> ObtenerSucursalesProduccion()
            {
                List<string> sucursales = new List<string>();

                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    string consulta = "SELECT descripcion FROM SUCURSAL WHERE tipoSucursal='PRODUCCIÓN'";
                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        sucursales.Add(lector["descripcion"].ToString());
                    }

                    lector.Close();
                }

                return sucursales;
            }
        }

    }
}
