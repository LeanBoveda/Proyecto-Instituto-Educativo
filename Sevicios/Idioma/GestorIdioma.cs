using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevicios
{
    public class GestorIdioma
    {
        private static GestorIdioma instancia;

        public static GestorIdioma Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new GestorIdioma();
                return instancia;
            }
        }

        private _274LJBIdioma idiomaActual;
        private readonly List<IObservadorIdioma> observadores = new List<IObservadorIdioma>();

        public void Suscribir(IObservadorIdioma obs)
        {
            if (!observadores.Contains(obs))
                observadores.Add(obs);

            if (idiomaActual != null)
                obs.IdiomaCambiado(idiomaActual);
        }

        public void CambiarIdioma(_274LJBIdioma idioma)
        {
            idiomaActual = idioma;
            foreach (var obs in observadores)
            {
                obs.IdiomaCambiado(idioma);
            }
        }

        public _274LJBIdioma ObtenerIdioma()
        {
            return idiomaActual;
        }
    }
}
