

create function [dbo].[udf_GetGunlukFaturaYKasa](
	@Tarih datetime)
	returns table 
	as return (

	select 
		ODEMESEKLI as OdemeSekli,
		F.FTARIH,
		TCKIMLIKNO,
		M.HesapKodu,
		--F.USER_ID,
		F.ACIKLAMA as Aciklama,
		F.MAKBUZNO as MakbuzNo,
		'Tutar'= 
		  SUM(CASE 
			 WHEN CHARINDEX('120', M.HesapKodu) >0  THEN F.TUTAR
			  END),
		--SUM(F.BORC-F.ALACAK) AS BTUTAR,
		SUM(F.TUTAR) AS HizmetTutari,
		0 as KDVOrani,
		'Yatan Kasa' as RecordType
	from  MuhasebeHesapKodu M
	left join 
		(select 
			ADRES.TCKIMLIKNO,
			K.MAKBUZNO, 
			HNEREYEODENDI AS ACIKLAMA,
			'BORC'=SUM(CASE 
				WHEN BORCALACAK='B'  THEN TUTAR ELSE 0
				END), 
			'ALACAK'=SUM(CASE 
				WHEN BORCALACAK='A'  THEN TUTAR ELSE 0
				END),
			MAX(K.MAKBUZNO) as MXFATNO,
			MIN(K.MAKBUZNO) as MFATNO ,
			CONVERT(VARCHAR(10), K.TARIH, 104) AS FTARIH,
			K.USER_ID,
			sum(K.TUTAR) as TUTAR,
			K.ODEMESEKLI
		from KASA K  INNER JOIN ADRES ON K.KNR = ADRES.KNR
		Where
			K.TARIH >= @Tarih and K.TARIH < dateadd(d,1,@Tarih)
			and K.ISIPTAL IS  NULL and K.KNR = ADRES.KNR
		GROUP BY 
			CONVERT(VARCHAR(10), K.TARIH, 104), K.USER_ID, K.MAKBUZNO, HNEREYEODENDI, TCKIMLIKNO, K.ODEMESEKLI) F
	   on F.USER_ID = M.UserID
			and HesapKodu in ('120 01 023')
	GROUP BY F.USER_ID,HesapKodu ,HesapAdi,F.FTARIH,F.MAKBUZNO,F.ACIKLAMA, TCKIMLIKNO,ODEMESEKLI
	having SUM(F.TUTAR) >0
	
	)
	
