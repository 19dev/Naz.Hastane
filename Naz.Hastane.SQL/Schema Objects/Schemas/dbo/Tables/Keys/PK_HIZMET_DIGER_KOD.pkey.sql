﻿ALTER TABLE [dbo].[HIZMET_DIGER_KOD]
    ADD CONSTRAINT [PK_HIZMET_DIGER_KOD] PRIMARY KEY NONCLUSTERED ([TANIM] ASC, [GRUP] ASC, [CODE] ASC, [FIYLIST] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
