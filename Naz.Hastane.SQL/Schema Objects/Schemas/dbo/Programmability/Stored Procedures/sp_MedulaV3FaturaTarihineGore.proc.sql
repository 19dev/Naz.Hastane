
CREATE PROCEDURE [dbo].[sp_MedulaV3FaturaTarihineGöre]  @t1 varchar(10), @t2 varchar(10),@ktip varchar(4),@AMBU varchar(4),@BRANS varchar(4)
AS

--declare @tarih1 varchar(10), @tarih2 varchar(10) , @ktip varchar(4)
--set @tarih1 = '20060504'
--set @tarih2 = '20060505'
--set @ktip = '0008'
select b.hastabasno,b.takıpno ,b.knr as HastaNo ,b.snr,b.bhdat,
(case when replace(replace(AMBU,'.',''),' ','') ='P'  then convert(varchar,B.BHDAT,104)   else convert(varchar,B.CIKTAR,104) end) 
,a.hastaadı as HastaAdı ,a.hastasoyadı as hastaSoyAdı, 
convert(varchar(4),S.SLXA) as BrasKodu ,(case when (b.ambu = 'P' or b.ambu = 'A')  then 'A' else 'Y' end) as TedaviTuru,
(CASE (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI') WHEN '1' THEN round(TAKIPTUTAR,2) WHEN '0' THEN round(TAKIPTUTAR/1.08,2) WHEN '2' THEN round(TAKIPTUTAR,2)  END) AS TAKIPTUTAR
,B.KTOPT
,(CASE (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI') WHEN '1' THEN round(TAKIPTUTAR,2)-round(KTOPT,2) WHEN '0' THEN round((TAKIPTUTAR/1.08),2)-round(KTOPT,2) WHEN '2' THEN round(TAKIPTUTAR,2)-round(KTOPT,2) END) AS FARK
,b.TESLIMNO,convert(varchar,MEDFATURATARIHI,104),b.faturano,b.medfattutar,EV_ADRES,EV_TEL1
from behand b
--left join SERVISLER s on s.slb = b.SERVIS
left join DOKTOR d on d.slb=b.ARZT
left join SERVISLER s on s.slb = d.slxx
inner join adres a on a.knr = b.knr 
inner join kuradr k on k.psg = a.psg
and k.kurumtıpı like '%'+ @ktip
and B.AMBU like '%'+ @AMBU
AND convert(varchar(4),S.SLXA)   like '%'+ @BRANS
where takıpno is not Null and convert(varchar,MEDFATURATARIHI,112) >= @t1 and convert(varchar,MEDFATURATARIHI,112) <= @t2
and TakıpSend =  '3'
ORDER BY B.HASTABASNO












