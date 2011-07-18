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

            IConfigSource cs = UIUtilities.ConfigurationSource;

            this.lueInvoicePrinter.Properties.DataSource = UIUtilities.GetPrinters();
            this.lueInvoicePrinter.EditValue = cs.Configs["Printer"].Get("InvoicePrinter", "");
            this.lueInvoicePrinterTray.Properties.DataSource = UIUtilities.GetPrinterTrays(lueInvoicePrinter.EditValue.ToString());
            this.lueInvoicePrinterTray.EditValue = cs.Configs["Printer"].Get("InvoicePrinterTray", "");

            this.lueVoucherPrinter.Properties.DataSource = UIUtilities.GetPrinters();
            this.lueVoucherPrinter.EditValue = cs.Configs["Printer"].Get("VoucherPrinter", "");
            this.lueVoucherPrinterTray.Properties.DataSource = UIUtilities.GetPrinterTrays(lueVoucherPrinter.EditValue.ToString());
            this.lueVoucherPrinterTray.EditValue = cs.Configs["Printer"].Get("VoucherPrinterTray", "");

            this.lueNormalPrinter.Properties.DataSource = UIUtilities.GetPrinters();
            this.lueNormalPrinter.EditValue = cs.Configs["Printer"].Get("NormalPrinter", "");
            this.lueNormalPrinterTray.Properties.DataSource = UIUtilities.GetPrinterTrays(lueVoucherPrinter.EditValue.ToString());
            this.lueNormalPrinterTray.EditValue = cs.Configs["Printer"].Get("NormalPrinterTray", "");

            this.teInvoiceUser.Text = cs.Configs["User"].Get("InvoiceUser", "");
            this.teInvoicePassword.Text = cs.Configs["User"].Get("InvoicePassword", "");
            this.teVoucherUser.Text = cs.Configs["User"].Get("VoucherUser", "");
            this.teVoucherPassword.Text = cs.Configs["User"].Get("VoucherPassword", "");
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            IConfigSource cs = UIUtilities.ConfigurationSource;

            cs.Configs["Printer"].Set("InvoicePrinter", this.lueInvoicePrinter.Text);
            cs.Configs["Printer"].Set("InvoicePrinterTray", this.lueInvoicePrinterTray.Text);

            cs.Configs["Printer"].Set("VoucherPrinter", this.lueVoucherPrinter.Text);
            cs.Configs["Printer"].Set("VoucherPrinterTray", this.lueVoucherPrinterTray.Text);

            cs.Configs["Printer"].Set("NormalPrinter", this.lueNormalPrinter.Text);
            cs.Configs["Printer"].Set("NormalPrinterTray", this.lueNormalPrinterTray.Text);

            cs.Configs["User"].Set("InvoiceUser", this.teInvoiceUser.Text);
            cs.Configs["User"].Set("InvoicePassword", this.teInvoicePassword.Text);

            cs.Configs["User"].Set("VoucherUser", this.teVoucherUser.Text);
            cs.Configs["User"].Set("VoucherPassword", this.teVoucherPassword.Text);

            cs.Save();
        }

        private void lueInvoicePrinter_EditValueChanged(object sender, EventArgs e)
        {
            lueInvoicePrinterTray.Properties.DataSource = UIUtilities.GetPrinterTrays(lueInvoicePrinter.Text);
        }

        private void lueVoucherPrinter_EditValueChanged(object sender, EventArgs e)
        {
            lueVoucherPrinterTray.Properties.DataSource = UIUtilities.GetPrinterTrays(lueVoucherPrinter.Text);
        }

        private void lueNormalPrinter_EditValueChanged(object sender, EventArgs e)
        {
            lueNormalPrinterTray.Properties.DataSource = UIUtilities.GetPrinterTrays(lueNormalPrinter.Text);
        }

        private void sbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}