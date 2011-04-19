

















CREATE PROCEDURE [dbo].[sp_MedulaDataset_e] @TakipNo varchar(8) , @DataSet varchar(20)
AS


declare  @knr varchar(6), @snr varchar(3),
        @doktor varchar(10),@serviskodu varchar(10),@servis varchar(50),
        @ambu varchar(1),@CikisTarih varchar(10),@TaburcuKodu varchar(2),
        @Sonucu varchar(1000),@IstisnaiDurum varchar(2) , @Sonucaciklama varchar(1000),
        @TesisKodu varchar(10)--,@TakipNo varchar(8), @DataSet varchar(15)

--set @TakipNo = '12345678'

select @TesisKodu = slt from keydat
where slk = '00' and  slb = 'INT_GSSKOD'

select @knr = knr,@snr = snr from behand
where takıpno = @takipno


if @Dataset = 'Giris'
begin

select @SonucAciklama = TA.ONTANI + substring(TA.TESHISVETEDAVI,1,99)--+ISNULL(TD.TEDAVI,'') 
from TET_ANAMNEZ TA
left join TET_MUAYENE_DETAY_01 TD ON TD.KNR = TA.KNR 
WHERE TA.KNR = @KNR AND TA.SNR = @SNR


select @knr = b.knr ,@snr = b.snr ,@doktor = b.ARZT , 

@servis = isnull(S.SLXA ,'0'),

@ambu = (case when b.ambu = 'P' then 'A' else 'Y' end),
@CikisTarih = (case when b.ambu = 'Y' then convert(varchar,CIKTAR,112) else convert(varchar,BHDAT,112) end ),

@TaburcuKodu = '2',@Sonucu = @Sonucaciklama,@IstisnaiDurum = '0'
from behand b
left join SERVISLER s on s.slb = b.SERVIS
where TakıpNo = @TakipNo


select *
from
(
select @TakipNo as takipNo,@TesisKodu as saglikTesisKodu,@servis as bransKodu,@ambu as tedaviTuru,
'N' as sorguTuru, @knr+@snr as protokolNo,@CikisTarih as hastaCikisTarihi,
@TaburcuKodu as taburcuKodu,@Sonucu as sonucAciklama,@IstisnaiDurum as istisnaiDurum
) as OdemeSorguGirisDVO

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

if @Dataset = 'Muayene'
begin

 
select replace(replace((isnull(hi.code1,h.code)),'.',''),' ','') as butKodu,

d.slvv as doktorTescilNo,

convert(varchar,tarıh,112) as muayeneTarihi,SIRANO as hizmetSunucuRefNo
from HIZIL h
left join hızmet_dıger_kod hi on hi.code = H.code and hi.but = 'B'
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
where knr = @knr and snr = @snr and hg.slx='5'

end
--*** Muayene Bilgisi ( Tanım Bilgisi = 01) 


--*** Tahlil Bilgisi (  = 1) 
if @Dataset = 'Tahlil'
begin
select replace(replace((isnull(hi.code1,h.code)),'.',''),' ','') as butKodu,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
d.slvv as doktorTescilNo,
TIPDATA.DBO.branskodubul(replace(replace((isnull(hi.code1,h.code)),'.',''),' ','')) as bransKodu,
--@servis as bransKodu,
SIRANO as hizmetSunucuRefNo
from HIZIL h
left join hızmet_dıger_kod hi on hi.code = H.code and hi.but = 'B'
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
where knr = @knr and snr = @snr and hg.slx = '1' and KSATISF > 0

end
--*** Tahlil Bilgisi (  = 1) 


--*** İlaç Bilgisi (  = 1) 

if @Dataset = 'İlac'
begin

select replace(replace(code,'.',''),' ','') as Barkod,
adet as adet,
convert(varchar,tarıh,112) as islemTarihi,

(case when replace(replace(code,'.',''),' ','') =  null then '2' else '1' end) as ilacTuru,
(case when
(case when replace(replace(code,'.',''),' ','') =  null then '2' else '1' end) = '2' then ksatısf else 0 end) as tutar,

SIRANO as hizmetSunucuRefNo
from HIZIL 
where knr = @knr and snr = @snr and tanım = '09' AND KSATISF > 0

end
--*** İlaç Bilgisi (  = 1) 

--*** Malzeme Bilgisi (  = 1) 
if @Dataset = 'Malzeme'
begin

