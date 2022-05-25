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
    public class cdalumno
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();
        public bool agregar_alumno(cealumno alumno)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDmatricula");
                ocmd.CommandText = "agregar_alumno";
                ocmd.Parameters.Add("@codigo_alumno", alumno.Codigo_alumno);
                ocmd.Parameters.Add("@nombre_alumno", alumno.Nombre_alumno);
                ocmd.Parameters.Add("@especialidad",alumno.Especialidad);

                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {                                                                                           
               
                throw new Exception(err.Message);
            }


        }
        public bool anula_alumno(cealumno alumno)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDmatricula");
                ocmd.CommandText = "borrar_alumno";
                ocmd.Parameters.Add("@codigo_alumno", alumno.Codigo_alumno);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataSet consultar_alumno(cealumno alumno)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDmatricula");
                ocmd.CommandText = "consultar_alumno";
                ocmd.Parameters.Add("@codigo_alumno", alumno.Codigo_alumno);
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
