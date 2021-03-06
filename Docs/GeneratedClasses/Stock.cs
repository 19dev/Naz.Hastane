using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class Stock {
        public Stock() { }
        public virtual string AKOD { get; set; }
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual string NAME1 { get; set; }
        public virtual string NAME2 { get; set; }
        public virtual string UNITE { get; set; }
        public virtual string FIRMA { get; set; }
        public virtual double KDV { get; set; }
        public virtual double SATISF { get; set; }
        public virtual double ALISF { get; set; }
        public virtual System.Nullable<double> KSATISF { get; set; }
        public virtual System.Nullable<double> ASATISF { get; set; }
        public virtual System.Nullable<double> YSATISF { get; set; }
        public virtual double ORTALAMAF { get; set; }
        public virtual double TOPGIR { get; set; }
        public virtual double TOPCIK { get; set; }
        public virtual double MINIMUM { get; set; }
        public virtual double VERADET { get; set; }
        public virtual double TOPSAT { get; set; }
        public virtual double TOPALS { get; set; }
        public virtual System.Nullable<System.DateTime> SEVKDAT { get; set; }
        public virtual System.Nullable<System.DateTime> ENVDAT { get; set; }
        public virtual double DEVIR { get; set; }
        public virtual System.Nullable<System.DateTime> SKDAT { get; set; }
        public virtual string FAR_KOD { get; set; }
        public virtual string JEN_KOD { get; set; }
        public virtual double DOZAJ { get; set; }
        public virtual double KAR { get; set; }
        public virtual System.Nullable<double> DOVIZ { get; set; }
        public virtual string DOVIZCINSI { get; set; }
        public virtual string REUSE { get; set; }
        public virtual double INFIYAT { get; set; }
        public virtual double KOLI { get; set; }
        public virtual string DAHHAR { get; set; }
        public virtual string OZELF { get; set; }
        public virtual double GUNLUK { get; set; }
        public virtual string ILACKONTROL { get; set; }
        public virtual short ILACKONTROLSURE { get; set; }
        public virtual System.Nullable<double> KURUMINDIRIM { get; set; }
        public virtual System.Nullable<double> ESKIALISF { get; set; }
        public virtual string APILACSARF { get; set; }
        public virtual string PDAHIL { get; set; }
        public virtual string MALTURU { get; set; }
        public virtual string DETAYKOD { get; set; }
        public virtual System.Nullable<bool> mk { get; set; }
        public virtual System.Nullable<bool> SEC { get; set; }
        public virtual string ILACADET { get; set; }
        public virtual string MEDGONDER { get; set; }
        public virtual string MALDURUM { get; set; }
        public virtual string ILACTURU { get; set; }
        public virtual System.Nullable<double> KBIRIMI { get; set; }
        public virtual string JENKOD { get; set; }
        public virtual string ETKENMADDE { get; set; }
        public virtual string BIRIMCINS { get; set; }
        public virtual string RECTIPI { get; set; }
        public virtual string ILFIRMA { get; set; }
        public virtual string UBBCODE { get; set; }
        public virtual string KATKIPAYI { get; set; }
        public virtual string MEDONAY { get; set; }
        public virtual string MAKSIMUM { get; set; }
        public virtual string KHIZMET { get; set; }
        public virtual string KONTROLKODU { get; set; }
        public virtual System.Nullable<double> KRITIKMIKTAR { get; set; }
    }
}
