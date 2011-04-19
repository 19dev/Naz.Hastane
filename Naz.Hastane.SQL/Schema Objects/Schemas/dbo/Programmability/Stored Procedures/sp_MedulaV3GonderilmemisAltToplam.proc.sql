









CREATE PROCEDURE [dbo].[sp_MedulaV3GönderilmemişAltToplam]  @tarih1 varchar(10), @tarih2 varchar(10),@ktip varchar(4),@BRANS varchar(4),@AMBU varchar(4),@DR varchar(4),@TAKIPSEND VARCHAR(2)
AS

-- @TAKIPSEND Değerleri
-- D : Diğer
-- H : Havuzdakiler
-- T : Tümü
-- HAVUZ_DURUMU
-- H : Hizmet
-- F : Fatura

select SUM(b.KTOPT) AS KTOPT 
 
from behand b
--left join SERVISLER s on s.slb = b.SERVIS
left join DOKTOR d on d.slb=b.ARZT
left join SERVISLER s on s.slb = d.slxx
inner join adres a on a.knr = b.knr 
inner join kuradr k on k.psg = a.psg
where takıpno is not Null and convert(varchar,BHDAT,112) >= @tarih1 and convert(varchar,BHDAT,112) <= @tarih2
 AND TAKIPNO<>'' 
 AND ((    @TAKIPSEND = 'D' AND TAKIPSEND IN ('9','') AND ISNULL(HAVUZ_DURUMU,'') <> 'H') 
       OR (@TAKIPSEND = 'H' AND HAVUZ_DURUMU = 'H' AND TAKIPSEND IN ('9','')) 
       OR (@TAKIPSEND = 'T' AND TAKIPSEND IN ('9','')))
and k.kurumtıpı like '%'+ @ktip
and B.TEDAVITURU like '%'+ @AMBU
AND convert(varchar(4),S.SLXA)   like '%'+ @BRANS
and B.ARZT like '%'+ @DR






