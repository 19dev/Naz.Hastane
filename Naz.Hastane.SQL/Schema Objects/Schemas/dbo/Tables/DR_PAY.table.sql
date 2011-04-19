CREATE TABLE [dbo].[DR_PAY] (
    [DETAY_ID]     INT            IDENTITY (2840000, 1) NOT NULL,
    [SIRA]         FLOAT          NULL,
    [HKNR]         NVARCHAR (255) NULL,
    [HSNR]         NVARCHAR (255) NULL,
    [HSIRANO]      FLOAT          NULL,
    [TANIM]        NVARCHAR (255) NULL,
    [GRUP]         NVARCHAR (255) NULL,
    [CODE]         NVARCHAR (255) NULL,
    [AMBU]         VARCHAR (2)    NULL,
    [ARZT2]        NVARCHAR (255) NULL,
    [TOPLAM]       FLOAT          NULL,
    [DRYUZDE]      FLOAT          NULL,
    [PHYUZDE]      FLOAT          NULL,
    [KNR]          NVARCHAR (255) NULL,
    [PAY]          FLOAT          NULL,
    [FATNO]        VARCHAR (50)   NULL,
    [FATURANO]     VARCHAR (50)   NULL,
    [FATURATARIHI] DATETIME       NULL,
    [USER_ID]      VARCHAR (20)   NULL,
    [DATE_CREATE]  DATETIME       NULL
);

