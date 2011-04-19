CREATE TABLE [dbo].[FATURA_KESERKEN] (
    [KNR]         VARCHAR (6)   NULL,
    [SNR]         VARCHAR (3)   NULL,
    [FATURA_ID]   VARCHAR (20)  NULL,
    [PSG]         VARCHAR (6)   NULL,
    [TARIH1]      DATETIME      NULL,
    [TARIH2]      DATETIME      NULL,
    [TANIM]       VARCHAR (2)   NULL,
    [GRUP]        VARCHAR (3)   NULL,
    [CODE]        VARCHAR (15)  NULL,
    [NAME1]       VARCHAR (250) NULL,
    [ADET]        FLOAT         NULL,
    [SATISF]      FLOAT         NULL,
    [KDV]         FLOAT         NULL,
    [TUTAR]       FLOAT         NULL,
    [SIRAID]      FLOAT         NULL,
    [USER_ID]     VARCHAR (100) NULL,
    [YAZIYLA]     VARCHAR (150) NULL,
    [PROVIZYONNO] VARCHAR (50)  NULL
);

