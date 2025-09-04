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
    public class _274LJBBLL_Alumno
    {
        _274LJBmp_alumnos mp = new _274LJBmp_alumnos();
        public void AgregarAlumno(_274LJBAlumno a)
        {
            if (string.IsNullOrWhiteSpace(a._274LJBDNI) || a._274LJBDNI.Length > 9)
                throw new Exception("DNI inválido.");
            mp.AgregarA(a);
        }
        public void ModificarAlumno(_274LJBAlumno a)
        {
            mp.ModificarA(a);
        }
        public void EliminarAlumno(string dni)
        {
            mp.EliminarA(dni);
        }
        public DataTable ObtenerAlumnos()
        {
            return mp.Listar();
        }
        public DataTable BuscarAlumnoPorDNI(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni) || dni.Length > 9)
                throw new Exception("DNI inválido.");
            return mp.BuscarPorDNI(dni);
        }


    }
}
