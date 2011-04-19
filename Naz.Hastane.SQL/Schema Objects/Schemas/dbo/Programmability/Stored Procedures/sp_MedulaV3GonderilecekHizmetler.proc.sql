























CREATE PROCEDURE [dbo].[sp_MedulaV3GönderilecekHizmetler]   @tarih1 varchar(10), @tarih2 varchar(10)
AS

--declare @tarih1 varchar(10), @tarih2 varchar(10) , @ktip varchar(4)
--set @tarih1 = '20060504'
--set @tarih2 = '20060505'
--set @ktip = '0008'
select    B.TAKIPNO,B.HASTABASNO,A.HASTAADI,A.HASTASOYADI,HIZIL.CODE,convert(varchar,TARIH,104), HIZIL.NAME1,ADET,HIZIL.KSATISF,HIZIL.KNR,HIZIL.SNR ,B.AMBU,convert(varchar(4),hg.slx),convert(varchar(4),HIZIL.SIRANO),MEDSIRANO,HIZIL.TANIM   FROM HIZIL 
left join BEHAND B ON B.KNR=HIZIL.KNR AND B.SNR=HIZIL.SNR
left join hizmet_gruplari hg on hg.slb = HIZIL.tanım
inner join adres a on a.knr = b.knr 
left join HIZMET HIZ on HIZ.TANIM = HIZIL.tanım AND HIZ.CODE = HIZIL.CODE AND HIZ.GRUP = HIZIL.GRUP
WHERE 
 HIZIL.MEDONAY='0' AND  convert(varchar,TARIH,112) >= @tarih1 and convert(varchar,TARIH,112) <= @tarih2 AND TAKIPNO<>'' AND  takıpno is not Null AND (HIZ.MEDONAY=1)

ORDER BY HIZIL.KNR,HIZIL.SNR,HIZIL.SIRANO













