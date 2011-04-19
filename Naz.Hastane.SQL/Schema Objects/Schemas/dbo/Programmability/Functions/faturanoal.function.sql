



CREATE FUNCTION faturanoal (@keleg varchar(50) )
RETURNS varchar(20)
AS
BEGIN 
declare @fn varchar(50) , @str varchar(20) ,@uzunluk varchar(20) , @don int ,@ifade varchar(1)

set @fn = (select (SLT) from KEYDAT where SLK='00' and SLB=@keleg)

set @don=len(@fn)
set @str=''
set @ifade = substring(@fn,2,1)
if (@ifade <> '0' and @ifade <> '1' and @ifade <> '2' and @ifade <> '3' and @ifade <> '4' 
and @ifade <> '5' and @ifade <> '6' and @ifade <> '7' and @ifade <> '8' and @ifade <> '9')

BEGIN

set @str=SUBSTRING(@fn,1,2)
set @uzunluk=substring(@fn,3,@don)
--print @uzunluk
--print @str

set @uzunluk=@uzunluk+1
set @str = @str+@uzunluk

END
ELSE
BEGIN

set @str=SUBSTRING(@fn,1,1)
set @uzunluk=substring(@fn,2,@don)
--print @uzunluk
--print @str

set @uzunluk=@uzunluk
set @str = @str+@uzunluk

END
RETURN (@str)


END

















