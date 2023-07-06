using CapaAplicacion;
using CapaEntidades;
using System;
using System.Collections.Generic;
using CapaPresentacion.gVarPublicas;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;
using System.Media;
using WMPLib;
using System.Data.OleDb;

namespace CapaPresentacion
{
    public class FuncionesGenerales 
    {
        public ManagmentSystemConfig managmentSystemConfig = new ManagmentSystemConfig();
        //Devolvemos el valor de la configuración del sistema.

        public void fvSonarNotificacion(int tipo)
        {
            var folder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Sonidos\");
            WindowsMediaPlayer player = new WindowsMediaPlayer();

            switch (tipo)
            {
                case 1:
                    player.URL = string.Concat(folder, "beep.mp3");
                    player.controls.play();
                    break;
                case 2:
                    player.URL = string.Concat(folder, "notificacion.mp3");
                    player.controls.play();
                    break;
                default:
                    break;
            }
        }
        public string GetFechaActual()
        {
            DateTime date = DateTime.Now;
            string annio = date.Year.ToString();
            string mes = date.Month.ToString();
            string dia = date.Day.ToString();
            string fecha = string.Concat(dia + "/" + (Convert.ToInt32(mes) < 10 ? string.Concat("0", mes) : mes) + "/" + annio);
            return fecha;
        }

        public string GetValueConfig(string type)
        {
            string typeValue = "";
            List<SystemConfig> systemConfigs = managmentSystemConfig.GetAllSystemConfig();
            foreach (SystemConfig systemConfig in systemConfigs)
            {
                switch (systemConfig.Name)
                {
                    case "direccion":
                        if (type.Equals("direccion"))
                            typeValue = systemConfig.Value;
                        break;
                    case "impresora":
                        if (type.Equals("impresora"))
                            typeValue = systemConfig.Value;
                        break;
                    case "title":
                        if (type.Equals("title"))
                            typeValue = systemConfig.Value;
                        break;
                    case "copyright":
                        if (type.Equals("copyright"))
                            typeValue = systemConfig.Value;
                        break;
                    case "image":
                        if (type.Equals("image"))
                            typeValue = systemConfig.Value;
                        break;
                    case "maintenance":
                        if (type.Equals("maintenance"))
                            typeValue = systemConfig.Value;
                        break;
                    case "moneda_default":
                        if (type.Equals("moneda_default"))
                            typeValue = systemConfig.Value;
                        break;
                    case "version":
                        if (type.Equals("version"))
                            typeValue = systemConfig.Value;
                        break;
                    case "ruc":
                        if (type.Equals("ruc"))
                            typeValue = systemConfig.Value;
                        break;
                    case "stock_alert_product":
                        if (type.Equals("stock_alert_product"))
                            typeValue = systemConfig.Value;
                        break;
                    case "show_ruc":
                        if (type.Equals("show_ruc"))
                            typeValue = systemConfig.Value;
                        break;
                    case "api_key_license":
                        if (type.Equals("api_key_license"))
                            typeValue = systemConfig.Value;
                        break;
                    case "descripcion_acerca_de":
                        if (type.Equals("descripcion_acerca_de"))
                            typeValue = systemConfig.Value;
                        break;
                    case "sonido_notificaciones":
                        if (type.Equals("sonido_notificaciones"))
                            typeValue = systemConfig.Value;
                        break;
                    case "hora_cierre_caja":
                        if (type.Equals("hora_cierre_caja"))
                            typeValue = systemConfig.Value;
                        break;
                    case "imprimir_ticket_factura":
                        if (type.Equals("imprimir_ticket_factura"))
                            typeValue = systemConfig.Value;
                        break;
                    default:
                        break;
                }
            }
            return typeValue;
        }
        public string GetGreeting()
        {
            string greeting = "";
            int hour = Convert.ToInt32(DateTime.Now.Hour);
            if(hour >= 0 && hour <= 12)
            {
                greeting = "Buenos días";
            }
            else
            {
                if (hour >= 13 && hour <= 18)
                {
                    greeting = "Buenas tardes";
                }
                else
                {
                    if (hour >= 19 && hour <= 24)
                    {
                        greeting = "Buenas noches";
                    }
                }
            }
            return greeting;
        }

        public static bool IsLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public bool IsDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public void ValidatingNumbers(KeyPressEventArgs keyPress)
        {
            if (Char.IsDigit(keyPress.KeyChar))
            {
                keyPress.Handled = false;
            }
            else if (Char.IsSeparator(keyPress.KeyChar))
            {
                keyPress.Handled = false;
            }
            else if (Char.IsControl(keyPress.KeyChar))
            {
                keyPress.Handled = false;
            }
            else
            {
                keyPress.Handled = true;
            }
        }
        public void ValidatingLetters(KeyPressEventArgs keyPress)
        {
            if (Char.IsLetter(keyPress.KeyChar))
            {
                keyPress.Handled = false;
            }
            else if (Char.IsSeparator(keyPress.KeyChar))
            {
                keyPress.Handled = false;
            }
            else if (Char.IsControl(keyPress.KeyChar))
            {
                keyPress.Handled = false;
            }
            else
            {
                keyPress.Handled = true;
            }
        }
        public static bool IsLettersOrDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }

        public static bool IsLettersOrDigitsOrUnderscores(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c) && c != '_')
                    return false;
            }
            return true;
        }
        public string GetDateWithUser()
        {
            int yeah = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            string dateFinish = yeah + "" + FillWithZeros(month) + "" + FillWithZeros(day) + "" + FillWithZeros(hour) + "" + FillWithZeros(minutes) + "" + FillWithZeros(second) + "" + GVarPublicas.GsUserName.ToUpper();
            return dateFinish;
        }
        public string FillWithZeros(int value)
        {
            return value < 10 ? ("0" + value).ToString() : value.ToString();
        }
        public void AddRowTablaGrid(DataGridView dataGridView, int rows)
        {
            if(rows >= 1)
            {
                dataGridView.Rows.Add();
            }
        }
    }
}
