﻿ALTER TABLE [dbo].[ORAL_DETAY]
    ADD CONSTRAINT [PK_ORAL_DETAY] PRIMARY KEY NONCLUSTERED ([DIYAGNOZ_ID] ASC, [DIS_NO] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

