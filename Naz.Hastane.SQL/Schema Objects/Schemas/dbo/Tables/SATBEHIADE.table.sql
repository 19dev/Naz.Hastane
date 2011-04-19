﻿CREATE TABLE [dbo].[SATBEHIADE] (
    [KNR]            VARCHAR (5)  NOT NULL,
    [SNR]            VARCHAR (3)  NOT NULL,
    [IRSALIYETARIHI] DATETIME     NOT NULL,
    [FATURATARIHI]   DATETIME     NOT NULL,
    [IRSALIYENO]     VARCHAR (10) NOT NULL,
    [FATURANO]       VARCHAR (20) NOT NULL,
    [ISKONTO]        FLOAT        NOT NULL,
    [ISKONTO1]       FLOAT        NOT NULL,
    [TOPLAM]         FLOAT        NOT NULL,
    [YUVARLAMA]      FLOAT        NOT NULL,
    [KDVTUTARI]      FLOAT        NOT NULL,
    [KDVYUVARLAMA]   FLOAT        NOT NULL,
    [GENELTOPLAM]    FLOAT        NOT NULL,
    [ILACSARF]       VARCHAR (1)  NULL,
    [TESELLUMNO]     VARCHAR (10) NULL,
    [TESELLUMTARIHI] DATETIME     NULL,
    [ISLENDI]        VARCHAR (1)  NOT NULL,
    [USER_ID]        VARCHAR (20) NOT NULL,
    [DATE_CREATE]    DATETIME     NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20) NULL,
    [DATE_UPDATE]    DATETIME     NULL
);

