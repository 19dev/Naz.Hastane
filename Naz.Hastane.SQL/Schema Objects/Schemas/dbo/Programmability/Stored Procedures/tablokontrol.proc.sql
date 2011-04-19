


CREATE PROCEDURE [dbo].[tablokontrol] 
@tablo varchar(50),@alan varchar(50),@tb varchar(50)
AS
if not exists ( 
select * from syscolumns s,sysobjects o where 
s.id=o.id and s.name=@alan and o.name=@tablo )


ALTER TABLE muh_login  ADD userp vharchar(50)


