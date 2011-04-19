CREATE TABLE [dbo].[DOKTORLAR_MAKBUZ_DETAY] (
    [CARI_ID]      INT          NULL,
    [DETAY_ID]     INT          IDENTITY (1, 1) NOT NULL,
    [KNR]          VARCHAR (5)  NOT NULL,
    [SIRA]         INT          NOT NULL,
    [HKNR]         VARCHAR (6)  NOT NULL,
    [HSNR]         VARCHAR (3)  NULL,
    [HSIRANO]      FLOAT        NULL,
    [FATNO]        VARCHAR (10) NOT NULL,
    [FATURANO]     VARCHAR (10) NOT NULL,
    [FATURATARIHI] DATETIME     NOT NULL,
    [AMBU]         CHAR (1)     NOT NULL,
    [TANIM]        VARCHAR (2)  NOT NULL,
    [GRUP]         VARCHAR (3)  NOT NULL,
    [CODE]         VARCHAR (15) NOT NULL,
    [TOPLAM]       FLOAT        NOT NULL,
    [PAY]          FLOAT        NOT NULL,
    [ISODENDI]     CHAR (1)     NOT NULL,
    [USER_ID]      VARCHAR (20) NOT NULL,
    [DATE_CREATE]  DATETIME     NOT NULL
);

