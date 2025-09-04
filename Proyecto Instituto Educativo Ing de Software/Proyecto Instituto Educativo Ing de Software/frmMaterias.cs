using BE;
using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
        }
        _274LJBBLL_Materia bllMateria = new _274LJBBLL_Materia();
        private void frmMaterias_Load(object sender, EventArgs e)
        {
            dgvMaterias.DataSource = bllMateria.ObtenerMaterias();

        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            _274LJBMateria m = new _274LJBMateria { _274LJBnombre = txtNombre.Text.Trim() };
            bllMateria  .AgregarMateria(m);
            dgvMaterias.DataSource = bllMateria.ObtenerMaterias();
        }

        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow == null) return;

            _274LJBMateria m = new _274LJBMateria
            {
                _274LJBId = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["ID"].Value),
                _274LJBnombre = txtNombre.Text.Trim()
            };
            bllMateria.ModificarMateria(m);
            dgvMaterias.DataSource = bllMateria.ObtenerMaterias();
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["ID"].Value);
            bllMateria.EliminarMateria(id);
            dgvMaterias.DataSource = bllMateria.ObtenerMaterias();
        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                txtNombre.Text = dgvMaterias.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
        }
    }
}
