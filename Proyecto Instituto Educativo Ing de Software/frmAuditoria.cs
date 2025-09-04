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
    public partial class frmAuditoria : Form, IObservadorIdioma
    {
        public frmAuditoria()
        {
            InitializeComponent();
            GestorIdioma.Instancia.Suscribir(this);

        }
        public void IdiomaCambiado(_274LJBIdioma idioma)
        {
            TraductorUI.AplicarIdioma(this, idioma);
        }
        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            dgvBitacora.DataSource = new _274LJBBLL_Auditoria().ObtenerBitacora();
            dgvAuditoriaCambios.DataSource = new _274LJBBLL_Auditoria().ObtenerAuditoria();
            dgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAuditoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
