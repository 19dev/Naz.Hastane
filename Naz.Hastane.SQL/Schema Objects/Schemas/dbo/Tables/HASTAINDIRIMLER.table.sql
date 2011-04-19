CREATE TABLE [dbo].[HASTAINDIRIMLER] (
    [HI_ID]           INT           IDENTITY (1, 1) NOT NULL,
    [KNR]             VARCHAR (6)   NOT NULL,
    [SNR]             VARCHAR (3)   NOT NULL,
    [TARIH]           SMALLDATETIME NOT NULL,
    [ARZT]            VARCHAR (4)   NOT NULL,
    [HASTATOPLAM]     FLOAT         NOT NULL,
    [SECILITOPLAM]    FLOAT         NOT NULL,
    [INDIRIMYUZDE]    FLOAT         NOT NULL,
    [INDIRIMTOPLAM]   FLOAT         NOT NULL,
    [SONTOPLAM]       FLOAT         NOT NULL,
    [INDIRIMNEDEN]    VARCHAR (4)   NOT NULL,
    [INDIRIMACIKLAMA] VARCHAR (100) NULL,
    [MAKNO]           VARCHAR (8)   NULL,
    [USER_ID]         VARCHAR (20)  NOT NULL,
    [DATE_CREATE]     DATETIME      NOT NULL
);

