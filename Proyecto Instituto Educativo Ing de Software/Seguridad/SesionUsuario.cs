using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sevicios;
namespace Seguridad
{
     public class SesionUsuario
    {
        private static SesionUsuario instancia;
        private static readonly object lockObj = new object();

        public _274LJBUsuario UsuarioActual { get; private set; }

        private SesionUsuario(_274LJBUsuario usuario)
        {
            UsuarioActual = usuario;
        }

        public static SesionUsuario IniciarSesion(_274LJBUsuario usuario)
        {
            if (instancia == null)
            {
                lock (lockObj)
                {
                    if (instancia == null)
                    {
                        instancia = new SesionUsuario(usuario);
                    }
                }
            }
            return instancia;
        }

        public static SesionUsuario ObtenerInstancia()
        {
            return instancia;
        }

        public static void CerrarSesion()
        {
            instancia = null;
        }

        public static bool SesionIniciada()
        {
            return instancia != null;
        }
    }
}
