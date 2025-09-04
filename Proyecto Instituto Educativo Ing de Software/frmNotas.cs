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
    public partial class frmNotas : Form, IObservadorIdioma
    {
        public frmNotas()
        {
            InitializeComponent();
            GestorIdioma.Instancia.Suscribir(this);
        }
        public void IdiomaCambiado(_274LJBIdioma idioma)
        {
            TraductorUI.AplicarIdioma(this, idioma);
        }

        _274LJBBLL_Curso BllCurso = new();
        _274LJBBLL_Materia BllMateria = new();
        _274LJBBLL_Notas BllNotas = new();
        private void frmNotas_Load(object sender, EventArgs e)
        {
            cmbCurso.DataSource = BllCurso.ObtenerCursos();
            cmbCurso.DisplayMember = "Anio";
            cmbCurso.ValueMember = "ID";

            cmbMateria.DataSource = BllMateria.ObtenerMaterias();
            cmbMateria.DisplayMember = "Nombre";
            cmbMateria.ValueMember = "ID";

            cmbTrimestre.Items.AddRange(new object[] { 1, 2, 3 });
            cmbTrimestre.SelectedIndex = 0;

            ActualizarNotas();
        }
        private void btnBuscarNotas_Click(object sender, EventArgs e)
        {
            int cursoID = Convert.ToInt32(cmbCurso.SelectedValue);
            int materiaID = Convert.ToInt32(cmbMateria.SelectedValue);
            int trimestre = Convert.ToInt32(cmbTrimestre.SelectedItem);

            dgvNotas.DataSource = BllNotas.ObtenerNotasParaCarga(cursoID, materiaID, trimestre);

            dgvNotas.Columns["NotaID"].Visible = false;
            dgvNotas.Columns["DNI"].ReadOnly = true;
            dgvNotas.Columns["Nombre"].ReadOnly = true;
            dgvNotas.Columns["Apellido"].ReadOnly = true;
            dgvNotas.Columns["Promedio"].ReadOnly = true;


            dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvNotas_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvNotas.Rows[e.RowIndex];

                string dni = row.Cells["DNI"].Value.ToString();
                object notaID = row.Cells["NotaID"].Value;
                int materiaID = Convert.ToInt32(cmbMateria.SelectedValue);
                int trimestre = Convert.ToInt32(cmbTrimestre.SelectedItem);

                decimal ex1 = LeerDecimal(row.Cells["Examen1"].Value);
                decimal ex2 = LeerDecimal(row.Cells["Examen2"].Value);
                decimal tp = LeerDecimal(row.Cells["TrabajoPractico"].Value);

                _274LJBNotas n = new()
                {
                    _274LJBDniAlumno = dni,
                    _274LJBMateriaId = materiaID,
                    _274LJBTrimestre = trimestre,
                    _274LJBEXamen1 = ex1,
                    _274LJBEXamen2 = ex2,
                    _274LJBTp = tp
                };

                if (notaID != DBNull.Value && notaID != null)
                {
                    n._274LJBid = Convert.ToInt32(notaID);
                    new _274LJBBLL_Notas().ModificarNota(n);
                }
                else
                {
                    new _274LJBBLL_Notas().AgregarNota(n);
                }

                row.Cells["Promedio"].Value = Math.Round((ex1 + ex2 + tp) / 3m, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar nota: " + ex.Message);
            }
        }

        private void dgvNotas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = dgvNotas.Columns[e.ColumnIndex].Name;
            if (columnName == "Examen1" || columnName == "Examen2" || columnName == "TrabajoPractico")
            {
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal value) || value < 0 || value > 10)
                {
                    MessageBox.Show("La nota debe ser un número entre 0 y 10.");
                    e.Cancel = true;
                }
            }
        }
        private decimal LeerDecimal(object valor)
        {
            return (valor == null || valor == DBNull.Value || valor.ToString() == "")
                ? 0m
                : Convert.ToDecimal(valor);
        }
        public void ActualizarNotas()
        {
            int cursoID = Convert.ToInt32(cmbCurso.SelectedValue);
            int materiaID = Convert.ToInt32(cmbMateria.SelectedValue);
            int trimestre = Convert.ToInt32(cmbTrimestre.SelectedItem);

            dgvNotas.DataSource = BllNotas.ObtenerNotasParaCarga(cursoID, materiaID, trimestre);

          
            dgvNotas.Columns["Nombre"].ReadOnly = true;
            dgvNotas.Columns["Apellido"].ReadOnly = true;
            dgvNotas.Columns["Promedio"].ReadOnly = true;
        }

        private void btnEliminarNota_Click(object sender, EventArgs e)
        {
            if (dgvNotas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una nota.");
                return;
            }

            object idValor = dgvNotas.CurrentRow.Cells["NotaID"].Value;
            if (idValor == null || idValor == DBNull.Value)
            {
                MessageBox.Show("La nota seleccionada no está guardada aún.");
                return;
            }

            int notaID = Convert.ToInt32(idValor);

            var confirm = MessageBox.Show("¿Está seguro que desea eliminar la nota?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                BllNotas.EliminarNota(notaID);
                MessageBox.Show("Nota eliminada correctamente.");
                btnBuscarNotas.PerformClick();

            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la nota: " + ex.Message);
            }
        }
        private void btnGuardarNotas_Click(object sender, EventArgs e)
        {
        
            try
            {
                int materiaID = Convert.ToInt32(cmbMateria.SelectedValue);
                int trimestre = Convert.ToInt32(cmbTrimestre.SelectedItem);

                foreach (DataGridViewRow row in dgvNotas.Rows)
                {
                    if (row.IsNewRow) continue;

                    string dni = row.Cells["DNI"].Value.ToString();
                    object notaID = row.Cells["NotaID"].Value;

                    decimal ex1 = LeerDecimal(row.Cells["Examen1"].Value);
                    decimal ex2 = LeerDecimal(row.Cells["Examen2"].Value);
                    decimal tp = LeerDecimal(row.Cells["TrabajoPractico"].Value);

                    _274LJBNotas n = new()
                    {
                        _274LJBDniAlumno = dni,
                        _274LJBMateriaId = materiaID,
                        _274LJBTrimestre = trimestre,
                        _274LJBEXamen1 = ex1,
                        _274LJBEXamen2 = ex2,
                        _274LJBTp = tp
                    };

                    if (notaID != DBNull.Value && notaID != null)
                    {
                        n._274LJBid = Convert.ToInt32(notaID);
                        new _274LJBBLL_Notas().ModificarNota(n);
                    }
                    else
                    {
                        new _274LJBBLL_Notas().AgregarNota(n);
                    }

                   
                    row.Cells["Promedio"].Value = Math.Round((ex1 + ex2 + tp) / 3m, 2);
                }
                
                MessageBox.Show("Notas guardadas correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar notas: " + ex.Message);
            }
        }
    }
}
