CREATE TABLE [dbo].[wsUBTIPDATA_Log] (
    [LID]         INT            IDENTITY (1, 1) NOT NULL,
    [METHOD]      VARCHAR (50)   NULL,
    [LOG_TEXT]    VARCHAR (5000) NULL,
    [DATE_CREATE] DATETIME       NULL
);

