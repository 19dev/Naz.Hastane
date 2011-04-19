CREATE TABLE [dbo].[DISMERKEZLER] (
    [KNR]            VARCHAR (5)    NOT NULL,
    [TIPI]           CHAR (1)       NOT NULL,
    [ADI1]           VARCHAR (50)   NOT NULL,
    [ADRZUS]         VARCHAR (100)  NULL,
    [STR]            VARCHAR (30)   NULL,
    [PLZ]            VARCHAR (5)    NULL,
    [ORT]            VARCHAR (20)   NOT NULL,
    [TEL1]           VARCHAR (20)   NULL,
    [TEL2]           VARCHAR (20)   NULL,
    [FAX1]           VARCHAR (20)   NULL,
    [FAX2]           VARCHAR (20)   NULL,
    [VERDAR]         VARCHAR (20)   NULL,
    [VERNO]          VARCHAR (20)   NULL,
    [BORC]           FLOAT          NOT NULL,
    [ALACAK]         FLOAT          NOT NULL,
    [EKSIKODENEN]    FLOAT          NOT NULL,
    [USER_ID]        VARCHAR (20)   NOT NULL,
    [DATE_CREATE]    DATETIME       NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20)   NULL,
    [DATE_UPDATE]    DATETIME       NULL,
    [OZELNOT]        VARCHAR (2000) NULL
);

