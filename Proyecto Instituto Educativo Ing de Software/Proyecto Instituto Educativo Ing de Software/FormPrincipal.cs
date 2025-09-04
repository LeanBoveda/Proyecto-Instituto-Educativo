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

namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    public partial class FormPrincipal : Form, IObservadorIdioma
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            menuCerrarSesion.Enabled = false;   
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void gp_iniciarSesion_Enter(object sender, EventArgs e)
        {

        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void portuguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var idiomas = IdiomaLoader.CargarDesdeJson("Recursos\\idioma.json");
            if (idiomas.TryGetValue("Portugués", out _274LJBIdioma portugues))
            {
                GestorIdioma.Instancia.CambiarIdioma(portugues);
            }
            else
            {
                MessageBox.Show("No se encontró el idioma Portugués en el archivo JSON.");
            }
        }

        void IObservadorIdioma.IdiomaCambiado(_274LJBIdioma idioma)
        {
            throw new NotImplementedException();
        }
    }
}
