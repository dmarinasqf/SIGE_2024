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
   public class CD_OPXBOX
    {

        //Combo laboratorio
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


        //Combo sucursalOP
        public class DatosSucursalOP
        {
            private string CadenaConexion = "Data Source=PANDAFILE;Initial Catalog=BACKUPQF;User ID=sa;Password=INT2021tf;";

            public List<string> ObtenerSucursalesOP()
            {
                List<string> sucursalesOP = new List<string>();

                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    string consulta = "select descripcion from SUCURSAL WHERE tipoSucursal='LOCAL' and estado='HABILITADO'";
                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        sucursalesOP.Add(lector["descripcion"].ToString());
                    }

                    lector.Close();
                }

                return sucursalesOP;
            }
        }
        //Combo DatosDiagnostico
        public class DatosDiagnostico
        {
            private string CadenaConexion = "Data Source=PANDAFILE;Initial Catalog=BACKUPQF;User ID=sa;Password=INT2021tf;";

            public List<string> ObtenerDiagnostico()
            {
                List<string> diagnosticos = new List<string>();

                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    string consulta = "SELECT descripcion FROM DIAGNOSTICO";
                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        diagnosticos.Add(lector["descripcion"].ToString());
                    }

                    lector.Close();
                }

                return diagnosticos;
            }
        }

        //Combo DatosDiagnostico
        public class DatosLineaAtencion
        {
            private string CadenaConexion = "Data Source=PANDAFILE;Initial Catalog=BACKUPQF;User ID=sa;Password=INT2021tf;";

            public List<string> ObtenerLinea()
            {
                List<string> linea = new List<string>();

                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    string consulta = "SELECT Nombre FROM LineaAtencion";
                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        linea.Add(lector["Nombre"].ToString());
                    }

                    lector.Close();
                }

                return linea;
            }
        }

    }
}
