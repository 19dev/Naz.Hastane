namespace Naz.Hastane.Win.MDIChildForms
{
    partial class PrinterSettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbSave = new DevExpress.XtraEditors.SimpleButton();
            this.lueVoucherPrinterTray = new DevExpress.XtraEditors.LookUpEdit();
            this.lueVoucherPrinter = new DevExpress.XtraEditors.LookUpEdit();
            this.lueInvoicePrinterTray = new DevExpress.XtraEditors.LookUpEdit();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.lueInvoicePrinter = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciInvoicePrinter = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciInvoicePrinterTray = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciVoucherPrinter = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciVoucherPrinterTray = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueVoucherPrinterTray.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVoucherPrinter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoicePrinterTray.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoicePrinter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoicePrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoicePrinterTray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherPrinterTray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbSave);
            this.layoutControl1.Controls.Add(this.lueVoucherPrinterTray);
            this.layoutControl1.Controls.Add(this.lueVoucherPrinter);
            this.layoutControl1.Controls.Add(this.lueInvoicePrinterTray);
            this.layoutControl1.Controls.Add(this.sbClose);
            this.layoutControl1.Controls.Add(this.lueInvoicePrinter);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(460, 347);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbSave
            // 
            this.sbSave.Location = new System.Drawing.Point(370, 71);
            this.sbSave.Name = "sbSave";
            this.sbSave.Size = new System.Drawing.Size(78, 22);
            this.sbSave.StyleController = this.layoutControl1;
            this.sbSave.TabIndex = 8;
            this.sbSave.Text = "Sakla";
            this.sbSave.Click += new System.EventHandler(this.sbSave_Click);
            // 
            // lueVoucherPrinterTray
            // 
            this.lueVoucherPrinterTray.Location = new System.Drawing.Point(123, 84);
            this.lueVoucherPrinterTray.Name = "lueVoucherPrinterTray";
            this.lueVoucherPrinterTray.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueVoucherPrinterTray.Size = new System.Drawing.Size(243, 20);
            this.lueVoucherPrinterTray.StyleController = this.layoutControl1;
            this.lueVoucherPrinterTray.TabIndex = 7;
            // 
            // lueVoucherPrinter
            // 
            this.lueVoucherPrinter.Location = new System.Drawing.Point(123, 60);
            this.lueVoucherPrinter.Name = "lueVoucherPrinter";
            this.lueVoucherPrinter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueVoucherPrinter.Size = new System.Drawing.Size(243, 20);
            this.lueVoucherPrinter.StyleController = this.layoutControl1;
            this.lueVoucherPrinter.TabIndex = 6;
            this.lueVoucherPrinter.EditValueChanged += new System.EventHandler(this.lueVoucherPrinter_EditValueChanged);
            // 
            // lueInvoicePrinterTray
            // 
            this.lueInvoicePrinterTray.Location = new System.Drawing.Point(123, 36);
            this.lueInvoicePrinterTray.Name = "lueInvoicePrinterTray";
            this.lueInvoicePrinterTray.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInvoicePrinterTray.Size = new System.Drawing.Size(243, 20);
            this.lueInvoicePrinterTray.StyleController = this.layoutControl1;
            this.lueInvoicePrinterTray.TabIndex = 5;
            // 
            // sbClose
            // 
            this.sbClose.Location = new System.Drawing.Point(370, 152);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(78, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 9;
            this.sbClose.Text = "Kapat";
            // 
            // lueInvoicePrinter
            // 
            this.lueInvoicePrinter.Location = new System.Drawing.Point(123, 12);
            this.lueInvoicePrinter.Name = "lueInvoicePrinter";
            this.lueInvoicePrinter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInvoicePrinter.Size = new System.Drawing.Size(243, 20);
            this.lueInvoicePrinter.StyleController = this.layoutControl1;
            this.lueInvoicePrinter.TabIndex = 4;
            this.lueInvoicePrinter.EditValueChanged += new System.EventHandler(this.lueInvoicePrinter_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciInvoicePrinter,
            this.lciInvoicePrinterTray,
            this.lciVoucherPrinter,
            this.lciVoucherPrinterTray,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(460, 347);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciInvoicePrinter
            // 
            this.lciInvoicePrinter.Control = this.lueInvoicePrinter;
            this.lciInvoicePrinter.CustomizationFormText = "Fatura Yazıcısı";
            this.lciInvoicePrinter.Location = new System.Drawing.Point(0, 0);
            this.lciInvoicePrinter.Name = "lciInvoicePrinter";
            this.lciInvoicePrinter.Size = new System.Drawing.Size(358, 24);
            this.lciInvoicePrinter.Text = "Fatura Yazıcısı";
            this.lciInvoicePrinter.TextSize = new System.Drawing.Size(107, 13);
            // 
            // lciInvoicePrinterTray
            // 
            this.lciInvoicePrinterTray.Control = this.lueInvoicePrinterTray;
            this.lciInvoicePrinterTray.CustomizationFormText = "Fatura Yazıcısı Tepsisi";
            this.lciInvoicePrinterTray.Location = new System.Drawing.Point(0, 24);
            this.lciInvoicePrinterTray.Name = "lciInvoicePrinterTray";
            this.lciInvoicePrinterTray.Size = new System.Drawing.Size(358, 24);
            this.lciInvoicePrinterTray.Text = "Fatura Yazıcısı Tepsisi";
            this.lciInvoicePrinterTray.TextSize = new System.Drawing.Size(107, 13);
            // 
            // lciVoucherPrinter
            // 
            this.lciVoucherPrinter.Control = this.lueVoucherPrinter;
            this.lciVoucherPrinter.CustomizationFormText = "Makbuz Yazıcısı";
            this.lciVoucherPrinter.Location = new System.Drawing.Point(0, 48);
            this.lciVoucherPrinter.Name = "lciVoucherPrinter";
            this.lciVoucherPrinter.Size = new System.Drawing.Size(358, 24);
            this.lciVoucherPrinter.Text = "Makbuz Yazıcısı";
            this.lciVoucherPrinter.TextSize = new System.Drawing.Size(107, 13);
            // 
            // lciVoucherPrinterTray
            // 
            this.lciVoucherPrinterTray.Control = this.lueVoucherPrinterTray;
            this.lciVoucherPrinterTray.CustomizationFormText = "Makbuz Yazıcısı Tepsisi";
            this.lciVoucherPrinterTray.Location = new System.Drawing.Point(0, 72);
            this.lciVoucherPrinterTray.Name = "lciVoucherPrinterTray";
            this.lciVoucherPrinterTray.Size = new System.Drawing.Size(358, 255);
            this.lciVoucherPrinterTray.Text = "Makbuz Yazıcısı Tepsisi";
            this.lciVoucherPrinterTray.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbSave;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(358, 59);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(82, 26);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(358, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(82, 59);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbClose;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(358, 140);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(82, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(358, 166);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(82, 161);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(358, 85);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(82, 55);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PrinterSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 347);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PrinterSettingsForm";
            this.Text = "PrinterSettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueVoucherPrinterTray.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueVoucherPrinter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoicePrinterTray.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoicePrinter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoicePrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInvoicePrinterTray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVoucherPrinterTray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit lueVoucherPrinterTray;
        private DevExpress.XtraEditors.LookUpEdit lueVoucherPrinter;
        private DevExpress.XtraEditors.LookUpEdit lueInvoicePrinterTray;
        private DevExpress.XtraEditors.LookUpEdit lueInvoicePrinter;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciInvoicePrinter;
        private DevExpress.XtraLayout.LayoutControlItem lciInvoicePrinterTray;
        private DevExpress.XtraLayout.LayoutControlItem lciVoucherPrinter;
        private DevExpress.XtraLayout.LayoutControlItem lciVoucherPrinterTray;
        private DevExpress.XtraEditors.SimpleButton sbSave;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}