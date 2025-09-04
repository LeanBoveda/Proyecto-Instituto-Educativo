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
    public partial class frmCambiarContraseña : Form
    {
        public _274LJBUsuario Usuario { get; internal set; }

        public frmCambiarContraseña(bool v)
        {
            InitializeComponent();
        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevaClave.Text != txtRepetirClave.Text)
                    throw new Exception("Las contraseñas no coinciden.");

                _274LJBBLL_Usuario bll = new _274LJBBLL_Usuario();
                bll.ReestablecerContraseña(txtUsuario.Text.Trim(), txtDNI.Text.Trim(), txtNuevaClave.Text);


                MessageBox.Show("Contraseña reestablecida correctamente.");
                this.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
