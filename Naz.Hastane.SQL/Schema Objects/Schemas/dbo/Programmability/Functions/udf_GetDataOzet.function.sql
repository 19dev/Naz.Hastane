
CREATE function [dbo].[udf_GetDataOzet](
	@Tarih1 datetime,
	@Tarih2 datetime,
	@TarihCode varchar(10))
	returns table 
	as return (

	SELECT
		AYP, lngKurumTipiID, lngAnaIslemID, Doktor, Hasta, HastaneServis, AY, Sum(Adet) as Adet, sum(Toplam) as Toplam, TarihCode = @TarihCode
	FROM
	
	(SELECT 
		AYP = BEHAND.AMBU,
		lngKurumTipiID = Kuradr.lngKurumTipiID,
		Islem = ISNULL(HIZMET.TANIMEk,HIZIL.TANIM),
		Doktor = case when [HIZIL].[ARZT]='' then '0000' else [HIZIL].[ARZT] end,
		Hasta = [Behand].[KNR] + [Behand].[SNR],
		AY = Month(HIZIL.TARIH),
		HastaneServis = BEHAND.SERVIS,

		Adet = Sum(HIZIL.ADET), 
		Toplam = Sum(([SATISF]+[KSATISF])*HIZIL.ADET),
		TarihCode = @TarihCode
		 
	FROM 
		((BEHAND (NOLOCK) INNER JOIN 
			HIZIL (NOLOCK) 
				ON BEHAND.KNR = HIZIL.KNR AND BEHAND.SNR = HIZIL.SNR) 
		LEFT JOIN 
			HIZMET (NOLOCK)
				ON HIZIL.TANIM = HIZMET.TANIM AND HIZIL.GRUP = HIZMET.GRUP AND HIZIL.CODE = HIZMET.CODE)
		INNER JOIN
			Kuradr ON HIZIL.PSG = Kuradr.PSG
	WHERE
		(HIZIL.TANIM + HIZIL.GRUP)<>'53001'
		And
		(HIZIL.TARIH>=@Tarih1 And HIZIL.TARIH<@Tarih2)
		
	GROUP BY 
		BEHAND.AMBU,
		Kuradr.lngKurumTipiID, 
		ISNULL(HIZMET.TANIMEk,HIZIL.TANIM),
		case when [HIZIL].[ARZT]='' then '0000' else [HIZIL].[ARZT] end,
		[Behand].[KNR] + [Behand].[SNR],
		Month(HIZIL.TARIH),
		BEHAND.SERVIS
		
	) as q
	
	INNER JOIN tlkpAnaIslem ON q.Islem = tlkpAnaIslem.SLB

	GROUP BY AYP, lngKurumTipiID, lngAnaIslemID, Doktor, Hasta, HastaneServis, AY
	
	)