﻿ALTER TABLE [dbo].[PATOLOJIRAP]
    ADD CONSTRAINT [FK_PATOLOJIRAP_BEHAND] FOREIGN KEY ([KNR], [SNR]) REFERENCES [dbo].[BEHAND] ([KNR], [SNR]) ON DELETE NO ACTION ON UPDATE NO ACTION;
