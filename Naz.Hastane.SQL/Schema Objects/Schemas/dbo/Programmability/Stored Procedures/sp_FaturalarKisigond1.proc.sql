






















CREATE PROCEDURE [dbo].[sp_FaturalarKisigond1] @FATTARIH varchar(10),@FATNO varchar(10) ,@ktip varchar(4),@AMBU varchar(4),@BRANS varchar(4)
AS

--declare @tarih1 varchar(10), @tarih2 varchar(10) , @ktip varchar(4)
--set @tarih1 = '20060504'
--set @tarih2 = '20060505'
--set @ktip = '0008'
select b.takıpno ,b.knr as HastaNo ,b.snr,b.bhdat,a.hastaadı as HastaAdı ,a.hastasoyadı as hastaSoyAdı, 
convert(varchar(4),S.SLXA) as BrasKodu ,(case when (b.ambu = 'P' or b.ambu = 'A')  then 'A' else 'Y' end) as TedaviTuru,
B.TAKIPTUTAR,B.KTOPT,b.TESLIMNO,convert(varchar,MEDFATURATARIHI,110)I,b.faturano,b.medfattutar,B.AMBU,B.PAKET,B.PAKET,EV_ADRES,EV_TEL1
from behand b
--left join SERVISLER s on s.slb = b.SERVIS
left join DOKTOR d on d.slb=b.ARZT
left join SERVISLER s on s.slb = d.slxx
inner join adres a on a.knr = b.knr 
inner join kuradr k on k.psg = a.psg
and k.kurumtıpı like '%'+ @ktip
and B.AMBU like '%'+ @AMBU
AND convert(varchar(4),S.SLXA)   like '%'+ @BRANS
and B.MEDFATURANO like '%'+ @FATNO
where takıpno is not Null and convert(varchar,MEDFATURATARIHI,112) = @FATTARIH
and TakıpSend =  '3'





