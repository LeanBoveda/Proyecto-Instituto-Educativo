using Sevicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class _274LJBAuditorio
    {
        public static void Registrar(string accion, string detalle)
        {
            var usuario = Seguridad.SesionUsuario.ObtenerInstancia()?.UsuarioActual?.NombreUsuario ?? "Desconocido";

            SqlParameter[] p = {
                   new SqlParameter("@Usuario", usuario),
                   new SqlParameter("@Accion", accion),
                   new SqlParameter("@Detalle", detalle)
               };



        }
    }
}
