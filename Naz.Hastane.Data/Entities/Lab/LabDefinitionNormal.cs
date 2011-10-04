
namespace Naz.Hastane.Data.Entities 
{
    public class LabDefinitionNormal 
    {
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual int IND { get; set; }
        public virtual string CINSIYET { get; set; }

        public virtual System.Nullable<int> SIRA { get; set; }
        public virtual string DMY { get; set; }
        public virtual System.Nullable<int> DMY1 { get; set; }
        public virtual System.Nullable<int> DMY2 { get; set; }
        public virtual string NORMAL1 { get; set; }
        public virtual string NORMAL2 { get; set; }
        public virtual string ACIKLAMA { get; set; }
        public virtual string PANIK1 { get; set; }
        public virtual string PANIK2 { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            LabDefinitionNormal lb = obj as LabDefinitionNormal;
            if (lb == null)
                return false;
            if (this.TANIM == lb.TANIM && this.GRUP == lb.GRUP && this.CODE == lb.CODE && this.IND == lb.IND && this.CINSIYET == lb.CINSIYET)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.TANIM ? 0 : this.TANIM.GetHashCode());
            hash += (null == this.GRUP ? 0 : this.GRUP.GetHashCode());
            hash += (null == this.CODE ? 0 : this.CODE.GetHashCode());
            hash += this.IND.GetHashCode();
            hash += (null == this.CINSIYET ? 0 : this.CINSIYET.GetHashCode());

            return hash;
        }

    }
}
