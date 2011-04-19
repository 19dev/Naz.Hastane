CREATE TABLE [dbo].[HASTAOTOMATIKDIGER] (
    [KNR]            VARCHAR (6)  NOT NULL,
    [SNR]            VARCHAR (3)  NOT NULL,
    [OUTG]           CHAR (4)     NOT NULL,
    [OUTH]           CHAR (4)     NOT NULL,
    [ARZT]           VARCHAR (4)  NOT NULL,
    [USER_ID]        VARCHAR (20) NOT NULL,
    [DATE_CREATE]    DATETIME     NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20) NULL,
    [DATE_UPDATE]    DATETIME     NULL
);

