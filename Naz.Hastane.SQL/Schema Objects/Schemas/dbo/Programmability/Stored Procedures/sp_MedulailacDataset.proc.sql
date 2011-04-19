














CREATE PROCEDURE [dbo].[sp_MedulailacDataset] @TakipNo varchar(8) , @DataSet varchar(20)
AS


declare  @knr varchar(6), @snr varchar(3),
        @doktor varchar(10),@serviskodu varchar(10),@servis varchar(50),
        @ambu varchar(1),@CikisTarih varchar(10),@TaburcuKodu varchar(2),
        @Sonucu varchar(1000),@IstisnaiDurum varchar(2) , @Sonucaciklama varchar(1000),
        @TesisKodu varchar(10) ,@kod varchar(20),@sorguturu varchar(7),@protokolno varchar(100),@KNR1 VARCHAR(6)
      --,@TakipNo varchar(8), @DataSet varchar(15)

--set @TakipNo = '12345678'

select @TesisKodu = slt from keydat
where slk = '00' and  slb = 'INT_GSSKOD'

select @knr = knr,@snr = snr from MEDILACRAPOR
where SNR = @SNR


if @Dataset = 'Giris'
begin

select @SonucAciklama = substring(TA.ONTANI,1,1000) + substring(TA.TESHISVETEDAVI,1,1000)+ ISNULL (TD.TEDAVI,'') 
from TET_ANAMNEZ TA
left join TET_MUAYENE_DETAY_01 TD ON TD.KNR = TA.KNR 
WHERE TA.KNR = @KNR AND TA.SNR = @SNR


select  @knr = b.knr ,@snr = b.snr ,@doktor = b.ARZT , 

@servis = S.SLXA ,
@protokolno=(case when replace(replace(TA.PROTNO,'.',''),' ','') = ''  then @KNR+@SNR  else TA.PROTNO end),
@ambu = (case when ( b.ambu = 'P 'or  b.ambu = 'A')   then 'A' else 'Y' end),
@CikisTarih = replace(replace((isnull( convert(varchar,B.MCIKISTARIHI,112) , convert(varchar,BHDAT,112))),'.',''),' ',''), 
@TaburcuKodu ='2',@Sonucu = @Sonucaciklama,@IstisnaiDurum = '0',@sorguturu=s.slya
from behand b
left join DOKTOR d on d.slb=b.ARZT
left join SERVISLER s on s.slb = d.slxx
left join TET_ANAMNEZ TA  on TA.KNR=B.KNR AND TA.SNR=B.SNR
where TakıpNo = @TakipNo



select *
from
(
select @TakipNo as takipNo,@TesisKodu as saglikTesisKodu,@servis as bransKodu,@ambu as tedaviTuru,
@sorguturu as sorguTuru, @protokolno as protokolNo,@CikisTarih as hastaCikisTarihi,
@TaburcuKodu as taburcuKodu,@Sonucu as sonucAciklama,@IstisnaiDurum as istisnaiDurum
) as RaporGirisDVO

end


--*** Tanı Bilgisi
if @Dataset = 'Tani'
begin

select substring(TESHISKODU,3,10) as taniKodu,'2' as taniTipi,'E' as birincilTani
from TET_ANAMNEZ_DETAY
where knr = @knr and snr = @snr

end

--*** Tanı Bilgisi



--*** Muayene Bilgisi ( Tanım Bilgisi = 01) 

if @Dataset = 'HASTA'
begin

 select
H.HSTTCNO AS TCNO,
H.HSTSNO AS SNO,
H.HSTKNO AS KNO, 
H.HSTYKODU AS YKODU, 
H.HSTPTIPI AS PTIPI,
 convert(varchar,H.HSTPTARIH,112) as PTARIH,
H.HSTDEVKURUM AS DEVKURUM ,
H.HSTSGTURU AS SGTURU 

from MEDILACRAPOR  h

where knr = @knr and  SNR=@SNR
end


if @Dataset = 'DOKTOR'
begin

 select
H.DRTESNO AS DRTESNO,
H.DRADI AS DRADI,
H.DRSOYADI AS DRSOYADI, 
H.DRBRANSKODU AS DRBRANSKODU, 
H.DRTIPI AS DRTIPI


from MEDILACRAPOR  h

where knr = @knr and  snr=@snr
end


if @Dataset = 'TESHIS'
begin

 select
 convert(varchar,H.RAPORBASTARIH,112) as  RAPORBASTARIH,
 convert(varchar,H.RAPORBITTARIH,112) as RAPORBITTARIH,
RAPORTESKOD AS RAPORTESKOD
from  MEDRAPTESHIS  h

where knr = @knr and  snr=@snr
end

if @Dataset = 'RAPOR'
begin

 select
H.RAPORNO AS RAPNO,
 convert(varchar,H.RAPORTARIHI,112) as RAPTARIH,
H.RAPORTURU AS RAPTUR, 
 convert(varchar,H.RAPORBASTARIH,112)  AS RAPBASTARIH, 
 convert(varchar,H.RAPORBITTARIH,112)   AS RAPBITTARIH,

H.RAPORDTUR AS RAPDTUR,
H.RAPPROTNO AS RAPPNO ,
convert(varchar,H.RAPPROTTARIH,112) AS RAPPTRARIH ,
H.RAPACIKLAMA AS RAPACIKLAMA, 
H.RAPDURUM AS RAPDURUM, 
H.TAKIPNO AS TAKIPNO ,

H.HSTTCNO AS TCNO,
H.HSTSNO AS SNO,
H.HSTKNO AS KNO, 
H.HSTYKODU AS YKODU, 
H.HSTPTIPI AS PTIPI,
 convert(varchar,H.HSTPTARIH,112) as PTARIH,
H.HSTDEVKURUM AS DEVKURUM ,
H.HSTSGTURU AS SGTURU 


from MEDILACRAPOR  h

where knr = @knr and  snr=@snr
end
--*** Muayene Bilgisi ( Tanım Bilgisi = 01) 

---*Radyoloj














