CREATE TABLE [dbo].[DOKTORLAR_HAVUZ] (
    [HAVUZ_ID]    INT          IDENTITY (1, 1) NOT NULL,
    [HKNR]        VARCHAR (6)  NOT NULL,
    [KNR]         VARCHAR (6)  NOT NULL,
    [PAY]         FLOAT        NOT NULL,
    [ISODENDI]    CHAR (1)     NOT NULL,
    [USER_ID]     VARCHAR (20) NOT NULL,
    [DATE_CREATE] DATETIME     NOT NULL
);

