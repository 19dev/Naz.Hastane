CREATE TABLE [dbo].[DISMERKEZLER_GIDEN] (
    [KNR]         VARCHAR (5)  NOT NULL,
    [MSIRANO]     FLOAT        NOT NULL,
    [HKNR]        VARCHAR (6)  NOT NULL,
    [HSNR]        VARCHAR (3)  NOT NULL,
    [SIRANO]      FLOAT        NOT NULL,
    [TANIM]       VARCHAR (2)  NOT NULL,
    [GRUP]        VARCHAR (3)  NOT NULL,
    [CODE]        VARCHAR (15) NOT NULL,
    [TARIH]       DATETIME     NOT NULL,
    [SATISF]      FLOAT        NOT NULL,
    [MSATISF]     FLOAT        NOT NULL,
    [USER_ID]     VARCHAR (20) NOT NULL,
    [DATE_CREATE] DATETIME     NOT NULL
);

