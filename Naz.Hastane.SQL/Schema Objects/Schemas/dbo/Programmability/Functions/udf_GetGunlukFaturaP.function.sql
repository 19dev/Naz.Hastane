

CREATE function [dbo].[udf_GetGunlukFaturaP](
	@Tarih datetime)
	returns table 
	as return (

	select  
		F.ODEMESEKLI as OdemeSekli,
		F.FTARIH,
		'' as TCKIMLIKNO,
		HesapKodu as HesapKodu,
		ISNULL(M.HesapAdi,'')+MIN(F.MFATNO)+'-'+MAX(F.MXFATNO) AS Aciklama,
		F.MFATNO as MakbuzNo,
		'Tutar'= 
		  SUM(CASE 
			 WHEN CHARINDEX('600', M.HesapKodu) >0  THEN F.TUTAR
			 WHEN CHARINDEX('120', M.HesapKodu) >0  THEN F.TUTAR
			 WHEN CHARINDEX('391', M.HesapKodu) >0  THEN F.KDVT
			END),
		SUM(F.FATT) AS FaturaTutari,
		F.KDVORANI as KDVOrani,
		'Poliklinik Fatura' as RecordType,
		F.USER_ID
	from  MuhasebeHesapKodu M
		left join 
		(select KDVORANI,
			MAX(FATURA.FATURANO) as MXFATNO,
			MIN(FATURA.FATURANO) as MFATNO ,
			CONVERT(VARCHAR(10),FATURA.FATURATARIHI , 104) AS FTARIH,
			FATURA.USER_ID,
			sum(FATURA.HIZMETTUTARI) as TUTAR,
			sum(FATURA.KDVTUTARI) AS KDVT,
			sum(FATURA.FATURATUTARI) AS FATT,
			KASA.ODEMESEKLI
		from FATURA join KASA on FATURA.FATURA_ID = KASA.FATURANO
		where FATURA.ISIPTAL IS NULL and FATURA.FATURATARIHI >= @Tarih and FATURA.FATURATARIHI < dateadd(d,1,@Tarih )
		GROUP BY CONVERT(VARCHAR(10),FATURA.FATURATARIHI , 104), FATURA.USER_ID, FATURA.KDVORANI, KASA.ODEMESEKLI) F
	  on F.USER_ID = M.UserID and M.KDV = F.KDVORANI
	LEFT JOIN KEYDAT K ON 
		K.SLB=F.KDVORANI AND
		K.SLK='02' 
	WHERE M.KasaTipi = 'P'
	GROUP BY F.FTARIH, M.HesapKodu, M.HesapAdi, F.MFATNO, F.KDVORANI, F.ODEMESEKLI, F.USER_ID 
	   having SUM(F.TUTAR) >0
	
	)
	
