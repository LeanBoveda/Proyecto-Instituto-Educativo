using Bll;
using Seguridad;
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

namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    public partial class frmProfesor : Form, IObservadorIdioma
    {

        public frmProfesor()
        {
            InitializeComponent();
            GestorIdioma.Instancia.Suscribir(this);
        }
        public void IdiomaCambiado(_274LJBIdioma idioma)
        {
            TraductorUI.AplicarIdioma(this, idioma);
        }
        private void frmPreceptor_Load(object sender, EventArgs e)
        {
            var u = SesionUsuario.ObtenerInstancia().UsuarioActual;
            lblBienvenida.Text = $"Bienvenido, {u.Nombre} ({u.Rol})";

            if (u.Rol != "Docente")
            {
                MessageBox.Show("Acceso denegado.");
                Close();
            }
        }
        private void AbrirFormulario(Form hijo)
        {
            panelContenido.Controls.Clear();
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(hijo);
            hijo.Show();
        }
        private void btnBoletines_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarNotas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmNotas());
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
           

            var result = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SesionUsuario.CerrarSesion();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cerrar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                new FormPrincipal().Show();
                this.Close();
            }
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
