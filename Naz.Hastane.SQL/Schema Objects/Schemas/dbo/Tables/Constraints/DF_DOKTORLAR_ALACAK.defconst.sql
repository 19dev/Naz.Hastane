﻿ALTER TABLE [dbo].[DOKTORLAR]
    ADD CONSTRAINT [DF_DOKTORLAR_ALACAK] DEFAULT ((0)) FOR [ALACAK];

