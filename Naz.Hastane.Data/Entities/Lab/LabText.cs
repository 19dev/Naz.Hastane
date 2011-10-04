
namespace Naz.Hastane.Data.Entities 
{
    public class LabText
    {
        public virtual LabRequest LabRequest { get; set; }

        public virtual string LABTEXT { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            LabText lb = obj as LabText;
            if (lb == null)
                return false;
            if (this.LabRequest == lb.LabRequest)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash += (null == this.LabRequest ? 0 : this.LabRequest.GetHashCode());

            return hash;
        }

    }
}
