﻿ALTER TABLE [dbo].[PERSONELSAYILARI]
    ADD CONSTRAINT [DF_PERSONELSAYILARI_PSIKIYATRI] DEFAULT ((0)) FOR [PSIKIYATRI];
