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
    public class _274LJBMP_Materia
    {
        Acceso datos = new Acceso();

        public void Agregar(_274LJBMateria m)
        {
            SqlParameter[] p = { new SqlParameter("@Nombre", m._274LJBnombre) };
            datos.Escribir("PA_Materia_Insertar", p);
        }

        public void Modificar(_274LJBMateria m)
        {
            SqlParameter[] p = {
            new SqlParameter("@ID", m._274LJBId),
            new SqlParameter("@Nombre", m._274LJBnombre)
        };
            datos.Escribir("PA_Materia_Modificar", p);
        }

        public void Eliminar(int id)
        {
            SqlParameter[] p = { new SqlParameter("@ID", id) };
            datos.Escribir("PA_Materia_Eliminar", p);
        }

        public DataTable Listar()
        {
            SqlParameter[] parametros = { };
            return datos.Leer("PA_Materia_Listar",parametros);
        }
    }
}
