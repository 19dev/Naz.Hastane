﻿ALTER TABLE [dbo].[PERSONELSAYILARI]
    ADD CONSTRAINT [DF_PERSONELSAYILARI_PATOLOJI] DEFAULT ((0)) FOR [PATOLOJI];

