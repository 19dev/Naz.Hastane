using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Win.Properties;
using System.Drawing.Printing;
using Nini.Config;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PrinterSettingsForm : MDIChildForm
    {
        public PrinterSettingsForm()
        {
            InitializeComponent();

            this.lueInvoicePrinter.Properties.DataSource = GetPrinters();
            this.lueVoucherPrinter.Properties.DataSource = GetPrinters();

            IConfigSource cs = new IniConfigSource("Naz.Hastane.ini");
            
            this.lueInvoicePrinter.EditValue = cs.Configs["Printer"].Get("InvoicePrinter");
            lueInvoicePrinterTray.Properties.DataSource = GetPrinterTrays(lueInvoicePrinter.EditValue.ToString());
            this.lueInvoicePrinterTray.EditValue = cs.Configs["Printer"].Get("InvoicePrinterTray");

            this.lueVoucherPrinter.EditValue = cs.Configs["Printer"].Get("VoucherPrinter");

            lueVoucherPrinterTray.Properties.DataSource = GetPrinterTrays(lueVoucherPrinter.EditValue.ToString());
            this.lueVoucherPrinterTray.EditValue = cs.Configs["Printer"].Get("VoucherPrinterTray");
        }

        private List<string> GetPrinters()
        {
            List<string> printers = new List<string>();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                printers.Add(printer);
            }
            return printers;
        }

        private List<string> GetPrinterTrays(string printerName)
        {
            PrinterSettings printer = new PrinterSettings();
            printer.PrinterName = printerName;

            List<string> paperSources = new List<string>();
            if (printer.IsValid)
            {
                foreach (PaperSource paperSource in printer.PaperSources)
                {
                    paperSources.Add(paperSource.SourceName);
                }
            }
            return paperSources;
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            IConfigSource cs = new IniConfigSource("Naz.Hastane.ini");

            cs.Configs["Printer"].Set("InvoicePrinter", this.lueInvoicePrinter.Text);
            cs.Configs["Printer"].Set("InvoicePrinterTray", this.lueInvoicePrinterTray.Text);

            cs.Configs["Printer"].Set("VoucherPrinter", this.lueVoucherPrinter.Text);
            cs.Configs["Printer"].Set("VoucherPrinterTray", this.lueVoucherPrinterTray.Text);

            cs.Save();
        }

        private void lueInvoicePrinter_EditValueChanged(object sender, EventArgs e)
        {
            lueInvoicePrinterTray.Properties.DataSource = GetPrinterTrays(lueInvoicePrinter.Text);
        }

        private void lueVoucherPrinter_EditValueChanged(object sender, EventArgs e)
        {
            lueVoucherPrinterTray.Properties.DataSource = GetPrinterTrays(lueVoucherPrinter.Text);
        }
    }
}