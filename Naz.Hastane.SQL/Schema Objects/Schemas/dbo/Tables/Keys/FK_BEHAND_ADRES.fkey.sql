﻿ALTER TABLE [dbo].[BEHAND]
    ADD CONSTRAINT [FK_BEHAND_ADRES] FOREIGN KEY ([KNR]) REFERENCES [dbo].[ADRES] ([KNR]) ON DELETE NO ACTION ON UPDATE NO ACTION;

