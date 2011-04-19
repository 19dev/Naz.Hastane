

CREATE PROCEDURE [dbo].[sp_KurumCariDurum] @knr varchar(6),@tarih1 varchar(10),@tarih2 varchar(10) 
AS
select '' as Tarih ,'' as Evrakno,'' as KOD,'Nakli Yekün' as  ACIKLAMA,
sum(CASE WHEN B_A = 'B' THEN (TUT) ELSE 0 END) BORC,
sum(CASE WHEN B_A = 'A' THEN (TUT) ELSE 0 END) ALACAK
FROM (
select B_A,sum(tutar) tut 
from SCARI  
WHERE    (KNR = @knr) AND --B_A = 'A' AND
(TARIH < @tarih1)
group by B_A

) AS TMP


UNION ALL

SELECT convert(varchar,TARIH,112) as Tarih
,EVRAKNO,
(case when KOD = 'T' then 'Makbuz' else 'Fatura' end) KOD,
ACIKLAMA,
(CASE WHEN B_A = 'B' THEN TUTAR ELSE 0 END) BORC,
(CASE WHEN B_A = 'A' THEN TUTAR ELSE 0 END) ALACAK
FROM SCARI
WHERE    (KNR = @knr) AND --B_A = 'A' AND
(TARIH BETWEEN @tarih1 AND @tarih2)
ORDER BY Tarih

