﻿ALTER TABLE [dbo].[ECZDEVIRILACSARF]
    ADD CONSTRAINT [PK_ECZDEVIRILACSARF] PRIMARY KEY NONCLUSTERED ([YIL] ASC, [AKOD] ASC, [TANIM] ASC, [GRUP] ASC, [CODE] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
