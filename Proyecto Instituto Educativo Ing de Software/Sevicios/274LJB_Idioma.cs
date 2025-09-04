using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevicios
{
    public class _274LJBIdioma
    {
        public string Nombre { get; set; }
        public Dictionary<string, string> Traducciones { get; set; }

        public string Traducir(string clave)
        {
            return Traducciones != null && Traducciones.ContainsKey(clave)
                ? Traducciones[clave]
                : clave; 
        }
    }
}
