﻿ALTER TABLE [dbo].[ICD10_SUBSECTION]
    ADD CONSTRAINT [PK_ICD10_SUBSECTION] PRIMARY KEY NONCLUSTERED ([CH_NO] ASC, [SC_NO] ASC, [SUBSC_NO] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];

