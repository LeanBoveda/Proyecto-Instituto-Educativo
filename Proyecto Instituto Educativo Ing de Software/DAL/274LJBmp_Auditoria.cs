using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class _274LJBmp_Auditoria
    {
        Acceso datos = new Acceso();

        public DataTable ObtenerTodo()
        {
            return datos.Leer("PA_Auditoria_ObtenerTodo", null);
        }
    }

}
