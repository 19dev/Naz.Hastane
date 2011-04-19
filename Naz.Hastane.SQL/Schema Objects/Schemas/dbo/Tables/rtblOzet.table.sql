CREATE TABLE [dbo].[rtblOzet] (
    [AYP]            VARCHAR (1)  NOT NULL,
    [lngKurumTipiID] INT          NULL,
    [lngAnaIslemID]  INT          NULL,
    [Doktor]         VARCHAR (4)  NOT NULL,
    [Hasta]          VARCHAR (9)  NOT NULL,
    [HastaneServis]  VARCHAR (2)  NOT NULL,
    [AY]             INT          NULL,
    [Adet]           FLOAT        NULL,
    [Toplam]         FLOAT        NULL,
    [TarihCode]      VARCHAR (10) NULL
);

