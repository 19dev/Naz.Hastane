﻿ALTER TABLE [dbo].[ECZPOLRECETELER]
    ADD CONSTRAINT [DF_ECZPOLRECETELER_GENELTOPLAM] DEFAULT ((0)) FOR [GENELTOPLAM];
