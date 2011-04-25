﻿CREATE VIEW dbo.SAYAT
AS
SELECT     TOP 100 PERCENT dbo.ADRES.KNR AS Expr1, dbo.ADRES.HASTAADI, dbo.ADRES.HASTASOYADI, dbo.BEHAND.BHDAT
FROM         dbo.ADRES INNER JOIN
                      dbo.BEHAND ON dbo.ADRES.KNR = dbo.BEHAND.KNR
WHERE     (dbo.BEHAND.ARZT = '0278') AND (dbo.BEHAND.DATE_CREATE BETWEEN CONVERT(DATETIME, '2009-11-14 13:00:00', 102) AND 
                      CONVERT(DATETIME, '2009-11-15 07:59:59', 102)) AND (dbo.BEHAND.KTOPT <> 0) AND (dbo.BEHAND.MTOPT <> 0)
ORDER BY dbo.BEHAND.BHDAT