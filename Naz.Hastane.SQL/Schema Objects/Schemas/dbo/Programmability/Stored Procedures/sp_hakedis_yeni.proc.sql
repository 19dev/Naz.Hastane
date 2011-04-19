



CREATE  PROCEDURE [dbo].[sp_hakedis_yeni]
@tarih varchar(15),@tarih2 varchar(15),@doktorkod varchar(5000) 
AS
SELECT HZ.arzt2,H.TANIM,ky.slt,
sum(HZ.S_adet) adet,sum(((HZ.adet+hz.p_adet)*Hz.satısF)) as htut,
sum(((HZ.adet+Hz.p_adet)*Hz.ksatısF)) as ktut,
sum(((((HZ.adet+hz.p_adet)*Hz.satısF)/100)*Hdy.sfiyatyuzde)) as hpay,
sum(((((HZ.adet+hz.p_adet)*Hz.ksatısF)/100)*Hdy.kfiyatyuzde)) as kpay


from HIZMET H
inner join DRHIZIL HZ on H.TANIM=HZ.TANıM and H.GRUP=HZ.GRUP and H.CODE=HZ.CODE
--inner join BEHAND B on B.KNR=HZ.KNR and B.SNR=HZ.SNR 
inner join keydat ky on ky.slb = hz.tanım and ky.slk = '01'
inner join kuradr k on k.psg = hz.psg

left join HIZMETDOKTORYUZDE_MUH HDY on H.TANIM=HDY.TANIM and H.GRUP=HDY.GRUP 
and H.CODE=HDY.CODE and HDY.ARZT=HZ.ARZT2 and k.KURUMTIPI = HDY.kurum

where HZ.TARIH BETWEEN @tarih AND @tarih2 and  (HZ.IPTAL = '0' or HZ.IPTAL IS NULL) and
hz.arzt  in (@doktorkod)
group by hz.arzt2,h.tanım,ky.slt
order by hz.arzt2,h.tanım



