using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace Naz.Reports
{
    public partial class XpoBaseReport : DevExpress.XtraReports.UI.XtraReport
    {
        public XpoBaseReport()
        {
            InitializeComponent();
        }

        public XpoBaseReport(Session session)
            : this()
        {
            _XpoSession = session;
        }

        private void CreateDataSource()
        {
            if (XpoSession != null)
            {
                Type xpoType = Type.GetType(XpoClassName, true);
                this.DataSource = new XPCollection(XpoSession, XpoSession.GetClassInfo(xpoType));
            }
        }

        private Session _XpoSession;
        [Browsable(false)]
        public Session XpoSession
        {
            get
            {
                return _XpoSession;
            }
            set
            {
                this._XpoSession = value;
                this.CreateDataSource();
            }
        }

        [Browsable(false)]
        public XPBaseCollection Collection
        {
            get
            {
                return this.DataSource as XPBaseCollection;
            }
        }

        private string _XpoClassName;
        public string XpoClassName
        {
            get { return _XpoClassName; }
            set
            {
                if (this._XpoClassName != value)
                {
                    this._XpoClassName = value;
                    this.CreateDataSource();
                }
            }
        }

        protected override void SerializeProperties(DevExpress.XtraReports.Serialization.XRSerializer serializer)
        {
            base.SerializeProperties(serializer);
            serializer.SerializeString("XpoClassName", this.XpoClassName);
        }
        protected override void DeserializeProperties(DevExpress.XtraReports.Serialization.XRSerializer serializer)
        {
            base.DeserializeProperties(serializer);
            this.XpoClassName = serializer.DeserializeString("XpoClassName", "");
        }
    }
}
