






--*********************

CREATE VIEW dbo.POSLAR
AS
SELECT     TOP 100 PERCENT SLB, SLT,SLXX
FROM         dbo.KEYDAT
WHERE     (SLK = '53')
ORDER BY SLB






