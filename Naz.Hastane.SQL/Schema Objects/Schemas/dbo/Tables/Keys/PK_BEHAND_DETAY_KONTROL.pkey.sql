﻿ALTER TABLE [dbo].[BEHAND_DETAY_KONTROL]
    ADD CONSTRAINT [PK_BEHAND_DETAY_KONTROL] PRIMARY KEY NONCLUSTERED ([KONTROL_ID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

