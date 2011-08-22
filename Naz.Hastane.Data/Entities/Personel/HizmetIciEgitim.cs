using System.Collections.Generic;
using System;
namespace Naz.Hastane.Data.Entities
{
    public class HizmetIciEgitim : IDBase
    {
        public virtual HizmetIciEgitimTipi HizmetIciEgitimTipi { get; set; }
        public virtual string HizmetIciEgitimTipiValue
        {
            get
            {
                if (HizmetIciEgitimTipi == null)
                    return String.Empty;
                else
                    return HizmetIciEgitimTipi.Value;
            }
        }
        public virtual DateTime? BaslangicTarihi { get; set; }
        public virtual DateTime? BitisTarihi { get; set; }
        public virtual string Aciklama { get; set; }
        public virtual string FullName
        {
            get { return String.Format("{0}-{1} {3}-{4}", HizmetIciEgitimTipiValue, Aciklama, BaslangicTarihi, BitisTarihi); }
            set {}
        }
        #region PersonelHizmetIciEgitim
        private IList<PersonelHizmetIciEgitim> _PersonelHizmetIciEgitims = new List<PersonelHizmetIciEgitim>();

        public virtual IList<PersonelHizmetIciEgitim> PersonelHizmetIciEgitims
        {
            get { return _PersonelHizmetIciEgitims; }
            set { _PersonelHizmetIciEgitims = value; }
        }

        public virtual void AddPersonelHizmetIciEgitim(PersonelHizmetIciEgitim pv)
        {
            this.PersonelHizmetIciEgitims.Insert(0, pv);
        }

        public virtual void RemovePersonelHizmetIciEgitim(PersonelHizmetIciEgitim pv)
        {
            _PersonelHizmetIciEgitims.Remove(pv);
        }
        #endregion
    }
}
