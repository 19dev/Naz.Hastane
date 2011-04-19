







CREATE PROCEDURE [dbo].[sp_MedulaV3RaporGönderilmemis]  @tarih1 varchar(10), @tarih2 varchar(10),@ktip varchar(4),@rtip varchar(1)
AS


select M.knr as HastaNo ,M.snr,b.bhdat,M.hastaadı as HastaAdı 
,M.hastasoyadı as hastaSoyAdı  
,DRBRANSKODU,(case when (b.ambu = 'P' or  b.ambu = 'A') then 'A' else 'Y' end) as TedaviTuru
,RAPORNO, convert(varchar,RAPORTARIHI,104),
RAPORTURU, 
RAPTURU,RAPTEDAVITURU
from MEDILACRAPOR M,BEHAND B
where 
convert(varchar,BHDAT,112) >= @tarih1 and convert(varchar,BHDAT,112) <= @tarih2 
AND  m.knr=b.knr and m.snr=b.snr
AND ( RAPTURU like '%'+ @rtip)
AND RAPGONDERILDI='0'








