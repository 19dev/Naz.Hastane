



CREATE PROCEDURE [dbo].[a_YeniHastaZiyaretNo] 
@HastaNo varchar(6)
AS

declare @min int

 
select @min = MIN(convert(int,SNR)) 
from BEHAND
where KNR = @HastaNo
if @min is null
	set @min = 999
else 
	set @min = @min -1 

select @min 

