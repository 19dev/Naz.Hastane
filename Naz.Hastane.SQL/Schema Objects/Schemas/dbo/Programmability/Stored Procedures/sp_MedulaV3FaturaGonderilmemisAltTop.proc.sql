

CREATE PROCEDURE [dbo].[sp_MedulaV3FaturaGönderilmemişAltTop]  @T1        VARCHAR(10), 
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
SELECT  ROUND(SUM(TAKIPTUTAR),2) AS TTOPT ,
        ROUND(SUM(KTOPT),2) AS KTOPT

FROM BEHAND    B LEFT OUTER JOIN 
     DOKTOR    D ON d.slb=B.ARZT
                 LEFT OUTER JOIN 
     SERVISLER S ON s.slb = d.slxx
                 INNER JOIN
     ADRES     A ON A.KNR = B.KNR 
                 INNER JOIN
     KURADR    K on K.psg = A.psg

WHERE TAKIPNO IS NOT NULL 
  AND CONVERT(VARCHAR,BHDAT,112) >= @T1 
  AND CONVERT(VARCHAR,BHDAT,112) <= @T2 
  AND B.KNR     =  A.KNR
  AND TAKIPNO   <> ''
  AND K.KURUMTIPI LIKE '%'+ @KTIP
  AND B.AMBU      LIKE '%'+ @AMBU
  AND CONVERT(VARCHAR(4),S.SLXA) LIKE '%'+ @BRANS
  AND B.ARZT LIKE '%'+ @DR
  AND ((    @TAKIPSEND = 'D' AND TAKIPSEND = '1' AND ISNULL(HAVUZ_DURUMU,'') <> 'F') 
        OR (@TAKIPSEND = 'H' AND HAVUZ_DURUMU = 'F' AND TAKIPSEND = '1') 
        OR (@TAKIPSEND = 'T' AND TAKIPSEND = '1'))
  AND ((@FIYATFARK = 'F' AND @SLXA IN ('1','2') AND TAKIPTUTAR <> B.KTOPT) -- KDV Çalışır ve ya Muaf
        OR
       (@FIYATFARK = 'F' AND @SLXA = '0' AND ROUND(TAKIPTUTAR / 1.08, 2) <> B.KTOPT) -- KDV Yok  
        OR @FIYATFARK <> 'F') 







