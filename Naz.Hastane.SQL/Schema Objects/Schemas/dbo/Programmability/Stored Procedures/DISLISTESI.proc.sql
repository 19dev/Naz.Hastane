﻿

CREATE PROCEDURE [dbo].[DISLISTESI] @KNRSEC VARCHAR(10),@SNRSEC VARCHAR(10)
AS
SELECT     BEHAND.PROTOKOLNO, BEHAND.BHDAT, BEHAND.PSG, doktor.SLXA AS DRTCKIMLIK, BEHAND.CIKTAR, ADRES.CINSIYETI, ADRES.HASTAADI, 
                      ADRES.HASTASOYADI, ADRES.DOGUMTARIHI, ADRES.UYRUGU, ADRES.TCKIMLIKNO, BEHAND.ARZT
FROM         BEHAND INNER JOIN
                      HIZILDIS ON BEHAND.KNR = HIZILDIS.KNR AND BEHAND.SNR = HIZILDIS.SNR INNER JOIN
                      DISKODLARI ON HIZILDIS.DISKOD = DISKODLARI.tipdatakod INNER JOIN
                          (SELECT     SLK, SLB, SLT, SLX, SLY, SLZ, SLVV, SLXX, SLYY, SLZZ, SLXA, SLYA, SEC
                            FROM          KEYDAT
                            WHERE      (SLK = '07')) AS doktor ON BEHAND.ARZT = doktor.SLB INNER JOIN
                      ADRES ON BEHAND.KNR = ADRES.KNR
WHERE HIZILDIS.KNR=@KNRSEC AND HIZILDIS.SNR=@SNRSEC



/****** Object:  StoredProcedure [dbo].[SAGLIKNETEKLEGUNCELLE]    Script Date: 01/28/2009 09:19:40 ******/
SET ANSI_NULLS ON
