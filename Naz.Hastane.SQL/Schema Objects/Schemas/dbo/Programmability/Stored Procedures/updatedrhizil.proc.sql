


CREATE PROCEDURE [dbo].[updatedrhızıl] 
@Id int ,@sf float ,@kf float ,@KPAY FLOAT , @HPAY FLOAT
AS

update DRHIZIL
set satısf = @sf,ksatısf = @kf ,H_PAY = @HPAY,K_PAY = @KPAY
where KAYITID = @ID


