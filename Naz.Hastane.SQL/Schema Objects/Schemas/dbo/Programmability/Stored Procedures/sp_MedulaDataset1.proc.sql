﻿
















CREATE PROCEDURE [dbo].[sp_MedulaDataset1] @TakipNo varchar(8) , @DataSet varchar(20)
AS


declare  @knr varchar(6), @snr varchar(3),
        @doktor varchar(10),@serviskodu varchar(10),@servis varchar(50),
        @ambu varchar(1),@CikisTarih varchar(10),@TaburcuKodu varchar(2),
        @Sonucu varchar(1000),@IstisnaiDurum varchar(2) , @Sonucaciklama varchar(1000),@Eksorgu varchar(2),
        @TesisKodu varchar(10) ,@kod varchar(20),@sorguturu varchar(7),@protokolno varchar(100)
      --,@TakipNo varchar(8), @DataSet varchar(15)

--set @TakipNo = '12345678'

select @TesisKodu = slt from keydat
where slk = '00' and  slb = 'INT_GSSKOD'

select @knr = knr,@snr = snr from behand
where takıpno = @takipno


if @Dataset = 'Giris'
begin

select @SonucAciklama = substring(TA.ONTANI,1,1000) + substring(TA.TESHISVETEDAVI,1,1000) 
from BEHAND_DETAY  BD
left join TET_ANAMNEZ  TA ON TA.KNR = BD.KNR AND    TA.SNR = BD.SNR AND BD.GELISTARIHI=TA.GELIS_TARIHI
WHERE BD.KNR = @KNR AND BD.SNR = @SNR AND BD.AMBU='Y'
 

select  @knr = b.knr ,@snr = b.snr ,@doktor = b.ARZT , 

@servis = S.SLXA ,
@protokolno=(case when replace(replace(TA.PROTNO,'.',''),' ','') = ''  then @KNR+@SNR  else TA.PROTNO end),
@ambu = (case when ( b.ambu = 'P 'or  b.ambu = 'A')   then 'A' else 'Y' end),
@CikisTarih = (case when b.ambu = 'Y' then convert(varchar,CIKTAR,112) else convert(varchar,BHDAT,112) end ),
@TaburcuKodu =(case when replace(replace(substring(b.tabkodu,2,1),'.',''),' ','') =0  then substring(b.tabkodu,1,2)  else substring(b.tabkodu,2,1) end),@Sonucu = @Sonucaciklama,
@IstisnaiDurum = (case when (BH.ISTISNAIDURUM=NULL)   then '0' else  BH.ISTISNAIDURUM  end),
@Eksorgu = (case when (BH.EKSORGU=NULL)   then 'H' else  BH.EKSORGU  end),
@sorguturu=s.slya
from behand b
left join DOKTOR d on d.slb=b.ARZT
left join SERVISLER s on s.slb = d.slxx
left join TET_ANAMNEZ TA  on TA.KNR=B.KNR AND TA.SNR=B.SNR 
left join BEHAND_DETAY BH  on BH.KNR=B.KNR AND BH.SNR=B.SNR 
where TakıpNo = @TakipNo



select *
from
(
select @TakipNo as takipNo,@TesisKodu as saglikTesisKodu,@servis as bransKodu,@ambu as tedaviTuru,
@sorguturu as sorguTuru, @protokolno as protokolNo,@CikisTarih as hastaCikisTarihi,
@TaburcuKodu as taburcuKodu,@Sonucu as sonucAciklama,@IstisnaiDurum as istisnaiDurum,@Eksorgu as Eksorgu
) as OdemeSorguGirisDVO

end


--*** Tanı Bilgisi
if @Dataset = 'Tani'
begin


select substring(TESHISKODU,3,10) as taniKodu,
isnull(TANITIPI,'2') as taniTipi  ,
isnull(BIRINCILTANI,'E')  AS  birincilTani

from TET_ANAMNEZ_DETAY
where knr = @knr and snr = @snr

end

--*** Tanı Bilgisi



--*** Muayene Bilgisi ( Tanım Bilgisi = 01) 

if @Dataset = 'Muayene'
begin

 select
(case when replace(replace(Hi.bkodu,'.',''),' ','') = ''  then h.code  else hi.bkodu end) as butKodu,
hi.BKODU ,
h.NAME1,
H.KSATISF,
d.slvv as doktorTescilNo,
convert(varchar,tarıh,112) as muayeneTarihi,H.SIRANO as hizmetSunucuRefNo
from PHIZIL h
left join HIZMET  hi on hi.code = H.code and h.grup=hi.grup  and   h.tanım=hi.tanım 
left join hizmet_gruplari hg on hg.slb = h.tanım 
left join doktor d on d.slb = h.ARZT2
where knr = @knr and snr = @snr and hg.slx='5'  AND NOT( (case when  (hi.bkodu=NULL or   hi.bkodu= '')   then h.code else hi.bkodu end)='520010')  AND hi.MEDGONDER='1' AND  H.FATURAEDILSIN='E'
end
--*** Muayene Bilgisi ( Tanım Bilgisi = 01) 


