﻿ALTER TABLE [dbo].[DOKTORLAR]
    ADD CONSTRAINT [DF_DOKTORLAR_EKSIKODENEN] DEFAULT ((0)) FOR [EKSIKODENEN];
