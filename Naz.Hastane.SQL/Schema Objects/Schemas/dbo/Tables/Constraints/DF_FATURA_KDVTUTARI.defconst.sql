﻿ALTER TABLE [dbo].[FATURA]
    ADD CONSTRAINT [DF_FATURA_KDVTUTARI] DEFAULT (0) FOR [KDVTUTARI];
