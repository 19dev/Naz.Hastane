﻿ALTER TABLE [dbo].[HIZMETDOKTORYUZDE_MUH]
    ADD CONSTRAINT [PK_HIZMETDOKTORYUZDE_MUH] PRIMARY KEY NONCLUSTERED ([TANIM] ASC, [GRUP] ASC, [CODE] ASC, [ARZT] ASC, [kurum] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
