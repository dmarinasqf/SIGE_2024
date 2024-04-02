using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CapaEntidad.Generales;
using System.Data.SqlClient;
using System.Data;

namespace CapaPresentacionAdmin.Logica
{
    public class LO_Empleado
    {
        public EMPLEADO EncontrarEmpleados(string userName, string clave)
        {
            EMPLEADO objeto = new EMPLEADO();
            using (SqlConnection conexion = new SqlConnection("Data Source=PANDAFILE;Initial Catalog=BACKUPQF;User ID=sa;Password=INT2021tf;"))
            //using (SqlConnection conexion = new SqlConnection("Data Source=(localdb)\\david_siste;Initial Catalog=PEDIDOSQF;Integrated Security=true"))
            {
                string query = "SELECT userName,nombres,apePaterno,clave,idcargo FROM  EMPLEADO where userName=@puserName and clave=@pclave";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@puserName", userName);
                cmd.Parameters.AddWithValue("@pclave", clave);
                cmd.CommandType = CommandType.Text;

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objeto = new EMPLEADO()
                        {
                            userName = dr["userName"].ToString(),
                            Nombres = dr["nombres"].ToString(),
                            apePaterno = dr["apePaterno"].ToString(),
                            clave = dr["clave"].ToString(),
                            //oCargoEmpleado1 = (CargoEmpleado1)dr["idcargo"],


                        };
                    }
                }
            }

                return objeto;
        }

    }
}