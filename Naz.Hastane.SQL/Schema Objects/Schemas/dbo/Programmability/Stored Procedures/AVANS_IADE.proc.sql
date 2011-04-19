
CREATE PROCEDURE [dbo].[AVANS_IADE] 
@tarih varchar(20),
@tutar float,
@user varchar(20),
@cdate varchar(10),
@aid int,
@mn int
AS

declare @makno int

UPDATE AVANSLAR 
SET IADEEDILEN = @TUTAR
WHERE AV_ID = @aid


INSERT into AVANSLAR_IADE(AV_ID,TARIH,IADEMAKNO,TUTAR,USER_ID,DATE_CREATE)
values(@aid,@tarih,@mn,@tutar,@user,@cdate)


update KEYDAT set SLT= slt + 1
where SLK='00' and SLB='MAKNO'

 select  @makno =SLT from KEYDAT where SLK='00' and SLB='MAKNO'



update  KASA
set ISIPTAL = 1
WHERE MAKNO = @mn


