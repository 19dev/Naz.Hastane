CREATE TABLE [dbo].[RAPORLAR] (
    [KNR]            VARCHAR (6)  NOT NULL,
    [SNR]            VARCHAR (3)  NOT NULL,
    [RAPORNO]        FLOAT        NOT NULL,
    [ACIKLAMA]       VARCHAR (50) NULL,
    [USER_ID]        CHAR (20)    NOT NULL,
    [DATE_CREATE]    DATETIME     NOT NULL,
    [USER_ID_UPDATE] CHAR (20)    NULL,
    [DATE_UPDATE]    DATETIME     NULL,
    [RAPOR]          TEXT         NULL
);

