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
using Naz.Hastane.Data.Services;
using Naz.Hastane.Reports;
using Naz.Hastane.Reports.Classes;
using Naz.Hastane.Win.Forms;
using Naz.Hastane.Win.MDIChildForms;

namespace Naz.Hastane.Win {
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        #region Splash Screen
        //const int kSplashUpdateInterval_ms = 200;
        //const int kMinAmountOfSplashTime_ms = 8000;

        /// <summary>
        /// Instance of the splash form.
        /// </summary>
        //private SplashForm splash = null;

        /// <summary>
        /// Starts the splash screen on a separate thread
        /// </summary>
        //public void StartSplash()
        //{
        //    // Instance a splash form given the image names
        //    splash = new SplashForm(kSplashUpdateInterval_ms);

        //    // Run the form
        //    Application.Run(splash);
        //}

        /// <summary>
        /// Shuts down and cleans up the splash screen
        /// </summary>
        //private void CloseSplash()
        //{
        //    if (splash == null)
        //        return;

        //    // Shut down the splash screen
        //    splash.Invoke(new EventHandler(splash.KillMe));
        //    splash.Dispose();
        //    splash = null;
        //}
        #endregion

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
            AttachMDIChildButtons();
            AttachLookUpButtons();
            AttachReportCommands();
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
            //Thread splashThread = new Thread(new ThreadStart(StartSplash));
            //splashThread.Start();

