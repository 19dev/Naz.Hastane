using System.Collections.Generic; 
using System.Text; 
using System; 


namespace Naz.Hastane.Data.Entities {
    
    public class OzetAYPAnaIslem {
        public OzetAYPAnaIslem() { }
        public virtual System.Nullable<long> RowNumber { get; set; }
        public virtual string Key1 { get; set; }
        public virtual string Key2 { get; set; }
        public virtual double AdetC { get; set; }
        public virtual double AdetP { get; set; }
        public virtual double AdetP1 { get; set; }
        public virtual System.Nullable<double> AdetY { get; set; }
        public virtual System.Nullable<double> AdetY1 { get; set; }
        public virtual int HastaC { get; set; }
        public virtual int HastaP { get; set; }
        public virtual int HastaP1 { get; set; }
        public virtual System.Nullable<double> HastaY { get; set; }
        public virtual System.Nullable<double> HastaY1 { get; set; }
        public virtual double ToplamC { get; set; }
        public virtual double ToplamP { get; set; }
        public virtual double ToplamP1 { get; set; }
        public virtual System.Nullable<double> ToplamY { get; set; }
        public virtual System.Nullable<double> ToplamY1 { get; set; }
        public virtual System.Nullable<double> KisiBasiC { get; set; }
        public virtual System.Nullable<double> KisiBasiP { get; set; }
        public virtual System.Nullable<double> KisiBasiP1 { get; set; }
        public virtual System.Nullable<double> KisiBasiY { get; set; }
        public virtual System.Nullable<double> KisiBasiY1 { get; set; }
        public virtual System.Nullable<double> IslemBasiC { get; set; }
        public virtual System.Nullable<double> IslemBasiP { get; set; }
        public virtual System.Nullable<double> IslemBasiP1 { get; set; }
        public virtual System.Nullable<double> IslemBasiY { get; set; }
        public virtual System.Nullable<double> IslemBasiY1 { get; set; }
    }
}
