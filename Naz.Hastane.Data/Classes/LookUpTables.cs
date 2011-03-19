using System;
using DevExpress.Xpo;

namespace Naz.Hastane.Data.Classes
{
    public struct KeydatKey
    {
        [Persistent("SLK"), Size(2)]
        public string SLK;
        [Persistent("SLB"), Size(10)]
        public string SLB;
    }

    [Persistent("KEYDAT"), OptimisticLocking(false)]
    public class Keydat : XPBaseObject
    {
        KeydatKey fID;
        [Persistent]
        [Key(true)]
        public KeydatKey ID
        {
            get { return fID; }
            set { SetPropertyValue<KeydatKey>("ID", ref fID, value); }
        }
        string fSLT;
        [Size(150)]
        public string SLT
        {
            get { return fSLT; }
            set { SetPropertyValue<string>("SLT", ref fSLT, value); }
        }
        double fSLX;
        public double SLX
        {
            get { return fSLX; }
            set { SetPropertyValue<double>("SLX", ref fSLX, value); }
        }
        double fSLY;
        public double SLY
        {
            get { return fSLY; }
            set { SetPropertyValue<double>("SLY", ref fSLY, value); }
        }
        double fSLZ;
        public double SLZ
        {
            get { return fSLZ; }
            set { SetPropertyValue<double>("SLZ", ref fSLZ, value); }
        }
        string fSLVV;
        public string SLVV
        {
            get { return fSLVV; }
            set { SetPropertyValue<string>("SLVV", ref fSLVV, value); }
        }
        string fSLXX;
        public string SLXX
        {
            get { return fSLXX; }
            set { SetPropertyValue<string>("SLXX", ref fSLXX, value); }
        }
        string fSLYY;
        public string SLYY
        {
            get { return fSLYY; }
            set { SetPropertyValue<string>("SLYY", ref fSLYY, value); }
        }
        string fSLZZ;
        public string SLZZ
        {
            get { return fSLZZ; }
            set { SetPropertyValue<string>("SLZZ", ref fSLZZ, value); }
        }
        string fSLXA;
        [Size(20)]
        public string SLXA
        {
            get { return fSLXA; }
            set { SetPropertyValue<string>("SLXA", ref fSLXA, value); }
        }
        string fSLYA;
        [Size(53)]
        public string SLYA
        {
            get { return fSLYA; }
            set { SetPropertyValue<string>("SLYA", ref fSLYA, value); }
        }
        string fSLXB;
        [Size(10)]
        public string SLXB
        {
            get { return fSLXB; }
            set { SetPropertyValue<string>("SLXB", ref fSLXB, value); }
        }
        bool fSEC;
        public bool SEC
        {
            get { return fSEC; }
            set { SetPropertyValue<bool>("SEC", ref fSEC, value); }
        }
        int flngAnaIslemID;
        public int lngAnaIslemID
        {
            get { return flngAnaIslemID; }
            set { SetPropertyValue<int>("lngAnaIslemID", ref flngAnaIslemID, value); }
        }
        int flngDoktorServisTipiID;
        public int lngDoktorServisTipiID
        {
            get { return flngDoktorServisTipiID; }
            set { SetPropertyValue<int>("lngDoktorServisTipiID", ref flngDoktorServisTipiID, value); }
        }
        string fServis;
        [Size(50)]
        public string Servis
        {
            get { return fServis; }
            set { SetPropertyValue<string>("Servis", ref fServis, value); }
        }
        string fSekreter;
        [Size(50)]
        public string Sekreter
        {
            get { return fSekreter; }
            set { SetPropertyValue<string>("Sekreter", ref fSekreter, value); }
        }
        string fSLBEk;
        [Size(10)]
        public string SLBEk
        {
            get { return fSLBEk; }
            set { SetPropertyValue<string>("SLBEk", ref fSLBEk, value); }
        }
        public Keydat(Session session) : base(session) { }
        public Keydat() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    // SLK='00'
    [Persistent("tlkpvGenelParametreler"), OptimisticLocking(false)]
    public class GenelParametreler : XPBaseObject
    {
        [Persistent("SLK"), Size(2)]
        string slk = "00";
        [PersistentAlias("slk")]
        public string SLK
        {
            get { return slk; }
        }

        string fID;
        [Key(AutoGenerate = false), Persistent("SLB"), Size(10)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }

        string fAciklama;
        [Persistent("SLT"), Size(150)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }

        public GenelParametreler(Session session) : base(session) { }
        public GenelParametreler() : base(Session.DefaultSession) {}
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    // SLK='01'
    [Persistent("tlkpvHizmetGrubu"), OptimisticLocking(false)]
    public class HizmetGrubu : XPBaseObject
    {
        [Persistent("SLK"), Size(2)]
        string slk = "01";
        [PersistentAlias("slk")]
        public string SLK
        {
            get { return slk; }
        }

        string fID;
        [Key(AutoGenerate = false), Persistent("SLB"), Size(10)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }

        string fAciklama;
        [Persistent("SLT"), Size(150)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }

        public HizmetGrubu(Session session) : base(session) { }
        public HizmetGrubu() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    // SLK='07'
    [Persistent("tlkpvDoktor"), OptimisticLocking(false)]
    public class Doktor : XPBaseObject
    {
        [Persistent("SLK"), Size(2)]
        string slk="07";
        [PersistentAlias("slk")]
        public string SLK
        {
            get { return slk; }
        }

