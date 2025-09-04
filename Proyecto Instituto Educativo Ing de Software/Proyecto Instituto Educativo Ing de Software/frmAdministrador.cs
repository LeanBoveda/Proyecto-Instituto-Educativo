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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void btnGestionAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmGestionAlumnos());
        }
        private void AbrirFormulario(Form formHijo)
        {
            panelPrincipal.Controls.Clear();
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formHijo);
            formHijo.Show();
        }
        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmGestionUsuario());

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

        private void btnCertificados_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Aun en Desarrollo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInscripcionAlumnos());
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAuditoria());
        }
    }
}
