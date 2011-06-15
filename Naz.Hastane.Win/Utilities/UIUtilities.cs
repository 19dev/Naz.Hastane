using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Reports;
using Naz.Hastane.Reports.Classes;
using Naz.Utilities.Classes;
using NHibernate;
using Nini.Config;
using System.IO;
using System.Windows.Forms;

namespace Naz.Hastane.Win
{
    public static class UIUtilities
    {
        public static User CurrentUser = null;
        
        public static string CurrentPrinter = null;
        public static string CurrentPrinterTray = null;

        //public static void BindLookUpEdit(LookUpEdit lue, Object dataSourceList,
        //    string displayMember = "Value", string valueMember = "ID")
        //{
        //    lue.Properties.DisplayMember = displayMember;
        //    lue.Properties.ValueMember = valueMember;
        //    lue.Properties.DataSource = dataSourceList;
        //}
        public static void BindLookUpEdit<T>(LookUpEdit lue, IList<T> dataSourceList,
            string displayMember = "Value", string valueMember = "Code") where T : new()
        {
            lue.Properties.Columns.Clear();
            lue.Properties.DisplayMember = displayMember;
            lue.Properties.ValueMember = valueMember;
            lue.Properties.Columns.Add(new LookUpColumnInfo("Code", 10, "Kod"));
            lue.Properties.Columns.Add(new LookUpColumnInfo("Value", 30, typeof(T).GetDescription()));
            lue.Properties.DataSource = dataSourceList;
            //if (dataSourceList.Count > 0)
            //    lue.ItemIndex = 0;
        }
        
        public static void BindLookUpEditAllColumns<T>(LookUpEdit lue, IList<T> dataSourceList) where T : new()
        {
            lue.Properties.Columns.Clear();
            lue.Properties.DisplayMember = "Value";
            lue.Properties.ValueMember = "Code";

            foreach (var md in ReflectionUtilities.MemberDescriptions<T>())
            {
                lue.Properties.Columns.Add(new LookUpColumnInfo(md.Key, md.Value));
            }
            lue.Properties.DataSource = dataSourceList;
        }

        public static void BindGrid<T>(GridView view, IList<T> dataSourceList) where T : new()
        {
            view.Columns.Clear();

            foreach (var md in ReflectionUtilities.MemberDescriptions<T>())
            {
                GridColumn column = view.Columns.AddField(md.Key);
                column.Caption = md.Value;
                column.Visible = true;
            }
            view.GridControl.DataSource = dataSourceList;
        }

        private static IConfigSource _Configuration = null;
        public static IConfigSource ConfigurationSource
        {
            get
            {
                if (_Configuration == null)
                {
                    //string appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SurpMed");
                    //if (!Directory.Exists(appPath))
                    //{
                    //    Directory.CreateDirectory(appPath);
                    //    StreamWriter SW;
                    //    SW = File.CreateText(appPath + "\\Naz.Hastane.ini");
                    //    SW.WriteLine("[Database]");
                    //    SW.WriteLine();
                    //    SW.WriteLine("[Printer]");
                    //    SW.WriteLine();

                    //    SW.Close();
                    //}
                    string appPath = Application.StartupPath;
                    appPath = Path.Combine(appPath, "Naz.Hastane.ini");
                    _Configuration = new IniConfigSource(appPath);
                    
                }
                return _Configuration;
            }
        }

        public static void SetPrintTray(PrintDocument doc, string printerName, string trayName)
        {
            if (IsPrinterExist(printerName))
            {
                doc.PrinterSettings.PrinterName = printerName;
                foreach(PaperSource ps in doc.PrinterSettings.PaperSources)
                {
                    if (ps.SourceName == trayName)
                    {
                        doc.DefaultPageSettings.PaperSource = ps;
                        break;
                    }
                }
            }
        }

        public static bool IsPrinterExist(string printerName)
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
                if (printer == printerName)
                    return true;
            return false;
        }

