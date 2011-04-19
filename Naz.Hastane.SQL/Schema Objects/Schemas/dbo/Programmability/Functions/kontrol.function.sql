



CREATE FUNCTION kontrol (@alan varchar(50) , @tablo varchar(50))  
RETURNS varchar(3)
AS
BEGIN 
declare @durum varchar(3)
set @alan = 'userp'
set @tablo = 'muh_login'

if  exists ( 
select * from syscolumns s,sysobjects o where 
s.id=o.id and s.name=@alan and o.name=@tablo) begin
set @durum = 'VAR' end else set @durum = 'YOK' 

return(@durum)
END




