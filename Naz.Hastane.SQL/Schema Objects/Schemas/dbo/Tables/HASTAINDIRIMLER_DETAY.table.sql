CREATE TABLE [dbo].[HASTAINDIRIMLER_DETAY] (
    [HI_DET_ID] INT         IDENTITY (1, 1) NOT NULL,
    [HI_ID]     INT         NOT NULL,
    [KNR]       VARCHAR (6) NOT NULL,
    [SNR]       VARCHAR (3) NOT NULL,
    [SIRANO]    FLOAT       NOT NULL,
    [ESATISF]   FLOAT       NOT NULL,
    [YSATISF]   FLOAT       NOT NULL
);