        public static List<string> GetPrinters()
        {
            List<string> printers = new List<string>();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                printers.Add(printer);
            }
            return printers;
        }

        public static List<string> GetPrinterTrays(string printerName)
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

        public static void PrintInvoice(ISession session, Patient patient, IList<PatientVisitDetail> pvds,
            string paymentType, string POSType,
            double productTotal, double VATTotal, double invoiceTotal, double discountTotal, double VATPercent,
            double cashPayment, double advancePaymentUsed, string tellerInvoiceNo, bool directPrint)
        {
            if (pvds.Count == 0)
                return;

            try
            {
                PatientVisit pv = pvds[0].PatientVisit;

                PatientServices.AddNewInvoice(session, UIUtilities.CurrentUser, patient, pvds,
                    paymentType, POSType,
                    productTotal, VATTotal, invoiceTotal, discountTotal, VATPercent,
                    cashPayment, advancePaymentUsed, tellerInvoiceNo);

                InvoiceSGK rpt = new InvoiceSGK();
                rpt.prmAddress.Value = patient.HomeInvoiceAddress;
                rpt.prmDate.Value = DateTime.Now;
                rpt.prmDoctor.Value = pv.Doctor.Value;
                rpt.prmInvoiceNo.Value = tellerInvoiceNo;
                rpt.prmPatientNo.Value = patient.PatientNo;
                rpt.prmPatientPrice.Value = productTotal;
                rpt.prmPatientTotal.Value = productTotal;
                rpt.prmQueueNo.Value = pv.QueueNo;
                rpt.prmServiceNo.Value = pv.Servis;
                rpt.prmTaxOffice.Value = "";
                rpt.prmTCID.Value = patient.TCId;
                rpt.prmTime.Value = DateTime.Now;
                rpt.prmTotal.Value = invoiceTotal;
                rpt.prmTotalText.Value = Helpers.GetMoneyToTrString(invoiceTotal.ToString());
                rpt.prmVAT.Value = VATPercent;
                rpt.prmVATValue.Value = VATTotal;

                CurrentPrinter = ConfigurationSource.Configs["Printer"].Get("InvoicePrinter", "");
                CurrentPrinterTray = ConfigurationSource.Configs["Printer"].Get("InvoicePrinterTray", "");

                PrintReport(rpt, directPrint);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Fatura Yazma Hatası: " + e.Message);
            }
        }
        public static void PrintVoucher(ISession session, Patient patient, IList<PatientVisitDetail> pvds,
            string paymentType, string POSType,
            double paymentTotal, string tellerVoucherNo, bool directPrint)
        {
            if (pvds.Count == 0)
                return;

            try
            {
                PatientServices.AddNewVoucher(session, UIUtilities.CurrentUser, pvds,
                    paymentType, POSType,
                    paymentTotal,
                    tellerVoucherNo
                    );

                VoucherSGK rpt = new VoucherSGK();
                rpt.prmDate.Value = DateTime.Now;
                rpt.prmPatientName.Value = patient.FullName;
                rpt.prmPatientNo.Value = patient.PatientNo;
                rpt.prmTCID.Value = patient.TCId;
                rpt.prmTime.Value = DateTime.Now;
                rpt.prmTotal.Value = paymentTotal;
                rpt.prmTotalText.Value = Helpers.GetMoneyToTrString(paymentTotal.ToString());
                rpt.prmUserID.Value = UIUtilities.CurrentUser.USER_ID;
                rpt.prmVoucherNo.Value = tellerVoucherNo;

                CurrentPrinter = ConfigurationSource.Configs["Printer"].Get("VoucherPrinter", "");
                CurrentPrinterTray = ConfigurationSource.Configs["Printer"].Get("VoucherPrinterTray", "");
                PrintReport(rpt, directPrint);

            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Makbuz Yazma Hatası: " + e.Message);
            }
        }

        public static void PrintTaahhutname(Patient patient, bool directPrint)
        {
            SGKTaahhutnameReport rpt = new SGKTaahhutnameReport();

            rpt.prmHomeAddress.Value = patient.HomeAddress;
            rpt.prmHomeCity.Value = patient.HomeCity;
            rpt.prmHomeDistrict.Value = patient.HomeDistrict;
            rpt.prmHomeTown.Value = patient.HomeTown;
            rpt.prmPatientName.Value = patient.FullName;
            rpt.prmPatientNo.Value = patient.PatientNo;
            rpt.prmPhone1.Value = patient.HomePhone1;
            rpt.prmPhone2.Value = patient.HomePhone2;
            rpt.prmPrintDate.Value = DateTime.Today;
            rpt.prmTCID.Value = patient.TCId;

            CurrentPrinter = ConfigurationSource.Configs["Printer"].Get("NormalPrinter", "");
            CurrentPrinterTray = ConfigurationSource.Configs["Printer"].Get("NormalPrinterTray", "");
            PrintReport(rpt, directPrint);
        }

        public static void PrintReport(XtraReport rpt, bool directPrint)
        {
            if (directPrint)
            {
                rpt.PrintingSystem.StartPrint += new PrintDocumentEventHandler(printingSystem_StartPrint);
                rpt.Print();

            }
            else
            {
                rpt.ShowPreview();
            }
        }

        private static void printingSystem_StartPrint(object sender, PrintDocumentEventArgs e)
        {
            UIUtilities.SetPrintTray(e.PrintDocument, CurrentPrinter,  CurrentPrinterTray);
        }

    }
}
