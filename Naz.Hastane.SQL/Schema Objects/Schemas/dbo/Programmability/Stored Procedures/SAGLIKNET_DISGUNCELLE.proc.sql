﻿

CREATE PROCEDURE [dbo].[SAGLIKNET_DISGUNCELLE] @KNRSEC VARCHAR(10)
AS
SELECT     HIZIL.KNR, HIZIL.SNR, HIZILGONSAGNET.GUID, HIZIL.SIRANO, HIZMET.BKODU, HIZIL.TARIH AS GELISTAR, ADRES.CINSIYETI, ADRES.HASTAADI, 
                      ADRES.HASTASOYADI, ADRES.DOGUMTARIHI, ADRES.UYRUGU, ADRES.TCKIMLIKNO, BEHAND.PROTOKOLNO, BEHAND.TAKIPNO, 
                      BEHAND.TAKIPSEND,BEHAND.CIKTAR,KEYDAT.SLVV AS DRTESCIL, KEYDAT.SLXA AS DRTC, HIZIL.NAME1, ADRES.BAGKARNENO AS KARNENO, 
                      ADRES.PSG AS HASTAKURUM, HIZILGONSAGNET.GELENCEVAP
FROM         HIZIL INNER JOIN
                          (SELECT     KNR, SNR, PROTOKOLNO, TAKIPNO, TAKIPSEND, CIKTAR,BHDAT
                            FROM          BEHAND AS BEHAND_1) AS BEHAND ON HIZIL.KNR = BEHAND.KNR AND HIZIL.SNR = BEHAND.SNR INNER JOIN
                          (SELECT     KNR, CINSIYETI, HASTAADI, HASTASOYADI, DOGUMTARIHI, UYRUGU, TCKIMLIKNO, BAGKARNENO, PSG
                            FROM          ADRES AS ADRES_1) AS ADRES ON HIZIL.KNR = ADRES.KNR AND BEHAND.CIKTAR IS NOT NULL INNER JOIN
                          (SELECT     SLB, SLVV, SLXA
                            FROM          KEYDAT AS KEYDAT_1
                            WHERE      (SLK = '07')) AS KEYDAT ON HIZIL.ARZT2 = KEYDAT.SLB INNER JOIN
                          (SELECT     BKODU, TANIM, GRUP, CODE
                            FROM          HIZMET AS HIZMET_1) AS HIZMET ON HIZIL.TANIM = HIZMET.TANIM AND HIZIL.GRUP = HIZMET.GRUP AND 
                      HIZIL.CODE = HIZMET.CODE LEFT OUTER JOIN
                          (SELECT     KNR, SNR, SIRANO, GUID, GELENCEVAP,SCODE
                            FROM          HIZILGONSAGNET AS HIZILGONSAGNET_1) AS HIZILGONSAGNET ON HIZIL.KNR = HIZILGONSAGNET.KNR AND 
                      HIZIL.SNR = HIZILGONSAGNET.SNR AND HIZIL.SIRANO = HIZILGONSAGNET.SIRANO
WHERE     (HIZIL.TANIM = '02') AND (LEN(ADRES.BAGKARNENO) > 1)  AND
 HIZILGONSAGNET.GELENCEVAP='CA'  AND HIZIL.KNR=@KNRSEC
AND HIZILGONSAGNET.SCODE='AE:OK' AND (isnumeric(SUBSTRING(HIZIL.NAME1, 2, 2)) = 1)




