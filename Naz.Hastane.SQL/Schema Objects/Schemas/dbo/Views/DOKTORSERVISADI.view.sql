﻿
CREATE VIEW DOKTORSERVISADI
AS
SELECT     KEYDAT.SEC, KEYDAT.SLB, KEYDAT.SLT, KEYDAT_1.SLT AS SERVIS
FROM         KEYDAT INNER JOIN
                      KEYDAT KEYDAT_1 ON KEYDAT.SLXX = KEYDAT_1.SLB
WHERE     (KEYDAT_1.SLK = '17') AND (KEYDAT.SLK = '07')





