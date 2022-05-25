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
    public class cnalumno
    {
        cdalumno DatAlumno = new cdalumno();
        public bool agregar_alumno(cealumno alumno)
        {
            return DatAlumno.agregar_alumno(alumno);

        }
        public bool anula_alumno(cealumno alumno)
        {
            return DatAlumno.anula_alumno(alumno);
        }
        public DataSet consultar_alumno(cealumno alumno)
        {
            return DatAlumno.consultar_alumno(alumno);
        }
    }
}
