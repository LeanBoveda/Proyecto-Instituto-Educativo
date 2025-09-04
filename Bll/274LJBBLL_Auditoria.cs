using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class _274LJBBLL_Auditoria
    {
        private _274LJBmp_Auditoria mp = new _274LJBmp_Auditoria();

        public void RegistrarEvento(string usuario, string modulo, string evento,string criticidad)
        {
            mp.InsertarEvento(usuario, modulo, evento,criticidad);
        }
        public DataTable ObtenerAuditoria()
        {
            return mp.ObtenerAuditoria();
        }
        public DataTable ObtenerBitacora()
        {
            return mp.ObtenerBitacora();
        }
    }

}
