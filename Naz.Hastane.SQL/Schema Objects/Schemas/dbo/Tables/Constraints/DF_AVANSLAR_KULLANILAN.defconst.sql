﻿ALTER TABLE [dbo].[AVANSLAR]
    ADD CONSTRAINT [DF_AVANSLAR_KULLANILAN] DEFAULT (0) FOR [KULLANILAN];
