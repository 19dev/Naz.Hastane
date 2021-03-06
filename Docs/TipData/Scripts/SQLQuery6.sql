USE [TIPDATA]
GO
/****** Object:  StoredProcedure [dbo].[sp_MakeTempOzetC]    Script Date: 01/29/2011 20:19:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[sp_MakeTempOzetC] 
@Tarih1 datetime,
@Tarih2 datetime
as

truncate table tblOzetC

insert tblOzetC

SELECT BEHAND.AMBU AS AYP, [Behand].[KNR] + [Behand].[SNR] AS Hasta, HIZMET.TANIMEk AS Islem, HIZIL.PSG AS Kurum,
 Doktor = case when [HIZIL].[ARZT]='' then '{BOS}' else [HIZIL].[ARZT] end , Sum(HIZIL.ADET) AS Adet, 
 Sum(([SATISF]+[KSATISF])*HIZIL.ADET) AS Toplam 
FROM (BEHAND (NOLOCK) INNER JOIN HIZIL (NOLOCK) ON (BEHAND.KNR = HIZIL.KNR) AND (BEHAND.SNR = HIZIL.SNR)) 
INNER JOIN HIZMET (NOLOCK) ON (HIZIL.TANIM = HIZMET.TANIM) AND (HIZIL.GRUP = HIZMET.GRUP) AND (HIZIL.CODE = HIZMET.CODE)
WHERE (((HIZIL.TARIH)>=@Tarih1 And (HIZIL.TARIH)<@Tarih2) AND ((HIZIL.TANIM + HIZIL.GRUP)<>'53001'))
GROUP BY BEHAND.AMBU, [Behand].[KNR] + [Behand].[SNR], HIZMET.TANIMEk, HIZIL.PSG, 
case when [HIZIL].[ARZT]='' then '{BOS}' else [HIZIL].[ARZT] end