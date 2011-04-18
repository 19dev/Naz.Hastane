namespace Naz.Hastane.Win.Controls
{
    partial class InvoiceControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.teVoucherNo = new DevExpress.XtraEditors.TextEdit();
            this.luePOS = new DevExpress.XtraEditors.LookUpEdit();
            this.ceAdvancePayment = new DevExpress.XtraEditors.CheckEdit();
            this.tePayment = new DevExpress.XtraEditors.TextEdit();
            this.tePatientVisitDetailTotal = new DevExpress.XtraEditors.TextEdit();
            this.ceSelectAll = new DevExpress.XtraEditors.CheckEdit();
            this.lueVAT = new DevExpress.XtraEditors.LookUpEdit();
            this.teVATTotal = new DevExpress.XtraEditors.TextEdit();
            this.cePayment = new DevExpress.XtraEditors.CheckEdit();
            this.teProductTotal = new DevExpress.XtraEditors.TextEdit();
            this.teGrandTotal = new DevExpress.XtraEditors.TextEdit();
            this.teRemainingTotal = new DevExpress.XtraEditors.TextEdit();
            this.teAdvancePaymentRemaining = new DevExpress.XtraEditors.TextEdit();
            this.teAdvancePaymentUsed = new DevExpress.XtraEditors.TextEdit();
            this.luePaymentType = new DevExpress.XtraEditors.LookUpEdit();
            this.teAdvancePaymentTotal = new DevExpress.XtraEditors.TextEdit();
            this.teInvoiceTotal = new DevExpress.XtraEditors.TextEdit();
            this.deExitDate = new DevExpress.XtraEditors.DateEdit();
            this.deCardDate = new DevExpress.XtraEditors.DateEdit();
            this.deInvoiceDate = new DevExpress.XtraEditors.DateEdit();
            this.teTaxNo = new DevExpress.XtraEditors.TextEdit();
            this.teTaxOffice = new DevExpress.XtraEditors.TextEdit();
            this.teInvoiceNo = new DevExpress.XtraEditors.TextEdit();
            this.meInvoiceAddress = new DevExpress.XtraEditors.MemoEdit();
            this.gcAdvancePayments = new DevExpress.XtraGrid.GridControl();
            this.gvAdvancePayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdvancePaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdvancePaymentAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPatientVisitDetails = new DevExpress.XtraGrid.GridControl();
            this.gvPatientVisitDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPatientVisitDetailVisitNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailPatientTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcPatientVisits = new DevExpress.XtraGrid.GridControl();
            this.gvPatientVisits = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVisitNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatientTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.sbVoucher = new DevExpress.XtraEditors.SimpleButton();
            this.sbRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.sbInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciInvoiceNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTaxOffice = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTaxNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciExitDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCardDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciInvoiceDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciGrandTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAdvancePaymentUsed = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAdvancePaymentTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciInvoiceTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProductTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciVATTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPayment = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRemainingTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciPaymentType = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPOS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAdvancePaymentRemaining = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciVoucherNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePOS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAdvancePayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePatientVisitDetailTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teVATTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGrandTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRemainingTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAdvancePaymentRemaining.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAdvancePaymentUsed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAdvancePaymentTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInvoiceTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExitDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExitDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCardDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCardDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTaxNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTaxOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meInvoiceAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdvancePayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdvancePayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisitDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisitDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoiceNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTaxOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTaxNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExitDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCardDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoiceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrandTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdvancePaymentUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdvancePaymentTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoiceTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProductTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVATTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemainingTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdvancePaymentRemaining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teVoucherNo);
            this.layoutControl1.Controls.Add(this.luePOS);
            this.layoutControl1.Controls.Add(this.ceAdvancePayment);
            this.layoutControl1.Controls.Add(this.tePayment);
            this.layoutControl1.Controls.Add(this.tePatientVisitDetailTotal);
            this.layoutControl1.Controls.Add(this.ceSelectAll);
            this.layoutControl1.Controls.Add(this.lueVAT);
            this.layoutControl1.Controls.Add(this.teVATTotal);
            this.layoutControl1.Controls.Add(this.cePayment);
            this.layoutControl1.Controls.Add(this.teProductTotal);
            this.layoutControl1.Controls.Add(this.teGrandTotal);
            this.layoutControl1.Controls.Add(this.teRemainingTotal);
            this.layoutControl1.Controls.Add(this.teAdvancePaymentRemaining);
            this.layoutControl1.Controls.Add(this.teAdvancePaymentUsed);
            this.layoutControl1.Controls.Add(this.luePaymentType);
            this.layoutControl1.Controls.Add(this.teAdvancePaymentTotal);
            this.layoutControl1.Controls.Add(this.teInvoiceTotal);
            this.layoutControl1.Controls.Add(this.deExitDate);
            this.layoutControl1.Controls.Add(this.deCardDate);
            this.layoutControl1.Controls.Add(this.deInvoiceDate);
            this.layoutControl1.Controls.Add(this.teTaxNo);
            this.layoutControl1.Controls.Add(this.teTaxOffice);
            this.layoutControl1.Controls.Add(this.teInvoiceNo);
            this.layoutControl1.Controls.Add(this.meInvoiceAddress);
            this.layoutControl1.Controls.Add(this.gcAdvancePayments);
            this.layoutControl1.Controls.Add(this.gcPatientVisitDetails);
            this.layoutControl1.Controls.Add(this.gcPatientVisits);
            this.layoutControl1.Controls.Add(this.sbVoucher);
            this.layoutControl1.Controls.Add(this.sbRefresh);
            this.layoutControl1.Controls.Add(this.sbInvoice);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1672, -141, 387, 543);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(956, 595);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teVoucherNo
            // 
            this.teVoucherNo.Location = new System.Drawing.Point(671, 384);
            this.teVoucherNo.Name = "teVoucherNo";
            this.teVoucherNo.Size = new System.Drawing.Size(96, 20);
            this.teVoucherNo.StyleController = this.layoutControl1;
            this.teVoucherNo.TabIndex = 36;
            // 
            // luePOS
            // 
            this.luePOS.Location = new System.Drawing.Point(504, 348);
            this.luePOS.Name = "luePOS";
            this.luePOS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePOS.Size = new System.Drawing.Size(81, 20);
            this.luePOS.StyleController = this.layoutControl1;
            this.luePOS.TabIndex = 35;
            // 
            // ceAdvancePayment
            // 
            this.ceAdvancePayment.Location = new System.Drawing.Point(423, 301);
            this.ceAdvancePayment.Name = "ceAdvancePayment";
            this.ceAdvancePayment.Properties.Caption = "Avans";
            this.ceAdvancePayment.Size = new System.Drawing.Size(162, 19);
            this.ceAdvancePayment.StyleController = this.layoutControl1;
            this.ceAdvancePayment.TabIndex = 34;
            this.ceAdvancePayment.CheckedChanged += new System.EventHandler(this.ceAdvancePayment_CheckedChanged);
            // 
            // tePayment
            // 
            this.tePayment.Location = new System.Drawing.Point(670, 324);
            this.tePayment.Name = "tePayment";
            this.tePayment.Properties.Appearance.Options.UseTextOptions = true;
            this.tePayment.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tePayment.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.tePayment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tePayment.Size = new System.Drawing.Size(99, 20);
            this.tePayment.StyleController = this.layoutControl1;
            this.tePayment.TabIndex = 33;
            this.tePayment.EditValueChanged += new System.EventHandler(this.tePayment_EditValueChanged);
            // 
            // tePatientVisitDetailTotal
            // 
            this.tePatientVisitDetailTotal.Location = new System.Drawing.Point(335, 543);
            this.tePatientVisitDetailTotal.Name = "tePatientVisitDetailTotal";
            this.tePatientVisitDetailTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.tePatientVisitDetailTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tePatientVisitDetailTotal.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.tePatientVisitDetailTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tePatientVisitDetailTotal.Size = new System.Drawing.Size(77, 20);
            this.tePatientVisitDetailTotal.StyleController = this.layoutControl1;
            this.tePatientVisitDetailTotal.TabIndex = 31;
            // 
            // ceSelectAll
            // 
            this.ceSelectAll.Location = new System.Drawing.Point(6, 543);
            this.ceSelectAll.Name = "ceSelectAll";
            this.ceSelectAll.Properties.Caption = "Hepsini Seç";
            this.ceSelectAll.Size = new System.Drawing.Size(93, 19);
            this.ceSelectAll.StyleController = this.layoutControl1;
            this.ceSelectAll.TabIndex = 30;
            // 
            // lueVAT
            // 
            this.lueVAT.Location = new System.Drawing.Point(184, 543);
            this.lueVAT.Name = "lueVAT";
            this.lueVAT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueVAT.Size = new System.Drawing.Size(66, 20);
            this.lueVAT.StyleController = this.layoutControl1;
            this.lueVAT.TabIndex = 29;
            this.lueVAT.EditValueChanged += new System.EventHandler(this.lueVAT_EditValueChanged);
            // 
            // teVATTotal
            // 
            this.teVATTotal.Enabled = false;
            this.teVATTotal.Location = new System.Drawing.Point(670, 226);
            this.teVATTotal.Name = "teVATTotal";
            this.teVATTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.teVATTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teVATTotal.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.teVATTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teVATTotal.Size = new System.Drawing.Size(99, 20);
            this.teVATTotal.StyleController = this.layoutControl1;
            this.teVATTotal.TabIndex = 27;
            // 
            // cePayment
            // 
            this.cePayment.Location = new System.Drawing.Point(423, 324);
            this.cePayment.Name = "cePayment";
            this.cePayment.Properties.Caption = "Ödeme";
            this.cePayment.Size = new System.Drawing.Size(79, 19);
            this.cePayment.StyleController = this.layoutControl1;
            this.cePayment.TabIndex = 32;
            this.cePayment.CheckedChanged += new System.EventHandler(this.cePayment_CheckedChanged);
            // 
            // teProductTotal
            // 
            this.teProductTotal.Enabled = false;
            this.teProductTotal.Location = new System.Drawing.Point(670, 202);
            this.teProductTotal.Name = "teProductTotal";
            this.teProductTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.teProductTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teProductTotal.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.teProductTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teProductTotal.Size = new System.Drawing.Size(99, 20);
            this.teProductTotal.StyleController = this.layoutControl1;
            this.teProductTotal.TabIndex = 26;
            // 
            // teGrandTotal
            // 
            this.teGrandTotal.Enabled = false;
            this.teGrandTotal.Location = new System.Drawing.Point(670, 348);
            this.teGrandTotal.Name = "teGrandTotal";
            this.teGrandTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.teGrandTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teGrandTotal.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.teGrandTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teGrandTotal.Size = new System.Drawing.Size(99, 20);
            this.teGrandTotal.StyleController = this.layoutControl1;
            this.teGrandTotal.TabIndex = 24;
            // 
            // teRemainingTotal
            // 
            this.teRemainingTotal.Enabled = false;
            this.teRemainingTotal.Location = new System.Drawing.Point(854, 348);
            this.teRemainingTotal.Name = "teRemainingTotal";
            this.teRemainingTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.teRemainingTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teRemainingTotal.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.teRemainingTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teRemainingTotal.Size = new System.Drawing.Size(84, 20);
            this.teRemainingTotal.StyleController = this.layoutControl1;
            this.teRemainingTotal.TabIndex = 23;
            // 
            // teAdvancePaymentRemaining
            // 
            this.teAdvancePaymentRemaining.Enabled = false;
            this.teAdvancePaymentRemaining.Location = new System.Drawing.Point(854, 252);
            this.teAdvancePaymentRemaining.Name = "teAdvancePaymentRemaining";
            this.teAdvancePaymentRemaining.Properties.Appearance.Options.UseTextOptions = true;
            this.teAdvancePaymentRemaining.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teAdvancePaymentRemaining.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.teAdvancePaymentRemaining.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teAdvancePaymentRemaining.Size = new System.Drawing.Size(84, 20);
            this.teAdvancePaymentRemaining.StyleController = this.layoutControl1;
            this.teAdvancePaymentRemaining.TabIndex = 22;
            // 
            // teAdvancePaymentUsed
            // 
            this.teAdvancePaymentUsed.Location = new System.Drawing.Point(670, 300);
            this.teAdvancePaymentUsed.Name = "teAdvancePaymentUsed";
            this.teAdvancePaymentUsed.Properties.Appearance.Options.UseTextOptions = true;
            this.teAdvancePaymentUsed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teAdvancePaymentUsed.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.teAdvancePaymentUsed.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teAdvancePaymentUsed.Size = new System.Drawing.Size(99, 20);
            this.teAdvancePaymentUsed.StyleController = this.layoutControl1;
            this.teAdvancePaymentUsed.TabIndex = 21;
            this.teAdvancePaymentUsed.EditValueChanged += new System.EventHandler(this.teUsedAdvancePayment_EditValueChanged);
            // 
            // luePaymentType
            // 
            this.luePaymentType.Location = new System.Drawing.Point(506, 324);
            this.luePaymentType.Name = "luePaymentType";
            this.luePaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePaymentType.Size = new System.Drawing.Size(79, 20);
            this.luePaymentType.StyleController = this.layoutControl1;
            this.luePaymentType.TabIndex = 25;
            this.luePaymentType.EditValueChanged += new System.EventHandler(this.luePaymentType_EditValueChanged);
            // 
            // teAdvancePaymentTotal
            // 
            this.teAdvancePaymentTotal.Enabled = false;
            this.teAdvancePaymentTotal.Location = new System.Drawing.Point(670, 276);
            this.teAdvancePaymentTotal.Name = "teAdvancePaymentTotal";
            this.teAdvancePaymentTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.teAdvancePaymentTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teAdvancePaymentTotal.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.teAdvancePaymentTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teAdvancePaymentTotal.Size = new System.Drawing.Size(99, 20);
            this.teAdvancePaymentTotal.StyleController = this.layoutControl1;
            this.teAdvancePaymentTotal.TabIndex = 20;
            // 
            // teInvoiceTotal
            // 
            this.teInvoiceTotal.Enabled = false;
            this.teInvoiceTotal.Location = new System.Drawing.Point(670, 252);
            this.teInvoiceTotal.Name = "teInvoiceTotal";
            this.teInvoiceTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.teInvoiceTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.teInvoiceTotal.Properties.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.teInvoiceTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teInvoiceTotal.Size = new System.Drawing.Size(99, 20);
            this.teInvoiceTotal.StyleController = this.layoutControl1;
            this.teInvoiceTotal.TabIndex = 19;
            // 
            // deExitDate
            // 
            this.deExitDate.EditValue = null;
            this.deExitDate.Location = new System.Drawing.Point(798, 134);
            this.deExitDate.Name = "deExitDate";
            this.deExitDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deExitDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deExitDate.Size = new System.Drawing.Size(140, 20);
            this.deExitDate.StyleController = this.layoutControl1;
            this.deExitDate.TabIndex = 18;
            // 
            // deCardDate
            // 
            this.deCardDate.EditValue = null;
            this.deCardDate.Location = new System.Drawing.Point(798, 94);
            this.deCardDate.Name = "deCardDate";
            this.deCardDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCardDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deCardDate.Size = new System.Drawing.Size(140, 20);
            this.deCardDate.StyleController = this.layoutControl1;
            this.deCardDate.TabIndex = 17;
            // 
            // deInvoiceDate
            // 
            this.deInvoiceDate.EditValue = null;
            this.deInvoiceDate.Location = new System.Drawing.Point(798, 54);
            this.deInvoiceDate.Name = "deInvoiceDate";
            this.deInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deInvoiceDate.Size = new System.Drawing.Size(140, 20);
            this.deInvoiceDate.StyleController = this.layoutControl1;
            this.deInvoiceDate.TabIndex = 16;
            // 
            // teTaxNo
            // 
            this.teTaxNo.Location = new System.Drawing.Point(647, 134);
            this.teTaxNo.Name = "teTaxNo";
            this.teTaxNo.Size = new System.Drawing.Size(147, 20);
            this.teTaxNo.StyleController = this.layoutControl1;
            this.teTaxNo.TabIndex = 15;
            // 
            // teTaxOffice
            // 
            this.teTaxOffice.Location = new System.Drawing.Point(647, 94);
            this.teTaxOffice.Name = "teTaxOffice";
            this.teTaxOffice.Size = new System.Drawing.Size(147, 20);
            this.teTaxOffice.StyleController = this.layoutControl1;
            this.teTaxOffice.TabIndex = 14;
            // 
            // teInvoiceNo
            // 
            this.teInvoiceNo.Location = new System.Drawing.Point(647, 54);
            this.teInvoiceNo.Name = "teInvoiceNo";
            this.teInvoiceNo.Size = new System.Drawing.Size(147, 20);
            this.teInvoiceNo.StyleController = this.layoutControl1;
            this.teInvoiceNo.TabIndex = 13;
            // 
            // meInvoiceAddress
            // 
            this.meInvoiceAddress.Location = new System.Drawing.Point(423, 54);
            this.meInvoiceAddress.Name = "meInvoiceAddress";
            this.meInvoiceAddress.Size = new System.Drawing.Size(220, 100);
            this.meInvoiceAddress.StyleController = this.layoutControl1;
            this.meInvoiceAddress.TabIndex = 12;
            // 
            // gcAdvancePayments
            // 
            this.gcAdvancePayments.Location = new System.Drawing.Point(266, 22);
            this.gcAdvancePayments.MainView = this.gvAdvancePayments;
            this.gcAdvancePayments.Name = "gcAdvancePayments";
            this.gcAdvancePayments.Size = new System.Drawing.Size(141, 153);
            this.gcAdvancePayments.TabIndex = 11;
            this.gcAdvancePayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAdvancePayments});
            // 
            // gvAdvancePayments
            // 
            this.gvAdvancePayments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdvancePaymentDate,
            this.colAdvancePaymentAmount});
            this.gvAdvancePayments.GridControl = this.gcAdvancePayments;
            this.gvAdvancePayments.Name = "gvAdvancePayments";
            this.gvAdvancePayments.OptionsView.ShowGroupPanel = false;
            // 
            // colAdvancePaymentDate
            // 
            this.colAdvancePaymentDate.Caption = "Tarih";
            this.colAdvancePaymentDate.DisplayFormat.FormatString = "d";
            this.colAdvancePaymentDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAdvancePaymentDate.FieldName = "TARIH";
            this.colAdvancePaymentDate.Name = "colAdvancePaymentDate";
            this.colAdvancePaymentDate.OptionsColumn.AllowEdit = false;
            this.colAdvancePaymentDate.Visible = true;
            this.colAdvancePaymentDate.VisibleIndex = 0;
            this.colAdvancePaymentDate.Width = 71;
            // 
            // colAdvancePaymentAmount
            // 
            this.colAdvancePaymentAmount.Caption = "Tutar";
            this.colAdvancePaymentAmount.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colAdvancePaymentAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAdvancePaymentAmount.FieldName = "RemainingAmount";
            this.colAdvancePaymentAmount.Name = "colAdvancePaymentAmount";
            this.colAdvancePaymentAmount.OptionsColumn.AllowEdit = false;
            this.colAdvancePaymentAmount.Visible = true;
            this.colAdvancePaymentAmount.VisibleIndex = 1;
            this.colAdvancePaymentAmount.Width = 52;
            // 
            // gcPatientVisitDetails
            // 
            this.gcPatientVisitDetails.Location = new System.Drawing.Point(6, 195);
            this.gcPatientVisitDetails.MainView = this.gvPatientVisitDetails;
            this.gcPatientVisitDetails.Name = "gcPatientVisitDetails";
            this.gcPatientVisitDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcPatientVisitDetails.Size = new System.Drawing.Size(401, 344);
            this.gcPatientVisitDetails.TabIndex = 9;
            this.gcPatientVisitDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatientVisitDetails});
            // 
            // gvPatientVisitDetails
            // 
            this.gvPatientVisitDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPatientVisitDetailVisitNo,
            this.colDetailNo,
            this.colDetailDate,
            this.colDetailComment,
            this.colDetailCount,
            this.colDetailPatientTotal});
            this.gvPatientVisitDetails.GridControl = this.gcPatientVisitDetails;
            this.gvPatientVisitDetails.Name = "gvPatientVisitDetails";
            this.gvPatientVisitDetails.OptionsView.ShowGroupPanel = false;
            // 
            // colPatientVisitDetailVisitNo
            // 
            this.colPatientVisitDetailVisitNo.Caption = "Kart No";
            this.colPatientVisitDetailVisitNo.FieldName = "PatientVisit.VisitNo";
            this.colPatientVisitDetailVisitNo.Name = "colPatientVisitDetailVisitNo";
            this.colPatientVisitDetailVisitNo.Visible = true;
            this.colPatientVisitDetailVisitNo.VisibleIndex = 0;
            // 
            // colDetailNo
            // 
            this.colDetailNo.Caption = "İşlem No";
            this.colDetailNo.FieldName = "DetailNo";
            this.colDetailNo.Name = "colDetailNo";
            this.colDetailNo.OptionsColumn.AllowEdit = false;
            this.colDetailNo.Visible = true;
            this.colDetailNo.VisibleIndex = 1;
            // 
            // colDetailDate
            // 
            this.colDetailDate.Caption = "İşlem Tarihi";
            this.colDetailDate.FieldName = "TARIH";
            this.colDetailDate.Name = "colDetailDate";
            this.colDetailDate.OptionsColumn.AllowEdit = false;
            this.colDetailDate.Visible = true;
            this.colDetailDate.VisibleIndex = 2;
            // 
            // colDetailComment
            // 
            this.colDetailComment.Caption = "Açıklama";
            this.colDetailComment.FieldName = "NAME1";
            this.colDetailComment.Name = "colDetailComment";
            this.colDetailComment.OptionsColumn.AllowEdit = false;
            this.colDetailComment.Visible = true;
            this.colDetailComment.VisibleIndex = 3;
            // 
            // colDetailCount
            // 
            this.colDetailCount.Caption = "Adet";
            this.colDetailCount.FieldName = "ADET";
            this.colDetailCount.Name = "colDetailCount";
            this.colDetailCount.OptionsColumn.AllowEdit = false;
            this.colDetailCount.Visible = true;
            this.colDetailCount.VisibleIndex = 4;
            // 
            // colDetailPatientTotal
            // 
            this.colDetailPatientTotal.Caption = "Hasta Tutarı";
            this.colDetailPatientTotal.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colDetailPatientTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetailPatientTotal.FieldName = "SATISF";
            this.colDetailPatientTotal.Name = "colDetailPatientTotal";
            this.colDetailPatientTotal.OptionsColumn.AllowEdit = false;
            this.colDetailPatientTotal.Visible = true;
            this.colDetailPatientTotal.VisibleIndex = 5;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gcPatientVisits
            // 
            this.gcPatientVisits.Location = new System.Drawing.Point(6, 22);
            this.gcPatientVisits.MainView = this.gvPatientVisits;
            this.gcPatientVisits.Name = "gcPatientVisits";
            this.gcPatientVisits.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gcPatientVisits.Size = new System.Drawing.Size(256, 153);
            this.gcPatientVisits.TabIndex = 4;
            this.gcPatientVisits.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatientVisits});
            // 
            // gvPatientVisits
            // 
            this.gvPatientVisits.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVisitNo,
            this.colDate,
            this.colExitDate,
            this.colPatientTotal});
            this.gvPatientVisits.GridControl = this.gcPatientVisits;
            this.gvPatientVisits.Name = "gvPatientVisits";
            this.gvPatientVisits.OptionsView.ShowGroupPanel = false;
            // 
            // colVisitNo
            // 
            this.colVisitNo.Caption = "Kart No";
            this.colVisitNo.FieldName = "VisitNo";
            this.colVisitNo.Name = "colVisitNo";
            this.colVisitNo.OptionsColumn.AllowEdit = false;
            this.colVisitNo.Visible = true;
            this.colVisitNo.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.Caption = "İşlem Tarihi";
            this.colDate.FieldName = "VisitDate";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colExitDate
            // 
            this.colExitDate.Caption = "Çıkış Tarihi";
            this.colExitDate.FieldName = "ExitDate";
            this.colExitDate.Name = "colExitDate";
            this.colExitDate.OptionsColumn.AllowEdit = false;
            this.colExitDate.Visible = true;
            this.colExitDate.VisibleIndex = 2;
            // 
            // colPatientTotal
            // 
            this.colPatientTotal.Caption = "Hasta Tutarı";
            this.colPatientTotal.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.colPatientTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPatientTotal.FieldName = "PatientTotal";
            this.colPatientTotal.Name = "colPatientTotal";
            this.colPatientTotal.OptionsColumn.AllowEdit = false;
            this.colPatientTotal.Visible = true;
            this.colPatientTotal.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // sbVoucher
            // 
            this.sbVoucher.Location = new System.Drawing.Point(771, 384);
            this.sbVoucher.Name = "sbVoucher";
            this.sbVoucher.Size = new System.Drawing.Size(179, 22);
            this.sbVoucher.StyleController = this.layoutControl1;
            this.sbVoucher.TabIndex = 5;
            this.sbVoucher.Text = "Makbuz Kes";
            this.sbVoucher.Click += new System.EventHandler(this.sbVoucher_Click);
            // 
            // sbRefresh
            // 
            this.sbRefresh.Location = new System.Drawing.Point(388, 567);
            this.sbRefresh.Name = "sbRefresh";
            this.sbRefresh.Size = new System.Drawing.Size(71, 22);
            this.sbRefresh.StyleController = this.layoutControl1;
            this.sbRefresh.TabIndex = 8;
            this.sbRefresh.Text = "Yenile";
            // 
            // sbInvoice
            // 
            this.sbInvoice.Location = new System.Drawing.Point(773, 226);
            this.sbInvoice.Name = "sbInvoice";
            this.sbInvoice.Size = new System.Drawing.Size(165, 22);
            this.sbInvoice.StyleController = this.layoutControl1;
            this.sbInvoice.TabIndex = 6;
            this.sbInvoice.Text = "Fatura Kes";
            this.sbInvoice.Click += new System.EventHandler(this.sbInvoice_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem4,
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem5,
            this.emptySpaceItem5,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem10,
            this.emptySpaceItem8,
            this.layoutControlItem2,
            this.lciVoucherNo,
            this.emptySpaceItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(956, 595);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(405, 404);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(543, 133);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcPatientVisits;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(260, 173);
            this.layoutControlItem1.Text = "Kartlar";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.gcAdvancePayments;
            this.layoutControlItem8.CustomizationFormText = "Avanslar";
            this.layoutControlItem8.Location = new System.Drawing.Point(260, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(145, 173);
            this.layoutControlItem8.Text = "Avanslar";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gcPatientVisitDetails;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 173);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(405, 364);
            this.layoutControlItem6.Text = "İşlemler";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 561);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(62, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(62, 561);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(171, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(233, 561);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(149, 26);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbRefresh;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(382, 561);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(75, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(457, 561);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(491, 26);
            this.emptySpaceItem5.Text = "emptySpaceItem5";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Fatura Bilgileri";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.lciInvoiceNo,
            this.lciTaxOffice,
            this.lciTaxNo,
            this.lciExitDate,
            this.lciCardDate,
            this.lciInvoiceDate});
            this.layoutControlGroup2.Location = new System.Drawing.Point(405, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(543, 164);
            this.layoutControlGroup2.Text = "Fatura Bilgileri";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.meInvoiceAddress;
            this.layoutControlItem7.CustomizationFormText = "Fatura Adresi";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(224, 120);
            this.layoutControlItem7.Text = "Fatura Adresi";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciInvoiceNo
            // 
            this.lciInvoiceNo.Control = this.teInvoiceNo;
            this.lciInvoiceNo.CustomizationFormText = "Fatura No";
            this.lciInvoiceNo.Location = new System.Drawing.Point(224, 0);
            this.lciInvoiceNo.Name = "lciInvoiceNo";
            this.lciInvoiceNo.Size = new System.Drawing.Size(151, 40);
            this.lciInvoiceNo.Text = "Fatura No";
            this.lciInvoiceNo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciInvoiceNo.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciTaxOffice
            // 
            this.lciTaxOffice.Control = this.teTaxOffice;
            this.lciTaxOffice.CustomizationFormText = "Vergi Dairesi";
            this.lciTaxOffice.Location = new System.Drawing.Point(224, 40);
            this.lciTaxOffice.Name = "lciTaxOffice";
            this.lciTaxOffice.Size = new System.Drawing.Size(151, 40);
            this.lciTaxOffice.Text = "Vergi Dairesi";
            this.lciTaxOffice.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciTaxOffice.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciTaxNo
            // 
            this.lciTaxNo.Control = this.teTaxNo;
            this.lciTaxNo.CustomizationFormText = "Vergi No";
            this.lciTaxNo.Location = new System.Drawing.Point(224, 80);
            this.lciTaxNo.Name = "lciTaxNo";
            this.lciTaxNo.Size = new System.Drawing.Size(151, 40);
            this.lciTaxNo.Text = "Vergi No";
            this.lciTaxNo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciTaxNo.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciExitDate
            // 
            this.lciExitDate.Control = this.deExitDate;
            this.lciExitDate.CustomizationFormText = "Çıkış Tarihi";
            this.lciExitDate.Location = new System.Drawing.Point(375, 80);
            this.lciExitDate.Name = "lciExitDate";
            this.lciExitDate.Size = new System.Drawing.Size(144, 40);
            this.lciExitDate.Text = "Çıkış Tarihi";
            this.lciExitDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciExitDate.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciCardDate
            // 
            this.lciCardDate.Control = this.deCardDate;
            this.lciCardDate.CustomizationFormText = "Yatış Tarihi";
            this.lciCardDate.Location = new System.Drawing.Point(375, 40);
            this.lciCardDate.Name = "lciCardDate";
            this.lciCardDate.Size = new System.Drawing.Size(144, 40);
            this.lciCardDate.Text = "Yatış Tarihi";
            this.lciCardDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCardDate.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciInvoiceDate
            // 
            this.lciInvoiceDate.Control = this.deInvoiceDate;
            this.lciInvoiceDate.CustomizationFormText = "Fatura Tarihi";
            this.lciInvoiceDate.Location = new System.Drawing.Point(375, 0);
            this.lciInvoiceDate.Name = "lciInvoiceDate";
            this.lciInvoiceDate.Size = new System.Drawing.Size(144, 40);
            this.lciInvoiceDate.Text = "Fatura Tarihi";
            this.lciInvoiceDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciInvoiceDate.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Ödeme Şekli";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGrandTotal,
            this.lciAdvancePaymentUsed,
            this.lciAdvancePaymentTotal,
            this.lciInvoiceTotal,
            this.lciProductTotal,
            this.lciVATTotal,
            this.lciPayment,
            this.layoutControlItem13,
            this.emptySpaceItem10,
            this.layoutControlItem15,
            this.lciRemainingTotal,
            this.emptySpaceItem6,
            this.lciPaymentType,
            this.lciPOS,
            this.lciAdvancePaymentRemaining,
            this.layoutControlItem3,
            this.emptySpaceItem7});
            this.layoutControlGroup3.Location = new System.Drawing.Point(405, 164);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(543, 214);
            this.layoutControlGroup3.Text = "Ödeme Şekli";
            // 
            // lciGrandTotal
            // 
            this.lciGrandTotal.Control = this.teGrandTotal;
            this.lciGrandTotal.CustomizationFormText = "Toplam";
            this.lciGrandTotal.Location = new System.Drawing.Point(166, 146);
            this.lciGrandTotal.Name = "lciGrandTotal";
            this.lciGrandTotal.Size = new System.Drawing.Size(184, 24);
            this.lciGrandTotal.Text = "Toplam";
            this.lciGrandTotal.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciAdvancePaymentUsed
            // 
            this.lciAdvancePaymentUsed.Control = this.teAdvancePaymentUsed;
            this.lciAdvancePaymentUsed.CustomizationFormText = "Kullanılan Avans";
            this.lciAdvancePaymentUsed.Location = new System.Drawing.Point(166, 98);
            this.lciAdvancePaymentUsed.Name = "lciAdvancePaymentUsed";
            this.lciAdvancePaymentUsed.Size = new System.Drawing.Size(184, 24);
            this.lciAdvancePaymentUsed.Text = "Kullanılan Avans";
            this.lciAdvancePaymentUsed.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciAdvancePaymentTotal
            // 
            this.lciAdvancePaymentTotal.Control = this.teAdvancePaymentTotal;
            this.lciAdvancePaymentTotal.CustomizationFormText = "Avans Tutarı";
            this.lciAdvancePaymentTotal.Location = new System.Drawing.Point(166, 74);
            this.lciAdvancePaymentTotal.Name = "lciAdvancePaymentTotal";
            this.lciAdvancePaymentTotal.Size = new System.Drawing.Size(184, 24);
            this.lciAdvancePaymentTotal.Text = "Avans Tutarı";
            this.lciAdvancePaymentTotal.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciInvoiceTotal
            // 
            this.lciInvoiceTotal.Control = this.teInvoiceTotal;
            this.lciInvoiceTotal.CustomizationFormText = "Fatura Tutarı";
            this.lciInvoiceTotal.Location = new System.Drawing.Point(166, 50);
            this.lciInvoiceTotal.Name = "lciInvoiceTotal";
            this.lciInvoiceTotal.Size = new System.Drawing.Size(184, 24);
            this.lciInvoiceTotal.Text = "Fatura Tutarı";
            this.lciInvoiceTotal.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciProductTotal
            // 
            this.lciProductTotal.Control = this.teProductTotal;
            this.lciProductTotal.CustomizationFormText = "Toplam Tutar";
            this.lciProductTotal.Location = new System.Drawing.Point(166, 0);
            this.lciProductTotal.Name = "lciProductTotal";
            this.lciProductTotal.Size = new System.Drawing.Size(184, 24);
            this.lciProductTotal.Text = "Toplam Tutar";
            this.lciProductTotal.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciVATTotal
            // 
            this.lciVATTotal.Control = this.teVATTotal;
            this.lciVATTotal.CustomizationFormText = "KDV";
            this.lciVATTotal.Location = new System.Drawing.Point(166, 24);
            this.lciVATTotal.Name = "lciVATTotal";
            this.lciVATTotal.Size = new System.Drawing.Size(184, 26);
            this.lciVATTotal.Text = "KDV";
            this.lciVATTotal.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciPayment
            // 
            this.lciPayment.Control = this.tePayment;
            this.lciPayment.CustomizationFormText = "layoutControlItem14";
            this.lciPayment.Location = new System.Drawing.Point(166, 122);
            this.lciPayment.Name = "lciPayment";
            this.lciPayment.Size = new System.Drawing.Size(184, 24);
            this.lciPayment.Text = "Ödeme";
            this.lciPayment.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.cePayment;
            this.layoutControlItem13.CustomizationFormText = "layoutControlItem13";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(83, 24);
            this.layoutControlItem13.Text = "layoutControlItem13";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextToControlDistance = 0;
            this.layoutControlItem13.TextVisible = false;
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.CustomizationFormText = "emptySpaceItem10";
            this.emptySpaceItem10.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(166, 99);
            this.emptySpaceItem10.Text = "emptySpaceItem10";
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.ceAdvancePayment;
            this.layoutControlItem15.CustomizationFormText = "layoutControlItem15";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 99);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(166, 23);
            this.layoutControlItem15.Text = "layoutControlItem15";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextToControlDistance = 0;
            this.layoutControlItem15.TextVisible = false;
            // 
            // lciRemainingTotal
            // 
            this.lciRemainingTotal.Control = this.teRemainingTotal;
            this.lciRemainingTotal.CustomizationFormText = "Kalan";
            this.lciRemainingTotal.Location = new System.Drawing.Point(350, 146);
            this.lciRemainingTotal.Name = "lciRemainingTotal";
            this.lciRemainingTotal.Size = new System.Drawing.Size(169, 24);
            this.lciRemainingTotal.Text = "Kalan";
            this.lciRemainingTotal.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6";
            this.emptySpaceItem6.Location = new System.Drawing.Point(350, 122);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(169, 24);
            this.emptySpaceItem6.Text = "emptySpaceItem6";
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciPaymentType
            // 
            this.lciPaymentType.Control = this.luePaymentType;
            this.lciPaymentType.CustomizationFormText = "Ödeme Şekli";
            this.lciPaymentType.Location = new System.Drawing.Point(83, 122);
            this.lciPaymentType.Name = "lciPaymentType";
            this.lciPaymentType.Size = new System.Drawing.Size(83, 24);
            this.lciPaymentType.Text = "Ödeme Şekli";
            this.lciPaymentType.TextSize = new System.Drawing.Size(0, 0);
            this.lciPaymentType.TextToControlDistance = 0;
            this.lciPaymentType.TextVisible = false;
            // 
            // lciPOS
            // 
            this.lciPOS.Control = this.luePOS;
            this.lciPOS.CustomizationFormText = "POS";
            this.lciPOS.Location = new System.Drawing.Point(0, 146);
            this.lciPOS.Name = "lciPOS";
            this.lciPOS.Size = new System.Drawing.Size(166, 24);
            this.lciPOS.Text = "POS";
            this.lciPOS.TextSize = new System.Drawing.Size(77, 13);
            // 
            // lciAdvancePaymentRemaining
            // 
            this.lciAdvancePaymentRemaining.Control = this.teAdvancePaymentRemaining;
            this.lciAdvancePaymentRemaining.CustomizationFormText = "Birikmiş Avans";
            this.lciAdvancePaymentRemaining.Location = new System.Drawing.Point(350, 50);
            this.lciAdvancePaymentRemaining.Name = "lciAdvancePaymentRemaining";
            this.lciAdvancePaymentRemaining.Size = new System.Drawing.Size(169, 72);
            this.lciAdvancePaymentRemaining.Text = "Birikmiş Avans";
            this.lciAdvancePaymentRemaining.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbInvoice;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(350, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(169, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.CustomizationFormText = "emptySpaceItem7";
            this.emptySpaceItem7.Location = new System.Drawing.Point(350, 0);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(169, 24);
            this.emptySpaceItem7.Text = "emptySpaceItem7";
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.lueVAT;
            this.layoutControlItem11.CustomizationFormText = "KDV";
            this.layoutControlItem11.Location = new System.Drawing.Point(97, 537);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(151, 24);
            this.layoutControlItem11.Text = "KDV";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.ceSelectAll;
            this.layoutControlItem12.CustomizationFormText = "layoutControlItem12";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 537);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(97, 24);
            this.layoutControlItem12.Text = "layoutControlItem12";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextToControlDistance = 0;
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.tePatientVisitDetailTotal;
            this.layoutControlItem10.CustomizationFormText = "Toplam";
            this.layoutControlItem10.Location = new System.Drawing.Point(248, 537);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(162, 24);
            this.layoutControlItem10.Text = "Toplam";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.CustomizationFormText = "emptySpaceItem8";
            this.emptySpaceItem8.Location = new System.Drawing.Point(410, 537);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(538, 24);
            this.emptySpaceItem8.Text = "emptySpaceItem8";
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbVoucher;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(765, 378);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(183, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // lciVoucherNo
            // 
            this.lciVoucherNo.Control = this.teVoucherNo;
            this.lciVoucherNo.CustomizationFormText = "Makbuz No";
            this.lciVoucherNo.Location = new System.Drawing.Point(584, 378);
            this.lciVoucherNo.Name = "lciVoucherNo";
            this.lciVoucherNo.Size = new System.Drawing.Size(181, 26);
            this.lciVoucherNo.Text = "Makbuz No";
            this.lciVoucherNo.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.CustomizationFormText = "emptySpaceItem9";
            this.emptySpaceItem9.Location = new System.Drawing.Point(405, 378);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(179, 26);
            this.emptySpaceItem9.Text = "emptySpaceItem9";
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // InvoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "InvoiceControl";
            this.Size = new System.Drawing.Size(956, 595);
            this.Load += new System.EventHandler(this.InvoiceControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePOS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAdvancePayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePatientVisitDetailTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teVATTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGrandTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRemainingTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAdvancePaymentRemaining.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAdvancePaymentUsed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAdvancePaymentTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInvoiceTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExitDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExitDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCardDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCardDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTaxNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTaxOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meInvoiceAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAdvancePayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdvancePayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisitDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisitDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoiceNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTaxOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTaxNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExitDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCardDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoiceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrandTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdvancePaymentUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdvancePaymentTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoiceTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProductTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVATTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemainingTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdvancePaymentRemaining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton sbInvoice;
        private DevExpress.XtraEditors.SimpleButton sbVoucher;
        private DevExpress.XtraGrid.GridControl gcPatientVisits;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatientVisits;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton sbRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraGrid.GridControl gcPatientVisitDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatientVisitDetails;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailComment;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailCount;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailPatientTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colVisitNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExitDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.GridControl gcAdvancePayments;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAdvancePayments;
        private DevExpress.XtraGrid.Columns.GridColumn colAdvancePaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAdvancePaymentAmount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.LookUpEdit luePaymentType;
        private DevExpress.XtraEditors.TextEdit teGrandTotal;
        private DevExpress.XtraEditors.TextEdit teRemainingTotal;
        private DevExpress.XtraEditors.TextEdit teAdvancePaymentRemaining;
        private DevExpress.XtraEditors.TextEdit teAdvancePaymentUsed;
        private DevExpress.XtraEditors.TextEdit teAdvancePaymentTotal;
        private DevExpress.XtraEditors.TextEdit teInvoiceTotal;
        private DevExpress.XtraEditors.DateEdit deExitDate;
        private DevExpress.XtraEditors.DateEdit deCardDate;
        private DevExpress.XtraEditors.DateEdit deInvoiceDate;
        private DevExpress.XtraEditors.TextEdit teTaxNo;
        private DevExpress.XtraEditors.TextEdit teTaxOffice;
        private DevExpress.XtraEditors.TextEdit teInvoiceNo;
        private DevExpress.XtraEditors.MemoEdit meInvoiceAddress;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem lciInvoiceNo;
        private DevExpress.XtraLayout.LayoutControlItem lciTaxOffice;
        private DevExpress.XtraLayout.LayoutControlItem lciTaxNo;
        private DevExpress.XtraLayout.LayoutControlItem lciExitDate;
        private DevExpress.XtraLayout.LayoutControlItem lciCardDate;
        private DevExpress.XtraLayout.LayoutControlItem lciInvoiceDate;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem lciGrandTotal;
        private DevExpress.XtraLayout.LayoutControlItem lciPaymentType;
        private DevExpress.XtraLayout.LayoutControlItem lciAdvancePaymentUsed;
        private DevExpress.XtraLayout.LayoutControlItem lciAdvancePaymentTotal;
        private DevExpress.XtraLayout.LayoutControlItem lciInvoiceTotal;
        private DevExpress.XtraLayout.LayoutControlItem lciAdvancePaymentRemaining;
        private DevExpress.XtraLayout.LayoutControlItem lciRemainingTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.CheckEdit ceAdvancePayment;
        private DevExpress.XtraEditors.TextEdit tePayment;
        private DevExpress.XtraEditors.TextEdit tePatientVisitDetailTotal;
        private DevExpress.XtraEditors.CheckEdit ceSelectAll;
        private DevExpress.XtraEditors.LookUpEdit lueVAT;
        private DevExpress.XtraEditors.TextEdit teVATTotal;
        private DevExpress.XtraEditors.CheckEdit cePayment;
        private DevExpress.XtraEditors.TextEdit teProductTotal;
        private DevExpress.XtraLayout.LayoutControlItem lciProductTotal;
        private DevExpress.XtraLayout.LayoutControlItem lciVATTotal;
        private DevExpress.XtraLayout.LayoutControlItem lciPayment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraGrid.Columns.GridColumn colPatientVisitDetailVisitNo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraEditors.LookUpEdit luePOS;
        private DevExpress.XtraLayout.LayoutControlItem lciPOS;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraEditors.TextEdit teVoucherNo;
        private DevExpress.XtraLayout.LayoutControlItem lciVoucherNo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
    }
}
