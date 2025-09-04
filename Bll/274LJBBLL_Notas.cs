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
    public class _274LJBBLL_Notas
    {
        _274LJBMP_Notas mp = new _274LJBMP_Notas();

        public void AgregarNota(_274LJBNotas n)
        {
            if (string.IsNullOrWhiteSpace(n._274LJBDniAlumno)) throw new Exception("DNI requerido");
            if (n._274LJBMateriaId <= 0 || n._274LJBTrimestre < 1 || n._274LJBTrimestre > 3)
                throw new Exception("Parámetros inválidos");

            mp.Agregar(n);
        }

        public void ModificarNota(_274LJBNotas n)
        {
            if (n._274LJBid <= 0)
                throw new Exception("ID de nota inválido.");
            ValidarNota(n);
            mp.Modificar(n);
        }
        public void EliminarNota(int notaID)
        {
            if (notaID <= 0) throw new Exception("ID de nota inválido.");
            mp.EliminarNota(notaID);
        }

        public DataTable ObtenerNotasParaCarga(int cursoID, int materiaID, int trimestre)
        {
            return mp.ListarParaCarga(cursoID, materiaID, trimestre);
        }
        private void ValidarNota(_274LJBNotas nota)
        {
            if (string.IsNullOrWhiteSpace(nota._274LJBDniAlumno))
                throw new Exception("DNI del alumno requerido.");
            if (nota._274LJBMateriaId <= 0)
                throw new Exception("Materia requerida.");
            if (nota._274LJBTrimestre < 1 || nota._274LJBTrimestre > 3)
                throw new Exception("Trimestre inválido.");
            if (nota._274LJBEXamen1 < 0 || nota._274LJBEXamen1 > 10 ||
                nota._274LJBEXamen2 < 0 || nota._274LJBEXamen2 > 10 ||
                nota._274LJBTp < 0 || nota._274LJBTp > 10)
                throw new Exception("Las notas deben estar entre 0 y 10.");
        }
    }
}