select replace(replace(code,'.',''),' ','') as malzemeKodu,
adet as adet,
convert(varchar,tarıh,112) as islemTarihi,

(case when replace(replace(code,'.',''),' ','') =  null then '2' else '1' end) as ilacTuru,


SIRANO as hizmetSunucuRefNo
from HIZIL 
where knr = @knr and snr = @snr and tanım = '16' AND KSATISF > 0

end
--*** Malzeme Bilgisi (  = 1) 


-- *** Ameliyat

if @Dataset = 'Ameliyat'
begin

select replace(replace((isnull(hi.code1,h.code)),'.',''),' ','') as butKodu,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
d.slvv as doktorTescilNo,
s.slx as bransKodu,
SIRANO as hizmetSunucuRefNo
from HIZIL h
left join hızmet_dıger_kod hi on hi.code = H.code and hi.but = 'B'
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
left join SERVISLER s on s.slb = d.slxx
where knr = @knr and snr = @snr and hg.slx = '3'

end
-- *** Ameliyat


-- Diş 

if @Dataset = 'Dis' 
begin

select replace(replace((isnull(hi.code1,h.code)),'.',''),' ','') as butKodu,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
--d.slvv as doktorTescilNo,
--@servis as bransKodu,
(case when b.ambu = 'A' then 'E' else 'H' end) as acilDurum,
SIRANO as hizmetSunucuRefNo
from HIZIL h
left join hızmet_dıger_kod hi on hi.code = H.code and hi.but = 'B'
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
inner join Behand b on b.knr = h.knr and b.snr = h.snr
where h.knr = @knr and h.snr = @snr and hg.slx = '4'

end
-- Diş



-----Konsültasyon 
if @Dataset = 'konsültasyon' 
begin 
select replace(replace((isnull(hi.code1,h.code)),'.',''),' ','') as butKodu,
s.slx as bransKodu,
d.slvv as doktorTescilNo,
convert(varchar,tarıh,112)  as islemTarihi,
SIRANO as hizmetSunucuRefNo
from HIZIL h
left join hizmet_gruplari hg on hg.slb = h.tanım
left join hızmet_dıger_kod hi on hi.code = H.code and hi.but = 'B'
left join doktor d on d.slb = h.ARZT2
inner join Behand b on b.knr = h.knr and b.snr = h.snr
left join SERVISLER s on s.slb = b.SERVIS
where h.knr = @knr and h.snr = @snr and replace(replace((isnull(hi.code1,h.code)),'.',''),' ','')='520010'

end
---*Konsültasyon


-----Konsültasyon 
if @Dataset = 'Hastayatis' 
begin 
select replace(replace((isnull(hi.code1,h.code)),'.',''),' ','') as butKodu,
convert(varchar,b.bhdat,112) as YatisBaslangicTarihi,
convert(varchar,b.cıktar,112) as YatisBitisTarihi,
d.slvv as doktorTescilNo,
s.slx as bransKodu,
SIRANO as hizmetSunucuRefNo
from HIZIL h
left join hizmet_gruplari hg on hg.slb = h.tanım
left join hızmet_dıger_kod hi on hi.code = H.code and hi.but = 'B'
left join doktor d on d.slb = h.ARZT2
inner join Behand b on b.knr = h.knr and b.snr = h.snr
left join SERVISLER s on s.slb = b.SERVIS
where h.knr = @knr and h.snr = @snr and b.Ambu='y'

end
---*Konsültasyon

-----Radyloji 
if @Dataset = 'Radyoloji' 
begin 
select replace(replace((isnull(hi.code1,h.code)),'.',''),' ','') as butKodu,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
d.slvv as doktorTescilNo,
TIPDATA.DBO.branskoduBul(replace(replace((isnull(hi.code1,h.code)),'.',''),' ','')) as bransKodu,
--s.slx as bransKodu,
SIRANO as hizmetSunucuRefNo
from HIZIL h
left join hizmet_gruplari hg on hg.slb = h.tanım
left join hızmet_dıger_kod hi on hi.code = H.code and hi.but = 'B'
left join doktor d on d.slb = h.ARZT2
inner join Behand b on b.knr = h.knr and b.snr = h.snr
left join SERVISLER s on s.slb = b.SERVIS
where h.knr = @knr and h.snr = @snr and hg.slx='2' AND KSATISF > 0

end
---*Radyoloj

















