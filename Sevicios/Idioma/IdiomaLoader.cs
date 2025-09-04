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
        private const string RutaArchivo = "Recursos\\Idioma.json";

        public static Dictionary<string, _274LJBIdioma> CargarIdiomas()
        {
            if (!File.Exists(RutaArchivo))
                throw new FileNotFoundException("No se encontró el archivo de idioma.", RutaArchivo);

            string json = File.ReadAllText(RutaArchivo);

            var datosCrudos = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);

            var idiomas = new Dictionary<string, _274LJBIdioma>();
            foreach (var par in datosCrudos)
            {
                var idioma = new _274LJBIdioma
                {
                    Nombre = par.Key,
                    Traducciones = par.Value
                };
                idiomas.Add(par.Key, idioma);
            }

            return idiomas;
        }
    }
}
