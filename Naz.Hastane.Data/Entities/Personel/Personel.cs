using System.Collections.Generic;
namespace Naz.Hastane.Data.Entities 
{
    public class Personel 
    {
        public virtual int ID { get; set; }
        public virtual string PersonelNo { get; set; }
        public virtual string Ad { get; set; }
        public virtual string Soyad { get; set; }
        public virtual string AdiSoyadi { get; set; }
        public virtual string TCID { get; set; }
        public virtual string BabaAdi { get; set; }
        public virtual string AnaAdi { get; set; }
        public virtual string DogumYeri { get; set; }
        public virtual string DogumTarihi { get; set; }
        public virtual string Uyrugu { get; set; }
        public virtual string KimlikTuru { get; set; }
        public virtual string KimlikNo { get; set; }
        public virtual string DogumIli { get; set; }
        public virtual string DogumIlcesi { get; set; }
        public virtual string DogumMahalleKoy { get; set; }
        public virtual string DogumCilt { get; set; }
        public virtual System.Nullable<int> DogumAileSiraNo { get; set; }
        public virtual string DogumSiraNo { get; set; }
        public virtual string Cinsiyeti { get; set; }
        public virtual string MedeniHali { get; set; }
        public virtual string Unvani { get; set; }
        public virtual string Bolumu { get; set; }
        public virtual string EvAdresi { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string EvTelefonu { get; set; }
        public virtual string CepTelefonu { get; set; }
        public virtual string Emekli { get; set; }
        public virtual string Sendikali { get; set; }
        public virtual string KanGrubu { get; set; }
        public virtual string IseGirisTarihi { get; set; }
        public virtual string SigortaNo { get; set; }
        public virtual string VergiNo { get; set; }
        public virtual string AyrilisTarihi { get; set; }
        public virtual string CalistigiBolum { get; set; }
        public virtual string Aciklama { get; set; }
        public virtual string Email { get; set; }
        public virtual string Mahalle { get; set; }
        public virtual string Ilce { get; set; }
        public virtual string Il { get; set; }

        #region PersonelEgitim
        private IList<PersonelEgitim> _PersonelEgitims = new List<PersonelEgitim>();

        public virtual IList<PersonelEgitim> PersonelEgitims
        {
            get { return _PersonelEgitims; }
            set { _PersonelEgitims = value; }
        }

        public virtual void AddPersonelEgitim(PersonelEgitim pv)
        {
            pv.Personel = this;
            this.PersonelEgitims.Insert(0, pv);
        }

        public virtual void RemovePersonelEgitim(PersonelEgitim pv)
        {
            _PersonelEgitims.Remove(pv);
        }

        # endregion
        #region PersonelHastaneBolumu
        private IList<PersonelHastaneBolumu> _PersonelHastaneBolumus = new List<PersonelHastaneBolumu>();

        public virtual IList<PersonelHastaneBolumu> PersonelHastaneBolumus
        {
            get { return _PersonelHastaneBolumus; }
            set { _PersonelHastaneBolumus = value; }
        }

        public virtual void AddPersonelHastaneBolumu(PersonelHastaneBolumu pv)
        {
            pv.Personel = this;
            this.PersonelHastaneBolumus.Insert(0, pv);
        }

        public virtual void RemovePersonelHastaneBolumu(PersonelHastaneBolumu pv)
        {
            _PersonelHastaneBolumus.Remove(pv);
        }
        #endregion
        #region PersonelHizmetIciEgitim
        private IList<PersonelHizmetIciEgitim> _PersonelHizmetIciEgitims = new List<PersonelHizmetIciEgitim>();

        public virtual IList<PersonelHizmetIciEgitim> PersonelHizmetIciEgitims
        {
            get { return _PersonelHizmetIciEgitims; }
            set { _PersonelHizmetIciEgitims = value; }
        }

        public virtual void AddPersonelHizmetIciEgitim(PersonelHizmetIciEgitim pv)
        {
            pv.Personel = this;
            this.PersonelHizmetIciEgitims.Insert(0, pv);
        }

        public virtual void RemovePersonelHizmetIciEgitim(PersonelHizmetIciEgitim pv)
        {
            _PersonelHizmetIciEgitims.Remove(pv);
        }
        #endregion
        #region PersonelIzin
        private IList<PersonelIzin> _PersonelIzins = new List<PersonelIzin>();

        public virtual IList<PersonelIzin> PersonelIzins
        {
            get { return _PersonelIzins; }
            set { _PersonelIzins = value; }
        }

        public virtual void AddPersonelIzin(PersonelIzin pv)
        {
            pv.Personel = this;
            this.PersonelIzins.Insert(0, pv);
        }

        public virtual void RemovePersonelIzin(PersonelIzin pv)
        {
            _PersonelIzins.Remove(pv);
        }
        #endregion
        #region PersonelRapor
        private IList<PersonelRapor> _PersonelRapors = new List<PersonelRapor>();

        public virtual IList<PersonelRapor> PersonelRapors
        {
            get { return _PersonelRapors; }
            set { _PersonelRapors = value; }
        }

        public virtual void AddPersonelRapor(PersonelRapor pv)
        {
            pv.Personel = this;
            this.PersonelRapors.Insert(0, pv);
        }

        public virtual void RemovePersonelRapor(PersonelRapor pv)
        {
            _PersonelRapors.Remove(pv);
        }
        #endregion
        #region PersonelSertifika
        private IList<PersonelSertifika> _PersonelSertifikas = new List<PersonelSertifika>();

        public virtual IList<PersonelSertifika> PersonelSertifikas
        {
            get { return _PersonelSertifikas; }
            set { _PersonelSertifikas = value; }
        }

        public virtual void AddPersonelSertifika(PersonelSertifika pv)
        {
            pv.Personel = this;
            this.PersonelSertifikas.Insert(0, pv);
        }

        public virtual void RemovePersonelSertifika(PersonelSertifika pv)
        {
            _PersonelSertifikas.Remove(pv);
        }
        #endregion
        #region PersonelYabanciDil
        private IList<PersonelYabanciDil> _PersonelYabanciDils = new List<PersonelYabanciDil>();

        public virtual IList<PersonelYabanciDil> PersonelYabanciDils
        {
            get { return _PersonelYabanciDils; }
            set { _PersonelYabanciDils = value; }
        }

        public virtual void AddPersonelYabanciDil(PersonelYabanciDil pv)
        {
            pv.Personel = this;
            this.PersonelYabanciDils.Insert(0, pv);
        }

        public virtual void RemovePersonelYabanciDil(PersonelYabanciDil pv)
        {
            _PersonelYabanciDils.Remove(pv);
        }
        #endregion

    }
}
