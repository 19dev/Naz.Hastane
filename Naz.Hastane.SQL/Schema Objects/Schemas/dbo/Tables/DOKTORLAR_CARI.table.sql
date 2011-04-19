CREATE TABLE [dbo].[DOKTORLAR_CARI] (
    [CARI_ID]         INT          IDENTITY (1, 1) NOT NULL,
    [KNR]             VARCHAR (5)  NOT NULL,
    [TARIH]           DATETIME     NOT NULL,
    [BASLANGICTARIHI] DATETIME     NOT NULL,
    [BITISTARIHI]     DATETIME     NOT NULL,
    [TUTAR]           FLOAT        NOT NULL,
    [ISODENDI]        CHAR (1)     NOT NULL,
    [ODEYEN]          VARCHAR (20) NULL,
    [USER_ID]         VARCHAR (20) NOT NULL,
    [DATE_CREATE]     DATETIME     NOT NULL
);

