﻿ALTER TABLE [dbo].[DISMERKEZLER]
    ADD CONSTRAINT [DF_DISMERKEZLER_BORC] DEFAULT ((0)) FOR [BORC];

