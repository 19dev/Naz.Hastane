CREATE TABLE [dbo].[DOKTORPROCESS] (
    [DP_ID]          NUMERIC (18) IDENTITY (1, 1) NOT NULL,
    [KNR]            VARCHAR (6)  NOT NULL,
    [SNR]            VARCHAR (3)  NOT NULL,
    [ARZT]           VARCHAR (4)  NOT NULL,
    [ACIKLAMA]       TEXT         NOT NULL,
    [USER_ID]        VARCHAR (20) NOT NULL,
    [DATE_CREATE]    DATETIME     NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20) NULL,
    [DATE_UPDATE]    DATETIME     NULL
);