--*** Tahlil Bilgisi (  = 1) 
if @Dataset = 'Tahlil'
begin



SELECT @kod = CODE FROM PHIZIL h
left join hizmet_gruplari hg on hg.slb = h.tanım
where h.knr = @knr and h.snr = @snr and hg.slx = '1'

if  NOT @kod is null
begin
select  (case when replace(replace(Hi.bkodu,'.',''),' ','') = ''  then h.code  else hi.bkodu end) as butKodu,
hi.BKODU ,
H.NAME1,
h.KSATISF,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
d.slvv as doktorTescilNo,
TIPDATA.DBO.branskoduBul((case when replace(replace(Hi.bkodu,'.',''),' ','') = ''  then h.code  else hi.bkodu end))  as bransKodu,
--s.slx as bransKodu,
H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM
from PHIZIL h
left join hizmet_gruplari hg on hg.slb = h.tanım
left join HIZMET  hi on hi.code = H.code and hi.grup=h.grup  and   h.tanım=hi.tanım 
left join doktor d on d.slb = h.ARZT2
inner join Behand b on b.knr = h.knr and b.snr = h.snr
left join SERVISLER s on s.slb = b.SERVIS
where h.knr = @knr and h.snr = @snr and hg.slx='1' AND hi.MEDGONDER='1' AND  H.FATURAEDILSIN='E'
end
else
begin
select '' as butKodu,'' as adet ,'' as islemTarihi,'' as doktorTescilNo,'' as bransKodu, 0 as hizmetSunucuRefNo
where 1=2
end
end

--*** Tahlil Bilgisi (  = 1) 


--*** İlaç Bilgisi (  = 1) 

if @Dataset = 'İlac'
begin

