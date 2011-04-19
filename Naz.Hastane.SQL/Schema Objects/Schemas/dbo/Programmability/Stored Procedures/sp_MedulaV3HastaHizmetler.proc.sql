























CREATE PROCEDURE [dbo].[sp_MedulaV3HastaHizmetler]  @KNR varchar(10), @SNR varchar(10)
AS

--declare @tarih1 varchar(10), @tarih2 varchar(10) , @ktip varchar(4)
--set @tarih1 = '20060504'
--set @tarih2 = '20060505'
--set @ktip = '0008'
select    B.TAKIPNO,B.HASTABASNO,CODE,TARIH, NAME1,ADET,KSATISF,HIZIL.KNR,HIZIL.SNR ,convert(varchar(4),hg.slx),B.AMBU,convert(varchar(4),SIRANO)   FROM HIZIL 
left join BEHAND B ON B.KNR=HIZIL.KNR AND B.SNR=HIZIL.SNR
left join hizmet_gruplari hg on hg.slb = HIZIL.tanım
WHERE 
HIZIL.KNR=@KNR AND 
HIZIL.SNR=@SNR and HIZIL.MEDONAY='0'














