UPDATE HIZIL 
SET HIZIL.MAKNO = KASA.MAKNO, HIZIL.USER_ID_UPDATE = 'AYDIN SAKAR', HIZIL.DATE_UPDATE = '20110719'
FROM HIZIL (NOLOCK)
	INNER JOIN KASA (NOLOCK) 
		ON (KASA.TUTAR = HIZIL.SATISF) AND (HIZIL.SNR = KASA.SNR) AND (HIZIL.KNR = KASA.KNR)
WHERE (((HIZIL.CODE)='SGKKATILIM') AND ((HIZIL.MAKNO) Is Null) AND ((KASA.ISIPTAL) Is Null) AND ((KASA.MAKBUZTIPI)='V'))


