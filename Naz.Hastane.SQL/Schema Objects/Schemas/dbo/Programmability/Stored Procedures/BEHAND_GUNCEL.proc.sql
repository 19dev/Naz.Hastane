﻿



CREATE PROCEDURE [dbo].[BEHAND_GUNCEL] 
@KNR VARCHAR(6) , @SNR VARCHAR(3)
 AS 
update behand 
set  MTOPT=(SELECT     SUM(ADET * SATISF)  from HIZIL WHERE     (KNR = @KNR) AND (SNR=@SNR)),  KTOPT=(SELECT     SUM(ADET * KSATISF)  from HIZIL WHERE     (KNR = @KNR) AND (SNR=@SNR))
WHERE     (KNR = @KNR) AND (SNR=@SNR)



