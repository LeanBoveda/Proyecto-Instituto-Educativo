using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevicios
{
    public interface IComandoReversible : ICommand
    {
        void Deshacer();
    }
}
