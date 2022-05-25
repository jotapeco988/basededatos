using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;
using System.Data;

namespace capaNegocio
{
   public class cncurso
    {
        cdcurso DatCurso = new cdcurso();
        public bool agregar_curso(cecurso curso)
        {
            return DatCurso.agregar_curso(curso);

        }
        public bool anula_curso(cecurso curso)
        {
            return DatCurso.anula_curso(curso);
        }
        public DataSet consultar_curso(cecurso curso)
        {
            return DatCurso.consultar_curso(curso);
        }
    }
}
