

CREATE function [dbo].[udf_GetGunlukKasaBanka](
	@Tarih datetime)
	returns table 
	as 

	return (

	select 
		F.ODEMESEKLI as OdemeSekli,
		F.FTARIH AS Tarih,
		F.TCKIMLIKNO,
		HesapKodu,
		F.HNEREYEODENDI AS Aciklama,
		F.MFATNO as MakbuzNo,
		--F.USER_ID,
		SUM(F.BORC-F.ALACAK) AS Tutar,
		SUM(F.TUTAR) AS HizmetTutari,
		0 as KDVOrani,
		'Banka' as RecordType,
		F.USER_ID
		
	from  MuhasebeHesapKodu M
	left join 
	   (select  
			K.ODEMESEKLI,
			K.HNEREYEODENDI,
			ADRES.TCKIMLIKNO,
			'BORC'=SUM(CASE 
				WHEN BORCALACAK='B'  THEN TUTAR ELSE 0
				END), 
			'ALACAK'=SUM(CASE 
				WHEN BORCALACAK='A'  THEN TUTAR ELSE 0
				END),
			MAX(K.MAKBUZNO) as MXFATNO,
			MIN(K.MAKBUZNO) as MFATNO,
			CONVERT(VARCHAR(10), K.TARIH, 104) AS FTARIH,
			K.USER_ID,sum(K.TUTAR) as TUTAR
		from KASA K
			left join ADRES on ADRES.KNR = K.KNR
		Where
			K.TARIH >= @Tarih and K.TARIH < dateadd(d,1,@Tarih)
			and K.ODEMESEKLI = 'B'
			and K.ISIPTAL IS  NULL
		GROUP BY CONVERT(VARCHAR(10), K.TARIH, 104),K.USER_ID, K.ODEMESEKLI, ADRES.TCKIMLIKNO, K.ODEMESEKLI, K.HNEREYEODENDI ) F
	on F.USER_ID=M.UserID
	WHERE not M.HesapKodu like '391%'
	GROUP BY F.USER_ID, HesapKodu, HesapAdi, F.FTARIH, F.MFATNO, F.ODEMESEKLI, F.TCKIMLIKNO, F.HNEREYEODENDI, F.USER_ID
	having SUM(F.TUTAR) >0
	)
	
