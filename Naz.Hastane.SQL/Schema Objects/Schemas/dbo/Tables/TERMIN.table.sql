﻿CREATE TABLE [dbo].[TERMIN] (
    [KNR]            VARCHAR (5)   NOT NULL,
    [SNR]            VARCHAR (3)   NOT NULL,
    [TARIH]          DATETIME      NOT NULL,
    [EVRAKNO]        VARCHAR (10)  NOT NULL,
    [ACIKLAMA]       VARCHAR (200) NULL,
    [B_A]            VARCHAR (1)   NOT NULL,
    [TUTAR]          FLOAT         NOT NULL,
    [KOD]            VARCHAR (1)   NOT NULL,
    [BK]             VARCHAR (1)   NOT NULL,
    [EEVRAKNO]       VARCHAR (10)  NULL,
    [ETARIH]         DATETIME      NULL,
    [SIRAID]         FLOAT         NULL,
    [USER_ID]        VARCHAR (20)  NOT NULL,
    [DATE_CREATE]    DATETIME      NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20)  NULL,
    [DATE_UPDATE]    DATETIME      NULL
);

