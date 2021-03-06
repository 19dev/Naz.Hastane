select 
	F.FTARIH,
	M.HesapKodu,
	F.MAKBUZNO,
	F.USER_ID,
	F.ACIKLAMA,
	'TUTAR'= 
      SUM(CASE 
         WHEN CHARINDEX('120', M.HesapKodu) >0  THEN F.TUTAR
	      END),
	SUM(F.BORC-F.ALACAK) AS BTUTAR,
	SUM(F.TUTAR) AS HTUTAR
from  MuhasebeHesapKodu M
left join 
	(select 
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
		sum(K.TUTAR) as TUTAR
    from KASA K
	Where
		K.TARIH >= '20110104' and K.TARIH < '20110105' 
		and K.ISIPTAL IS  NULL
    GROUP BY 
		CONVERT(VARCHAR(10), K.TARIH, 104), K.USER_ID, K.MAKBUZNO, HNEREYEODENDI) F
   on F.USER_ID = M.UserID
		and HesapKodu in ('120 01 023')
GROUP BY F.USER_ID,HesapKodu ,HesapAdi,F.FTARIH,F.MAKBUZNO,F.ACIKLAMA
having SUM(F.TUTAR) >0
