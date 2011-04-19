CREATE TABLE [dbo].[ITS_HAREKET] (
    [ITS_ID]      INT          NOT NULL,
    [TIP]         CHAR (2)     NOT NULL,
    [KNR]         VARCHAR (6)  NULL,
    [SNR]         VARCHAR (5)  NULL,
    [AKOD]        VARCHAR (2)  NOT NULL,
    [TANIM]       VARCHAR (2)  NOT NULL,
    [USER_ID]     VARCHAR (20) NOT NULL,
    [DATE_CREATE] DATETIME     NOT NULL
);

