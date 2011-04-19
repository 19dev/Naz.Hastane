CREATE TABLE [dbo].[HUZUREVI_DETAY] (
    [KNR]         VARCHAR (6)  NOT NULL,
    [SIRANO]      INT          NOT NULL,
    [TARIH]       DATETIME     NOT NULL,
    [B_A]         CHAR (1)     NOT NULL,
    [UCRTIPI]     CHAR (1)     NULL,
    [ACIKLAMA]    VARCHAR (30) NULL,
    [TUTAR]       FLOAT        NOT NULL,
    [USER_ID]     VARCHAR (20) NOT NULL,
    [DATE_CREATE] DATETIME     NOT NULL,
    [MAKNO]       VARCHAR (8)  NULL
);

