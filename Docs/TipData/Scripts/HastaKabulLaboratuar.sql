  SELECT DISTINCT L.KNR, L.SNR, A.HASTAADI, A.HASTASOYADI, A.SIGORTANO, B.ODANO, B.SERVIS, B.ARZT
         from LBISTE L
			inner join BEHAND B on 
                B.KNR=L.KNR and
                B.SNR=L.SNR
			inner join HIZIL H on
                H.KNR=B.KNR and
                H.SNR=B.SNR and
                H.TANIM=L.TANIM and
                H.GRUP=L.GRUP and
                H.CODE=L.CODE
                --H.TARIH=L.TARIH 
			inner join ADRES A on
				A.KNR=L.KNR
         where 
                ((B.AMBU='P' and (H.SATISF>0 and (H.LRGOR IS NOT NULL OR H.MAKNO is not null)) or H.SATISF=0) or (B.AMBU='Y') or (B.AMBU='A'))  and
                L.TANIM='06' and
                L.KABUL = '0' and
                L.ONAY = '0' AND
                L.TARIH >= '20110203' and
                L.TARIH <  '20110204'
           ORDER BY A.HASTAADI, A.HASTASOYADI
                