﻿ALTER TABLE [dbo].[PERSONELSAYILARI]
    ADD CONSTRAINT [DF_PERSONELSAYILARI_UROLOJI] DEFAULT ((0)) FOR [UROLOJI];

