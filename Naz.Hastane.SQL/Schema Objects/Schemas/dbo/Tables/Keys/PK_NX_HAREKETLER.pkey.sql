﻿ALTER TABLE [dbo].[NX_HAREKETLER]
    ADD CONSTRAINT [PK_NX_HAREKETLER] PRIMARY KEY CLUSTERED ([HAREKET_ID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

