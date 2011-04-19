
CREATE  PROCEDURE [dbo].[odemeal] 
@knr varchar(6) ,
@snr varchar(3),
@tarih varchar(20),
@tutar float,
@os varchar(1),
@pn varchar(10),
@mn varchar(10),
@user varchar(20),
@cdate varchar(20),
@fn varchar(10),
@vezne varchar(10),
@FTUTAR FLOAT
AS

declare @aid int , @MTOP FLOAT , @KASAB  FLOAT , @KASAA  FLOAT

--begin transaction

--select @mn = SLT from KEYDAT where SLK='00' and SLB='MAKNO'
--update KEYDAT set SLT= @mn 
--where SLK='00' and SLB='MAKNO'

update KEYDAT  set slt = slt +1
where SLK='00' and SLB='AVANS_ID'
select  @aid =SLT from KEYDAT where SLK='00' and SLB='AVANS_ID'


INSERT into AVANSLAR (AV_ID, KNR, SNR, TARIH, TUTAR, ODEMESEKLI, POSNO, MAKNO, USER_ID, DATE_CREATE)
values (@aid,@knr,@snr,@tarih,@tutar,@os,@pn,@mn,@user,@cdate)

INSERT into AVANSLAR_KULLANILAN (AV_ID,TARIH,FATURANO,TUTAR,USER_ID,DATE_CREATE)
values(@aid,@tarih,@fn,@tutar,@user,@cdate)

UPDATE AVANSLAR 
SET KULLANILAN = @tutar
WHERE AV_ID = @aid

INSERT into KASA (MAKNO, KNR, SNR, TARIH, MAKBUZNO, MAKBUZTIPI, ODEMESEKLI, POSNO, TUTAR, BORCALACAK, FATURANO, VEZNE, USER_ID, DATE_CREATE)
values (@mn,@knr,@snr,@tarih,0,'A',@os,@pn,@tutar,'B',@fn,@vezne,@user,@cdate)


EXEC DBO.DOKTORHAKEDIS @KNR,@SNR,@tarih,@tutar,@mn,@user,@cdate,@FTUTAR,@fn
