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
    public class cndocente
    {
        cddocente DatDocente = new cddocente();
        public bool agregar_docente(cedocente docente)
        {
            return DatDocente.agregar_docente(docente);

        }
        public bool anula_docente(cedocente docente)
        {
            return DatDocente.anula_docente(docente);
        }
        public DataSet consultar_docente(cedocente docente)
        {
            return DatDocente.consultar_docente(docente);
        }
    }
}
