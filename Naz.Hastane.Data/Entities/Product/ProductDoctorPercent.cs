using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naz.Hastane.Data.Entities
{
    public class ProductDoctorPercent
    {
        public virtual string ANAHIZ { get; set; } // ANAHIZ; length(50); 1
        public virtual string ANHIZ { get; set; } // ANHIZ; length(50); 1
        public virtual string APHIZMET { get; set; } // APHIZMET; length(1); 1
        public virtual string ARZT { get; set; } // ARZT; length(4); 1
        public virtual string BKODU { get; set; } // BKODU; length(15); 1
        public virtual string BUT { get; set; } // BUT; length(50); 1
        public virtual string CODE { get; set; } // CODE; length(15); 0
        public virtual string CODE1 { get; set; } // CODE1; length(50); 1
        public virtual DateTime DATE_CREATE { get; set; } // DATE_CREATE; length(8); 1
        public virtual DateTime? DATE_UPDATE { get; set; } // DATE_UPDATE; length(8); 1
        public virtual double DRYUZDE { get; set; } // DRYUZDE; length(8); 0
        public virtual string GELIRGRUBU { get; set; } // GELIRGRUBU; length(10); 1
        public virtual string GRUP { get; set; } // GRUP; length(3); 0
        public virtual string HAVUZ { get; set; } // HAVUZ; length(4); 1
        public virtual string HKILIT { get; set; } // HKILIT; length(50); 1
        public virtual double HMALIYET { get; set; } // HMALIYET; length(8); 1
        public virtual string HREFAKAT { get; set; } // HREFAKAT; length(50); 0
        public virtual string IKINCIHIZ { get; set; } // IKINCIHIZ; length(50); 1
        public virtual double KDV { get; set; } // KDV; length(8); 0
        public virtual string KKODU { get; set; } // KKODU; length(50); 1
        public virtual double KSATISF00 { get; set; } // KSATISF00; length(8); 0
        public virtual double KSATISF01 { get; set; } // KSATISF01; length(8); 1
        public virtual double KSATISF02 { get; set; } // KSATISF02; length(8); 1
        public virtual double KSATISF03 { get; set; } // KSATISF03; length(8); 1
        public virtual double KSATISF04 { get; set; } // KSATISF04; length(8); 1
        public virtual double KSATISF05 { get; set; } // KSATISF05; length(8); 1
        public virtual double KSATISF06 { get; set; } // KSATISF06; length(8); 1
        public virtual double KSATISF07 { get; set; } // KSATISF07; length(8); 1
        public virtual double KSATISF08 { get; set; } // KSATISF08; length(8); 1
        public virtual double KSATISF09 { get; set; } // KSATISF09; length(8); 1
        public virtual double KSATISF10 { get; set; } // KSATISF10; length(8); 1
        public virtual double KSATISF11 { get; set; } // KSATISF11; length(8); 1
        public virtual double KSATISF12 { get; set; } // KSATISF12; length(8); 1
        public virtual double KSATISF13 { get; set; } // KSATISF13; length(8); 1
        public virtual double KSATISF14 { get; set; } // KSATISF14; length(8); 1
        public virtual double KSATISF15 { get; set; } // KSATISF15; length(8); 1
        public virtual double KSATISF16 { get; set; } // KSATISF16; length(8); 1
        public virtual double KSATISF17 { get; set; } // KSATISF17; length(8); 1
        public virtual double KSATISF18 { get; set; } // KSATISF18; length(8); 1
        public virtual double KSATISF19 { get; set; } // KSATISF19; length(8); 1
        public virtual double KSATISF20 { get; set; } // KSATISF20; length(8); 1
        public virtual double KSATISF21 { get; set; } // KSATISF21; length(8); 1
        public virtual double KSATISF22 { get; set; } // KSATISF22; length(8); 1
        public virtual double KSATISF23 { get; set; } // KSATISF23; length(8); 1
        public virtual double KSATISF24 { get; set; } // KSATISF24; length(8); 1
        public virtual double KSATISF25 { get; set; } // KSATISF25; length(8); 1
        public virtual double KSATISF26 { get; set; } // KSATISF26; length(8); 1
        public virtual double KSATISF27 { get; set; } // KSATISF27; length(8); 1
        public virtual double KSATISF28 { get; set; } // KSATISF28; length(8); 1
        public virtual double KSATISF29 { get; set; } // KSATISF29; length(8); 1
        public virtual double KSATISF30 { get; set; } // KSATISF30; length(8); 1
        public virtual double KSATISF31 { get; set; } // KSATISF31; length(8); 1
        public virtual double KSATISF32 { get; set; } // KSATISF32; length(8); 1
        public virtual double KSATISF33 { get; set; } // KSATISF33; length(8); 1
        public virtual double KSATISF34 { get; set; } // KSATISF34; length(8); 1
        public virtual double KSATISF35 { get; set; } // KSATISF35; length(8); 1
        public virtual double KSATISF36 { get; set; } // KSATISF36; length(8); 1
        public virtual double KSATISF37 { get; set; } // KSATISF37; length(8); 1
        public virtual double KSATISF38 { get; set; } // KSATISF38; length(8); 1
        public virtual double KSATISF39 { get; set; } // KSATISF39; length(8); 1
        public virtual double KSATISF40 { get; set; } // KSATISF40; length(8); 1
        public virtual double KSATISF41 { get; set; } // KSATISF41; length(8); 1
        public virtual double KSATISF42 { get; set; } // KSATISF42; length(8); 1
        public virtual double KSATISF43 { get; set; } // KSATISF43; length(8); 1
        public virtual double KSATISF44 { get; set; } // KSATISF44; length(8); 1
        public virtual double KSATISF45 { get; set; } // KSATISF45; length(8); 1
        public virtual double KSATISF46 { get; set; } // KSATISF46; length(8); 1
        public virtual double KSATISF47 { get; set; } // KSATISF47; length(8); 1
        public virtual double KSATISF48 { get; set; } // KSATISF48; length(8); 1
        public virtual double KSATISF49 { get; set; } // KSATISF49; length(8); 1
        public virtual double KSATISF50 { get; set; } // KSATISF50; length(8); 1
        public virtual double KSATISF51 { get; set; } // KSATISF51; length(8); 1
        public virtual double KSATISF52 { get; set; } // KSATISF52; length(8); 1
        public virtual double KSATISF53 { get; set; } // KSATISF53; length(8); 1
        public virtual double KSATISF54 { get; set; } // KSATISF54; length(8); 1
        public virtual double KSATISF55 { get; set; } // KSATISF55; length(8); 1
        public virtual double KSATISF56 { get; set; } // KSATISF56; length(8); 1
        public virtual double KSATISF57 { get; set; } // KSATISF57; length(8); 1
        public virtual double KSATISF58 { get; set; } // KSATISF58; length(8); 1
        public virtual double KSATISF59 { get; set; } // KSATISF59; length(8); 1
        public virtual double KSATISF60 { get; set; } // KSATISF60; length(8); 1
        public virtual double KSATISF61 { get; set; } // KSATISF61; length(8); 1
        public virtual double KSATISF62 { get; set; } // KSATISF62; length(8); 1
        public virtual double KSATISF63 { get; set; } // KSATISF63; length(8); 1
        public virtual double KSATISF64 { get; set; } // KSATISF64; length(8); 1
        public virtual double KSATISF65 { get; set; } // KSATISF65; length(8); 1
        public virtual double KSATISF66 { get; set; } // KSATISF66; length(8); 1
        public virtual double KSATISF67 { get; set; } // KSATISF67; length(8); 1
        public virtual double KSATISF68 { get; set; } // KSATISF68; length(8); 1
        public virtual double KSATISF69 { get; set; } // KSATISF69; length(8); 1
        public virtual double KSATISF70 { get; set; } // KSATISF70; length(8); 1
        public virtual double KSATISF71 { get; set; } // KSATISF71; length(8); 1
        public virtual double KSATISF72 { get; set; } // KSATISF72; length(8); 1
        public virtual double KSATISF73 { get; set; } // KSATISF73; length(8); 1
        public virtual double KSATISF74 { get; set; } // KSATISF74; length(8); 1
        public virtual double KSATISF75 { get; set; } // KSATISF75; length(8); 1
        public virtual double KSATISF76 { get; set; } // KSATISF76; length(8); 1
        public virtual double KSATISF77 { get; set; } // KSATISF77; length(8); 1
        public virtual double KSATISF78 { get; set; } // KSATISF78; length(8); 1
        public virtual double KSATISF79 { get; set; } // KSATISF79; length(8); 1
        public virtual double KSATISF80 { get; set; } // KSATISF80; length(8); 1
        public virtual double KSATISF81 { get; set; } // KSATISF81; length(8); 1
        public virtual double KSATISF82 { get; set; } // KSATISF82; length(8); 1
        public virtual double KSATISF83 { get; set; } // KSATISF83; length(8); 1
        public virtual double KSATISF84 { get; set; } // KSATISF84; length(8); 1
        public virtual double KSATISF85 { get; set; } // KSATISF85; length(8); 1
        public virtual double KSATISF86 { get; set; } // KSATISF86; length(8); 1
        public virtual double KSATISF87 { get; set; } // KSATISF87; length(8); 1
        public virtual double KSATISF88 { get; set; } // KSATISF88; length(8); 1
        public virtual double KSATISF89 { get; set; } // KSATISF89; length(8); 1
        public virtual double KSATISF90 { get; set; } // KSATISF90; length(8); 1
        public virtual double KSATISF91 { get; set; } // KSATISF91; length(8); 1
        public virtual double KSATISF92 { get; set; } // KSATISF92; length(8); 1
        public virtual double KSATISF93 { get; set; } // KSATISF93; length(8); 1
        public virtual double KSATISF94 { get; set; } // KSATISF94; length(8); 1
        public virtual double KSATISF95 { get; set; } // KSATISF95; length(8); 1
        public virtual double KSATISF96 { get; set; } // KSATISF96; length(8); 1
        public virtual double KSATISF97 { get; set; } // KSATISF97; length(8); 1
        public virtual double KSATISF98 { get; set; } // KSATISF98; length(8); 1
        public virtual double KSATISF99 { get; set; } // KSATISF99; length(8); 1
        public virtual char LABTIPI { get; set; } // LABTIPI; length(1); 1
        public virtual string MATERYAL { get; set; } // MATERYAL; length(20); 1
        public virtual string MEDGONDER { get; set; } // MEDGONDER; length(50); 1
        public virtual string NAME1 { get; set; } // NAME1; length(100); 0
        public virtual char OTOISLE { get; set; } // OTOISLE; length(1); 0
        public virtual string OZELKOD { get; set; } // OZELKOD; length(10); 0
        public virtual string PAKET { get; set; } // PAKET; length(1); 0
        public virtual string PAKETGRUBU { get; set; } // PAKETGRUBU; length(50); 1
        public virtual int PARSAYI { get; set; } // PARSAYI; length(4); 1
        public virtual string PDAHIL { get; set; } // PDAHIL; length(1); 0
        public virtual double PHYUZDE { get; set; } // PHYUZDE; length(8); 0
        public virtual double PYUZDE { get; set; } // PYUZDE; length(8); 0
        public virtual double SATISF00 { get; set; } // SATISF00; length(8); 0
        public virtual double SATISF01 { get; set; } // SATISF01; length(8); 1
        public virtual double SATISF02 { get; set; } // SATISF02; length(8); 1
        public virtual double SATISF03 { get; set; } // SATISF03; length(8); 1
        public virtual double SATISF04 { get; set; } // SATISF04; length(8); 1
        public virtual double SATISF05 { get; set; } // SATISF05; length(8); 1
        public virtual double SATISF06 { get; set; } // SATISF06; length(8); 1
        public virtual double SATISF07 { get; set; } // SATISF07; length(8); 1
        public virtual double SATISF08 { get; set; } // SATISF08; length(8); 1
        public virtual double SATISF09 { get; set; } // SATISF09; length(8); 1
        public virtual double SATISF10 { get; set; } // SATISF10; length(8); 1
        public virtual double SATISF11 { get; set; } // SATISF11; length(8); 1
        public virtual double SATISF12 { get; set; } // SATISF12; length(8); 1
        public virtual double SATISF13 { get; set; } // SATISF13; length(8); 1
        public virtual double SATISF14 { get; set; } // SATISF14; length(8); 1
        public virtual double SATISF15 { get; set; } // SATISF15; length(8); 1
        public virtual double SATISF16 { get; set; } // SATISF16; length(8); 1
        public virtual double SATISF17 { get; set; } // SATISF17; length(8); 1
        public virtual double SATISF18 { get; set; } // SATISF18; length(8); 1
        public virtual double SATISF19 { get; set; } // SATISF19; length(8); 1
        public virtual double SATISF20 { get; set; } // SATISF20; length(8); 1
        public virtual double SATISF21 { get; set; } // SATISF21; length(8); 1
        public virtual double SATISF22 { get; set; } // SATISF22; length(8); 1
        public virtual double SATISF23 { get; set; } // SATISF23; length(8); 1
        public virtual double SATISF24 { get; set; } // SATISF24; length(8); 1
        public virtual double SATISF25 { get; set; } // SATISF25; length(8); 1
        public virtual double SATISF26 { get; set; } // SATISF26; length(8); 1
        public virtual double SATISF27 { get; set; } // SATISF27; length(8); 1
        public virtual double SATISF28 { get; set; } // SATISF28; length(8); 1
        public virtual double SATISF29 { get; set; } // SATISF29; length(8); 1
        public virtual double SATISF30 { get; set; } // SATISF30; length(8); 1
        public virtual double SATISF31 { get; set; } // SATISF31; length(8); 1
        public virtual double SATISF32 { get; set; } // SATISF32; length(8); 1
        public virtual double SATISF33 { get; set; } // SATISF33; length(8); 1
        public virtual double SATISF34 { get; set; } // SATISF34; length(8); 1
        public virtual double SATISF35 { get; set; } // SATISF35; length(8); 1
        public virtual double SATISF36 { get; set; } // SATISF36; length(8); 1
        public virtual double SATISF37 { get; set; } // SATISF37; length(8); 1
        public virtual double SATISF38 { get; set; } // SATISF38; length(8); 1
        public virtual double SATISF39 { get; set; } // SATISF39; length(8); 1
        public virtual double SATISF40 { get; set; } // SATISF40; length(8); 1
        public virtual double SATISF41 { get; set; } // SATISF41; length(8); 1
        public virtual double SATISF42 { get; set; } // SATISF42; length(8); 1
        public virtual double SATISF43 { get; set; } // SATISF43; length(8); 1
        public virtual double SATISF44 { get; set; } // SATISF44; length(8); 1
        public virtual double SATISF45 { get; set; } // SATISF45; length(8); 1
        public virtual double SATISF46 { get; set; } // SATISF46; length(8); 1
        public virtual double SATISF47 { get; set; } // SATISF47; length(8); 1
        public virtual double SATISF48 { get; set; } // SATISF48; length(8); 1
        public virtual double SATISF49 { get; set; } // SATISF49; length(8); 1
        public virtual double SATISF50 { get; set; } // SATISF50; length(8); 1
        public virtual double SATISF51 { get; set; } // SATISF51; length(8); 1
        public virtual double SATISF52 { get; set; } // SATISF52; length(8); 1
        public virtual double SATISF53 { get; set; } // SATISF53; length(8); 1
        public virtual double SATISF54 { get; set; } // SATISF54; length(8); 1
        public virtual double SATISF55 { get; set; } // SATISF55; length(8); 1
        public virtual double SATISF56 { get; set; } // SATISF56; length(8); 1
        public virtual double SATISF57 { get; set; } // SATISF57; length(8); 1
        public virtual double SATISF58 { get; set; } // SATISF58; length(8); 1
        public virtual double SATISF59 { get; set; } // SATISF59; length(8); 1
        public virtual double SATISF60 { get; set; } // SATISF60; length(8); 1
        public virtual double SATISF61 { get; set; } // SATISF61; length(8); 1
        public virtual double SATISF62 { get; set; } // SATISF62; length(8); 1
        public virtual double SATISF63 { get; set; } // SATISF63; length(8); 1
        public virtual double SATISF64 { get; set; } // SATISF64; length(8); 1
        public virtual double SATISF65 { get; set; } // SATISF65; length(8); 1
        public virtual double SATISF66 { get; set; } // SATISF66; length(8); 1
        public virtual double SATISF67 { get; set; } // SATISF67; length(8); 1
        public virtual double SATISF68 { get; set; } // SATISF68; length(8); 1
        public virtual double SATISF69 { get; set; } // SATISF69; length(8); 1
        public virtual double SATISF70 { get; set; } // SATISF70; length(8); 1
        public virtual double SATISF71 { get; set; } // SATISF71; length(8); 1
        public virtual double SATISF72 { get; set; } // SATISF72; length(8); 1
        public virtual double SATISF73 { get; set; } // SATISF73; length(8); 1
        public virtual double SATISF74 { get; set; } // SATISF74; length(8); 1
        public virtual double SATISF75 { get; set; } // SATISF75; length(8); 1
        public virtual double SATISF76 { get; set; } // SATISF76; length(8); 1
        public virtual double SATISF77 { get; set; } // SATISF77; length(8); 1
        public virtual double SATISF78 { get; set; } // SATISF78; length(8); 1
        public virtual double SATISF79 { get; set; } // SATISF79; length(8); 1
        public virtual double SATISF80 { get; set; } // SATISF80; length(8); 1
        public virtual double SATISF81 { get; set; } // SATISF81; length(8); 1
        public virtual double SATISF82 { get; set; } // SATISF82; length(8); 1
        public virtual double SATISF83 { get; set; } // SATISF83; length(8); 1
        public virtual double SATISF84 { get; set; } // SATISF84; length(8); 1
        public virtual double SATISF85 { get; set; } // SATISF85; length(8); 1
        public virtual double SATISF86 { get; set; } // SATISF86; length(8); 1
        public virtual double SATISF87 { get; set; } // SATISF87; length(8); 1
        public virtual double SATISF88 { get; set; } // SATISF88; length(8); 1
        public virtual double SATISF89 { get; set; } // SATISF89; length(8); 1
        public virtual double SATISF90 { get; set; } // SATISF90; length(8); 1
        public virtual double SATISF91 { get; set; } // SATISF91; length(8); 1
        public virtual double SATISF92 { get; set; } // SATISF92; length(8); 1
        public virtual double SATISF93 { get; set; } // SATISF93; length(8); 1
        public virtual double SATISF94 { get; set; } // SATISF94; length(8); 1
        public virtual double SATISF95 { get; set; } // SATISF95; length(8); 1
        public virtual double SATISF96 { get; set; } // SATISF96; length(8); 1
        public virtual double SATISF97 { get; set; } // SATISF97; length(8); 1
        public virtual double SATISF98 { get; set; } // SATISF98; length(8); 1
        public virtual double SATISF99 { get; set; } // SATISF99; length(8); 1
        public virtual string SIRANO { get; set; } // SIRANO; length(50); 1
        public virtual string TANIM { get; set; } // TANIM; length(2); 0
        public virtual string USER_ID { get; set; } // USER_ID; length(50); 1
        public virtual string USER_ID_UPDATE { get; set; } // USER_ID_UPDATE; length(50); 1
        public virtual string YTKHIZMET { get; set; } // YTKHIZMET; length(50); 0

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            ProductDoctorPercent pv = obj as ProductDoctorPercent;
            if (pv == null)
                return false;
            if (this.TANIM == pv.TANIM && this.GRUP == pv.GRUP && this.CODE == pv.CODE)
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

            return hash;
        }

    }
}
