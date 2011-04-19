CREATE TABLE [dbo].[TDISTEM] (
    [ISTEMNO]     INT           NOT NULL,
    [AKOD]        VARCHAR (2)   NOT NULL,
    [TANIM]       VARCHAR (2)   NOT NULL,
    [GRUP]        VARCHAR (3)   NOT NULL,
    [CODE]        VARCHAR (15)  NOT NULL,
    [NAME1]       VARCHAR (100) NOT NULL,
    [ADET]        FLOAT         NOT NULL,
    [MEVCUT]      FLOAT         NOT NULL,
    [MINIMUM]     FLOAT         NOT NULL,
    [FAR_KOD]     VARCHAR (4)   NOT NULL,
    [JEN_KOD]     VARCHAR (4)   NOT NULL,
    [TRANS]       VARCHAR (1)   NOT NULL,
    [USER_ID]     VARCHAR (20)  NOT NULL,
    [DATE_CREATE] DATETIME      NOT NULL
);

