using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class _274LJBBLL_Inscripcion
    {
        _274LJBmp_inscripcion mp = new _274LJBmp_inscripcion();

        public void InscribirAlumno(string dni, int cursoID, DateTime fecha)
        {
            if (string.IsNullOrWhiteSpace(dni))
                throw new Exception("DNI inválido.");
            if (cursoID <= 0)
                throw new Exception("Curso inválido.");

            mp.InscribirDirecto(dni, cursoID, fecha);
        }

        public void EliminarInscripcion(string dni, int cursoID)
        {
            if (string.IsNullOrWhiteSpace(dni) || cursoID <= 0)
                throw new Exception("Datos inválidos.");
            mp.Eliminar(dni, cursoID);
        }

        public DataTable ObtenerAlumnosDelCurso(int cursoID)
        {
            if (cursoID <= 0)
                throw new Exception("Curso inválido.");
            return mp.ListarAlumnosInscritos(cursoID);
        }

        public DataTable ObtenerAlumnosNoInscritos(int cursoID)
        {
            if (cursoID <= 0)
                throw new Exception("Curso inválido.");
            return mp.ListarAlumnosNoInscritos(cursoID);
        }
        public DataTable ListarAlumnosDisponiblesGenerales()
        {
            return mp.ListarAlumnosDisponiblesGenerales();
        }

    }
}
