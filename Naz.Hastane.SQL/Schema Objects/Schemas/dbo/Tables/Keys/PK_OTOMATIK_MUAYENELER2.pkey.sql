﻿ALTER TABLE [dbo].[OTOMATIK_MUAYENELER2]
    ADD CONSTRAINT [PK_OTOMATIK_MUAYENELER2] PRIMARY KEY NONCLUSTERED ([SERVISKODU] ASC, [TANIM] ASC, [GRUP] ASC, [CODE] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

