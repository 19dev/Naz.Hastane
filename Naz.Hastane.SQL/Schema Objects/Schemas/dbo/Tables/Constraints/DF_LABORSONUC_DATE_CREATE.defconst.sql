﻿ALTER TABLE [dbo].[LABORSONUC]
    ADD CONSTRAINT [DF_LABORSONUC_DATE_CREATE] DEFAULT (getdate()) FOR [DATE_CREATE];
