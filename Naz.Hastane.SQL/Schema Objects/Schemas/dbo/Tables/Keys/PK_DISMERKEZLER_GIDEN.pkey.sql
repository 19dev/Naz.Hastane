﻿ALTER TABLE [dbo].[DISMERKEZLER_GIDEN]
    ADD CONSTRAINT [PK_DISMERKEZLER_GIDEN] PRIMARY KEY CLUSTERED ([KNR] ASC, [MSIRANO] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

