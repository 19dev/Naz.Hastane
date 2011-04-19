


CREATE PROCEDURE [dbo].[KASADURUM] (@TAR1 varchar(20) ,@TAR2 varchar(20))
AS

SELECT VEZNE,dovizcinsi, SUM(tUTAR_A) GİREN, SUM(tUTAR_B) ÇIKAN from

(SELECT VEZNE,dovizcinsi,
CASE BORCALACAK WHEN  'A' THEN 0 ELSE  tutar+tutardoviz END AS tUTAR_A,
CASE BORCALACAK WHEN 'B' THEN 0 ELSE TUTAR+tutardoviz END AS tUTAR_B

from KASA
where TARIH between @TAR1 and @TAR2)
AS TMp
GROUP BY VEZNE,dovizcinsi


