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
        public DataTable ObtenerLogs()
        {
            return new _274LJBmp_Auditoria().ObtenerTodo();
        }
    }

}
