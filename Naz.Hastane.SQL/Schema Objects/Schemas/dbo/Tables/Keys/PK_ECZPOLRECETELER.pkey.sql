﻿ALTER TABLE [dbo].[ECZPOLRECETELER]
    ADD CONSTRAINT [PK_ECZPOLRECETELER] PRIMARY KEY NONCLUSTERED ([TARIH] ASC, [RECKNR] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
