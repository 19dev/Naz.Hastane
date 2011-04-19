
-- Yazan : OC
-- Tarih : 10/02/2011
-- KDV parametresine göre medula ile sistemdeki fiyatları farklı olan faturalanmış kayıtları listeler.

CREATE PROCEDURE [dbo].[sp_MedulaV3FaturaFiyatFark] @T1    VARCHAR(10), 
                                                   @T2    VARCHAR(10),
                                                   @KTIP  VARCHAR(4),
                                                   @AMBU  VARCHAR(4),
                                                   @BRANS VARCHAR(4),
                                                   @DR    VARCHAR(4)

AS
-------------------------------------------------
DECLARE @SLXA AS VARCHAR(2)
-------------------------------------------------
SELECT @SLXA = SLXA 
  FROM KEYDAT 
 WHERE SLK='00' 
   AND SLB ='KDVORANI'
-------------------------------------------------
IF @SLXA IN ('1','2') BEGIN -- KDV Çalışır ve ya Muaf
   ---------------------------------------------- 
   SELECT B.HASTABASNO,
          B.TAKIPNO,
          B.KNR AS HASTANO,
          B.SNR,
          B.BHDAT,
          CONVERT(VARCHAR,CIKTAR,104)          AS CIKTAR,
          A.HASTAADI,
          A.HASTASOYADI,
          CONVERT(VARCHAR(4),S.SLXA)           AS BrasKodu ,
          (case when (b.ambu = 'P' or b.ambu = 'A')  then 'A' else 'Y' end) as TedaviTuru,
          B.TAKIPTUTAR,
          B.KTOPT,
          round(TAKIPTUTAR,2)-round(KTOPT,2) AS FARKTUTAR,
          --B.FARKTUTAR,
          B.TESLIMNO,
          CONVERT(VARCHAR,B.MEDFATURATARIHI,112) AS MEDFATURATARIHI, 
		  B.FATURANO,
          B.MEDFATTUTAR,
          B.TEDAVITURU,
          B.paket,
          A.EV_TEL1,
          A.EV_ADRES         
          
     FROM BEHAND    B LEFT OUTER JOIN 
          DOKTOR    D ON   D.SLB = B.ARZT
                      LEFT OUTER JOIN
          ADRES     A ON   A.KNR = B.KNR
                      LEFT OUTER JOIN
          SERVISLER S ON   S.SLB = D.SLXX
    WHERE TAKIPTUTAR <> B.KTOPT
      AND TAKIPNO    IS NOT NULL 
      AND CONVERT(VARCHAR,BHDAT,112)  >= @T1 
      AND CONVERT(VARCHAR,BHDAT,112)  <= @T2
      AND TAKIPSEND                    = '3'
      AND ((@AMBU = 'G' and TEDAVITURU = @AMBU) OR (@AMBU IN ('A','Y','P') and AMBU = @AMBU) OR (@AMBU = '' and AMBU LIKE '%%'))
 ORDER 
    BY B.HASTABASNO
   ---------------------------------------------- 
END
ELSE BEGIN
   ---------------------------------------------- 
   SELECT B.HASTABASNO,
          B.TAKIPNO,
          B.KNR AS HASTANO,
          B.SNR,
          B.BHDAT,
          CONVERT(VARCHAR,CIKTAR,104)          AS CIKTAR,
          A.HASTAADI,
          A.HASTASOYADI,
          CONVERT(VARCHAR(4),S.SLXA)           AS BrasKodu ,
          (case when (b.ambu = 'P' or b.ambu = 'A')  then 'A' else 'Y' end) as TedaviTuru,
          round(B.TAKIPTUTAR/1.08,2),
          B.KTOPT,
          round((TAKIPTUTAR/1.08),2)-round(KTOPT,2) AS FARKTUTAR,
          --B.FARKTUTAR,
          B.TESLIMNO,
          CONVERT(VARCHAR,B.MEDFATURATARIHI,112) AS MEDFATURATARIHI, 
          B.FATURANO,
          B.MEDFATTUTAR,
          B.TEDAVITURU,
          B.paket,
          A.EV_TEL1,
          A.EV_ADRES
          
     FROM BEHAND    B LEFT OUTER JOIN 
          DOKTOR    D ON   D.SLB = B.ARZT
                      LEFT OUTER JOIN
          ADRES     A ON   A.KNR = B.KNR
                      LEFT OUTER JOIN
          SERVISLER S ON   S.SLB = D.SLXX
                      INNER JOIN 
          KURADR    K ON  K.PSG = A.PSG
                      AND K.KURUMTIPI                LIKE '%'+ @KTIP
                      AND CONVERT(VARCHAR(4),S.SLXA) LIKE '%'+ @BRANS
                      AND B.ARZT                     LIKE '%'+ @DR
    WHERE ROUND(TAKIPTUTAR / 1.08, 2) <> B.KTOPT
      AND TAKIPNO    IS NOT NULL 
      AND CONVERT(VARCHAR,BHDAT,112)  >= @T1 
      AND CONVERT(VARCHAR,BHDAT,112)  <= @T2
      AND TAKIPSEND                    = '3'
      AND ((@AMBU = 'G' and TEDAVITURU = @AMBU) OR (@AMBU IN ('A','Y','P') and AMBU = @AMBU) OR (@AMBU = '' and AMBU LIKE '%%'))
   ---------------------------------------------- 
END
-------------------------------------------------



