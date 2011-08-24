namespace Naz.Hastane.Win.MDIChildForms
{
    partial class DoctorPatientCallListForm
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition6 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbCall = new DevExpress.XtraEditors.SimpleButton();
            this.sbRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.sbPatientAbsent = new DevExpress.XtraEditors.SimpleButton();
            this.sbDoctorAbsent = new DevExpress.XtraEditors.SimpleButton();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbNextPatient = new DevExpress.XtraEditors.SimpleButton();
            this.gcPatients = new DevExpress.XtraGrid.GridControl();
            this.gvPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lstDoctors = new DevExpress.XtraEditors.ListBoxControl();
            this.sbResend = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDoctors = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPatients = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNextPatient = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDoctorAbsent = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciResend = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPatientAbsent = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRefresh = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCall = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNextPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorAbsent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientAbsent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCall)).BeginInit();
            this.SuspendLayout();
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Durum";
            this.colStatus.FieldName = "QueueStatusValue";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 4;
            this.colStatus.Width = 83;
            // 
            // colKurum
            // 
            this.colKurum.Caption = "Kurum";
            this.colKurum.FieldName = "PSG";
            this.colKurum.Name = "colKurum";
            this.colKurum.Visible = true;
            this.colKurum.VisibleIndex = 5;
            this.colKurum.Width = 155;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbCall);
            this.layoutControl1.Controls.Add(this.sbRefresh);
            this.layoutControl1.Controls.Add(this.deDate);
            this.layoutControl1.Controls.Add(this.sbPatientAbsent);
            this.layoutControl1.Controls.Add(this.sbDoctorAbsent);
            this.layoutControl1.Controls.Add(this.sbClose);
            this.layoutControl1.Controls.Add(this.sbNextPatient);
            this.layoutControl1.Controls.Add(this.gcPatients);
            this.layoutControl1.Controls.Add(this.lstDoctors);
            this.layoutControl1.Controls.Add(this.sbResend);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(932, 476);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sbCall
            // 
            this.sbCall.Location = new System.Drawing.Point(324, 442);
            this.sbCall.Name = "sbCall";
            this.sbCall.Size = new System.Drawing.Size(148, 22);
            this.sbCall.StyleController = this.layoutControl1;
            this.sbCall.TabIndex = 14;
            this.sbCall.Text = "Hasta Çağır";
            this.sbCall.Click += new System.EventHandler(this.sbCall_Click);
            // 
            // sbRefresh
            // 
            this.sbRefresh.Location = new System.Drawing.Point(175, 12);
            this.sbRefresh.Name = "sbRefresh";
            this.sbRefresh.Size = new System.Drawing.Size(109, 22);
            this.sbRefresh.StyleController = this.layoutControl1;
            this.sbRefresh.TabIndex = 13;
            this.sbRefresh.Text = "Yenile";
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.Location = new System.Drawing.Point(60, 12);
            this.deDate.Name = "deDate";
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDate.Size = new System.Drawing.Size(111, 20);
            this.deDate.StyleController = this.layoutControl1;
            this.deDate.TabIndex = 12;
            this.deDate.DateTimeChanged += new System.EventHandler(this.deDate_DateTimeChanged);
            // 
            // sbPatientAbsent
            // 
            this.sbPatientAbsent.Location = new System.Drawing.Point(178, 442);
            this.sbPatientAbsent.Name = "sbPatientAbsent";
            this.sbPatientAbsent.Size = new System.Drawing.Size(142, 22);
            this.sbPatientAbsent.StyleController = this.layoutControl1;
            this.sbPatientAbsent.TabIndex = 10;
            this.sbPatientAbsent.Text = "Hasta Gelmedi";
            this.sbPatientAbsent.Click += new System.EventHandler(this.sbPatientAbsent_Click);
            // 
            // sbDoctorAbsent
            // 
            this.sbDoctorAbsent.Location = new System.Drawing.Point(476, 442);
            this.sbDoctorAbsent.Name = "sbDoctorAbsent";
            this.sbDoctorAbsent.Size = new System.Drawing.Size(135, 22);
            this.sbDoctorAbsent.StyleController = this.layoutControl1;
            this.sbDoctorAbsent.TabIndex = 8;
            this.sbDoctorAbsent.Text = "Doktor İzinli";
            this.sbDoctorAbsent.Click += new System.EventHandler(this.sbDoctorAbsent_Click);
            // 
            // sbClose
            // 
            this.sbClose.Location = new System.Drawing.Point(783, 442);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(137, 22);
            this.sbClose.StyleController = this.layoutControl1;
            this.sbClose.TabIndex = 7;
            this.sbClose.Text = "Kapat";
            this.sbClose.Click += new System.EventHandler(this.sbClose_Click);
            // 
            // sbNextPatient
            // 
            this.sbNextPatient.Location = new System.Drawing.Point(12, 442);
            this.sbNextPatient.Name = "sbNextPatient";
            this.sbNextPatient.Size = new System.Drawing.Size(162, 22);
            this.sbNextPatient.StyleController = this.layoutControl1;
            this.sbNextPatient.TabIndex = 6;
            this.sbNextPatient.Text = "Sonraki Hasta >>";
            this.sbNextPatient.Click += new System.EventHandler(this.sbNextPatient_Click);
            // 
            // gcPatients
            // 
            this.gcPatients.Location = new System.Drawing.Point(288, 28);
            this.gcPatients.MainView = this.gvPatients;
            this.gcPatients.Name = "gcPatients";
            this.gcPatients.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit1});
            this.gcPatients.Size = new System.Drawing.Size(632, 410);
            this.gcPatients.TabIndex = 5;
            this.gcPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatients});
            // 
            // gvPatients
            // 
            this.gvPatients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn6,
            this.gridColumn2,
            this.gridColumn3,
            this.colKurum,
            this.colStatus});
            this.gvPatients.CustomizationFormBounds = new System.Drawing.Rectangle(1150, 101, 216, 178);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "Sırada";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.SlateGray;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Column = this.colStatus;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "Bitti";
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.Column = this.colStatus;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = "Gelmedi";
            styleFormatCondition4.Appearance.BackColor = System.Drawing.Color.White;
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            styleFormatCondition4.Appearance.Options.UseBackColor = true;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.ApplyToRow = true;
            styleFormatCondition4.Column = this.colStatus;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition4.Value1 = "İçeride";
            styleFormatCondition5.Appearance.BackColor = System.Drawing.Color.Yellow;
            styleFormatCondition5.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            styleFormatCondition5.Appearance.Options.UseBackColor = true;
            styleFormatCondition5.Appearance.Options.UseForeColor = true;
            styleFormatCondition5.Column = this.colKurum;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition5.Value1 = "SGK";
            styleFormatCondition6.Appearance.BackColor = System.Drawing.Color.Blue;
            styleFormatCondition6.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            styleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition6.Appearance.Options.UseBackColor = true;
            styleFormatCondition6.Appearance.Options.UseForeColor = true;
            styleFormatCondition6.Column = this.colKurum;
            styleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            styleFormatCondition6.Value1 = "SGK";
            this.gvPatients.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4,
            styleFormatCondition5,
            styleFormatCondition6});
            this.gvPatients.GridControl = this.gcPatients;
            this.gvPatients.Name = "gvPatients";
            this.gvPatients.OptionsBehavior.Editable = false;
            this.gvPatients.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sıra No";
            this.gridColumn1.FieldName = "QueueNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 46;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Protokol";
            this.gridColumn6.FieldName = "PatientVisit.Patient.PatientNo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 64;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Adı";
            this.gridColumn2.FieldName = "Patient.FirstName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 127;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Soyadı";
            this.gridColumn3.FieldName = "Patient.LastName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 139;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // lstDoctors
            // 
            this.lstDoctors.DisplayMember = "Value";
            this.lstDoctors.Location = new System.Drawing.Point(12, 54);
            this.lstDoctors.Name = "lstDoctors";
            this.lstDoctors.Size = new System.Drawing.Size(272, 384);
            this.lstDoctors.StyleController = this.layoutControl1;
            this.lstDoctors.TabIndex = 4;
            this.lstDoctors.Click += new System.EventHandler(this.lstDoctors_Click);
            // 
            // sbResend
            // 
            this.sbResend.Location = new System.Drawing.Point(615, 442);
            this.sbResend.Name = "sbResend";
            this.sbResend.Size = new System.Drawing.Size(164, 22);
            this.sbResend.StyleController = this.layoutControl1;
            this.sbResend.TabIndex = 9;
            this.sbResend.Text = "Tekrar Gönder";
            this.sbResend.Click += new System.EventHandler(this.sbResend_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDoctors,
            this.lciPatients,
            this.lciNextPatient,
            this.lciClose,
            this.lciDoctorAbsent,
            this.lciResend,
            this.lciPatientAbsent,
            this.lciDate,
            this.lciRefresh,
            this.lciCall});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(932, 476);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciDoctors
            // 
            this.lciDoctors.Control = this.lstDoctors;
            this.lciDoctors.CustomizationFormText = "Doktorlar";
            this.lciDoctors.Location = new System.Drawing.Point(0, 26);
            this.lciDoctors.Name = "lciDoctors";
            this.lciDoctors.Size = new System.Drawing.Size(276, 404);
            this.lciDoctors.Text = "Doktorlar";
            this.lciDoctors.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciDoctors.TextSize = new System.Drawing.Size(44, 13);
            // 
            // lciPatients
            // 
            this.lciPatients.Control = this.gcPatients;
            this.lciPatients.CustomizationFormText = "Hastalar";
            this.lciPatients.Location = new System.Drawing.Point(276, 0);
            this.lciPatients.Name = "lciPatients";
            this.lciPatients.Size = new System.Drawing.Size(636, 430);
            this.lciPatients.Text = "Hastalar";
            this.lciPatients.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciPatients.TextSize = new System.Drawing.Size(44, 13);
            // 
            // lciNextPatient
            // 
            this.lciNextPatient.Control = this.sbNextPatient;
            this.lciNextPatient.CustomizationFormText = "lciNextPatient";
            this.lciNextPatient.Location = new System.Drawing.Point(0, 430);
            this.lciNextPatient.Name = "lciNextPatient";
            this.lciNextPatient.Size = new System.Drawing.Size(166, 26);
            this.lciNextPatient.Text = "lciNextPatient";
            this.lciNextPatient.TextSize = new System.Drawing.Size(0, 0);
            this.lciNextPatient.TextToControlDistance = 0;
            this.lciNextPatient.TextVisible = false;
            // 
            // lciClose
            // 
            this.lciClose.Control = this.sbClose;
            this.lciClose.CustomizationFormText = "lciClose";
            this.lciClose.Location = new System.Drawing.Point(771, 430);
            this.lciClose.Name = "lciClose";
            this.lciClose.Size = new System.Drawing.Size(141, 26);
            this.lciClose.Text = "lciClose";
            this.lciClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciClose.TextToControlDistance = 0;
            this.lciClose.TextVisible = false;
            // 
            // lciDoctorAbsent
            // 
            this.lciDoctorAbsent.Control = this.sbDoctorAbsent;
            this.lciDoctorAbsent.CustomizationFormText = "lciDoctorAbsent";
            this.lciDoctorAbsent.Location = new System.Drawing.Point(464, 430);
            this.lciDoctorAbsent.Name = "lciDoctorAbsent";
            this.lciDoctorAbsent.Size = new System.Drawing.Size(139, 26);
            this.lciDoctorAbsent.Text = "lciDoctorAbsent";
            this.lciDoctorAbsent.TextSize = new System.Drawing.Size(0, 0);
            this.lciDoctorAbsent.TextToControlDistance = 0;
            this.lciDoctorAbsent.TextVisible = false;
            // 
            // lciResend
            // 
            this.lciResend.Control = this.sbResend;
            this.lciResend.CustomizationFormText = "lciResend";
            this.lciResend.Location = new System.Drawing.Point(603, 430);
            this.lciResend.Name = "lciResend";
            this.lciResend.Size = new System.Drawing.Size(168, 26);
            this.lciResend.Text = "lciResend";
            this.lciResend.TextSize = new System.Drawing.Size(0, 0);
            this.lciResend.TextToControlDistance = 0;
            this.lciResend.TextVisible = false;
            // 
            // lciPatientAbsent
            // 
            this.lciPatientAbsent.Control = this.sbPatientAbsent;
            this.lciPatientAbsent.CustomizationFormText = "lciPatientAbsent";
            this.lciPatientAbsent.Location = new System.Drawing.Point(166, 430);
            this.lciPatientAbsent.Name = "lciPatientAbsent";
            this.lciPatientAbsent.Size = new System.Drawing.Size(146, 26);
            this.lciPatientAbsent.Text = "lciPatientAbsent";
            this.lciPatientAbsent.TextSize = new System.Drawing.Size(0, 0);
            this.lciPatientAbsent.TextToControlDistance = 0;
            this.lciPatientAbsent.TextVisible = false;
            // 
            // lciDate
            // 
            this.lciDate.Control = this.deDate;
            this.lciDate.CustomizationFormText = "Tarih";
            this.lciDate.Location = new System.Drawing.Point(0, 0);
            this.lciDate.Name = "lciDate";
            this.lciDate.Size = new System.Drawing.Size(163, 26);
            this.lciDate.Text = "Tarih";
            this.lciDate.TextSize = new System.Drawing.Size(44, 13);
            // 
            // lciRefresh
            // 
            this.lciRefresh.Control = this.sbRefresh;
            this.lciRefresh.CustomizationFormText = "lciRefresh";
            this.lciRefresh.Location = new System.Drawing.Point(163, 0);
            this.lciRefresh.Name = "lciRefresh";
            this.lciRefresh.Size = new System.Drawing.Size(113, 26);
            this.lciRefresh.Text = "lciRefresh";
            this.lciRefresh.TextSize = new System.Drawing.Size(0, 0);
            this.lciRefresh.TextToControlDistance = 0;
            this.lciRefresh.TextVisible = false;
            // 
            // lciCall
            // 
            this.lciCall.Control = this.sbCall;
            this.lciCall.CustomizationFormText = "lciCall";
            this.lciCall.Location = new System.Drawing.Point(312, 430);
            this.lciCall.Name = "lciCall";
            this.lciCall.Size = new System.Drawing.Size(152, 26);
            this.lciCall.Text = "lciCall";
            this.lciCall.TextSize = new System.Drawing.Size(0, 0);
            this.lciCall.TextToControlDistance = 0;
            this.lciCall.TextVisible = false;
            // 
            // DoctorPatientCallListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 476);
            this.Controls.Add(this.layoutControl1);
            this.Name = "DoctorPatientCallListForm";
            this.Text = "DoctorCallListForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNextPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDoctorAbsent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPatientAbsent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton sbPatientAbsent;
        private DevExpress.XtraEditors.SimpleButton sbDoctorAbsent;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraEditors.SimpleButton sbNextPatient;
        private DevExpress.XtraGrid.GridControl gcPatients;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatients;
        private DevExpress.XtraEditors.ListBoxControl lstDoctors;
        private DevExpress.XtraEditors.SimpleButton sbResend;
        private DevExpress.XtraLayout.LayoutControlItem lciDoctors;
        private DevExpress.XtraLayout.LayoutControlItem lciPatients;
        private DevExpress.XtraLayout.LayoutControlItem lciNextPatient;
        private DevExpress.XtraLayout.LayoutControlItem lciClose;
        private DevExpress.XtraLayout.LayoutControlItem lciDoctorAbsent;
        private DevExpress.XtraLayout.LayoutControlItem lciResend;
        private DevExpress.XtraLayout.LayoutControlItem lciPatientAbsent;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.DateEdit deDate;
        private DevExpress.XtraLayout.LayoutControlItem lciDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton sbRefresh;
        private DevExpress.XtraLayout.LayoutControlItem lciRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colKurum;
        private DevExpress.XtraEditors.SimpleButton sbCall;
        private DevExpress.XtraLayout.LayoutControlItem lciCall;
    }
}