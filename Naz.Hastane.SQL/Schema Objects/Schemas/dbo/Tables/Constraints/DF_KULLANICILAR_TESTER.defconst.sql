﻿ALTER TABLE [dbo].[KULLANICILAR]
    ADD CONSTRAINT [DF_KULLANICILAR_TESTER] DEFAULT ('F') FOR [TESTER];
