using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class cecurso

    {
        private int codigo_curso;
        private String nombre_curso;
        private String curso;

        public string Nombre_curso { get => nombre_curso; set => nombre_curso = value; }
        public string Curso { get => curso; set => curso = value; }
        public int Codigo_curso { get => codigo_curso; set => codigo_curso = value; }
    }
}
