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
    public class _274LJBmp_Cursos
    {
        private Acceso acceso = new Acceso();

        public void Agregar(_274LJBCurso c)
        {
            SqlParameter[] p = {
            new SqlParameter("@Anio", c._274LJBAño),
            new SqlParameter("@Division", c._274LJBDivision)
        };
            acceso.Escribir("PA_Curso_Insertar", p);
        }

        public void Modificar(_274LJBCurso c)
        {
            SqlParameter[] p = {
            new SqlParameter("@ID", c._274LJBId),
            new SqlParameter("@Anio", c._274LJBAño),
            new SqlParameter("@Division", c._274LJBDivision)
        };
            acceso.Escribir("PA_Curso_Modificar", p);
        }

        public void Eliminar(int id)
        {
            SqlParameter[] p = { new SqlParameter("@ID", id) };
            acceso.Escribir("PA_Curso_Eliminar", p);
        }

        public DataTable Listar()
        {
            SqlParameter[] parametros = { };
            return acceso.Leer("PA_Curso_Listar",parametros);
        }
    }
}
