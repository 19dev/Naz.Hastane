﻿ALTER TABLE [dbo].[HIZMET_ESKI]
    ADD CONSTRAINT [PK_HIZMET_ESKI] PRIMARY KEY NONCLUSTERED ([TANIM] ASC, [GRUP] ASC, [CODE] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

