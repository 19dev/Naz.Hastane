





--******************


CREATE VIEW dbo.hizmet_gruplari
AS
SELECT     TOP 100 PERCENT SLB, SLT,SLX,sec
FROM         dbo.KEYDAT
WHERE     (SLK = '01')
ORDER BY SLB








