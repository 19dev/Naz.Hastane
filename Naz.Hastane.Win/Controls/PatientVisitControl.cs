using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Naz.Hastane.Data.Entities;

namespace Naz.Hastane.Win.Controls
{
    public partial class PatientVisitControl : DevExpress.XtraEditors.XtraUserControl
    {
        public event System.EventHandler<EventArgs> PatientVisitClick;
        public event System.EventHandler<EventArgs> PatientVisitDoubleClick;
        public event System.EventHandler<EventArgs> PatientVisitDetailClick;
        
        public PatientVisitControl()
        {
            InitializeComponent();
        }

        private void gvPatientVisit_Click(object sender, EventArgs e)
        {
            if (PatientVisitClick != null)
                PatientVisitClick(sender, e);
        }

        private void gvPatientVisit_DoubleClick(object sender, EventArgs e)
        {
            if (PatientVisitDoubleClick != null)
                PatientVisitDoubleClick(sender, e);
        }

        private void gvPatientVisitDetail_Click(object sender, EventArgs e)
        {
            if (PatientVisitDetailClick != null)
                PatientVisitDetailClick(sender, e);
        }

        #region GridBindings
        private void gvPatientVisit_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            PatientVisit pv = (PatientVisit)gvPatientVisit.GetRow(e.RowHandle);
            if (e.RelationIndex == 0)
                e.IsEmpty = pv.PatientVisitDetails.Count == 0;
            else
                e.IsEmpty = pv.PatientVisitRecords.Count == 0;
        }

        private void gvPatientVisit_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 2;
        }

        private void gvPatientVisit_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            if (e.RelationIndex == 0)
                e.RelationName = "PatientVisitDetails";
            else
                e.RelationName = "PatientVisitRecords";
        }

        private void gvPatientVisit_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            PatientVisit pv = (PatientVisit)gvPatientVisit.GetRow(e.RowHandle);
            if (e.RelationIndex == 0)
                e.ChildList = new BindingSource(pv, "PatientVisitDetails");
            else
                e.ChildList = new BindingSource(pv, "PatientVisitRecords");

        }

        private void gvPatientVisit_MasterRowGetLevelDefaultView(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs e)
        {
            if (e.RelationIndex == 0)
                e.DefaultView = gvPatientVisitDetail;
            else
                e.DefaultView = gvPatientVisitRecord;
        }

        private void gvPatientVisit_MasterRowGetRelationDisplayCaption(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            if (e.RelationIndex == 0)
                e.RelationName = "İşlemler";
            else
                e.RelationName = "Kayıtlar";
        }

        #endregion

    }
}
