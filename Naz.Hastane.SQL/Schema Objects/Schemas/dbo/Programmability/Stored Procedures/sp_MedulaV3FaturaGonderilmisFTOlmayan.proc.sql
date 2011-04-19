

CREATE PROCEDURE [dbo].[sp_MedulaV3FaturaGönderilmişFTOlmayan]  @T1    VARCHAR(10), 
                                                               @T2    VARCHAR(10),
                                                               @KTIP  VARCHAR(4),
                                                               @AMBU  VARCHAR(4),
                                                               @BRANS VARCHAR(4),
                                                               @DR    VARCHAR(4)
AS

select b.hastabasno,b.takıpno ,b.knr as HastaNo ,b.snr,b.bhdat,convert(varchar,CIKTAR,104),a.hastaadı as HastaAdı ,a.hastasoyadı as hastaSoyAdı, 
convert(varchar(4),S.SLXA) as BrasKodu ,B.TEDAVITURU as TedaviTuru,
(CASE WHEN (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI')='1'  THEN round(TAKIPTUTAR*1.08,2)   ELSE ( round(TAKIPTUTAR,2) ) END) AS TAKIPTUTAR,B.KTOPT,
FARKTUTAR AS FARK
,b.TESLIMNO,convert(varchar,MEDFATURATARIHI,104),b.faturano,b.medfattutar,EV_ADRES,EV_TEL1

--SELECT b.Hastabasno,
--       b.takıpno ,
--       b.knr AS HastaNo,
--       b.snr,
--       b.bhdat,
--       CONVERT(VARCHAR, CIKTAR,104),
--       a.Hastaadı    AS HastaAdı ,
--       a.HastaSoyadı AS HastaSoyAdı, 
--       CONVERT(VARCHAR(4),S.SLXA) AS BrASKodu ,
--       (CASE WHEN (b.ambu = 'P' or b.ambu = 'A')  THEN 'A' ELSE 'Y' end) AS TedaviTuru,
--       (CASE WHEN (SELECT SLXA 
--                     FROM KEYDAT 
--                    WHERE SLK='00' 
--                      AND SLB='KDVORANI')='1'  THEN round(TAKIPTUTAR*1.08,2)  ELSE ( round(TAKIPTUTAR,2) ) END) AS TAKIPTUTAR,B.KTOPT,
--       FARKTUTAR AS FARK,
--       b.TESLIMNO,
--       CONVERT(VARCHAR,MEDFATURATARIHI,104),
--       b.faturano,
--       b.medfattutar,
--       EV_ADRES,
--       EV_TEL1
  FROM BEHAND    B LEFT OUTER JOIN 
       DOKTOR    D ON  d.slb = b.ARZT
                   LEFT OUTER JOIN 
       SERVISLER S ON  s.slb = d.slxx
                   LEFT OUTER JOIN 
       adres     a ON  a.knr = b.knr 
                   INNER JOIN 
       KURADR    K ON  K.PSG = A.PSG
                   AND K.KURUMTIPI                LIKE '%'+ @KTIP
                   AND CONVERT(VARCHAR(4),S.SLXA) LIKE '%'+ @BRANS
                   AND B.ARZT                     LIKE '%'+ @DR
 WHERE TAKIPNO IS NOT NULL 
   AND CONVERT(VARCHAR,BHDAT,112) >= @t1 
   AND CONVERT(VARCHAR,BHDAT,112) <= @t2
   AND TAKIPSEND                   =  '3'
   AND (MEDFATURATARIHI='' OR  MEDFATURATARIHI=NULL)
   AND ((@AMBU = 'G' and TEDAVITURU = @AMBU) OR (@AMBU IN ('A','Y','P') and AMBU = @AMBU) OR (@AMBU = '' and AMBU LIKE '%%'))
 ORDER 
    BY B.HastaBASNO