select (case when replace(replace(IL.NAME2,'.',''),' ','') =  '' then H.CODE  else IL.NAME2 end) as Barkod,
h.adet as adet,
H.NAME1,
(CASE WHEN (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI')='1'  THEN round(h.KSATISF*1.08,2)   ELSE ( round(h.KSATISF,2) ) END) AS tutar,
convert(varchar,tarıh,112) as islemTarihi,
IL.ILACTURU  as ilacTuru,
IL.KATKIPAYI,
SIRANO as hizmetSunucuRefNo ,ISDURUM AS ISDURUM
from PHIZIL H
left join  ILACSARF  IL on IL.CODE=h.code 
left join malzeme_grup  hg on hg.TANIM = h.tanım AND HG.GRUP=H.GRUP
where h.knr = @knr and h.snr = @snr and hg.slxa = 'I'  AND h.akod=IL.AKOD  and h.grup=IL.GRUP  AND IL.MEDGONDER='1' AND  H.FATURAEDILSIN='E'
end
--*** İlaç Bilgisi (  = 1) 

--*** Malzeme Bilgisi (  = 1) 
if @Dataset = 'Malzeme'
begin

SELECT (case when replace(replace(IL.NAME2,'.',''),' ','') =  '' then H.CODE  else IL.NAME2 end)  as malzemeKodu,
IL.NAME2,
H.NAME1 as ADI,
IL.UBBCODE AS UBB,
IL.KATKIPAYI AS katkıpayı,
(CASE WHEN (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI')='1'  THEN round(h.KSATISF*1.08,2)   ELSE ( round(h.KSATISF,2) ) END) AS tutar,
adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
substring(IL.MALTURU,2,1) as ilacTuru,

SIRANO as hizmetSunucuRefNo,

(case when substring(IL.MALTURU,2,1)=  '3' then h.kSATISF*h.adet  else h.kSATISF   end)  as TUTAR1,
ISDURUM AS ISDURUM
from PHIZIL  h
left join  ILACSARF  IL on IL.CODE=h.code 
left join malzeme_grup  hg on hg.TANIM = h.tanım AND HG.GRUP=H.GRUP
where h.knr = @knr and h.snr = @snr and hg.slxa = 'M'   AND h.akod=IL.AKOD AND H.GRUP=IL.GRUP  AND IL.MEDGONDER='1' AND  H.FATURAEDILSIN='E'

end




--*** Malzeme Bilgisi (  = 1) 


-- *** Ameliyat
if @Dataset = 'Ameliyat'
BEGIN
select (case when replace(replace(Hi.bkodu,'.',''),' ','') = ''  then h.code  else hi.bkodu end) as butKodu,
h.NAME1,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
 replace(replace((isnull(SUBSTRING(H.PSEANS,2,1) ,'')),'.',''),' ','') as SEANS,
d.slvv as doktorTescilNo,
(case when replace(replace(EUSCORE,'.',''),' ','') = ''  then '0'  else EUSCORE end) as  score ,
(case when replace(replace(SAGSOL,'.',''),' ','') = ''  then ''  else SAGSOL end) as  SAGSOL ,
s.slxa as bransKodu,
H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM
from PHIZIL h
left join HIZMET  hi on hi.code = H.code and hi.grup=h.grup  and   h.tanım=hi.tanım 
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
left join SERVISLER s on s.slb = d.slxx
where knr = @knr and snr = @snr and hg.slx = '3'  AND hi.MEDGONDER='1' AND  H.FATURAEDILSIN='E'
end



-- *** Ameliyat



-- Diş 

if @Dataset = 'Dis' 
begin

select (case when replace(replace(Hi.bkodu,'.',''),' ','') = ''  then h.code  else hi.bkodu end) as butKodu,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
--d.slvv as doktorTescilNo,
--@servis as bransKodu,
(case when b.ambu = 'A' then 'E' else 'H' end) as acilDurum,
H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM
from PHIZIL h
left join HIZMET  hi on hi.code = H.code and hi.grup=h.grup  and   h.tanım=hi.tanım 
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
inner join Behand b on b.knr = h.knr and b.snr = h.snr
where h.knr = @knr and h.snr = @snr and hg.slx = '4'  AND hi.MEDGONDER='1' AND  H.FATURAEDILSIN='E'

end
-- Diş



-----Konsültasyon 
if @Dataset = 'konsültasyon' 
begin 
select (case when replace(replace(Hi.bkodu,'.',''),' ','') = ''  then h.code  else hi.bkodu end) as butKodu,
h.name1,
h.KSATISF,
s.slxa as bransKodu,
d.slvv as doktorTescilNo,
convert(varchar,tarıh,112)  as islemTarihi,
H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUMfrom HIZIL h
left join HIZMET  hi on hi.code = H.code and hi.grup=h.grup  and   h.tanım=hi.tanım 
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
left join SERVISLER s on s.slb = d.slxx
where h.knr = @knr and h.snr = @snr and replace(replace((isnull(hi.bkodu ,h.code)),'.',''),' ','')='520010' AND  hi.MEDGONDER='1'  AND  H.FATURAEDILSIN='E'

end


---*Konsültasyon


-----Konsültasyon 
if @Dataset = 'Hastayatis' 
begin 


select (case when replace(replace(Hi.bkodu,'.',''),' ','') = ''  then h.code  else hi.bkodu end) as butKodu,
hi.BKODU ,
h.NAME1,
h.KSATISF,
d.slvv as doktorTescilNo,
h.adet as adet,
s.slxa as bransKodu,
convert(varchar,h.HYATISTARIHI,112) as yatisBaslangicTarihi,
convert(varchar,h.HCIKISTARIHI,112) as yatisBitisTarihi,
H.SIRANO as hizmetSunucuRefNo,
H.REFGUNSAY AS REFGUNSAY
from PHIZIL h
left join HIZMET  hi on hi.code = H.code and hi.grup=h.grup  and   h.tanım=hi.tanım 
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
left join SERVISLER s on s.slb = d.slxx
where knr = @knr and snr = @snr and hg.slx='6'  and not( h. tanım='09' or h.tanım='16') AND  hi.MEDGONDER='1'  AND  H.FATURAEDILSIN='E'

end

---*Konsültasyon

-----Radyloji 
if @Dataset = 'Radyoloji' 
begin 

SELECT @kod = CODE FROM PHIZIL h
left join hizmet_gruplari hg on hg.slb = h.tanım
where h.knr = @knr and h.snr = @snr and hg.slx = '2' 

if  NOT @kod is null
begin
select
(case when replace(replace(Hi.bkodu,'.',''),' ','') = ''  then h.code  else hi.bkodu end) as butKodu,
h.name1,
H.KSATISF,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
d.slvv as doktorTescilNo,
'3300' as bransKodu,
--s.slx as bransKodu,
H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM
from PHIZIL h
left join hizmet_gruplari hg on hg.slb = h.tanım
left join HIZMET  hi on hi.code = H.code and hi.grup=h.grup  and   h.tanım=hi.tanım 
left join doktor d on d.slb = h.ARZT2
inner join Behand b on b.knr = h.knr and b.snr = h.snr
left join SERVISLER s on s.slb = b.SERVIS
where h.knr = @knr and h.snr = @snr and hg.slx='2'  AND hi.MEDGONDER='1' AND  H.FATURAEDILSIN='E'
end
else
begin
select '' as butKodu,'' as adet ,'' as islemTarihi,'' as doktorTescilNo,'' as bransKodu, 0 as hizmetSunucuRefNo
where 1=2
end
end

if @Dataset = 'Diger' 
begin 

 SELECT
(case when replace(replace(Hi.bkodu,'.',''),' ','') = ''  then h.code  else hi.bkodu end) as butKodu,
hi.BKODU ,
h.NAME1,
h.KSATISF,
d.slvv as doktorTescilNo,
h.adet as adet,
s.slxa as bransKodu,
convert(varchar,tarıh,112) as islemTarihi,
convert(varchar,tarıh,112) as muayeneTarihi,H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM,
H.ISLEMSIRANO AS islemsırano
from PHIZIL h
left join HIZMET  hi on hi.code = H.code and hi.grup=h.grup  and   h.tanım=hi.tanım 
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
left join SERVISLER s on s.slb = d.slxx
where knr = @knr and snr = @snr and hg.slx='0' and  (NOT H.TANIM IN('09','16'))  AND hi.MEDGONDER='1' AND  H.FATURAEDILSIN='E'

end


---*Radyoloj









