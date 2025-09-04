using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Sevicios
{
    public static class IdiomaLoader
    {
        public static Dictionary<string, _274LJBIdioma> CargarDesdeJson(string ruta)
        {
            if (!File.Exists(ruta))
                throw new FileNotFoundException("No se encontró el archivo de idioma.", ruta);

            string json = File.ReadAllText(ruta);

            var datosCrudos = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);

            var idiomas = new Dictionary<string, _274LJBIdioma>();
            foreach (var par in datosCrudos)
            {
                idiomas.Add(par.Key, new _274LJBIdioma
                {
                    Nombre = par.Key,
                    Traducciones = par.Value
                });
            }

            return idiomas;
        }
    }
}
