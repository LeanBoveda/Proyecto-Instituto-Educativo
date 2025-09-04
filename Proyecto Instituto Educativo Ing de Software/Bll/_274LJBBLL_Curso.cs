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
    public class _274LJBBLL_Curso
    {
        _274LJBmp_Cursos mp = new _274LJBmp_Cursos();

        public void AgregarCurso(_274LJBCurso c)
        {
            if (c._274LJBAño < 1 || c._274LJBAño > 7)
                throw new Exception("Año inválido");
            if (string.IsNullOrWhiteSpace(c._274LJBDivision))
                throw new Exception("División obligatoria");

            mp.Agregar(c);
        }

        public void ModificarCurso(_274LJBCurso c)
        {
            if (c._274LJBId <= 0)
                throw new Exception("ID inválido");
            mp.Modificar(c);
        }

        public void EliminarCurso(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido");
            mp.Eliminar(id);
        }

        public DataTable ObtenerCursos()
        {
            return mp.Listar();
        }
    }
}
