﻿ALTER TABLE [dbo].[LOGHIZILDELETED]
    ADD CONSTRAINT [DF_LOGHIZILDELETED_KDV] DEFAULT ((0)) FOR [KDV];

