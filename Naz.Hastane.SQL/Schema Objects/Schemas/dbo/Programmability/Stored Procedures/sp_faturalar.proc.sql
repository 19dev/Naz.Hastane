





CREATE PROCEDURE [dbo].[sp_faturalar] @t1 varchar(10),@t2 varchar(10)
AS

--declare @t1 varchar(10),@t2 varchar(10)
--set @t1 = '20060601' 
--set @t2 = '20063006'
select '' as TakipNo,faturano,convert(varchar,faturatarıhı,112) as Tarih,faturatutarı,[name]
from fatura
where convert(varchar,faturatarıhı,112) >= @t1 and convert(varchar,faturatarıhı,112) <= @t2





