﻿ALTER TABLE [dbo].[TET_COC_HASTA_ASI_UYGULAMA]
    ADD CONSTRAINT [PK_TET_COC_ASI_HASTA_UYGULAMA] PRIMARY KEY CLUSTERED ([KNR] ASC, [ASI_KOD] ASC, [SIRANO] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

