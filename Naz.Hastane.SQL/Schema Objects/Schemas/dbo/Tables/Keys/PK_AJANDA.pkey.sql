﻿ALTER TABLE [dbo].[AJANDA]
    ADD CONSTRAINT [PK_AJANDA] PRIMARY KEY NONCLUSTERED ([MSG_ID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
