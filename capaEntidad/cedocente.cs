using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class cedocente
    {
        private int cedula_docente;
        private String nombre_docente;
        private String oficina;

        public int Cedula_docente { get => cedula_docente; set => cedula_docente = value; }
        public string Nombre_docente { get => nombre_docente; set => nombre_docente = value; }
        public string Oficina { get => oficina; set => oficina = value; }
    }
}
