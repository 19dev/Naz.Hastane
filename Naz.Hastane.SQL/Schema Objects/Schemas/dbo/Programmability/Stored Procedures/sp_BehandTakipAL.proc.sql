












--CREATE PROCEDURE [dbo].[sp_BehandTakipAL]  @tarih1 varchar(10), @tarih2 varchar(10),@ktip varchar(4),@AMBU varchar(4),@BRANS varchar(4)
--AS

----declare @tarih1 varchar(10), @tarih2 varchar(10) , @ktip varchar(4)
----set @tarih1 = '20060504'
----set @tarih2 = '20060505'
----set @ktip = '0008'
--select b.takıpno ,b.knr as HastaNo ,b.snr,b.bhdat,  (case when replace(replace(AMBU,'.',''),' ','') ='P'  then B.BHDAT  else B.CIKTAR  end), a.hastaadı as HastaAdı ,a.hastasoyadı as hastaSoyAdı, 
--convert(varchar(4),S.SLXA) as BrasKodu ,(case when (b.ambu = 'P' or  b.ambu = 'A') then 'A' else 'Y' end) as TedaviTuru,
--b.ktopt,b.TAKIPTURU,b.ambu,b.paket
--from behand b
----left join SERVISLER s on s.slb = b.SERVIS
--left join DOKTOR d on d.slb=b.ARZT
--left join SERVISLER s on s.slb = d.slxx
--inner join adres a on a.knr = b.knr 
--inner join kuradr k on k.psg = a.psg
--where takıpno is not Null and convert(varchar,BHDAT,112) >= @tarih1 and convert(varchar,BHDAT,112) <= @tarih2
-- AND TAKIPNO<>'' AND  (TakıpSend =  '9' or TakıpSend = '')
--and k.kurumtıpı like '%'+ @ktip
--and B.AMBU like '%'+ @AMBU
--AND convert(varchar(4),S.SLXA)   like '%'+ @BRANS
--order by SERVIS, BHDAT,a.hastaadı,a.hastasoyadı

