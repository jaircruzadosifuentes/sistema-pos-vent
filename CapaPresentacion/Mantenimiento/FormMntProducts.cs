using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAplicacion;
using CapaEntidades;
using CapaPresentacion.gVarPublicas;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using CapaPresentacion.Mantenimiento;

namespace CapaPresentacion
{
    public partial class FormProducts : MaterialSkin.Controls.MaterialForm
    {
        #region
        private readonly ManagmentProducts managmentProducts = new ManagmentProducts();
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        private readonly ManagmentAuth managmentAuth = new ManagmentAuth();
        private bool IS_MODIFICATION = false;
        private bool IS_NEW = false;
        Excel.Application xlApplication;
        Excel._Workbook xlLibro;
        Excel._Worksheet xlHoja;
        //Excel.Range xlRange;

        #endregion

        public FormProducts()
        {
            InitializeComponent();
        }
        private void AlternarColores(DataGridView datagrid)
        {
            datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }
        public void CentrarItemsTable()
        {
            this.dgTableProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgTableProductos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void DesactivarColumnas()
        {
            this.dgTableProductos.Columns[0].Visible = false;
            this.dgTableProductos.Columns["product_id"].Visible = false;
        }
        public void RedimensionarColumnas()
        {
            this.dgTableProductos.Columns["Nombre"].Width = 250;
            this.dgTableProductos.Columns["Cod_Barras"].Width = 90;
            this.dgTableProductos.Columns["Stock"].Width = 60;
            this.dgTableProductos.Columns["Moneda"].Width = 60;
            this.dgTableProductos.Columns["StockAlmacen"].Width = 90;
            this.dgTableProductos.Columns["Precio_venta"].Width = 80;
            this.dgTableProductos.Columns["Precio_costo"].Width = 80;
            this.dgTableProductos.Columns["Utilidad"].Width = 60;
            this.dgTableProductos.Columns["Dias_restantes"].Width = 90;
            this.dgTableProductos.Columns["Fecha_vencimiento"].Width = 115;
            this.dgTableProductos.Columns["UMedida"].Width = 60;
            this.dgTableProductos.Columns["Estado"].Width = 80;
            this.dgTableProductos.Columns["Estado_almacen"].Width = 100;
        }
        
        public void InhabilitarControles(bool estado)
        {
            this.btnEliminar.Enabled = !estado;
            this.btnModificar.Enabled = !estado;
            gbDatosProducto.Enabled = !estado;
            this.btnGuardar.Enabled = !estado;
            this.btnMoverStock.Enabled = !estado;
        }
        public void HabilitarControlesNuevo(bool estado)
        {
            gbDatosProducto.Enabled = estado;
            tbPanelProducto.SelectedIndex = estado ? 1 : 0;
            this.btnNuevo.Enabled = !estado;
            this.btnCancelar.Visible = estado;
            this.btnEliminar.Visible = !estado;
            this.btnExcel.Enabled = !estado;
            this.btnGuardar.Enabled = estado;
            this.txtCodigoBarras.Focus();
        }
        public void HabilitarControlesModificar(bool estado)
        {
            gbDatosProducto.Enabled = estado;
            tbPanelProducto.SelectedIndex = estado ? 1 : 0;
            this.btnNuevo.Enabled = !estado;
            this.btnCancelar.Visible = estado;
            this.btnEliminar.Visible = !estado;
            this.btnExcel.Enabled = !estado;
            this.btnMoverStock.Enabled = estado;
            this.btnModificar.Enabled = estado;
            this.btnGuardar.Enabled = IS_MODIFICATION ? false: true;
            this.txtCodigoBarras.Focus();
        }
        public void LoadCategory()
        {
            cboCategoria.DataSource = managmentProducts.GetAllCategoryForCombo();
            cboCategoria.ValueMember = "categoryId";
            cboCategoria.DisplayMember = "name";
        }
        public void ClearControllers()
        {
            this.txtCodigoBarras.Text = "";
            this.txtNombre.Text = "";
            this.txtDescripcion.Text = "";
            this.cboCategoria.Text = "";
            this.cboUMedida.Text = "";
            this.txtStock.Text = "";
            this.txtStockAlmacen.Text = "";
            this.txtPrecioCosto.Text = "";
            this.txtPrecioVenta.Text = "";
            this.txtUtilidad.Text = "";
        }
        public void LoadUMedida()
        {
            cboUMedida.DataSource = managmentProducts.GetAllUMedidaForCombo();
            cboUMedida.ValueMember = "presentationId";
            cboUMedida.DisplayMember = "name";
        }
        public void DisabledControl()
        {
            if (!managmentAuth.PermisoEspecial(GVarPublicas.GsUserName, "1"))
            {
                chkAnular.Enabled = false;
                lblAuthAnular.Visible = true;
            }
            else
            {
                chkAnular.Enabled = true;
                lblAuthAnular.Visible = false;
            }
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadTableProducts();
            AlternarColores(dgTableProductos);
            DesactivarColumnas();
            RedimensionarColumnas();
            CentrarItemsTable();
            ControlesFocusPorDefecto();
            InhabilitarControles(true);
            LoadCategory();
            LoadUMedida();
            DisabledControl();
        }
        public void ControlesFocusPorDefecto()
        {
            cboTipoBusqueda.SelectedIndex = 0;
            txtBuscarProducto.Focus();
        }
        public string MostrarValoresCombo(int value)
        {
            string valor = "";
            switch (value)
            {
                case 0:
                    valor = "Cod.barras";
                    return valor;
                case 1:
                    valor = "Nombre";
                    return valor;
                case 2:
                    valor = "Categoria";
                    return valor;
                case 3:
                    valor = "Presentacion";
                    return valor;
                default:
                    break;
            }
            return valor;
        }
        public void LoadTableProducts()
        {
            dgTableProductos.DataSource = managmentProducts.GetAllProducts();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                xlApplication = new Excel.Application();
                xlApplication.Visible = false;
                //Visible progres bar
                pb2.Visible = true;
                pb1.Visible = true;
                //Get a new workbook.
                xlLibro = xlApplication.Workbooks.Add(Missing.Value);
                xlHoja = (Excel._Worksheet)xlLibro.ActiveSheet;
                xlHoja.Name = "REP_PRODUCTOS";
                var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"spooler\");
                var nombre = "REPORTE_PRODUCTOS_GENERAL.xlsx";
                if(File.Exists(folder + nombre)) File.Delete(folder + nombre);
                GenerarExcelCabeceraProductos();
                if (GenerarExcelCuerpoProductos())
                {
                    Excel.Sheets worksheets = xlLibro.Worksheets;
                    var xlNewSheet = (Excel.Worksheet)worksheets.Add(worksheets[1], Type.Missing, Type.Missing, Type.Missing);
                    xlNewSheet.Name = "KARDEX";

                    //Kardex
                    int showRuc = Convert.ToInt32(funcionesGenerales.GetValueConfig("show_ruc"));
                    //Titulo
                    xlNewSheet.Cells[2, 2] = "REPORTE KARDEX VALORIZADO DE PRODUCTOS";
                    if (showRuc == 1) xlNewSheet.Cells[3, 2] = "RUC: " + funcionesGenerales.GetValueConfig("ruc");
                    xlNewSheet.Cells[4, 2] = "RAZON SOCIAL: " + funcionesGenerales.GetValueConfig("title").Replace("&&", "&").ToUpper();

                    //Merge titulo
                    var rangeMergue = xlNewSheet.Range["B2:G2"];
                    rangeMergue.Merge();
                    xlNewSheet.Range["B2:G2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    xlNewSheet.Range["B2:G2"].Font.Size = 14;
                    xlNewSheet.Range["B2:G2"].Font.Name = "Arial";

                    //Usuario
                    xlNewSheet.Cells[2, 14] = "USUARIO: " + GVarPublicas.GsUserName.ToUpper();
                    xlNewSheet.Cells[3, 14] = "FECHA: " + DateTime.Now;

                    xlNewSheet.Range["B2:P2"].Font.Bold = true;
                    xlNewSheet.Range["B3:P3"].Font.Bold = true;
                    xlNewSheet.Range["B4:F4"].Font.Bold = true;
                    xlNewSheet.Range["B5:F5"].Font.Bold = true;

                    xlNewSheet.Range["A6:A6"].ColumnWidth = 4;
                    xlNewSheet.Range["B6:B6"].ColumnWidth = 4; //Nro
                    xlNewSheet.Range["C6:C6"].ColumnWidth = 18; //Fecha de registro
                    xlNewSheet.Range["D6:D6"].ColumnWidth = 10; //Tipo
                    xlNewSheet.Range["E6:E6"].ColumnWidth = 35; //Producto
                    xlNewSheet.Range["F6:F6"].ColumnWidth = 15; //Cantidad entrada
                    xlNewSheet.Range["G6:G6"].ColumnWidth = 15; //Cantidad salida

                    xlNewSheet.Range["B6:G6"].Font.Bold = true;
                    xlNewSheet.Range["B6:D6"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    xlNewSheet.Range["B6:D6"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    xlNewSheet.Range["B6:G6"].Borders.LineStyle = true;

                    xlNewSheet.Range["B6:G6"].Font.Color = Color.Black;
                    xlNewSheet.Range["B6:G6"].Interior.Color = Color.Orange;

                    xlNewSheet.Cells[6, 2] = "N°";
                    xlNewSheet.Cells[6, 3] = "Fecha registro";
                    xlNewSheet.Cells[6, 4] = "Tipo";
                    xlNewSheet.Cells[6, 5] = "Producto";
                    xlNewSheet.Cells[6, 6] = "Cantidad entrada";
                    xlNewSheet.Cells[6, 7] = "Cantidad salida";

                    //Cuerpo
                    DataTable getAllKardex = managmentProducts.ServiceGetAllKardex();
                    long nFilas = 6;
                    long contador = 0;
                    lblMensajeProceso.Text = "Generando kardex de productos.";

                    pb1.Maximum = getAllKardex.Rows.Count;
                    pb1.Value = 1;
                    pb2.Maximum = getAllKardex.Rows.Count;
                    pb2.Value = 1;

                    foreach (DataRow row in getAllKardex.Rows)
                    {
                        nFilas = nFilas + 1;
                        contador = contador + 1;
                        long indice = nFilas;
                        xlNewSheet.Cells[nFilas, 2] = contador;
                        xlNewSheet.Cells[nFilas, 3] = row["Fecha"];
                        xlNewSheet.Cells[nFilas, 4] = row["Tipo"];
                        xlNewSheet.Cells[nFilas, 5] = row["Producto"];
                        xlNewSheet.Cells[nFilas, 6] = row["cantidadEntrada"];
                        xlNewSheet.Cells[nFilas, 6].NumberFormat = "#,##0.00";
                        xlNewSheet.Cells[nFilas, 7] = row["cantidadSalida"];
                        xlNewSheet.Cells[nFilas, 7].NumberFormat = "#,##0.00";
                        pb1.PerformStep();
                        pb2.PerformStep();
                    }
                    for (long i = 6; i <= 6 + getAllKardex.Rows.Count; i++)
                    {
                        for (int j = 2; j <= 7; j++)
                        {
                            if (j >= 6 && j <= 7)
                            {
                                xlNewSheet.Cells[i, j].Borders.LineStyle = true;
                                xlNewSheet.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                            }
                            else if (j == 5)
                            {
                                xlNewSheet.Cells[i, j].Borders.LineStyle = true;
                                xlNewSheet.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                            }
                            else
                            {
                                xlNewSheet.Cells[i, j].Borders.LineStyle = true;
                                xlNewSheet.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                xlNewSheet.Cells[i, j].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }
                        }
                    }
                    lblMensajeProceso.Text = "Reporte excel generado correctamente.";
                    xlNewSheet = (Excel.Worksheet)xlLibro.Worksheets.get_Item(1);

                    xlApplication.Visible = true;
                    xlApplication.UserControl = false;
                    xlLibro.SaveAs(folder + nombre);
                    pb1.Visible = false;
                    pb1.Value = 0;
                    pb2.Visible = false;
                    pb2.Value = 0;
                    lblMensajeProceso.Visible = false;
                }
                else
                {
                    MessageBox.Show("¡No existen datos para mostrar!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }
      
        public void GenerarExcelCabeceraProductos()
        {
            int showRuc = Convert.ToInt32(funcionesGenerales.GetValueConfig("show_ruc"));
            //Titulo
            xlHoja.Cells[2, 2] = "REPORTE GENERAL DE PRODUCTOS";
            if(showRuc == 1) xlHoja.Cells[3, 2] = "RUC: " + funcionesGenerales.GetValueConfig("ruc");
            xlHoja.Cells[4, 2] = "RAZON SOCIAL: " + funcionesGenerales.GetValueConfig("title").Replace("&&", "&").ToUpper();
            
            //Merge titulo
            var rangeMergue = xlHoja.Range["B2:L2"];
            rangeMergue.Merge();
            xlHoja.Range["B2:L2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B2:L2"].Font.Size = 14;
            xlHoja.Range["B2:L2"].Font.Name = "Arial";

            //Usuario
            xlHoja.Cells[2, 14] = "USUARIO: " + GVarPublicas.GsUserName.ToUpper();
            xlHoja.Cells[3, 14] = "FECHA: " + DateTime.Now;

            xlHoja.Range["B2:P2"].Font.Bold = true;
            xlHoja.Range["B3:P3"].Font.Bold = true;
            xlHoja.Range["B4:F4"].Font.Bold = true;
            xlHoja.Range["B5:F5"].Font.Bold = true;

            xlHoja.Range["A6:A6"].ColumnWidth = 4;
            xlHoja.Range["B6:B6"].ColumnWidth = 4;
            xlHoja.Range["C6:C6"].ColumnWidth = 12;
            xlHoja.Range["D6:D6"].ColumnWidth = 12;
            xlHoja.Range["E6:E6"].ColumnWidth = 25;
            xlHoja.Range["F6:F6"].ColumnWidth = 15;
            xlHoja.Range["G6:G6"].ColumnWidth = 7;
            xlHoja.Range["H6:H6"].ColumnWidth = 12;
            xlHoja.Range["I6:I6"].ColumnWidth = 13;
            xlHoja.Range["J6:J6"].ColumnWidth = 13;
            xlHoja.Range["K6:K6"].ColumnWidth = 15;
            xlHoja.Range["L6:L6"].ColumnWidth = 20;

            xlHoja.Range["B6:L6"].Font.Bold = true;
            xlHoja.Range["B6:D6"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:D6"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            xlHoja.Range["B6:L6"].Borders.LineStyle = true;

            xlHoja.Range["B6:L6"].Font.Color = Color.Black;
            xlHoja.Range["B6:L6"].Interior.Color = Color.Orange;

            xlHoja.Cells[6, 2] = "N°";
            xlHoja.Cells[6, 3] = "Categoría";
            xlHoja.Cells[6, 4] = "U.Medida";
            xlHoja.Cells[6, 5] = "Producto";
            xlHoja.Cells[6, 6] = "Cód.Barras";
            xlHoja.Cells[6, 7] = "Stock";
            xlHoja.Cells[6, 8] = "Stock almacen";
            xlHoja.Cells[6, 9] = "Precio Compra";
            xlHoja.Cells[6, 10] = "Precio Venta";
            xlHoja.Cells[6, 11] = "Fecha Venc.";
            xlHoja.Cells[6, 12] = "Estado";
        }
        public bool GenerarExcelCuerpoProductos()
        {
            DataTable getAllProductos = managmentProducts.GetAllProducts();
            long nFilas = 6;
            long contador = 0;
            lblMensajeProceso.Visible = true;
            lblMensajeProceso.Text = "Generando reporte de productos.";
            pb1.Maximum = getAllProductos.Rows.Count;
            pb1.Value = 1;
            pb2.Maximum = getAllProductos.Rows.Count;
            pb2.Value = 1;

            foreach (DataRow row in getAllProductos.Rows)
            {
                nFilas = nFilas + 1;
                contador = contador + 1;
                long indice = nFilas;
                MostrarFilaResaltada(indice, Convert.ToInt32(row["Dias_restantes"]), Convert.ToInt32(row["Stock"]), Convert.ToInt32(row["StockAlmacen"]));
                xlHoja.Cells[nFilas, 2] = contador;
                xlHoja.Cells[nFilas, 3] = row["Categoria"];
                xlHoja.Cells[nFilas, 4] = row["UMedida"];
                xlHoja.Cells[nFilas, 5] = row["Nombre"];
                xlHoja.Cells[nFilas, 6] = row["Cod_barras"];
                xlHoja.Cells[nFilas, 7] = row["Stock"];
                xlHoja.Cells[nFilas, 8] = row["StockAlmacen"];
                xlHoja.Cells[nFilas, 9] = row["Precio_costo"];
                xlHoja.Cells[nFilas, 10] = row["Precio_venta"];
                xlHoja.Cells[nFilas, 11] = row["Fecha_vencimiento"];
                xlHoja.Cells[nFilas, 12] = MostrarEstadoProducto(Convert.ToInt32(row["Dias_restantes"]), Convert.ToInt32(row["Stock"]), Convert.ToInt32(row["StockAlmacen"]));
                pb1.PerformStep();
                pb2.PerformStep();
            }
            for (long i = 6; i <= 6 + getAllProductos.Rows.Count ; i++)
            {
                for (int j = 2; j <= 12; j++)
                {
                    if(j >= 7 && j <= 10)
                    {
                        xlHoja.Cells[i, j].Borders.LineStyle = true;
                        xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    }
                    else if(j == 5)
                    {
                        xlHoja.Cells[i, j].Borders.LineStyle = true;
                        xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    }
                    else
                    {
                        xlHoja.Cells[i, j].Borders.LineStyle = true;
                        xlHoja.Cells[i, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        xlHoja.Cells[i, j].VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    }
                }
            }
            bool ExistenRegistros = getAllProductos.Rows.Count > 0 ? true : false;
            return ExistenRegistros;
        }
        public void MostrarFilaResaltada(long indice, int diasVencimiento, int stock, int stockAlmacen)
        {
            string rango;
            int stockAlert = Convert.ToInt32(funcionesGenerales.GetValueConfig("stock_alert_product"));
            bool stockEstadoAmbos = stock < stockAlert && stockAlmacen < stockAlert ? true : false;
            if(stockEstadoAmbos)
            {
                rango = "B" + indice + ":" + "L" + indice;
                //xlHoja.Range[rango].Font.Color = Color.White;
                //xlHoja.Range[rango].Interior.Color = Color.IndianRed;
                xlHoja.Range[rango].Font.Bold = true;
            }
            else
            {
                if (diasVencimiento < 0)
                {
                    rango = "B" + indice + ":" + "L" + indice;
                    xlHoja.Range[rango].Font.Color = Color.DarkRed;
                    //xlHoja.Range[rango].Interior.Color = Color.Yellow;
                    //xlHoja.Range[rango].Font.Bold = true;
                }
                else if (stock < stockAlert)
                {
                    rango = "B" + indice + ":" + "L" + indice;
                    //xlHoja.Range[rango].Font.Color = Color.Black;
                    //xlHoja.Range[rango].Interior.Color = Color.Gold;
                    //xlHoja.Range[rango].Font.Bold = true;
                }
                else if (stockAlmacen < stockAlert)
                {
                    rango = "B" + indice + ":" + "L" + indice;
                    //xlHoja.Range[rango].Font.Color = Color.White;
                    //xlHoja.Range[rango].Interior.Color = Color.MediumVioletRed;
                    //xlHoja.Range[rango].Font.Bold = true;
                }
            }
        }
        public string MostrarEstadoProducto(int diasVencimiento, int stock, int stockAlmacen)
        {
            string estado;
            int stockAlert = Convert.ToInt32(funcionesGenerales.GetValueConfig("stock_alert_product"));
            bool stockEstadoAmbos = stock < stockAlert && stockAlmacen < stockAlert ? true: false;

            if(stockEstadoAmbos)
            {
                estado = "Stock total agotado";
            }
            else
            {
                if (diasVencimiento < 0)
                {
                    estado = "Producto vencido";
                }
                else if (stock < stockAlert)
                {
                    estado = "Stock agotado";
                }
                else if (stockAlmacen < stockAlert)
                {
                    estado = "Stock almacen agotado";
                }
                else
                {
                    estado = "Normal";
                }
            }
            return estado;
        }

        private void cboTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBuscar.Text = "Buscar producto por " + MostrarValoresCombo(cboTipoBusqueda.SelectedIndex);
        }

        private void dgTableProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgTableProductos.Columns["Anular"].Index)
            {
                if(e.RowIndex != -1)
                {
                    DataGridViewCheckBoxCell CheckAnular = (DataGridViewCheckBoxCell)dgTableProductos.Rows[e.RowIndex].Cells["Anular"];
                    CheckAnular.Value = !Convert.ToBoolean(CheckAnular.Value);
                }
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            switch (cboTipoBusqueda.SelectedIndex)
            {
                case 0:
                    this.dgTableProductos.DataSource = managmentProducts.GetByCodBarrasProduct(txtBuscarProducto.Text);
                    break;
                case 1:
                    this.dgTableProductos.DataSource = managmentProducts.GetByNameProduct(txtBuscarProducto.Text);
                    break;
                case 2:
                    this.dgTableProductos.DataSource = managmentProducts.GetByCategoryProduct(txtBuscarProducto.Text);
                    break;
                case 3:
                    this.dgTableProductos.DataSource = managmentProducts.GetByUMedidaProduct(txtBuscarProducto.Text);
                    break;
                default:
                    break;
            }
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControlesNuevo(true);
            IS_NEW = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IS_MODIFICATION)
            {
                HabilitarControlesModificar(false);
                IS_MODIFICATION = false;
                ClearControllers();
            }
            else
            {
                HabilitarControlesNuevo(false);
                IS_NEW = false;
                ClearControllers();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                int contador = 0;
                bool estadoAnulado = false;
                Opcion = MessageBox.Show("¿Realmente desea anular los productos seleccionados?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int idproducto;
                    foreach (DataGridViewRow row in dgTableProductos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            idproducto = Convert.ToInt32(row.Cells[1].Value);
                            bool anular = managmentProducts.BannedProduct(Convert.ToInt32(idproducto), funcionesGenerales.GetDateWithUser());
                            if (anular)
                            {
                                contador = contador + 1;
                                estadoAnulado = true;
                                continue;
                            }
                            else
                            {
                                contador = 0;
                                estadoAnulado = false;
                                MessageBox.Show("¡Error al anular Producto!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    if(estadoAnulado)
                    {
                        MessageBox.Show($"{(contador > 1 ? "Productos anulados": "Producto anulado")} con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTableProducts();
                        chkAnular.Checked = false;
                        contador = 0;
                        estadoAnulado = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgTableProductos_DoubleClick(object sender, EventArgs e)
        {
            if (!managmentAuth.PermisoEspecial(GVarPublicas.GsUserName, "3"))
            {
                MessageBox.Show("¡No tiene permiso para modificar un producto, comuniquese con el Administrador!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.txtIdProducto.Text = Convert.ToString(this.dgTableProductos.CurrentRow.Cells["product_id"].Value);
                this.txtCodigoBarras.Text = Convert.ToString(this.dgTableProductos.CurrentRow.Cells["Cod_Barras"].Value);
                this.txtNombre.Text = Convert.ToString(this.dgTableProductos.CurrentRow.Cells["Nombre"].Value);
                this.txtStock.Text = Convert.ToString(this.dgTableProductos.CurrentRow.Cells["Stock"].Value);
                this.txtPrecioCosto.Text = Convert.ToString(this.dgTableProductos.CurrentRow.Cells["Precio_costo"].Value);
                this.txtPrecioVenta.Text = Convert.ToString(this.dgTableProductos.CurrentRow.Cells["Precio_venta"].Value);
                this.txtStockAlmacen.Text = Convert.ToString(this.dgTableProductos.CurrentRow.Cells["StockAlmacen"].Value);
                this.txtUtilidad.Text = Convert.ToString(this.dgTableProductos.CurrentRow.Cells["Utilidad"].Value);
                this.cboCategoria.Text = Convert.ToString(this.dgTableProductos.CurrentRow.Cells["Categoria"].Value);
                this.cboUMedida.Text = Convert.ToString(this.dgTableProductos.CurrentRow.Cells["UMedida"].Value);
                this.dtpDueDate.Text = Convert.ToString(this.dgTableProductos.CurrentRow.Cells["Fecha_vencimiento"].Value);
                IS_MODIFICATION = true;
                HabilitarControlesModificar(true);
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnGuardar.Focus();
            }
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cboUMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtStock.Focus();
            }
        }

        private void cboUMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtStockAlmacen.Focus();
            }
        }

        private void txtStockAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtPrecioCosto.Focus();
            }
        }

        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtPrecioVenta.Focus();
            }
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            if (IS_MODIFICATION || IS_NEW)
            {
                if (txtPrecioVenta.Text == string.Empty)
                {
                    txtPrecioVenta.BackColor = Color.Gold;
                    MessageBox.Show("¡El precio de venta no puede ser cero!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    txtPrecioVenta.BackColor = Color.White;
                    decimal precioCosto = Convert.ToDecimal(txtPrecioCosto.Text);
                    decimal precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    txtUtilidad.Text = (precioVenta - precioCosto).ToString();
                }
            }
        }

        private void txtPrecioCosto_TextChanged(object sender, EventArgs e)
        {
            if (IS_MODIFICATION || IS_NEW)
            {
                if (txtPrecioCosto.Text == string.Empty)
                {
                    MessageBox.Show("¡El precio costo no puede ser cero!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtPrecioCosto.BackColor = Color.Gold;
                }
                else
                {
                    txtPrecioCosto.BackColor = Color.White;
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool flagValidate = validaDatosProducto();
            if (flagValidate)
            {
                if (IS_MODIFICATION)
                {
                    string barCode = txtCodigoBarras.Text;
                    string name = txtNombre.Text;
                    int productId = Convert.ToInt32(txtIdProducto.Text);
                    decimal stock = Convert.ToDecimal(txtStock.Text);
                    decimal stockAlmacen = Convert.ToDecimal(txtStockAlmacen.Text);
                    decimal costPrice = Convert.ToDecimal(txtPrecioCosto.Text);
                    decimal salePrice = Convert.ToDecimal(txtPrecioVenta.Text);
                    decimal utility = Convert.ToDecimal(txtUtilidad.Text);
                    int categoryId = Convert.ToInt32(cboCategoria.SelectedValue);
                    int presentationId = Convert.ToInt32(cboUMedida.SelectedValue);
                    DateTime dueDate = dtpDueDate.Value;
                    Product product = new Product();
                    Category category = new Category();
                    UMedida uMedida = new UMedida();

                    category.CategoryId = categoryId;
                    uMedida.PresentationId = presentationId;
                    product.ProductId = productId;
                    product.Name = name;
                    product.BarCode = barCode;
                    product.Stock = stock;
                    product.StockAlmacen = stockAlmacen;
                    product.CostPrice = costPrice;
                    product.Price = salePrice;
                    product.Utility = utility;
                    product.DueDate = dueDate;
                    product.Category = category;
                    product.UMedida = uMedida;

                    bool update = managmentProducts.UpdateProduct(product);
                    if (update)
                    {
                        MessageBox.Show("Producto actualizado con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HabilitarControlesModificar(false);
                        IS_MODIFICATION = false;
                        ClearControllers();
                        LoadTableProducts();
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Llene los campos vacios!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        public bool validaDatosProducto()
        {
            bool validaDatos = true;

            int categoryId = Convert.ToInt32(cboCategoria.SelectedValue);
            int presentationId = Convert.ToInt32(cboUMedida.SelectedValue);

            if (txtCodigoBarras.Text == string.Empty || txtNombre.Text == string.Empty || txtStock.Text == string.Empty || txtStockAlmacen.Text == string.Empty
                || categoryId == 0 || presentationId == 0)
            {
                validaDatos = false;
            }
            return validaDatos;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool flagValidate = validaDatosProducto();
            if (flagValidate)
            {
                if (IS_NEW)
                {

                    string barCode = txtCodigoBarras.Text;
                    string name = txtNombre.Text;
                    decimal stock = Convert.ToDecimal(txtStock.Text);
                    decimal stockAlmacen = Convert.ToDecimal(txtStockAlmacen.Text);
                    decimal costPrice = Convert.ToDecimal(txtPrecioCosto.Text);
                    decimal salePrice = Convert.ToDecimal(txtPrecioVenta.Text);
                    decimal utility = Convert.ToDecimal(txtUtilidad.Text);
                    int categoryId = Convert.ToInt32(cboCategoria.SelectedValue);
                    int presentationId = Convert.ToInt32(cboUMedida.SelectedValue);
                    DateTime dueDate = dtpDueDate.Value;
                    Product product = new Product();
                    Category category = new Category();
                    UMedida uMedida = new UMedida();

                    category.CategoryId = categoryId;
                    uMedida.PresentationId = presentationId;

                    product.Name = name;
                    product.BarCode = barCode;
                    product.Stock = stock;
                    product.StockAlmacen = stockAlmacen;
                    product.CostPrice = costPrice;
                    product.Price = salePrice;
                    product.Utility = utility;
                    product.DueDate = dueDate;
                    product.Category = category;
                    product.UMedida = uMedida;

                    bool insert = managmentProducts.InsertaProduct(product);
                    if (insert)
                    {
                        MessageBox.Show("Producto registrado con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HabilitarControlesNuevo(false);
                        IS_NEW = false;
                        ClearControllers();
                        LoadTableProducts();
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Llene los campos vacios!", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkAnular.Checked)
            {
                this.dgTableProductos.Columns[0].Visible = true;
                this.dgTableProductos.Columns[0].Width = 40;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.dgTableProductos.Columns[0].Visible = false;
                this.dgTableProductos.Columns[0].Width = 40;
                this.btnEliminar.Enabled = false;
            }     
        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void btnMoverStock_Click(object sender, EventArgs e)
        {
            FormMntProductMoverStock formMntProductMoverStock = new FormMntProductMoverStock();
            formMntProductMoverStock.Inicio(Convert.ToInt32(txtIdProducto.Text), txtNombre.Text, Convert.ToDecimal(txtStockAlmacen.Text), Convert.ToDecimal(txtStock.Text));
            formMntProductMoverStock.ShowDialog();
            btnCancelar.PerformClick();
            LoadTableProducts();
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
            FormMntProductsCargarExcel formMntProductsCargarExcel = new FormMntProductsCargarExcel();
            formMntProductsCargarExcel.ShowDialog();
            LoadTableProducts();
        }
    }
}
