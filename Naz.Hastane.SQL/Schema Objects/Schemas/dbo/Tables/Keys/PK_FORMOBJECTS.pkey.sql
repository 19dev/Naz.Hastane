﻿ALTER TABLE [dbo].[FORMOBJECTS]
    ADD CONSTRAINT [PK_FORMOBJECTS] PRIMARY KEY NONCLUSTERED ([FORMNAME] ASC, [OBJECTNAME] ASC, [TABNUMBER] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

