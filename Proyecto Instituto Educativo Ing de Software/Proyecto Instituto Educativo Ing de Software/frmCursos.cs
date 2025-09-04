using BE;
using Bll;
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
    public partial class frmCursos : Form
    {
        _274LJBBLL_Curso bllCurso = new _274LJBBLL_Curso();
        public frmCursos()
        {
            InitializeComponent();
        }
        private void frmCursos_Load(object sender, EventArgs e)
        {
            dgvCurso.DataSource = bllCurso.ObtenerCursos();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                _274LJBCurso nuevo = new _274LJBCurso
                {
                    _274LJBAño = int.Parse(txtAño.Text),
                    _274LJBDivision = txtDivision.Text.Trim().ToUpper()
                };

                bllCurso.AgregarCurso(nuevo);
                MessageBox.Show("Curso agregado correctamente.");
                dgvCurso.DataSource = bllCurso.ObtenerCursos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnModificarCurso_Click(object sender, EventArgs e)
        {
            if (dgvCurso.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un curso.");
                return;
            }

            try
            {
                _274LJBCurso modificado = new _274LJBCurso
                {
                    _274LJBId = Convert.ToInt32(dgvCurso.CurrentRow.Cells["ID"].Value),
                    _274LJBAño = int.Parse(txtAño.Text),
                    _274LJBDivision = txtDivision.Text.Trim().ToUpper()
                };

                bllCurso.ModificarCurso(modificado);
                MessageBox.Show("Curso modificado correctamente.");
                dgvCurso.DataSource = bllCurso.ObtenerCursos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            if (dgvCurso.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un curso.");
                return;
            }

            int id = Convert.ToInt32(dgvCurso.CurrentRow.Cells["ID"].Value);

            if (MessageBox.Show("¿Eliminar curso?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllCurso.EliminarCurso(id);
                MessageBox.Show("Curso eliminado.");
                dgvCurso.DataSource = bllCurso.ObtenerCursos();
            }
        }
    }
}   

