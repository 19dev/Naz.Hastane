



CREATE  PROCEDURE [dbo].[updateHDY] 
@kf float ,@sf float ,@KPAY FLOAT , @HPAY FLOAT,@Id int 
AS

update HIZMETDOKTORYUZDE_MUH
set sfiyatyuzde = @sf,kfiyatyuzde = @kf ,sfiyat = @HPAY,kfiyat = @KPAY
where KAYITID = @ID



