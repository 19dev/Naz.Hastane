CREATE TABLE [dbo].[ORAL_DETAY] (
    [DIYAGNOZ_ID]    NUMERIC (18)  NOT NULL,
    [DIS_NO]         NUMERIC (18)  NOT NULL,
    [TARIH]          DATETIME      NULL,
    [ARZT]           CHAR (4)      NULL,
    [NOT1]           VARCHAR (500) NULL,
    [USER_ID]        VARCHAR (20)  NULL,
    [DATE_CREATE]    DATETIME      NULL,
    [USER_ID_UPDATE] VARCHAR (20)  NULL,
    [DATE_UPDATE]    DATETIME      NULL
);

