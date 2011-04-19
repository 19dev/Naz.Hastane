



CREATE FUNCTION katsayi ( @tar datetime, @s1 varchar(10) , @s2 varchar(10))
RETURNS float

AS

BEGIN 
declare @k float 
set @k = (
select 
case when convert(varchar,@tar, 114) > @s1 and 
convert(varchar,@tar, 114) < @s2  then 1 else 1.5 end)


return(@k)
END







