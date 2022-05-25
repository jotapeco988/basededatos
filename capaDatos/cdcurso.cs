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
    public class cdcurso
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();
        public bool agregar_curso(cecurso curso)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDmatricula");
                ocmd.CommandText = "agregar_curso";
                ocmd.Parameters.Add("@codigo_curso", curso.Codigo_curso);
                ocmd.Parameters.Add("@nombre_curso", curso.Nombre_curso);
                ocmd.Parameters.Add("@curso", curso.Curso);

                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }


        }
        public bool anula_curso(cecurso curso)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDmatricula");
                ocmd.CommandText = "borrar_curso";
                ocmd.Parameters.Add("@codigo_curso", curso.Codigo_curso);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataSet consultar_curso(cecurso curso)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDmatricula");
                ocmd.CommandText = "consultar_curso";
                ocmd.Parameters.Add("@codigo_curso", curso.Codigo_curso);
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
