﻿CREATE TABLE [dbo].[MEDRAPORETKENMADDE] (
    [KNR]                  VARCHAR (50)  NOT NULL,
    [SNR]                  VARCHAR (50)  NOT NULL,
    [ETKENKODU]            VARCHAR (50)  NULL,
    [ACIKLAMA]             VARCHAR (100) NULL,
    [KULLANIMDOZ1]         VARCHAR (20)  NULL,
    [KULLANIMDOZ2]         VARCHAR (20)  NULL,
    [KULLANIMDOZBIRIM]     VARCHAR (20)  NULL,
    [KULLANIMPERIYOT]      VARCHAR (20)  NULL,
    [KULLANIMPERIYOTBIRIM] VARCHAR (20)  NULL,
    [FLAG_GONDER]          TINYINT       NULL
);

