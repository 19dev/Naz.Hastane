﻿ALTER TABLE [dbo].[DISMERKEZLER]
    ADD CONSTRAINT [PK_DISMERKEZLER] PRIMARY KEY CLUSTERED ([KNR] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
