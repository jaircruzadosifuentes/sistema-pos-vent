using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Mantenimiento
{
    public partial class FormLogErrores : MaterialSkin.Controls.MaterialForm
    {
        public List<ErrorInventario> erroresInventarios { get; set; }
        public FormLogErrores()
        {
            InitializeComponent();
        }
        public void RedimensionarColumnas()
        {
            this.dgLogErrores.Columns["Nro"].Width = 50;
            this.dgLogErrores.Columns["Descripción"].Width = 430;
            this.dgLogErrores.Columns["Columna"].Width = 120;
            this.dgLogErrores.Columns["Valor_errónea"].Width = 120;
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void CargarDatosLog()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nro", typeof(int));
            dataTable.Columns.Add("Descripción", typeof(string));
            dataTable.Columns.Add("Columna", typeof(string));
            dataTable.Columns.Add("Valor_errónea", typeof(string));

            foreach (ErrorInventario error in erroresInventarios)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["Nro"] = error.NroRegistro;
                dataRow["Descripción"] = error.Nombre;
                dataRow["Columna"] = error.Columna;
                dataRow["Valor_errónea"] = error.Valor;
                dataTable.Rows.Add(dataRow);
            }
            dgLogErrores.DataSource = dataTable;
            RedimensionarColumnas();
        }
        private void FormLogErrores_Load(object sender, EventArgs e)
        {
            CargarDatosLog();
            AlternarColores(dgLogErrores);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
