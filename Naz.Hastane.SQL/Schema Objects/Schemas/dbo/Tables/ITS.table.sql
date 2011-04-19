CREATE TABLE [dbo].[ITS] (
    [ITS_ID]          INT             IDENTITY (1, 1) NOT NULL,
    [CODE]            VARCHAR (15)    NOT NULL,
    [SERINO]          VARCHAR (20)    NOT NULL,
    [ITS]             VARBINARY (200) NOT NULL,
    [YERDEGISTI]      BIT             NOT NULL,
    [GIRISBILDIRIM]   BIT             NOT NULL,
    [CIKISBILDIRIM]   BIT             NOT NULL,
    [GIRISBILDIRIMID] VARCHAR (20)    NULL,
    [CIKISBILDIRIMID] VARCHAR (20)    NULL,
    [UC]              VARCHAR (5)     NULL
);

