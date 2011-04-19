CREATE TABLE [dbo].[SATCARI] (
    [SC_ID]          NUMERIC (18) IDENTITY (1, 1) NOT NULL,
    [KNR]            VARCHAR (5)  NOT NULL,
    [SNR]            VARCHAR (3)  NOT NULL,
    [TARIH]          DATETIME     NOT NULL,
    [EVRAKNO]        VARCHAR (10) NOT NULL,
    [ACIKLAMA]       VARCHAR (30) NULL,
    [ODEMESEKLI]     VARCHAR (50) NULL,
    [HESAPKODU]      VARCHAR (50) NULL,
    [ALTHESAPKODU]   VARCHAR (50) NULL,
    [B_A]            VARCHAR (1)  NOT NULL,
    [TUTAR]          FLOAT        NOT NULL,
    [KOD]            VARCHAR (1)  NOT NULL,
    [USER_ID]        VARCHAR (20) NOT NULL,
    [DATE_CREATE]    DATETIME     NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20) NULL,
    [DATE_UPDATE]    DATETIME     NULL
);

