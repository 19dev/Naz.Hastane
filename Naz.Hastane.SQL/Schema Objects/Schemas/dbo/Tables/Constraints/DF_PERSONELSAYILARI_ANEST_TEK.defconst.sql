﻿ALTER TABLE [dbo].[PERSONELSAYILARI]
    ADD CONSTRAINT [DF_PERSONELSAYILARI_ANEST_TEK] DEFAULT ((0)) FOR [ANEST_TEK];

