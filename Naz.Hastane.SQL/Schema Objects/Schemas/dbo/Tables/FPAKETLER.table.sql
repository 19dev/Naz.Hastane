CREATE TABLE [dbo].[FPAKETLER] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [KNR]           VARCHAR (8)   NOT NULL,
    [SNR]           VARCHAR (5)   NOT NULL,
    [CODE]          VARCHAR (20)  NOT NULL,
    [NAME1]         VARCHAR (100) NULL,
    [ADET]          INT           NULL,
    [HTUTARI]       FLOAT         NULL,
    [TUTARI]        FLOAT         NULL,
    [FATURANO]      VARCHAR (50)  NULL,
    [TARIH]         DATETIME      NULL,
    [FAT_ID]        VARCHAR (50)  NULL,
    [FATURAEDILSIN] VARCHAR (1)   NULL,
    [KDV]           FLOAT         NULL,
    [TANIM]         VARCHAR (50)  NULL,
    [GRUP]          VARCHAR (50)  NULL,
    [psg]           VARCHAR (50)  NULL
);

