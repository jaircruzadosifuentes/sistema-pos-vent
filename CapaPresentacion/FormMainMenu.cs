using CapaAplicacion;
using CapaEntidades;
using CapaPresentacion.Configuración;
using CapaPresentacion.Contabilidad;
using CapaPresentacion.gVarPublicas;
using CapaPresentacion.Mantenimiento;
using CapaPresentacion.Sales;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormMainMenu : Form
    {
        private readonly FuncionesGenerales funcionesGenerales = new FuncionesGenerales();
        private readonly ManagmentCaja managmentCaja = new ManagmentCaja();
        private int childFormNumber = 0;

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //oolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        public string GetStateApp()
        {
            bool state = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName);
            string respuesta;
            if (!state)
            {
                respuesta = "SISTEMA FALLIDO - ";
            }
            else
            {
                respuesta = "SISTEMA OK - ";
            }
            return respuesta;
        }
        public string GetStateMessage()
        {
            bool state = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName);
            string mensajeOk = ">>> " + GVarPublicas.GsCaja + " APERTURADA <<<";
            string mensajeBad = ">>> DEBE DE HABILITAR " + GVarPublicas.GsCaja + " <<<";
            return !state ? string.Concat(mensajeBad, "     *** SERVIDOR PRODUCCIÓN ***"): string.Concat(mensajeOk, "       *** SERVIDOR PRODUCCIÓN ***");
        }
        public void UpdateValues()
        {
            lblTitulo.Text = string.Concat("SISVENTAS - ", funcionesGenerales.GetValueConfig("title").ToUpper());
        }
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.toolDetailUser.Text = GetStateApp() + " " + GetStateMessage();
            this.toolDetailUser.ForeColor = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName) ? Color.Green : Color.DarkRed;
            UpdateValues();
            fvPermisos();
        }
        public void fvPermisos()
        {
            if (!GVarPublicas.GsCargo.ToUpper().Equals("ADMINISTRADOR"))
            {
                configuraciónToolStripMenuItem.Visible = false;
                productosToolStripMenuItem.Visible = false;
                personasToolStripMenuItem.Visible = false;
                categoríaToolStripMenuItem.Visible = false;
                presentaciónToolStripMenuItem.Visible = false;
                btnAperturaCaja.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                copiaSeguridadToolStripMenuItem.Visible = false;
                generarCopiaDeSeguridadBDToolStripMenuItem.Visible = false;
            }
        }
        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMntPersona formMntPersona = FormMntPersona.GetInstancia();
            formMntPersona.MdiParent = this;
            formMntPersona.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReports formReportes = new FormReports();
            formReportes.MdiParent = this;
            formReportes.Show();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool state = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName);
            if (!state)
            {
                if (GVarPublicas.GsCargo.ToUpper().Equals("ADMINISTRADOR"))
                {
                    FormAperturaCajaChica formOpenCaja = new FormAperturaCajaChica();
                    formOpenCaja.MdiParent = this;
                    formOpenCaja.Show();
                }
                else
                {
                    MessageBox.Show("Usted no tiene permisos para habilitar caja, comuniquese con el Administrador del Sistema.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                FormPOS frmSales = FormPOS.GetInstancia();
                frmSales.MdiParent = this;
                frmSales.Show();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.MdiParent = this;
            formProducts.Show();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOperations formOperations = new FormOperations();
            formOperations.MdiParent = this;
            formOperations.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
        }

        private void aperturaDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAperturaCajaChica formAperturaCajaChica = new FormAperturaCajaChica();
            formAperturaCajaChica.MdiParent = this;
            formAperturaCajaChica.Show();
        }

        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMntCategoria formMntCategoria = new FormMntCategoria
            {
                MdiParent = this
            };
            formMntCategoria.Show();
        }

        private void presentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMntPresentacion formMntPresentacion = new FormMntPresentacion
            {
                MdiParent = this
            };
            formMntPresentacion.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaVentaMain_Click(object sender, EventArgs e)
        {
            bool state = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName);
            
            if (!state)
            {
                if (GVarPublicas.GsCargo.ToUpper().Equals("ADMINISTRADOR"))
                {
                    FormAperturaCajaChica formOpenCaja = new FormAperturaCajaChica();
                    formOpenCaja.MdiParent = this;
                    formOpenCaja.Show();
                }
                else
                {
                    MessageBox.Show("Usted no tiene permisos para habilitar caja, comuniquese con el Administrador del Sistema.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                FormPOS frmSales = FormPOS.GetInstancia();
                frmSales.MdiParent = this;
                frmSales.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReports formReportes = new FormReports();
            formReportes.MdiParent = this;
            formReportes.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            FormMntPersona formMntPersona = FormMntPersona.GetInstancia();
            formMntPersona.MdiParent = this;
            formMntPersona.Show();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            FormOperations formOperations = new FormOperations();
            formOperations.MdiParent = this;
            formOperations.Show();
        }

        private void FormMainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            Impresora impresora = new Impresora();

            switch (e.KeyCode)
            {
                case Keys.F2:
                    btnAperturaCaja.PerformClick();
                    break;
                case Keys.F3:
                    btnCierreCaja.PerformClick();
                    break;
                case Keys.F6:
                    btnNuevaVentaMain.PerformClick();
                    break;
                case Keys.F7:
                    impresora.AbreCajon();
                    MessageBox.Show("Cajón abierto con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                //case Keys.F8:
                //    btnReporteGeneral.PerformClick();
                case Keys.F9:
                    btnOperaciones.PerformClick();
                    break;
                case Keys.F10:
                    btnConsultar.PerformClick();
                    break;
                case Keys.F11:
                    btnCalculadora.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void acercaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcercaDe formAcercaDe = new FormAcercaDe();
            formAcercaDe.MdiParent = this;
            formAcercaDe.Show();
        }

        private void actualizaciónDeValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfigurarValoresSistema formConfigurarValores = new FormConfigurarValoresSistema();
            formConfigurarValores.MdiParent = this;
            formConfigurarValores.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FormConsultar formConsultar = new FormConsultar();
            formConsultar.MdiParent = this;
            formConsultar.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMntClientes formMntClientes = new FormMntClientes();
            formMntClientes.MdiParent = this;
            formMntClientes.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolDetailUser.Text = GetStateApp() + " " + GetStateMessage();
            this.toolDetailUser.ForeColor = managmentCaja.GetStateOpenCaja(GVarPublicas.GsUserName) ? Color.Green : Color.DarkRed;
            UpdateValues();
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            FormCierreCajaChica formCierreCajaChica = new FormCierreCajaChica();
            formCierreCajaChica.ShowDialog();
        }

        private void btnAperturaCaja_Click(object sender, EventArgs e)
        {
            FormAperturaCajaChica formAperturaCajaChica = new FormAperturaCajaChica();
            formAperturaCajaChica.ShowDialog();
        }

        private void copiaSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void generarCopiaDeSeguridadBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Realmente desea generar copia de seguridad?", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                string ConnectionString = "datasource=127.0.0.1;port=3306;username=lawcodev;password=@Jcs12344321-lw;database=bd_pan_canela;";
                ConnectionString += "charset=utf8; convertzerodatetime=true";

                var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"spooler\BackUp\");
                var nombre = funcionesGenerales.GetDateWithUser();
                string ruta = string.Concat(folder, "Copia_Seg_", nombre, ".sql");

                MySqlConnection connection = new MySqlConnection(ConnectionString);
                MySqlCommand command = new MySqlCommand();
                MySqlBackup backup = new MySqlBackup(command);

                command.Connection = connection;
                connection.Open();
                backup.ExportToFile(ruta);
                connection.Close();

                MessageBox.Show("Copia de seguridad generada correctamente.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Process calc = new Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();

            calc.WaitForExit();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Creamos una instancia d ela clase CrearTicket
            Impresora ticket = new Impresora();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.
            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo
            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("LORENS");
            ticket.TextoCentro("Calle Oro. San Isidro Mz N Lote 04");
            //ticket.TextoIzquierda("DIREC: DIRECCION DE LA EMPRESA");
            ticket.TextoCentro("Trujillo - Trujillo - La Libertad");
            ticket.TextoCentro("R.U.C: 10700252596");
            ticket.TextoCentro("BOLETA DE VENTA ELECTRÓNICA");//Es el mio por si me quieren contactar ...
            ticket.TextoCentro("BA04-0255681");//Es el mio por si me quieren contactar ...
            //ticket.TextoIzquierda("");
            //ticket.TextoExtremos("CAJERO: ", "BPSA");
            ticket.lineasGuio();
            //Sub cabecera.
            //ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ATENDIÓ: BPSA");
            ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.lineasGuio();
            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasGuio();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            //foreach (DataGridViewRow fila in dgvLista.Rows)//dgvLista es el nombre del datagridview
            //{
            //ticket.AgregaArticulo(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[5].Value.ToString()),
            //decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
            //}
            ticket.AgregaArticulo("Articulo A", 2, 20, 40);
            ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         SUBTOTAL      S/.", 100);
            ticket.AgregarTotales("         IGV           S/.", 10.04M);//La M indica que es un decimal en C#
            ticket.AgregarTotales("         TOTAL         S/.", 200);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("         EFECTIVO      S/.", 200);
            ticket.AgregarTotales("         CAMBIO        S/.", 0);

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoCentro("GRACIAS POR SU COMPRA.");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        }

        private void btnAbrirCajon_Click(object sender, EventArgs e)
        {
            Impresora impresora = new Impresora();
            impresora.AbreCajon();
            MessageBox.Show("Cajón abierto con éxito.", funcionesGenerales.GetValueConfig("title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
