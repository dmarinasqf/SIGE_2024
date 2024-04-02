using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad.Generales;

namespace CapaDatos
{
    public class CD_Empleados
    {
        //public List<EMPLEADO> Listar(){

        //    List<EMPLEADO> lista = new List<EMPLEADO>();

        //    try
        //    {
        //        using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
        //        {
        //            string query = "select emp_codigo,userName,clave,perfil_codigo,documento,nombres,apePaterno,apeMaterno,estado,celular from EMPLEADO";
        //            SqlCommand cmd = new SqlCommand(query, oconexion);
        //            cmd.CommandType = CommandType.Text;

        //            oconexion.Open();

        //            using (SqlDataReader dr = cmd.ExecuteReader())
        //            {
        //                while (dr.Read())
        //                {
        //                    lista.Add(
        //                        new EMPLEADO()
        //                        {
        //                            emp_codigo= Convert.ToInt32(dr["emp_codigo"]),
        //                            userName = dr["userName"].ToString(),
        //                            clave = dr["clave"].ToString(),
        //                            perfil_codigo = dr["perfil_codigo"].ToString(),
        //                            documento = dr["documento"].ToString(),
        //                            nombres = dr["nombres"].ToString(),
        //                            apePaterno = dr["apePaterno"].ToString(),
        //                            apeMaterno = dr["apeMaterno"].ToString(),
        //                            estado = dr["estado"].ToString(),
        //                            celular = dr["celular"].ToString(),
        //                        });
        //                }
        //            }
        //        }
        //    }
        //    // el Exception es para ver que se esta mostrando con la variable e
        //    catch (Exception e)
        //    {
        //        lista = new List<EMPLEADO>();

        //    }
        //    return lista;

        //}
        public List<EMPLEADO> Listar()
        {
            List<EMPLEADO> rptListaEmpleado = new List<EMPLEADO>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
            {
                SqlCommand cmd = new SqlCommand("LISTAR_EMPLEADOS_TERCEROS", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        rptListaEmpleado.Add(new EMPLEADO()
                        {
                            emp_codigo = Convert.ToInt32(dr["emp_codigo"]),
                            documento = dr["documento"].ToString(),
                            Nombres = dr["nombreEmpleado"].ToString(),
                            Sucursal = dr["Sucursal"].ToString(),
                            Empresa = dr["Empresa"].ToString(),
                            Grupo = dr["Grupo"].ToString(),
                            userName = dr["userName"].ToString(),
                            estado = dr["estado"].ToString()

                        });
                    }
                    dr.Close();

                    return rptListaEmpleado;

                }
                catch (Exception ex)
                {
                    rptListaEmpleado = null;
                    return rptListaEmpleado;
                }
            }
        }
    }
}
