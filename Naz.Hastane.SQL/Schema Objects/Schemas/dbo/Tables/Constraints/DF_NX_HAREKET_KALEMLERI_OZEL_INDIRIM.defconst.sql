﻿ALTER TABLE [dbo].[NX_HAREKET_KALEMLERI]
    ADD CONSTRAINT [DF_NX_HAREKET_KALEMLERI_OZEL_INDIRIM] DEFAULT (0) FOR [OZEL_INDIRIM];
