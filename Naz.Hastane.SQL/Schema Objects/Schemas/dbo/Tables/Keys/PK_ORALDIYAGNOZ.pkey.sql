﻿ALTER TABLE [dbo].[ORALDIYAGNOZ]
    ADD CONSTRAINT [PK_ORALDIYAGNOZ] PRIMARY KEY NONCLUSTERED ([DIYAGNOZ_ID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

