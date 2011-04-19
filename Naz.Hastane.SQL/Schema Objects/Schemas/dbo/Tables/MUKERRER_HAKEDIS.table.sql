CREATE TABLE [dbo].[MUKERRER_HAKEDIS] (
    [KNR]            VARCHAR (5)  NOT NULL,
    [HKNR]           VARCHAR (6)  NOT NULL,
    [HSNR]           VARCHAR (3)  NULL,
    [HSIRANO]        FLOAT        NULL,
    [FATURANO]       VARCHAR (15) NOT NULL,
    [TANIM]          VARCHAR (2)  NOT NULL,
    [GRUP]           VARCHAR (3)  NOT NULL,
    [CODE]           VARCHAR (15) NOT NULL,
    [TOPLAM]         FLOAT        NOT NULL,
    [PAY]            FLOAT        NOT NULL,
    [FATURATARIHI]   DATETIME     NULL,
    [M_FATURATARIHI] DATETIME     NULL
);

