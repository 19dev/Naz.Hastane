using System;
using DevExpress.Xpo;
namespace TIPDATA
{

    //[NonPersistent]
    //public class a_YeniHastaZiyaretNo : PersistentBase
    //{
    //    int fInt32_column_0;
    //    public int Int32_column_0
    //    {
    //        get { return fInt32_column_0; }
    //        set { SetPropertyValue<int>("Int32_column_0", ref fInt32_column_0, value); }
    //    }
    //    public a_YeniHastaZiyaretNo(Session session) : base(session) { }
    //    public a_YeniHastaZiyaretNo() : base(Session.DefaultSession) { }
    //    public override void AfterConstruction() { base.AfterConstruction(); }
    //}

    //[NonPersistent]
    //public class a_YeniHastaZiyaretIslemNo : PersistentBase
    //{
    //    int fInt32_column_0;
    //    public int Int32_column_0
    //    {
    //        get { return fInt32_column_0; }
    //        set { SetPropertyValue<int>("Int32_column_0", ref fInt32_column_0, value); }
    //    }
    //    public a_YeniHastaZiyaretIslemNo(Session session) : base(session) { }
    //    public a_YeniHastaZiyaretIslemNo() : base(Session.DefaultSession) { }
    //    public override void AfterConstruction() { base.AfterConstruction(); }
    //}
    //public static class TIPDATASprocHelper
    //{

    //    public static DevExpress.Xpo.DB.SelectedData Execa_YeniHastaZiyaretNo(Session session, string HastaNo)
    //    {
    //        return session.ExecuteSproc("a_YeniHastaZiyaretNo", HastaNo);
    //    }

    //    public static System.Collections.Generic.ICollection<a_YeniHastaZiyaretNo> Execa_YeniHastaZiyaretNoIntoObjects(Session session, string HastaNo)
    //    {
    //        return session.GetObjectsFromSproc<a_YeniHastaZiyaretNo>("a_YeniHastaZiyaretNo", HastaNo);
    //    }

    //    public static XPDataView Execa_YeniHastaZiyaretNoIntoDataView(Session session, string HastaNo)
    //    {
    //        DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("a_YeniHastaZiyaretNo", HastaNo);
    //        return new XPDataView(session.Dictionary, session.GetClassInfo(typeof(a_YeniHastaZiyaretNo)), sprocData);
    //    }
    //    public static void Execa_YeniHastaZiyaretNoIntoDataView(XPDataView dataView, Session session, string HastaNo)
    //    {
    //        DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("a_YeniHastaZiyaretNo", HastaNo);
    //        dataView.PopulateProperties(session.GetClassInfo(typeof(a_YeniHastaZiyaretNo)));
    //        dataView.LoadData(sprocData);
    //    }

    //    public static DevExpress.Xpo.DB.SelectedData Execa_YeniHastaZiyaretIslemNo(Session session, string HastaNo, string ZiyaretNo)
    //    {
    //        return session.ExecuteSproc("a_YeniHastaZiyaretIslemNo", HastaNo, ZiyaretNo);
    //    }

    //    public static System.Collections.Generic.ICollection<a_YeniHastaZiyaretIslemNo> Execa_YeniHastaZiyaretIslemNoIntoObjects(Session session, string HastaNo, string ZiyaretNo)
    //    {
    //        return session.GetObjectsFromSproc<a_YeniHastaZiyaretIslemNo>("a_YeniHastaZiyaretIslemNo", HastaNo, ZiyaretNo);
    //    }

    //    public static XPDataView Execa_YeniHastaZiyaretIslemNoIntoDataView(Session session, string HastaNo, string ZiyaretNo)
    //    {
    //        DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("a_YeniHastaZiyaretIslemNo", HastaNo, ZiyaretNo);
    //        return new XPDataView(session.Dictionary, session.GetClassInfo(typeof(a_YeniHastaZiyaretIslemNo)), sprocData);
    //    }
    //    public static void Execa_YeniHastaZiyaretIslemNoIntoDataView(XPDataView dataView, Session session, string HastaNo, string ZiyaretNo)
    //    {
    //        DevExpress.Xpo.DB.SelectedData sprocData = session.ExecuteSproc("a_YeniHastaZiyaretIslemNo", HastaNo, ZiyaretNo);
    //        dataView.PopulateProperties(session.GetClassInfo(typeof(a_YeniHastaZiyaretIslemNo)));
    //        dataView.LoadData(sprocData);
    //    }
    //}


}
