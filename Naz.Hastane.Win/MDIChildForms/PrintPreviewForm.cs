using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Printing;

namespace Naz.Hastane.Win.MDIChildForms
{
    public partial class PrintPreviewForm : MDIChildForm
    {
        public PrintPreviewForm()
        {
            InitializeComponent();
        }

        public void ShowReport<T>() where T : DevExpress.XtraReports.UI.XtraReport, new()
        {
            T report = new T();
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }

        public void ShowReport<T>(object dataSource) where T : DevExpress.XtraReports.UI.XtraReport, new()
        {
            T report = new T();
            printControl.PrintingSystem = report.PrintingSystem;
            report.DataSource = dataSource;
            report.CreateDocument();
        }

        private void printingSystem_StartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
        {
            //e.PrintDocument.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters[0];
            //for (int i = 0; i < e.PrintDocument.PrinterSettings.PaperSources.Count; i++)
            //    if (e.PrintDocument.PrinterSettings.PaperSources[i].Kind ==
            //        PaperSourceKind.TractorFeed)
            //    {
            //        e.PrintDocument.DefaultPageSettings.PaperSource =
            //            e.PrintDocument.PrinterSettings.PaperSources[i];
            //        break;
            //    }

        }


    }
}