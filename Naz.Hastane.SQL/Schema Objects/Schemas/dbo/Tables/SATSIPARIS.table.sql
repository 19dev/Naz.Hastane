CREATE TABLE [dbo].[SATSIPARIS] (
    [SP_ID]          NUMERIC (18) IDENTITY (1, 1) NOT NULL,
    [KNR]            VARCHAR (5)  NOT NULL,
    [SIPARISNO]      VARCHAR (5)  NOT NULL,
    [TARIH]          DATETIME     NOT NULL,
    [TANIM]          VARCHAR (2)  NOT NULL,
    [GRUP]           VARCHAR (3)  NOT NULL,
    [CODE]           VARCHAR (15) NOT NULL,
    [NAME1]          VARCHAR (50) NOT NULL,
    [FIYAT]          FLOAT        NOT NULL,
    [ADET]           FLOAT        NOT NULL,
    [GELENADET]      FLOAT        NOT NULL,
    [GELISTARIHI]    DATETIME     NULL,
    [USER_ID]        VARCHAR (20) NOT NULL,
    [DATE_CREATE]    DATETIME     NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20) NULL,
    [DATE_UPDATE]    DATETIME     NULL
);

