﻿ALTER TABLE [dbo].[LOGHASTAKARTIBIRLESTI]
    ADD CONSTRAINT [PK_LOGHASTAKARTIBIRLESTI] PRIMARY KEY NONCLUSTERED ([HKB_ID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

