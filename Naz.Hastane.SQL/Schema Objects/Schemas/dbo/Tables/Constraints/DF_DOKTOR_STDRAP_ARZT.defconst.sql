﻿ALTER TABLE [dbo].[DOKTOR_STDRAP]
    ADD CONSTRAINT [DF_DOKTOR_STDRAP_ARZT] DEFAULT ('') FOR [ARZT];

