
CREATE PROCEDURE [dbo].[sp_AlisFaturalari] @tarih1 varchar(10) ,@tarih2 varchar(10)
AS
select SB.FATURANO,'' as MAKNO,
convert(varchar(10),SB.FATURATARIHI,112) as FATURATARIHI,S.ADI1 as NAME,
sb.Toplam as Tutar,'' as KDVORANI,SB.KDVTUTARI,SB.GENELTOPLAM,
--(case when kdvtutarı <> 0 then sb.GENELTOPLAM/sb.kdvtutarı end) as KDV,
SB.ILACSARF as FATURATIPI,SB.KNR,SB.SNR ,'', '',s.hesap_kodu
from SATBEH SB
INNER JOIN SATADR S ON S.KNR = SB.KNR
WHERE SB.FATURATARIHI >= @tarih1 AND SB.FATURATARIHI <= @tarih2

