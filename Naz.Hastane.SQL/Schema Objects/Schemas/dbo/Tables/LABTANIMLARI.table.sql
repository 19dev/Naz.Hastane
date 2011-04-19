CREATE TABLE [dbo].[LABTANIMLARI] (
    [TANIM]         VARCHAR (2)  NOT NULL,
    [GRUP]          VARCHAR (3)  NOT NULL,
    [CODE]          VARCHAR (15) NOT NULL,
    [IND]           INT          NOT NULL,
    [PARISMI]       VARCHAR (30) NULL,
    [BIRIMI]        VARCHAR (15) NULL,
    [ACIKLAMA]      VARCHAR (50) NULL,
    [TEXT]          TEXT         NULL,
    [MEDTAHLILKODU] VARCHAR (10) NULL,
    [MEDGONDER]     VARCHAR (1)  NOT NULL
);

