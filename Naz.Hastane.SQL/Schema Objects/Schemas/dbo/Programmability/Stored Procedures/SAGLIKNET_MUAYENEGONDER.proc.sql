﻿



CREATE PROCEDURE [dbo].[SAGLIKNET_MUAYENEGONDER] @ILKTAR VARCHAR(10),@SONTAR VARCHAR(10),@GELGIT VARCHAR(1),@KNRSEC VARCHAR(10)
AS
SELECT  BEHAND.KNR, BEHAND.SNR,HIZILGONSAGNET.GUID,0 AS SIRANO,BEHAND.BHDAT AS GELISTAR,ADRES.HASTAADI, ADRES.HASTASOYADI,BEHAND.SERVIS, BEHAND.AMBU, BEHAND.HASTALIKSONU, 
(BEHAND.BHDAT)+11 as TETSONUCTAR, (BEHAND.BHDAT)+10 as CIKTAR,ISNULL(BEHAND.PROTOKOLNO,'27')as PROTOKOLNO, BEHAND.PROVIZYONNO, BEHAND.TAKIPNO, 
                      BEHAND.SEVKTAKIPNO,ADRES.SIGORTANO, 
                      ADRES.CINSIYETI, ADRES.DOGUMTARIHI, ADRES.UYRUGU, ADRES.TCKIMLIKNO,CASE WHEN  LEN(ADRES.BAGKARNENO)>1 THEN ADRES.BAGKARNENO ELSE '123' END BAGKARNENO,
                      SAGLIKNET_KURUMTUR.KURUMKODU, SAGLIKNET_KURUMTUR.KURUMADI, KEYDAT.SLVV AS DRTESCIL, 
                      KEYDAT.SLXA AS DRTC
FROM         BEHAND 
INNER JOIN  ADRES ON BEHAND.KNR = ADRES.KNR 
LEFT OUTER JOIN HIZILGONSAGNET ON HIZILGONSAGNET.KNR = BEHAND.KNR AND HIZILGONSAGNET.SNR = BEHAND.SNR
INNER JOIN   KURADR ON ADRES.PSG = KURADR.PSG 
INNER JOIN SAGLIKNET_KURUMTUR ON KURADR.KURUMTIPI = SAGLIKNET_KURUMTUR.SLB 
INNER JOIN  (SELECT   SLB, SLVV, SLXA   FROM      KEYDAT  WHERE      (SLK = '07') and LEN(SLXA)=11 AND SLXA IS NOT NULL) AS KEYDAT ON BEHAND.ARZT = KEYDAT.SLB
INNER JOIN (SELECT KNR,SNR FROM TET_ANAMNEZ GROUP BY KNR,SNR) TAD ON TAD.KNR=BEHAND.KNR and TAD.SNR=BEHAND.SNR
WHERE  (CONVERT(VARCHAR, BEHAND.BHDAT, 112) BETWEEN @ILKTAR AND @SONTAR) AND LEN(ADRES.TCKIMLIKNO)=11 AND ISNULL(HIZILGONSAGNET.GELENCEVAP,'CE')<>'CA'
and  AMBU IN ('A','P')  AND (SUBSTRING(ISNULL(BEHAND.OZELNOT,0),0,2)<>'*') AND HIZILGONSAGNET.GUID IS NOT NULL --and  LEN(ISNULL(KEYDAT.SLXA,0))=11
