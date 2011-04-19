






















CREATE PROCEDURE [dbo].[sp_MedulaV3HastaDataset] @SIRANO VARCHAR(8),@TakipNo varchar(8) , @DataSet varchar(20)
AS


declare  @knr varchar(6), @snr varchar(3),
        @doktor varchar(10),@serviskodu varchar(10),@servis varchar(50),
        @ambu varchar(1),@CikisTarih varchar(10),@TaburcuKodu varchar(2),@hstbasno varchar(20),
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
from BEHAND  BH 
left join BEHAND_DETAY  BD ON BD.KNR = BH.KNR AND    BH.SNR = BD.SNR AND BH.SERVIS=BD.SERVIS AND BH.ARZT=BD.ARZT
left join TET_ANAMNEZ  TA ON TA.KNR = BD.KNR AND    TA.SNR = BD.SNR AND BD.GELISTARIHI=TA.GELIS_TARIHI
WHERE BH.KNR = @KNR AND BH.SNR = @SNR




select  @knr = b.knr ,@snr = b.snr ,@doktor = b.ARZT ,

@servis = S.SLXA ,
@protokolno=(case when replace(replace(TA.PROTNO,'.',''),' ','') = ''  then @KNR+@SNR  else TA.PROTNO end),
@ambu = (case when ( b.ambu = 'P 'or  b.ambu = 'A')   then 'A' else 'Y' end),
@CikisTarih =(SELECT CONVERT(VARCHAR,MAX(TARIH),112)  FROM HIZIL  WHERE KNR=@KNR AND SNR=@SNR),
@TaburcuKodu =(case when replace(replace(substring(b.tabkodu,2,1),'.',''),' ','') =0  then substring(b.tabkodu,1,2)  else substring(b.tabkodu,2,1) end),@Sonucu = @Sonucaciklama,
@IstisnaiDurum = (case when (BH.ISTISNAIDURUM=NULL)   then '0' else  BH.ISTISNAIDURUM  end),
@Eksorgu = (case when (BH.EKSORGU=NULL)   then 'H' else  BH.EKSORGU  end),
@sorguturu=s.slya,
@hstbasno=b.HASTABASNO
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
@sorguturu as sorguTuru, @protokolno as protokolNo,@CikisTarih as hastaCikisTarihi,@Eksorgu as Eksorgu,
@TaburcuKodu as taburcuKodu,@Sonucu as sonucAciklama,@IstisnaiDurum as istisnaiDurum,@hstbasno as hstbasno
) as OdemeSorguGirisDVO

end


--*** Tanı Bilgisi
if @Dataset = 'Tani'
begin

select substring(TESHISKODU,3,10) as taniKodu,
isnull(TANITIPI,'2') as taniTipi  ,
isnull(BIRINCILTANI,'E')  AS  birincilTani,
SIRANO AS hizmetsunucuRefno
from TET_ANAMNEZ_DETAY
where knr = @knr and snr = @snr

end

--*** Tanı Bilgisi



--*** Muayene Bilgisi ( Tanım Bilgisi = 01) 
if @Dataset = 'Discode'
begin
select (case when ( replace(replace(Hi.bkodu,'.',''),' ','') = '' OR  replace(replace(Hi.bkodu,'.',''),' ','') = NULL )  then h.code  else hi.bkodu end) as butKodu,
hi.BKODU 
from HIZIL h
left join HIZMET  hi on h.tanım=hi.tanım AND  h.grup=hi.grup and h.code = hi.code
where knr = @knr and snr = @snr 
end



if @Dataset = 'Muayene'
begin

select (case when ( replace(replace(Hi.bkodu,'.',''),' ','') = '' OR  replace(replace(Hi.bkodu,'.',''),' ','') = NULL )  then h.code  else hi.bkodu end) as butKodu,
hi.BKODU ,
h.NAME1,
H.KSATISF,
s.slxa as bransKodu,
d.slvv as doktorTescilNo,
convert(varchar,tarıh,112) as muayeneTarihi,H.SIRANO as hizmetSunucuRefNo,
h.MEDSIRANO AS issırano
from HIZIL h
left join HIZMET  hi on h.tanım=hi.tanım AND  h.grup=hi.grup and h.code = hi.code
left join hizmet_gruplari hg on hg.slb = h.tanım 
left join doktor d on d.slb = h.ARZT2
inner join Behand b on b.knr = h.knr and b.snr = h.snr
left join SERVISLER s on s.slb = b.SERVIS
where h.knr = @knr and h.snr = @snr and hi.MBASLIK='5'   AND NOT( (case when  (hi.bkodu=NULL or   hi.bkodu= '')   then h.code else hi.bkodu end)='520010') AND  (hi.MEDGONDER='1' AND  H.FATURAEDILSIN='E') AND H.SIRANO=@SIRANO
end
--*** Muayene Bilgisi ( Tanım Bilgisi = 01) 


--*** Tahlil Bilgisi (  = 1) 
if @Dataset = 'Tahlil'
begin



SELECT @kod = CODE FROM HIZIL h
left join hizmet_gruplari hg on hg.slb = h.tanım
where h.knr = @knr and h.snr = @snr and hg.slx = '1'

