﻿ALTER TABLE [dbo].[TET_TES_LIST]
    ADD CONSTRAINT [FK_TET_TES_LIST_TET_TES_TANIM] FOREIGN KEY ([TANIM]) REFERENCES [dbo].[TET_TES_TANIM] ([TES_TANIM_CODE]) ON DELETE CASCADE ON UPDATE CASCADE;
