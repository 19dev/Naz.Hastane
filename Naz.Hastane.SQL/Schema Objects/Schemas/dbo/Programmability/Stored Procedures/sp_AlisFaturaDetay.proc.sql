

CREATE PROCEDURE [dbo].[sp_AlısFaturaDetay] @knr varchar(10),@snr varchar(10)
AS
declare @kdv float
set @kdv = 1.08

select sum(ADET*BIRIMF)TP,TANIM,GRUP,KNR,SNR  from SATHIZ 
where KNR = @knr and SNR = @snr 
GROUP BY TANIM,GRUP,KNR,SNR

