﻿

CREATE PROCEDURE [dbo].[sp_KurumCariFaturaTum] @tarih1 varchar(10),@tarih2 varchar(10),@kurum varchar(20)
AS
DECLARE @KDV INT
SET @KDV = 8

select FATURANO,MAKNO,
convert(varchar(10),FATURATARIHI,112) as FATURATARIHI,NAME ,
(CASE WHEN f.KDVORANI = 0 THEN f.FATURATUTARI - (f.FATURATUTARI*@KDV)/100
else f.hızmettutarı end) as Tutar,
(CASE WHEN f.KDVORANI = 0 THEN @KDV ELSE KDVORANI END ) AS KDVORANI,
(CASE WHEN f.KDVORANI = 0 THEN (f.FATURATUTARI*@KDV)/100  
ELSE F.KDVTUTARI end) as KDVTUTARI,
(CASE WHEN f.KDVORANI = 0 THEN (f.FATURATUTARI)
ELSE HIZMETTUTARI + KDVTUTARI end) as GENELTOPLAM,
FATURATIPI,f.PSG,f.KNR,f.FATURA_ID,mk , k.hesap_kodu,F.ISODENDI
from FATURA F INNER JOIN KURADR K ON K.PSG=F.PSG
where F.FATURATARIHI>=@tarih1 and F.FATURATARIHI<=@tarih2 AND F.FATURATIPI='K'
and F.KNR= @kurum and ISIPTAL IS NULL
order by F.FATURATARIHI,F.FATURANO

