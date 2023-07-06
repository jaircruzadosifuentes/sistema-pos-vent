using CapaAplicacion;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;
namespace CapaPresentacion.Mantenimiento
{
    public partial class FormMntProductsCargarExcel : MaterialSkin.Controls.MaterialForm
    {
        bool estadoExcel = false;
        List<ErrorInventario> listErrores = new List<ErrorInventario>();

        public FormMntProductsCargarExcel()
        {
            InitializeComponent();
        }

        private void FormMntProductsCargarExcel_Load(object sender, EventArgs e)
        {
            EstadoControles(false);
            AlternarColores(dgViewInventario);
            this.ActiveControl = btnCargarArchivo;
        }
        public void RedimensionarColumnas()
        {
            this.dgViewInventario.Columns["Nro"].Width = 50;
            this.dgViewInventario.Columns["Estado"].Width = 75;
            this.dgViewInventario.Columns["Codigo_barras"].Width = 120;
            this.dgViewInventario.Columns["Producto"].Width = 200;
            this.dgViewInventario.Columns["Valor_costo"].Width = 65;
            this.dgViewInventario.Columns["Valor_venta"].Width = 65;
            this.dgViewInventario.Columns["Categoria"].Width = 100;
            this.dgViewInventario.Columns["Presentacion"].Width = 100;
            this.dgViewInventario.Columns["Stock_almacen"].Width = 100;
            this.dgViewInventario.Columns["Stock_venta"].Width = 100;
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void EstadoControles(bool estado)
        {
            btnProcesar.Enabled = estado;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //if(estadoExcel)
            //{
            //    //DialogResult Opcion;
            //    //Opcion = MessageBox.Show("El archivo excel abierto se va a cerrar, si desea guarde éste formato o puedes visualizarlo en la carpeta Spooler del Sistema.", new funcionesGenerales().GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //    //if (Opcion == DialogResult.OK)
            //    //{
            //    //    this.Close();
            //    //    System.GC.Collect();
            //    //    MatarProcesoExcel();
            //    //}
            //    this.Close();
            //    System.GC.Collect();
            //}
            //else
            //{
            //    this.Close();
            //    System.GC.Collect();
            //}
            this.Close();
            System.GC.Collect();
        }
        public void MatarProcesoExcel()
        {
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (System.Diagnostics.Process p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName))
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = txtArchivoRuta.Text;
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    txtArchivoRuta.Text = fileDialog.FileName;
                    EstadoControles(txtArchivoRuta.Text.Length > 0);
                    btnProcesar.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede leer el archivo debido a: " + ex.Message);
                    throw;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(rbIngreso.Checked)
            {
                if (!btnProcesar.Enabled)
                {
                    MessageBox.Show("Primero se debe de procesar archivo, para guardar datos.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea guardar inventario procesado?", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    bool estadoRegistro = false;
                    Product product = new Product();
                    foreach (DataGridViewRow inventario in dgViewInventario.Rows)
                    {
                        string estado = Convert.ToString(inventario.Cells[1].Value);
                        if(estado.Equals("OK"))
                        {
                            string codigoBarras = Convert.ToString(inventario.Cells[2].Value);
                            string descripcion = Convert.ToString(inventario.Cells[3].Value);
                            decimal valorCosto = Convert.ToDecimal(inventario.Cells[4].Value);
                            decimal valorVenta = Convert.ToDecimal(inventario.Cells[5].Value);
                            string codigoCategoria = Convert.ToString(inventario.Cells[6].Value);
                            string codigoPresentacion = Convert.ToString(inventario.Cells[7].Value);
                            decimal stockAlmacen = Convert.ToDecimal(inventario.Cells[8].Value);
                            decimal stockVenta = Convert.ToDecimal(inventario.Cells[9].Value);
                            DateTime fechaVencimiento = DateTime.Now.AddYears(1);

                            int categoriaId = new ManagmentProducts().ServiceRecuperaIdPorCodigo(1, codigoCategoria);
                            int presentacionId = new ManagmentProducts().ServiceRecuperaIdPorCodigo(2, codigoPresentacion);

                            Category category = new Category();
                            category.CategoryId = categoriaId;

                            UMedida uMedida = new UMedida();
                            uMedida.PresentationId = presentacionId;

                            product.Name = descripcion;
                            product.BarCode = codigoBarras;
                            product.StockAlmacen = stockAlmacen;
                            product.Stock = stockVenta;
                            product.CostPrice = valorCosto;
                            product.Price = valorVenta;
                            product.DueDate = fechaVencimiento;

                            product.Category = category;
                            product.UMedida = uMedida;

                            bool inserta = new ManagmentProducts().InsertaProduct(product);
                            if(inserta)
                            {
                                estadoRegistro = true;
                            }
                        }
                    }
                    if(estadoRegistro)
                    {
                        MessageBox.Show("Registro de inventario realizado con éxito.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnProcesar.Enabled = false;
                        btnGuardar.Enabled = false;
                        lblRegistrosBad.Visible = false;
                        lblItems.Visible = false;
                        dgViewInventario.Visible = false;
                        txtArchivoRuta.Text = "";
                        btnProcesar.Text = "Procesar";
                    }
                    else
                    {
                        MessageBox.Show("Todos los registros procesados están con error, no se guardará datos.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
            else if(rbActualiza.Checked)
            {
                if (!btnProcesar.Enabled)
                {
                    MessageBox.Show("Primero se debe de procesar archivo, para guardar datos.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea actualizar el inventario procesado?", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    bool estadoActualiza = false;
                    Product product = new Product();
                    foreach (DataGridViewRow inventario in dgViewInventario.Rows)
                    {
                        string estado = Convert.ToString(inventario.Cells[1].Value);
                        if (estado.Equals("OK"))
                        {
                            string codigoBarras = Convert.ToString(inventario.Cells[2].Value);
                            string descripcion = Convert.ToString(inventario.Cells[3].Value);
                            decimal valorCosto = Convert.ToDecimal(inventario.Cells[4].Value);
                            decimal valorVenta = Convert.ToDecimal(inventario.Cells[5].Value);
                            string codigoCategoria = Convert.ToString(inventario.Cells[6].Value);
                            string codigoPresentacion = Convert.ToString(inventario.Cells[7].Value);
                            decimal stockAlmacen = Convert.ToDecimal(inventario.Cells[8].Value);
                            decimal stockVenta = Convert.ToDecimal(inventario.Cells[9].Value);
                            DateTime fechaVencimiento = DateTime.Now.AddYears(1);

                            int categoriaId = new ManagmentProducts().ServiceRecuperaIdPorCodigo(1, codigoCategoria);
                            int presentacionId = new ManagmentProducts().ServiceRecuperaIdPorCodigo(2, codigoPresentacion);
                            int productoId = new ManagmentProducts().ServiceRecuperaIdPorCodigo(3, codigoBarras);

                            Category category = new Category();
                            category.CategoryId = categoriaId;

                            UMedida uMedida = new UMedida();
                            uMedida.PresentationId = presentacionId;

                            product.ProductId = productoId;
                            product.Name = descripcion;
                            product.BarCode = codigoBarras;
                            product.StockAlmacen = stockAlmacen;
                            product.Stock = stockVenta;
                            product.CostPrice = valorCosto;
                            product.Price = valorVenta;
                            product.DueDate = fechaVencimiento;
                            product.Utility = valorVenta - valorCosto;

                            product.Category = category;
                            product.UMedida = uMedida;

                            bool actualiza = new ManagmentProducts().UpdateProduct(product);
                            if (actualiza)
                            {
                                estadoActualiza = true;
                            }
                        }
                    }
                    if (estadoActualiza)
                    {
                        MessageBox.Show("Actualización de inventario realizado con éxito.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnProcesar.Enabled = false;
                        btnGuardar.Enabled = false;
                        lblRegistrosBad.Visible = false;
                        lblItems.Visible = false;
                        dgViewInventario.Visible = false;
                        txtArchivoRuta.Text = "";
                        btnProcesar.Text = "Procesar";
                    }
                    else
                    {
                        MessageBox.Show("Todos los registros procesados están con error, no se actualizarán datos.", new FuncionesGenerales().GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            
            btnProcesar.Text = "Procesando";
            btnProcesar.Enabled = false;
            dgViewInventario.Visible = false;
            ExcelApp.Application excelApp = new ExcelApp.Application();
            string codigoBarras = "", producto = "", categoria = "", presentacion = "";
            decimal valorCosto = 0, valorVenta = 0, stockAlmacen = 0, stockVenta = 0;
            ErrorInventario errorInventario = null; 
            int contador = 0;
            if (excelApp == null)
            {
                return;
            }
            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(txtArchivoRuta.Text.Trim());
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;
            if (listErrores == null)
            {
                listErrores = new List<ErrorInventario>();
            }
            int rows = excelRange.Rows.Count;
            int cols = excelRange.Columns.Count;
            DataTable dt = null;
            dt = new DataTable();
            dt.Columns.Add("Nro", typeof(int));
            dt.Columns.Add("Estado", typeof(string));
            dt.Columns.Add("Codigo_barras", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Valor_costo", typeof(decimal));
            dt.Columns.Add("Valor_venta", typeof(decimal));
            dt.Columns.Add("Categoria", typeof(string));
            dt.Columns.Add("Presentacion", typeof(string));
            dt.Columns.Add("Stock_almacen", typeof(decimal));
            dt.Columns.Add("Stock_venta", typeof(decimal));
            for (int i = 5; i <= rows; i++)
            {
                for (int j = 2; j <= cols; j++)
                {
                    contador = contador + 1;
                    if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                    {
                        if (excelRange.Cells[i, 2] != null && excelRange.Cells[i, 3] != null && excelRange.Cells[i, 10] != null && excelRange.Cells[i, 11] != null && excelRange.Cells[i, 12] != null && excelRange.Cells[i, 13] != null && excelRange.Cells[i, 14] != null && excelRange.Cells[i, 15] != null)
                        { 
                            DataRow dataRow = dt.NewRow();
                            errorInventario = new ErrorInventario();
                            codigoBarras = excelRange.Cells[i, 2].Value2.ToString();
                            // Validate category
                            dataRow["Estado"] = "OK";
                            if(rbIngreso.Checked)
                            {
                                if (!fbValidateProducto(codigoBarras.Trim()))
                                {
                                    errorInventario.NroRegistro = contador;
                                    errorInventario.Nombre = "El producto ya está registrado, use la opción de Actualización de inventario.";
                                    errorInventario.Columna = "Codigo_barras";
                                    errorInventario.Valor = codigoBarras;
                                    dataRow["Estado"] = "Error";
                                    listErrores.Add(errorInventario);
                                    errorInventario = null;
                                }
                            } 
                            else if(rbActualiza.Checked)
                            {
                                if (fbValidateProducto(codigoBarras.Trim()))
                                {
                                    errorInventario.NroRegistro = contador;
                                    errorInventario.Nombre = "El producto no ha sido encontrado.";
                                    errorInventario.Columna = "Codigo_barras";
                                    errorInventario.Valor = codigoBarras;
                                    dataRow["Estado"] = "Error";
                                    listErrores.Add(errorInventario);
                                    errorInventario = null;
                                }
                            }
                            dataRow["Codigo_barras"] = codigoBarras;

                            dataRow["Nro"] = Convert.ToInt32(contador);

                            producto = excelRange.Cells[i, 3].Value2.ToString();
                            dataRow["Producto"] = producto;

                            valorCosto = Convert.ToDecimal(excelRange.Cells[i, 10].Value2);
                            dataRow["Valor_costo"] = Convert.ToDecimal(valorCosto);

                            valorVenta = Convert.ToDecimal(excelRange.Cells[i, 11].Value2);
                            dataRow["Valor_venta"] = Convert.ToDecimal(valorVenta);

                            categoria = excelRange.Cells[i, 12].Value2.ToString();
                            if (!fbValidateCategory(categoria))
                            {
                                errorInventario = new ErrorInventario();
                                errorInventario.NroRegistro = contador;
                                errorInventario.Nombre = "Código de categoría no encontrado";
                                errorInventario.Columna = "Categoria";
                                errorInventario.Valor = categoria;
                                dataRow["Estado"] = "Error";
                                listErrores.Add(errorInventario);
                                errorInventario = null;
                            }
                            dataRow["Categoria"] = categoria;

                            presentacion = excelRange.Cells[i, 13].Value2.ToString();
                            if(!fbValidatePresentation(presentacion))
                            {
                                errorInventario = new ErrorInventario();
                                errorInventario.NroRegistro = contador;
                                errorInventario.Nombre = "Código de presentación no encontrado";
                                errorInventario.Columna = "Presentacion";
                                errorInventario.Valor = presentacion;
                                dataRow["Estado"] = "Error";
                                listErrores.Add(errorInventario);
                                errorInventario = null;
                            }
                            dataRow["Presentacion"] = presentacion;

                            stockAlmacen = Convert.ToDecimal(excelRange.Cells[i, 14].Value2);
                            dataRow["Stock_almacen"] = Convert.ToDecimal(stockAlmacen);

                            stockVenta = Convert.ToDecimal(excelRange.Cells[i, 15].Value2);
                            dataRow["Stock_venta"] = Convert.ToDecimal(stockVenta);

                            j = j + cols;
                            dt.Rows.Add(dataRow);
                        }
                    }
                }
            }
            dgViewInventario.Visible = true;
            dgViewInventario.DataSource = dt;
            RedimensionarColumnas();
            lblItems.Visible = true;
            lblItems.Text = string.Concat("Se han cargado ", dgViewInventario.Rows.Count, " registros.");
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            btnProcesar.Enabled = true;
            btnProcesar.Text = "Procesado";
            btnGuardar.Enabled = true;
            btnGuardar.Focus();
            lblRegistrosBad.Visible = true;
            
            lblRegistrosBad.Text = string.Concat("Se han detectado ", listErrores.Count, " errores.");
            if(listErrores.Count > 0)
            {
                btnLogErrores.Visible = true;
                btnLogErrores.Focus();
            }
        }
        public bool fbValidateCategory(string codigoCategoria)
        {
            bool respuesta = true;
            DataTable dataTable = new ManagmentProducts().ServiceValidaDatosInventario(1, codigoCategoria);
            if(dataTable.Rows.Count > 0)
            {
                if(Convert.ToInt32(dataTable.Rows[0]["hay_datos"]) == 0)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool fbValidatePresentation(string codePresentation)
        {
            bool respuesta = true;
            DataTable dataTable = new ManagmentProducts().ServiceValidaDatosInventario(2, codePresentation);
            if (dataTable.Rows.Count > 0)
            {
                if (Convert.ToInt32(dataTable.Rows[0]["hay_datos"]) == 0)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool fbValidateProducto(string codigoBarras)
        {
            bool respuesta = true;
            DataTable dataTable = new ManagmentProducts().ServiceValidaDatosInventario(3, codigoBarras);
            if (dataTable.Rows.Count > 0)
            {
                if (Convert.ToInt32(dataTable.Rows[0]["hay_datos"]) == 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        private void rbActualiza_CheckedChanged(object sender, EventArgs e)
        {
            if(rbActualiza.Checked)
            {
                btnGuardar.Text = "Actualizar";
                EstadoControles(false);
                txtArchivoRuta.Text = "";
                btnGuardar.Enabled = false;
                lblItems.Visible = false;
                lblRegistrosBad.Visible = false;
                dgViewInventario.DataSource = null;
                btnLogErrores.Visible = false;
                listErrores = null;
                dgViewInventario.Visible = false;
                btnProcesar.Text = "Procesar";
            }
        }

        private void rbIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if(rbIngreso.Checked)
            {
                btnGuardar.Text = "Guardar";
                btnProcesar.Text = "Procesar";
                EstadoControles(false);
                txtArchivoRuta.Text = "";
                btnGuardar.Enabled = false;
                lblItems.Visible = false;
                lblRegistrosBad.Visible = false;
                dgViewInventario.DataSource = null;
                btnLogErrores.Visible = false;
                listErrores = null;
                dgViewInventario.Visible = false;
            }
        }

        private void btnFormato_Click(object sender, EventArgs e)
        {
            var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"spooler\");
            var nombre = "FORMAT_INVENTARIO.xlsx";

            ExcelApp.Application Excel = new ExcelApp.Application();
            ExcelApp.Workbook wbv = Excel.Workbooks.Open(string.Concat(folder, nombre));
            ExcelApp.Worksheet wx = Excel.ActiveSheet as ExcelApp.Worksheet;
            Excel.Visible = true;
            estadoExcel = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblRegistrosBad_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistrosOk_Click(object sender, EventArgs e)
        {

        }

        private void btnLogErrores_Click(object sender, EventArgs e)
        {
            FormLogErrores formLogErrores = new FormLogErrores();
            formLogErrores.erroresInventarios = listErrores;
            formLogErrores.ShowDialog();
        }

        private void dgViewInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgViewInventario.Rows)
            {           
                if (Convert.ToString(Myrow.Cells[1].Value).Equals("Error")) 
                {
                    Myrow.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }
    }
}
