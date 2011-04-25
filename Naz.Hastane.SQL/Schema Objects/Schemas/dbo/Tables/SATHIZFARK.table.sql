﻿CREATE TABLE [dbo].[SATHIZFARK] (
    [KNR]            VARCHAR (7)   NOT NULL,
    [SNR]            VARCHAR (7)   NOT NULL,
    [AKOD]           VARCHAR (2)   NOT NULL,
    [TANIM]          VARCHAR (2)   NOT NULL,
    [GRUP]           VARCHAR (3)   NOT NULL,
    [CODE]           VARCHAR (15)  NOT NULL,
    [NAME1]          VARCHAR (35)  NULL,
    [ADET]           FLOAT         NOT NULL,
    [BIRIMF]         FLOAT         NOT NULL,
    [TOPLAMF]        FLOAT         NOT NULL,
    [ECZKARO]        FLOAT         NOT NULL,
    [OZISKO]         FLOAT         NOT NULL,
    [ISKONTO]        FLOAT         NOT NULL,
    [KDVO]           FLOAT         NOT NULL,
    [KDVT]           FLOAT         NOT NULL,
    [ALISF]          FLOAT         NOT NULL,
    [ORJTUTAR]       FLOAT         NOT NULL,
    [FZMAL]          FLOAT         NOT NULL,
    [OZELF]          VARCHAR (1)   NOT NULL,
    [MIAD]           SMALLDATETIME NULL,
    [USER_ID]        VARCHAR (20)  NOT NULL,
    [DATE_CREATE]    DATETIME      NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20)  NULL,
    [DATE_UPDATE]    DATETIME      NULL,
    [ESKIALISF]      FLOAT         NULL
);
