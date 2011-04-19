
















CREATE PROCEDURE [dbo].[sp_MedulaV3GönderilmişAltToplam]  @tarih1 varchar(10), @tarih2 varchar(10), @ktip varchar(4),@BRANS varchar(4),@AMBU varchar(4), @durum varchar(1)
AS

--declare @tarih1 varchar(10), @tarih2 varchar(10) , @ktip varchar(4)
--set @tarih1 = '20060504'
--set @tarih2 = '20060505'
--set @ktip = '0008'
select SUM(TAKIPTUTAR) AS TAKIPTUT,SUM(KTOPT) as KTOPT,SUM(TAKIPTUTAR)-SUM(KTOPT) as ftopt
from behand b
--left join SERVISLER s on s.slb = b.SERVIS
left join DOKTOR d on d.slb=b.ARZT
left join SERVISLER s on s.slb = d.slxx
inner join adres a on a.knr = b.knr
inner join kuradr k on a.psg = k.psg
where takıpno is not Null and convert(varchar,BHDAT,112) >= @tarih1 and convert(varchar,BHDAT,112) <= @tarih2
AND TAKIPNO<>''  AND (TAKIPNO IS NOT NULL)
and ( TakıpSend in (0,1,2,3,4,5)  AND  b.TAKIPSEND  like '%' + @DURUM)
AND ( k.kurumtıpı like '%'+ @ktip)
 AND   ( b.ambu like '%' + @ambu)
and b.ktopt>0 
AND (convert(varchar(4),S.SLXA)   like '%' + @BRANS)












