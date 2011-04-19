CREATE TABLE [dbo].[ANAMNEZ] (
    [KNR]              VARCHAR (6)   NOT NULL,
    [SNR]              VARCHAR (3)   NOT NULL,
    [OZSOYGECMIS]      TEXT          NULL,
    [SISTEMSORGULARI]  TEXT          NULL,
    [MUAYENEBULGULARI] TEXT          NULL,
    [ONTANI]           VARCHAR (100) NULL,
    [TESHISVETEDAVI]   TEXT          NULL,
    [USER_ID]          VARCHAR (20)  NOT NULL,
    [DATE_CREATE]      DATETIME      NOT NULL,
    [USER_ID_UPDATE]   VARCHAR (20)  NULL,
    [DATE_UPDATE]      DATETIME      NULL
);

