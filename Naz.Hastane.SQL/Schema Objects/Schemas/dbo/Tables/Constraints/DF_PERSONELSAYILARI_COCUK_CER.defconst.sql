﻿ALTER TABLE [dbo].[PERSONELSAYILARI]
    ADD CONSTRAINT [DF_PERSONELSAYILARI_COCUK_CER] DEFAULT ((0)) FOR [COCUK_CER];

