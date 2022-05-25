using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class cealumno
    {
        private int codigo_alumno;
        private String nombre_alumno;
        private String especialidad;

        public int Codigo_alumno { get => codigo_alumno; set => codigo_alumno = value; }
        public string Nombre_alumno { get => nombre_alumno; set => nombre_alumno = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}
