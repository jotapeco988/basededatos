using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using capaEntidad;
using System.Data;
namespace capaDatos
{
   public class cddocente
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();
        public bool agregar_docente(cedocente docente)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDmatricula");
                ocmd.CommandText = "agregar_docente";
                ocmd.Parameters.Add("@cedula_docente", docente.Cedula_docente);
                ocmd.Parameters.Add("@nombre_docente", docente.Nombre_docente);
                ocmd.Parameters.Add("@oficina", docente.Oficina);

                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }


        }
        public bool anula_docente(cedocente docente)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDmatricula");
                ocmd.CommandText = "borrar_docente";
                ocmd.Parameters.Add("@cedula_docente", docente.Cedula_docente);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataSet consultar_docente(cedocente docente)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDmatricula");
                ocmd.CommandText = "consultar_docente";
                ocmd.Parameters.Add("@cedula_docente", docente.Cedula_docente);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }



        }
    }
}
