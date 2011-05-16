select K.SLT, isnull(sum(SH.TOPLAMF+SH.KDVT),0) as TOPLAM 
	from SATHIZ SH, SATBEH SB, KEYDAT K 
	where SB.KNR=SH.KNR and SB.SNR=SH.SNR and SH.TANIM+SH.GRUP=K.SLB and K.SLK='30' 
		and SB.FATURATARIHI >= '20110401' and SB.FATURATARIHI < '20110501' and SH.TANIM = '09' and SH.AKOD = '00' 
	group by K.SLT 
	order by K.SLT

select isnull(sum(ADET * (SATISF + KSATISF)),0) as [YATAN HASTA ECZANEDEN TAHSÝL EDÝLMEYEN] 
	From HIZIL H 
		inner join BEHAND B on (H.KNR=B.KNR and H.SNR=B.SNR) 
		inner join FATURA F on (H.MAKNO=F.MAKNO and H.USER_ID <> F.USER_ID) 
	Where H.TANIM='09' and H.AKOD='00' and B.AMBU='Y' and H.TARIH >= '20110401' and H.TARIH < '20110501' 

select isnull(sum(ADET * (SATISF + KSATISF)),0) as [YATAN HASTA PARASI TAHSÝL EDÝLMEYEN] 
	From HIZIL H 
		inner join BEHAND B on (H.KNR=B.KNR and H.SNR=B.SNR) 
	Where H.TANIM='09' and H.AKOD='00' and B.AMBU='Y' and H.TARIH >= '20110401' and H.TARIH < '20110501' and H.MAKNO is null

select isnull(sum(ADET * (SATISF + KSATISF)),0) as [YATAN HASTA PARASI PEÞÝN] 
	From HIZIL H 
		inner join BEHAND B on (H.KNR=B.KNR and H.SNR=B.SNR) 
		inner join FATURA F on (H.MAKNO=F.MAKNO and H.USER_ID=F.USER_ID) 
	Where H.TANIM='09' and H.AKOD='00' and B.AMBU='Y' and H.TARIH >= '20110401' and H.TARIH < '20110501' 

select isnull(sum(ADET * (SATISF + KSATISF)),0) as [POLÝKLÝNÝK HASTA PARASI PEÞÝN] 
	From HIZIL H 
		inner join BEHAND B on (H.KNR=B.KNR and H.SNR=B.SNR) 
		inner join FATURA F on (H.MAKNO=F.MAKNO and H.USER_ID=F.USER_ID) 
	Where H.TANIM='09' and H.AKOD='00' and (B.AMBU='P' or B.AMBU='A') and H.TARIH >= '20110401' and H.TARIH < '20110501' 

select isnull(sum(ADET * HID.ESATISF),0) as [YATAN HASTA ÜCRETSÝZ] 
	From HIZIL H 
		inner join BEHAND B on (H.KNR=B.KNR and H.SNR=B.SNR) 
		inner join HASTAINDIRIMLER_DETAY HID on (H.KNR=HID.KNR and H.SNR = HID.SNR and H.SIRANO=HID.SIRANO) 
	Where H.TANIM='09' and H.AKOD='00' and B.AMBU='Y' and H.TARIH >= '20110401' and H.TARIH < '20110501' and HID.YSATISF=0

select isnull(sum(ADET * HID.ESATISF),0) as [POLÝKLÝNÝK HASTA ÜCRETSÝZ] 
	From HIZIL H 
		inner join BEHAND B on (H.KNR=B.KNR and H.SNR=B.SNR) 
		inner join HASTAINDIRIMLER_DETAY HID on (H.KNR=HID.KNR and H.SNR = HID.SNR and H.SIRANO=HID.SIRANO) 
	Where H.TANIM='09' and H.AKOD='00' and (B.AMBU='P' or B.AMBU='A') and H.TARIH >= '20110401' and H.TARIH < '20110501' and HID.YSATISF=0

select K.SLT, isnull(sum(SH.ADET*I.SATISF),0) as TOPLAM 
	from SHARK SH, ILACSARF I, KEYDAT K 
	where I.TANIM=SH.TANIM and I.AKOD=SH.AKOD and I.GRUP=SH.GRUP and I.CODE=SH.CODE 
		and left(SH.ACIKLAMA,2)=K.SLB and K.SLK='03' 
		and SH.TARIH >= '20110401' and SH.TARIH < '20110501' and SH.TANIM = '09' and SH.AKOD = '00' and SH.G_C = 'C' and SH.FIRMA = 'A' 
	group by K.SLT order by K.SLT

select K.SLT, isnull(sum(SH.ADET*SH.BIRIMF),0) as TOPLAM 
	from SHARK SH, KEYDAT K 
	where SH.SERVIS=K.SLB and K.SLK='17' 
		and SH.TARIH >= '20110401' and SH.TARIH < '20110501' and SH.TANIM = '09' and SH.AKOD = '00' and SH.G_C = 'C' and SH.FIRMA = 'R' 
	group by K.SLT order by K.SLT

