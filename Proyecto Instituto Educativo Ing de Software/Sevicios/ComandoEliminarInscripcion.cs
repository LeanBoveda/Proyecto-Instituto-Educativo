using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevicios
{
    public class ComandoEliminarInscripcion
    {
         private readonly string dni;
        private readonly int cursoID;
        private readonly Bll._274LJBBLL_Inscripcion servicio;

        public ComandoEliminarInscripcion(string dni, int cursoID)
        {
            this.dni = dni;
            this.cursoID = cursoID;
            this.servicio = new _274LJBBLL_Inscripcion();
        }

        public void Ejecutar()
        {
            servicio.EliminarInscripcion(dni, cursoID);
        }
    }
}
