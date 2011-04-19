






/****** Object:  View dbo.vw_HASTA    Script Date: 20.02.2006 00:08:20 
******/
CREATE VIEW dbo.vw_HASTA
AS
SELECT     dbo.ADRES.KNR, dbo.ADRES.HASTAADI, dbo.ADRES.HASTASOYADI, 
dbo.HIZIL.TARIH, dbo.HIZIL.NAME1 AS ACIKLAMA,
                      dbo.HIZIL.ADET * (dbo.HIZIL.SATISF + 
dbo.HIZIL.KSATISF) AS TUTAR
FROM         dbo.HIZIL INNER JOIN
                      dbo.BEHAND ON dbo.HIZIL.KNR = dbo.BEHAND.KNR AND 
dbo.HIZIL.SNR = dbo.BEHAND.SNR INNER JOIN
                      dbo.ADRES ON dbo.BEHAND.KNR = dbo.ADRES.KNR INNER JOIN
                      dbo.KURADR ON dbo.HIZIL.PSG = dbo.KURADR.PSG
WHERE     (dbo.HIZIL.MAKNO IS NULL) AND (dbo.KURADR.FIXKURUM = 5)







