﻿ALTER TABLE [dbo].[RANDEVULARRUHANI]
    ADD CONSTRAINT [PK_RANDEVULARRUHANI] PRIMARY KEY CLUSTERED ([RUHANIKODU] ASC, [TARIH] ASC, [SAAT] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

