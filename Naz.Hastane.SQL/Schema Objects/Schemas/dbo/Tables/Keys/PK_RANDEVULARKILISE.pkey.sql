﻿ALTER TABLE [dbo].[RANDEVULARKILISE]
    ADD CONSTRAINT [PK_RANDEVULARKILISE] PRIMARY KEY CLUSTERED ([KILISEKODU] ASC, [TARIH] ASC, [SAAT] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
