﻿CREATE TABLE [dbo].[HIZILGONSAGNET] (
    [KNR]        VARCHAR (6)    NOT NULL,
    [SNR]        VARCHAR (3)    NOT NULL,
    [SIRANO]     INT            NOT NULL,
    [TUR]        NCHAR (10)     NOT NULL,
    [GUID]       VARCHAR (100)  NULL,
    [GONTARIH]   DATETIME       NULL,
    [GELENCEVAP] VARCHAR (5)    NULL,
    [SCODE]      VARCHAR (5)    NULL,
    [GELENHATA]  VARCHAR (1000) NULL,
    [GUIDGUNCEL] VARCHAR (100)  NULL
);

