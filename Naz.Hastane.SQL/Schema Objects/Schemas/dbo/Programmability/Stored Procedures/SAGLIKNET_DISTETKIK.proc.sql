﻿


CREATE PROCEDURE [dbo].[SAGLIKNET_DISTETKIK] @ILKTAR VARCHAR(10),@SONTAR VARCHAR(10),@GELGIT VARCHAR(1),@KNRSEC VARCHAR(10)
AS
IF @GELGIT=0  BEGIN 
SELECT     HIZIL.KNR, HIZIL.SNR, HIZILGONSAGNET.GUID, HIZIL.SIRANO, HIZMET.BKODU, HIZIL.TARIH AS GELISTAR, ADRES.CINSIYETI, ADRES.HASTAADI, 
                      ADRES.HASTASOYADI, ADRES.DOGUMTARIHI, ADRES.UYRUGU, ADRES.TCKIMLIKNO, BEHAND.PROTOKOLNO, BEHAND.TAKIPNO, 
                      BEHAND.TAKIPSEND,HIZIL.TARIH AS CIKTAR, KEYDAT.SLVV AS DRTESCIL, KEYDAT.SLXA AS DRTC, HIZIL.NAME1, ISNULL(ADRES.BAGKARNENO,'YOK') AS KARNENO, 
                      ADRES.PSG AS HASTAKURUM, HIZILGONSAGNET.GELENCEVAP
FROM         HIZIL 
INNER JOIN (SELECT     KNR, SNR, PROTOKOLNO, TAKIPNO, TAKIPSEND,BHDAT,CIKTAR   FROM          BEHAND AS BEHAND_1) AS BEHAND ON HIZIL.KNR = BEHAND.KNR AND HIZIL.SNR = BEHAND.SNR INNER JOIN
                          (SELECT     KNR, CINSIYETI, HASTAADI, HASTASOYADI, DOGUMTARIHI, UYRUGU, TCKIMLIKNO, BAGKARNENO, PSG
                            FROM          ADRES AS ADRES_1) AS ADRES ON HIZIL.KNR = ADRES.KNR INNER JOIN
                          (SELECT     SLB, SLVV, SLXA
                            FROM          KEYDAT AS KEYDAT_1
                            WHERE      (SLK = '07')) AS KEYDAT ON HIZIL.ARZT2 = KEYDAT.SLB INNER JOIN
                          (SELECT     BKODU, TANIM, GRUP, CODE
                            FROM          HIZMET AS HIZMET_1) AS HIZMET ON HIZIL.TANIM = HIZMET.TANIM AND HIZIL.GRUP = HIZMET.GRUP AND 
                      HIZIL.CODE = HIZMET.CODE LEFT OUTER JOIN
                          (SELECT     KNR, SNR, SIRANO, GUID, GELENCEVAP
                            FROM          HIZILGONSAGNET AS HIZILGONSAGNET_1) AS HIZILGONSAGNET ON HIZIL.KNR = HIZILGONSAGNET.KNR AND 
                      HIZIL.SNR = HIZILGONSAGNET.SNR AND HIZIL.SIRANO = HIZILGONSAGNET.SIRANO
WHERE (HIZMET.BKODU IN ('401050','401080','801750','801770')) 
AND CONVERT(VARCHAR,BEHAND.BHDAT,112) BETWEEN @ILKTAR AND @SONTAR
END


