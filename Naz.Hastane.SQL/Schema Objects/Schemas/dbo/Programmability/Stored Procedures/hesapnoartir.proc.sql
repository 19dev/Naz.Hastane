


CREATE PROCEDURE [dbo].[hesapnoartir] (@hesapkodu varchar(20),@ay varchar(1),@kirilim varchar(20)) 
AS

declare @ifade varchar(20),@uzunluk int

set @ifade = (
select max(hesap_kodu) as hk from muh_hesap_plani where hesap_kodu like @hesapkodu+'%')

set @ifade = replace(@ifade,@ay,'')
set @ifade = @ifade +1
set @ifade = RIGHT(@ifade, @kirilim)

select @ifade


