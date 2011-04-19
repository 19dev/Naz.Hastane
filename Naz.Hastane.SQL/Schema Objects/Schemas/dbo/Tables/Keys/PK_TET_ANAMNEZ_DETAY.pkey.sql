﻿ALTER TABLE [dbo].[TET_ANAMNEZ_DETAY]
    ADD CONSTRAINT [PK_TET_ANAMNEZ_DETAY] PRIMARY KEY NONCLUSTERED ([KNR] ASC, [SNR] ASC, [GELISTARIHI] ASC, [TESHISKODU] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

