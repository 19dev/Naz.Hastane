﻿ALTER TABLE [dbo].[TET_İSTEK]
    ADD CONSTRAINT [PK_Tetİstek] PRIMARY KEY CLUSTERED ([TANIM] ASC, [GRUP] ASC, [CODE] ASC, [ARZT] ASC, [TAB_CODE] ASC, [ALT_TAB_CODE] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

