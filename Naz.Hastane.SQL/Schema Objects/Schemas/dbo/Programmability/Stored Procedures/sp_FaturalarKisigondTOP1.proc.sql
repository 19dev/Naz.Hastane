





CREATE PROCEDURE [dbo].[sp_FaturalarKisigondTOP1]  @t1 varchar(10), @t2 varchar(10)
AS


select round(SUM(TAKIPTUTAR),2) AS TTOPT,round(SUM(KTOPT),2) AS KTOPT


from behand b

where takıpno is not Null and convert(varchar,BHDAT,112) >= @t1 and convert(varchar,BHDAT,112) <= @t2
and TakıpSend IN('3','4','5','6')



