




















CREATE PROCEDURE [dbo].[sp_MedulaV3FaturatarihiAltTop] @t1 varchar(10), @t2 varchar(10),@ktip varchar(4),@AMBU varchar(4),@BRANS varchar(4)
AS


select round(SUM(TAKIPTUTAR),2) AS TTOPT ,round(SUM(KTOPT),2) AS KTOPT


from behand b
--left join SERVISLER s on s.slb = b.SERVIS
left join DOKTOR d on d.slb=b.ARZT
left join SERVISLER s on s.slb = d.slxx
inner join adres a on a.knr = b.knr 
inner join kuradr k on k.psg = a.psg
and k.kurumtıpı like '%'+ @ktip
and B.AMBU like '%'+ @AMBU
AND convert(varchar(4),S.SLXA)   like '%'+ @BRANS
where takıpno is not Null and convert(varchar,MEDFATURATARIHI,112) >= @t1 and convert(varchar,MEDFATURATARIHI,112) <= @t2
and TakıpSend =  '3'











