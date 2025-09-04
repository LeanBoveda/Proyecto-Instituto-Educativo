using BE;
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

namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    public partial class frmGestionUsuario : Form
    {
        public frmGestionUsuario()
        {
            InitializeComponent();
            ActualizarUsuarios();
        }
        _274LJBBLL_Usuario bllusuario = new _274LJBBLL_Usuario();
        _274LJBUsuario usuario = new _274LJBUsuario();
        private void frmGestionUsuario_Load(object sender, EventArgs e)
        {
            cmbRoles.Items.Add("Docente");
            cmbRoles.Items.Add("Preceptor");
            cmbRoles.Items.Add("Administrativo");
        }
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtDNI.Clear();
            cmbRoles.SelectedIndex = -1;
        }
        public void ActualizarUsuarios()
        {
            dgvUsuarios.DataSource = bllusuario.ListarUsuarios();
            LimpiarCampos();
        }
        private void btnAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtApellido.Text) ||
            string.IsNullOrWhiteSpace(txtUsuario.Text) ||
            string.IsNullOrWhiteSpace(txtDNI.Text) ||
            cmbRoles.SelectedItem == null)
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!long.TryParse(txtDNI.Text, out _))
                {
                    MessageBox.Show("El DNI debe contener solo números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _274LJBUsuario nuevo = new _274LJBUsuario
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    NombreUsuario = txtUsuario.Text,
                    Contraseña = txtNombre.Text.Trim() + txtDNI.Text.Trim(),
                    Rol = cmbRoles.SelectedItem.ToString(),
                    DNI = txtDNI.Text.Trim(),
                    Activo = true,
                    Bloqueado = false,
                    DebeCambiarClave = true
                };
                bllusuario.RegistrarUsuario(nuevo);
                MessageBox.Show("Usuario agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            ActualizarUsuarios();
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un Usuario para Eliminar.");
                    return;
                }
                string dni = dgvUsuarios.CurrentRow.Cells["DNI"].Value.ToString();
                if (MessageBox.Show("¿Está seguro de Eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bllusuario.EliminarUsuario(dni);
                    MessageBox.Show("Usuario eliminado correctamente.");
                    ActualizarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un Usuario para modificar.");
                    return;
                }
                _274LJBUsuario usuario = new _274LJBUsuario
                {
                    
                    ID = int.Parse(dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString()),
                    DNI = txtDNI.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    NombreUsuario = txtUsuario.Text.Trim(),
                };
                bllusuario.ModificarUsuario(usuario);
                ActualizarUsuarios();
                MessageBox.Show("Usuario modificado correctamente.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtDNI.Text = dgvUsuarios.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
                txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                txtUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();
                cmbRoles.SelectedItem = dgvUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
            }
        }
        private void btnDesbloquear_Click_1(object sender, EventArgs e)
        {
            bllusuario.DesbloquearUsuario(int.Parse(dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString()));
            ActualizarUsuarios();
        }
        private void btnBloquear_Click(object sender, EventArgs e)
        {
            bllusuario.BloquearUsuario(int.Parse(dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString()));
            ActualizarUsuarios();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            bllusuario.Activar(int.Parse(dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString()));
            ActualizarUsuarios();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            bllusuario.Desactivar(int.Parse(dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString()));
            ActualizarUsuarios();
        }
    }
}
