﻿ALTER TABLE [dbo].[TET_TABS]
    ADD CONSTRAINT [PK_TABS] PRIMARY KEY CLUSTERED ([ARZT] ASC, [TAB_CODE] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
