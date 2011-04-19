













--CREATE PROCEDURE [dbo].[sp_BehandTakipALINMAMIS]  @tarih1 varchar(10), @tarih2 varchar(10),@ktip varchar(4)
--AS

----declare @tarih1 varchar(10), @tarih2 varchar(10)
----set @tarih1 = '20060504'
----set @tarih2 = '20060505'

--select b.knr as HastaNo ,b.snr,a.hastaadı as HastaAdı ,a.hastasoyadı as hastaSoyAdı, S.SLXA as BrasKodu ,(case when b.ambu = 'P' then 'A' else 'Y' end) as TedaviTuru,
--convert(varchar,b.BHDAT,112) as Tarih,b.ktopt,
--a.TCKIMLIKNO,a.SIGORTANO,a.BAGKARNENO,isnull(a.YAKINLIK,'0000'),a.DURUM,k.FIXKURUM
--from behand b
--left join SERVISLER s on s.slb = b.SERVIS
--inner join adres a on a.knr = b.knr
--inner join kuradr k on k.psg = a.psg
--where ( takıpno is Null or takıpno='')  and convert(varchar,BHDAT,112) >= @tarih1 and convert(varchar,BHDAT,112) <= @tarih2
--and (TakıpSend =  '9' or TakıpSend is  null) 
--and k.kurumtıpı like '%'+ @ktip
--order by BHDAT,a.hastaadı,a.hastasoyadı



