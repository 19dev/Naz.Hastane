


CREATE PROCEDURE [dbo].[sp_MedulaV3FaturaGönderilmişAltTop] @T1    VARCHAR(10), 
                                                           @T2    VARCHAR(10),
                                                           @KTIP  VARCHAR(4),
                                                           @AMBU  VARCHAR(4),
                                                           @BRANS VARCHAR(4),
                                                           @DR    VARCHAR(4)
AS


SELECT ROUND(SUM(TAKIPTUTAR),2) AS TTOPT ,
       ROUND(SUM(KTOPT),2) AS KTOPT
  FROM BEHAND    B LEFT OUTER JOIN 
       DOKTOR    D ON D.SLB  = B.ARZT
                   LEFT OUTER JOIN 
       SERVISLER S ON S.SLB  = D.SLXX
                   INNER JOIN 
       ADRES     A ON A.KNR  = B.KNR 
                   INNER JOIN 
       KURADR    K ON  K.PSG = A.PSG
                   AND K.KURUMTIPI                LIKE '%'+ @KTIP
                   AND CONVERT(VARCHAR(4),S.SLXA) LIKE '%'+ @BRANS
                   AND B.ARZT                     LIKE '%'+ @DR
 WHERE TAKIPNO IS NOT NULL 
   AND CONVERT(VARCHAR,BHDAT,112) >= @t1 
   AND CONVERT(VARCHAR,BHDAT,112) <= @t2
   AND ((@AMBU = 'G' and TEDAVITURU = @AMBU) OR (@AMBU IN ('A','Y','P') and AMBU = @AMBU) OR (@AMBU = '' and AMBU LIKE '%%'))
   AND TAKIPSEND =  '3'




