﻿ALTER TABLE [dbo].[DISMERKEZLER]
    ADD CONSTRAINT [DF_DISMERKEZLER_ALACAK] DEFAULT ((0)) FOR [ALACAK];
