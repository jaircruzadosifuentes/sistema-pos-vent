using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormAcercaDe : MaterialSkin.Controls.MaterialForm
    {
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        public FormAcercaDe()
        {
            InitializeComponent();
        }

        private void FormAcercaDe_Load(object sender, EventArgs e)
        {
            lblCopyright.Text = funcionesGenerales.GetValueConfig("copyright");
            lblApiKey.Text = string.Concat("Licencia: ", funcionesGenerales.GetValueConfig("api_key_license"));
        }
    }
}
