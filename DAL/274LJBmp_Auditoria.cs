using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class _274LJBmp_Auditoria
    {
        Acceso acceso = new Acceso();

        public DataTable ObtenerBitacora()
        {
            return acceso.Leer("PA_Bitacora_Obtener", null);
        }

        public DataTable ObtenerAuditoria()
        {
            return acceso.Leer("PA_AuditoriaCambios_Obtener", null);
        } 
        public void InsertarEvento(string usuario, string modulo,  string evento,string criticidad)
        {
            SqlParameter[] parametros = new SqlParameter[] {
            new SqlParameter("@Usuario", usuario),
            new SqlParameter("@Modulo", modulo),
            new SqlParameter("@Evento", evento),
            new SqlParameter("@Criticidad", criticidad),
            };
            acceso.Escribir("PA_Bitacora_Insertar", parametros);
        }
    }

}
