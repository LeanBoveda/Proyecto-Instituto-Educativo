using BE;
using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevicios
{
    public class ComandoModificarNota : ICommand
    {
        private readonly BE._274LJBNotas nota;
        private readonly Bll._274LJBBLL_Notas servicio;

        public ComandoModificarNota(_274LJBNotas nota)
        {
            this.nota = nota;
            this.servicio = new _274LJBBLL_Notas();
        }

        public void Ejecutar()
        {
            servicio.ModificarNota(nota);
        }
    }
}
