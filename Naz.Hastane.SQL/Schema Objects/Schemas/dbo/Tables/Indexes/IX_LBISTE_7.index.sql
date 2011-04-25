﻿CREATE NONCLUSTERED INDEX [IX_LBISTE_7]
    ON [dbo].[LBISTE]([TANIM] ASC, [GRUP] ASC, [CODE] ASC, [KNR] ASC, [SNR] ASC, [TARIH] ASC, [KABUL] ASC, [ONAY] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF, ONLINE = OFF, MAXDOP = 0)
    ON [PRIMARY];
