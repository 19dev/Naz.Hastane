﻿CREATE TABLE [dbo].[FORMOBJECTS] (
    [FORMNAME]      VARCHAR (50)  NOT NULL,
    [FORMTAG]       VARCHAR (50)  NOT NULL,
    [OBJECTNAME]    VARCHAR (50)  NOT NULL,
    [OBJECTTYPE]    VARCHAR (20)  NOT NULL,
    [TABNUMBER]     SMALLINT      NOT NULL,
    [OBJECTCAPTION] VARCHAR (100) NULL,
    [TARIH]         DATETIME      NOT NULL
);

