﻿ALTER TABLE [dbo].[NX_HAREKET_KALEMLERI]
    ADD CONSTRAINT [DF_NX_HAREKET_KALEMLERI_MAL_FAZLASI] DEFAULT (0) FOR [MAL_FAZLASI];

