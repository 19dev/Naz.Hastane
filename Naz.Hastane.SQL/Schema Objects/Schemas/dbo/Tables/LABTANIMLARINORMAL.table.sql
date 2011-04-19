CREATE TABLE [dbo].[LABTANIMLARINORMAL] (
    [TANIM]    VARCHAR (2)  NOT NULL,
    [GRUP]     VARCHAR (3)  NOT NULL,
    [CODE]     VARCHAR (15) NOT NULL,
    [IND]      INT          NOT NULL,
    [SIRA]     INT          NULL,
    [CINSIYET] CHAR (1)     NULL,
    [DMY]      CHAR (1)     NULL,
    [DMY1]     INT          NULL,
    [DMY2]     INT          NULL,
    [NORMAL1]  VARCHAR (25) NULL,
    [NORMAL2]  VARCHAR (25) NULL,
    [ACIKLAMA] VARCHAR (50) NULL,
    [PANIK1]   VARCHAR (25) NULL,
    [PANIK2]   VARCHAR (25) NULL
);

