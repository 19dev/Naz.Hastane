﻿CREATE TABLE [dbo].[TMPECZSAYIMLISTESI] (
    [AKOD]       VARCHAR (2)  NOT NULL,
    [TANIM]      VARCHAR (2)  NOT NULL,
    [GRUP]       VARCHAR (3)  NOT NULL,
    [CODE]       VARCHAR (15) NOT NULL,
    [NAME1]      VARCHAR (65) NOT NULL,
    [SAYIM]      FLOAT        NOT NULL,
    [MEVCUT]     FLOAT        NOT NULL,
    [EKSIK]      FLOAT        NOT NULL,
    [FAZLA]      FLOAT        NOT NULL,
    [FIRMA]      VARCHAR (4)  NOT NULL,
    [MIADTARIHI] DATETIME     NULL,
    [USER_ID]    VARCHAR (20) NOT NULL
);

