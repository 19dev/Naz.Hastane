﻿ALTER TABLE [dbo].[PERSONELSAYILARI]
    ADD CONSTRAINT [DF_PERSONELSAYILARI_FIZIK_TEDAVI] DEFAULT ((0)) FOR [FIZIK_TEDAVI];

