﻿ALTER TABLE [dbo].[RAPORLAR]
    ADD CONSTRAINT [FK_RAPORLAR_BEHAND] FOREIGN KEY ([KNR], [SNR]) REFERENCES [dbo].[BEHAND] ([KNR], [SNR]) ON DELETE NO ACTION ON UPDATE NO ACTION;

