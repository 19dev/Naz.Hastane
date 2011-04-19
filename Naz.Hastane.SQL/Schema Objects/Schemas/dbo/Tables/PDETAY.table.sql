CREATE TABLE [dbo].[PDETAY] (
    [SIRA]     INT           IDENTITY (1, 1) NOT NULL,
    [TANIM]    VARCHAR (2)   NULL,
    [GRUP]     VARCHAR (3)   NULL,
    [CODE]     VARCHAR (15)  NULL,
    [ACIKLAMA] VARCHAR (100) NULL,
    [ADET]     VARCHAR (50)  NULL,
    [SATISF]   FLOAT         NULL,
    [KSATISF]  FLOAT         NULL
);

