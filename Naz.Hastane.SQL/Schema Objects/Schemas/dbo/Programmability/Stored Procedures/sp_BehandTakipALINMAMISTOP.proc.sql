


















--CREATE PROCEDURE [dbo].[sp_BehandTakipALINMAMISTOP]  @tarih1 varchar(10), @tarih2 varchar(10),@ktip varchar(4)
--AS

----declare @tarih1 varchar(10), @tarih2 varchar(10)
----set @tarih1 = '20060504'
----set @tarih2 = '20060505'

--select SUM(KTOPT) AS TOPLAM
--from behand b
--left join SERVISLER s on s.slb = b.SERVIS
--inner join adres a on a.knr = b.knr
--inner join kuradr k on k.psg = a.psg
--where ( takıpno is Null or takıpno='')  and convert(varchar,BHDAT,112) >= @tarih1 and convert(varchar,BHDAT,112) <= @tarih2
--and (TakıpSend =  '9' or TakıpSend is  null) AND KTOPT>0
--and k.kurumtıpı like '%'+ @ktip



