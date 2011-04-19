CREATE TABLE [dbo].[RANDEVU_HASTA] (
    [HASTA_ID]       FLOAT        NOT NULL,
    [KNR]            VARCHAR (6)  NULL,
    [PSG]            VARCHAR (6)  NOT NULL,
    [SIGORTANO]      VARCHAR (15) NULL,
    [CINSIYETI]      VARCHAR (1)  NOT NULL,
    [HASTAADI]       VARCHAR (15) NOT NULL,
    [HASTASOYADI]    VARCHAR (20) NOT NULL,
    [BABAADI]        VARCHAR (15) NULL,
    [EV_ADRES]       VARCHAR (60) NULL,
    [EV_PK]          VARCHAR (5)  NULL,
    [EV_SEHIR]       VARCHAR (20) NULL,
    [EV_TEL1]        VARCHAR (15) NULL,
    [EV_TEL2]        VARCHAR (15) NULL,
    [DOGUMYERI]      VARCHAR (15) NULL,
    [DOGUMTARIHI]    DATETIME     NOT NULL,
    [DURUM]          CHAR (1)     NULL,
    [USER_ID]        VARCHAR (20) NULL,
    [DATE_CREATE]    DATETIME     NULL,
    [USER_ID_UPDATE] VARCHAR (20) NULL,
    [DATE_UPDATE]    DATETIME     NULL,
    [SIRA]           FLOAT        NULL
);

