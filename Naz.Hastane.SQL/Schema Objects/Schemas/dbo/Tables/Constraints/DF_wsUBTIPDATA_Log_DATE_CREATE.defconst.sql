﻿ALTER TABLE [dbo].[wsUBTIPDATA_Log]
    ADD CONSTRAINT [DF_wsUBTIPDATA_Log_DATE_CREATE] DEFAULT (getdate()) FOR [DATE_CREATE];

