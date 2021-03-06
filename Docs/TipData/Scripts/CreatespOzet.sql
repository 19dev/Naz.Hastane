USE [TIPDATA]
GO
/****** Object:  StoredProcedure [dbo].[sp_MakeTempOzetC]    Script Date: 01/30/2011 11:08:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_MakeTempOzetP1] 
	@Tarih1 datetime,
	@Tarih2 datetime
as

truncate table rtblOzetP1

insert rtblOzetP1

SELECT 
	AYP = BEHAND.AMBU,
	Hasta = [Behand].[KNR] + [Behand].[SNR],
	Islem = HIZMET.TANIMEk,
	KURUM = HIZIL.PSG,
	Doktor = case when [HIZIL].[ARZT]='' then '{BOS}' else [HIZIL].[ARZT] end,
	Adet = Sum(HIZIL.ADET), 
	Toplam = Sum(([SATISF]+[KSATISF])*HIZIL.ADET)
	 
FROM 
	(BEHAND (NOLOCK) INNER JOIN HIZIL (NOLOCK) ON (BEHAND.KNR = HIZIL.KNR) AND (BEHAND.SNR = HIZIL.SNR)) 
	INNER JOIN HIZMET (NOLOCK) ON (HIZIL.TANIM = HIZMET.TANIM) AND (HIZIL.GRUP = HIZMET.GRUP) AND (HIZIL.CODE = HIZMET.CODE)
	
WHERE
	(((HIZIL.TARIH)>=@Tarih1 And (HIZIL.TARIH)<@Tarih2) AND ((HIZIL.TANIM + HIZIL.GRUP)<>'53001'))
	
GROUP BY 
	BEHAND.AMBU,
	[Behand].[KNR] + [Behand].[SNR],
	HIZMET.TANIMEk,
	HIZIL.PSG, 
	case when [HIZIL].[ARZT]='' then '{BOS}' else [HIZIL].[ARZT] end