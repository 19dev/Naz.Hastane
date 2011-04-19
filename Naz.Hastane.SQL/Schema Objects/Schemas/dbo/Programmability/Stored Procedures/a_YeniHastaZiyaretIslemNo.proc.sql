



create PROCEDURE [dbo].[a_YeniHastaZiyaretIslemNo] 
@HastaNo varchar(6),
@ZiyaretNo varchar(3)
AS

declare @max int

 
select @max = MAX(convert(int,SIRANO)) 
from HIZIL
where KNR = @HastaNo AND SNR = @ZiyaretNo
if @max is null
	set @max = 1
else 
	set @max = @max + 1 

select @max 

