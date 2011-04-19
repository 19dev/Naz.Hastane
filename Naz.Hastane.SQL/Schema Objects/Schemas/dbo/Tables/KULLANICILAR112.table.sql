CREATE TABLE [dbo].[KULLANICILAR112] (
    [SIRANO]           INT           IDENTITY (1, 1) NOT NULL,
    [USER112]          NVARCHAR (50) NULL,
    [PASS112]          NVARCHAR (50) NULL,
    [KTIPI]            NVARCHAR (50) NULL,
    [GECERLILIKTARIHI] DATETIME      NULL,
    [TESISKODU]        INT           NULL,
    [KSURE]            NVARCHAR (50) NULL,
    [SURL]             NVARCHAR (50) NULL
);

