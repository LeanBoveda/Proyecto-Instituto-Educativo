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
    public partial class frmInscripcionAlumnos : Form
    {
        public frmInscripcionAlumnos()
        {
            InitializeComponent();
        }

        _274LJBBLL_Curso bllCurso = new _274LJBBLL_Curso();
        _274LJBBLL_Inscripcion bllInscripcion = new _274LJBBLL_Inscripcion();
        private void frmInscripcionAlumnos_Load(object sender, EventArgs e)
        {
            DataTable cursos = bllCurso.ObtenerCursos();

            if (!cursos.Columns.Contains("Descripcion"))
                cursos.Columns.Add("Descripcion", typeof(string));

            foreach (DataRow row in cursos.Rows)
            {
                row["Descripcion"] = row["Anio"] + "º " + row["Division"];
            }

            cmbCursos.DataSource = cursos;
            cmbCursos.DisplayMember = "Descripcion";
            cmbCursos.ValueMember = "ID";
        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCursos.SelectedValue == null || cmbCursos.SelectedValue is DataRowView)
                    return;

                int cursoID = Convert.ToInt32(cmbCursos.SelectedValue);

                dgvNoInscritos.DataSource = bllInscripcion.ListarAlumnosDisponiblesGenerales();
                dgvInscritos.DataSource = bllInscripcion.ObtenerAlumnosDelCurso(cursoID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNoInscritos.CurrentRow == null) return;

                string dni = dgvNoInscritos.CurrentRow.Cells["DNI"].Value.ToString();
                int cursoID = Convert.ToInt32(cmbCursos.SelectedValue);

                bllInscripcion.InscribirAlumno(dni, cursoID, DateTime.Now);
                MessageBox.Show($"DNI: {dni}\nCursoID: {cursoID}\nFecha: {DateTime.Now}");

                MessageBox.Show("Alumno inscrito correctamente.");
                OnAlumnoInscripto?.Invoke(dni, cursoID);

                cmbCursos_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inscribir: " + ex.Message);
            }
        }
        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            if (dgvInscritos.CurrentRow == null) return;

            string dni = dgvInscritos.CurrentRow.Cells["DNI"].Value.ToString();
            int cursoID = Convert.ToInt32(cmbCursos.SelectedValue);
            bllInscripcion.EliminarInscripcion(dni, cursoID);
            cmbCursos_SelectedIndexChanged(null, null);
        }
        public delegate void AlumnoInscriptoHandler(string dni, int cursoID);
        public event AlumnoInscriptoHandler OnAlumnoInscripto;

    }
}
