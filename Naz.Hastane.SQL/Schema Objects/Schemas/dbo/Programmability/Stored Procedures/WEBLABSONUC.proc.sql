﻿
CREATE procedure [dbo].[WEBLABSONUC] @KNR VARCHAR(6),@SNR VARCHAR(3),@CODE VARCHAR(15)
as
/*
SELECT PARISMI, SONUC, BIRIMI, NORMAL1, NORMAL2 FROM LABORSONUC 
WHERE KNR=@KNR and SNR=@SNR
--and TANIM='02' 
--and GRUP='001' 
and CODE=@CODE
-- and TARIH = '27.02.2009 09:54:24' 
order by IND
*/
SELECT     H.NAME1, H.MATERYAL, H.LABTIPI, L.SNR, L.TANIM, L.GRUP, L.CODE, L.TARIH, L.KABUL_NO, L.ONAY_TARIH, L.ONAY_ID, L.ONAY, L.YAZILDIMI, 
                      LABORSONUC.PARISMI, LABORSONUC.SONUC, LABORSONUC.BIRIMI, LABORSONUC.NORMAL1, LABORSONUC.NORMAL2, 
                      LABORSONUC.ACIKLAMA
FROM         LBISTE AS L INNER JOIN
                      HIZMET AS H ON L.TANIM = H.TANIM AND L.GRUP = H.GRUP AND L.CODE = H.CODE INNER JOIN
                      LABORSONUC ON L.KNR = LABORSONUC.KNR AND L.SNR = LABORSONUC.SNR AND L.CODE = LABORSONUC.CODE and     L.TARIH = LABORSONUC.TARIH AND L.DRONAY<>'0'
WHERE L.KNR=@KNR and L.SNR=@SNR 

