﻿ALTER TABLE [dbo].[ANAMNEZ]
    ADD CONSTRAINT [PK_ANAMNEZ] PRIMARY KEY NONCLUSTERED ([KNR] ASC, [SNR] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

