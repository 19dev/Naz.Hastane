﻿ALTER TABLE [dbo].[FHAKEDIS]
    ADD CONSTRAINT [PK_FHAKEDIS] PRIMARY KEY NONCLUSTERED ([KNR] ASC, [SNR] ASC, [DR] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

