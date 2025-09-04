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
    public class _274LJBMP_Notas
    {
        Acceso datos = new Acceso();
        public void Agregar(_274LJBNotas nota)
        {
            SqlParameter[] p = {
            new SqlParameter("@DNIAlumno", nota._274LJBDniAlumno),
            new SqlParameter("@MateriaID", nota._274LJBMateriaId),
            new SqlParameter("@Trimestre", nota._274LJBTrimestre),
            new SqlParameter("@Examen1", nota._274LJBEXamen1),
            new SqlParameter("@Examen2", nota._274LJBEXamen2),
            new SqlParameter("@TP", nota._274LJBTp)
        };
            datos.Escribir("PA_Nota_Insertar", p);
        }
        public void Modificar(_274LJBNotas nota)
        {
            SqlParameter[] p = {
            new SqlParameter("@ID", nota._274LJBid),
            new SqlParameter("@Examen1", nota._274LJBEXamen1),
            new SqlParameter("@Examen2", nota._274LJBEXamen2),
            new SqlParameter("@TP", nota._274LJBTp)
        };
            datos.Escribir("PA_Nota_Modificar", p);
        }
        public void EliminarNota(int notaID)
        {
            SqlParameter[] p = { new SqlParameter("@ID", notaID) };
            datos.Escribir("PA_Nota_Eliminar", p);
        }

        public DataTable ListarParaCarga(int cursoID, int materiaID, int trimestre)
        {
            SqlParameter[] p = {
              new SqlParameter("@CursoID", cursoID),
              new SqlParameter("@MateriaID", materiaID),
              new SqlParameter("@Trimestre", trimestre)
    };
            return datos.Leer("PA_Nota_ListarParaCarga", p);
        }

    }
}
