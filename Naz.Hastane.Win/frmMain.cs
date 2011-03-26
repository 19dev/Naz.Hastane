using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Naz.Hastane.Data.Entities;
using Naz.Hastane.Data.Entities.LookUp.General;
using Naz.Hastane.Data.Entities.LookUp.MedulaDiabet;
using Naz.Hastane.Data.Entities.LookUp.MedulaProvision;
using Naz.Hastane.Data.Entities.LookUp.Special;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Reports;
using Naz.Hastane.Win.MDIChildForms;
using Naz.Utilities.Classes;
using Naz.Hastane.Data.Entities.LookUp.MedulaReport;

namespace Naz.Hastane.Win {
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm {
        
        const int kSplashUpdateInterval_ms = 200;
        const int kMinAmountOfSplashTime_ms = 8000;

        /// <summary>
        /// Instance of the splash form.
        /// </summary>
        private SplashForm splash = null;

        /// <summary>
        /// Starts the splash screen on a separate thread
        /// </summary>
        public void StartSplash()
        {
            // Instance a splash form given the image names
            splash = new SplashForm(kSplashUpdateInterval_ms);

            // Run the form
            Application.Run(splash);
        }

        /// <summary>
        /// Shuts down and cleans up the splash screen
        /// </summary>
        private void CloseSplash()
        {
            if (splash == null)
                return;

            // Shut down the splash screen
            splash.Invoke(new EventHandler(splash.KillMe));
            splash.Dispose();
            splash = null;
        }

        public frmMain()
        {
            InitializeComponent();
            CreateColorPopup(popupControlContainer1);
            InitSkinGallery();
            InitFontGallery();
            InitColorGallery();
            InitEditors();
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            this.Text = "SurpMed v. " + Application.ProductVersion;
        }

        private void TestUsers()
        {
            Encrypter en = new Encrypter();
            var users = LookUpServices.Users;

            foreach (User user in users)
            {
                if (user.USER_PASS.Length == 1)
                {
                    en.CodeWord = user.USER_ID;
                    string s = en.Encrypt("1");
                    if (s != user.USER_PASS)
                    {
                        MessageBox.Show(user.USER_ID + " Hatalý Password!");
                    }
                }
            }
        }

        /// <summary>
        /// The form is ready so do our application specific loading and
        /// initialization
        /// </summary>
        /// <param name="sender">Sender of the event</param>
        /// <param name="e">Event arguments</param>
        private void frmMain_Load(object sender, System.EventArgs e)
        {
            //TestUsers();
            // Create a new thread from which to start the splash screen form
            Thread splashThread = new Thread(new ThreadStart(StartSplash));
            splashThread.Start();

            arMRUList = new MRUArrayList(pcAppMenuFileLabels, imageCollection3.Images[0], imageCollection3.Images[1]);
            arMRUList.LabelClicked += new EventHandler(OnLabelClicked);
            InitMostRecentFiles(arMRUList);
            rcMain.ForceInitialize();
            GalleryDropDown skins = new GalleryDropDown();
            skins.Ribbon = rcMain;
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins);
            iPaintStyle.DropDownControl = skins;
            CreateHastaAraSGKForm();
            this.rcMain.SelectedPage = rbPatient;

            // Force the loading of the database
            var doctors = LookUpServices.Doctors;

            // Close the splash screen
            CloseSplash();
        }

        int documentIndex = 0;
        ColorPopup cp;
        //frmFind dlgFind = null;
        //frmReplace dlgReplace = null;
        GalleryItem fCurrentFontItem, fCurrentColorItem;
        string DocumentName { get { return string.Format("New Document {0}", documentIndex); } }

