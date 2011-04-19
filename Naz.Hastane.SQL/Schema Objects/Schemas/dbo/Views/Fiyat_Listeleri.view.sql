





--*************


CREATE VIEW dbo.Fiyat_Listeleri
AS
SELECT     TOP 100 PERCENT *
FROM         dbo.KEYDAT
WHERE     (SLK = 15)
ORDER BY SLB






