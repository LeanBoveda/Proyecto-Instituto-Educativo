using BE;
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
    public partial class frmGestionAlumnos : Form, IObservadorIdioma
    {
        _274LJBBLL_Alumno BLLAlumno = new _274LJBBLL_Alumno();
        _274LJBBLL_Auditoria auditoria = new _274LJBBLL_Auditoria();

        public frmGestionAlumnos()
        {
            InitializeComponent();
            GestorIdioma.Instancia.Suscribir(this);
        }
        public void IdiomaCambiado(_274LJBIdioma idioma)
        {
            TraductorUI.AplicarIdioma(this, idioma);
        }
        private void frmGestionAlumnos_Load(object sender, EventArgs e)
        {
            CargarAlumnos();

        }
        private void CargarAlumnos()
        {
            dgvAlumnos.DataSource = new _274LJBBLL_Alumno().ObtenerAlumnos();
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            dtpNacimiento.Value = DateTime.Now;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtBuscarDNI.Clear();
        }
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtDNI.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
              

                if (!long.TryParse(txtDNI.Text, out _))
                {
                    MessageBox.Show("El DNI debe contener solo números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _274LJBAlumno alumno = new _274LJBAlumno
            {
                _274LJBDNI = txtDNI.Text,
                _274LJBNombre = txtNombre.Text,
                _274LJBApellido = txtApellido.Text,
                _274LJBFechaNacimiento = dtpNacimiento.Value,
                _274LJBDireccion = txtDireccion.Text,
                _274LJBTelefono = txtTelefono.Text
            };

                

                BLLAlumno.AgregarAlumno(alumno);
            CargarAlumnos();

                MessageBox.Show("Usuario agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un alumno para modificar.");
                    return;
                }

                _274LJBAlumno alumno = new _274LJBAlumno
                {
                    _274LJBDNI = txtDNI.Text.Trim(),
                    _274LJBNombre = txtNombre.Text.Trim(),
                    _274LJBApellido = txtApellido.Text.Trim(),
                    _274LJBFechaNacimiento = dtpNacimiento.Value,
                    _274LJBDireccion = txtDireccion.Text.Trim(),
                    _274LJBTelefono = txtTelefono.Text.Trim()
                };

                BLLAlumno.ModificarAlumno(alumno);
                MessageBox.Show("Alumno modificado correctamente.");
                CargarAlumnos();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un alumno para eliminar.");
                    return;
                }

                string dni = dgvAlumnos.CurrentRow.Cells["DNI"].Value.ToString();

                if (MessageBox.Show("¿Está seguro de eliminar este alumno?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BLLAlumno.EliminarAlumno(dni);
                    MessageBox.Show("Alumno eliminado correctamente.");
                    CargarAlumnos();
                }
                var usuario = SesionUsuario.ObtenerInstancia().UsuarioActual;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvAlumnos.Rows[e.RowIndex];
                txtDNI.Text = fila.Cells["DNI"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                dtpNacimiento.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtBuscarDNI.Text.Trim();
                dgvAlumnos.DataSource = BLLAlumno.BuscarAlumnoPorDNI(dni);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
