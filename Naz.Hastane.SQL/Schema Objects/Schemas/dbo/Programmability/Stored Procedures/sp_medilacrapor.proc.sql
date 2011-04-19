




















CREATE PROCEDURE [dbo].[sp_medilacrapor]  @tarih1 varchar(10), @tarih2 varchar(10),@ktip varchar(4)
AS


--declare @tarih1 varchar(10), @tarih2 varchar(10) , @ktip varchar(4)
--set @tarih1 = '20060504'
--set @tarih2 = '20060505'
--set @ktip = '0008'
select M.knr as HastaNo ,M.snr,b.bhdat,M.hastaadı as HastaAdı ,M.hastasoyadı as hastaSoyAdı  ,DRBRANSKODU,(case when (b.ambu = 'P' or  b.ambu = 'A') then 'A' else 'Y' end) as TedaviTuru,RAPORNO, convert(varchar,RAPORTARIHI,104),
RAPORTURU
from MEDILACRAPOR M,BEHAND B
--left join SERVISLER s on s.slb = b.SERVIS
where convert(varchar,BHDAT,112) >= @tarih1 and convert(varchar,BHDAT,112) <= @tarih2 and  m.knr=b.knr and m.snr=b.snr
AND RAPGONDERILDI='0'















