CREATE TABLE [dbo].[LABORSONUC] (
    [KNR]         VARCHAR (6)   NOT NULL,
    [SNR]         VARCHAR (3)   NOT NULL,
    [TANIM]       VARCHAR (2)   NOT NULL,
    [GRUP]        VARCHAR (3)   NOT NULL,
    [CODE]        VARCHAR (15)  NOT NULL,
    [TARIH]       DATETIME      NOT NULL,
    [IND]         INT           NOT NULL,
    [OZELKOD]     VARCHAR (5)   NULL,
    [PARISMI]     VARCHAR (30)  NOT NULL,
    [SONUC]       VARCHAR (100) NOT NULL,
    [BIRIMI]      VARCHAR (20)  NOT NULL,
    [NORMAL1]     VARCHAR (25)  NOT NULL,
    [NORMAL2]     VARCHAR (25)  NOT NULL,
    [ACIKLAMA]    VARCHAR (50)  NULL,
    [DATE_CREATE] DATETIME      NULL
);

