﻿ALTER TABLE [dbo].[KRITIKBILGI]
    ADD CONSTRAINT [FK_KRITIKBILGI_ADRES] FOREIGN KEY ([KNR]) REFERENCES [dbo].[ADRES] ([KNR]) ON DELETE NO ACTION ON UPDATE NO ACTION;