            arMRUList = new MRUArrayList(pcAppMenuFileLabels, imageCollection3.Images[0], imageCollection3.Images[1]);
            arMRUList.LabelClicked += new EventHandler(OnLabelClicked);
            InitMostRecentFiles(arMRUList);
            rcMain.ForceInitialize();
            GalleryDropDown skins = new GalleryDropDown();
            skins.Ribbon = rcMain;
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins);
            iPaintStyle.DropDownControl = skins;

            //// Close the splash screen
            //CloseSplash();

            EnableRibbonButtons(false);
            ShowLoginForm();

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
            ShowNewDocument(new T());
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

        private void iPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

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

        #region Patient Forms
        private void iYeniSGKHastasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenNewSGKPatient();
        }

        private void iYeniHasta_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenNewHasta();
        }
        public void OpenNewHasta()
        {
            //Patient patient = PatientServices.GetNewPatient();
            string name = "Yeni Hasta";
            HastaIslemleriForm newForm = new HastaIslemleriForm("");
            newForm.Text = name;
            ShowNewDocument(newForm);
        }
        public void OpenHasta(string patientID)
        {
            Patient patient = PatientServices.GetPatientByID(patientID);
            if (patient != null)
            {
                HastaIslemleriForm newForm = new HastaIslemleriForm(patientID);
                string name = patient.FirstName + " " + patient.LastName;
                newForm.Text = name;
                ShowNewDocument(newForm);
                AddToMostRecentFiles(name, arMRUList);
            }
        }
        public void OpenNewSGKPatient()
        {
            string name = "Yeni SGK Hastasý";
            SGKPatientForm newForm = new SGKPatientForm("");
            newForm.Text = name;
            ShowNewDocument(newForm);
        }
        public void OpenNewSGKPatientWithTCID(string newTCID)
        {
            string name = "Yeni SGK Hastasý";
            SGKPatientForm newForm = new SGKPatientForm("");
            newForm.Text = name;
            ShowNewDocument(newForm);
            newForm.SetNewTCID(newTCID);
        }

        public void OpenSGKPatient(string patientID)
        {
            Patient patient = PatientServices.GetPatientByID(patientID);
            if (patient != null)
            {
                SGKPatientForm newForm = new SGKPatientForm(patientID);
                string name = patient.FirstName + " " + patient.LastName;
                newForm.Text = name;
                ShowNewDocument(newForm);
                AddToMostRecentFiles(name, arMRUList);
            }
        }
        #endregion

        #region MDIChildForms
        private void AttachMDIChildButtons()
        {
            iHastaAra.ItemClick += (o, args) => ShowNewDocument<HastaAraForm>();
            iSGKHastaAra.ItemClick += (o, args) => ShowNewDocument<SGKFindPatientForm>();
            iPrinterSettings.ItemClick += (o, args) => ShowNewDocument<PrinterSettingsForm>();
            iAccDailyReport.ItemClick += (o, args) => ShowNewDocument<AccountingDailySummaryForm>();
            iSGKInvoiceVoucher.ItemClick += (o, args) => ShowNewDocument<SGKInvoiceVoucherForm>();
            iDiabetReports.ItemClick += (o, args) => ShowNewDocument<MedulaDiabetReportForm>();
            iMedulaMedicationReports.ItemClick += (o, args) => ShowNewDocument<MedulaMedicationReportForm>();
            iTreatmentReports.ItemClick += (o, args) => ShowNewDocument<MedulaMedicationReportForm>();
            iDatabaseTest.ItemClick += (o, args) => ShowNewDocument<DBTestForm>();
            iDailyTellerReport.ItemClick += (o, args) => ShowNewDocument<DailyTellerReportForm>();
        }
        #endregion

        #region LookUp Buttons

        private void ShowNewLookUpForm<T>(IList<T> lookUpTable, string caption) where T : new()
        {
            LookUpForm<T> newForm = new LookUpForm<T>(lookUpTable);
            newForm.Text = caption;
            ShowNewDocument(newForm);
        }
        private void AttachLookUpButtons()
        {
            // General LookUps
            iBloodType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.BloodTypes, args.Item.Caption);
            iCity.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.Cities, args.Item.Caption);
            iIDType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.IDTypes, args.Item.Caption);
            iNationality.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.Nationalities, args.Item.Caption);
            iPatientRelations.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.PatientRelations, args.Item.Caption);
            iVAT.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.VATs, args.Item.Caption);
            iYesNo.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.YesNos, args.Item.Caption);

            // Medula Diabet Report
            iAcuteComplication.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.AcuteComplications, args.Item.Caption);
            iApplicationReason.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.ApplicationReasons, args.Item.Caption);
            iDiseaseCode.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.DiseaseCodes, args.Item.Caption);
            iEKG.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.EKGs, args.Item.Caption);
            iExercise.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.Exercises, args.Item.Caption);
            iEyeExam.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.EyeExams, args.Item.Caption);
            iFootExam.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.FootExams, args.Item.Caption);
            iHabitCode.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.HabitCodes, args.Item.Caption);
            iPositiveNegative.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.PositiveNegatives, args.Item.Caption);
            iResidentialType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.ResidentialTypes, args.Item.Caption);
            iTBT.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.TBTs, args.Item.Caption);
            iVarYok.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.VarYoks, args.Item.Caption);

            // Medula Provision
            iProvisionType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.ProvisionTypes, args.Item.Caption);
            iBranchCodes.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.BranchCodes, args.Item.Caption);
            iFollowUpType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.FollowUpTypes, args.Item.Caption);
            iInsuranceType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.InsuranceTypes, args.Item.Caption);
            iTreatmentType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.TreatmentTypes, args.Item.Caption);
            iTreatmentStyle.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.TreatmentStyles, args.Item.Caption);
            iTransferorIns.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.TransferorInstitutions, args.Item.Caption);
            iRelationType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.RelationTypes, args.Item.Caption);

            // Medula Treatment Report
            iDoctorType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.DoctorTypes, args.Item.Caption);
            iMedulaReportType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.MedulaReportTypes, args.Item.Caption);
            iEditingType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.EditingTypes, args.Item.Caption);
            iMedulaReportTreatmentType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.MedulaReportTreatmentTypes, args.Item.Caption);
            iESWTBodyPart.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.ESWTBodyParts, args.Item.Caption);
            iFTRBodyPart.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.FTRBodyParts, args.Item.Caption);
            iKidneyType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.KidneyTypes, args.Item.Caption);           
            iKidneyStoneLocalisationCode.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.KidneyStoneLocalisationCodes, args.Item.Caption);
            iEffectiveSubstances.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.EffectiveSubstances, args.Item.Caption);

            //Special LookUps
            iDepository.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.Depositories, args.Item.Caption);
            iDoctor.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.Doctors, args.Item.Caption);
            iFunctionGroup.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.FunctionGroups, args.Item.Caption);
            iSubFunctionGroup.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.SubFunctionGroups, args.Item.Caption);
            iFunctionType.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.FunctionGroupTypes, args.Item.Caption);
            iPriceList.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.PriceLists, args.Item.Caption);
            iRooms.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.Rooms, args.Item.Caption);
            iService.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.Services, args.Item.Caption);
            iSystemSettings.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.SystemSettings, args.Item.Caption);
            iUser.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.Users, args.Item.Caption);
            iWareHouse.ItemClick += (o, args) => ShowNewLookUpForm(LookUpServices.Warehouses, args.Item.Caption);

        }

        #endregion

        #region Reports
        private void ShowReport<T>(string caption) where T : DevExpress.XtraReports.UI.XtraReport, new()
        {
            //T report = new T();
            //report.ShowPreview();
            PrintPreviewForm newForm = new PrintPreviewForm();
            newForm.Text = caption;
            ShowNewDocument(newForm);
            newForm.ShowReport<T>();
        }

        private void AttachReportCommands()
        {
            iOzetAnaIslemAyXTab.ItemClick += (o, args) => ShowReport<OZETAnaIslemAyXTab>(args.Item.Caption);
            iOzetAnaIslem.ItemClick += (o, args) => ShowReport<OZETAnaIslemReport>(args.Item.Caption);
            iOzetServisAnaIslemPivot.ItemClick += (o, args) => ShowReport<OZETAnaIslemServisXTab>(args.Item.Caption);
            iOzetAYPAnaIslem.ItemClick += (o, args) => ShowReport<OZETAYPAnaIslemReport>(args.Item.Caption);
            iOzetAYP.ItemClick += (o, args) => ShowReport<OZETAYPReport>(args.Item.Caption);
            iOzetDoktorAnaIslem.ItemClick += (o, args) => ShowReport<OZETDoktorAnaIslemReport>(args.Item.Caption);
            iOzetDoktor.ItemClick += (o, args) => ShowReport<OZETDoktorReport>(args.Item.Caption);
            iOzetDoktorServis.ItemClick += (o, args) => ShowReport<OZETDoktorServisReport>(args.Item.Caption);
            iOzetKurumAnaIslem.ItemClick += (o, args) => ShowReport<OZETKurumAnaIslemReport>(args.Item.Caption);
            iOzetKurumAYP.ItemClick += (o, args) => ShowReport<OZETKurumAYPReport>(args.Item.Caption);
            iOzetKurum.ItemClick += (o, args) => ShowReport<OZETKurumReport>(args.Item.Caption);
            iOzetServisAnaIslem.ItemClick += (o, args) => ShowReport<OZETServisAnaIslemReport>(args.Item.Caption);
            iOzetServis.ItemClick += (o, args) => ShowReport<OZETServisReport>(args.Item.Caption);
            iOzetYatakServisAy.ItemClick += (o, args) => ShowReport<OZETYatakServisAyXTab>(args.Item.Caption);

            //iOzetHastaneServisAnaIslem.ItemClick += (o, args) => ShowReport<OZETServisAnaIslemReport>();
        }

        private void ReportExportToPdf<T>(string aPath) where T : DevExpress.XtraReports.UI.XtraReport, new()
        {
            const string path = @"D:\SurpPirgic\Tipdata\AccessRapor\DevxReports\";
            T report = new T();
            report.Parameters[0].Value = "Nisan 2011";
            report.ExportToPdf(path + aPath + ".pdf");
        }

        private void iExportToPDF_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportExportToPdf<OZETAnaIslemAyXTab>("OZETAnaIslemAyXTab");
            ReportExportToPdf<OZETAnaIslemReport>("OZETAnaIslemReport");
            ReportExportToPdf<OZETAnaIslemServisXTab>("OZETAnaIslemServisXTab");
            ReportExportToPdf<OZETAYPAnaIslemReport>("OZETAYPAnaIslemReport");
            ReportExportToPdf<OZETAYPReport>("OZETAYPReport");
            ReportExportToPdf<OZETDoktorAnaIslemReport>("OZETDoktorAnaIslemReport");
            ReportExportToPdf<OZETDoktorReport>("OZETDoktorReport");
            ReportExportToPdf<OZETDoktorServisReport>("OZETDoktorServisReport");
            ReportExportToPdf<OZETKurumAnaIslemReport>("OZETKurumAnaIslemReport");
            ReportExportToPdf<OZETKurumAYPReport>("OZETKurumAYPReport");
            ReportExportToPdf<OZETKurumReport>("OZETKurumReport");
            ReportExportToPdf<OZETServisAnaIslemReport>("OZETServisAnaIslemReport");
            ReportExportToPdf<OZETServisReport>("OZETServisReport");
            ReportExportToPdf<OZETYatakServisAyXTab>("OZETYatakServisAyXTab");
        }

        private void ReportExportToXlsx<T>(string aPath) where T : DevExpress.XtraReports.UI.XtraReport, new()
        {
            const string path = @"D:\SurpPirgic\Tipdata\AccessRapor\DevxReports\";
            T report = new T();
            report.Parameters[0].Value = "Nisan 2011";
            report.ExportToXlsx(path + aPath + ".xlsx");
        }

        private void iExportToXLSX_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportExportToXlsx<OZETAnaIslemAyXTab>("OZETAnaIslemAyXTab");
            ReportExportToXlsx<OZETAnaIslemReport>("OZETAnaIslemReport");
            ReportExportToXlsx<OZETAnaIslemServisXTab>("OZETAnaIslemServisXTab");
            ReportExportToXlsx<OZETAYPAnaIslemReport>("OZETAYPAnaIslemReport");
            ReportExportToXlsx<OZETAYPReport>("OZETAYPReport");
            ReportExportToXlsx<OZETDoktorAnaIslemReport>("OZETDoktorAnaIslemReport");
            ReportExportToXlsx<OZETDoktorReport>("OZETDoktorReport");
            ReportExportToXlsx<OZETDoktorServisReport>("OZETDoktorServisReport");
            ReportExportToXlsx<OZETKurumAnaIslemReport>("OZETKurumAnaIslemReport");
            ReportExportToXlsx<OZETKurumAYPReport>("OZETKurumAYPReport");
            ReportExportToXlsx<OZETKurumReport>("OZETKurumReport");
            ReportExportToXlsx<OZETServisAnaIslemReport>("OZETServisAnaIslemReport");
            ReportExportToXlsx<OZETServisReport>("OZETServisReport");
            ReportExportToXlsx<OZETYatakServisAyXTab>("OZETYatakServisAyXTab");
        }

        #endregion

        #region Login
        private void iLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();
            if (form.IsOK)
                UIUtilities.CurrentUser = form.User;
            EnableRibbonButtons(form.IsOK);
        }

        private void iPasswordChange_ItemClick(object sender, ItemClickEventArgs e)
        {
            PasswordChangeForm form = new PasswordChangeForm();
            form.ShowDialog();
            if (form.IsOK)
                UIUtilities.CurrentUser = form.User;
        }

        private void EnableRibbonButtons(bool enable)
        {
            foreach (RibbonPage rp in this.rcMain.Pages)
            {
                rp.Visible = enable;
                foreach (RibbonPageGroup rpg in rp.Groups)
                    rpg.Visible = enable;
            }
            this.rpUser.Visible = true;
            this.rpgUserFunctions.Visible = true;
            this.rcMain.SelectedPage = rpSGKPatients;
        }
        #endregion

    }
}
