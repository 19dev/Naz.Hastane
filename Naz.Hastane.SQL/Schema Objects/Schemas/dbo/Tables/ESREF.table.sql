CREATE TABLE [dbo].[ESREF] (
    [KNR]          VARCHAR (6)  NULL,
    [SIRA]         INT          NULL,
    [HKNR]         VARCHAR (6)  NOT NULL,
    [HSNR]         VARCHAR (3)  NOT NULL,
    [HSIRANO]      FLOAT        NOT NULL,
    [HAREKETTIPI]  CHAR (1)     NULL,
    [AMBU]         CHAR (1)     NULL,
    [TANIM]        VARCHAR (2)  NOT NULL,
    [GRUP]         VARCHAR (3)  NOT NULL,
    [CODE]         VARCHAR (15) NOT NULL,
    [TOPLAM]       FLOAT        NULL,
    [KDV]          FLOAT        NOT NULL,
    [PAY]          FLOAT        NULL,
    [TARIH]        DATETIME     NOT NULL,
    [FATNO]        VARCHAR (12) NULL,
    [ISODENDI]     CHAR (1)     NULL,
    [USER_ID]      CHAR (10)    NULL,
    [DATE_CREATE]  DATETIME     NULL,
    [FATURANO]     VARCHAR (50) NULL,
    [FATURATARIHI] DATETIME     NULL,
    [DETAY_ID]     CHAR (10)    NULL
);

