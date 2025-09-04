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
    public class _274LJBBLL_Materia
    {
        _274LJBMP_Materia mp = new _274LJBMP_Materia();

        public void AgregarMateria(_274LJBMateria m)
        {
            if (string.IsNullOrWhiteSpace(m._274LJBnombre))
                throw new Exception("El nombre es obligatorio.");
            mp.Agregar(m);
        }

        public void ModificarMateria(_274LJBMateria m)
        {
            if (m._274LJBId <= 0) throw new Exception("ID inválido.");
            mp.Modificar(m);
        }

        public void EliminarMateria(int id)
        {
            if (id <= 0) throw new Exception("ID inválido.");
            mp.Eliminar(id);
        }

        public DataTable ObtenerMaterias()
        {
            return mp.Listar();
        }
    }
}
