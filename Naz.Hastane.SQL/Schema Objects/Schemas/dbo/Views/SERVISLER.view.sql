﻿





--*******************

CREATE VIEW dbo.SERVISLER
AS
SELECT     TOP 100 PERCENT SEC,SLB, SLT,SLX,SLXA,SLXX,SLYA
FROM         dbo.KEYDAT
WHERE     (SLK = '17')
ORDER BY SLB










