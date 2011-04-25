﻿



CREATE  PROCEDURE [dbo].[sp_hakedisdetay_yeni]
@tarih varchar(15),@tarih2 varchar(15),@doktorkod varchar(5000) 
AS
SELECT H.code,H.TANIM,HZ.adet,Hz.name1,HZ.satısf*(hz.adet+hz.p_adet) as f,HZ.ksatısf*(hz.adet+hz.p_adet) as kf,

((HZ.adet+hz.p_adet)*Hz.satısF) as htut, HDY.SFiYATyuzde,
((HZ.adet+hz.p_adet)*Hz.ksatısF) as ktut,HDY.KFiYATYUZDE,
(case when hdy.sfiyat = 0 then ((((HZ.adet+hz.p_adet)*Hz.satısF)/100)*HDY.SFiYATyuzde) else ((HZ.adet+hz.p_adet)*Hdy.sfiyat)  end) as pay,

(case when hdy.kfiyat = 0 then ((((HZ.adet+hz.p_adet)*Hz.ksatısF)/100)*HDY.kFiYATyuzde) else ((HZ.adet+hz.p_adet)*Hdy.kfiyat)  end) as kpay,

(case when hdy.sfiyat = 0 then ((((HZ.adet+hz.p_adet)*Hz.satısF)/100)*HDY.SFiYATyuzde) else ((HZ.adet+hz.p_adet)*Hdy.sfiyat)  end) +
(case when hdy.kfiyat = 0 then ((((HZ.adet+hz.p_adet)*Hz.ksatısF)/100)*HDY.kFiYATyuzde) else ((HZ.adet+hz.p_adet)*Hdy.kfiyat)  end)
AS payt,


Hz.KNR,Hz.psg,Hz.tarıh,HZ.KAYITID,HZ.MAKNO,HZ.KFATNO,F.ISODENDI

from HIZMET H
inner join DRHIZIL HZ on H.TANIM=HZ.TANıM and H.GRUP=HZ.GRUP and H.CODE=HZ.CODE
--inner join BEHAND B on B.KNR=HZ.KNR and B.SNR=HZ.SNR 
inner join kuradr k on k.psg = hz.psg
left join HIZMETDOKTORYUZDE_MUH HDY on H.TANIM=HDY.TANIM and H.GRUP=HDY.GRUP 
and H.CODE=HDY.CODE and HDY.ARZT=HZ.ARZT2 and k.kurumtıpı = HDY.kurum
left join fatura F on F.FATURA_ID = HZ.KFATNO

where (HZ.TARIH BETWEEN @tarih AND @tarih2) and (HZ.IPTAL = '0' or HZ.IPTAL IS NULL) AND
HZ.ISLENDIMI = '0' AND (hdy.kfiyatyuzde<>0 and hdy.sfiyatyuzde<>0)
 and  (hz.k_pay >=0 or  hz.h_pay>=0) and
hz.arzt2 in (select datavalue from strtotable(@doktorkod,','))
order by HZ.tarıh,hz.arzt2,h.tanım


