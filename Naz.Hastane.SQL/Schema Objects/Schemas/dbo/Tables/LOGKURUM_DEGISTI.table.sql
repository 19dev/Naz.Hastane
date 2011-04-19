CREATE TABLE [dbo].[LOGKURUM_DEGISTI] (
    [KD_ID]          NUMERIC (18) NOT NULL,
    [KNR]            VARCHAR (6)  NOT NULL,
    [TARIH]          DATETIME     NOT NULL,
    [EPSG]           VARCHAR (6)  NOT NULL,
    [YPSG]           VARCHAR (6)  NOT NULL,
    [OHASTATOP]      FLOAT        NOT NULL,
    [EHASTATOP]      FLOAT        NOT NULL,
    [EKURUMTOP]      FLOAT        NOT NULL,
    [YHASTATOP]      FLOAT        NOT NULL,
    [YKURUMTOP]      FLOAT        NOT NULL,
    [USER_ID]        VARCHAR (20) NOT NULL,
    [DATE_CREATE]    DATETIME     NOT NULL,
    [USER_ID_UPDATE] VARCHAR (20) NULL,
    [DATE_UPDATE]    DATETIME     NULL
);

