using System;
using Proyecto_Instituto_Educativo_Ing_de_Software;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factories
{
    public static class FormFactory
    {
        public static Form CrearFormPrincipal(string rol)
        {
            switch (rol)
            {
                case "Administrativo":
                    return new frmAdministrador();
                case "Docente":
                    return new frmProfesor();
                case "Preceptor":
                   // return new FrmPreceptor();
                default:
                    throw new ArgumentException("Rol no reconocido: " + rol);
            }
        }
       }

}
