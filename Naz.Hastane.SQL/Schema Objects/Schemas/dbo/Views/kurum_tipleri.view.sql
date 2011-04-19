





--********************

CREATE VIEW dbo.kurum_tipleri
AS
SELECT     TOP 100 PERCENT SLB, SLT
FROM         dbo.KEYDAT
WHERE     (SLK = '36')
ORDER BY SLB






