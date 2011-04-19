

CREATE PROCEDURE [dbo].[sp_VezneTahsil] @tarih1 varchar(10),@tarih2 varchar(10),@Tip varchar(1) 
AS

--Declare @tarih1 varchar(10),@tarih2 varchar(10),@Tip varchar(1) 

--set @tarih1 = '20060601'
--set @tarih2 = '20060930'
--set @tip = 'P'

if @tip = 'N' or @tip = 'K' or @tip = 'Ç' or @tip = 'S' or @tip = 'T'
begin
if @tip = 'T' set @tip =''
SELECT VEZNE as Vezne,USER_ID as Kullanıcı, SUM(tUTAR_A) as Borç, SUM(tUTAR_B) as Alacak FROM
(SELECT vezne,USER_ID, CASE BORCALACAK WHEN 'A' THEN 0 ELSE tutar END AS tUTAR_A,
CASE BORCALACAK WHEN 'B' THEN 0 ELSE tutar END AS tUTAR_b
FROM kasa
WHERE TARIH BETWEEN @tarih1 AND @tarih2 and ODEMESEKLI LIKE @tip+'%'
) AS TMP
GROUP BY VEZNE,USER_ID
order BY VEZNE


end

if @tip = 'P'
begin
set @tip = 'K'
SELECT VEZNE as Vezne,USER_ID as Kullanıcı, POSNO as Pos,ltrim(substring(P.SLT,1,15)) as PosAdı,
SUM(tUTAR_A) as Borç, SUM(tUTAR_B) as Alacak FROM
(SELECT vezne,USER_ID,POSNO, CASE BORCALACAK WHEN 'A' THEN 0 ELSE tutar END AS tUTAR_A,
CASE BORCALACAK WHEN 'B' THEN 0 ELSE tutar END AS tUTAR_b
FROM kasa
WHERE TARIH BETWEEN @tarih1 AND @tarih2 and ODEMESEKLI LIKE @tip+'%'
) AS TMP
LEFT OUTER JOIN POSLAR P ON P.SLB = POSNO

GROUP BY VEZNE,USER_ID,POSNO,P.SLT
order BY VEZNE
  
end

