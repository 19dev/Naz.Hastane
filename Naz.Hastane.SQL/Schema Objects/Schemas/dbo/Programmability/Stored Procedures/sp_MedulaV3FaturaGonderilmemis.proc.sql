

CREATE PROCEDURE [dbo].[sp_MedulaV3FaturaGönderilmemiş]  @T1        VARCHAR(10), 
                                                        @T2        VARCHAR(10),
                                                        @KTIP      VARCHAR(4),
                                                        @AMBU      VARCHAR(4),
                                                        @BRANS     VARCHAR(4),
                                                        @DR        VARCHAR(4),
                                                        @TAKIPSEND VARCHAR(2),
                                                        @FIYATFARK VARCHAR(1)
AS

-- @TAKIPSEND Değerleri
-- D : Diğer
-- H : Havuzdakiler
-- T : Tümü
-- HAVUZ_DURUMU
-- H : Hizmet
-- F : Fatura

DECLARE @SLXA AS VARCHAR(2)
-------------------------------------------------
SELECT @SLXA = SLXA 
  FROM KEYDAT 
 WHERE SLK='00' 
   AND SLB ='KDVORANI'
-------------------------------------------------
SELECT B.HASTABASNO,
       B.TAKIPNO,
       B.KNR AS HastaNo ,
       B.SNR,
       B.BHDAT,
       CONVERT(VARCHAR,CIKTAR,104),
       A.HASTAADI AS HastaAdı ,
       A.HASTASOYADI AS hastaSoyAdı, 
       CONVERT(VARCHAR(4),S.SLXA) AS BrasKodu ,
       B.TEDAVITURU AS TedaviTuru,
       (CASE (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI') WHEN '1' THEN round(TAKIPTUTAR,2) WHEN '0' THEN round(TAKIPTUTAR/1.08,2) WHEN '2' THEN round(TAKIPTUTAR,2)  END) AS TAKIPTUTAR,
--     CASE WHEN (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI')='1'  THEN ROUND(TAKIPTUTAR*1.08,2)   ELSE ( ROUND(TAKIPTUTAR,2) ) END AS TAKIPTUTAR,
       B.KTOPT,
       (CASE (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI') WHEN '1' THEN round(TAKIPTUTAR,2)-round(KTOPT,2) WHEN '0' THEN round((TAKIPTUTAR/1.08),2)-round(KTOPT,2) WHEN '2' THEN round(TAKIPTUTAR,2)-round(KTOPT,2) END) AS FARK,
       B.TESLIMNO,
       CONVERT(VARCHAR,MEDFATURATARIHI,104),
       B.FATURANO,
       B.MEDFATTUTAR,
       EV_ADRES,
       EV_TEL1

  FROM BEHAND    B LEFT OUTER JOIN 
       DOKTOR    D ON D.SLB = B.ARZT
                   LEFT OUTER JOIN 
       SERVISLER S ON S.SLB = D.SLXX
                   INNER JOIN
       ADRES     A ON A.KNR = B.KNR 
                   INNER JOIN 
       KURADR    K ON K.PSG = A.PSG

 WHERE TAKIPNO IS NOT NULL 
   AND CONVERT(VARCHAR,BHDAT,112) >= @t1 
   AND CONVERT(VARCHAR,BHDAT,112) <= @t2 
   AND B.KNR     =  A.KNR
   AND TAKIPNO   <> ''
   AND K.KURUMTIPI LIKE '%'+ @KTIP
   AND ((@AMBU = 'G' AND TEDAVITURU = @AMBU) OR (@AMBU IN ('A','Y','P') AND AMBU = @AMBU) OR (@AMBU = '' AND AMBU LIKE '%%'))
   AND CONVERT(VARCHAR(4),S.SLXA) LIKE '%'+ @BRANS
   AND B.ARZT LIKE '%'+ @DR
   AND ((    @TAKIPSEND = 'D' AND TAKIPSEND = '1' AND ISNULL(HAVUZ_DURUMU,'') <> 'F') 
         OR (@TAKIPSEND = 'H' AND HAVUZ_DURUMU = 'F' AND TAKIPSEND = '1') 
         OR (@TAKIPSEND = 'T' AND TAKIPSEND = '1'))
   AND ((@FIYATFARK = 'F' AND @SLXA IN ('1','2') AND TAKIPTUTAR <> B.KTOPT) -- KDV Çalışır ve ya Muaf
         OR
        (@FIYATFARK = 'F' AND @SLXA = '0' AND ROUND(TAKIPTUTAR / 1.08, 2) <> B.KTOPT) -- KDV Yok
         OR @FIYATFARK <> 'F')     
 ORDER 
    BY B.HASTABASNO

