



CREATE  PROCEDURE [dbo].[sp_hakedistanim] 
@tanım varchar(2),
@grup varchar(3),
@code varchar(10),
@arzt varchar (5),
@psg varchar(6),
@kfiyatyuzde float,
@sfiyatyuzde float,
@kfiyat float,
@sfiyat float
AS
/*
set @tanım = '01'
set @grup = '001'
set @code = '520030'
set @arzt = '0252'
set @fiylist = '03'
set @kfiyatyuzde = 10
set @sfiyatyuzde = 15
set @kfiyat = 0
set @sfiyat = 0
*/
if  exists (select * from hızmetdoktoryuzde_muh
where tanım=@tanım and grup=@grup and code=@code and arzt=@arzt and kurum=@psg)

update hızmetdoktoryuzde_muh
set kfiyatYuzde = @kfiyatyuzde ,
sfiyatYuzde = @sfiyatyuzde,
kfiyat = @kfiyat ,
sfiyat = @sfiyat
where tanım = @tanım and grup = @grup and code = @code and arzt = @arzt and kurum = @psg  
else
insert into hızmetdoktoryuzde_muh (tanım,grup,code,arzt,kfiyatYuzde,sfiyatYuzde,kfiyat,sfiyat,kurum)
values (@tanım , @grup , @code , @arzt , @kfiyatyuzde , @sfiyatyuzde , @kfiyat , @sfiyat , @psg)



