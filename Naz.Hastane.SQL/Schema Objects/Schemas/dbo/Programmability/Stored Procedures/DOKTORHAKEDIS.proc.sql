
--***********

CREATE PROCEDURE [dbo].[DOKTORHAKEDIS]
@knr varchar(6) ,
@snr varchar(3),
@tarih varchar(20),
@tutar float,
@mn varchar(10),
@user varchar(20),
@cdate varchar(10),
@ftutar float,
@faturano varchar(10)
AS

DECLARE @yuzde float

--select @ftutar = mtopt from behand
--where knr = @knr

set @yuzde = (@tutar/@ftutar)


INSERT INTO DOKTORLAR_FATURA_DETAY 
(KNR, SIRA, HKNR, HSNR, HSIRANO, HAREKETTIPI, FATNO, FATURANO,FATURATARIHI,
MAKNO, AMBU, TANIM, GRUP, CODE, TOPLAM, PAY, USER_ID,DATE_CREATE)



SELECT DK.KNR,
(select isnull(max(SIRA),0) from DOKTORLAR_FATURA_DETAY where KNR=DK.KNR) as sira,
@knr as hknr,
@snr as hsnr,
hz.SIRANO as hsirano,
'F','',@faturano,
@tarih,@mn as makno,
B.AMBU,H.TANIM,H.GRUP,H.CODE,
(HZ.adet*(Hz.satısF+HZ.KSATISF)),(((HZ.adet*(Hz.satısF+HZ.KSATISF)*@yuzde)/100)*H.dryuzde),
@user,@cdate
from HIZMET H

inner join HIZIL HZ on H.TANIM=HZ.TANIM and H.GRUP=HZ.GRUP and H.CODE=HZ.CODE
inner join BEHAND B on B.KNR=HZ.KNR and B.SNR=HZ.SNR 
INNER JOIN DOKTORLAR DK ON HZ.ARZT2 = DK.ARZT
left join HIZMETDOKTORYUZDE HDY on H.TANIM=HDY.TANIM and H.GRUP=HDY.GRUP and H.CODE=HDY.CODE and HDY.ARZT=HZ.ARZT2
where HZ.KNR=@knr and HZ.SNR=@snr AND h.dryuzde <>0
