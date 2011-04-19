









--CREATE PROCEDURE [dbo].[sp_BehandTakipALTOP]  @tarih1 varchar(10), @tarih2 varchar(10),@ktip varchar(4),@BRANS varchar(4),@AMBU varchar(4)
--AS

----declare @tarih1 varchar(10), @tarih2 varchar(10) , @ktip varchar(4)
----set @tarih1 = '20060504'
----set @tarih2 = '20060505'
----set @ktip = '0008'
--select SUM(KTOPT) AS KTOPT 
--from behand b
--left join DOKTOR d on d.slb=b.ARZT
--left join SERVISLER s on s.slb = d.slxx
--inner join adres a on a.knr = b.knr 
--inner join kuradr k on k.psg = a.psg
--where takıpno is not Null and convert(varchar,BHDAT,112) >= @tarih1 and convert(varchar,BHDAT,112) <= @tarih2
--and ktopt > 0 AND TAKIPNO<>'' AND  (TakıpSend =  '9' and TakıpSend is not null)
--and takıpno<>''
--and k.kurumtıpı like '%'+ @ktip
--and B.AMBU in(@ambu)
--AND convert(varchar(4),S.SLXA)   like '%'+ @BRANS



