CREATE TABLE [dbo].[HASTAOTOMATIK] (
    [KNR]            VARCHAR (6)   NOT NULL,
    [SNR]            VARCHAR (3)   NOT NULL,
    [TANIM]          VARCHAR (2)   NOT NULL,
    [GRUP]           VARCHAR (3)   NOT NULL,
    [CODE]           VARCHAR (15)  NOT NULL,
    [ARZT]           VARCHAR (4)   NOT NULL,
    [ADET]           FLOAT         NOT NULL,
    [UNITE]          VARCHAR (2)   NULL,
    [NAME1]          VARCHAR (100) NOT NULL,
    [SATISF]         FLOAT         NOT NULL,
    [KSATISF]        FLOAT         NOT NULL,
    [KDV]            FLOAT         NOT NULL,
    [PSG]            VARCHAR (6)   NOT NULL,
    [USER_ID]        VARCHAR (20)  NOT NULL,
    [DATE_CREATE]    DATETIME      NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20)  NULL,
    [DATE_UPDATE]    DATETIME      NULL
);

