CREATE TABLE [dbo].[muh_donemler] (
    [donem]      VARCHAR (50) NOT NULL,
    [donemadi]   VARCHAR (50) NOT NULL,
    [tarih1]     VARCHAR (10) NULL,
    [tarih2]     VARCHAR (10) NULL,
    [secili]     BIT          NULL,
    [sirket]     VARCHAR (20) NOT NULL,
    [para_birim] VARCHAR (5)  NULL,
    [asil]       VARCHAR (1)  NOT NULL
);

