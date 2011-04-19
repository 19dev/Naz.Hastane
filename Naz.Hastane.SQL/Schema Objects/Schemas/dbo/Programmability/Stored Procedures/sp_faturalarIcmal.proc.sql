









CREATE PROCEDURE [dbo].[sp_faturalarIcmal] @t1 varchar(10),@t2 varchar(10),@ktip varchar(10)
AS

--declare @t1 varchar(10),@t2 varchar(10)
--set @t1 = '20060601' 
--set @t2 = '20063006'
--select '' as TakipNo,faturano,convert(varchar,faturatarıhı,112) as Tarih ,faturatutarı,[name]
--from fatura
--where convert(varchar,faturatarıhı,112) >= @t1 and convert(varchar,faturatarıhı,112) <= @t2

select b.takıpno as TakipNo,
--f.fatura_ıd,
b.faturano,
convert(varchar,f.faturatarıhı,112) as Tarih,
--,f.faturatutarı
f.faturatutarı,
f.name,k.FIXKURUM,isnull(f.teslimNo,'0'),(case when isnull(f.teslimNo,'0') = '0' then '0'  else '1' end) as GD
--,f.knr,k.adı1
from fatura f
inner join behand b on b.FATURANO = f.FATURA_ID
left join kuradr k on substring(f.knr,2,50) = k.knr
where convert(varchar,f.faturatarıhı,112) >= @t1 and convert(varchar,f.faturatarıhı,112) <= @t2
and f.ISIPTAL is null and k.adı1 = f.name and k.FIXKURUM not in ('7')
and k.kurumtıpı like '%'+ @ktip











