using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class _274LJBmp_inscripcion
    {
        private readonly Acceso acceso = new Acceso();
        public void InscribirDirecto(string dni, int cursoID, DateTime fecha)
        {
            SqlParameter[] p = {
        new SqlParameter("@DNIAlumno", dni),
        new SqlParameter("@CursoID", cursoID),
        new SqlParameter("@FechaInscripcion", fecha)
    };

            acceso.Escribir("PA_Inscripcion_Insertar", p);
        }


        public void Eliminar(string dni, int cursoID)
        {
            SqlParameter[] p = {
            new SqlParameter("@DNIAlumno", dni),
            new SqlParameter("@CursoID", cursoID)
        };
            acceso.Escribir("PA_Inscripcion_Eliminar", p);
        }

        public DataTable ListarAlumnosInscritos(int cursoID)
        {
            SqlParameter[] p = {
            new SqlParameter("@CursoID", cursoID)
        };
            return acceso.Leer("PA_Inscripcion_ListarPorCurso", p);
        }

        public DataTable ListarAlumnosNoInscritos(int cursoID)
        {
            SqlParameter[] p = {
            new SqlParameter("@CursoID", cursoID)
        };
            return acceso.Leer("PA_Inscripcion_ListarDisponiblesParaCurso", p);
        }
        public DataTable ListarAlumnosDisponiblesGenerales()
        {
            SqlParameter[] parametros = { };

            return acceso.Leer("PA_Inscripcion_ListarDisponiblesGenerales",parametros);
        }
    }
}
