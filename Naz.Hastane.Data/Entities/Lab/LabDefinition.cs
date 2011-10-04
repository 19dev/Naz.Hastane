
namespace Naz.Hastane.Data.Entities 
{
    public class LabDefinition 
    {
        public virtual string TANIM { get; set; }
        public virtual string GRUP { get; set; }
        public virtual string CODE { get; set; }
        public virtual int IND { get; set; }

        public virtual string PARISMI { get; set; }
        public virtual string BIRIMI { get; set; }
        public virtual string ACIKLAMA { get; set; }
        public virtual string TEXT { get; set; }
        public virtual string MEDTAHLILKODU { get; set; }
        public virtual string MEDGONDER { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            LabDefinition lb = obj as LabDefinition;
            if (lb == null)
                return false;
            if (this.TANIM == lb.TANIM && this.GRUP == lb.GRUP && this.CODE == lb.CODE && this.IND == lb.IND)
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

            return hash;
        }

    }
}
