﻿ALTER TABLE [dbo].[KULLANICILAR]
    ADD CONSTRAINT [DF_KULLANICILAR_TARIH] DEFAULT (getdate()) FOR [TARIH];

