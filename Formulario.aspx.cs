using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaEntidad;
using capaNegocio;
using System.Data;

namespace estructuraCapas
{
    public partial class Formulario : System.Web.UI.Page
    {
        cnalumno ONalumno = new cnalumno();
        cealumno OEalumno = new cealumno();
        cncurso ONcurso = new cncurso();
        cecurso OEcurso = new cecurso();
        cndocente ONdocente = new cndocente();
        cedocente OEdocente = new cedocente();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnguardaralumno_Click(object sender, EventArgs e)
        {
            OEalumno.Codigo_alumno = Convert.ToInt32(txtcodigoalumno.Text);
            OEalumno.Nombre_alumno = Convert.ToString(txtnombrealumno.Text);
            OEalumno.Especialidad = Convert.ToString(txtespecialidad.Text);
            if (ONalumno.agregar_alumno(OEalumno))
            {
                lblmensajealumno.Text = "Alumno guardado.";
            }
            else
            {
                lblmensajealumno.Text = "Error al guardar el alumno";
            }
        }

        protected void btnagregarcurso_Click(object sender, EventArgs e)
        {
            OEcurso.Codigo_curso = Convert.ToInt32(txtcodigocurso.Text);
            OEcurso.Nombre_curso = Convert.ToString(txtnombrecurso.Text);
            OEcurso.Curso = Convert.ToString(txtcurso.Text);
            if (ONcurso.agregar_curso(OEcurso))
            {
                lblmensajecurso.Text = "Curso guardado.";
            }   
            else
            {
                lblmensajecurso.Text = "Error al guardar el curso.";
            }
        }

        protected void btnagregardocente_Click(object sender, EventArgs e)
        {
            OEdocente.Cedula_docente = Convert.ToInt32(txtceduladocente.Text);
            OEdocente.Nombre_docente = Convert.ToString(txtnombredocente.Text);
            OEdocente.Oficina = Convert.ToString(txtoficina.Text);
            if (ONdocente.agregar_docente(OEdocente))
            {
                lblmensajedocente.Text = "Docente guardado.";
            }
            else
            {
                lblmensajedocente.Text = "Error al guardar el docente.";
            }
        }

        protected void btnconsultaralumno_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OEalumno.Codigo_alumno = Convert.ToInt32(txtcodigoalumno.Text);
            ds = ONalumno.consultar_alumno(OEalumno);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblmensajealumno.Text = "No hay alumno";
            }
            else
            {
                lblmensajealumno.Text = ds.Tables[0].Rows[0]["codigo_alumno"].ToString() + "<br/>"
                    + ds.Tables[0].Rows[0]["nombre_alumno"].ToString() + "<br/>"
                    + ds.Tables[0].Rows[0]["especialidad"].ToString();
            }
        }

        protected void btnconsultarcurso_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OEcurso.Codigo_curso = Convert.ToInt32(txtcodigocurso.Text);
            ds = ONcurso.consultar_curso(OEcurso);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblmensajecurso.Text = "No hay curso";
            }
            else
            {
                lblmensajecurso.Text = ds.Tables[0].Rows[0]["codigo_curso"].ToString() + "<br/>"
                    + ds.Tables[0].Rows[0]["nombre_curso"].ToString() + "<br/>"
                    + ds.Tables[0].Rows[0]["curso"].ToString();
            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OEdocente.Cedula_docente = Convert.ToInt32(txtceduladocente.Text);
            ds = ONdocente.consultar_docente(OEdocente);

            if (ds.Tables[0].Rows.Count == 0)
            {
                lblmensajedocente.Text = "No hay docente";
            }
            else
            {
                lblmensajedocente.Text ="Cedula docente:" + ds.Tables[0].Rows[0]["cedula_docente"].ToString() + "<br/>"+
                   "Nombre docente:" + ds.Tables[0].Rows[0]["nombre_docente"].ToString() + "<br/>"+
                   "Oficina:" + ds.Tables[0].Rows[0]["oficina"].ToString();
            }
        }

        protected void btneliminaralumno_Click(object sender, EventArgs e)
        {
            OEalumno.Codigo_alumno = Convert.ToInt32(txtcodigoalumno.Text);

            if (ONalumno.anula_alumno(OEalumno))
            {
                lblmensajealumno.Text = "Alumno eliminado";
            }
            else
            {
                lblmensajealumno.Text = "No se pudo eliminar el alumno";
            }
        }

        protected void btneliminarcurso_Click(object sender, EventArgs e)
        {
            OEcurso.Codigo_curso = Convert.ToInt32(txtcodigocurso.Text);

            if (ONcurso.anula_curso(OEcurso))
            {
                lblmensajecurso.Text = "Curso eliminado";
            }
            else
            {
                lblmensajecurso.Text = "No se pudo eliminar el curso";
            }
        }

        protected void btneliminardocente_Click(object sender, EventArgs e)
        {
            OEdocente.Cedula_docente = Convert.ToInt32(txtceduladocente.Text);

            if (ONdocente.anula_docente(OEdocente))
            {
                lblmensajedocente.Text = "docente eliminado";
            }
            else
            {
                lblmensajedocente.Text = "No se pudo eliminar el docente";
            }
        }
    }
    }