        void InitEditors() {
            riicStyle.Items.Add(new ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1));
            biStyle.EditValue = rcMain.RibbonStyle;
        }
        public void ShowHideFormatCategory() {
            RibbonPageCategory selectionCategory = Ribbon.PageCategories[0] as RibbonPageCategory;
            if(selectionCategory == null) return;
            //if(CurrentRichTextBox == null)
            //    selectionCategory.Visible = false;
            //else
            //    selectionCategory.Visible = CurrentRichTextBox.SelectionLength != 0;
            if(selectionCategory.Visible) Ribbon.SelectedPage = selectionCategory.Pages[0];
        }
 
        void CreateNewDocument(string fileName) {
            ShowNewDocument<MDIChildForm>();
        }

        public void CreateHastaAraForm()
        {
            ShowNewDocument<HastaAraForm>();
        }
        public void CreateHastaAraSGKForm()
        {
            ShowNewDocument<HastaAraSGKForm>();
        }

        public void ShowNewDocument(MDIChildForm newForm)
        {
            documentIndex++;
            newForm.MdiParent = this;
            newForm.Closed += new EventHandler(Pad_Closed);
            newForm.ShowPopupMenu += new EventHandler(Pad_ShowPopupMenu);
            newForm.Show();
        }

        public void ShowNewDocument<T>() where T:MDIChildForm, new()
        {
            T newForm = new T();
            documentIndex++;
            newForm.MdiParent = this;
            newForm.Closed += new EventHandler(Pad_Closed);
            newForm.ShowPopupMenu += new EventHandler(Pad_ShowPopupMenu);
            newForm.Show();
        }

        void Pad_Closed(object sender, EventArgs e)
        {
            CloseFind();
        }
        void Pad_ShowPopupMenu(object sender, EventArgs e) {
            pmMain.ShowPopup(Control.MousePosition);
        }
        void CloseFind() {
        }

        private void CreateColorPopup(PopupControlContainer container) {
            cp = new ColorPopup(container, iFontColor, this);
        }
        #region Init
        public void UpdateText() {
            rcMain.ApplicationCaption = "SurpMed V" + Application.ProductVersion;
            //ribbonControl1.ApplicationDocumentCaption = CurrentDocName + (CurrentModified ? "*" : "");
            //Text = string.Format("Ribbon Simple Pad ({0})", CurrentDocName);
            //siDocName.Caption = string.Format("  {0}", CurrentDocName);
        }
        private void xtraTabbedMdiManager1_FloatMDIChildActivated(object sender, EventArgs e) {
            //ChangeActiveForm();
        }
        private void xtraTabbedMdiManager1_FloatMDIChildDeactivated(object sender, EventArgs e) {
            //BeginInvoke(new MethodInvoker(ChangeActiveForm));
        }
        private void frmMain_MdiChildActivate(object sender, System.EventArgs e) {
            //ChangeActiveForm();
        }

        protected void InitFormat() {
            //iBold.Enabled = SelectFont != null;
            //iItalic.Enabled = SelectFont != null;
            //iUnderline.Enabled = SelectFont != null;
            //iFont.Enabled = SelectFont != null;
            //iFontColor.Enabled = SelectFont != null;
            //if(SelectFont != null) {
            //    iBold.Down = SelectFont.Bold;
            //    iItalic.Down = SelectFont.Italic;
            //    iUnderline.Down = SelectFont.Underline;
            //}
        }

        void ClearFormats() {
            iBold.Down = false;
            iItalic.Down = false;
            iUnderline.Down = false;
            iProtected.Down = false;
            iBullets.Down = false;
            iAlignLeft.Down = false;
            iAlignRight.Down = false;
            iCenter.Down = false;
        }

        #endregion
        #region Properties
        MDIChildForm CurrentForm {
            get {
                if(this.ActiveMdiChild == null) return null;
                if(xtraTabbedMdiManager1.ActiveFloatForm != null)
                    return xtraTabbedMdiManager1.ActiveFloatForm as MDIChildForm;
                return this.ActiveMdiChild as MDIChildForm;
            }
        }

        #endregion
        #region File

        void iKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(CurrentForm != null) CurrentForm.Close();
        }

        public void OpenHasta(string hastaID)
        {
            Patient patient = PatientServices.GetByNo(hastaID);
            if (patient != null)
            {
                HastaIslemleriForm newForm = new HastaIslemleriForm(patient);
                string name = patient.FirstName + " " + patient.LastName;
                newForm.Text = name;
                ShowNewDocument(newForm);
                AddToMostRecentFiles(name, arMRUList);
            }
        }

        public void OpenHastaSGK(string hastaID)
        {
            Patient patient = PatientServices.GetByNo(hastaID);
            if (patient != null)
            {
                HastaIslemleriSGKForm newForm = new HastaIslemleriSGKForm(patient);
                string name = patient.FirstName + " " + patient.LastName;
                newForm.Text = name;
                ShowNewDocument(newForm);
                AddToMostRecentFiles(name, arMRUList);
            }
        }

        public void OpenNewHasta()
        {
            Patient patient = PatientServices.GetNewPatient();
            string name = "Yeni Hasta";
            HastaIslemleriForm newForm = new HastaIslemleriForm(patient);
            newForm.Text = name;
            ShowNewDocument(newForm);
        }

        public void OpenNewHastaSGK()
        {
            Patient patient = PatientServices.GetNewSGKPatient();
            string name = "Yeni SGK Hastasý";
            HastaIslemleriSGKForm newForm = new HastaIslemleriSGKForm(patient);
            newForm.Text = name;
            ShowNewDocument(newForm);
        }

        private void iPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //XtraMessageBox.Show(this, "Yazýcý Ýþlemleri", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            VoucherSGK rpt = new VoucherSGK();
            rpt.prmDate.Value = DateTime.Now;
            rpt.prmPatientName.Value = "AYDIN SAKAR";
            rpt.prmPatientNo.Value = "882301";
            rpt.prmTCID.Value = "38872435224";
            rpt.prmTime.Value = DateTime.Now;
            rpt.prmTotal.Value = 12;
            rpt.prmTotalText.Value = "OnÝki TürkLirasý Sýfýr Kuruþ";
            rpt.prmUserID.Value = "AYDIN";
            rpt.prmVoucherNo.Value = "123456";
            
            rpt.ShowPreview();


            //ReportPrintTool pt = new ReportPrintTool(rpt);
            //pt.AutoShowParametersPanel = true;
            //pt.ShowPreviewDialog();

            //InvoiceSGK rpt = new InvoiceSGK();
            //rpt.ShowPreview();

            //rptIL rpt = new rptIL();
            //rpt.ShowPreview();
        }

        //        private void button1_Click(object sender, EventArgs e) {
        //    ReportPrintTool pt = new ReportPrintTool(new XtraReport1());
        //    pt.PrintingSystem.StartPrint += 
        //        new PrintDocumentEventHandler(printingSystem_StartPrint);
        //    pt.PrintDialog();
        //}

        //        private void printingSystem_StartPrint(object sender, PrintDocumentEventArgs e) {
        //            for (int i = 0; i < e.PrintDocument.PrinterSettings.PaperSources.Count; i++)
        //                if (e.PrintDocument.PrinterSettings.PaperSources[i].Kind == 
        //                    PaperSourceKind.TractorFeed) {
        //                    e.PrintDocument.DefaultPageSettings.PaperSource = 
        //                        e.PrintDocument.PrinterSettings.PaperSources[i];
        //                    break;
        //                }

        //            for (int i = 0; i < e.PrintDocument.PrinterSettings.PrinterResolutions.Count; i++)
        //                if (e.PrintDocument.PrinterSettings.PrinterResolutions[i].Kind == 
        //                    PrinterResolutionKind.High) {
        //                    e.PrintDocument.DefaultPageSettings.PrinterResolution = 
        //                        e.PrintDocument.PrinterSettings.PrinterResolutions[i];
        //                    break;
        //                }
        //        }
        void iSakla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }

        void Save() {
            if(CurrentForm == null) return;
            //SetModifiedCaption();
        }
        private void iCik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Close();
        }
        private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
        }
        #endregion
        #region Format
        private FontStyle rtPadFontStyle() {
            FontStyle fs = new FontStyle();
            if(iBold.Down) fs |= FontStyle.Bold;
            if(iItalic.Down) fs |= FontStyle.Italic;
            if(iUnderline.Down) fs |= FontStyle.Underline;
            return fs;
        }

        private void iBullets_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //CurrentRichTextBox.SelectionBullet = iBullets.Down;
            //InitUndo();
        }

        private void iFontStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //CurrentRichTextBox.SelectionFont = new Font(SelectFont, rtPadFontStyle());
        }

        private void iProtected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //CurrentRichTextBox.SelectionProtected = iProtected.Down;
        }

        private void iAlign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //if(iAlignLeft.Down)
            //    CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
            //if(iCenter.Down)
            //    CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            //if(iAlignRight.Down)
            //    CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Right;
            //InitUndo();
        }


        protected Font SelectFont {
            get
            {
                //if (CurrentRichTextBox != null)
                //    return CurrentRichTextBox.SelectionFont;
                return null;
            }
        }
        void ShowFontDialog() {
            //if(CurrentRichTextBox == null) return;
            //Font dialogFont = null;
            //if(SelectFont != null)
            //    dialogFont = (Font)SelectFont.Clone();
            //else dialogFont = CurrentRichTextBox.Font;
            //XtraFontDialog dlg = new XtraFontDialog(dialogFont);
            //if(dlg.ShowDialog() == DialogResult.OK) {
            //    CurrentRichTextBox.SelectionFont = dlg.ResultFont;
            //    beiFontSize.EditValue = dlg.ResultFont.Size;
            //}
        }
        private void iFont_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ShowFontDialog();
        }
        private void iFontColor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //CurrentRichTextBox.SelectionColor = cp.ResultColor;
        }
        #endregion
        #region Edit
        private void iUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //CurrentRichTextBox.Undo();
            //CurrentForm.Modified = CurrentRichTextBox.CanUndo;
            //SetModifiedCaption();
            //InitUndo();
            //InitFormat();
        }

        private void iCut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //CurrentRichTextBox.Cut();
            //InitPaste();
        }

        private void iCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //CurrentRichTextBox.Copy();
            //InitPaste();
        }

        private void iPaste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //CurrentRichTextBox.Paste();
        }

        private void iClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //CurrentRichTextBox.SelectedRtf = "";
        }

        private void iSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //CurrentRichTextBox.SelectAll();
        }
        private void ribbonPageGroup2_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e) {
            pmMain.ShowPopup(rcMain.Manager, MousePosition);
        }
        #endregion
        #region SkinGallery
        void InitSkinGallery() {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        #endregion
        #region FontGallery
        Image GetFontImage(int width, int height, string fontName, int fontSize) {
            Rectangle rect = new Rectangle(0, 0, width, height);
            Image fontImage = new Bitmap(width, height);
            try {
                using(Font fontSample = new Font(fontName, fontSize)) {
                    Graphics g = Graphics.FromImage(fontImage);
                    g.FillRectangle(Brushes.White, rect);
                    using(StringFormat fs = new StringFormat()) {
                        fs.Alignment = StringAlignment.Center;
                        fs.LineAlignment = StringAlignment.Center;
                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        g.DrawString("Aa", fontSample, Brushes.Black, rect, fs);
                        g.Dispose();
                    }
                }
            }
            catch { }
            return fontImage;
        }
        void InitFont(GalleryItemGroup groupDropDown, GalleryItemGroup galleryGroup) {
            FontFamily[] fonts = FontFamily.Families;
            for(int i = 0; i < fonts.Length; i++) {
                if(!FontFamily.Families[i].IsStyleAvailable(FontStyle.Regular)) continue;
                string fontName = fonts[i].Name;
                GalleryItem item = new GalleryItem();
                item.Caption = fontName;
                item.Image = GetFontImage(32, 28, fontName, 12);
                item.HoverImage = item.Image;
                item.Description = fontName;
                item.Hint = fontName;
                try {
                    item.Tag = new Font(fontName, 9);
                    if(DevExpress.Utils.ControlUtils.IsSymbolFont((Font)item.Tag)) {
                        item.Tag = new Font(DevExpress.Utils.AppearanceObject.DefaultFont.FontFamily, 9);
                        item.Description += " (Symbol Font)";
                    }
                }
                catch {
                    continue;
                }
                groupDropDown.Items.Add(item);
                galleryGroup.Items.Add(item);
            }
        }
        void InitFontGallery() {
            InitFont(gddFont.Gallery.Groups[0], rgbiFont.Gallery.Groups[0]);
            beiFontSize.EditValue = 8;
        }
        void SetFont(string fontName, GalleryItem item) {
            //if(CurrentRichTextBox == null) return;
            //CurrentRichTextBox.SelectionFont = new Font(fontName, Convert.ToInt32(beiFontSize.EditValue), rtPadFontStyle());
            //if(item != null) CurrentFontItem = item;
        }
        private void gddFont_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            SetFont(e.Item.Caption, e.Item);
        }
        private void rpgFont_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e) {
            ShowFontDialog();
        }
        private void rgbiFont_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            SetFont(e.Item.Caption, e.Item);
        }
        private void gddFont_Gallery_CustomDrawItemText(object sender, GalleryItemCustomDrawEventArgs e) {
            DevExpress.XtraBars.Ribbon.ViewInfo.GalleryItemViewInfo itemInfo = e.ItemInfo as DevExpress.XtraBars.Ribbon.ViewInfo.GalleryItemViewInfo;
            itemInfo.PaintAppearance.ItemDescription.DrawString(e.Cache, e.Item.Description, itemInfo.DescriptionBounds);
            AppearanceObject app = itemInfo.PaintAppearance.ItemCaption.Clone() as AppearanceObject;
            app.Font = (Font)e.Item.Tag;
            try {
                e.Cache.Graphics.DrawString(e.Item.Caption, app.Font, app.GetForeBrush(e.Cache), itemInfo.CaptionBounds);
            }
            catch { }
            e.Handled = true;
        }
        #endregion
        #region ColorGallery
        void InitColorGallery() {
            gddFontColor.BeginUpdate();
            foreach(Color color in DevExpress.XtraEditors.Popup.ColorListBoxViewInfo.WebColors) {
                if(color == Color.Transparent) continue;
                GalleryItem item = new GalleryItem();
                item.Caption = color.Name;
                item.Tag = color;
                item.Hint = color.Name;
                gddFontColor.Gallery.Groups[0].Items.Add(item);
                rgbiFontColor.Gallery.Groups[0].Items.Add(item);
            }
            foreach(Color color in DevExpress.XtraEditors.Popup.ColorListBoxViewInfo.SystemColors) {
                GalleryItem item = new GalleryItem();
                item.Caption = color.Name;
                item.Tag = color;
                gddFontColor.Gallery.Groups[1].Items.Add(item);
            }
            gddFontColor.EndUpdate();
        }
        private void gddFontColor_Gallery_CustomDrawItemImage(object sender, GalleryItemCustomDrawEventArgs e) {
            Color clr = (Color)e.Item.Tag;
            using(Brush brush = new SolidBrush(clr)) {
                e.Cache.FillRectangle(brush, e.Bounds);
                e.Handled = true;
            }
        }
        void SetResultColor(Color color, GalleryItem item) {
            //if(CurrentRichTextBox == null) return;
            //cp.ResultColor = color;
            //CurrentRichTextBox.SelectionColor = cp.ResultColor;
            //if(item != null) CurrentColorItem = item;
        }
        private void gddFontColor_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            SetResultColor((Color)e.Item.Tag, e.Item);
        }
        private void rpgFontColor_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e) {
            //if(CurrentRichTextBox == null) return;
            //if(cp == null)
            //    CreateColorPopup(popupControlContainer1);
            //popupControlContainer1.ShowPopup(ribbonControl1.Manager, MousePosition);
        }

        private void rgbiFontColor_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            SetResultColor((Color)e.Item.Tag, e.Item);
        }
        #endregion

        private void iAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //foreach (frmPad frm in this.OwnedForms)
            //{
            //    if frm is frmHastaAra
            //    {
            //        frm.Focus();
            //        return;
            //    }
            //}
            CreateHastaAraForm();
        }

        private void iHakkinda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DevExpress.Utils.About.frmAbout dlg = new DevExpress.Utils.About.frmAbout("SurpMed v." + Application.ProductVersion);
            dlg.ShowDialog();
        }

        string TextByCaption(string caption) {
            return caption.Replace("&", "");
        }

        #region GalleryItemsChecked

        GalleryItem GetColorItemByColor(Color color, BaseGallery gallery) {
            foreach(GalleryItemGroup galleryGroup in gallery.Groups)
                foreach(GalleryItem item in galleryGroup.Items)
                    if(item.Caption == color.Name)
                        return item;
            return null;
        }
        GalleryItem GetFontItemByFont(string fontName, BaseGallery gallery) {
            foreach(GalleryItemGroup galleryGroup in gallery.Groups)
                foreach(GalleryItem item in galleryGroup.Items)
                    if(item.Caption == fontName)
                        return item;
            return null;
        }
        GalleryItem CurrentFontItem {
            get { return fCurrentFontItem; }
            set {
                if(fCurrentFontItem == value) return;
                if(fCurrentFontItem != null) fCurrentFontItem.Checked = false;
                fCurrentFontItem = value;
                if(fCurrentFontItem != null) {
                    fCurrentFontItem.Checked = true;
                    MakeFontVisible(fCurrentFontItem);
                }
            }
        }
        void MakeFontVisible(GalleryItem item) {
            gddFont.Gallery.MakeVisible(fCurrentFontItem);
            rgbiFont.Gallery.MakeVisible(fCurrentFontItem);
        }
        GalleryItem CurrentColorItem {
            get { return fCurrentColorItem; }
            set {
                if(fCurrentColorItem == value) return;
                if(fCurrentColorItem != null) fCurrentColorItem.Checked = false;
                fCurrentColorItem = value;
                if(fCurrentColorItem != null) {
                    fCurrentColorItem.Checked = true;
                    MakeColorVisible(fCurrentColorItem);
                }
            }
        }
        void MakeColorVisible(GalleryItem item) {
            gddFontColor.Gallery.MakeVisible(fCurrentColorItem);
            rgbiFontColor.Gallery.MakeVisible(fCurrentColorItem);
        }
        void CurrentFontChanged() {
            //if(CurrentRichTextBox == null || CurrentRichTextBox.SelectionFont == null) return;
            //CurrentFontItem = GetFontItemByFont(CurrentRichTextBox.SelectionFont.Name, rgbiFont.Gallery);
            //CurrentColorItem = GetColorItemByColor(CurrentRichTextBox.SelectionColor, rgbiFontColor.Gallery);
        }
        private void gddFont_Popup(object sender, System.EventArgs e) {
            MakeFontVisible(CurrentFontItem);
        }

        private void gddFontColor_Popup(object sender, System.EventArgs e) {
            MakeColorVisible(CurrentColorItem);
        }
        #endregion
        #region MostRecentFiles
        MRUArrayList arMRUList = null;
        string mrfFileName = "RibbonMRUFiles.ini";
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            // Make sure the splash screen is closed
            //CloseSplash();

            //SaveMostRecentFiles(arMRUList);
        }
        void InitMostRecentFiles(MRUArrayList arList) {
            string fileName = Application.StartupPath + "\\" + mrfFileName;
            if(!System.IO.File.Exists(fileName)) {
                AddToMostRecentFiles("Document1.rtf", arList);
                return;
            }
            System.IO.StreamReader sr = System.IO.File.OpenText(fileName);
            for(string s = sr.ReadLine(); s != null; s = sr.ReadLine())
                AddToMostRecentFiles(s, arList);
            sr.Close();
        }

        void SaveMostRecentFiles(MRUArrayList arList) {
            try {
                System.IO.StreamWriter sw = System.IO.File.CreateText(Application.StartupPath + "\\" + mrfFileName);
                for(int i = arList.Count - 1; i >= 0; i--) sw.WriteLine(string.Format("{0},{1}", arList[i].ToString(), arList.GetLabelChecked(arList[i].ToString())));
                sw.Close();
            }
            catch { }
        }

        void AddToMostRecentFiles(string name, MRUArrayList arList) {
            arList.InsertElement(name);
        }
        void OnLabelClicked(object sender, EventArgs e) {
            //pmAppMain.HidePopup();
            //this.Refresh();
            //OpenFile(sender.ToString());
        }
        class MRUArrayList : ArrayList {
            PanelControl container;
            int maxRecentFiles = 9;
            Image imgChecked, imgUncheked;
            public event EventHandler LabelClicked;
            public MRUArrayList(PanelControl cont, Image iChecked, Image iUnchecked)
                : base() {
                this.imgChecked = iChecked;
                this.imgUncheked = iUnchecked;
                this.container = cont;
            }
            public void InsertElement(object value) {
                string[] names = value.ToString().Split(',');
                string name = names[0];
                bool checkedLabel = false;
                if(names.Length > 1) checkedLabel = names[1].ToLower().Equals("true");
                foreach(AppMenuFileLabel ml in container.Controls) {
                    if(ml.Tag.Equals(name)) {
                        checkedLabel = ml.Checked;
                        base.Remove(name);
                        ml.LabelClick -= new EventHandler(OnLabelClick);
                        ml.Dispose();
                        break;
                    }
                }
                bool access = true;
                if(base.Count >= maxRecentFiles)
                    access = RemoveLastElement();
                if(access) {
                    base.Insert(0, name);
                    AppMenuFileLabel ml = new AppMenuFileLabel();
                    container.Controls.Add(ml);
                    ml.Tag = name;
                    ml.Text = GetFileName(name);
                    ml.Checked = checkedLabel;
                    ml.AutoHeight = true;
                    ml.Dock = DockStyle.Top;
                    ml.Image = imgUncheked;
                    ml.SelectedImage = imgChecked;
                    ml.LabelClick += new EventHandler(OnLabelClick);
                    SetElementsRange();
                }
            }
            void OnLabelClick(object sender, EventArgs e) {
                if(LabelClicked != null)
                    LabelClicked(((AppMenuFileLabel)sender).Tag.ToString(), e);
            }
            public bool RemoveLastElement() {
                for(int i = 0; i < container.Controls.Count; i++) {
                    AppMenuFileLabel ml = container.Controls[i] as AppMenuFileLabel;
                    if(!ml.Checked) {
                        base.Remove(ml.Tag);
                        ml.LabelClick -= new EventHandler(OnLabelClick);
                        ml.Dispose();
                        return true;
                    }
                }
                return false;
            }
            string GetFileName(object obj) {
                FileInfo fi = new FileInfo(obj.ToString());
                return fi.Name;
            }
            void SetElementsRange() {
                int i = 0;
                foreach(AppMenuFileLabel ml in container.Controls) {
                    ml.Caption = string.Format("&{0}", container.Controls.Count - i);
                    i++;
                }
            }
            public bool GetLabelChecked(string name) {
                foreach(AppMenuFileLabel ml in container.Controls) {
                    if(ml.Tag.Equals(name)) return ml.Checked;
                }
                return false;
            }
        }
        #endregion

        private void ribbonControl1_ApplicationButtonDoubleClick(object sender, EventArgs e) {
            if(rcMain.RibbonStyle == RibbonControlStyle.Office2007)
                this.Close();
        }

        private void barEditItem1_ItemPress(object sender, ItemClickEventArgs e) {
            System.Diagnostics.Process.Start("http://www.devexpress.com");
        }

        private void biStyle_EditValueChanged(object sender, EventArgs e) {
            rcMain.RibbonStyle = (RibbonControlStyle)biStyle.EditValue;
        }

        private void sbExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void iHastaAra_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHastaAraForm();
        }

        private void iSGKHastaAra_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateHastaAraSGKForm();
        }

        private void iYeniSGKHastasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenNewHastaSGK();
        }

        private void iYeniHasta_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenNewHasta();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ShowNewLookUpForm<T>(IList<T> lookUpTable, string caption) where T : new()
        {
            LookUpForm<T> newForm = new LookUpForm<T>(lookUpTable);
            newForm.Text = caption;
            ShowNewDocument(newForm);

        }

        #region MDIChildForms
        private void iPrinterSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewDocument<PrinterSettingsForm>();
        }
        private void iAccDailyReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewDocument<AccountingDailySummaryForm>();
        }
        private void iSGKInvoiceVoucher_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewDocument<SGKInvoiveVoucherForm>();
        }
        private void iDiabetReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewDocument<DiabetForm>();
        }
        private void iMedulaMedicationReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewDocument<MedulaMedicationReportForm>();
        }
        private void iTreatmentReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewDocument<MedulaMedicationReportForm>();
        }
        private void iDatabaseTest_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewDocument<DBTestForm>();
        }
        private void iProvisionType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<ProvisionType>(LookUpServices.ProvisionTypes, e.Item.Caption);
        }
        #endregion

        #region General Definitions
        private void iBloodType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<BloodType>(LookUpServices.BloodTypes, e.Item.Caption);
        }
        private void iCity_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<City>(LookUpServices.Cities, e.Item.Caption);
        }
        private void iIDType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<IDType>(LookUpServices.IDTypes, e.Item.Caption);
        }
        private void iNationality_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<Nationality>(LookUpServices.Nationalities, e.Item.Caption);
        }
        private void iPatientRelations_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<PatientRelation>(LookUpServices.PatientRelations, e.Item.Caption);
        }
        private void iVAT_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<VAT>(LookUpServices.VATs, e.Item.Caption);
        }
        private void iYesNo_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<YesNo>(LookUpServices.YesNos, e.Item.Caption);
        }
        #endregion

        #region Medula Diabet
        private void iAcuteComplication_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<AcuteComplication>(LookUpServices.AcuteComplications, e.Item.Caption);
        }
        private void iApplicationReason_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<ApplicationReason>(LookUpServices.ApplicationReasons, e.Item.Caption);
        }
        private void iDiseaseCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<DiseaseCode>(LookUpServices.DiseaseCodes, e.Item.Caption);
        }
        private void iEKG_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<EKG>(LookUpServices.EKGs, e.Item.Caption);
        }
        private void iExercise_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<Exercise>(LookUpServices.Exercises, e.Item.Caption);
        }
        private void iEyeExam_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<EyeExam>(LookUpServices.EyeExams, e.Item.Caption);
        }
        private void iFootExam_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<FootExam>(LookUpServices.FootExams, e.Item.Caption);
        }
        private void iHabitCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<HabitCode>(LookUpServices.HabitCodes, e.Item.Caption);
        }
        private void iPositiveNegative_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<PositiveNegative>(LookUpServices.PositiveNegatives, e.Item.Caption);
        }
        private void iResidentialType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<ResidentialType>(LookUpServices.ResidentialTypes, e.Item.Caption);
        }
        private void iTBT_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<TBT>(LookUpServices.TBTs, e.Item.Caption);
        }
        private void iVarYok_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<VarYok>(LookUpServices.VarYoks, e.Item.Caption);
        }
        #endregion

        #region Medula Provizyon
        private void iBranchCodes_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<BranchCode>(LookUpServices.BranchCodes, e.Item.Caption);
        }
        private void iFollowUpType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<FollowUpType>(LookUpServices.FollowUpTypes, e.Item.Caption);
        }
        private void iInsuranceType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<InsuranceType>(LookUpServices.InsuranceTypes, e.Item.Caption);
        }
        private void iTreatmentType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<TreatmentType>(LookUpServices.TreatmentTypes, e.Item.Caption);
        }
        private void iTreatmentStyle_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<TreatmentStyle>(LookUpServices.TreatmentStyles, e.Item.Caption);
        }
        private void iTransferorIns_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<TransferorInstitution>(LookUpServices.TransferorInstitutions, e.Item.Caption);
        }
        private void iRelationType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<RelationType>(LookUpServices.RelationTypes, e.Item.Caption);
        }
        #endregion

        #region Medula Report
        private void iDoctorType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<DoctorType>(LookUpServices.DoctorTypes, e.Item.Caption);
        }
        private void iMedulaReportType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<MedulaReportType>(LookUpServices.MedulaReportTypes, e.Item.Caption);
        }
        private void iEditingType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<EditingType>(LookUpServices.EditingTypes, e.Item.Caption);
        }
        private void iMedulaReportTreatmentType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<MedulaReportTreatmentType>(LookUpServices.MedulaReportTreatmentTypes, e.Item.Caption);
        }
        private void iESWTBodyPart_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<ESWTBodyPart>(LookUpServices.ESWTBodyParts, e.Item.Caption);
        }
        private void iFTRBodyPart_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<FTRBodyPart>(LookUpServices.FTRBodyParts, e.Item.Caption);
        }
        #endregion

        #region Special Definitions
        private void iDepository_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<Depository>(LookUpServices.Depositories, e.Item.Caption);
        }
        private void iDoctor_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<Doctor>(LookUpServices.Doctors, e.Item.Caption);
        }
        private void iFunctionGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<FunctionGroup>(LookUpServices.FunctionGroups, e.Item.Caption);
        }
        private void iFunctionType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<FunctionGroupType>(LookUpServices.FunctionGroupTypes, e.Item.Caption);
        }
        private void iRooms_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<Room>(LookUpServices.Rooms, e.Item.Caption);
        }
        private void iService_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<Service>(LookUpServices.Services, e.Item.Caption);
        }
        private void iSystemSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<SystemSetting>(LookUpServices.SystemSettings, e.Item.Caption);
        }
        private void iUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<User>(LookUpServices.Users, e.Item.Caption);
        }
        private void iWareHouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowNewLookUpForm<Warehouse>(LookUpServices.Warehouses, e.Item.Caption);
        }
        #endregion

    }
}
