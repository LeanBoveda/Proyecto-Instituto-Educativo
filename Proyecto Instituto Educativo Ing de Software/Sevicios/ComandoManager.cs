using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevicios
{
    public class ComandoManager
    {
        private readonly Stack<ICommand> historial = new Stack<ICommand>();
        private readonly Stack<ICommand> deshechos = new Stack<ICommand>();

        public void Ejecutar(ICommand comando, string descripcion = null)
        {
            ICommand ejecutable = descripcion != null
                ? new ComandoAuditable(comando, descripcion)
                : comando;

            ejecutable.Ejecutar();
            historial.Push(ejecutable);
            deshechos.Clear();
        }

        public bool PuedeDeshacer => historial.Count > 0;
        public bool PuedeRehacer => deshechos.Count > 0;

        public void Deshacer()
        {
            if (!PuedeDeshacer) return;
            var ultimo = historial.Pop();
            if (ultimo is IComandoReversible reversible)
            {
                reversible.Deshacer();
                deshechos.Push(ultimo);
            }
        }

        public void Rehacer()
        {
            if (!PuedeRehacer) return;
            var comando = deshechos.Pop();
            comando.Ejecutar();
            historial.Push(comando);
        }
    }
}
