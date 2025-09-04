using Bll;
using Sevicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factories;
using Seguridad;
using BE;
using DAL;


namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    public partial class FormPrincipal : Form, IObservadorIdioma
    {
        _274LJBBLL_Auditoria auditoria = new _274LJBBLL_Auditoria();
        public FormPrincipal()
        {
            InitializeComponent();
            GestorIdioma.Instancia.Suscribir(this);
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            menuCerrarSesion.Enabled = false;
            try
            {
                idiomas = IdiomaLoader.CargarIdiomas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando idiomas: " + ex.Message);
            }
        }   
        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            gp_iniciarSesion.Visible = true;
        }
        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar Sesion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SesionUsuario.CerrarSesion();
                menuIniciarSesion.Visible = true;
                txtUsuario.Enabled = true;
                txtContraseña.Enabled = true;
                MessageBox.Show("Sesión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var bll = new _274LJBBLL_Usuario();
                var usuario = bll.LoginSeguro(txtUsuario.Text, txtContraseña.Text);

                SesionUsuario.IniciarSesion(usuario);

                MessageBox.Show($"Bienvenido {usuario.Nombre} ({usuario.Rol})");

                menuIniciarSesion.Visible = false;
                txtUsuario.Enabled = false;
                txtContraseña.Enabled = false;
                gp_iniciarSesion.Visible = false;
                menuCerrarSesion.Enabled = true;

                Acceso acceso = new Acceso();
                acceso.Abrir();
                //acceso.SetUsuarioActivo(usuario.NombreUsuario);

                Form menu = FormFactory.CrearFormPrincipal(usuario.Rol);
                this.Hide();
                menu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            gp_iniciarSesion.Visible = false;

        }
        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña cambiarContraseña = new frmCambiarContraseña(true);
            cambiarContraseña.ShowDialog();
        }
        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña cambiarContraseña = new frmCambiarContraseña(true);
            cambiarContraseña.ShowDialog();
        }

        void IObservadorIdioma.IdiomaCambiado(_274LJBIdioma idioma)
        {
            AplicarIdioma(idioma);
        }

        private Dictionary<string, _274LJBIdioma> idiomas;
        public void IdiomaCambiado(_274LJBIdioma idioma)
        {
            AplicarIdioma(idioma);
        }
        private void AplicarIdioma(_274LJBIdioma idioma)
        {
            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                TraducirMenu(item, idioma);
            }
        }
        private void TraducirControles(Control.ControlCollection controls, _274LJBIdioma idioma)
        {
            foreach (Control ctrl in controls)
            {
                if (idioma.Traducciones.ContainsKey(ctrl.Name))
                    ctrl.Text = idioma.Traducir(ctrl.Name);

                if (ctrl.HasChildren)
                    TraducirControles(ctrl.Controls, idioma);
            }
        }
        private void TraducirMenu(ToolStripMenuItem menuItem, _274LJBIdioma idioma)
        {
            if (idioma.Traducciones.ContainsKey(menuItem.Name))
                menuItem.Text = idioma.Traducir(menuItem.Name);

            foreach (ToolStripItem subItem in menuItem.DropDownItems)
            {
                if (subItem is ToolStripMenuItem)
                    TraducirMenu((ToolStripMenuItem)subItem, idioma);
            }
        }
        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idiomas != null && idiomas.ContainsKey("Español"))
                GestorIdioma.Instancia.CambiarIdioma(idiomas["Español"]);
        }
        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idiomas != null && idiomas.ContainsKey("Inglés"))
                GestorIdioma.Instancia.CambiarIdioma(idiomas["Inglés"]);
        }
        private void portuguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idiomas != null && idiomas.ContainsKey("Portugués"))
                GestorIdioma.Instancia.CambiarIdioma(idiomas["Portugués"]);
        }
    }
}
