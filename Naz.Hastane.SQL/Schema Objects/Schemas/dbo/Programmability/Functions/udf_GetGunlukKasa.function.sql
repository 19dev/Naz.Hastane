

CREATE function [dbo].[udf_GetGunlukKasa](
	@Tarih datetime)
	returns table 
	as 

	return (

	select 
		'N' as OdemeSekli,
		F.FTARIH AS Tarih,
		'' as TCKIMLIKNO,
		HesapKodu,
		F.USER_ID + ' ' + ISNULL(HesapAdi,'')+MIN(F.MFATNO)+'-'+MAX(F.MXFATNO) AS Aciklama,
		F.MFATNO as MakbuzNo,
		--F.USER_ID,
		SUM(F.BORC-F.ALACAK) AS Tutar,
		SUM(F.TUTAR) AS HizmetTutari,
		0 as KDVOrani,
		'Kasa' as RecordType,
		F.USER_ID
		
	from  MuhasebeHesapKodu M
	left join 
	   (select  
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
		Where
			K.TARIH >= @Tarih and K.TARIH < dateadd(d,1,@Tarih) 
			and K.ISIPTAL IS  NULL
		GROUP BY CONVERT(VARCHAR(10), K.TARIH, 104),K.USER_ID ) F
	on F.USER_ID=M.UserID
		and HesapKodu in ('120 14 003')
	GROUP BY F.USER_ID, HesapKodu, HesapAdi, F.FTARIH, F.MFATNO, F.USER_ID
	having SUM(F.TUTAR) >0
	)
	
