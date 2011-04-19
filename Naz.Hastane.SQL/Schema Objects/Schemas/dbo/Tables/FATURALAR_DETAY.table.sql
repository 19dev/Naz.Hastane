CREATE TABLE [dbo].[FATURALAR_DETAY] (
    [DET_ID]   INT           IDENTITY (1, 1) NOT NULL,
    [ID]       INT           NOT NULL,
    [SATIR]    INT           NULL,
    [KOD]      VARCHAR (10)  NULL,
    [ACIKLAMA] VARCHAR (255) NULL,
    [TUTAR0]   FLOAT         NULL,
    [TUTAR8]   FLOAT         NULL,
    [TUTAR18]  FLOAT         NULL,
    [tutar]    FLOAT         NULL,
    [adet]     FLOAT         NULL,
    [bfiyat]   FLOAT         NULL,
    [e_tutar]  FLOAT         NULL,
    [tanim]    NVARCHAR (2)  NULL
);

