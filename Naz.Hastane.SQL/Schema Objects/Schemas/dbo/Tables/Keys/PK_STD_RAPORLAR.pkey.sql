﻿ALTER TABLE [dbo].[STD_RAPORLAR]
    ADD CONSTRAINT [PK_STD_RAPORLAR] PRIMARY KEY NONCLUSTERED ([RAPORNO] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
