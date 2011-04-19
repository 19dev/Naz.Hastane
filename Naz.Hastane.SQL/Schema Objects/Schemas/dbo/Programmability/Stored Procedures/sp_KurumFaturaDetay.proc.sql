

CREATE PROCEDURE [dbo].[sp_KurumFaturaDetay] @fatno varchar(10) 
AS
declare @kdv float
set @kdv = 1.08
select 
(case when kdv = 0 THEN sum(ADET*(KSATISF/@kdv)) 
else sum(ADET*KSATISF) END) TP,
TANIM,GRUP,KNR,SNR,kdv  from KURHIZIL 
where KFATNO = @fatno
GROUP BY TANIM,GRUP,KNR,SNR,kdv

