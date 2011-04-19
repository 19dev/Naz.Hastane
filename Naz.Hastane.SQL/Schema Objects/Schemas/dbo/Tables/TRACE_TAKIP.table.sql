CREATE TABLE [dbo].[TRACE_TAKIP] (
    [RowNumber]       INT            IDENTITY (1, 1) NOT NULL,
    [EventClass]      INT            NULL,
    [TextData]        NTEXT          NULL,
    [NTUserName]      NVARCHAR (128) NULL,
    [ClientProcessID] INT            NULL,
    [ApplicationName] NVARCHAR (128) NULL,
    [LoginName]       NVARCHAR (128) NULL,
    [SPID]            INT            NULL,
    [Duration]        BIGINT         NULL,
    [StartTime]       DATETIME       NULL,
    [Reads]           BIGINT         NULL,
    [Writes]          BIGINT         NULL,
    [CPU]             INT            NULL,
    PRIMARY KEY CLUSTERED ([RowNumber] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);


GO
EXECUTE sp_addextendedproperty @name = N'Build', @value = 760, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TRACE_TAKIP';


GO
EXECUTE sp_addextendedproperty @name = N'MajorVer', @value = 8, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TRACE_TAKIP';


GO
EXECUTE sp_addextendedproperty @name = N'MinorVer', @value = 0, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TRACE_TAKIP';

