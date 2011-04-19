CREATE TABLE [dbo].[AVANSLAR] (
    [AV_ID]          FLOAT        NOT NULL,
    [KNR]            VARCHAR (6)  NOT NULL,
    [SNR]            VARCHAR (3)  NOT NULL,
    [TARIH]          DATETIME     NOT NULL,
    [TUTAR]          FLOAT        NOT NULL,
    [KULLANILAN]     FLOAT        NOT NULL,
    [IADEEDILEN]     FLOAT        NOT NULL,
    [ODEMESEKLI]     CHAR (1)     NOT NULL,
    [POSNO]          VARCHAR (2)  NULL,
    [MAKNO]          VARCHAR (7)  NOT NULL,
    [USER_ID]        VARCHAR (20) NOT NULL,
    [DATE_CREATE]    DATETIME     NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20) NULL,
    [DATE_UPDATE]    DATETIME     NULL,
    [HESAPKODU]      VARCHAR (50) NULL,
    [ALTHESAPKODU]   VARCHAR (50) NULL,
    [TIPI]           VARCHAR (50) NULL,
    [AFATNO]         VARCHAR (50) NULL,
    [KALAN]          FLOAT        NULL,
    [AMAKNO]         VARCHAR (50) NULL
);

