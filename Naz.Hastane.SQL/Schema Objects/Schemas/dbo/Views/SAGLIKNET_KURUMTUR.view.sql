﻿
CREATE VIEW [dbo].[SAGLIKNET_KURUMTUR]
 AS SELECT     SLB, SLZ AS KURUMKODU, SLZZ AS KURUMADI 
 FROM         dbo.KEYDAT WHERE     (SLK = '36')