if  NOT @kod is null
begin
select (case when ( replace(replace(Hi.bkodu,'.',''),' ','') = '' OR  replace(replace(Hi.bkodu,'.',''),' ','') = NULL )  then h.code  else hi.bkodu end) as butKodu,
hi.BKODU ,
H.NAME1,
h.KSATISF,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
d.slvv as doktorTescilNo,
TIPDATA.DBO.branskoduBul(replace(replace((isnull(hi.BKODU,h.code)),'.',''),' ','')) as bransKodu,
--s.slx as bransKodu,
H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM
from HIZIL h
left join hizmet_gruplari hg on hg.slb = h.tanım
left join HIZMET  hi on h.tanım=hi.tanım AND  h.grup=hi.grup and h.code = hi.code
left join doktor d on d.slb = h.ARZT2
inner join Behand b on b.knr = h.knr and b.snr = h.snr
left join SERVISLER s on s.slb = b.SERVIS
where h.knr = @knr and h.snr = @snr and hi.MBASLIK='1' AND  hi.MEDGONDER='1'  AND  H.FATURAEDILSIN='E' and H.SIRANO=@SIRANO
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
adet as adet,
IL.NAME1,
(CASE WHEN (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI')='1'  THEN round(h.KSATISF*1.08,2)   ELSE ( round(h.KSATISF,2) ) END) AS tutar,
convert(varchar,tarıh,112) as islemTarihi,
IL.KATKIPAYI AS Katkıpayı,
IL.ILACTURU as ilacTuru,
SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM 
from HIZIL H
left join  ILACSARF  IL on IL.CODE=h.code 
left join malzeme_grup  hg on hg.TANIM = h.tanım AND HG.GRUP=H.GRUP
where h.knr = @knr and h.snr = @snr and hg.slxa = 'I' and  h.akod=IL.AKOD  and h.grup=IL.GRUP AND  IL.MEDGONDER='1'  AND  H.FATURAEDILSIN='E'




end
--*** İlaç Bilgisi (  = 1) 

--*** Malzeme Bilgisi (  = 1) 
if @Dataset = 'Malzeme'
begin

SELECT (case when replace(replace(IL.NAME2,'.',''),' ','') =  '' then H.CODE  else IL.NAME2 end)  as malzemeKodu,
IL.NAME2,
IL.NAME1 as ADI,
IL.KATKIPAYI AS katkıpayı,
(CASE WHEN (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI')='1'  THEN round(h.KSATISF*1.08,2)   ELSE ( round(h.KSATISF,2) ) END) AS tutar,
IL.UBBCODE AS UBB,
adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
substring(IL.MALTURU,2,1) as ilacTuru,
(case when substring(IL.MALTURU,2,1)=  '3' then h.SATISF*h.adet  else h.SATISF   end)  as TUTAR1,
SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM
from HIZIL  h
left join  ILACSARF  IL on IL.CODE=h.code 
left join malzeme_grup  hg on hg.TANIM = h.tanım AND HG.GRUP=H.GRUP
where h.knr = @knr and h.snr = @snr and hg.slxa = 'M'   AND h.akod=IL.AKOD AND H.GRUP=IL.GRUP AND  IL.MEDGONDER='1'  AND  H.FATURAEDILSIN='E'

end




--*** Malzeme Bilgisi (  = 1) 


-- *** Ameliyat
if @Dataset = 'Ameliyat'
begin

select (case when ( replace(replace(Hi.bkodu,'.',''),' ','') = '' OR  replace(replace(Hi.bkodu,'.',''),' ','') = NULL )  then h.code  else hi.bkodu end) as butKodu,
h.NAME1,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
d.slvv as doktorTescilNo,
s.slxa as bransKodu,
H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM
from HIZIL h
left join HIZMET  hi on h.tanım=hi.tanım AND  h.grup=hi.grup and h.code = hi.code
left join hizmet_gruplari hg on hg.slb = h.tanım 
left join doktor d on d.slb = h.ARZT2
left join SERVISLER s on s.slb = d.slxx
where knr = @knr and snr = @snr and hi.MBASLIK = '3' AND  hi.MEDGONDER='1'  AND  H.FATURAEDILSIN='E'  and H.SIRANO=@SIRANO

end


-- *** Ameliyat



-- Diş 

if @Dataset = 'Dis' 
begin

select (case when ( replace(replace(Hi.bkodu,'.',''),' ','') = '' OR  replace(replace(Hi.bkodu,'.',''),' ','') = NULL )  then h.code  else hi.bkodu end) as butKodu,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
--d.slvv as doktorTescilNo,
--@servis as bransKodu,
(case when b.ambu = 'A' then 'E' else 'H' end) as acilDurum,
H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM,
h.name1 as name1
from HIZIL h
left join HIZMET  hi on h.tanım=hi.tanım AND  h.grup=hi.grup and h.code = hi.code
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
inner join Behand b on b.knr = h.knr and b.snr = h.snr
where h.knr = @knr and h.snr = @snr and hi.MBASLIK = '4' AND  hi.MEDGONDER='1'  AND  H.FATURAEDILSIN='E'  and H.SIRANO=@SIRANO

end
-- Diş



-----Konsültasyon 
if @Dataset = 'konsültasyon' 
begin 
select (case when ( replace(replace(Hi.bkodu,'.',''),' ','') = '' OR  replace(replace(Hi.bkodu,'.',''),' ','') = NULL )  then h.code  else hi.bkodu end) as butKodu,
h.name1,
h.KSATISF,
s.slxa as bransKodu,
d.slvv as doktorTescilNo,
convert(varchar,tarıh,112)  as islemTarihi,
H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUMfrom HIZIL h
left join HIZMET  hi on h.tanım=hi.tanım AND  h.grup=hi.grup and h.code = hi.code
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
left join SERVISLER s on s.slb = d.slxx
where h.knr = @knr and h.snr = @snr and replace(replace((isnull(hi.bkodu ,h.code)),'.',''),' ','')='520010' AND  hi.MEDGONDER='1'  AND  H.FATURAEDILSIN='E'  and H.SIRANO=@SIRANO

end
---*Konsültasyon


-----Konsültasyon 
if @Dataset = 'Hastayatis' 
begin 
select (case when ( replace(replace(Hi.bkodu,'.',''),' ','') = '' OR  replace(replace(Hi.bkodu,'.',''),' ','') = NULL )  then h.code  else hi.bkodu end) as butKodu,
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
from HIZIL h
left join HIZMET  hi on h.tanım=hi.tanım AND  h.grup=hi.grup and h.code = hi.code
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
left join SERVISLER s on s.slb = d.slxx
where knr = @knr and snr = @snr and hi.MBASLIK='6'  and not( h. tanım='09' or h.tanım='16') AND  hi.MEDGONDER='1'  AND  H.FATURAEDILSIN='E'  and H.SIRANO=@SIRANO


end

---*Konsültasyon

-----Radyloji 
if @Dataset = 'Radyoloji' 

begin
select (case when ( replace(replace(Hi.bkodu,'.',''),' ','') = '' OR  replace(replace(Hi.bkodu,'.',''),' ','') = NULL )  then h.code  else hi.bkodu end) as butKodu,
hi.bkodu,
h.name1,
H.KSATISF,
h.adet as adet,
convert(varchar,tarıh,112) as islemTarihi,
d.slvv as doktorTescilNo,
'3300' as bransKodu,
--s.slx as bransKodu,
H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM
from HIZIL h
left join hizmet_gruplari hg on hg.slb = h.tanım
left join HIZMET  hi on h.tanım=hi.tanım AND  h.grup=hi.grup and h.code = hi.code
left join doktor d on d.slb = h.ARZT2
inner join Behand b on b.knr = h.knr and b.snr = h.snr
left join SERVISLER s on s.slb = b.SERVIS
where h.knr = @knr and h.snr = @snr and hi.MBASLIK='2' AND  hi.MEDGONDER='1'  AND  H.FATURAEDILSIN='E'  and H.SIRANO=@SIRANO
end
else
begin
select '' as butKodu,'' as adet ,'' as islemTarihi,'' as doktorTescilNo,'' as bransKodu, 0 as hizmetSunucuRefNo
where 1=2
end

if @Dataset = 'Diger' 
begin 

 
select (case when ( replace(replace(Hi.bkodu,'.',''),' ','') = '' OR  replace(replace(Hi.bkodu,'.',''),' ','') = NULL )  then h.code  else hi.bkodu end) as butKodu,
hi.BKODU ,
h.NAME1,
h.KSATISF,
d.slvv as doktorTescilNo,
h.adet as adet,
s.slxa as bransKodu,
convert(varchar,tarıh,112) as islemTarihi,
convert(varchar,tarıh,112) as muayeneTarihi,H.SIRANO as hizmetSunucuRefNo,
ISDURUM AS ISDURUM
from HIZIL h
left join HIZMET  hi on h.tanım=hi.tanım AND  h.grup=hi.grup and h.code = hi.code
left join hizmet_gruplari hg on hg.slb = h.tanım
left join doktor d on d.slb = h.ARZT2
left join SERVISLER s on s.slb = d.slxx
where knr = @knr and snr = @snr and hi.MBASLIK='0'  and not( h. tanım='09' or h.tanım='16') AND  hi.MEDGONDER='1'  AND  H.FATURAEDILSIN='E' and H.SIRANO=@SIRANO

end
if @Dataset = 'Anamnez' 
begin 

select substring(TA.TESHISVETEDAVI,1,250)  AS sonucaciklama
,BH.TAKIPNO
,BH.PROTOKOLNO
,BH.TABKODU
 
from BEHAND  BH 
left join BEHAND_DETAY  BD ON BD.KNR = BH.KNR AND    BH.SNR = BD.SNR AND BH.SERVIS=BD.SERVIS AND BH.ARZT=BD.ARZT
left join TET_ANAMNEZ  TA ON TA.KNR = BD.KNR AND    TA.SNR = BD.SNR AND BD.GELISTARIHI=TA.GELIS_TARIHI
WHERE BH.KNR = @KNR AND BH.SNR = @SNR
end
---*Radyoloj











