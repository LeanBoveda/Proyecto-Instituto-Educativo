using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevicios
{
    public class ComandoAuditable : ICommand
    {
        private readonly ICommand comando;
        private readonly string descripcion;

        public ComandoAuditable(ICommand comando, string descripcion)
        {
            this.comando = comando;
            this.descripcion = descripcion;
        }

        public void Ejecutar()
        {
            try
            {
                comando.Ejecutar();
                _274LJBAuditorio.Registrar("Ejecutar Comando", descripcion);
            }
            catch (Exception ex)
            {
                _274LJBAuditorio.Registrar("Error en Comando", descripcion + " | ERROR: " + ex.Message);
                throw;
            }
        }
    
    }
}
