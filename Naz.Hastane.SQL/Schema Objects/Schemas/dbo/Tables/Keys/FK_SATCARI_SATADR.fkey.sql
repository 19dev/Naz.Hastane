﻿ALTER TABLE [dbo].[SATCARI]
    ADD CONSTRAINT [FK_SATCARI_SATADR] FOREIGN KEY ([KNR]) REFERENCES [dbo].[SATADR] ([KNR]) ON DELETE NO ACTION ON UPDATE NO ACTION;

