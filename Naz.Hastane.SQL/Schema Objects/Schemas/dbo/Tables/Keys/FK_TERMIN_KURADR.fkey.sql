﻿ALTER TABLE [dbo].[TERMIN]
    ADD CONSTRAINT [FK_TERMIN_KURADR] FOREIGN KEY ([KNR]) REFERENCES [dbo].[KURADR] ([KNR]) ON DELETE NO ACTION ON UPDATE NO ACTION;

