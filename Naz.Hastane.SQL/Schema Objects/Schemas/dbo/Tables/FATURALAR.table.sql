CREATE TABLE [dbo].[FATURALAR] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [KNR]           VARCHAR (6)   NULL,
    [SNR]           CHAR (6)      NULL,
    [ADRES]         VARCHAR (255) NULL,
    [FATURANO]      VARCHAR (20)  NULL,
    [FATURATARIHI]  DATETIME      NULL,
    [VERGIDAIRESI]  VARCHAR (20)  NULL,
    [VERGINUMARASI] VARCHAR (15)  NULL,
    [KDV0TUTAR]     FLOAT         NULL,
    [KDV8TUTAR]     FLOAT         NULL,
    [KDV18TUTAR]    FLOAT         NULL,
    [ftutar]        FLOAT         NULL,
    [kdvtutar]      FLOAT         NULL,
    [gtop]          FLOAT         NULL,
    [yaziile]       NCHAR (255)   NULL,
    [indtoplam]     FLOAT         NULL,
    [indsiztoplam]  FLOAT         NULL,
    [doviz]         VARCHAR (50)  NULL,
    [SEC]           BIT           NULL
);

