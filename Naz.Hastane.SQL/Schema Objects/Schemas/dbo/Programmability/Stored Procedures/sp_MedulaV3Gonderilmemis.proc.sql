







CREATE PROCEDURE [dbo].[sp_MedulaV3Gönderilmemis]  @TARIH1    VARCHAR(10), 
                                                  @TARIH2    VARCHAR(10),
                                                  @KTIP      VARCHAR(4),
                                                  @AMBU      VARCHAR(4),
                                                  @BRANS     VARCHAR(4),
                                                  @DR        VARCHAR(4),
                                                  @TAKIPSEND VARCHAR(2)
AS

-- @TAKIPSEND Değerleri
-- D : Diğer
-- H : Havuzdakiler
-- T : Tümü
-- HAVUZ_DURUMU
-- H : Hizmet
-- F : Fatura

 SELECT B.TAKIPNO,
        B.HASTABASNO,
        B.KNR AS HastaNo,
        B.SNR,
        B.BHDAT,  
        (CASE WHEN REPLACE(REPLACE(AMBU,'.',''),' ','') = 'P'  THEN B.BHDAT ELSE CONVERT(VARCHAR, B.CIKTAR, 104) END), 
        A.HASTAADI                 AS HastaAdı,
        A.HASTASOYADI              AS HastaSoyAdı, 
        CONVERT(VARCHAR(4),S.SLXA) AS BrasKodu,
        B.TEDAVITURU               AS TedaviTuru,
        B.KTOPT,
        B.TAKIPTURU,
        B.AMBU,
        B.PAKET,
        TEDAVITURU
   FROM BEHAND    B LEFT OUTER JOIN 
        DOKTOR    D ON D.SLB = B.ARZT
                    LEFT OUTER JOIN 
        SERVISLER S ON S.SLB = D.SLXX
                    INNER JOIN 
        ADRES     A ON A.KNR = B.KNR 
                    INNER JOIN 
        KURADR    K ON K.PSG = A.PSG
  WHERE TAKIPNO IS NOT NULL 
    AND CONVERT(VARCHAR,BHDAT,112) >= @TARIH1 
    AND CONVERT(VARCHAR,BHDAT,112) <= @TARIH2
    AND TAKIPNO      <> '' 
    AND ((    @TAKIPSEND = 'D' AND TAKIPSEND IN ('9','') AND ISNULL(HAVUZ_DURUMU,'') <> 'H') 
          OR (@TAKIPSEND = 'H' AND HAVUZ_DURUMU = 'H' AND TAKIPSEND IN ('9','')) 
          OR (@TAKIPSEND = 'T' AND TAKIPSEND IN ('9','')))
    AND K.KURUMTIPI  LIKE '%'+ @KTIP
    AND B.TEDAVITURU LIKE '%'+ @AMBU
    AND CONVERT(VARCHAR(4),S.SLXA) LIKE '%'+ @BRANS
    AND B.ARZT LIKE '%'+ @DR
  ORDER 
     BY B.HASTABASNO






