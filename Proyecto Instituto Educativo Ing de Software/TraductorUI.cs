using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sevicios
{
    public static class TraductorUI
    {
        public static void AplicarIdioma(Form formulario, _274LJBIdioma idioma)
        {
            if (idioma == null) return;

            TraducirControles(formulario.Controls, idioma);

            foreach (Control ctrl in formulario.Controls)
            {
                if (ctrl is MenuStrip)
                {
                    foreach (ToolStripMenuItem item in ((MenuStrip)ctrl).Items)
                        TraducirMenu(item, idioma);
                }
            }
        }

        private static void TraducirControles(Control.ControlCollection controls, _274LJBIdioma idioma)
        {
            foreach (Control ctrl in controls)
            {
                if (idioma.Traducciones.ContainsKey(ctrl.Name))
                    ctrl.Text = idioma.Traducir(ctrl.Name);

                if (ctrl.HasChildren)
                    TraducirControles(ctrl.Controls, idioma);
            }
        }

        private static void TraducirMenu(ToolStripMenuItem menuItem, _274LJBIdioma idioma)
        {
            if (idioma.Traducciones.ContainsKey(menuItem.Name))
                menuItem.Text = idioma.Traducir(menuItem.Name);

            foreach (ToolStripItem subItem in menuItem.DropDownItems)
            {
                if (subItem is ToolStripMenuItem)
                    TraducirMenu((ToolStripMenuItem)subItem, idioma);
            }
        }
    }
}
