




CREATE PROCEDURE [dbo].[sp_MedulaV3FaturaGönderilmiş]  @t1 varchar(10), @t2 varchar(10),@ktip varchar(4),@AMBU varchar(4),@BRANS varchar(4),@DR varchar(4)
AS

select b.hastabasno,b.takıpno ,b.knr as HastaNo ,b.snr,b.bhdat,convert(varchar,CIKTAR,104),a.hastaadı as HastaAdı ,a.hastasoyadı as hastaSoyAdı, 
convert(varchar(4),S.SLXA) as BrasKodu ,B.TEDAVITURU as TedaviTuru,
(CASE (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI') WHEN '1' THEN round(TAKIPTUTAR,2) WHEN '0' THEN round(TAKIPTUTAR/1.08,2) WHEN '2' THEN round(TAKIPTUTAR,2)  END) AS TAKIPTUTAR
,B.KTOPT,
(CASE (SELECT SLXA FROM KEYDAT WHERE SLK='00' AND SLB='KDVORANI') WHEN '1' THEN round(TAKIPTUTAR,2)-round(KTOPT,2) WHEN '0' THEN round((TAKIPTUTAR/1.08),2)-round(KTOPT,2) WHEN '2' THEN round(TAKIPTUTAR,2)-round(KTOPT,2) END) AS FARK
--FARKTUTAR AS FARK
,b.TESLIMNO,convert(varchar,MEDFATURATARIHI,104),b.faturano,b.medfattutar,EV_ADRES,EV_TEL1
from behand b
--left join SERVISLER s on s.slb = b.SERVIS
left join DOKTOR d on d.slb=b.ARZT
left join SERVISLER s on s.slb = d.slxx
inner join adres a on a.knr = b.knr 
inner join kuradr k on k.psg = a.psg
and k.kurumtıpı like '%'+ @ktip
 
AND convert(varchar(4),S.SLXA)   like '%'+ @BRANS
and B.ARZT like '%'+ @DR
where takıpno is not Null and convert(varchar,BHDAT,112) >= @t1 and convert(varchar,BHDAT,112) <= @t2
and TakıpSend =  '3' AND HASTABASNO<>''
AND ((@AMBU = 'G' and TEDAVITURU = @AMBU) OR (@AMBU IN ('A','Y','P') and AMBU = @AMBU) OR (@AMBU = '' and AMBU LIKE '%%'))
ORDER BY B.HASTABASNO
