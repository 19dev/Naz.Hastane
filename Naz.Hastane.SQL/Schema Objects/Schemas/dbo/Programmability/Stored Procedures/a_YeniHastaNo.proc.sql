



CREATE PROCEDURE [dbo].[a_YeniHastaNo] 
AS
declare @SeqNo varchar(150)
 UPDATE KEYDAT
  SET @SeqNo = SLT = convert(varchar(150), convert(int,SLT) + 1 )
  WHERE SLK = '00' AND SLB = 'KNR'

 select @SeqNo
 

