﻿ALTER TABLE [dbo].[FATURA]
    ADD CONSTRAINT [DF_FATURA_YUVARLAMA] DEFAULT (0) FOR [YUVARLAMA];
