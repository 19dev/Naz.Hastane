﻿ALTER TABLE [dbo].[TET_HASTA_GÖZLEM]
    ADD CONSTRAINT [PK_TET_HASTA_GÖZLEM] PRIMARY KEY NONCLUSTERED ([KNR] ASC, [SNR] ASC, [GELISTARIHI] ASC, [TARIH] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