        string fID;
        [Key(AutoGenerate = false), Persistent("SLB"), Size(10)]
        public string ID
        {
            get { return fID;  }
            set { SetPropertyValue<string>("ID", ref fID, value);  }
        }

        string fAciklama;
        [Persistent("SLT"), Size(150)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }

        public Doktor(Session session) : base(session) {}
        public Doktor() : base(Session.DefaultSession) {}
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    // SLK='10'
    [Persistent("tlkpvYakinlikDurumu"), OptimisticLocking(false)]
    public class YakinlikDurumu : XPBaseObject
    {
        [Persistent("SLK"), Size(2)]
        string slk = "10";
        [PersistentAlias("slk")]
        public string SLK
        {
            get { return slk; }
        }

        string fID;
        [Key(AutoGenerate = false), Persistent("SLB"), Size(10)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }

        string fAciklama;
        [Persistent("SLT"), Size(150)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }

        public YakinlikDurumu(Session session) : base(session) { }
        public YakinlikDurumu() : base(Session.DefaultSession) {}
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    // SLK='15'
    [Persistent("tlkpvFiyatListesiAdi"), OptimisticLocking(false)]
    public class FiyatListesiAdi : XPBaseObject
    {
        [Persistent("SLK"), Size(2)]
        string slk = "15";
        [PersistentAlias("slk")]
        public string SLK
        {
            get { return slk; }
        }

        string fID;
        [Key(AutoGenerate = false), Persistent("SLB"), Size(10)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }

        string fAciklama;
        [Persistent("SLT"), Size(150)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }

        public FiyatListesiAdi(Session session) : base(session) { }
        public FiyatListesiAdi() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    // SLK='17'
    [Persistent("tlkpvServis"), OptimisticLocking(false)]
    public class Servis : XPBaseObject
    {
        [Persistent("SLK"), Size(2)]
        string slk = "17";
        [PersistentAlias("slk")]
        public string SLK
        {
            get { return slk; }
        }

        string fID;
        [Key(AutoGenerate = false), Persistent("SLB"), Size(10)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }

        string fAciklama;
        [Persistent("SLT"), Size(150)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }

        public Servis(Session session) : base(session) { }
        public Servis() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    // SLK='30'
    [Persistent("tlkpvAltHizmetGrubu"), OptimisticLocking(false)]
    public class AltHizmetGrubu : XPBaseObject
    {
        [Persistent("SLK"), Size(2)]
        string slk = "30";
        [PersistentAlias("slk")]
        public string SLK
        {
            get { return slk; }
        }

        string fID;
        [Key(AutoGenerate = false), Persistent("SLB"), Size(10)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }

        string fAciklama;
        [Persistent("SLT"), Size(150)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }

        public AltHizmetGrubu(Session session) : base(session) { }
        public AltHizmetGrubu() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    // SLK='36'
    [Persistent("tlkpvKurumTipi"), OptimisticLocking(false)]
    public class KurumTipi : XPBaseObject
    {
        [Persistent("SLK"), Size(2)]
        string slk = "36";
        [PersistentAlias("slk")]
        public string SLK
        {
            get { return slk; }
        }

        string fID;
        [Key(AutoGenerate = false), Persistent("SLB"), Size(10)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }

        string fAciklama;
        [Persistent("SLT"), Size(150)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }

        public KurumTipi(Session session) : base(session) { }
        public KurumTipi() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    // SLK='37'
    [Persistent("tlkpvIL"), OptimisticLocking(false)]
    public class IL : XPBaseObject
    {
        [Persistent("SLK"), Size(2)]
        string slk = "37";
        [PersistentAlias("slk")]
        public string SLK
        {
            get { return slk; }
        }

        string fID;
        [Key(AutoGenerate = false), Persistent("SLB"), Size(10)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }

        string fAciklama;
        [Persistent("SLT"), Size(150)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }

        public IL(Session session) : base(session) { }
        public IL() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    // SLK='51'
    [Persistent("tlkpvUyruk"), OptimisticLocking(false)]
    public class Uyruk : XPBaseObject
    {
        [Persistent("SLK"), Size(2)]
        string slk = "51";
        [PersistentAlias("slk")]
        public string SLK
        {
            get { return slk; }
        }

        string fID;
        [Key(AutoGenerate = false), Persistent("SLB"), Size(10)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }

        string fAciklama;
        [Persistent("SLT"), Size(150)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }

        public Uyruk(Session session) : base(session) { }
        public Uyruk() : base(Session.DefaultSession) {}
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    // SLK='53'
    [Persistent("tlkpvPOS"), OptimisticLocking(false)]
    public class POS : XPBaseObject
    {
        [Persistent("SLK"), Size(2)]
        string slk = "53";
        [PersistentAlias("slk")]
        public string SLK
        {
            get { return slk; }
        }

        string fID;
        [Key(AutoGenerate = false), Persistent("SLB"), Size(10)]
        public string ID
        {
            get { return fID; }
            set { SetPropertyValue<string>("ID", ref fID, value); }
        }

        string fAciklama;
        [Persistent("SLT"), Size(150)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }

        public POS(Session session) : base(session) { }
        public POS() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    [Persistent("tlkpSigortaTuru")]
    public class SigortaTuru : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>("ID", ref fID, value); }
        }
        string fAciklama;
        [Size(20)]
        public string Aciklama
        {
            get { return fAciklama; }
            set { SetPropertyValue<string>("Aciklama", ref fAciklama, value); }
        }
        public SigortaTuru(Session session) : base(session) { }
        public SigortaTuru() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
